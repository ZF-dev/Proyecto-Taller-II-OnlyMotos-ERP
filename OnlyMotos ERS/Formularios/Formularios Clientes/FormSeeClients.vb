Public Class FormSeeClients
    Private Sub FormSeeClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarClientesGrid()

    End Sub

    Private Sub CargarClientesGrid()
        Try

            Dim negocio As New ClienteNegocio()
            DGVClients.DataSource = negocio.ObtenerClientes()

        Catch ex As Exception

            MessageBox.Show("Error al cargar la lista de clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub CargarClientesInactivosGrid()

        Try

            Dim negocio As New ClienteNegocio()
            DGVClients.DataSource = negocio.ObtenerClientesInactivos()

        Catch ex As Exception

            MessageBox.Show("Error al cargar la lista de clientes inactivos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub TBSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSearch.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub DGVClients_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClients.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub

        Dim columnName As String = DGVClients.Columns(e.ColumnIndex).Name

        If columnName = "Nombre" OrElse columnName = "Apellido" OrElse columnName = "Telefono" OrElse columnName = "Email" Then

            Try

                Dim row As DataGridViewRow = DGVClients.Rows(e.RowIndex)

                Dim idCliente As Integer = Convert.ToInt32(row.Cells("IdCliente").Value)
                Dim nombre As String = row.Cells("Nombre").Value.ToString()
                Dim apellido As String = row.Cells("Apellido").Value.ToString()
                Dim dni As String = row.Cells("DNI").Value.ToString()
                Dim email As String = row.Cells("Email").Value.ToString()
                Dim telefono = row.Cells("Telefono").Value.ToString()

                If String.IsNullOrWhiteSpace(nombre) OrElse IsNumeric(nombre) Then
                    CargarClientesGrid()
                    Exit Sub
                End If


                If String.IsNullOrWhiteSpace(apellido) OrElse IsNumeric(apellido) Then
                    CargarClientesGrid()
                    Exit Sub
                End If

                If Not ValidadorEmail.IsValidEmail(email) Then
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CargarClientesGrid()
                    Exit Sub
                End If

                If Not String.IsNullOrWhiteSpace(telefono) AndAlso Not IsNumeric(telefono) Then
                    MessageBox.Show("El teléfono debe contener solo números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CargarClientesGrid()
                    Exit Sub
                End If


                Dim negocio As New ClienteNegocio()
                negocio.ActualizarCliente(idCliente, nombre, apellido, dni, email, telefono)

                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al actualizar el cliente: Campo/dato no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CargarClientesGrid()

            End Try

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

        Try
            Dim negocio As New ClienteNegocio()

            DGVClients.DataSource = negocio.BuscarClientePorDni(TBSearch.Text.Trim())

            If DirectCast(DGVClients.DataSource, DataTable).Rows.Count = 0 Then

                MessageBox.Show("No se encontró ningún cliente con ese DNI.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarClientesGrid()

            End If

        Catch ex As Exception

            MessageBox.Show("Error al buscar el cliente: Error en la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click

        TBSearch.Clear()
        If RBActive.Checked Then

            CargarClientesGrid()

        Else

            CargarClientesInactivosGrid()

        End If

    End Sub

    Private Sub BAddClient_Click(sender As Object, e As EventArgs) Handles BAddClient.Click

        Dim manageForm As New FormManageClients()

        If manageForm.ShowDialog() = DialogResult.OK Then

            CargarClientesGrid()

        End If

    End Sub

    Private Sub BDeleteClient_Click(sender As Object, e As EventArgs) Handles BDeleteClient.Click

        If DGVClients.SelectedCells.Count = 0 Then

            MessageBox.Show("Seleccione un cliente para dar de baja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim rowIndex As Integer = DGVClients.SelectedCells(0).RowIndex
        Dim clientName As String = DGVClients.Rows(rowIndex).Cells("Nombre").Value.ToString()

        Dim idCliente As Integer = Convert.ToInt32(DGVClients.Rows(rowIndex).Cells("IdCliente").Value)

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de dar de baja al cliente '{clientName}'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try

                Dim negocio As New ClienteNegocio()

                negocio.CambiarEstadoInactivo(idCliente)

                CargarClientesGrid()

                MessageBox.Show("Cliente marcado como inactivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show("Error al dar de baja al cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub RBInactive_CheckedChanged(sender As Object, e As EventArgs) Handles RBInactive.CheckedChanged
        If RBInactive.Checked Then

            CargarClientesInactivosGrid()

            BActiveClient.Visible = True
            BDeleteClient.Visible = False

        End If
    End Sub

    Private Sub RBActive_CheckedChanged(sender As Object, e As EventArgs) Handles RBActive.CheckedChanged
        If RBActive.Checked Then

            CargarClientesGrid()
            BActiveClient.Visible = False
            BDeleteClient.Visible = True

        End If

    End Sub

    Private Sub BActiveClient_Click(sender As Object, e As EventArgs) Handles BActiveClient.Click
        If DGVClients.SelectedCells.Count = 0 Then

            MessageBox.Show("Seleccione un cliente de la lista para Reactivar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim rowIndex As Integer = DGVClients.SelectedCells(0).RowIndex

        Dim idCliente As Integer = Convert.ToInt32(DGVClients.Rows(rowIndex).Cells("IdCliente").Value)
        Dim clientName As String = DGVClients.Rows(rowIndex).Cells("Nombre").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de Reactivar al cliente '{clientName}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try

                Dim negocio As New ClienteNegocio()
                Dim exito As Boolean = negocio.CambiarEstadoActivo(idCliente)

                If exito Then

                    MessageBox.Show($"El cliente '{clientName}' ha sido marcado como Activo nuevamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Recargamos la grilla para ver los cambios reflejados desde el servidor
                    CargarClientesInactivosGrid()

                End If

            Catch ex As Exception

                MessageBox.Show("Error al procesar la baja: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class