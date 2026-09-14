<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRestore
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
        GBInformation = New GroupBox()
        LInformation = New Label()
        TBBackupFile = New TextBox()
        BSelectFile = New Button()
        BExecuteRestore = New Button()
        BClose = New Button()
        GBInformation.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBInformation
        ' 
        GBInformation.Controls.Add(LInformation)
        GBInformation.ForeColor = SystemColors.ControlLightLight
        GBInformation.Location = New Point(12, 12)
        GBInformation.Name = "GBInformation"
        GBInformation.Size = New Size(556, 66)
        GBInformation.TabIndex = 0
        GBInformation.TabStop = False
        GBInformation.Text = "Informacion de Seguridad"
        ' 
        ' LInformation
        ' 
        LInformation.AutoSize = True
        LInformation.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LInformation.ForeColor = SystemColors.ControlLightLight
        LInformation.Location = New Point(3, 19)
        LInformation.Name = "LInformation"
        LInformation.Size = New Size(542, 30)
        LInformation.TabIndex = 0
        LInformation.Text = "La restauración sobrescribirá los datos actuales del sistema con el archivo de respaldo seleccionado." & vbCrLf & "Asegúrese de realizar un backup previo si es necesario.""" & vbCrLf
        ' 
        ' TBBackupFile
        ' 
        TBBackupFile.Location = New Point(93, 123)
        TBBackupFile.Name = "TBBackupFile"
        TBBackupFile.ReadOnly = True
        TBBackupFile.Size = New Size(464, 23)
        TBBackupFile.TabIndex = 1
        ' 
        ' BSelectFile
        ' 
        BSelectFile.Location = New Point(12, 122)
        BSelectFile.Name = "BSelectFile"
        BSelectFile.Size = New Size(75, 23)
        BSelectFile.TabIndex = 2
        BSelectFile.Text = "Examinar..."
        BSelectFile.UseVisualStyleBackColor = True
        ' 
        ' BExecuteRestore
        ' 
        BExecuteRestore.Image = My.Resources.Resources.Icono_Restore_Chiquito
        BExecuteRestore.ImageAlign = ContentAlignment.MiddleRight
        BExecuteRestore.Location = New Point(220, 193)
        BExecuteRestore.Name = "BExecuteRestore"
        BExecuteRestore.Size = New Size(156, 61)
        BExecuteRestore.TabIndex = 3
        BExecuteRestore.Text = "Ejecutar Restauracion"
        BExecuteRestore.TextAlign = ContentAlignment.MiddleLeft
        BExecuteRestore.UseVisualStyleBackColor = True
        ' 
        ' BClose
        ' 
        BClose.Location = New Point(12, 193)
        BClose.Name = "BClose"
        BClose.Size = New Size(117, 46)
        BClose.TabIndex = 4
        BClose.Text = "Salir/Cancelar"
        BClose.UseVisualStyleBackColor = True
        BClose.Visible = False
        ' 
        ' FormRestore
        ' 
        AcceptButton = BExecuteRestore
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BClose
        ClientSize = New Size(579, 285)
        Controls.Add(BClose)
        Controls.Add(BExecuteRestore)
        Controls.Add(BSelectFile)
        Controls.Add(TBBackupFile)
        Controls.Add(GBInformation)
        Name = "FormRestore"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Restauración de Base de Datos - OnlyMotos ERP"
        GBInformation.ResumeLayout(False)
        GBInformation.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GBInformation As GroupBox
    Friend WithEvents LInformation As Label
    Friend WithEvents TBBackupFile As TextBox
    Friend WithEvents BSelectFile As Button
    Friend WithEvents BExecuteRestore As Button
    Friend WithEvents BClose As Button
End Class
