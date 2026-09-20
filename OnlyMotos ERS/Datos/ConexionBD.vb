Imports Microsoft.Data.SqlClient

Public Class ConexionBD

    Private Shared cadenaConexion As String = "Server=localhost; Database=OnlyMotosDB; Integrated Security=True;"

    ' Es una función que crea y devuelve un objeto de tipo SqlConnection listo para abrirse cuando lo necesite.
    Public Shared Function ObtenerConexion() As SqlConnection

        Return New SqlConnection(cadenaConexion)

    End Function

End Class


