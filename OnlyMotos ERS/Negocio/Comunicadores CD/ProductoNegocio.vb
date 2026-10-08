Imports System.IO

Public Class ProductoNegocio

    Public Function ObtenerMotos() As DataTable

        Dim datos As New ProductoDatos()
        Return datos.ListarMotos()

    End Function

    Public Sub RegistrarMoto(id_marca As Integer, id_cc As Integer, modelo As String, precio As Decimal, stock As Integer, stockMin As Integer, imagenPathOrigen As String, año As String)

        Dim rutaParaBD As String = String.Empty

        ' Si seleccionaron una imagen, la copiamos a la carpeta del sistema
        If Not String.IsNullOrEmpty(imagenPathOrigen) AndAlso File.Exists(imagenPathOrigen) Then

            Dim carpetaDestino As String = Path.Combine(Application.StartupPath, "ImagenesMotos")

            If Not Directory.Exists(carpetaDestino) Then
                Directory.CreateDirectory(carpetaDestino)
            End If

            Dim nombreUnico As String = Guid.NewGuid().ToString() & Path.GetExtension(imagenPathOrigen)
            Dim rutaFinal As String = Path.Combine(carpetaDestino, nombreUnico)

            File.Copy(imagenPathOrigen, rutaFinal)

            ' Guardamos la ruta relativa para la BD
            rutaParaBD = Path.Combine("ImagenesMotos", nombreUnico)
        End If

        Dim datos As New ProductoDatos()
        datos.InsertarMoto(id_marca, id_cc, modelo.Trim(), precio, stock, stockMin, rutaParaBD, año)

    End Sub

    Public Function ObtenerMarcas() As DataTable

        Dim datos As New ProductoDatos()
        Return datos.ListarMarcasParaCombo()

    End Function

    Public Function ObtenerCc() As DataTable

        Dim datos As New ProductoDatos()
        Return datos.ListarCcParaCombo()

    End Function

    Public Function ObtenerMotosPorModelo(modelo As String) As DataTable

        Dim datos As New ProductoDatos()
        Return datos.FiltrarMotosPorModelo(modelo)

    End Function

    Public Sub DarDeBajaMoto(idMoto As Integer)

        Dim datos As New ProductoDatos()
        datos.EliminarMoto(idMoto)

    End Sub

    Public Sub ModificarStockMoto(idMoto As Integer, stock As Integer)

        Dim datos As New ProductoDatos()
        datos.ActualizarStockMoto(idMoto, stock)

    End Sub

End Class
