Imports Microsoft.Data.SqlClient
Public Class ProductoDatos

    Public Function ListarMotos() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarMotos", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

End Class
