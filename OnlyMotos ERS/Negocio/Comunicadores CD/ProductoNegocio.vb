Public Class ProductoNegocio

    Public Function ObtenerMotos() As DataTable

        Dim datos As New ProductoDatos()
        Return datos.ListarMotos()

    End Function

End Class
