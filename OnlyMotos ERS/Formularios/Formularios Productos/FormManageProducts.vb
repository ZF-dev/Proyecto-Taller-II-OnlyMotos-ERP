Public Class FormManageProducts
    Private Sub FormManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearForm()
        CargarComboBoxes()
    End Sub

    Private Sub ClearForm()
        TBModel.Clear()
        TBPrice.Clear()
        TBYear.Clear()
        NUDStock.Value = 1
        NUDStockMin.Value = 1
    End Sub

    Private Sub CargarComboBoxes()
        Try
            Dim negocioMoto As New ProductoNegocio()

            CBBrand.DataSource = negocioMoto.ObtenerMarcas()
            CBBrand.DisplayMember = "nombre"
            CBBrand.ValueMember = "id_marca"
            CBBrand.SelectedIndex = -1


            CBCylinder.DataSource = negocioMoto.ObtenerCc()
            CBCylinder.DisplayMember = "tamaño"
            CBCylinder.ValueMember = "id_cc"
            CBCylinder.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Error al cargar las listas desplegables: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BSelectImage_Click(sender As Object, e As EventArgs) Handles BSelectImage.Click

        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        Dim price As Decimal
        Dim year As Integer

        If CBBrand.SelectedValue Is Nothing OrElse CBBrand.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(CBBrand.Text) Then
            MessageBox.Show("Por favor seleccione una marca válida de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CBBrand.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TBPrice.Text) OrElse Not Decimal.TryParse(TBPrice.Text, price) OrElse price <= 0 Then
            MessageBox.Show("Ingrese un precio unitario válido mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBPrice.Focus()
            Exit Sub
        End If

        If CBCylinder.SelectedValue Is Nothing OrElse CBCylinder.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(CBCylinder.Text) Then
            MessageBox.Show("Ingrese una cilindrada válida mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CBCylinder.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(TBYear.Text) OrElse Not Integer.TryParse(TBYear.Text, year) OrElse year <= 0 Then
            MessageBox.Show("Ingrese un año válido mayor a cero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBYear.Focus()
            Exit Sub
        End If

        Try
            Dim negocio As New ProductoNegocio()



            Dim idMarca As Integer = Convert.ToInt32(CBBrand.SelectedValue)
            Dim idCc As Integer = Convert.ToInt32(CBCylinder.SelectedValue)
            Dim stock As Integer = Convert.ToInt32(NUDStock.Value)
            Dim stockMin As Integer = Convert.ToInt32(NUDStockMin.Value)
            Dim rutaOrigen As String = TBImagePath.Text.Trim()
            Dim yearBD As String = TBYear.Text.Trim()

            negocio.RegistrarMoto(idMarca, idCc, TBModel.Text, price, stock, stockMin, rutaOrigen, yearBD)

            MessageBox.Show("Moto registrada correctamente en el catálogo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error al registrar la moto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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