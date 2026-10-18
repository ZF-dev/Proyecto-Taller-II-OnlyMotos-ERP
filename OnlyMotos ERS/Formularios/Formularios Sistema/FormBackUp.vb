Imports System.IO

Public Class FormBackUp
    Private Sub FormBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim directorioActual As New DirectoryInfo(Application.StartupPath)

        Dim carpetaBackups As String = Path.Combine(Application.StartupPath, "Datos", "Backups")

        If directorioActual.FullName.Contains("bin") Then

            Dim raizProyecto = directorioActual.Parent?.Parent?.Parent?.FullName 'los parent son para subir niveles (subir en carpetas) en el path
            If raizProyecto IsNot Nothing Then
                carpetaBackups = Path.Combine(raizProyecto, "Datos", "Backups")
            End If

        End If

        If Not Directory.Exists(carpetaBackups) Then 'todo esto es por si falla algo o al subir de nivel en el path no existe el nuevo path crea el directorio que necesito
            Directory.CreateDirectory(carpetaBackups)
        End If

        TBBackupPath.Text = carpetaBackups

    End Sub
    Private Sub BExecuteBackup_Click(sender As Object, e As EventArgs) Handles BExecuteBackup.Click

        Try
            Dim targetPath As String = TBBackupPath.Text.Trim()

            If Not Directory.Exists(targetPath) Then
                Directory.CreateDirectory(targetPath)
            End If

            Dim archivosExistente = Directory.GetFiles(targetPath, "OnlyMotos_Backup_*.bak")


            If archivosExistente.Length >= 3 Then
                Dim archivoMasAntiguo = archivosExistente.OrderBy(Function(f) File.GetCreationTime(f)).FirstOrDefault()

                If archivoMasAntiguo IsNot Nothing AndAlso File.Exists(archivoMasAntiguo) Then
                    File.Delete(archivoMasAntiguo)
                End If

            End If

            Dim fileName As String = $"OnlyMotos_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak"
            Dim fullPath As String = Path.Combine(targetPath, fileName)

            Dim datosBackup As New BackUpNegocio()
            datosBackup.EjecutarBackup(fullPath)

            MessageBox.Show($"Respaldo generado de forma exitosa y segura en:{Environment.NewLine}{fullPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al generar el respaldo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class