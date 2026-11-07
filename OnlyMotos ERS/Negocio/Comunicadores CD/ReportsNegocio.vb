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

End Class
