Public Class FormSeeProducts
    Private Sub FormSeeProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadMockData()

    End Sub

    Private Sub LoadMockData()
        DGVProducts.Rows.Clear()
        ' Datos simulados (El ID representa el valor autoincremental de la BD)
        DGVProducts.Rows.Add(1, "HONDA", "Wave 110s", "2010", "110 cc", 8, "$ 2,500,000.00")
        DGVProducts.Rows.Add(2, "YAMAHA", "YBR 125", "2012", "125 cc", 4, "$ 3,800,000.00")
        DGVProducts.Rows.Add(3, "MOTOMEL", "Sirius 150", "2015", "150 cc", 12, "$ 2,100,000.00")
    End Sub

    ' --- VALIDACIÓN Y ACTUALIZACIÓN EN TIEMPO REAL DEL STOCK EN LA GRILLA ---

    Private Sub DGVProducts_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVProducts.CellValidating
        ' Verificar si la celda editada pertenece a la columna "stock"
        If DGVProducts.Columns(e.ColumnIndex).Name = "Stock" Then
            Dim newStock As Integer

            ' Intenta convertir la entrada a un número entero. Si falla o es negativo, detiene el cambio
            If Not Integer.TryParse(e.FormattedValue.ToString(), newStock) OrElse newStock < 0 Then
                e.Cancel = True
                MessageBox.Show("El stock debe ser un número entero mayor o igual a 0.", "Validación de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub DGVProducts_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducts.CellValueChanged
        ' Se activa cuando el usuario confirma el cambio en la celda
        If e.RowIndex < 0 OrElse DGVProducts.Columns(e.ColumnIndex).Name <> "Stock" Then Exit Sub

        Dim idMoto As Integer = Convert.ToInt32(DGVProducts.Rows(e.RowIndex).Cells("IdMoto").Value)
        Dim nuevoStock As Integer = Convert.ToInt32(DGVProducts.Rows(e.RowIndex).Cells("Stock").Value)

        ' MÁS ADELANTE: UPDATE Productos SET stock = @nuevoStock WHERE id_moto = @idMoto
        Console.WriteLine($"Stock actualizado en BD para ID {idMoto}: {nuevoStock}")
    End Sub

    ' --- ELIMINACIÓN DE REGISTROS ---

    Private Sub BDeleteProduct_Click(sender As Object, e As EventArgs) Handles BDeleteProduct.Click
        If DGVProducts.SelectedCells.Count = 0 Then
            MessageBox.Show("Seleccione una moto de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = DGVProducts.SelectedCells(0).RowIndex
        Dim selectedModel As String = DGVProducts.Rows(rowIndex).Cells("Modelo").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de eliminar la moto '{selectedModel}'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            DGVProducts.Rows.RemoveAt(rowIndex)
            MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BSearch_Click(sender As Object, e As EventArgs) Handles BSearch.Click
        MessageBox.Show("Filtro de búsqueda aplicado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        TBSearch.Clear()
        LoadMockData()
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

End Class