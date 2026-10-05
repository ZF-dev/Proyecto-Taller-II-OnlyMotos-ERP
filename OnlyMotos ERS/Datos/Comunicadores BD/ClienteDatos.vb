Imports Microsoft.Data.SqlClient
Public Class ClienteDatos

    Public Function ListarClientes() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarClientes", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ListarClientesInactivos() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarClientesInactivos", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Sub InsertarCliente(nombre As String, apellido As String, dni As String, email As String, telefono As String)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_InsertarCliente", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@dni", dni)
                comando.Parameters.AddWithValue("@email", email)

                If String.IsNullOrEmpty(telefono) Then

                    comando.Parameters.AddWithValue("@telefono", DBNull.Value)

                Else

                    comando.Parameters.AddWithValue("@telefono", telefono)

                End If

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function BuscarPorDni(dni As String) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_BuscarClientePorDni", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@dni", dni)
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Sub DarDeBajaCliente(id_cliente As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_DarDeBajaCliente", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_cliente", id_cliente)
                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Sub ModificarCliente(id As Integer, nombre As String, apellido As String, dni As String, email As String, telefono As String)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ActualizarCliente", conexion)

                comando.CommandType = CommandType.StoredProcedure

                comando.Parameters.AddWithValue("@id_cliente", id)
                comando.Parameters.AddWithValue("@nombre", nombre)
                comando.Parameters.AddWithValue("@apellido", apellido)
                comando.Parameters.AddWithValue("@dni", dni)
                comando.Parameters.AddWithValue("@email", email)
                comando.Parameters.AddWithValue("@telefono", telefono)

                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    Public Function ActivarCliente(id_cliente As Integer)

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ReactivarCliente", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@id_cliente", id_cliente)
                conexion.Open()
                comando.ExecuteNonQuery()

            End Using

        End Using

        Return True

    End Function

End Class

