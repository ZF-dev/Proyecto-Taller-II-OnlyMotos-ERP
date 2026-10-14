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


End Class
