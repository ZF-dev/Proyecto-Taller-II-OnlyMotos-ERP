Public Class FormSellMoto
    Private Sub FormSellMoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInitialData()
    End Sub

    Private Sub LoadInitialData()

        TBTotal.Text = "$ 0.00"


    End Sub

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDni.KeyPress
        ' Permite únicamente dígitos numéricos y la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBUnitPrice.KeyPress
        ' Permite únicamente dígitos numéricos y la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub BAddProduct_Click(sender As Object, e As EventArgs) Handles BAddProduct.Click
        ' Lógica preliminar para agregar ítems a la grilla
        If String.IsNullOrWhiteSpace(CBMoto.Text) OrElse String.IsNullOrWhiteSpace(TBUnitPrice.Text) OrElse String.IsNullOrWhiteSpace(CBClient.Text) Then

            MessageBox.Show("Por favor, complete todos los campos del producto.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

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

    Private Sub BAddClient_Click(sender As Object, e As EventArgs) Handles BAddClient.Click
        Dim manageClientForm As New FormManageClients()
        If manageClientForm.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("Cliente dado de alta exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MÁS ADELANTE: Reconsultar BD
        End If
    End Sub
End Class