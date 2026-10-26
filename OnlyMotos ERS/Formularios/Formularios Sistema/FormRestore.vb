Imports System.IO
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

        Dim confirmacion As DialogResult = MessageBox.Show(
            "¿Está completamente seguro de ejecutar la restauración? Se perderá cualquier operación registrada después de la fecha y hora de este respaldo.",
            "Confirmación Crítica",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirmacion = DialogResult.Yes Then

            Dim passwordIngresada As String = Microsoft.VisualBasic.Interaction.InputBox(
            "La restauración sobrescribirá todos los datos actuales del sistema." & vbCrLf & "Ingrese la contraseña de seguridad para autorizar la operación:",
            "Autenticación Requerida - OnlyMotos ERP",
            "")

            If String.IsNullOrEmpty(passwordIngresada) Then
                Exit Sub
            End If

            Try

                Dim negocioRestore As New RestoreNegocio()
                negocioRestore.EjecutarRestore(backupFilePath, passwordIngresada)

                MessageBox.Show("La base de datos ha sido restaurada exitosamente.", "Restauración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try

        End If

    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click

        Me.Close()

    End Sub

End Class