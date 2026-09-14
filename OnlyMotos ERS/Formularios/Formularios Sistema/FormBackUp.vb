Public Class FormBackUp
    Private Sub BExecuteBackup_Click(sender As Object, e As EventArgs) Handles BExecuteBackup.Click

        Dim targetPath As String = TBBackupPath.Text.Trim()

        Dim fileName As String = $"OnlyMotos_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak"
        Dim fullPath As String = IO.Path.Combine(targetPath, fileName)

        MessageBox.Show($"Respaldo generado de forma automática en la ruta del sistema:{Environment.NewLine}{fullPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class