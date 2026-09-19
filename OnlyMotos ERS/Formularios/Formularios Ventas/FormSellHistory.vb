Public Class FormSellHistory
    Private Sub FormSellHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMockData()
        GBDetailSells.Visible = False
    End Sub

    Private Sub LoadMockData()
        ' Configurar fechas por defecto (último mes)
        DTPFromDate.Value = DateTime.Now.AddMonths(-1)
        DTPToDate.Value = DateTime.Now

        ' Carga de ventas de prueba
        DGVSellHeaders.Rows.Clear()
        DGVSellHeaders.Rows.Add("1001", "Admin", "05/09/2026", "Juan Pérez", "Factura B", "$ 2,500,000.00")
        DGVSellHeaders.Rows.Add("1002", "Admin", "05/09/2026", "María Gómez", "Factura A", "$ 5,900,000.00")
    End Sub

    ' Evento al cambiar de fila seleccionada en la grilla principal
    Private Sub DGVSellHeaders_SelectionChanged(sender As Object, e As EventArgs) Handles DGVSellHeaders.SelectionChanged
        If DGVSellHeaders.SelectedRows.Count > 0 Then
            Dim selectedId As String = DGVSellHeaders.SelectedRows(0).Cells("IdVenta").Value.ToString()
            LoadSellDetail(selectedId)
            GBDetailSells.Visible = True
        End If
    End Sub

    Private Sub LoadSellDetail(idVenta As String)
        DGVSellDetails.Rows.Clear()

        ' Simulación de detalle de acuerdo a la venta seleccionada
        If idVenta = "1001" Then
            DGVSellDetails.Rows.Add("1", "Honda Wave 110s", "$ 2,500,000.00", 1, "$ 2,500,000.00")
        ElseIf idVenta = "1002" Then
            DGVSellDetails.Rows.Add("1", "Honda Wave 110s", "$ 2,500,000.00", 1, "$ 2,500,000.00")
            DGVSellDetails.Rows.Add("2", "Yamaha YBR 125", "$ 3,400,000.00", 1, "$ 3,400,000.00")
        End If
    End Sub

    Private Sub TBSearchClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBSearchClient.KeyPress
        ' Permite únicamente dígitos numéricos y la tecla Backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        ' Validar campo DNI del cliente antes de aplicar filtro
        If String.IsNullOrWhiteSpace(TBSearchClient.Text) Then
            MessageBox.Show("Ingrese un número de DNI para filtrar las ventas.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearchClient.Focus()
            Exit Sub
        End If

        If Not ValidadorDNI.IsValidDNI(TBSearchClient.Text) Then
            MessageBox.Show("El DNI ingresado no es válido. Debe contener 7 u 8 dígitos.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBSearchClient.Focus()
            TBSearchClient.SelectAll()
            Exit Sub
        End If

        ' Aquí irá la consulta filtrada a la base de datos
        MessageBox.Show($"Filtrando ventas por DNI del cliente: {TBSearchClient.Text}", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        TBSearchClient.Clear()
        LoadMockData()
    End Sub

    Private Sub BAnnullSell_Click(sender As Object, e As EventArgs) Handles BAnnullSell.Click
        If DGVSellHeaders.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de anular la venta seleccionada?", "Confirmar Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                MessageBox.Show("Venta anulada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub
End Class