Public Class FormSeeUsers
    Private Sub FormSeeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadMockData()
        DGVUsers.Rows.Clear()
        DGVUsers.Rows.Add(1, "Carlos", "Gómez", "35123456", "admin", "admin@onlymotos.com", "Administrador", "3794001122", "Activo")
        DGVUsers.Rows.Add(2, "Juan", "Pérez", "38987654", "jperez", "jperez@onlymotos.com", "Vendedor", "3794334455", "Activo")
        DGVUsers.Rows.Add(3, "María", "Rodríguez", "29555666", "mrodriguez", "mrodriguez@onlymotos.com", "Supervisor", "3794667788", "Inactivo")
    End Sub

    ' --- RESTRICCIÓN DE BÚSQUEDA: SOLO NÚMEROS (DNI) ---

    Private Sub TBSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSearch.KeyPress
        ' Permite únicamente dígitos numéricos y la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- CAPTURA DE EDICIÓN EN TIEMPO REAL DESDE EL DATAGRIDVIEW ---

    Private Sub DGVUsers_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsers.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub

        Dim columnName As String = DGVUsers.Columns(e.ColumnIndex).Name

        ' Validar y procesar cambios solo en los campos permitidos
        If columnName = "nombre" OrElse columnName = "apellido" OrElse columnName = "email" OrElse columnName = "telefono" Then
            Dim idUsuario As Integer = Convert.ToInt32(DGVUsers.Rows(e.RowIndex).Cells("id_usuario").Value)
            Dim nuevoValor As String = DGVUsers.Rows(e.RowIndex).Cells(columnName).Value.ToString()

            ' MÁS ADELANTE EN BD: UPDATE Usuarios SET [columnName] = @nuevoValor WHERE id_usuario = @idUsuario
            Console.WriteLine($"Actualizando campo '{columnName}' = '{nuevoValor}' para el Usuario ID {idUsuario}")
        End If
    End Sub

    ' --- BÚSQUEDA Y FILTRADO ---

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        If String.IsNullOrWhiteSpace(TBSearch.Text) Then
            MessageBox.Show("Ingrese un número de DNI para filtrar los usuarios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        MessageBox.Show($"Filtrando usuario por DNI: {TBSearch.Text}", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        TBSearch.Clear()
        LoadMockData()
    End Sub

    ' --- ACCIONES DEL MÓDULO (GBActions) ---

    Private Sub BAddUser_Click(sender As Object, e As EventArgs) Handles BAddUser.Click
        Dim manageUserForm As New FormManageUsers()
        If manageUserForm.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Usuario dado de alta exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MÁS ADELANTE: Reconsultar BD
            LoadMockData()
        End If
    End Sub

    Private Sub BDeleteUser_Click(sender As Object, e As EventArgs) Handles BDeleteUser.Click
        If DGVUsers.SelectedCells.Count = 0 Then
            MessageBox.Show("Seleccione un usuario de la lista para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = DGVUsers.SelectedCells(0).RowIndex
        Dim userName As String = DGVUsers.Rows(rowIndex).Cells("usuario").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de eliminar/dar de baja al usuario '{userName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DGVUsers.Rows(rowIndex).Cells("estado").Value = "Inactivo"
            ' MÁS ADELANTE EN BD: UPDATE Usuarios SET eliminado = 1 WHERE id_usuario = @idUsuario
            MessageBox.Show($"El usuario '{userName}' ha sido marcado como Inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

End Class