Public Class FormSellMoto
    Private Sub FormSellMoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialData()
    End Sub

    Private Sub LoadInitialData()

        TBTotal.Text = "$ 0.00"
    End Sub

    Private Sub BAddProduct_Click(sender As Object, e As EventArgs) Handles BAddProduct.Click
        ' Lógica preliminar para agregar ítems a la grilla
        CalculateTotal()
    End Sub

    Private Sub BRemoveProduct_Click(sender As Object, e As EventArgs) Handles BRemoveProduct.Click
        If DGVDetails.SelectedRows.Count > 0 Then
            DGVDetails.Rows.Remove(DGVDetails.SelectedRows(0))
            CalculateTotal()
        Else
            MessageBox.Show("Seleccione un elemento de la lista para quitar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub CalculateTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DGVDetails.Rows
            total += Convert.ToDecimal(row.Cells("Subtotal").Value)
        Next

        TBTotal.Text = total.ToString("$ #,##0.00")
    End Sub

    Private Sub BSaveSell_Click(sender As Object, e As EventArgs) Handles BSaveSell.Click
        If DGVDetails.Rows.Count = 0 Then
            MessageBox.Show("Debe agregar al menos una moto para registrar la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Aquí irá la lógica para guardar en la tabla Cabecera y Detalle
        MessageBox.Show("Venta registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

End Class