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

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        ' Aquí irá la consulta filtrada a la base de datos
        MessageBox.Show("Filtro aplicado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        TBSearchClient.Clear()
        DTPFromDate.Value = DateTime.Now.AddMonths(-1)
        DTPToDate.Value = DateTime.Now
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

End Class