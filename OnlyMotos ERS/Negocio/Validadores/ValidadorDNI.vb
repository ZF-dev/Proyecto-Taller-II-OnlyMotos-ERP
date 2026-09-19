Imports System.Text.RegularExpressions

Public Class ValidadorDNI

    Public Shared Function IsValidDNI(dni As String) As Boolean

        If String.IsNullOrWhiteSpace(dni) Then Return False

        Dim pattern As String = "^\d{7,8}$"
        Return Regex.IsMatch(dni.Trim(), pattern)

    End Function

End Class
