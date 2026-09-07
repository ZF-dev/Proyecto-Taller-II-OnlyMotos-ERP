<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageProducts
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
        LStockMin = New Label()
        NUDStockMin = New NumericUpDown()
        LStock = New Label()
        LPrice = New Label()
        LCylinder = New Label()
        LModel = New Label()
        LBrand = New Label()
        BCancel = New Button()
        BSave = New Button()
        NUDStock = New NumericUpDown()
        TBPrice = New TextBox()
        TBCylinder = New TextBox()
        TBModel = New TextBox()
        TBBrand = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        GBData.SuspendLayout()
        CType(NUDStockMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NUDStock, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GBData
        ' 
        GBData.Controls.Add(LStockMin)
        GBData.Controls.Add(NUDStockMin)
        GBData.Controls.Add(LStock)
        GBData.Controls.Add(LPrice)
        GBData.Controls.Add(LCylinder)
        GBData.Controls.Add(LModel)
        GBData.Controls.Add(LBrand)
        GBData.Controls.Add(BCancel)
        GBData.Controls.Add(BSave)
        GBData.Controls.Add(NUDStock)
        GBData.Controls.Add(TBPrice)
        GBData.Controls.Add(TBCylinder)
        GBData.Controls.Add(TBModel)
        GBData.Controls.Add(TBBrand)
        GBData.Location = New Point(0, 12)
        GBData.Name = "GBData"
        GBData.Size = New Size(800, 374)
        GBData.TabIndex = 0
        GBData.TabStop = False
        GBData.Text = "Datos de la Moto"
        ' 
        ' LStockMin
        ' 
        LStockMin.AutoSize = True
        LStockMin.Location = New Point(35, 326)
        LStockMin.Name = "LStockMin"
        LStockMin.Size = New Size(84, 15)
        LStockMin.TabIndex = 13
        LStockMin.Text = "Stock Minimo:"
        ' 
        ' NUDStockMin
        ' 
        NUDStockMin.Location = New Point(128, 318)
        NUDStockMin.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        NUDStockMin.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NUDStockMin.Name = "NUDStockMin"
        NUDStockMin.Size = New Size(71, 23)
        NUDStockMin.TabIndex = 12
        NUDStockMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' LStock
        ' 
        LStock.AutoSize = True
        LStock.Location = New Point(35, 259)
        LStock.Name = "LStock"
        LStock.Size = New Size(73, 15)
        LStock.TabIndex = 11
        LStock.Text = "Stock Inicial:"
        ' 
        ' LPrice
        ' 
        LPrice.AutoSize = True
        LPrice.Location = New Point(35, 190)
        LPrice.Name = "LPrice"
        LPrice.Size = New Size(36, 15)
        LPrice.TabIndex = 10
        LPrice.Text = "Price:"
        ' 
        ' LCylinder
        ' 
        LCylinder.AutoSize = True
        LCylinder.Location = New Point(35, 133)
        LCylinder.Name = "LCylinder"
        LCylinder.Size = New Size(64, 15)
        LCylinder.TabIndex = 9
        LCylinder.Text = "Cilindrada:"
        ' 
        ' LModel
        ' 
        LModel.AutoSize = True
        LModel.Location = New Point(35, 81)
        LModel.Name = "LModel"
        LModel.Size = New Size(51, 15)
        LModel.TabIndex = 8
        LModel.Text = "Modelo:"
        ' 
        ' LBrand
        ' 
        LBrand.AutoSize = True
        LBrand.Location = New Point(35, 40)
        LBrand.Name = "LBrand"
        LBrand.Size = New Size(43, 15)
        LBrand.TabIndex = 7
        LBrand.Text = "Marca:"
        ' 
        ' BCancel
        ' 
        BCancel.Location = New Point(584, 245)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(112, 58)
        BCancel.TabIndex = 6
        BCancel.Text = "Cancelar carga"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' BSave
        ' 
        BSave.Location = New Point(584, 127)
        BSave.Name = "BSave"
        BSave.Size = New Size(112, 58)
        BSave.TabIndex = 5
        BSave.Text = "Agregar Moto"
        BSave.UseVisualStyleBackColor = True
        ' 
        ' NUDStock
        ' 
        NUDStock.Location = New Point(128, 251)
        NUDStock.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        NUDStock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NUDStock.Name = "NUDStock"
        NUDStock.Size = New Size(71, 23)
        NUDStock.TabIndex = 4
        NUDStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' TBPrice
        ' 
        TBPrice.Location = New Point(128, 187)
        TBPrice.Name = "TBPrice"
        TBPrice.Size = New Size(166, 23)
        TBPrice.TabIndex = 3
        TBPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' TBCylinder
        ' 
        TBCylinder.Location = New Point(128, 133)
        TBCylinder.Name = "TBCylinder"
        TBCylinder.Size = New Size(100, 23)
        TBCylinder.TabIndex = 2
        ' 
        ' TBModel
        ' 
        TBModel.Location = New Point(128, 81)
        TBModel.Name = "TBModel"
        TBModel.Size = New Size(239, 23)
        TBModel.TabIndex = 1
        ' 
        ' TBBrand
        ' 
        TBBrand.CharacterCasing = CharacterCasing.Upper
        TBBrand.Location = New Point(128, 37)
        TBBrand.Name = "TBBrand"
        TBBrand.Size = New Size(239, 23)
        TBBrand.TabIndex = 0
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(128, 341)
        NumericUpDown1.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 12
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' FormManageProducts
        ' 
        AcceptButton = BSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BCancel
        ClientSize = New Size(800, 387)
        Controls.Add(GBData)
        Controls.Add(NumericUpDown1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormManageProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Alta de Nueva Moto - OnlyMotos ERP"
        GBData.ResumeLayout(False)
        GBData.PerformLayout()
        CType(NUDStockMin, ComponentModel.ISupportInitialize).EndInit()
        CType(NUDStock, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBData As GroupBox
    Friend WithEvents TBBrand As TextBox
    Friend WithEvents LStock As Label
    Friend WithEvents LPrice As Label
    Friend WithEvents LCylinder As Label
    Friend WithEvents LModel As Label
    Friend WithEvents LBrand As Label
    Friend WithEvents BCancel As Button
    Friend WithEvents BSave As Button
    Friend WithEvents NUDStock As NumericUpDown
    Friend WithEvents TBPrice As TextBox
    Friend WithEvents TBCylinder As TextBox
    Friend WithEvents TBModel As TextBox
    Friend WithEvents NUDStockMin As NumericUpDown
    Friend WithEvents LStockMin As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
