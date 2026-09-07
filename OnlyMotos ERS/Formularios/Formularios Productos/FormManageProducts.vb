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

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        Dim price As Decimal

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

        ' Aquí irá la orden INSERT INTO Productos (marca, modelo, cilindrada, precio, stock)
        MessageBox.Show("Moto registrada correctamente en el catálogo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearForm()
    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

End Class