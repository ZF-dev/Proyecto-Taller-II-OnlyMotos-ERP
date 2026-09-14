Public Class FormRestore
    Private Sub BSelectFile_Click(sender As Object, e As EventArgs) Handles BSelectFile.Click

        Using OFD As New OpenFileDialog()

            OFD.Filter = "Archivos de Respaldo (*.bak)|*.bak|Todos los archivos|*.*"
            OFD.Title = "Seleccionar Archivo de Respaldo (.bak)"

            ' Sugerir la carpeta fija de backups del sistema creada previamente
            If IO.Directory.Exists("C:\OnlyMotosERP\Datos\Backups\") Then

                OFD.InitialDirectory = "C:\OnlyMotosERP\Datos\Backups\"

            End If

            If OFD.ShowDialog() = DialogResult.OK Then

                TBBackupFile.Text = OFD.FileName

            End If

        End Using

    End Sub

    Private Sub BExecuteRestore_Click(sender As Object, e As EventArgs) Handles BExecuteRestore.Click

        Dim backupFilePath As String = TBBackupFile.Text.Trim()

        If String.IsNullOrWhiteSpace(backupFilePath) Then

            MessageBox.Show("Debe seleccionar un archivo de respaldo válido (.bak) para continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        If Not IO.File.Exists(backupFilePath) Then

            MessageBox.Show("El archivo seleccionado ya no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "ATENCIÓN: Restaurar la base de datos reemplazará toda la información actual del sistema con los datos de este archivo." & Environment.NewLine & Environment.NewLine & "¿Desea continuar con la restauración?",
            "Confirmación de Seguridad",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult = DialogResult.Yes Then

            ' SIMULACIÓN: Más adelante aquí se invocará a la Capa de Negocio y Datos
            ' NegocioRestore.RestaurarSistema(backupFilePath)

            MessageBox.Show("La base de datos ha sido restaurada exitosamente.", "Restauración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        End If

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class