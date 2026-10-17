Public Class FormSellHistory
    Private Sub FormSellHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTPFromDate.Value = DateTime.Now.AddMonths(-1)
        DTPToDate.Value = DateTime.Now

        CargarGrillaVentas(Nothing, Nothing, String.Empty)
        GBDetailSells.Visible = False

    End Sub

    Private Sub CargarGrillaVentas(fechaDesde As Date?, fechaHasta As Date?, dni As String)

        Try

            Dim negocio As New VentaNegocio()
            DGVSellHeaders.DataSource = negocio.ObtenerVentas(fechaDesde, fechaHasta, dni)

            If DGVSellDetails.DataSource IsNot Nothing Then

                DirectCast(DGVSellDetails.DataSource, DataTable).Clear()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub DGVSellHeaders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSellHeaders.CellClick

        If e.RowIndex >= 0 Then

            Dim filaSeleccionada As DataGridViewRow = DGVSellHeaders.Rows(e.RowIndex)

            Dim idVenta As Integer = Convert.ToInt32(filaSeleccionada.Cells("id_venta").Value)

            Try

                Dim negocio As New VentaNegocio()
                DGVSellDetails.DataSource = negocio.ObtenerDetalleVenta(idVenta)
                GBDetailSells.Visible = True

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al cargar detalle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub TBSearchClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSearchClient.KeyPress
        ' Permite únicamente dígitos numéricos y la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub TBSearchClient_TextChanged(sender As Object, e As EventArgs) Handles TBSearchClient.TextChanged
        Dim dniBuscado As String = TBSearchClient.Text.Trim()

        If String.IsNullOrEmpty(dniBuscado) Then

            CargarGrillaVentas(Nothing, Nothing, String.Empty)
            Exit Sub

        End If

        If Not ValidadorDNI.IsValidDNI(dniBuscado) Then

            Exit Sub

        End If

        Dim fDesde As Date? = DTPFromDate.Value.Date
        Dim fHasta As Date? = DTPToDate.Value.Date

        CargarGrillaVentas(fDesde, fHasta, dniBuscado)

    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        DTPFromDate.Value = DateTime.Now.AddMonths(-1)
        DTPToDate.Value = DateTime.Now
        TBSearchClient.Clear()

        CargarGrillaVentas(Nothing, Nothing, String.Empty)
    End Sub

    Private Sub BAnnullSell_Click(sender As Object, e As EventArgs) Handles BAnnullSell.Click

        If DGVSellHeaders.SelectedRows.Count > 0 Then

            Dim filaSeleccionada As DataGridViewRow = DGVSellHeaders.SelectedRows(0)
            Dim idVenta As Integer = Convert.ToInt32(filaSeleccionada.Cells("id_venta").Value)

            Dim fechaVenta As DateTime = Convert.ToDateTime(filaSeleccionada.Cells("Fecha").Value)

            Dim diferenciaTiempo As TimeSpan = DateTime.Now - fechaVenta

            If diferenciaTiempo.TotalHours > 1 Then

                MessageBox.Show("No se puede anular la venta porque ya ha pasado más de una hora desde su emisión.", "Acción Denegada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If

            Dim respuesta As DialogResult = MessageBox.Show($"¿Estás seguro de que deseas anular la venta N° {idVenta}?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If respuesta = DialogResult.Yes Then

                Try

                    Dim negocio As New VentaNegocio()
                    negocio.AnularVenta(idVenta)

                    MessageBox.Show("La venta ha sido anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    CargarGrillaVentas(Nothing, Nothing, String.Empty)

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If

        Else
            MessageBox.Show("Por favor, selecciona una venta de la lista para anular.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

    Private Sub BReFactura_Click(sender As Object, e As EventArgs) Handles BReFactura.Click

        If DGVSellHeaders.SelectedRows.Count > 0 Then
            Dim filaVenta As DataGridViewRow = DGVSellHeaders.SelectedRows(0)

            If DGVSellDetails.DataSource Is Nothing OrElse DGVSellDetails.Rows.Count = 0 Then

                MessageBox.Show("No se encontró el detalle de la venta seleccionada para reimprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub

            End If

            Try

                Dim numVenta As Integer = Convert.ToInt32(filaVenta.Cells("id_venta").Value)
                Dim tipoFactura As String = filaVenta.Cells("Tipo de Comprobante").Value.ToString()
                Dim nombreUsuario As String = filaVenta.Cells("Usuario").Value.ToString()
                Dim nombreCliente As String = filaVenta.Cells("Cliente").Value.ToString()
                Dim fechaVenta As DateTime = Convert.ToDateTime(filaVenta.Cells("Fecha").Value)
                Dim totalVenta As Decimal = Convert.ToDecimal(filaVenta.Cells("Total").Value)

                Dim dtDetalle As DataTable = DirectCast(DGVSellDetails.DataSource, DataTable)

                GeneradorFacturaPDF.GenerarComprobante(tipoFactura, nombreCliente, nombreUsuario, fechaVenta, dtDetalle, totalVenta, numVenta)

            Catch ex As Exception
                MessageBox.Show("Error al intentar reimprimir la factura: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Por favor, selecciona una venta de la lista para reimprimir su factura.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

End Class