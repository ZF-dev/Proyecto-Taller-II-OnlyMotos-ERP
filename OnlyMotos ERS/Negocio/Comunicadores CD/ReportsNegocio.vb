Imports Microsoft.Data.SqlClient
Public Class ReportsNegocio

    Public Function ListarVentasPorUsuario(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasPorUsuario(fechaInicio, fechaFin)

    End Function

    Public Function ListarVentasRango(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasRango(fechaInicio, fechaFin)

    End Function

    Public Function ListarComprasRango(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerComprasRango(fechaInicio, fechaFin)

    End Function

    Public Function ListarVentasPorTiempo(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasPorTiempo(fechaInicio, fechaFin)

    End Function

    Public Function ListarVentasPorElUsuarioYTiempo(fechaInicio As DateTime, fechaFin As DateTime, idUsuario As Integer) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasPorUsuarioYTiempo(fechaInicio, fechaFin, idUsuario)

    End Function

    Public Function ListarRestauracionesEnElTiempo(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerRestauracionesEnElTiempo(fechaInicio, fechaFin)

    End Function

End Class
