<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeeUsers
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
        GBActions = New GroupBox()
        BAddUser = New Button()
        BDeleteUser = New Button()
        BClose = New Button()
        DGVUsers = New DataGridView()
        IdCliente = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        DNI = New DataGridViewTextBoxColumn()
        Usuario = New DataGridViewTextBoxColumn()
        Perfil = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GBFilters = New GroupBox()
        BClearFilters = New Button()
        TBSearch = New TextBox()
        LSearch = New Label()
        BSearch = New Button()
        GBActions.SuspendLayout()
        CType(DGVUsers, ComponentModel.ISupportInitialize).BeginInit()
        GBFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBActions
        ' 
        GBActions.Controls.Add(BAddUser)
        GBActions.Controls.Add(BDeleteUser)
        GBActions.Controls.Add(BClose)
        GBActions.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBActions.ForeColor = SystemColors.ControlLightLight
        GBActions.Location = New Point(460, 12)
        GBActions.Name = "GBActions"
        GBActions.Size = New Size(395, 158)
        GBActions.TabIndex = 9
        GBActions.TabStop = False
        GBActions.Text = "Acciones"
        ' 
        ' BAddUser
        ' 
        BAddUser.Font = New Font("Segoe UI", 9F)
        BAddUser.ForeColor = SystemColors.ControlText
        BAddUser.Image = My.Resources.Resources.Icono_insertar_Usuario_Cliente_chiquito
        BAddUser.ImageAlign = ContentAlignment.MiddleRight
        BAddUser.Location = New Point(295, 50)
        BAddUser.Name = "BAddUser"
        BAddUser.Size = New Size(94, 58)
        BAddUser.TabIndex = 9
        BAddUser.Text = "Nuevo Usuario"
        BAddUser.TextImageRelation = TextImageRelation.TextBeforeImage
        BAddUser.UseVisualStyleBackColor = True
        ' 
        ' BDeleteUser
        ' 
        BDeleteUser.Font = New Font("Segoe UI", 9F)
        BDeleteUser.ForeColor = SystemColors.ControlText
        BDeleteUser.Location = New Point(156, 50)
        BDeleteUser.Name = "BDeleteUser"
        BDeleteUser.Size = New Size(102, 58)
        BDeleteUser.TabIndex = 8
        BDeleteUser.Text = "Eliminar Usuario"
        BDeleteUser.UseVisualStyleBackColor = True
        ' 
        ' BClose
        ' 
        BClose.Font = New Font("Segoe UI", 9F)
        BClose.ForeColor = SystemColors.ControlText
        BClose.Image = My.Resources.Resources.Icono_Cancelar_Chiquito
        BClose.ImageAlign = ContentAlignment.MiddleRight
        BClose.Location = New Point(24, 50)
        BClose.Name = "BClose"
        BClose.Size = New Size(94, 58)
        BClose.TabIndex = 7
        BClose.Text = "Cerrar"
        BClose.UseVisualStyleBackColor = True
        ' 
        ' DGVUsers
        ' 
        DGVUsers.AllowUserToAddRows = False
        DGVUsers.AllowUserToDeleteRows = False
        DGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVUsers.Columns.AddRange(New DataGridViewColumn() {IdCliente, Nombre, Apellido, DNI, Usuario, Perfil, Email, Telefono, Estado})
        DGVUsers.Location = New Point(12, 194)
        DGVUsers.Name = "DGVUsers"
        DGVUsers.Size = New Size(843, 244)
        DGVUsers.TabIndex = 8
        ' 
        ' IdCliente
        ' 
        IdCliente.HeaderText = "ID"
        IdCliente.Name = "IdCliente"
        IdCliente.ReadOnly = True
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' Apellido
        ' 
        Apellido.HeaderText = "Apellido"
        Apellido.Name = "Apellido"
        ' 
        ' DNI
        ' 
        DNI.HeaderText = "DNI"
        DNI.Name = "DNI"
        DNI.ReadOnly = True
        ' 
        ' Usuario
        ' 
        Usuario.HeaderText = "Usuario"
        Usuario.Name = "Usuario"
        Usuario.ReadOnly = True
        ' 
        ' Perfil
        ' 
        Perfil.HeaderText = "Rol"
        Perfil.Name = "Perfil"
        Perfil.ReadOnly = True
        ' 
        ' Email
        ' 
        Email.HeaderText = "Email"
        Email.Name = "Email"
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.Name = "Telefono"
        ' 
        ' Estado
        ' 
        Estado.HeaderText = "Estado"
        Estado.Name = "Estado"
        Estado.ReadOnly = True
        ' 
        ' GBFilters
        ' 
        GBFilters.Controls.Add(BClearFilters)
        GBFilters.Controls.Add(TBSearch)
        GBFilters.Controls.Add(LSearch)
        GBFilters.Controls.Add(BSearch)
        GBFilters.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBFilters.ForeColor = SystemColors.ControlLightLight
        GBFilters.Location = New Point(12, 12)
        GBFilters.Name = "GBFilters"
        GBFilters.Size = New Size(357, 158)
        GBFilters.TabIndex = 7
        GBFilters.TabStop = False
        GBFilters.Text = "Filtro"
        ' 
        ' BClearFilters
        ' 
        BClearFilters.Font = New Font("Segoe UI", 9F)
        BClearFilters.ForeColor = SystemColors.ControlText
        BClearFilters.Location = New Point(43, 116)
        BClearFilters.Name = "BClearFilters"
        BClearFilters.Size = New Size(75, 23)
        BClearFilters.TabIndex = 4
        BClearFilters.Text = "Limpiar Filtros"
        BClearFilters.UseVisualStyleBackColor = True
        ' 
        ' TBSearch
        ' 
        TBSearch.Location = New Point(56, 54)
        TBSearch.Name = "TBSearch"
        TBSearch.Size = New Size(295, 23)
        TBSearch.TabIndex = 0
        ' 
        ' LSearch
        ' 
        LSearch.AutoSize = True
        LSearch.Location = New Point(20, 57)
        LSearch.Name = "LSearch"
        LSearch.Size = New Size(32, 15)
        LSearch.TabIndex = 2
        LSearch.Text = "DNI:"
        ' 
        ' BSearch
        ' 
        BSearch.Font = New Font("Segoe UI", 9F)
        BSearch.ForeColor = SystemColors.ControlText
        BSearch.Location = New Point(230, 116)
        BSearch.Name = "BSearch"
        BSearch.Size = New Size(75, 23)
        BSearch.TabIndex = 1
        BSearch.Text = "Buscar"
        BSearch.UseVisualStyleBackColor = True
        ' 
        ' FormSeeUsers
        ' 
        AcceptButton = BSearch
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BClose
        ClientSize = New Size(867, 450)
        Controls.Add(GBActions)
        Controls.Add(DGVUsers)
        Controls.Add(GBFilters)
        Name = "FormSeeUsers"
        Text = "Lista de Usuarios"
        GBActions.ResumeLayout(False)
        CType(DGVUsers, ComponentModel.ISupportInitialize).EndInit()
        GBFilters.ResumeLayout(False)
        GBFilters.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBActions As GroupBox
    Friend WithEvents BAddUser As Button
    Friend WithEvents BDeleteUser As Button
    Friend WithEvents BClose As Button
    Friend WithEvents DGVUsers As DataGridView
    Friend WithEvents GBFilters As GroupBox
    Friend WithEvents BClearFilters As Button
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents LSearch As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Perfil As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
