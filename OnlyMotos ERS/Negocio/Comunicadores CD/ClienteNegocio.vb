Public Class ClienteNegocio

    Public Function ObtenerClientes() As DataTable

        Dim datos As New ClienteDatos()
        Return datos.ListarClientes()

    End Function

    Public Function ObtenerClientesInactivos() As DataTable

        Dim datos As New ClienteDatos()
        Return datos.ListarClientesInactivos()

    End Function

    Public Sub RegistrarCliente(nombre As String, apellido As String, dni As String, email As String, telefono As String)

        Try

            Dim datos As New ClienteDatos()
            datos.InsertarCliente(nombre.Trim(), apellido.Trim(), dni.Trim(), email.Trim(), telefono.Trim())

        Catch ex As Exception

            If ex.Message.Contains("UNIQUE") OrElse ex.Message.Contains("Violation of UNIQUE KEY") Then

                Throw New Exception("Ya existe un cliente registrado con ese DNI o Correo Electrónico.")

            Else

                Throw New Exception("Error en la Base de Datos.")

            End If

        End Try

    End Sub

    Public Function BuscarClientePorDni(dni As String) As DataTable

        Dim datos As New ClienteDatos()
        Return datos.BuscarPorDni(dni)

    End Function

    Public Sub CambiarEstadoInactivo(id_cliente As Integer)

        Dim datos As New ClienteDatos()
        datos.DarDeBajaCliente(id_cliente)

    End Sub

    Public Sub ActualizarCliente(id As Integer, nombre As String, apellido As String, dni As String, email As String, telefono As String)

        Try

            Dim datos As New ClienteDatos()
            datos.ModificarCliente(id, nombre.Trim(), apellido.Trim(), dni.Trim(), email.Trim(), telefono.Trim())

        Catch ex As Exception

            If ex.Message.Contains("UNIQUE") OrElse ex.Message.Contains("Violation of UNIQUE KEY") Then

                Throw New Exception("Ya existe un cliente registrado con ese Correo Electrónico.")

            Else

                Throw New Exception("Error en la Base de Datos.")

            End If

        End Try

    End Sub

    Public Function CambiarEstadoActivo(id_cliente As Integer)

        Dim datos As New ClienteDatos()
        Return datos.ActivarCliente(id_cliente)

    End Function

End Class
