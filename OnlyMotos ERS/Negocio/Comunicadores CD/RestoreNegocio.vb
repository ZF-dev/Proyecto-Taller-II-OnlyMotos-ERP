Public Class RestoreNegocio

    Public Sub EjecutarRestore(rutaCompleta As String, passwordIngresada As String)

        Const PASSWORD_AUTORIZADA As String = "Adm1n0nlyM0t052026"

        If passwordIngresada <> PASSWORD_AUTORIZADA Then
            Throw New UnauthorizedAccessException("Contraseña incorrecta. Acceso denegado para restaurar el sistema.")
            Exit Sub
        End If

        Try

            Dim restoreDatos As New RestoreDatos()
            restoreDatos.EjecutarRestore(rutaCompleta)

        Catch ex As Exception
            Throw New Exception("Error en la base de datos al Realizar el restore: (" & ex.Message & ")")
        End Try

    End Sub

End Class
