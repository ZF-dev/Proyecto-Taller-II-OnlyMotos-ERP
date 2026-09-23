<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSellHistory
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
        BClose = New Button()
        LToDate = New Label()
        LSearchClient = New Label()
        LFromDate = New Label()
        BClearFilters = New Button()
        BSearch = New Button()
        TBSearchClient = New TextBox()
        DTPToDate = New DateTimePicker()
        DTPFromDate = New DateTimePicker()
        DGVSellHeaders = New DataGridView()
        IdVenta = New DataGridViewTextBoxColumn()
        Usuario = New DataGridViewTextBoxColumn()
        Fecha = New DataGridViewTextBoxColumn()
        Cliente = New DataGridViewTextBoxColumn()
        TipoComprobante = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        GBHeaderSells = New GroupBox()
        BAnnullSell = New Button()
        GBDetailSells = New GroupBox()
        DGVSellDetails = New DataGridView()
        IdMoto = New DataGridViewTextBoxColumn()
        Modelo = New DataGridViewTextBoxColumn()
        PrecioUnitario = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        Subtotal = New DataGridViewTextBoxColumn()
        GBFilters.SuspendLayout()
        CType(DGVSellHeaders, ComponentModel.ISupportInitialize).BeginInit()
        GBHeaderSells.SuspendLayout()
        GBDetailSells.SuspendLayout()
        CType(DGVSellDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GBFilters
        ' 
        GBFilters.Controls.Add(BClose)
        GBFilters.Controls.Add(LToDate)
        GBFilters.Controls.Add(LSearchClient)
        GBFilters.Controls.Add(LFromDate)
        GBFilters.Controls.Add(BClearFilters)
        GBFilters.Controls.Add(BSearch)
        GBFilters.Controls.Add(TBSearchClient)
        GBFilters.Controls.Add(DTPToDate)
        GBFilters.Controls.Add(DTPFromDate)
        GBFilters.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBFilters.ForeColor = SystemColors.ControlLightLight
        GBFilters.Location = New Point(12, 12)
        GBFilters.Name = "GBFilters"
        GBFilters.Size = New Size(893, 164)
        GBFilters.TabIndex = 0
        GBFilters.TabStop = False
        GBFilters.Text = "Filtros de Busqueda"
        ' 
        ' BClose
        ' 
        BClose.Font = New Font("Segoe UI", 9F)
        BClose.ForeColor = SystemColors.ControlText
        BClose.Location = New Point(616, 63)
        BClose.Name = "BClose"
        BClose.Size = New Size(103, 48)
        BClose.TabIndex = 8
        BClose.Text = "Cerrar"
        BClose.UseVisualStyleBackColor = True
        BClose.Visible = False
        ' 
        ' LToDate
        ' 
        LToDate.AutoSize = True
        LToDate.Location = New Point(268, 30)
        LToDate.Name = "LToDate"
        LToDate.Size = New Size(79, 15)
        LToDate.TabIndex = 7
        LToDate.Text = "Fecha  Hasta:"
        ' 
        ' LSearchClient
        ' 
        LSearchClient.AutoSize = True
        LSearchClient.Location = New Point(6, 107)
        LSearchClient.Name = "LSearchClient"
        LSearchClient.Size = New Size(94, 15)
        LSearchClient.TabIndex = 6
        LSearchClient.Text = "Buscar por DNI:"
        ' 
        ' LFromDate
        ' 
        LFromDate.AutoSize = True
        LFromDate.Location = New Point(6, 30)
        LFromDate.Name = "LFromDate"
        LFromDate.Size = New Size(80, 15)
        LFromDate.TabIndex = 5
        LFromDate.Text = "Fecha Desde:"
        ' 
        ' BClearFilters
        ' 
        BClearFilters.Font = New Font("Segoe UI", 9F)
        BClearFilters.ForeColor = SystemColors.ControlText
        BClearFilters.Location = New Point(749, 24)
        BClearFilters.Name = "BClearFilters"
        BClearFilters.Size = New Size(103, 55)
        BClearFilters.TabIndex = 4
        BClearFilters.Text = "Limpiar Filtros"
        BClearFilters.UseVisualStyleBackColor = True
        ' 
        ' BSearch
        ' 
        BSearch.Font = New Font("Segoe UI", 9F)
        BSearch.ForeColor = SystemColors.ControlText
        BSearch.Location = New Point(749, 99)
        BSearch.Name = "BSearch"
        BSearch.Size = New Size(103, 48)
        BSearch.TabIndex = 3
        BSearch.Text = "Buscar/Filtrar"
        BSearch.UseVisualStyleBackColor = True
        ' 
        ' TBSearchClient
        ' 
        TBSearchClient.Location = New Point(106, 104)
        TBSearchClient.Name = "TBSearchClient"
        TBSearchClient.Size = New Size(166, 23)
        TBSearchClient.TabIndex = 2
        ' 
        ' DTPToDate
        ' 
        DTPToDate.Format = DateTimePickerFormat.Short
        DTPToDate.Location = New Point(362, 24)
        DTPToDate.Name = "DTPToDate"
        DTPToDate.Size = New Size(113, 23)
        DTPToDate.TabIndex = 1
        ' 
        ' DTPFromDate
        ' 
        DTPFromDate.Format = DateTimePickerFormat.Short
        DTPFromDate.Location = New Point(106, 24)
        DTPFromDate.Name = "DTPFromDate"
        DTPFromDate.Size = New Size(107, 23)
        DTPFromDate.TabIndex = 0
        ' 
        ' DGVSellHeaders
        ' 
        DGVSellHeaders.AllowUserToAddRows = False
        DGVSellHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSellHeaders.Columns.AddRange(New DataGridViewColumn() {IdVenta, Usuario, Fecha, Cliente, TipoComprobante, Total})
        DGVSellHeaders.Location = New Point(127, 22)
        DGVSellHeaders.Name = "DGVSellHeaders"
        DGVSellHeaders.ReadOnly = True
        DGVSellHeaders.Size = New Size(644, 150)
        DGVSellHeaders.TabIndex = 1
        ' 
        ' IdVenta
        ' 
        IdVenta.HeaderText = "Id Venta"
        IdVenta.Name = "IdVenta"
        IdVenta.ReadOnly = True
        ' 
        ' Usuario
        ' 
        Usuario.HeaderText = "Usuario"
        Usuario.Name = "Usuario"
        Usuario.ReadOnly = True
        ' 
        ' Fecha
        ' 
        Fecha.HeaderText = "Fecha"
        Fecha.Name = "Fecha"
        Fecha.ReadOnly = True
        ' 
        ' Cliente
        ' 
        Cliente.HeaderText = "Cliente"
        Cliente.Name = "Cliente"
        Cliente.ReadOnly = True
        ' 
        ' TipoComprobante
        ' 
        TipoComprobante.HeaderText = "Tipo de Comprobante"
        TipoComprobante.Name = "TipoComprobante"
        TipoComprobante.ReadOnly = True
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.Name = "Total"
        Total.ReadOnly = True
        ' 
        ' GBHeaderSells
        ' 
        GBHeaderSells.Controls.Add(BAnnullSell)
        GBHeaderSells.Controls.Add(DGVSellHeaders)
        GBHeaderSells.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBHeaderSells.ForeColor = SystemColors.ControlText
        GBHeaderSells.Location = New Point(12, 196)
        GBHeaderSells.Name = "GBHeaderSells"
        GBHeaderSells.Size = New Size(893, 187)
        GBHeaderSells.TabIndex = 2
        GBHeaderSells.TabStop = False
        GBHeaderSells.Text = "Lista de Ventas"
        ' 
        ' BAnnullSell
        ' 
        BAnnullSell.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BAnnullSell.ForeColor = SystemColors.ControlText
        BAnnullSell.Location = New Point(784, 80)
        BAnnullSell.Name = "BAnnullSell"
        BAnnullSell.Size = New Size(103, 48)
        BAnnullSell.TabIndex = 8
        BAnnullSell.Text = "Anular Venta"
        BAnnullSell.UseVisualStyleBackColor = True
        ' 
        ' GBDetailSells
        ' 
        GBDetailSells.Controls.Add(DGVSellDetails)
        GBDetailSells.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBDetailSells.ForeColor = SystemColors.ControlText
        GBDetailSells.Location = New Point(12, 412)
        GBDetailSells.Name = "GBDetailSells"
        GBDetailSells.Size = New Size(893, 187)
        GBDetailSells.TabIndex = 3
        GBDetailSells.TabStop = False
        GBDetailSells.Text = "Detalle de Venta Seleccionada"
        ' 
        ' DGVSellDetails
        ' 
        DGVSellDetails.AllowUserToAddRows = False
        DGVSellDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVSellDetails.Columns.AddRange(New DataGridViewColumn() {IdMoto, Modelo, PrecioUnitario, Cantidad, Subtotal})
        DGVSellDetails.Location = New Point(239, 22)
        DGVSellDetails.Name = "DGVSellDetails"
        DGVSellDetails.ReadOnly = True
        DGVSellDetails.Size = New Size(443, 150)
        DGVSellDetails.TabIndex = 1
        ' 
        ' IdMoto
        ' 
        IdMoto.HeaderText = "Id Moto"
        IdMoto.Name = "IdMoto"
        IdMoto.ReadOnly = True
        IdMoto.Visible = False
        ' 
        ' Modelo
        ' 
        Modelo.HeaderText = "Modelo"
        Modelo.Name = "Modelo"
        Modelo.ReadOnly = True
        ' 
        ' PrecioUnitario
        ' 
        PrecioUnitario.HeaderText = "Precio Unitario"
        PrecioUnitario.Name = "PrecioUnitario"
        PrecioUnitario.ReadOnly = True
        ' 
        ' Cantidad
        ' 
        Cantidad.HeaderText = "Cantidad"
        Cantidad.Name = "Cantidad"
        Cantidad.ReadOnly = True
        ' 
        ' Subtotal
        ' 
        Subtotal.HeaderText = "Subtotal"
        Subtotal.Name = "Subtotal"
        Subtotal.ReadOnly = True
        ' 
        ' FormSellHistory
        ' 
        AcceptButton = BSearch
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BClose
        ClientSize = New Size(934, 611)
        Controls.Add(GBDetailSells)
        Controls.Add(GBHeaderSells)
        Controls.Add(GBFilters)
        ForeColor = SystemColors.ControlText
        Name = "FormSellHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Historial de Ventas - OnlyMotos ERP"
        GBFilters.ResumeLayout(False)
        GBFilters.PerformLayout()
        CType(DGVSellHeaders, ComponentModel.ISupportInitialize).EndInit()
        GBHeaderSells.ResumeLayout(False)
        GBDetailSells.ResumeLayout(False)
        CType(DGVSellDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBFilters As GroupBox
    Friend WithEvents LFromDate As Label
    Friend WithEvents BClearFilters As Button
    Friend WithEvents BSearch As Button
    Friend WithEvents TBSearchClient As TextBox
    Friend WithEvents DTPToDate As DateTimePicker
    Friend WithEvents DTPFromDate As DateTimePicker
    Friend WithEvents LToDate As Label
    Friend WithEvents LSearchClient As Label
    Friend WithEvents DGVSellHeaders As DataGridView
    Friend WithEvents IdVenta As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents TipoComprobante As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents GBHeaderSells As GroupBox
    Friend WithEvents GBDetailSells As GroupBox
    Friend WithEvents DGVSellDetails As DataGridView
    Friend WithEvents IdMoto As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As DataGridViewTextBoxColumn
    Friend WithEvents BAnnullSell As Button
    Friend WithEvents BClose As Button
End Class
