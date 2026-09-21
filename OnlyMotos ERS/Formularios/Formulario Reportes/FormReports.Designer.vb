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
        BReportSales = New Button()
        GBCurrentSession = New GroupBox()
        LEnd = New Label()
        LStart = New Label()
        DTPEnd = New DateTimePicker()
        DTPStart = New DateTimePicker()
        BReportSalesRange = New Button()
        BReportUsers = New Button()
        BReportFinancial = New Button()
        BReportSalesUser = New Button()
        GBCurrentSession.SuspendLayout()
        SuspendLayout()
        ' 
        ' BReportSales
        ' 
        BReportSales.Font = New Font("Segoe UI", 9F)
        BReportSales.ForeColor = SystemColors.ControlText
        BReportSales.Location = New Point(20, 115)
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
        GBCurrentSession.Controls.Add(BReportUsers)
        GBCurrentSession.Controls.Add(BReportFinancial)
        GBCurrentSession.Controls.Add(BReportSalesUser)
        GBCurrentSession.Controls.Add(BReportSales)
        GBCurrentSession.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBCurrentSession.ForeColor = SystemColors.ControlLightLight
        GBCurrentSession.Location = New Point(12, 12)
        GBCurrentSession.Name = "GBCurrentSession"
        GBCurrentSession.Size = New Size(376, 273)
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
        ' 
        ' BReportSalesRange
        ' 
        BReportSalesRange.Font = New Font("Segoe UI", 9F)
        BReportSalesRange.ForeColor = SystemColors.ControlText
        BReportSalesRange.Location = New Point(212, 115)
        BReportSalesRange.Name = "BReportSalesRange"
        BReportSalesRange.Size = New Size(112, 43)
        BReportSalesRange.TabIndex = 4
        BReportSalesRange.Text = "Ventas en Rango"
        BReportSalesRange.UseVisualStyleBackColor = True
        ' 
        ' BReportUsers
        ' 
        BReportUsers.Font = New Font("Segoe UI", 9F)
        BReportUsers.ForeColor = SystemColors.ControlText
        BReportUsers.Location = New Point(124, 115)
        BReportUsers.Name = "BReportUsers"
        BReportUsers.Size = New Size(112, 43)
        BReportUsers.TabIndex = 3
        BReportUsers.Text = "Auditoria de Usuarios"
        BReportUsers.UseVisualStyleBackColor = True
        ' 
        ' BReportFinancial
        ' 
        BReportFinancial.Font = New Font("Segoe UI", 9F)
        BReportFinancial.ForeColor = SystemColors.ControlText
        BReportFinancial.Location = New Point(20, 115)
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
        BReportSalesUser.Location = New Point(212, 115)
        BReportSalesUser.Name = "BReportSalesUser"
        BReportSalesUser.Size = New Size(112, 43)
        BReportSalesUser.TabIndex = 1
        BReportSalesUser.Text = "Ventas por Usuario"
        BReportSalesUser.UseVisualStyleBackColor = True
        ' 
        ' FormReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(401, 302)
        Controls.Add(GBCurrentSession)
        Name = "FormReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Reportes y Estadísticas - OnlyMotos ERP"
        GBCurrentSession.ResumeLayout(False)
        GBCurrentSession.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BReportSales As Button
    Friend WithEvents GBCurrentSession As GroupBox
    Friend WithEvents BReportUsers As Button
    Friend WithEvents BReportFinancial As Button
    Friend WithEvents BReportSalesUser As Button
    Friend WithEvents BReportSalesRange As Button
    Friend WithEvents LEnd As Label
    Friend WithEvents LStart As Label
    Friend WithEvents DTPEnd As DateTimePicker
    Friend WithEvents DTPStart As DateTimePicker
End Class
