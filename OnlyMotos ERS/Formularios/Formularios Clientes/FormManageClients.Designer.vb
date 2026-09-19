<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageClients
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
        GBData = New GroupBox()
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
        GBData.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBData
        ' 
        GBData.Controls.Add(BCancel)
        GBData.Controls.Add(BSave)
        GBData.Controls.Add(TBPhone)
        GBData.Controls.Add(TBEmail)
        GBData.Controls.Add(TBDNI)
        GBData.Controls.Add(TBLastName)
        GBData.Controls.Add(TBName)
        GBData.Controls.Add(LDNI)
        GBData.Controls.Add(LApellido)
        GBData.Controls.Add(LEmail)
        GBData.Controls.Add(LTelefono)
        GBData.Controls.Add(LNombre)
        GBData.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBData.ForeColor = SystemColors.ControlLightLight
        GBData.Location = New Point(12, 12)
        GBData.Name = "GBData"
        GBData.Size = New Size(304, 290)
        GBData.TabIndex = 0
        GBData.TabStop = False
        GBData.Text = "Datos del Cliente"
        ' 
        ' BCancel
        ' 
        BCancel.ForeColor = SystemColors.ControlText
        BCancel.Location = New Point(32, 258)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(75, 23)
        BCancel.TabIndex = 11
        BCancel.Text = "Cancelar"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' BSave
        ' 
        BSave.ForeColor = SystemColors.ControlText
        BSave.Location = New Point(186, 258)
        BSave.Name = "BSave"
        BSave.Size = New Size(75, 23)
        BSave.TabIndex = 10
        BSave.Text = "Guardar"
        BSave.UseVisualStyleBackColor = True
        ' 
        ' TBPhone
        ' 
        TBPhone.Location = New Point(68, 183)
        TBPhone.Name = "TBPhone"
        TBPhone.Size = New Size(222, 23)
        TBPhone.TabIndex = 9
        ' 
        ' TBEmail
        ' 
        TBEmail.Location = New Point(68, 147)
        TBEmail.Name = "TBEmail"
        TBEmail.Size = New Size(222, 23)
        TBEmail.TabIndex = 8
        ' 
        ' TBDNI
        ' 
        TBDNI.Location = New Point(68, 108)
        TBDNI.Name = "TBDNI"
        TBDNI.Size = New Size(222, 23)
        TBDNI.TabIndex = 7
        ' 
        ' TBLastName
        ' 
        TBLastName.Location = New Point(68, 68)
        TBLastName.Name = "TBLastName"
        TBLastName.Size = New Size(222, 23)
        TBLastName.TabIndex = 6
        ' 
        ' TBName
        ' 
        TBName.Location = New Point(68, 31)
        TBName.Name = "TBName"
        TBName.Size = New Size(222, 23)
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
        LEmail.Location = New Point(6, 150)
        LEmail.Name = "LEmail"
        LEmail.Size = New Size(39, 15)
        LEmail.TabIndex = 2
        LEmail.Text = "Email:"
        ' 
        ' LTelefono
        ' 
        LTelefono.AutoSize = True
        LTelefono.Location = New Point(6, 186)
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
        ' FormManageClients
        ' 
        AcceptButton = BSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BCancel
        ClientSize = New Size(325, 320)
        Controls.Add(GBData)
        Name = "FormManageClients"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Nuevo Cliente - OnlyMotos ERP"
        GBData.ResumeLayout(False)
        GBData.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBData As GroupBox
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
    Friend WithEvents BCancel As Button
    Friend WithEvents BSave As Button
End Class
