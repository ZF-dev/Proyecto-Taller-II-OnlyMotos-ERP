Public Class IngresoUsuario

    Private datosUsuario As New UsuarioDatos()

    Public Function ValidarLogin(user As String, pass As String, ByRef rolUsuario As String, ByRef nombreCompleto As String) As Boolean

        If String.IsNullOrWhiteSpace(user) OrElse String.IsNullOrWhiteSpace(pass) Then

            Return False

        End If

        Dim dt As DataTable = datosUsuario.ObtenerDatosUsuario(user, pass)

        If dt.Rows.Count > 0 Then

            rolUsuario = dt.Rows(0)("nombre_tipo").ToString()
            nombreCompleto = dt.Rows(0)("nombre").ToString() & " " & dt.Rows(0)("apellido").ToString()
            Return True

        End If

        Return False

    End Function

End Class
