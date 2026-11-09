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


            lblUsuarioTop.Text = $"• Usuario con Mayor Venta: {usuarioTop}"
            lblMontoTop.Text = $"• Monto Total en Ventas realizadas: {maxVentas:C2}"
            lblCantTop.Text = $"• Cantidad de Ventas Realizadas: {cantidadTop}"
            lblPorcentajeTop.Text = $"• Participación sobre el Total: {porcentajeTop:N2}%"

        Catch ex As Exception

            MessageBox.Show("Error al cargar el reporte en pantalla: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Shared Sub GenerarReporteGanancias(dtVentas As DataTable, dtCompras As DataTable, dgvTabla As DataGridView, chartVisual As System.Windows.Forms.DataVisualization.Charting.Chart, lblGananciaNeta As Label, lblInversion As Label, lblVentas As Label)

        Try

            chartVisual.ChartAreas.Clear()
            chartVisual.Series.Clear()

            Dim area As New System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaGanancias")
            area.AxisY.LabelStyle.Format = "C0"
            area.AxisY.IsLabelAutoFit = True
            chartVisual.ChartAreas.Add(area)

            Dim serie As New System.Windows.Forms.DataVisualization.Charting.Series("GananciasVsInversion")
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            serie.IsValueShownAsLabel = True

            Dim totalVentas As Decimal = 0
            For Each row As DataRow In dtVentas.Rows

                totalVentas += Convert.ToDecimal(row("total"))

            Next

            Dim totalInversion As Decimal = 0
            For Each row As DataRow In dtCompras.Rows

                Dim precioVentaMoto As Decimal = Convert.ToDecimal(row("precio"))
                Dim costoEstimado As Decimal = (precioVentaMoto / 1.15D) * Convert.ToInt16(row("stock"))
                totalInversion += costoEstimado

            Next

            ' Configurar las dos torres en el gráfico (se hacen de a dos, pq si lo hago en una misma serie las agrupa y se superponen)
            ' 3. Crear SERIE 1: Inversión 
            Dim serieInversion As New System.Windows.Forms.DataVisualization.Charting.Series("Inversión")
            serieInversion.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            serieInversion.IsValueShownAsLabel = True
            serieInversion.LabelFormat = "C0"
            serieInversion.Points.AddXY("Inversión (Costo)", totalInversion)
            serieInversion.Points(0).Color = Color.IndianRed
            chartVisual.Series.Add(serieInversion)

            ' 4. Crear SERIE 2: Ventas
            Dim serieVentas As New System.Windows.Forms.DataVisualization.Charting.Series("Ventas")
            serieVentas.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            serieVentas.IsValueShownAsLabel = True
            serieVentas.LabelFormat = "C0"
            serieVentas.Points.AddXY("Ventas (Ingresos)", totalVentas)
            serieVentas.Points(0).Color = Color.SeaGreen
            chartVisual.Series.Add(serieVentas)


            chartVisual.Titles.Clear()
            chartVisual.Titles.Add("BALANCE DE GANANCIAS E INVERSIÓN")

            'cargo el dtg con los datos de las ventas
            dgvTabla.DataSource = dtVentas

            ' Calcular ganancia neta y actualizar etiquetas
            Dim gananciaNeta As Decimal = totalVentas - totalInversion

            lblInversion.Font = New Font(lblInversion.Font, FontStyle.Bold)
            lblInversion.Text = $"• Inversión Total Estimada: {totalInversion:C2}"



            lblVentas.Font = New Font(lblVentas.Font, FontStyle.Bold)
            lblVentas.Text = $"• Ingresos Totales por Ventas: {totalVentas:C2}"



            lblGananciaNeta.Font = New Font(lblGananciaNeta.Font, FontStyle.Bold)
            Dim textoGanancia As String = If(gananciaNeta >= 0, $"¡Ganancia Neta: {gananciaNeta:C2}!", $"Pérdida Neta: {gananciaNeta:C2}")
            lblGananciaNeta.Text = $"• {textoGanancia}"
            lblGananciaNeta.ForeColor = If(gananciaNeta >= 0, Color.DarkGreen, Color.DarkRed)


        Catch ex As Exception

            MessageBox.Show("Error al procesar el reporte de ganancias: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Shared Sub GenerarReporteVentas(dtVentas As DataTable, dgvTabla As DataGridView, chartVisual As System.Windows.Forms.DataVisualization.Charting.Chart, LTotalVentas As Label, LCantidadVentas As Label, LVentaDestacada As Label, Titulo As String)

        Try
            chartVisual.ChartAreas.Clear()
            chartVisual.Series.Clear()

            Dim area As New System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaTiempo")

            ' Configuramos el eje X para que interprete fechas correctamente si es necesario
            area.AxisX.LabelStyle.Format = "dd/MM/yyyy"
            area.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
            chartVisual.ChartAreas.Add(area)

            ' Creamos la serie de tipo Línea
            Dim serieLinea As New System.Windows.Forms.DataVisualization.Charting.Series("Evolución de Ventas")
            serieLinea.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line

            ' Habilitamos los marcadores (los "puntos rojos/visibles" sobre la línea como en tu imagen)
            serieLinea.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
            serieLinea.MarkerSize = 8
            serieLinea.MarkerColor = Color.Red

            ' Color de la línea y grosor
            serieLinea.Color = Color.OrangeRed
            serieLinea.BorderWidth = 3

            ' Mostrar los valores numéricos de cantidad arriba de cada marcador
            serieLinea.IsValueShownAsLabel = True

            ' Variables acumuladoras para los labels
            Dim sumaCantidadTotal As Integer = 0
            Dim sumaDineroTotal As Decimal = 0

            ' Variables para detectar el día destacado
            Dim maxDinero As Decimal = -1
            Dim fechaDestacada As String = ""

            ' Recorremos el DataTable y poblamos el gráfico
            For Each row As DataRow In dtVentas.Rows

                Dim fecha As DateTime = Convert.ToDateTime(row("FechaVenta"))
                Dim cantidad As Integer = Convert.ToInt32(row("CantidadVentas"))
                Dim dineroDia As Decimal = Convert.ToDecimal(row("TotalDinero"))

                ' Añadimos el punto al gráfico
                serieLinea.Points.AddXY(fecha, cantidad)

                ' Acumulamos valores para los resúmenes
                sumaCantidadTotal += cantidad
                sumaDineroTotal += dineroDia

                ' Lógica para hallar el día que generó más dinero
                If dineroDia > maxDinero Then
                    maxDinero = dineroDia
                    fechaDestacada = fecha.ToString("dd/MM/yyyy")
                End If

            Next

            chartVisual.Series.Add(serieLinea)

            chartVisual.Titles.Clear()
            chartVisual.Titles.Add($"{Titulo}")

            'cargo el dtg con los datos de las ventas
            dgvTabla.DataSource = dtVentas


            'Labels
            LCantidadVentas.Font = New Font(LCantidadVentas.Font, FontStyle.Bold)
            LCantidadVentas.Text = $"• Cantidad Total de Ventas: {sumaCantidadTotal}"

            LTotalVentas.Font = New Font(LTotalVentas.Font, FontStyle.Bold)
            LTotalVentas.Text = $"• Ingresos Totales: {sumaDineroTotal:C2}"


            LVentaDestacada.Font = New Font(LVentaDestacada.Font, FontStyle.Bold)
            LVentaDestacada.Text = $"• Día Destacado: {fechaDestacada} ({maxDinero:C2})"

        Catch ex As Exception

            MessageBox.Show("Error al cargar el gráfico de línea: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Shared Sub GenerarReporteRestauraciones(dtRestauraciones As DataTable, dgvTabla As DataGridView, chartVisual As System.Windows.Forms.DataVisualization.Charting.Chart, LDiaMaxRestauraciones As Label)
        Try
            chartVisual.ChartAreas.Clear()
            chartVisual.Series.Clear()

            Dim area As New System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaRestauraciones")
            area.AxisX.LabelStyle.Format = "dd/MM/yyyy"
            area.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
            chartVisual.ChartAreas.Add(area)

            Dim serieLinea As New System.Windows.Forms.DataVisualization.Charting.Series("Restauraciones")
            serieLinea.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
            serieLinea.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
            serieLinea.MarkerSize = 8
            serieLinea.MarkerColor = Color.DarkBlue
            serieLinea.Color = Color.RoyalBlue
            serieLinea.BorderWidth = 3
            serieLinea.IsValueShownAsLabel = True

            ' Variables para detectar el día con mayor cantidad de restauraciones
            Dim maxCantidad As Integer = -1
            Dim fechaMaxRestauracion As String = ""

            ' Recorremos el DataTable y poblamos el gráfico
            For Each row As DataRow In dtRestauraciones.Rows
                Dim fecha As DateTime = Convert.ToDateTime(row("FechaRestauracion"))
                Dim cantidad As Integer = Convert.ToInt32(row("CantidadRestauraciones"))

                ' Añadimos el punto al gráfico
                serieLinea.Points.AddXY(fecha, cantidad)

                ' Lógica para hallar el día récord de restauraciones
                If cantidad > maxCantidad Then
                    maxCantidad = cantidad
                    fechaMaxRestauracion = fecha.ToString("dd/MM/yyyy")
                End If
            Next

            chartVisual.Series.Add(serieLinea)
            chartVisual.Titles.Clear()
            chartVisual.Titles.Add("AUDITORÍA DE RESTAURACIONES EN EL TIEMPO")

            ' Cargamos la grilla
            dgvTabla.DataSource = dtRestauraciones

            ' Asignación del Label Destacado (solo la fecha y la mayor cantidad)
            LDiaMaxRestauraciones.Font = New Font(LDiaMaxRestauraciones.Font, FontStyle.Bold)

            LDiaMaxRestauraciones.Text = $"• Día con más restauraciones: {fechaMaxRestauracion} ({maxCantidad} respaldos)"

        Catch ex As Exception

            MessageBox.Show("Error al cargar el reporte de restauraciones: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class
