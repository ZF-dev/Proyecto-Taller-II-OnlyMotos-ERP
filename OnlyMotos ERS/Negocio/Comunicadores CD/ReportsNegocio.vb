Imports Microsoft.Data.SqlClient
Public Class ReportsNegocio

    Public Function ListarVentasPorUsuario(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasPorUsuario(fechaInicio, fechaFin)

    End Function

End Class
