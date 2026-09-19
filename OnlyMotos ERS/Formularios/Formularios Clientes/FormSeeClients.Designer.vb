<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeeClients
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
        GBFilters = New GroupBox()
        BClearFilters = New Button()
        TBSearch = New TextBox()
        LSearch = New Label()
        BSearch = New Button()
        DGVClients = New DataGridView()
        IdCliente = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        Apellido = New DataGridViewTextBoxColumn()
        DNI = New DataGridViewTextBoxColumn()
        Email = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        GBActions = New GroupBox()
        BAddClient = New Button()
        BDeleteClient = New Button()
        BClose = New Button()
        GBFilters.SuspendLayout()
        CType(DGVClients, ComponentModel.ISupportInitialize).BeginInit()
        GBActions.SuspendLayout()
        SuspendLayout()
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
        GBFilters.TabIndex = 4
        GBFilters.TabStop = False
        GBFilters.Text = "Filtro"
        ' 
        ' BClearFilters
        ' 
        BClearFilters.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        TBSearch.Location = New Point(89, 54)
        TBSearch.Name = "TBSearch"
        TBSearch.Size = New Size(262, 23)
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
        BSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BSearch.ForeColor = SystemColors.ControlText
        BSearch.Location = New Point(230, 116)
        BSearch.Name = "BSearch"
        BSearch.Size = New Size(75, 23)
        BSearch.TabIndex = 1
        BSearch.Text = "Buscar"
        BSearch.UseVisualStyleBackColor = True
        ' 
        ' DGVClients
        ' 
        DGVClients.AllowUserToAddRows = False
        DGVClients.AllowUserToDeleteRows = False
        DGVClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVClients.Columns.AddRange(New DataGridViewColumn() {IdCliente, Nombre, Apellido, DNI, Email, Telefono, Estado})
        DGVClients.Location = New Point(32, 194)
        DGVClients.Name = "DGVClients"
        DGVClients.Size = New Size(743, 244)
        DGVClients.TabIndex = 5
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
        ' GBActions
        ' 
        GBActions.Controls.Add(BAddClient)
        GBActions.Controls.Add(BDeleteClient)
        GBActions.Controls.Add(BClose)
        GBActions.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBActions.ForeColor = SystemColors.ControlLightLight
        GBActions.Location = New Point(445, 12)
        GBActions.Name = "GBActions"
        GBActions.Size = New Size(343, 158)
        GBActions.TabIndex = 6
        GBActions.TabStop = False
        GBActions.Text = "Acciones"
        ' 
        ' BAddClient
        ' 
        BAddClient.Font = New Font("Segoe UI", 9F)
        BAddClient.ForeColor = SystemColors.ControlText
        BAddClient.Image = My.Resources.Resources.Icono_insertar_Usuario_Cliente_chiquito
        BAddClient.ImageAlign = ContentAlignment.BottomCenter
        BAddClient.Location = New Point(243, 50)
        BAddClient.Name = "BAddClient"
        BAddClient.Size = New Size(94, 58)
        BAddClient.TabIndex = 9
        BAddClient.Text = "Nuevo Cliente"
        BAddClient.TextAlign = ContentAlignment.TopCenter
        BAddClient.UseVisualStyleBackColor = True
        ' 
        ' BDeleteClient
        ' 
        BDeleteClient.Font = New Font("Segoe UI", 9F)
        BDeleteClient.ForeColor = SystemColors.ControlText
        BDeleteClient.Location = New Point(121, 50)
        BDeleteClient.Name = "BDeleteClient"
        BDeleteClient.Size = New Size(102, 58)
        BDeleteClient.TabIndex = 8
        BDeleteClient.Text = "Eliminar Cliente"
        BDeleteClient.UseVisualStyleBackColor = True
        ' 
        ' BClose
        ' 
        BClose.Font = New Font("Segoe UI", 9F)
        BClose.ForeColor = SystemColors.ControlText
        BClose.Image = My.Resources.Resources.Icono_Cancelar_Chiquito
        BClose.ImageAlign = ContentAlignment.MiddleRight
        BClose.Location = New Point(6, 50)
        BClose.Name = "BClose"
        BClose.Size = New Size(94, 58)
        BClose.TabIndex = 7
        BClose.Text = "Cerrar"
        BClose.UseVisualStyleBackColor = True
        ' 
        ' FormSeeClients
        ' 
        AcceptButton = BSearch
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BClose
        ClientSize = New Size(800, 450)
        Controls.Add(GBActions)
        Controls.Add(DGVClients)
        Controls.Add(GBFilters)
        ForeColor = SystemColors.ControlText
        Name = "FormSeeClients"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lista de Clientes - OnlyMotos ERP"
        GBFilters.ResumeLayout(False)
        GBFilters.PerformLayout()
        CType(DGVClients, ComponentModel.ISupportInitialize).EndInit()
        GBActions.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBFilters As GroupBox
    Friend WithEvents BClearFilters As Button
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents LSearch As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents DGVClients As DataGridView
    Friend WithEvents IdCliente As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents GBActions As GroupBox
    Friend WithEvents BAddClient As Button
    Friend WithEvents BDeleteClient As Button
    Friend WithEvents BClose As Button
End Class
