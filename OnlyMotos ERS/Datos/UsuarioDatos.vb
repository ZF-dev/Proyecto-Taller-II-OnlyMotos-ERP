Imports Microsoft.Data.SqlClient

Public Class UsuarioDatos
    Public Function ObtenerDatosUsuario(user As String, pass As String) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ValidarUsuario", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@usuario", user)
                comando.Parameters.AddWithValue("@password", pass)

                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

End Class