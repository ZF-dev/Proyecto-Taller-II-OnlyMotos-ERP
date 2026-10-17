Public Class VentaNegocio

    Public Function ObtenerTiposFactura() As DataTable

        Dim datos As New VentaDatos()
        Return datos.ObtenerTiposFactura()

    End Function

    Public Function ListarClientesParaCombo() As DataTable

        Dim datos As New VentaDatos()
        Return datos.ListarClientesParaCombo()

    End Function

    Public Function ObtenerMotosDisponibles() As DataTable

        Dim datos As New VentaDatos()
        Return datos.ObtenerMotosDisponibles()

    End Function

    Public Function ObtenerDatosMotoPorId(idMoto As Integer) As DataTable

        Dim datos As New VentaDatos()
        Return datos.ObtenerDatosMotoPorId(idMoto)

    End Function

    Public Function ProcesarDescuentoStock(idMoto As Integer, cantidad As Integer) As Boolean

        Dim datos As New VentaDatos()
        Return datos.DescontarStockMoto(idMoto, cantidad)

    End Function

    Public Sub ReintegrarStock(idMoto As Integer, cantidad As Integer)

        Dim datos As New VentaDatos()
        datos.DevolverStockMoto(idMoto, cantidad)

    End Sub

    Public Function GuardarVenta(idUsuario As Integer, idCliente As Integer, idTipoFactura As Integer, fecha As DateTime, total As Decimal, dtDetalle As DataTable) As Boolean

        Dim datos As New VentaDatos()
        Return datos.RegistrarVentaCompleta(idUsuario, idCliente, idTipoFactura, fecha, total, dtDetalle)

    End Function

    Public Function ObtenerUltimoIdVenta() As Integer

        Dim datos As New VentaDatos()
        Return datos.ObtenerUltimoIdVenta()

    End Function

    Public Function ObtenerVentas(fechaDesde As Date?, fechaHasta As Date?, dniCliente As String) As DataTable

        Dim datos As New VentaDatos()

        Try
            Return datos.ListarVentas(fechaDesde, fechaHasta, dniCliente)
        Catch ex As Exception
            Throw New Exception("Error al obtener el listado de ventas: " & ex.Message)
        End Try

    End Function

    Public Function ObtenerDetalleVenta(idVenta As Integer) As DataTable

        Dim datos As New VentaDatos()

        Try
            Return datos.ListarDetalleVenta(idVenta)
        Catch ex As Exception
            Throw New Exception("Error al obtener el detalle de la venta: " & ex.Message)
        End Try

    End Function

    Public Sub AnularVenta(idVenta As Integer)

        Dim datos As New VentaDatos()

        Try

            datos.AnularVenta(idVenta)

        Catch ex As Exception
            Throw New Exception("Error al procesar la anulación de la venta: " & ex.Message)
        End Try
    End Sub

End Class
