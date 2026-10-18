Imports Microsoft.Data.SqlClient
Public Class BackUpDatos

    Public Sub EjecutarBackup(rutaCompleta As String)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexionMaster()

            Using comando As New SqlCommand("sp_RealizarBackup", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@RutaArchivo", rutaCompleta)

                comando.CommandTimeout = 60


                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

End Class
