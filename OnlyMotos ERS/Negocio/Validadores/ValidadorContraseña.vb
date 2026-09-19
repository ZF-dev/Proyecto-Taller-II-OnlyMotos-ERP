Public Class ValidadorContraseña

    Public Shared Function IsValidPassword(password As String) As Boolean

        If String.IsNullOrWhiteSpace(password) Then Return False
        Return password.Trim().Length >= 8

    End Function

End Class
