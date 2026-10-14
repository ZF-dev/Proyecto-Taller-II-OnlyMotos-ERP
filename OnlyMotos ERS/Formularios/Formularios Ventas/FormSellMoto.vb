Public Class FormSellMoto

    Private dtDetalleVenta As New DataTable()
    Private Sub FormSellMoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialData()
    End Sub

    Private Sub LoadInitialData()

        Try

            TBUser.Text = CurrentUserName

            CargarComboTipoFactura()

            CargarComboClientes()

            CargarComboMotos()

            InicializarGrillaDetalle()

            CBTicketType.SelectedIndex = -1
            CBClient.SelectedIndex = -1
            CBMoto.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show("Error al inicializar el formulario de ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub CargarComboTipoFactura()

        Dim negocio As New VentaNegocio()
        CBTicketType.DataSource = negocio.ObtenerTiposFactura()
        CBTicketType.DisplayMember = "tipo"
        CBTicketType.ValueMember = "id_tipo_factura"

    End Sub

    Private Sub CargarComboClientes()

        Dim negocio As New VentaNegocio()
        CBClient.DataSource = negocio.ListarClientesParaCombo()
        CBClient.DisplayMember = "nombre_completo"
        CBClient.ValueMember = "id_cliente"

    End Sub

    Private Sub CargarComboMotos()

        Dim negocio As New VentaNegocio()
        CBMoto.DataSource = negocio.ObtenerMotosDisponibles()
        CBMoto.DisplayMember = "modelo"
        CBMoto.ValueMember = "id_moto"

    End Sub

    Private Sub InicializarGrillaDetalle()

        dtDetalleVenta.Columns.Add("id_moto", GetType(Integer))
        dtDetalleVenta.Columns.Add("Modelo", GetType(String))
        dtDetalleVenta.Columns.Add("Precio Unitario", GetType(Decimal))
        dtDetalleVenta.Columns.Add("Cantidad", GetType(Integer))
        dtDetalleVenta.Columns.Add("SubTotal", GetType(Decimal))

    End Sub

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TBUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBUnitPrice.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub BAddProduct_Click(sender As Object, e As EventArgs) Handles BAddProduct.Click

        If String.IsNullOrWhiteSpace(CBMoto.Text) OrElse String.IsNullOrWhiteSpace(TBUnitPrice.Text) OrElse String.IsNullOrWhiteSpace(CBClient.Text) Then

            MessageBox.Show("Por favor, complete todos los campos del producto.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim idMoto As Integer = Convert.ToInt32(CBMoto.SelectedValue)
        Dim cantidad As Integer = Convert.ToInt32(NUDQuantity.Value)
        Dim precioUnitario As Decimal = Convert.ToDecimal(TBUnitPrice.Text)
        Dim modeloMoto As String = CBMoto.Text

        Dim negocio As New VentaNegocio()
        Dim stockDescontadoOk As Boolean = negocio.ProcesarDescuentoStock(idMoto, cantidad)

        If Not stockDescontadoOk Then

            MessageBox.Show("No hay suficiente stock disponible para cubrir la cantidad solicitada.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CargarComboMotos()
            Exit Sub

        End If


        Dim subtotal As Decimal = precioUnitario * cantidad
        Dim filaExistente As DataRow = Nothing

        For Each row As DataRow In dtDetalleVenta.Rows

            If Convert.ToInt32(row("id_moto")) = idMoto Then

                filaExistente = row
                Exit For

            End If

        Next

        If filaExistente IsNot Nothing Then

            Dim nuevaCantidad As Integer = Convert.ToInt32(filaExistente("Cantidad")) + cantidad
            filaExistente("Cantidad") = nuevaCantidad
            filaExistente("SubTotal") = nuevaCantidad * precioUnitario

        Else

            Dim nuevaFila As DataRow = dtDetalleVenta.NewRow()
            nuevaFila("id_moto") = idMoto
            nuevaFila("Modelo") = modeloMoto
            nuevaFila("Precio Unitario") = precioUnitario
            nuevaFila("Cantidad") = cantidad
            nuevaFila("SubTotal") = subtotal
            dtDetalleVenta.Rows.Add(nuevaFila)

        End If

        DGVDetails.Rows.Clear()

        For Each row As DataRow In dtDetalleVenta.Rows

            Dim nRowIndex As Integer = DGVDetails.Rows.Add()
            DGVDetails.Rows(nRowIndex).Cells("Model").Value = row("Modelo")
            DGVDetails.Rows(nRowIndex).Cells("Price").Value = row("Precio Unitario")
            DGVDetails.Rows(nRowIndex).Cells("Quantity").Value = row("Cantidad")
            DGVDetails.Rows(nRowIndex).Cells("SubTotal").Value = row("SubTotal")

            DGVDetails.Rows(nRowIndex).Cells("IdMoto").Value = row("id_moto")
        Next

        CalculateTotal()

        CBMoto.SelectedIndex = -1
        TBUnitPrice.Clear()
        NUDQuantity.Value = 1
        CargarComboMotos()

    End Sub

    Private Sub BRemoveProduct_Click(sender As Object, e As EventArgs) Handles BRemoveProduct.Click

        If DGVDetails.SelectedRows.Count > 0 Then

            Dim index As Integer = DGVDetails.SelectedRows(0).Index

            If Not DGVDetails.Rows(index).IsNewRow Then

                Dim rowSeleccionada As DataGridViewRow = DGVDetails.Rows(index)
                Dim idMoto As Integer = Convert.ToInt32(rowSeleccionada.Cells("IdMoto").Value)
                Dim cantidadDevolver As Integer = Convert.ToInt32(rowSeleccionada.Cells("Quantity").Value)


                Dim negocio As New VentaNegocio()
                negocio.ReintegrarStock(idMoto, cantidadDevolver)


                dtDetalleVenta.Rows.RemoveAt(index)


                CalculateTotal()

                If dtDetalleVenta.Rows.Count = 0 Then

                    DGVDetails.Rows.Clear()

                Else

                    For Each row As DataRow In dtDetalleVenta.Rows

                        Dim nRowIndex As Integer = DGVDetails.Rows.Add()
                        DGVDetails.Rows(nRowIndex).Cells("Model").Value = row("Modelo")
                        DGVDetails.Rows(nRowIndex).Cells("Price").Value = row("Precio Unitario")
                        DGVDetails.Rows(nRowIndex).Cells("Quantity").Value = row("Cantidad")
                        DGVDetails.Rows(nRowIndex).Cells("SubTotal").Value = row("SubTotal")

                        DGVDetails.Rows(nRowIndex).Cells("IdMoto").Value = row("id_moto")
                    Next

                End If

                CargarComboMotos()

                MessageBox.Show("Producto removido y stock reintegrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        Else

            MessageBox.Show("Seleccione una fila de la grilla para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub CalculateTotal()
        Dim totalGeneral As Decimal = 0

        For Each row As DataRow In dtDetalleVenta.Rows
            totalGeneral += Convert.ToDecimal(row("SubTotal"))
        Next

        TBTotal.Text = totalGeneral.ToString("N2")
    End Sub

    Private Sub BSaveSell_Click(sender As Object, e As EventArgs) Handles BSaveSell.Click

        If DGVDetails.Rows.Count = 0 Then

            MessageBox.Show("Debe agregar al menos una moto para registrar la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        Try

            Dim idCliente As Integer = Convert.ToInt32(CBClient.SelectedValue)
            Dim idTipoFactura As Integer = Convert.ToInt32(CBTicketType.SelectedValue)

            Dim idUsuario As Integer = ModuleSession.CurrentUserId
            Dim fechaVenta As DateTime = DTPDate.Value
            Dim totalVenta As Decimal = Convert.ToDecimal(TBTotal.Text)

            Dim negocio As New VentaNegocio()
            Dim exito As Boolean = negocio.GuardarVenta(idUsuario, idCliente, idTipoFactura, fechaVenta, totalVenta, dtDetalleVenta)

            If exito Then

                MessageBox.Show("¡Venta registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try

                    Dim tipoFacturaStr As String = CBTicketType.Text
                    Dim clienteStr As String = CBClient.Text

                    GeneradorFacturaPDF.GenerarComprobante(tipoFacturaStr, clienteStr, TBUser.Text, fechaVenta, dtDetalleVenta, totalVenta)

                Catch pdfEx As Exception

                    MessageBox.Show("La venta se guardó, pero hubo un error al crear el PDF: " & pdfEx.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                End Try

                dtDetalleVenta.Clear()
                DGVDetails.Rows.Clear()
                TBTotal.Clear()
                CBClient.SelectedIndex = -1
                CBTicketType.SelectedIndex = -1
                CBMoto.SelectedIndex = -1

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        If dtDetalleVenta.Rows.Count > 0 Then

            Dim resultado As DialogResult = MessageBox.Show("¿Desea cancelar la venta? Los productos agregados se devolverán al inventario.", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then

                Try

                    Dim negocio As New VentaNegocio()


                    For Each row As DataRow In dtDetalleVenta.Rows

                        Dim idMoto As Integer = Convert.ToInt32(row("id_moto"))
                        Dim cantidadDevolver As Integer = Convert.ToInt32(row("Cantidad"))


                        negocio.ReintegrarStock(idMoto, cantidadDevolver)

                    Next

                    MessageBox.Show("Stock devuelto al inventario correctamente.", "Cancelación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception

                    MessageBox.Show("Error al reintegrar el stock durante la cancelación: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            End If
        Else

            Me.Close()

        End If

    End Sub

    Private Sub BAddClient_Click(sender As Object, e As EventArgs) Handles BAddClient.Click
        Dim manageClientForm As New FormManageClients()
        If manageClientForm.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Cliente dado de alta exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarComboClientes()
        End If
    End Sub


    Private Sub CBMoto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMoto.SelectedIndexChanged

        If CBMoto.SelectedIndex <> -1 AndAlso CBMoto.SelectedValue IsNot Nothing Then

            Dim idMoto As Integer

            If Integer.TryParse(CBMoto.SelectedValue.ToString(), idMoto) Then

                Try
                    Dim negocio As New VentaNegocio()
                    Dim dtMoto As DataTable = negocio.ObtenerDatosMotoPorId(idMoto)

                    If dtMoto.Rows.Count > 0 Then
                        Dim row As DataRow = dtMoto.Rows(0)

                        TBUnitPrice.Text = row("precio").ToString()

                        Dim stockDisponible As Integer = Convert.ToInt32(row("stock"))
                        NUDStock.Value = stockDisponible

                    End If

                Catch ex As Exception

                    MessageBox.Show("Error al obtener los datos de la moto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try

            End If
        Else

            TBUnitPrice.Clear()
            NUDStock.Value = 0

        End If
    End Sub

End Class