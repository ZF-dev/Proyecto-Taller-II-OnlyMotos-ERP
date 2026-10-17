Imports System.IO
Imports System.Windows.Forms
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports PdfSharp.Fonts

Public Class GeneradorFacturaPDF

    Private Shared fuenteRegistrada As Boolean = False

    Public Shared Sub GenerarComprobante(tipoFactura As String, nombreCliente As String, nombreUsuario As String, fechaVenta As DateTime, dtDetalle As DataTable, totalVenta As Decimal, numVenta As Integer)
        Try
            ' Registrar el FontResolver de manera segura y única
            If Not fuenteRegistrada Then
                GlobalFontSettings.FontResolver = New FileFontResolver()
                fuenteRegistrada = True
            End If

            Dim documento As New PdfDocument()
            documento.Info.Title = "Comprobante de Venta - OnlyMotos"

            Dim pagina As PdfPage = documento.AddPage()
            Dim gfx As XGraphics = XGraphics.FromPdfPage(pagina)

            ' Fuentes tipográficas estándar de Windows
            Dim fuenteTitulo As New XFont("Verdana", 16)
            Dim fuenteSubtitulo As New XFont("Verdana", 10)
            Dim fuenteTexto As New XFont("Verdana", 9)
            Dim fuenteTotal As New XFont("Verdana", 12)

            Dim yPos As Double = 40
            Dim xMargen As Double = 40
            Dim anchoPagina As Double = pagina.Width.Point

            ' --- ENCABEZADO ---
            gfx.DrawString("ONLYMOTOS S.A.", fuenteTitulo, XBrushes.DarkBlue, xMargen, yPos)
            yPos += 20
            gfx.DrawString("Sistema de Gestión de Ventas", fuenteSubtitulo, XBrushes.Gray, xMargen, yPos)
            yPos += 30

            gfx.DrawLine(XPens.LightGray, xMargen, yPos, anchoPagina - xMargen, yPos)
            yPos += 20

            ' --- DATOS DE LA VENTA Y CLIENTE ---
            gfx.DrawString($"Numero de Venta: {numVenta}", fuenteTexto, XBrushes.Black, xMargen, yPos)
            yPos += 20
            gfx.DrawString($"Tipo de Factura: {tipoFactura.ToUpper()}", fuenteTexto, XBrushes.Black, xMargen, yPos)
            gfx.DrawString($"Fecha: {fechaVenta:dd/MM/yyyy HH:mm}", fuenteTexto, XBrushes.Black, xMargen + 250, yPos)
            yPos += 20

            gfx.DrawString($"Cliente: {nombreCliente}", fuenteTexto, XBrushes.Black, xMargen, yPos)
            yPos += 15
            gfx.DrawString($"Atendido por: {nombreUsuario}", fuenteTexto, XBrushes.Black, xMargen, yPos)
            yPos += 30

            ' --- TABLA DE DETALLE (CABECERA) ---
            gfx.DrawRectangle(XBrushes.LightSlateGray, xMargen, yPos, anchoPagina - (xMargen * 2), 20)
            gfx.DrawString("Modelo", fuenteTexto, XBrushes.White, xMargen + 5, yPos + 14)
            gfx.DrawString("Cant.", fuenteTexto, XBrushes.White, xMargen + 260, yPos + 14)
            gfx.DrawString("P. Unitario", fuenteTexto, XBrushes.White, xMargen + 320, yPos + 14)
            gfx.DrawString("SubTotal", fuenteTexto, XBrushes.White, xMargen + 420, yPos + 14)
            yPos += 25

            ' --- ITEMS DEL DETALLE ---
            For Each row As DataRow In dtDetalle.Rows
                Dim modelo As String = row("Modelo").ToString()
                Dim cantidad As String = row("Cantidad").ToString()
                Dim pUnit As String = Convert.ToDecimal(row("Precio Unitario")).ToString("N2")
                Dim subTotal As String = Convert.ToDecimal(row("SubTotal")).ToString("N2")

                gfx.DrawString(modelo, fuenteTexto, XBrushes.Black, xMargen + 5, yPos)
                gfx.DrawString(cantidad, fuenteTexto, XBrushes.Black, xMargen + 260, yPos)
                gfx.DrawString($"$ {pUnit}", fuenteTexto, XBrushes.Black, xMargen + 320, yPos)
                gfx.DrawString($"$ {subTotal}", fuenteTexto, XBrushes.Black, xMargen + 420, yPos)

                yPos += 20
            Next

            ' Línea final de tabla
            yPos += 10
            gfx.DrawLine(XPens.DarkGray, xMargen, yPos, anchoPagina - xMargen, yPos)
            yPos += 25

            ' --- TOTAL GENERAL ---
            gfx.DrawString($"TOTAL GENERAL: $ {totalVenta:N2}", fuenteTotal, XBrushes.DarkRed, anchoPagina - xMargen - 220, yPos)

            ' --- PIE DE PÁGINA ---
            yPos += 60
            gfx.DrawString("¡Gracias por su compra en OnlyMotos ERP!", fuenteSubtitulo, XBrushes.Gray, xMargen + 130, yPos)

            ' Ruta de guardado en Mis Documentos
            Dim rutaCarpeta As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OnlyMotos_Facturas")
            If Not Directory.Exists(rutaCarpeta) Then
                Directory.CreateDirectory(rutaCarpeta)
            End If

            Dim nombreArchivo As String = $"Factura_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            Dim rutaCompleta As String = Path.Combine(rutaCarpeta, nombreArchivo)

            ' Guardar documento
            documento.Save(rutaCompleta)

            ' Notificar y abrir automáticamente
            MessageBox.Show("Factura PDF generada con éxito.", "Comprobante Creado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(rutaCompleta) With {.UseShellExecute = True})

        Catch ex As Exception
            Throw New Exception("Error al generar el PDF de la factura: " & ex.Message)
        End Try
    End Sub

End Class