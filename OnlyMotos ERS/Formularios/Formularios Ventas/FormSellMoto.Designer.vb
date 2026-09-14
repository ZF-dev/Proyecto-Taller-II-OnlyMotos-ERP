<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSellMoto
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
        GBHeader = New GroupBox()
        TBUser = New TextBox()
        LUser = New Label()
        LTicketType = New Label()
        CBTicketType = New ComboBox()
        LDate = New Label()
        DTPDate = New DateTimePicker()
        GBClient = New GroupBox()
        TBDni = New TextBox()
        LDni = New Label()
        BAddClient = New Button()
        CBClient = New ComboBox()
        LClient = New Label()
        GroupBox1 = New GroupBox()
        BAddProduct = New Button()
        NUDQuantity = New NumericUpDown()
        LQuantity = New Label()
        TBUnitPrice = New TextBox()
        Label1 = New Label()
        CBMoto = New ComboBox()
        LMoto = New Label()
        DGVDetails = New DataGridView()
        IdMoto = New DataGridViewTextBoxColumn()
        Model = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        SubTotal = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        BSaveSell = New Button()
        BRemoveProduct = New Button()
        TBTotal = New TextBox()
        BCancel = New Button()
        LTotal = New Label()
        GBHeader.SuspendLayout()
        GBClient.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NUDQuantity, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVDetails, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBHeader
        ' 
        GBHeader.Controls.Add(TBUser)
        GBHeader.Controls.Add(LUser)
        GBHeader.Controls.Add(LTicketType)
        GBHeader.Controls.Add(CBTicketType)
        GBHeader.Controls.Add(LDate)
        GBHeader.Controls.Add(DTPDate)
        GBHeader.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBHeader.ForeColor = SystemColors.ControlLightLight
        GBHeader.Location = New Point(12, 12)
        GBHeader.Name = "GBHeader"
        GBHeader.Size = New Size(327, 123)
        GBHeader.TabIndex = 0
        GBHeader.TabStop = False
        GBHeader.Text = "1-Datos de la Venta"
        ' 
        ' TBUser
        ' 
        TBUser.Location = New Point(112, 82)
        TBUser.Name = "TBUser"
        TBUser.ReadOnly = True
        TBUser.Size = New Size(183, 23)
        TBUser.TabIndex = 5
        ' 
        ' LUser
        ' 
        LUser.AutoSize = True
        LUser.Location = New Point(6, 86)
        LUser.Name = "LUser"
        LUser.Size = New Size(52, 15)
        LUser.TabIndex = 4
        LUser.Text = "Usuario:"
        ' 
        ' LTicketType
        ' 
        LTicketType.AutoSize = True
        LTicketType.Location = New Point(8, 55)
        LTicketType.Name = "LTicketType"
        LTicketType.Size = New Size(94, 15)
        LTicketType.TabIndex = 3
        LTicketType.Text = "Tipo de factura:"
        ' 
        ' CBTicketType
        ' 
        CBTicketType.FormattingEnabled = True
        CBTicketType.Items.AddRange(New Object() {"Factura A", "Factura B", "Factura C", "Factura D"})
        CBTicketType.Location = New Point(115, 55)
        CBTicketType.Name = "CBTicketType"
        CBTicketType.Size = New Size(66, 23)
        CBTicketType.TabIndex = 2
        ' 
        ' LDate
        ' 
        LDate.AutoSize = True
        LDate.Location = New Point(8, 22)
        LDate.Name = "LDate"
        LDate.Size = New Size(106, 15)
        LDate.TabIndex = 1
        LDate.Text = "Fecha de la Venta:"
        ' 
        ' DTPDate
        ' 
        DTPDate.Enabled = False
        DTPDate.Format = DateTimePickerFormat.Short
        DTPDate.Location = New Point(112, 16)
        DTPDate.Name = "DTPDate"
        DTPDate.Size = New Size(107, 23)
        DTPDate.TabIndex = 0
        ' 
        ' GBClient
        ' 
        GBClient.Controls.Add(TBDni)
        GBClient.Controls.Add(LDni)
        GBClient.Controls.Add(BAddClient)
        GBClient.Controls.Add(CBClient)
        GBClient.Controls.Add(LClient)
        GBClient.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBClient.ForeColor = SystemColors.ControlLightLight
        GBClient.Location = New Point(381, 12)
        GBClient.Name = "GBClient"
        GBClient.Size = New Size(441, 123)
        GBClient.TabIndex = 6
        GBClient.TabStop = False
        GBClient.Text = "2-Datos del Cliente"
        ' 
        ' TBDni
        ' 
        TBDni.Location = New Point(61, 51)
        TBDni.Name = "TBDni"
        TBDni.Size = New Size(260, 23)
        TBDni.TabIndex = 5
        ' 
        ' LDni
        ' 
        LDni.AutoSize = True
        LDni.Location = New Point(8, 55)
        LDni.Name = "LDni"
        LDni.Size = New Size(32, 15)
        LDni.TabIndex = 4
        LDni.Text = "DNI:"
        ' 
        ' BAddClient
        ' 
        BAddClient.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAddClient.ForeColor = SystemColors.ControlText
        BAddClient.Image = My.Resources.Resources.Icono_insertar_Usuario_Cliente_chiquito
        BAddClient.Location = New Point(185, 79)
        BAddClient.Name = "BAddClient"
        BAddClient.Size = New Size(78, 38)
        BAddClient.TabIndex = 3
        BAddClient.Text = "Nuevo Cliente"
        BAddClient.TextImageRelation = TextImageRelation.TextBeforeImage
        BAddClient.UseVisualStyleBackColor = True
        ' 
        ' CBClient
        ' 
        CBClient.AutoCompleteCustomSource.AddRange(New String() {"Pepe", "Seba"})
        CBClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CBClient.AutoCompleteSource = AutoCompleteSource.ListItems
        CBClient.FormattingEnabled = True
        CBClient.Location = New Point(61, 16)
        CBClient.Name = "CBClient"
        CBClient.Size = New Size(260, 23)
        CBClient.TabIndex = 2
        ' 
        ' LClient
        ' 
        LClient.AutoSize = True
        LClient.Location = New Point(8, 22)
        LClient.Name = "LClient"
        LClient.Size = New Size(49, 15)
        LClient.TabIndex = 1
        LClient.Text = "Cliente:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(BAddProduct)
        GroupBox1.Controls.Add(NUDQuantity)
        GroupBox1.Controls.Add(LQuantity)
        GroupBox1.Controls.Add(TBUnitPrice)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(CBMoto)
        GroupBox1.Controls.Add(LMoto)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(12, 160)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(327, 123)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "3-Seleccionar Moto:"
        ' 
        ' BAddProduct
        ' 
        BAddProduct.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAddProduct.ForeColor = SystemColors.ControlText
        BAddProduct.Location = New Point(228, 79)
        BAddProduct.Name = "BAddProduct"
        BAddProduct.Size = New Size(93, 38)
        BAddProduct.TabIndex = 8
        BAddProduct.Text = "Agregar a la Venta"
        BAddProduct.UseVisualStyleBackColor = True
        ' 
        ' NUDQuantity
        ' 
        NUDQuantity.Location = New Point(73, 83)
        NUDQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NUDQuantity.Name = "NUDQuantity"
        NUDQuantity.Size = New Size(38, 23)
        NUDQuantity.TabIndex = 7
        NUDQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' LQuantity
        ' 
        LQuantity.AutoSize = True
        LQuantity.Location = New Point(8, 85)
        LQuantity.Name = "LQuantity"
        LQuantity.Size = New Size(61, 15)
        LQuantity.TabIndex = 6
        LQuantity.Text = "Unidades:"
        ' 
        ' TBUnitPrice
        ' 
        TBUnitPrice.Location = New Point(61, 47)
        TBUnitPrice.Name = "TBUnitPrice"
        TBUnitPrice.ReadOnly = True
        TBUnitPrice.Size = New Size(129, 23)
        TBUnitPrice.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 4
        Label1.Text = "Precio:"
        ' 
        ' CBMoto
        ' 
        CBMoto.AutoCompleteCustomSource.AddRange(New String() {"Pepe", "Seba"})
        CBMoto.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CBMoto.AutoCompleteSource = AutoCompleteSource.ListItems
        CBMoto.FormattingEnabled = True
        CBMoto.Location = New Point(61, 16)
        CBMoto.Name = "CBMoto"
        CBMoto.Size = New Size(260, 23)
        CBMoto.TabIndex = 2
        ' 
        ' LMoto
        ' 
        LMoto.AutoSize = True
        LMoto.Location = New Point(8, 22)
        LMoto.Name = "LMoto"
        LMoto.Size = New Size(40, 15)
        LMoto.TabIndex = 1
        LMoto.Text = "Moto:"
        ' 
        ' DGVDetails
        ' 
        DGVDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDetails.Columns.AddRange(New DataGridViewColumn() {IdMoto, Model, Price, Quantity, SubTotal})
        DGVDetails.Location = New Point(376, 160)
        DGVDetails.Name = "DGVDetails"
        DGVDetails.Size = New Size(446, 123)
        DGVDetails.TabIndex = 8
        ' 
        ' IdMoto
        ' 
        IdMoto.HeaderText = "Id Moto"
        IdMoto.Name = "IdMoto"
        IdMoto.Visible = False
        ' 
        ' Model
        ' 
        Model.HeaderText = "Modelo"
        Model.Name = "Model"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Precio Unitario"
        Price.Name = "Price"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Cantidad"
        Quantity.Name = "Quantity"
        ' 
        ' SubTotal
        ' 
        SubTotal.HeaderText = "SubTotal"
        SubTotal.Name = "SubTotal"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BSaveSell)
        GroupBox2.Controls.Add(BRemoveProduct)
        GroupBox2.Controls.Add(TBTotal)
        GroupBox2.Controls.Add(BCancel)
        GroupBox2.Controls.Add(LTotal)
        GroupBox2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = SystemColors.ControlLightLight
        GroupBox2.Location = New Point(12, 348)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(810, 123)
        GroupBox2.TabIndex = 9
        GroupBox2.TabStop = False
        GroupBox2.Text = "Resumen y Confirmacion"
        ' 
        ' BSaveSell
        ' 
        BSaveSell.Font = New Font("Segoe UI", 9F)
        BSaveSell.ForeColor = SystemColors.ControlText
        BSaveSell.Location = New Point(386, 36)
        BSaveSell.Name = "BSaveSell"
        BSaveSell.Size = New Size(88, 51)
        BSaveSell.TabIndex = 6
        BSaveSell.Text = "Confirmar Venta"
        BSaveSell.UseVisualStyleBackColor = True
        ' 
        ' BRemoveProduct
        ' 
        BRemoveProduct.Font = New Font("Segoe UI", 9F)
        BRemoveProduct.ForeColor = SystemColors.ControlText
        BRemoveProduct.Location = New Point(539, 36)
        BRemoveProduct.Name = "BRemoveProduct"
        BRemoveProduct.Size = New Size(93, 51)
        BRemoveProduct.TabIndex = 5
        BRemoveProduct.Text = "Quitar Producto"
        BRemoveProduct.UseVisualStyleBackColor = True
        ' 
        ' TBTotal
        ' 
        TBTotal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TBTotal.Location = New Point(61, 49)
        TBTotal.Name = "TBTotal"
        TBTotal.ReadOnly = True
        TBTotal.Size = New Size(129, 25)
        TBTotal.TabIndex = 4
        ' 
        ' BCancel
        ' 
        BCancel.Font = New Font("Segoe UI", 9F)
        BCancel.ForeColor = SystemColors.ControlText
        BCancel.Location = New Point(690, 36)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(97, 51)
        BCancel.TabIndex = 3
        BCancel.Text = "Cancelar"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' LTotal
        ' 
        LTotal.AutoSize = True
        LTotal.Location = New Point(11, 54)
        LTotal.Name = "LTotal"
        LTotal.Size = New Size(37, 15)
        LTotal.TabIndex = 1
        LTotal.Text = "Total:"
        ' 
        ' FormSellMoto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(834, 561)
        Controls.Add(GroupBox2)
        Controls.Add(DGVDetails)
        Controls.Add(GroupBox1)
        Controls.Add(GBClient)
        Controls.Add(GBHeader)
        Name = "FormSellMoto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Venta de Motos - OnlyMotos ERP"
        GBHeader.ResumeLayout(False)
        GBHeader.PerformLayout()
        GBClient.ResumeLayout(False)
        GBClient.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NUDQuantity, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVDetails, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBHeader As GroupBox
    Friend WithEvents LUser As Label
    Friend WithEvents LTicketType As Label
    Friend WithEvents CBTicketType As ComboBox
    Friend WithEvents LDate As Label
    Friend WithEvents DTPDate As DateTimePicker
    Friend WithEvents TBUser As TextBox
    Friend WithEvents GBClient As GroupBox
    Friend WithEvents L As Label
    Friend WithEvents CBClient As ComboBox
    Friend WithEvents LClient As Label
    Friend WithEvents BAddClient As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBMoto As ComboBox
    Friend WithEvents LMoto As Label
    Friend WithEvents NUDQuantity As NumericUpDown
    Friend WithEvents LQuantity As Label
    Friend WithEvents TBUnitPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BAddProduct As Button
    Friend WithEvents DGVDetails As DataGridView
    Friend WithEvents IdMoto As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BCancel As Button
    Friend WithEvents LTotal As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents BSaveSell As Button
    Friend WithEvents BRemoveProduct As Button
    Friend WithEvents TBDni As TextBox
    Friend WithEvents LDni As Label
End Class
