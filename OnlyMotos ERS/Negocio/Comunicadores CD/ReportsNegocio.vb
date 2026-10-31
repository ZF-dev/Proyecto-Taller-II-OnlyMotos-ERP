Imports Microsoft.Data.SqlClient
Public Class ReportsNegocio

    Public Function ListarVentasPorUsuario() As DataTable

        Dim reporteDatos As New ReporteDatos()
        Return reporteDatos.ObtenerVentasPorUsuario()

    End Function

End Class
