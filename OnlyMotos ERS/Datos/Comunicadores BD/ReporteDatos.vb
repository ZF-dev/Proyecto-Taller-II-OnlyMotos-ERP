Imports Microsoft.Data.SqlClient
Public Class ReporteDatos

    Public Function ObtenerVentasPorUsuario(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_VentasPorUsuario", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerVentasRango(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_VentasPorRango", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerComprasRango(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_ComprasPorRango", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerVentasPorTiempo(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_VentasPorTiempo", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerVentasPorUsuarioYTiempo(fechaInicio As DateTime, fechaFin As DateTime, idUsuario As Integer) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_VentasPorUsuarioYTiempo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

    Public Function ObtenerRestauracionesEnElTiempo(fechaInicio As DateTime, fechaFin As DateTime) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_Reporte_RestauracionesPorTiempo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                comando.Parameters.AddWithValue("@FechaFin", fechaFin)

                Using adaptador As New SqlDataAdapter(comando)

                    adaptador.Fill(dt)

                End Using

            End Using

        End Using

        Return dt

    End Function

End Class
