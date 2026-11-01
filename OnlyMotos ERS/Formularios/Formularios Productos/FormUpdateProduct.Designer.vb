<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateProduct
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
        CBCylinder = New ComboBox()
        CBBrand = New ComboBox()
        BSelectImage = New Button()
        TBImagePath = New TextBox()
        LYear = New Label()
        TBYear = New TextBox()
        LPrice = New Label()
        LCylinder = New Label()
        LModel = New Label()
        LBrand = New Label()
        BCancel = New Button()
        BSaveUpdate = New Button()
        TBPrice = New TextBox()
        TBModel = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        GBData.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBData
        ' 
        GBData.BackColor = Color.MidnightBlue
        GBData.Controls.Add(CBCylinder)
        GBData.Controls.Add(CBBrand)
        GBData.Controls.Add(BSelectImage)
        GBData.Controls.Add(TBImagePath)
        GBData.Controls.Add(LYear)
        GBData.Controls.Add(TBYear)
        GBData.Controls.Add(LPrice)
        GBData.Controls.Add(LCylinder)
        GBData.Controls.Add(LModel)
        GBData.Controls.Add(LBrand)
        GBData.Controls.Add(BCancel)
        GBData.Controls.Add(BSaveUpdate)
        GBData.Controls.Add(TBPrice)
        GBData.Controls.Add(TBModel)
        GBData.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBData.ForeColor = SystemColors.ControlLightLight
        GBData.Location = New Point(12, 12)
        GBData.Name = "GBData"
        GBData.Size = New Size(390, 374)
        GBData.TabIndex = 1
        GBData.TabStop = False
        GBData.Text = "Datos de la Moto"
        ' 
        ' CBCylinder
        ' 
        CBCylinder.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CBCylinder.AutoCompleteSource = AutoCompleteSource.ListItems
        CBCylinder.FormattingEnabled = True
        CBCylinder.Location = New Point(128, 124)
        CBCylinder.Name = "CBCylinder"
        CBCylinder.Size = New Size(239, 23)
        CBCylinder.TabIndex = 20
        ' 
        ' CBBrand
        ' 
        CBBrand.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CBBrand.AutoCompleteSource = AutoCompleteSource.ListItems
        CBBrand.FormattingEnabled = True
        CBBrand.Location = New Point(128, 37)
        CBBrand.MaxDropDownItems = 100
        CBBrand.Name = "CBBrand"
        CBBrand.Size = New Size(239, 23)
        CBBrand.TabIndex = 19
        ' 
        ' BSelectImage
        ' 
        BSelectImage.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BSelectImage.ForeColor = SystemColors.ControlText
        BSelectImage.Location = New Point(35, 259)
        BSelectImage.Name = "BSelectImage"
        BSelectImage.Size = New Size(75, 23)
        BSelectImage.TabIndex = 18
        BSelectImage.Text = "Examinar"
        BSelectImage.UseVisualStyleBackColor = True
        ' 
        ' TBImagePath
        ' 
        TBImagePath.Location = New Point(128, 259)
        TBImagePath.Name = "TBImagePath"
        TBImagePath.Size = New Size(239, 23)
        TBImagePath.TabIndex = 17
        ' 
        ' LYear
        ' 
        LYear.AutoSize = True
        LYear.Location = New Point(35, 219)
        LYear.Name = "LYear"
        LYear.Size = New Size(32, 15)
        LYear.TabIndex = 15
        LYear.Text = "Año:"
        ' 
        ' TBYear
        ' 
        TBYear.Location = New Point(128, 216)
        TBYear.Name = "TBYear"
        TBYear.Size = New Size(239, 23)
        TBYear.TabIndex = 14
        ' 
        ' LPrice
        ' 
        LPrice.AutoSize = True
        LPrice.Location = New Point(35, 175)
        LPrice.Name = "LPrice"
        LPrice.Size = New Size(45, 15)
        LPrice.TabIndex = 10
        LPrice.Text = "Precio:"
        ' 
        ' LCylinder
        ' 
        LCylinder.AutoSize = True
        LCylinder.Location = New Point(35, 127)
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
        LModel.Size = New Size(52, 15)
        LModel.TabIndex = 8
        LModel.Text = "Modelo:"
        ' 
        ' LBrand
        ' 
        LBrand.AutoSize = True
        LBrand.Location = New Point(35, 40)
        LBrand.Name = "LBrand"
        LBrand.Size = New Size(44, 15)
        LBrand.TabIndex = 7
        LBrand.Text = "Marca:"
        ' 
        ' BCancel
        ' 
        BCancel.Font = New Font("Segoe UI", 9F)
        BCancel.ForeColor = SystemColors.ControlText
        BCancel.ImageAlign = ContentAlignment.MiddleRight
        BCancel.Location = New Point(35, 310)
        BCancel.Name = "BCancel"
        BCancel.Size = New Size(112, 58)
        BCancel.TabIndex = 6
        BCancel.Text = "Cancelar carga"
        BCancel.UseVisualStyleBackColor = True
        ' 
        ' BSaveUpdate
        ' 
        BSaveUpdate.Font = New Font("Segoe UI", 9F)
        BSaveUpdate.ForeColor = SystemColors.ControlText
        BSaveUpdate.Location = New Point(255, 310)
        BSaveUpdate.Name = "BSaveUpdate"
        BSaveUpdate.Size = New Size(112, 58)
        BSaveUpdate.TabIndex = 5
        BSaveUpdate.Text = "Actualizar Moto"
        BSaveUpdate.UseVisualStyleBackColor = True
        ' 
        ' TBPrice
        ' 
        TBPrice.Location = New Point(128, 172)
        TBPrice.Name = "TBPrice"
        TBPrice.Size = New Size(239, 23)
        TBPrice.TabIndex = 3
        ' 
        ' TBModel
        ' 
        TBModel.Location = New Point(128, 81)
        TBModel.Name = "TBModel"
        TBModel.Size = New Size(239, 23)
        TBModel.TabIndex = 1
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormUpdateProduct
        ' 
        AcceptButton = BSaveUpdate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        CancelButton = BCancel
        ClientSize = New Size(414, 394)
        Controls.Add(GBData)
        Name = "FormUpdateProduct"
        Text = "Actualizar Moto"
        GBData.ResumeLayout(False)
        GBData.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GBData As GroupBox
    Friend WithEvents CBCylinder As ComboBox
    Friend WithEvents CBBrand As ComboBox
    Friend WithEvents BSelectImage As Button
    Friend WithEvents TBImagePath As TextBox
    Friend WithEvents LYear As Label
    Friend WithEvents TBYear As TextBox
    Friend WithEvents LPrice As Label
    Friend WithEvents LCylinder As Label
    Friend WithEvents LModel As Label
    Friend WithEvents LBrand As Label
    Friend WithEvents BCancel As Button
    Friend WithEvents BSaveUpdate As Button
    Friend WithEvents TBPrice As TextBox
    Friend WithEvents TBModel As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
