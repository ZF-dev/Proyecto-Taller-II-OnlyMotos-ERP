<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeeProducts
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
        Label1 = New Label()
        BSearch = New Button()
        LSearch = New Label()
        GBFilters = New GroupBox()
        BClearFilters = New Button()
        TBSearch = New TextBox()
        DGVProducts = New DataGridView()
        IdMoto = New DataGridViewTextBoxColumn()
        Marca = New DataGridViewTextBoxColumn()
        Modelo = New DataGridViewTextBoxColumn()
        Año = New DataGridViewTextBoxColumn()
        CC = New DataGridViewTextBoxColumn()
        Stock = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Imagen = New DataGridViewImageColumn()
        BClose = New Button()
        BDeleteProduct = New Button()
        GBFilters.SuspendLayout()
        CType(DGVProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' BSearch
        ' 
        BSearch.Font = New Font("Segoe UI", 9F)
        BSearch.ForeColor = SystemColors.ControlText
        BSearch.Location = New Point(230, 116)
        BSearch.Name = "BSearch"
        BSearch.Size = New Size(75, 23)
        BSearch.TabIndex = 1
        BSearch.Text = "Aplicar"
        BSearch.UseVisualStyleBackColor = True
        ' 
        ' LSearch
        ' 
        LSearch.AutoSize = True
        LSearch.Location = New Point(20, 57)
        LSearch.Name = "LSearch"
        LSearch.Size = New Size(52, 15)
        LSearch.TabIndex = 2
        LSearch.Text = "Modelo:"
        ' 
        ' GBFilters
        ' 
        GBFilters.Controls.Add(BClearFilters)
        GBFilters.Controls.Add(TBSearch)
        GBFilters.Controls.Add(LSearch)
        GBFilters.Controls.Add(BSearch)
        GBFilters.ForeColor = SystemColors.ControlLight
        GBFilters.Location = New Point(12, 12)
        GBFilters.Name = "GBFilters"
        GBFilters.Size = New Size(357, 158)
        GBFilters.TabIndex = 3
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
        TBSearch.Location = New Point(89, 54)
        TBSearch.Name = "TBSearch"
        TBSearch.Size = New Size(262, 23)
        TBSearch.TabIndex = 0
        ' 
        ' DGVProducts
        ' 
        DGVProducts.AllowUserToAddRows = False
        DGVProducts.AllowUserToDeleteRows = False
        DGVProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVProducts.Columns.AddRange(New DataGridViewColumn() {IdMoto, Marca, Modelo, Año, CC, Stock, Precio, Imagen})
        DGVProducts.Location = New Point(12, 194)
        DGVProducts.Name = "DGVProducts"
        DGVProducts.Size = New Size(837, 244)
        DGVProducts.TabIndex = 4
        ' 
        ' IdMoto
        ' 
        IdMoto.HeaderText = "Id Moto"
        IdMoto.Name = "IdMoto"
        IdMoto.ReadOnly = True
        ' 
        ' Marca
        ' 
        Marca.HeaderText = "Marca"
        Marca.Name = "Marca"
        Marca.ReadOnly = True
        ' 
        ' Modelo
        ' 
        Modelo.HeaderText = "Modelo"
        Modelo.Name = "Modelo"
        Modelo.ReadOnly = True
        ' 
        ' Año
        ' 
        Año.HeaderText = "Año"
        Año.Name = "Año"
        Año.ReadOnly = True
        ' 
        ' CC
        ' 
        CC.HeaderText = "Cilindrada"
        CC.Name = "CC"
        CC.ReadOnly = True
        ' 
        ' Stock
        ' 
        Stock.HeaderText = "Stock"
        Stock.Name = "Stock"
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.Name = "Precio"
        Precio.ReadOnly = True
        ' 
        ' Imagen
        ' 
        Imagen.HeaderText = "Vista"
        Imagen.Image = My.Resources.Resources.OnlyMotos_Logo
        Imagen.ImageLayout = DataGridViewImageCellLayout.Zoom
        Imagen.Name = "Imagen"
        Imagen.ReadOnly = True
        ' 
        ' BClose
        ' 
        BClose.Font = New Font("Segoe UI", 9F)
        BClose.ForeColor = SystemColors.ControlText
        BClose.Location = New Point(545, 57)
        BClose.Name = "BClose"
        BClose.Size = New Size(94, 58)
        BClose.TabIndex = 5
        BClose.Text = "Cerrar"
        BClose.UseVisualStyleBackColor = True
        ' 
        ' BDeleteProduct
        ' 
        BDeleteProduct.Font = New Font("Segoe UI", 9F)
        BDeleteProduct.ForeColor = SystemColors.ControlText
        BDeleteProduct.Location = New Point(686, 57)
        BDeleteProduct.Name = "BDeleteProduct"
        BDeleteProduct.Size = New Size(102, 58)
        BDeleteProduct.TabIndex = 6
        BDeleteProduct.Text = "Eliminar Moto"
        BDeleteProduct.UseVisualStyleBackColor = True
        ' 
        ' FormSeeProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(861, 450)
        Controls.Add(BDeleteProduct)
        Controls.Add(BClose)
        Controls.Add(DGVProducts)
        Controls.Add(GBFilters)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ControlLightLight
        Name = "FormSeeProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catálogo de Motos - OnlyMotos ERP"
        GBFilters.ResumeLayout(False)
        GBFilters.PerformLayout()
        CType(DGVProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents LSearch As Label
    Friend WithEvents GBFilters As GroupBox
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents BClearFilters As Button
    Friend WithEvents DGVProducts As DataGridView
    Friend WithEvents BClose As Button
    Friend WithEvents BDeleteProduct As Button
    Friend WithEvents IdMoto As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Año As DataGridViewTextBoxColumn
    Friend WithEvents CC As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewImageColumn
End Class
