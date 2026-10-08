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

    Public Sub InsertarMoto(id_marca As Integer, id_cc As Integer, modelo As String, precio As Decimal, stock As Integer, stockMin As Integer, imagenPath As String, año As String)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_InsertarMoto", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@id_marca", id_marca)
                comando.Parameters.AddWithValue("@id_cc", id_cc)
                comando.Parameters.AddWithValue("@modelo", modelo)
                comando.Parameters.AddWithValue("@precio", precio)
                comando.Parameters.AddWithValue("@stock", stock)
                comando.Parameters.AddWithValue("@stock_min", stockMin)
                comando.Parameters.AddWithValue("@año", año)

                If String.IsNullOrEmpty(imagenPath) Then
                    comando.Parameters.AddWithValue("@imagen_path", DBNull.Value)
                Else
                    comando.Parameters.AddWithValue("@imagen_path", imagenPath)
                End If

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function ListarMarcasParaCombo() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarMarcasParaCombo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function


    Public Function ListarCcParaCombo() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarCcParaCombo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function FiltrarMotosPorModelo(modelo As String) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_FiltrarMotosPorModelo", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@modelo", modelo)

                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Sub EliminarMoto(idMoto As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_EliminarMoto", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_moto", idMoto)

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Sub ActualizarStockMoto(idMoto As Integer, stock As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ActualizarStockMoto", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_moto", idMoto)
                comando.Parameters.AddWithValue("@stock", stock)

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

End Class
