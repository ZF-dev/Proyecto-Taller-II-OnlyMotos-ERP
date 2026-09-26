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

    Public Function ListarUsuarios() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarUsuarios", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ListarUsuariosInactivos() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarUsuariosInactivos", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function RegistrarUsuario(idTipo As Integer, dni As String, usuario As String, pass As String, nombre As String, apellido As String, email As String, telefono As String) As Boolean

        Try

            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

                Using comando As New SqlCommand("sp_InsertarUsuario", conexion)

                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.AddWithValue("@id_tipo", idTipo)
                    comando.Parameters.AddWithValue("@dni", dni)
                    comando.Parameters.AddWithValue("@usuario", usuario)
                    comando.Parameters.AddWithValue("@password", pass)
                    comando.Parameters.AddWithValue("@nombre", nombre)
                    comando.Parameters.AddWithValue("@apellido", apellido)
                    comando.Parameters.AddWithValue("@email", email)

                    If String.IsNullOrEmpty(telefono) Then

                        comando.Parameters.AddWithValue("@telefono", DBNull.Value)

                    Else

                        comando.Parameters.AddWithValue("@telefono", telefono)

                    End If

                    conexion.Open()
                    comando.ExecuteNonQuery()

                    Return True

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al registrar usuario en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Public Function ListarTiposUsuario() As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_ListarTiposUsuario", conexion)

                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function DarBajaUsuario(idUsuario As Integer) As Boolean

        Try

            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

                Using comando As New SqlCommand("sp_DarBajaUsuario", conexion)

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@id_usuario", idUsuario)

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al dar de baja en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Public Function ReactivarUsuario(idUsuario As Integer) As Boolean

        Try

            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

                Using comando As New SqlCommand("sp_ReactivarUsuario", conexion)

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@id_usuario", idUsuario)

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al reactivar usuario en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

    Public Function BuscarUsuarioPorDni(dni As String) As DataTable

        Dim dt As New DataTable()

        Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

            Using comando As New SqlCommand("sp_BuscarUsuarioPorDni", conexion)

                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.AddWithValue("@dni", dni)
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(dt)

            End Using

        End Using

        Return dt

    End Function

    Public Function ActualizarCampoUsuario(idUsuario As Integer, campo As String, valor As String) As Boolean

        Try

            Using conexion As SqlConnection = ConexionBD.ObtenerConexion()

                Using comando As New SqlCommand("sp_ActualizarCampoUsuario", conexion)

                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@id_usuario", idUsuario)
                    comando.Parameters.AddWithValue("@campo", campo)

                    If String.IsNullOrEmpty(valor) Then

                        comando.Parameters.AddWithValue("@valor", DBNull.Value)

                    Else

                        comando.Parameters.AddWithValue("@valor", valor)

                    End If

                    conexion.Open()
                    comando.ExecuteNonQuery()
                    Return True

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Error al actualizar en la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False

        End Try

    End Function

End Class