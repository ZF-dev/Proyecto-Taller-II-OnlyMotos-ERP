Public Class BackUpNegocio

    Public Sub EjecutarBackup(rutaCompleta As String)
        Try

            Dim backupDatos As New BackUpDatos()
            backupDatos.EjecutarBackup(rutaCompleta)

        Catch ex As Exception
            Throw New Exception("Error en la base de datos al generar el backup: (" & ex.Message & ")")
        End Try

    End Sub

End Class
