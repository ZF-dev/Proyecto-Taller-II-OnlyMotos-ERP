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
        CC = New DataGridViewTextBoxColumn()
        Stock = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
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
        LSearch.Size = New Size(51, 15)
        LSearch.TabIndex = 2
        LSearch.Text = "Modelo:"
        ' 
        ' GBFilters
        ' 
        GBFilters.Controls.Add(BClearFilters)
        GBFilters.Controls.Add(TBSearch)
        GBFilters.Controls.Add(LSearch)
        GBFilters.Controls.Add(BSearch)
        GBFilters.Location = New Point(12, 12)
        GBFilters.Name = "GBFilters"
        GBFilters.Size = New Size(357, 158)
        GBFilters.TabIndex = 3
        GBFilters.TabStop = False
        GBFilters.Text = "Filtro"
        ' 
        ' BClearFilters
        ' 
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
        DGVProducts.Columns.AddRange(New DataGridViewColumn() {IdMoto, Marca, Modelo, CC, Stock, Precio})
        DGVProducts.Location = New Point(69, 194)
        DGVProducts.Name = "DGVProducts"
        DGVProducts.Size = New Size(643, 244)
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
        ' BClose
        ' 
        BClose.Location = New Point(545, 57)
        BClose.Name = "BClose"
        BClose.Size = New Size(94, 58)
        BClose.TabIndex = 5
        BClose.Text = "Cerrar"
        BClose.UseVisualStyleBackColor = True
        ' 
        ' BDeleteProduct
        ' 
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
        ClientSize = New Size(800, 450)
        Controls.Add(BDeleteProduct)
        Controls.Add(BClose)
        Controls.Add(DGVProducts)
        Controls.Add(GBFilters)
        Controls.Add(Label1)
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
    Friend WithEvents CC As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
End Class
