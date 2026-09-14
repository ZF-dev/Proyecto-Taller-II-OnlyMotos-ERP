<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LUser = New Label()
        LPassword = New Label()
        TBUser = New TextBox()
        TBPassword = New TextBox()
        BLogin = New Button()
        BCancel = New Button()
        PBLogo = New PictureBox()
        CType(PBLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LUser
        ' 
        LUser.AutoSize = True
        LUser.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LUser.ForeColor = SystemColors.ControlLightLight
        LUser.Location = New Point(12, 117)
        LUser.Name = "LUser"
        LUser.Size = New Size(52, 15)
        LUser.TabIndex = 0
        LUser.Text = "Usuario:"
        ' 
        ' LPassword
        ' 
        LPassword.AutoSize = True
        LPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LPassword.ForeColor = SystemColors.ControlLightLight
        LPassword.Location = New Point(12, 176)
        LPassword.Name = "LPassword"
        LPassword.Size = New Size(72, 15)
        LPassword.TabIndex = 1
        LPassword.Text = "Contraseña:"
        ' 
        ' TBUser
        ' 
        TBUser.Location = New Point(13, 135)
        TBUser.Name = "TBUser"
        TBUser.Size = New Size(409, 23)
        TBUser.TabIndex = 2
        ' 
        ' TBPassword
        ' 
        TBPassword.Location = New Point(13, 194)
        TBPassword.Name = "TBPassword"
        TBPassword.Size = New Size(409, 23)
        TBPassword.TabIndex = 3
        TBPassword.UseSystemPasswordChar = True
        ' 
        ' BLogin
        ' 
        BLogin.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BLogin.Location = New Point(254, 241)
        BLogin.Name = "BLogin"
        BLogin.Size = New Size(80, 32)
        BLogin.TabIndex = 4
        BLogin.Text = "Ingresar"
        BLogin.UseVisualStyleBackColor = True
        ' 
        ' BCancel
        ' 
        BCancel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BCancel.Location = New Point(94, 241)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(80, 32)
        BCancel.TabIndex = 5
        BCancel.Text = "Cancelar"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' PBLogo
        ' 
        PBLogo.BackColor = Color.Transparent
        PBLogo.Image = My.Resources.Resources.OnlyMotos_Logo_nuevo
        PBLogo.Location = New Point(138, 3)
        PBLogo.Name = "PBLogo"
        PBLogo.Size = New Size(160, 113)
        PBLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PBLogo.TabIndex = 6
        PBLogo.TabStop = False
        ' 
        ' FormLogin
        ' 
        AcceptButton = BLogin
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BCancel
        ClientSize = New Size(434, 311)
        Controls.Add(PBLogo)
        Controls.Add(BCancel)
        Controls.Add(BLogin)
        Controls.Add(TBPassword)
        Controls.Add(TBUser)
        Controls.Add(LPassword)
        Controls.Add(LUser)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Acceso al Sistema"
        CType(PBLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LUser As Label
    Friend WithEvents LPassword As Label
    Friend WithEvents TBUser As TextBox
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents BLogin As Button
    Friend WithEvents BCancel As Button
    Friend WithEvents PBLogo As PictureBox

End Class
