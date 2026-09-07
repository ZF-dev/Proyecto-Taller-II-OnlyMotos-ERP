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
        Label2 = New Label()
        GBFilters = New GroupBox()
        TBSearch = New TextBox()
        BClearFilters = New Button()
        GBFilters.SuspendLayout()
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
        BSearch.Location = New Point(713, 161)
        BSearch.Name = "BSearch"
        BSearch.Size = New Size(75, 23)
        BSearch.TabIndex = 1
        BSearch.Text = "BSearch"
        BSearch.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' GBFilters
        ' 
        GBFilters.Controls.Add(TBSearch)
        GBFilters.Location = New Point(0, 0)
        GBFilters.Name = "GBFilters"
        GBFilters.Size = New Size(200, 100)
        GBFilters.TabIndex = 3
        GBFilters.TabStop = False
        GBFilters.Text = "GBFilters"
        ' 
        ' TBSearch
        ' 
        TBSearch.Location = New Point(3, 19)
        TBSearch.Name = "TBSearch"
        TBSearch.Size = New Size(100, 23)
        TBSearch.TabIndex = 0
        TBSearch.Text = "TBSearch"
        ' 
        ' BClearFilters
        ' 
        BClearFilters.Location = New Point(721, 169)
        BClearFilters.Name = "BClearFilters"
        BClearFilters.Size = New Size(75, 23)
        BClearFilters.TabIndex = 4
        BClearFilters.Text = "Button1"
        BClearFilters.UseVisualStyleBackColor = True
        ' 
        ' FormSeeProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BClearFilters)
        Controls.Add(GBFilters)
        Controls.Add(Label2)
        Controls.Add(BSearch)
        Controls.Add(Label1)
        Name = "FormSeeProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Catálogo de Motos - OnlyMotos ERP"
        WindowState = FormWindowState.Maximized
        GBFilters.ResumeLayout(False)
        GBFilters.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GBFilters As GroupBox
    Friend WithEvents TBSearch As TextBox
    Friend WithEvents BClearFilters As Button
End Class
