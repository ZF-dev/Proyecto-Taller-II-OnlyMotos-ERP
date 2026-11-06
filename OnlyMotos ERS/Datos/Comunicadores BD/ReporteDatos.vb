Imports Microsoft.Data.SqlClient
Public Class ReporteDatos

    Public Function ObtenerVentasPorUsuario(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_VentasPorUsuario", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio.Date)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin.Date)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

End Class
