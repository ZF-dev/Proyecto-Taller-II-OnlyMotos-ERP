<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageUsers
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
        GBUserData = New GroupBox()
        CBProfile = New ComboBox()
        TBPassword = New TextBox()
        Label1 = New Label()
        LPassword = New Label()
        TBUser = New TextBox()
        LUser = New Label()
        BCancel = New Button()
        BSave = New Button()
        TBPhone = New TextBox()
        TBEmail = New TextBox()
        TBDNI = New TextBox()
        TBLastName = New TextBox()
        TBName = New TextBox()
        LDNI = New Label()
        LApellido = New Label()
        LEmail = New Label()
        LTelefono = New Label()
        LNombre = New Label()
        GBUserData.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBUserData
        ' 
        GBUserData.Controls.Add(CBProfile)
        GBUserData.Controls.Add(TBPassword)
        GBUserData.Controls.Add(Label1)
        GBUserData.Controls.Add(LPassword)
        GBUserData.Controls.Add(TBUser)
        GBUserData.Controls.Add(LUser)
        GBUserData.Controls.Add(BCancel)
        GBUserData.Controls.Add(BSave)
        GBUserData.Controls.Add(TBPhone)
        GBUserData.Controls.Add(TBEmail)
        GBUserData.Controls.Add(TBDNI)
        GBUserData.Controls.Add(TBLastName)
        GBUserData.Controls.Add(TBName)
        GBUserData.Controls.Add(LDNI)
        GBUserData.Controls.Add(LApellido)
        GBUserData.Controls.Add(LEmail)
        GBUserData.Controls.Add(LTelefono)
        GBUserData.Controls.Add(LNombre)
        GBUserData.ForeColor = SystemColors.ControlLightLight
        GBUserData.Location = New Point(12, 12)
        GBUserData.Name = "GBUserData"
        GBUserData.Size = New Size(304, 426)
        GBUserData.TabIndex = 1
        GBUserData.TabStop = False
        GBUserData.Text = "Datos del Usuario"
        ' 
        ' CBProfile
        ' 
        CBProfile.DropDownStyle = ComboBoxStyle.DropDownList
        CBProfile.FormattingEnabled = True
        CBProfile.Items.AddRange(New Object() {"Vendedor", "Supervisor", "Administrador"})
        CBProfile.Location = New Point(82, 244)
        CBProfile.Name = "CBProfile"
        CBProfile.Size = New Size(208, 23)
        CBProfile.TabIndex = 16
        ' 
        ' TBPassword
        ' 
        TBPassword.Location = New Point(82, 198)
        TBPassword.Name = "TBPassword"
        TBPassword.PasswordChar = "*"c
        TBPassword.Size = New Size(208, 23)
        TBPassword.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 244)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 8
        Label1.Text = "Rol:"
        ' 
        ' LPassword
        ' 
        LPassword.AutoSize = True
        LPassword.Location = New Point(6, 198)
        LPassword.Name = "LPassword"
        LPassword.Size = New Size(72, 15)
        LPassword.TabIndex = 14
        LPassword.Text = "Contraseña:"
        ' 
        ' TBUser
        ' 
        TBUser.Location = New Point(82, 153)
        TBUser.Name = "TBUser"
        TBUser.Size = New Size(208, 23)
        TBUser.TabIndex = 13
        ' 
        ' LUser
        ' 
        LUser.AutoSize = True
        LUser.Location = New Point(6, 153)
        LUser.Name = "LUser"
        LUser.Size = New Size(52, 15)
        LUser.TabIndex = 12
        LUser.Text = "Usuario:"
        ' 
        ' BCancel
        ' 
        BCancel.Font = New Font("Segoe UI", 9F)
        BCancel.ForeColor = SystemColors.ControlText
        BCancel.Location = New Point(32, 379)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(75, 23)
        BCancel.TabIndex = 11
        BCancel.Text = "Cancelar"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' BSave
        ' 
        BSave.Font = New Font("Segoe UI", 9F)
        BSave.ForeColor = SystemColors.ControlText
        BSave.Location = New Point(186, 379)
        BSave.Name = "BSave"
        BSave.Size = New Size(75, 23)
        BSave.TabIndex = 10
        BSave.Text = "Guardar"
        BSave.UseVisualStyleBackColor = True
        ' 
        ' TBPhone
        ' 
        TBPhone.Location = New Point(82, 321)
        TBPhone.Name = "TBPhone"
        TBPhone.Size = New Size(208, 23)
        TBPhone.TabIndex = 9
        ' 
        ' TBEmail
        ' 
        TBEmail.Location = New Point(82, 285)
        TBEmail.Name = "TBEmail"
        TBEmail.Size = New Size(208, 23)
        TBEmail.TabIndex = 8
        ' 
        ' TBDNI
        ' 
        TBDNI.Location = New Point(82, 108)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(208, 23)
        TBDNI.TabIndex = 7
        ' 
        ' TBLastName
        ' 
        TBLastName.Location = New Point(82, 68)
        TBLastName.Name = "TBLastName"
        TBLastName.Size = New Size(208, 23)
        TBLastName.TabIndex = 6
        ' 
        ' TBName
        ' 
        TBName.Location = New Point(82, 31)
        TBName.Name = "TBName"
        TBName.Size = New Size(208, 23)
        TBName.TabIndex = 5
        ' 
        ' LDNI
        ' 
        LDNI.AutoSize = True
        LDNI.Location = New Point(6, 108)
        LDNI.Name = "LDNI"
        LDNI.Size = New Size(32, 15)
        LDNI.TabIndex = 4
        LDNI.Text = "DNI:"
        ' 
        ' LApellido
        ' 
        LApellido.AutoSize = True
        LApellido.Location = New Point(6, 71)
        LApellido.Name = "LApellido"
        LApellido.Size = New Size(55, 15)
        LApellido.TabIndex = 3
        LApellido.Text = "Apellido:"
        ' 
        ' LEmail
        ' 
        LEmail.AutoSize = True
        LEmail.Location = New Point(6, 288)
        LEmail.Name = "LEmail"
        LEmail.Size = New Size(39, 15)
        LEmail.TabIndex = 2
        LEmail.Text = "Email:"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(6, 324)
        LTelefono.Name = "LTelefono"
        LTelefono.Size = New Size(59, 15)
        LTelefono.TabIndex = 1
        LTelefono.Text = "Telefono:"
        ' 
        ' LNombre
        ' 
        LNombre.AutoSize = True
        LNombre.Location = New Point(6, 34)
        LNombre.Name = "LNombre"
        LNombre.Size = New Size(56, 15)
        LNombre.TabIndex = 0
        LNombre.Text = "Nombre:"
        ' 
        ' FormManageUsers
        ' 
        AcceptButton = BSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BCancel
        ClientSize = New Size(330, 450)
        Controls.Add(GBUserData)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLightLight
        Name = "FormManageUsers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta de Nuevo Usuario - OnlyMotos ERP"
        GBUserData.ResumeLayout(False)
        GBUserData.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBUserData As GroupBox
    Friend WithEvents TBUser As TextBox
    Friend WithEvents LUser As Label
    Friend WithEvents BCancel As Button
    Friend WithEvents BSave As Button
    Friend WithEvents TBPhone As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents TBLastName As TextBox
    Friend WithEvents TBName As TextBox
    Friend WithEvents LDNI As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents LEmail As Label
    Friend WithEvents LTelefono As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LPassword As Label
    Friend WithEvents CBProfile As ComboBox
End Class
