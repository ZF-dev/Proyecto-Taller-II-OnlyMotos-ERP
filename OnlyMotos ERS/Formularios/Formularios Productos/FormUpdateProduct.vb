Public Class FormUpdateProduct

    Public idMotoSeleccionada As Integer
    Public marcaSeleccionada As String
    Public modeloActual As String
    Public cilindradaSeleccionada As String
    Public precioActual As Decimal
    Public anioActual As Integer
    Public imagenActual As String

    Private Sub FormUpdateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarComboBoxes()
        CargarDatosEnControles()

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

    Private Sub CargarDatosEnControles()

        TBModel.Text = modeloActual
        TBPrice.Text = precioActual.ToString()
        TBYear.Text = anioActual.ToString()
        TBImagePath.Text = imagenActual

        CBBrand.SelectedText = marcaSeleccionada
        CBCylinder.SelectedText = cilindradaSeleccionada
    End Sub

    Private Sub BtnSaveUpdate_Click(sender As Object, e As EventArgs) Handles BSaveUpdate.Click

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

            Dim idMarca As Integer = Convert.ToInt32(CBBrand.SelectedValue)
            Dim modelo As String = TBModel.Text.Trim()
            Dim idCc As Integer = Convert.ToInt32(CBCylinder.SelectedValue)
            Dim precio As Decimal = Convert.ToDecimal(TBPrice.Text)
            Dim anio As Integer = Convert.ToInt32(TBYear.Text)
            Dim imagen As String = TBImagePath.Text.Trim()

            Dim negocio As New ProductoNegocio()
            negocio.ModificarMoto(idMotoSeleccionada, idMarca, modelo, idCc, precio, anio, imagen)

            MessageBox.Show("Moto actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar la moto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BSelectImage_Click(sender As Object, e As EventArgs) Handles BSelectImage.Click

        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        TBImagePath.Text = OpenFileDialog1.FileName

    End Sub
    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

End Class