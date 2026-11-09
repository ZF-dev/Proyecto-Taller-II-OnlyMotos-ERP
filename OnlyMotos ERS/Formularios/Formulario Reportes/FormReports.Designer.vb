<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReports
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        BReportSales = New Button()
        GBCurrentSession = New GroupBox()
        LEnd = New Label()
        LStart = New Label()
        DTPEnd = New DateTimePicker()
        DTPStart = New DateTimePicker()
        BReportSalesRange = New Button()
        BReportRestors = New Button()
        BReportFinancial = New Button()
        BReportSalesUser = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        DGVDetalle = New DataGridView()
        Label1 = New Label()
        LNameDNI = New Label()
        LTotal = New Label()
        LQuantity = New Label()
        LPorc = New Label()
        GroupBox1 = New GroupBox()
        GBCurrentSession.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVDetalle, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BReportSales
        ' 
        BReportSales.Font = New Font("Segoe UI", 9F)
        BReportSales.ForeColor = SystemColors.ControlText
        BReportSales.Location = New Point(6, 216)
        BReportSales.Name = "BReportSales"
        BReportSales.Size = New Size(112, 43)
        BReportSales.TabIndex = 0
        BReportSales.Text = " Ventas"
        BReportSales.UseVisualStyleBackColor = True
        ' 
        ' GBCurrentSession
        ' 
        GBCurrentSession.Controls.Add(LEnd)
        GBCurrentSession.Controls.Add(LStart)
        GBCurrentSession.Controls.Add(DTPEnd)
        GBCurrentSession.Controls.Add(DTPStart)
        GBCurrentSession.Controls.Add(BReportSalesRange)
        GBCurrentSession.Controls.Add(BReportRestors)
        GBCurrentSession.Controls.Add(BReportFinancial)
        GBCurrentSession.Controls.Add(BReportSalesUser)
        GBCurrentSession.Controls.Add(BReportSales)
        GBCurrentSession.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBCurrentSession.ForeColor = SystemColors.ControlLightLight
        GBCurrentSession.Location = New Point(12, 12)
        GBCurrentSession.Name = "GBCurrentSession"
        GBCurrentSession.Size = New Size(377, 292)
        GBCurrentSession.TabIndex = 1
        GBCurrentSession.TabStop = False
        GBCurrentSession.Text = "Reportes:"
        ' 
        ' LEnd
        ' 
        LEnd.AutoSize = True
        LEnd.Location = New Point(202, 42)
        LEnd.Name = "LEnd"
        LEnd.Size = New Size(52, 15)
        LEnd.TabIndex = 8
        LEnd.Text = "Mes Fin:"
        ' 
        ' LStart
        ' 
        LStart.AutoSize = True
        LStart.Location = New Point(6, 42)
        LStart.Name = "LStart"
        LStart.Size = New Size(65, 15)
        LStart.TabIndex = 7
        LStart.Text = "Mes inicio:"
        ' 
        ' DTPEnd
        ' 
        DTPEnd.Format = DateTimePickerFormat.Short
        DTPEnd.Location = New Point(259, 36)
        DTPEnd.Name = "DTPEnd"
        DTPEnd.Size = New Size(102, 23)
        DTPEnd.TabIndex = 6
        ' 
        ' DTPStart
        ' 
        DTPStart.Format = DateTimePickerFormat.Short
        DTPStart.Location = New Point(76, 36)
        DTPStart.Name = "DTPStart"
        DTPStart.Size = New Size(102, 23)
        DTPStart.TabIndex = 5
        DTPStart.Value = New Date(2026, 10, 5, 20, 54, 0, 0)
        ' 
        ' BReportSalesRange
        ' 
        BReportSalesRange.Font = New Font("Segoe UI", 9F)
        BReportSalesRange.ForeColor = SystemColors.ControlText
        BReportSalesRange.Location = New Point(7, 83)
        BReportSalesRange.Name = "BReportSalesRange"
        BReportSalesRange.Size = New Size(112, 43)
        BReportSalesRange.TabIndex = 4
        BReportSalesRange.Text = "Ventas en Rango"
        BReportSalesRange.UseVisualStyleBackColor = True
        ' 
        ' BReportRestors
        ' 
        BReportRestors.Font = New Font("Segoe UI", 9F)
        BReportRestors.ForeColor = SystemColors.ControlText
        BReportRestors.Location = New Point(7, 132)
        BReportRestors.Name = "BReportRestors"
        BReportRestors.Size = New Size(112, 60)
        BReportRestors.TabIndex = 3
        BReportRestors.Text = "Auditoria de Restauraciones de la Base de Datos"
        BReportRestors.UseVisualStyleBackColor = True
        ' 
        ' BReportFinancial
        ' 
        BReportFinancial.Font = New Font("Segoe UI", 9F)
        BReportFinancial.ForeColor = SystemColors.ControlText
        BReportFinancial.Location = New Point(6, 149)
        BReportFinancial.Name = "BReportFinancial"
        BReportFinancial.Size = New Size(112, 43)
        BReportFinancial.TabIndex = 2
        BReportFinancial.Text = "Ganancias"
        BReportFinancial.UseVisualStyleBackColor = True
        ' 
        ' BReportSalesUser
        ' 
        BReportSalesUser.Font = New Font("Segoe UI", 9F)
        BReportSalesUser.ForeColor = SystemColors.ControlText
        BReportSalesUser.Location = New Point(6, 83)
        BReportSalesUser.Name = "BReportSalesUser"
        BReportSalesUser.Size = New Size(112, 43)
        BReportSalesUser.TabIndex = 1
        BReportSalesUser.Text = "Ventas por Usuario"
        BReportSalesUser.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(404, 21)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(618, 283)
        Chart1.TabIndex = 2
        Chart1.Text = "Chart"
        ' 
        ' DGVDetalle
        ' 
        DGVDetalle.AllowUserToAddRows = False
        DGVDetalle.AllowUserToDeleteRows = False
        DGVDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVDetalle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDetalle.Location = New Point(12, 330)
        DGVDetalle.Name = "DGVDetalle"
        DGVDetalle.ReadOnly = True
        DGVDetalle.Size = New Size(1010, 201)
        DGVDetalle.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(19, 561)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 21)
        Label1.TabIndex = 4
        Label1.Text = "Rendimiento Destacado:"
        ' 
        ' LNameDNI
        ' 
        LNameDNI.AutoSize = True
        LNameDNI.ForeColor = SystemColors.ControlLightLight
        LNameDNI.Location = New Point(9, 33)
        LNameDNI.Name = "LNameDNI"
        LNameDNI.Size = New Size(41, 15)
        LNameDNI.TabIndex = 5
        LNameDNI.Text = "Label2"
        ' 
        ' LTotal
        ' 
        LTotal.AutoSize = True
        LTotal.ForeColor = SystemColors.ControlLightLight
        LTotal.Location = New Point(9, 62)
        LTotal.Name = "LTotal"
        LTotal.Size = New Size(41, 15)
        LTotal.TabIndex = 6
        LTotal.Text = "Label3"
        ' 
        ' LQuantity
        ' 
        LQuantity.AutoSize = True
        LQuantity.ForeColor = SystemColors.ControlLightLight
        LQuantity.Location = New Point(9, 91)
        LQuantity.Name = "LQuantity"
        LQuantity.Size = New Size(41, 15)
        LQuantity.TabIndex = 7
        LQuantity.Text = "Label4"
        ' 
        ' LPorc
        ' 
        LPorc.AutoSize = True
        LPorc.ForeColor = SystemColors.ControlLightLight
        LPorc.Location = New Point(9, 124)
        LPorc.Name = "LPorc"
        LPorc.Size = New Size(41, 15)
        LPorc.TabIndex = 8
        LPorc.Text = "Label5"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LPorc)
        GroupBox1.Controls.Add(LQuantity)
        GroupBox1.Controls.Add(LTotal)
        GroupBox1.Controls.Add(LNameDNI)
        GroupBox1.ForeColor = SystemColors.ControlLightLight
        GroupBox1.Location = New Point(10, 561)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1012, 164)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Rendimiento Destacado"
        ' 
        ' FormReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(1034, 749)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(DGVDetalle)
        Controls.Add(Chart1)
        Controls.Add(GBCurrentSession)
        Name = "FormReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reportes y Estadísticas - OnlyMotos ERP"
        GBCurrentSession.ResumeLayout(False)
        GBCurrentSession.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVDetalle, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BReportSales As Button
    Friend WithEvents GBCurrentSession As GroupBox
    Friend WithEvents BReportRestors As Button
    Friend WithEvents BReportFinancial As Button
    Friend WithEvents BReportSalesUser As Button
    Friend WithEvents BReportSalesRange As Button
    Friend WithEvents LEnd As Label
    Friend WithEvents LStart As Label
    Friend WithEvents DTPEnd As DateTimePicker
    Friend WithEvents DTPStart As DateTimePicker
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents DGVDetalle As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LNameDNI As Label
    Friend WithEvents LTotal As Label
    Friend WithEvents LQuantity As Label
    Friend WithEvents LPorc As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
