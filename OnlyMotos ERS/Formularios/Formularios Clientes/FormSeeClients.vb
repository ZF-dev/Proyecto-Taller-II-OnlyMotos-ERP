Public Class FormSeeClients
    Private Sub FormSeeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMockData()

    End Sub

    Private Sub LoadMockData()

        DGVClients.Rows.Clear()
        DGVClients.Rows.Add(1, "Juan", "Perez", "30123456", "juan.perez@email.com", "3794123456", "Activo")
        DGVClients.Rows.Add(2, "María", "Gómez", "38901234", "maria.gomez@email.com", "3794987654", "Activo")
        DGVClients.Rows.Add(3, "Carlos", "Rodríguez", "21122334", "crodriguez@email.com", "3794556677", "Inactivo")

    End Sub

    Private Sub TBSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSearch.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub DGVClients_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClients.CellValueChanged
        ' Evitar ejecuciones al cargar/limpiar la grilla
        If e.RowIndex < 0 Then Exit Sub

        Dim columnName As String = DGVClients.Columns(e.ColumnIndex).Name

        If columnName = "Nombre" OrElse columnName = "Apellido" OrElse columnName = "Telefono" OrElse columnName = "Email" Then
            Dim idCliente As Integer = Convert.ToInt32(DGVClients.Rows(e.RowIndex).Cells("id_cliente").Value)
            Dim nuevoValor As String = DGVClients.Rows(e.RowIndex).Cells(columnName).Value.ToString()

            ' MÁS ADELANTE EN BD: UPDATE Clientes SET [columnName] = @nuevoValor WHERE id_cliente = @idCliente
            Console.WriteLine($"Actualizando {columnName} = '{nuevoValor}' para el Cliente ID {idCliente}")

        End If
    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click

        If String.IsNullOrWhiteSpace(TBSearch.Text) Then

            MessageBox.Show("Ingrese un número de DNI para filtrar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearch.Focus()
            Exit Sub

        End If

        If Not ValidadorDNI.IsValidDNI(TBSearch.Text) Then
            MessageBox.Show("El DNI ingresado no es válido. Debe contener 7 u 8 dígitos.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearch.Focus()
            TBSearch.SelectAll()
            Exit Sub
        End If


        MessageBox.Show($"Filtrando cliente por DNI: {TBSearch.Text}", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click

        TBSearch.Clear()
        LoadMockData()

    End Sub

    Private Sub BAddClient_Click(sender As Object, e As EventArgs) Handles BAddClient.Click

        Dim manageForm As New FormManageClients()

        If manageForm.ShowDialog() = DialogResult.OK Then

            MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MÁS ADELANTE: Reconsultar BD
            LoadMockData()

        End If

    End Sub

    Private Sub BDeleteClient_Click(sender As Object, e As EventArgs) Handles BDeleteClient.Click

        If DGVClients.SelectedCells.Count = 0 Then

            MessageBox.Show("Seleccione un cliente para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim rowIndex As Integer = DGVClients.SelectedCells(0).RowIndex
        Dim clientName As String = DGVClients.Rows(rowIndex).Cells("Nombre").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de dar de baja al cliente '{clientName}'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            DGVClients.Rows(rowIndex).Cells("estado").Value = "Inactivo"
            MessageBox.Show("Cliente marcado como inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class