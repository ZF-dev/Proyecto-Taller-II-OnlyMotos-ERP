Imports System.Text.RegularExpressions

Public Class ValidadorEmail
    Public Shared Function IsValidEmail(email As String) As Boolean

        If String.IsNullOrWhiteSpace(email) Then Return False

        ' Patrón estándar de expresión regular para direcciones de e-mail (DESPUES DEbO PONERLO EN LA CARPETA NEGOCIO)
        Dim pattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(email.Trim(), pattern)

    End Function

End Class
