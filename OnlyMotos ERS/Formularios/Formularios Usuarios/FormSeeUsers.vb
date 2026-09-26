Public Class FormSeeUsers
    Private Sub FormSeeUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuariosGrid()
    End Sub

    ' --- Funciones auxiliares de validación local ---
    Private Function IsAlphaSpace(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then Return False
        For Each ch As Char In value
            If Not Char.IsLetter(ch) AndAlso Not Char.IsWhiteSpace(ch) Then
                Return False
            End If
        Next
        Return True
    End Function


    Private Sub CargarUsuariosGrid()

        Try

            Dim negocio As New UsuarioNegocio()

            ' Asignamos directamente la DataTable devuelta por el negocio al DataGridView
            DGVUsers.DataSource = negocio.ObtenerListaUsuarios()

        Catch ex As Exception

            MessageBox.Show("Error al cargar la lista de usuarios: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub CargarUsuariosInactivosGrid()

        Try
            Dim negocio As New UsuarioNegocio()

            ' Asegúrate de que este nombre coincida con tu capa de negocio/datos (ej: ListarUsuariosInactivos)
            DGVUsers.DataSource = negocio.ObtenerListaUsuariosInactivos()

        Catch ex As Exception

            MessageBox.Show("Error al cargar la lista de usuarios inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

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
        If columnName = "Nombre" OrElse columnName = "Apellido" OrElse columnName = "Email" OrElse columnName = "Telefono" Then

            Try

                Dim idUsuario As Integer = Convert.ToInt32(DGVUsers.Rows(e.RowIndex).Cells("IdUsuario").Value)
                Dim celdaValor = DGVUsers.Rows(e.RowIndex).Cells(columnName).Value
                Dim nuevoValor As String = If(celdaValor Is Nothing, String.Empty, celdaValor.ToString())

                Select Case columnName
                    Case "Nombre", "Apellido"
                        ' Validar que solo contenga letras y espacios (sin números)
                        If String.IsNullOrWhiteSpace(nuevoValor) OrElse Not IsAlphaSpace(nuevoValor) Then
                            MessageBox.Show($"El campo {columnName} solo debe contener letras y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            CargarUsuariosGrid() ' Revierte el cambio visual
                            Exit Sub
                        End If

                    Case "Email"
                        ' Validar estructura de email usando el validador central
                        If String.IsNullOrWhiteSpace(nuevoValor) OrElse Not ValidadorEmail.IsValidEmail(nuevoValor) Then
                            MessageBox.Show("El formato del correo electrónico no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            CargarUsuariosGrid()
                            Exit Sub
                        End If

                    Case "Telefono"
                        ' Validar que sean solo números (puedes ajustar si usas guiones o espacios)
                        If Not String.IsNullOrEmpty(nuevoValor) AndAlso Not IsNumeric(nuevoValor) Then
                            MessageBox.Show("El teléfono solo debe contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            CargarUsuariosGrid()
                            Exit Sub
                        End If
                End Select

                Dim negocio As New UsuarioNegocio()
                Dim exito As Boolean = negocio.ModificarCampoUsuario(idUsuario, columnName, nuevoValor)

                If exito Then

                    CargarUsuariosGrid()  ' Refresca la grilla para reflejar los cambios desde el servidor

                End If

            Catch ex As Exception

                MessageBox.Show("Error al intentar actualizar la celda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    ' --- BÚSQUEDA Y FILTRADO ---

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        If String.IsNullOrWhiteSpace(TBSearch.Text) Then

            MessageBox.Show("Ingrese un número de DNI para filtrar los usuarios.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearch.Focus()
            Exit Sub

        End If

        If Not ValidadorDNI.IsValidDNI(TBSearch.Text) Then

            MessageBox.Show("El DNI ingresado no es válido. Debe contener 7 u 8 dígitos.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearch.Focus()
            TBSearch.SelectAll()
            Exit Sub

        End If

        Try

            Dim negocio As New UsuarioNegocio()
            Dim resultado As DataTable = negocio.ObtenerUsuarioPorDni(TBSearch.Text.Trim())

            ' Verificamos si la búsqueda arrojó resultados
            If resultado.Rows.Count > 0 Then

                DGVUsers.DataSource = resultado

            Else

                MessageBox.Show("DNI no registrado en el sistema.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TBSearch.Focus()
                TBSearch.SelectAll()

            End If

        Catch ex As Exception

            MessageBox.Show("Error al buscar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click

        TBSearch.Clear()
        If RBActive.Checked Then
            CargarUsuariosGrid()
        Else
            CargarUsuariosInactivosGrid()
        End If
        TBSearch.Focus()

    End Sub

    ' --- ACCIONES DEL MÓDULO (GBActions) ---

    Private Sub BAddUser_Click(sender As Object, e As EventArgs) Handles BAddUser.Click

        Dim manageUserForm As New FormManageUsers()

        If manageUserForm.ShowDialog() = DialogResult.OK Then

            CargarUsuariosGrid()

        End If

    End Sub

    Private Sub BDeleteUser_Click(sender As Object, e As EventArgs) Handles BDeleteUser.Click

        If DGVUsers.SelectedCells.Count = 0 Then

            MessageBox.Show("Seleccione un usuario de la lista para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim rowIndex As Integer = DGVUsers.SelectedCells(0).RowIndex

        Dim idUsuario As Integer = Convert.ToInt32(DGVUsers.Rows(rowIndex).Cells("IdUsuario").Value)
        Dim userName As String = DGVUsers.Rows(rowIndex).Cells("usuario").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de dar de baja al usuario '{userName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try

                Dim negocio As New UsuarioNegocio()
                Dim exito As Boolean = negocio.CambiarEstadoInactivo(idUsuario)

                If exito Then

                    MessageBox.Show($"El usuario '{userName}' ha sido marcado como Inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Recargamos la grilla para ver los cambios reflejados desde el servidor
                    CargarUsuariosGrid()

                End If

            Catch ex As Exception

                MessageBox.Show("Error al procesar la baja: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

    Private Sub RBInactive_CheckedChanged(sender As Object, e As EventArgs) Handles RBInactive.CheckedChanged
        If RBInactive.Checked Then

            CargarUsuariosInactivosGrid()

            BActiveUser.Visible = True
            BDeleteUser.Visible = False

        End If
    End Sub

    Private Sub RBActive_CheckedChanged(sender As Object, e As EventArgs) Handles RBActive.CheckedChanged
        If RBActive.Checked Then

            CargarUsuariosGrid()
            BActiveUser.Visible = False
            BDeleteUser.Visible = True

        End If

    End Sub

    Private Sub BActiveUser_Click(sender As Object, e As EventArgs) Handles BActiveUser.Click
        If DGVUsers.SelectedCells.Count = 0 Then

            MessageBox.Show("Seleccione un usuario de la lista para Reactivar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim rowIndex As Integer = DGVUsers.SelectedCells(0).RowIndex

        Dim idUsuario As Integer = Convert.ToInt32(DGVUsers.Rows(rowIndex).Cells("IdUsuario").Value)
        Dim userName As String = DGVUsers.Rows(rowIndex).Cells("usuario").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de Reactivar al usuario '{userName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try

                Dim negocio As New UsuarioNegocio()
                Dim exito As Boolean = negocio.CambiarEstadoActivo(idUsuario)

                If exito Then

                    MessageBox.Show($"El usuario '{userName}' ha sido marcado como Activo nuevamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Recargamos la grilla para ver los cambios reflejados desde el servidor
                    CargarUsuariosInactivosGrid()

                End If

            Catch ex As Exception

                MessageBox.Show("Error al procesar la baja: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
    End Sub
End Class