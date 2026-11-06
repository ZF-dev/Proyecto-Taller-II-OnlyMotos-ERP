Public Class GeneradorReportes

    Public Shared Sub GenerarReporteVentasUsuario(dt As DataTable, chartVisual As System.Windows.Forms.DataVisualization.Charting.Chart, dgvTabla As DataGridView, lblUsuarioTop As Label, lblMontoTop As Label, lblCantTop As Label, lblPorcentajeTop As Label)

        Try


            chartVisual.ChartAreas.Clear()
            chartVisual.Series.Clear()

            Dim area As New System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaPrincipal")
            chartVisual.ChartAreas.Add(area)

            Dim serie As New System.Windows.Forms.DataVisualization.Charting.Series("VentasUsuario")
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            serie.IsValueShownAsLabel = True
            serie.Label = "#VALX: #PERCENT"

            ' Variables para calcular estadísticas
            Dim totalGeneral As Decimal = 0

            For Each r As DataRow In dt.Rows

                totalGeneral += Convert.ToDecimal(r("TotalVendido"))

            Next

            Dim usuarioTop As String = ""
            Dim maxVentas As Decimal = -1
            Dim cantidadTop As Integer = 0
            Dim porcentajeTop As Decimal = 0

            ' Poblar puntos del gráfico y calcular el mayor
            For Each row As DataRow In dt.Rows

                Dim nombreUsuario As String = row("Usuario").ToString()
                Dim totalVendidoUsuario As Decimal = Convert.ToDecimal(row("TotalVendido"))
                Dim cantVentasUsuario As Integer = Convert.ToInt32(row("CantidadVentas"))

                serie.Points.AddXY(nombreUsuario, totalVendidoUsuario)

                If totalVendidoUsuario > maxVentas Then

                    maxVentas = totalVendidoUsuario
                    usuarioTop = nombreUsuario
                    cantidadTop = cantVentasUsuario

                    If totalGeneral > 0 Then

                        porcentajeTop = (totalVendidoUsuario / totalGeneral) * 100

                    End If

                End If

            Next

            chartVisual.Series.Add(serie)
            chartVisual.Titles.Clear()
            chartVisual.Titles.Add("REPORTE DE VENTAS POR USUARIO")


            dgvTabla.DataSource = dt


            If lblUsuarioTop IsNot Nothing Then lblUsuarioTop.Text = $"• Usuario con Mayor Venta: {usuarioTop}"
            If lblMontoTop IsNot Nothing Then lblMontoTop.Text = $"• Monto Total en Ventas realizadas: {maxVentas:C2}"
            If lblCantTop IsNot Nothing Then lblCantTop.Text = $"• Cantidad de Ventas Realizadas: {cantidadTop}"
            If lblPorcentajeTop IsNot Nothing Then lblPorcentajeTop.Text = $"• Participación sobre el Total: {porcentajeTop:N2}%"

        Catch ex As Exception

            MessageBox.Show("Error al cargar el reporte en pantalla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

End Class
