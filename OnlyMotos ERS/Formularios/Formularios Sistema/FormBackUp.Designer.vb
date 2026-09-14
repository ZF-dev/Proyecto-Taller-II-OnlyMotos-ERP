<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBackUp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBackUp))
        LDescription = New Label()
        TBBackupPath = New TextBox()
        LBackUpPath = New Label()
        BExecuteBackup = New Button()
        BClose = New Button()
        SuspendLayout()
        ' 
        ' LDescription
        ' 
        LDescription.AutoSize = True
        LDescription.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LDescription.ForeColor = SystemColors.ControlLightLight
        LDescription.Location = New Point(12, 9)
        LDescription.Name = "LDescription"
        LDescription.Size = New Size(679, 195)
        LDescription.TabIndex = 0
        LDescription.Text = resources.GetString("LDescription.Text")
        ' 
        ' TBBackupPath
        ' 
        TBBackupPath.Location = New Point(226, 299)
        TBBackupPath.Name = "TBBackupPath"
        TBBackupPath.ReadOnly = True
        TBBackupPath.Size = New Size(206, 23)
        TBBackupPath.TabIndex = 1
        TBBackupPath.Text = """C:\OnlyMotosERP\Datos\Backups\"""
        ' 
        ' LBackUpPath
        ' 
        LBackUpPath.AutoSize = True
        LBackUpPath.ForeColor = SystemColors.ControlLightLight
        LBackUpPath.Location = New Point(173, 302)
        LBackUpPath.Name = "LBackUpPath"
        LBackUpPath.Size = New Size(34, 15)
        LBackUpPath.TabIndex = 2
        LBackUpPath.Text = "Ruta:"
        ' 
        ' BExecuteBackup
        ' 
        BExecuteBackup.Image = My.Resources.Resources.Icono_Back_Up_Chiquito
        BExecuteBackup.ImageAlign = ContentAlignment.MiddleRight
        BExecuteBackup.Location = New Point(267, 233)
        BExecuteBackup.Name = "BExecuteBackup"
        BExecuteBackup.Size = New Size(129, 48)
        BExecuteBackup.TabIndex = 3
        BExecuteBackup.Text = "Realizar Back Up"
        BExecuteBackup.TextAlign = ContentAlignment.MiddleLeft
        BExecuteBackup.UseVisualStyleBackColor = True
        ' 
        ' BClose
        ' 
        BClose.Location = New Point(529, 267)
        BClose.Name = "BClose"
        BClose.Size = New Size(110, 50)
        BClose.TabIndex = 4
        BClose.Text = "Salir"
        BClose.UseVisualStyleBackColor = True
        BClose.Visible = False
        ' 
        ' FormBackUp
        ' 
        AcceptButton = BExecuteBackup
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BClose
        ClientSize = New Size(696, 338)
        Controls.Add(BClose)
        Controls.Add(BExecuteBackup)
        Controls.Add(LBackUpPath)
        Controls.Add(TBBackupPath)
        Controls.Add(LDescription)
        Name = "FormBackUp"
        StartPosition = FormStartPosition.CenterParent
        Text = "Respaldo de Base de Datos - OnlyMotos ERP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LDescription As Label
    Friend WithEvents TBBackupPath As TextBox
    Friend WithEvents LBackUpPath As Label
    Friend WithEvents BExecuteBackup As Button
    Friend WithEvents BClose As Button
End Class
