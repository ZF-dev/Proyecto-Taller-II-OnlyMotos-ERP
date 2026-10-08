Public Class FormSeeProducts
    Private Sub FormSeeProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarMotosGrid()

    End Sub

    Private Sub CargarMotosGrid()

        Try
            Dim negocio As New ProductoNegocio()
            DGVProducts.DataSource = negocio.ObtenerMotos()

        Catch ex As Exception

            MessageBox.Show("Error al cargar el catálogo de motos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub



    Private Sub DGVProducts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducts.CellEndEdit

        Dim estaValidandoStock As Boolean = False

        If estaValidandoStock OrElse e.RowIndex < 0 Then Exit Sub

        Dim columnName As String = DGVProducts.Columns(e.ColumnIndex).Name

        If columnName = "Stock" Then

            Dim row As DataGridViewRow = DGVProducts.Rows(e.RowIndex)
            Dim idMoto As Integer = Convert.ToInt32(row.Cells("IdMoto").Value)
            Dim valorCelda = row.Cells("Stock").Value
            Dim nuevoStock As Integer

            If valorCelda Is Nothing OrElse Not Integer.TryParse(valorCelda.ToString(), nuevoStock) OrElse nuevoStock < 0 Then

                estaValidandoStock = True
                MessageBox.Show("El stock debe ser un número entero válido mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CargarMotosGrid()
                Exit Sub

            End If

            Try

                Dim negocio As New ProductoNegocio()
                negocio.ModificarStockMoto(idMoto, nuevoStock)

            Catch ex As Exception

                estaValidandoStock = True
                MessageBox.Show("Error al actualizar el stock: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CargarMotosGrid()

            End Try

        End If

    End Sub


    Private Sub BDeleteProduct_Click(sender As Object, e As EventArgs) Handles BDeleteProduct.Click
        If DGVProducts.SelectedCells.Count = 0 Then
            MessageBox.Show("Seleccione una moto de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = DGVProducts.SelectedCells(0).RowIndex
        Dim selectedModel As String = DGVProducts.Rows(rowIndex).Cells("Modelo").Value.ToString()

        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de eliminar la moto '{selectedModel}'?", "Confirmar Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Try

                Dim row As DataGridViewRow = DGVProducts.SelectedRows(0)
                Dim idMoto As Integer = Convert.ToInt32(row.Cells("IdMoto").Value)

                Dim negocio As New ProductoNegocio()
                negocio.DarDeBajaMoto(idMoto)

                MessageBox.Show("Moto eliminada correctamente del catálogo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)


                CargarMotosGrid()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar la moto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TBSearchModel_TextChanged(sender As Object, e As EventArgs) Handles TBSearch.TextChanged

        Try
            Dim negocio As New ProductoNegocio()
            Dim filtro As String = TBSearch.Text.Trim()

            DGVProducts.DataSource = negocio.ObtenerMotosPorModelo(filtro)

        Catch ex As Exception
            MessageBox.Show("Error al filtrar las motos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BClearFilters_Click(sender As Object, e As EventArgs) Handles BClearFilters.Click
        TBSearch.Clear()
        CargarMotosGrid()
    End Sub

    Private Sub BClose_Click(sender As Object, e As EventArgs) Handles BClose.Click
        Me.Close()
    End Sub

End Class