Imports System.IO
Imports System.Data
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports PdfSharp.Fonts


Public Class GeneradorReportePDF

    Private Shared fuenteRegistrada As Boolean = False

    Public Shared Sub GenerarReporteVentasUsuario(dt As DataTable)
        ' Usamos la ruta completa para evitar conflictos de librerías (Web vs Escritorio)
        Dim chartTemp As New System.Windows.Forms.DataVisualization.Charting.Chart()

        Try
            ' Registrar el FontResolver de manera segura si no se hizo antes
            If Not fuenteRegistrada Then
                GlobalFontSettings.FontResolver = New FileFontResolver()
                fuenteRegistrada = True
            End If

            ' 1. CONFIGURAR EL CHART EN MEMORIA
            chartTemp.Size = New System.Drawing.Size(600, 400)

            Dim area As New System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaPrincipal")
            chartTemp.ChartAreas.Add(area)

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

            chartTemp.Series.Add(serie)

            ' 2. GUARDAR EL CHART EN UN MEMORYSTREAM COMO IMAGEN PNG
            Using msChart As New MemoryStream()
                chartTemp.SaveImage(msChart, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png)
                msChart.Position = 0

                ' 3. ARMAR EL DOCUMENTO PDF CON PDFSHARP
                Using documento As New PdfDocument()
                    documento.Info.Title = "Reporte de Ventas por Usuario - OnlyMotos"

                    Dim pagina As PdfPage = documento.AddPage()
                    Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

                    Dim fuenteTitulo As New XFont("Verdana", 14)
                    Dim fuenteTexto As New XFont("Verdana", 10)
                    Dim fuenteDestacado As New XFont("Verdana", 10)

                    Dim xMargen As Double = 40
                    Dim yPos As Double = 40
                    Dim anchoPagina As Double = pagina.Width.Point
                    Dim altoPagina As Double = pagina.Height.Point

                    'Imagen de fondo
                    Dim directorioActual As New DirectoryInfo(Application.StartupPath)
                    Dim carpetaRecursos As String

                    If directorioActual.FullName.Contains("bin") Then

                        Dim raizProyecto = directorioActual.Parent?.Parent?.Parent?.FullName 'los parent son para subir niveles (subir en carpetas) en el path
                        If raizProyecto IsNot Nothing Then
                            carpetaRecursos = Path.Combine(raizProyecto, "Resources", "Icono-Logo_OnlyMotos Factura.jpg")

                            Using imagenLogo As XImage = XImage.FromFile(carpetaRecursos)
                                Dim anchoLogo As Double = 250
                                Dim altoLogo As Double = 120
                                Dim posX As Double = (anchoPagina - anchoLogo) / 2
                                Dim posY As Double = (altoPagina - altoLogo) / 2
                                gfx.DrawImage(imagenLogo, posX, posY, anchoLogo, altoLogo)
                            End Using

                        End If

                    End If

                    ' Título del Reporte
                    gfx.DrawString("REPORTE DE VENTAS POR USUARIO", fuenteTitulo, XBrushes.DarkBlue, xMargen, yPos)
                    yPos += 25

                    gfx.DrawLine(XPens.LightGray, xMargen, yPos, pagina.Width.Point - xMargen, yPos)
                    yPos += 20

                    ' Dibujar la imagen del Gráfico de Torta obtenida de la memoria
                    Using xImgGrafico As XImage = XImage.FromStream(msChart)
                        Dim anchoImg As Double = 400
                        Dim altoImg As Double = 260
                        Dim posXImg As Double = (pagina.Width.Point - anchoImg) / 2

                        gfx.DrawImage(xImgGrafico, posXImg, yPos, anchoImg, altoImg)
                        yPos += altoImg + 20
                    End Using

                    gfx.DrawLine(XPens.LightGray, xMargen, yPos, pagina.Width.Point - xMargen, yPos)
                    yPos += 15

                    ' ==========================================
                    ' NUEVO: DIBUJAR TABLA DE DATOS DEL DATATABLE
                    ' ==========================================
                    gfx.DrawString("DETALLE DE VENTAS:", fuenteDestacado, XBrushes.DarkBlue, New XPoint(xMargen, yPos))
                    yPos += 20

                    ' Definir anchos de columnas (asegúrate de que sumen aprox el ancho útil de la página)
                    Dim anchoCol1 As Double = 220
                    Dim anchoCol2 As Double = 100
                    Dim anchoCol3 As Double = 100
                    Dim totalTabla As Double = anchoCol1 + anchoCol2 + anchoCol3

                    ' Cabecera de la tabla (Fondo gris claro o línea de encabezado)
                    gfx.DrawRectangle(XBrushes.WhiteSmoke, xMargen, yPos, totalTabla, 18)
                    gfx.DrawString("Usuario", fuenteDestacado, XBrushes.Black, New XPoint(xMargen + 5, yPos + 13))
                    gfx.DrawString("Cant. Ventas", fuenteDestacado, XBrushes.Black, New XPoint(xMargen + anchoCol1 + 5, yPos + 13))
                    gfx.DrawString("Total Vendido", fuenteDestacado, XBrushes.Black, New XPoint(xMargen + anchoCol1 + anchoCol2 + 5, yPos + 13))
                    yPos += 18

                    ' Línea de cabecera
                    gfx.DrawLine(XPens.Gray, xMargen, yPos, xMargen + totalTabla, yPos)
                    yPos += 5

                    ' Recorrer el DataTable para pintar cada fila de la tabla
                    For Each row As DataRow In dt.Rows
                        Dim nombreUsr As String = row("Usuario").ToString()
                        Dim cantVentas As String = row("CantidadVentas").ToString()
                        Dim totalVendido As String = Convert.ToDecimal(row("TotalVendido")).ToString("C2") ' Formato moneda

                        gfx.DrawString(nombreUsr, fuenteTexto, XBrushes.Black, New XPoint(xMargen + 5, yPos + 12))
                        gfx.DrawString(cantVentas, fuenteTexto, XBrushes.Black, New XPoint(xMargen + anchoCol1 + 5, yPos + 12))
                        gfx.DrawString(totalVendido, fuenteTexto, XBrushes.Black, New XPoint(xMargen + anchoCol1 + anchoCol2 + 5, yPos + 12))

                        yPos += 16
                        ' Línea divisoria muy tenue entre filas
                        gfx.DrawLine(XPens.LightGray, xMargen, yPos, xMargen + totalTabla, yPos)
                        yPos += 4
                    Next

                    yPos += 10

                    ' Línea separadora inferior
                    gfx.DrawLine(XPens.LightGray, xMargen, yPos, pagina.Width.Point - xMargen, yPos)
                    yPos += 20

                    ' Resaltar abajo los datos clave del mejor usuario
                    gfx.DrawString("RESUMEN DE RENDIMIENTO (DESTACADO):", fuenteDestacado, XBrushes.DarkBlue, New XPoint(xMargen, yPos))
                    yPos += 22
                    gfx.DrawString($"• Usuario con Mayor Venta: {usuarioTop}", fuenteTexto, XBrushes.Black, New XPoint(xMargen, yPos))
                    yPos += 18
                    gfx.DrawString($"• Monto Total en Ventas realizadas: {maxVentas}", fuenteTexto, XBrushes.Black, New XPoint(xMargen, yPos))
                    yPos += 18
                    gfx.DrawString($"• Cantidad de Ventas Realizadas: {cantidadTop}", fuenteTexto, XBrushes.Black, New XPoint(xMargen, yPos))
                    yPos += 18
                    gfx.DrawString($"• Participación sobre el Total: {porcentajeTop:N2}%", fuenteTexto, XBrushes.Black, New XPoint(xMargen, yPos))

                    ' 4. GUARDAR Y ABRIR AUTOMÁTICAMENTE EL PDF
                    Dim rutaCarpeta As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OnlyMotos_Reportes")
                    If Not Directory.Exists(rutaCarpeta) Then
                        Directory.CreateDirectory(rutaCarpeta)
                    End If

                    Dim nombreArchivo As String = $"Reporte_VentasPorUsuario_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
                    Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

                    documento.Save(rutaCompleta)

                    MessageBox.Show("Reporte PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(rutaCompleta) With {.UseShellExecute = True})
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception("Error al generar el reporte de ventas: " & ex.Message)
        Finally
            ' Liberar los recursos de memoria del Chart de forma segura
            If chartTemp IsNot Nothing Then
                chartTemp.Dispose()
            End If
        End Try
    End Sub

End Class