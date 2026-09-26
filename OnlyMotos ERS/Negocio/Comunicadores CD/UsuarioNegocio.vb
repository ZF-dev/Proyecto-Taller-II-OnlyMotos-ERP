Public Class UsuarioNegocio

    Private datosUsuario As New UsuarioDatos()

    Public Function ObtenerListaUsuarios() As DataTable

        ' Aquí podrías agregar reglas de negocio en el futuro si hiciera falta
        Return datosUsuario.ListarUsuarios()

    End Function

    Public Function ObtenerListaUsuariosInactivos() As DataTable

        ' Aquí podrías agregar reglas de negocio en el futuro si hiciera falta
        Return datosUsuario.ListarUsuariosInactivos()

    End Function

    Public Function RegistrarNuevoUsuario(idTipo As Integer, dni As String, usuario As String, pass As String, nombre As String, apellido As String, email As String, telefono As String) As Boolean

        Return datosUsuario.RegistrarUsuario(idTipo, dni, usuario, pass, nombre, apellido, email, telefono)

    End Function

    Public Function ObtenerTiposUsuario() As DataTable

        Return datosUsuario.ListarTiposUsuario()

    End Function

    Public Function CambiarEstadoInactivo(idUsuario As Integer) As Boolean

        Return datosUsuario.DarBajaUsuario(idUsuario)

    End Function

    Public Function CambiarEstadoActivo(idUsuario As Integer) As Boolean

        Return datosUsuario.ReactivarUsuario(idUsuario)

    End Function

    Public Function ObtenerUsuarioPorDni(dni As String) As DataTable

        Return datosUsuario.BuscarUsuarioPorDni(dni)

    End Function

    Public Function ModificarCampoUsuario(idUsuario As Integer, campo As String, valor As String) As Boolean

        Return datosUsuario.ActualizarCampoUsuario(idUsuario, campo.ToLower(), valor)

    End Function

End Class
