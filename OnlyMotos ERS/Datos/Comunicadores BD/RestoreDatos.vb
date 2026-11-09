Imports Microsoft.Data.SqlClient
Public Class RestoreDatos

    Public Sub EjecutarRestore(rutaCompleta As String)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexionMaster

            Using comando As New SqlCommand("sp_RestaurarBackup", conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@RutaArchivo", rutaCompleta)

                ' Timeout extendido a 3 minutos por si el archivo es pesado
                comando.CommandTimeout = 180

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Sub registrarRestore(id_usuario As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_RegistrarRestore", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@Usuario", id_usuario)
                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

End Class
