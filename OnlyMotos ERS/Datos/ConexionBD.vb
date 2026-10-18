Imports Microsoft.Data.SqlClient

Public Class ConexionBD

    Private Shared cadenaConexion As String = "Server=localhost\SQLEXPRESS01; Database=OnlyMotosDB; Integrated Security=True; TrustServerCertificate=True;"

    Private Shared cadenaConexionMaster As String = "Server=localhost\SQLEXPRESS01; Database=master; Integrated Security=True; TrustServerCertificate=True;"

    ' Es una función que crea y devuelve un objeto de tipo SqlConnection listo para abrirse cuando lo necesite.
    Public Shared Function ObtenerConexion() As SqlConnection

        Return New SqlConnection(cadenaConexion)

    End Function

    Public Shared Function ObtenerConexionMaster() As SqlConnection

        Return New SqlConnection(cadenaConexionMaster)

    End Function

End Class


