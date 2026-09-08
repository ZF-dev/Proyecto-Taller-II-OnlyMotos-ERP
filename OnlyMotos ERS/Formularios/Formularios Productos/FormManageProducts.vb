Imports System.Security.Cryptography

Public Class FormManageProducts
    Private Sub FormManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
    End Sub

    Private Sub ClearForm()
        TBBrand.Clear()
        TBModel.Clear()
        TBCylinder.Clear()
        TBPrice.Clear()
        NUDStock.Value = 1
        NUDStockMin.Value = 1
        TBBrand.Focus()
    End Sub

    Private Sub BSelectImage_Click(sender As Object, e As EventArgs) Handles BSelectImage.Click

        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        Dim price As Decimal
        Dim cylinder As Integer
        Dim year As Integer

        If String.IsNullOrWhiteSpace(TBBrand.Text) OrElse String.IsNullOrWhiteSpace(TBModel.Text) Then
            MessageBox.Show("Por favor complete la marca y el modelo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBBrand.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TBPrice.Text) OrElse Not Decimal.TryParse(TBPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Ingrese un precio unitario válido mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBPrice.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TBCylinder.Text) OrElse Not Integer.TryParse(TBCylinder.Text, cylinder) OrElse cylinder <= 0 Then
            MessageBox.Show("Ingrese una cilindrada válida mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBCylinder.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TBYear.Text) OrElse Not Integer.TryParse(TBYear.Text, year) OrElse year <= 0 Then
            MessageBox.Show("Ingrese un año válido mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBYear.Focus()
            Exit Sub
        End If



        ' Aquí irá la orden INSERT INTO Productos (marca, modelo, cilindrada, precio, stock)
        MessageBox.Show("Moto registrada correctamente en el catálogo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearForm()

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        ' 1. Guardar la ruta completa en el TextBox
        TBImagePath.Text = OpenFileDialog1.FileName

        ' 2. Cargar la imagen en el PictureBox de forma segura
        If PBMotoImage.Image IsNot Nothing Then
            PBMotoImage.Image.Dispose() ' Libera recursos de la imagen anterior si existía
        End If

        PBMotoImage.Image = Image.FromFile(OpenFileDialog1.FileName)


    End Sub
End Class