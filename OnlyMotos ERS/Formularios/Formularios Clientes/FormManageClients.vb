Public Class FormManageClients
    Private Sub FormManageClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TBDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDNI.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub TBPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBPhone.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub TBName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBName.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub TBLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBLastName.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click

        If String.IsNullOrWhiteSpace(TBDNI.Text) Then

            MessageBox.Show("Por favor, ingrese el DNI del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBDNI.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBName.Text) Then

            MessageBox.Show("Por favor, ingrese el Nombre del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBName.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBLastName.Text) Then

            MessageBox.Show("Por favor, ingrese el Apellido del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBLastName.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBEmail.Text) Then

            MessageBox.Show("Por favor, ingrese el Email del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBEmail.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBPhone.Text) Then

            MessageBox.Show("Por favor, ingrese el Teléfono del cliente.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBPhone.Focus()
            Exit Sub

        End If

        ' Validar formato mínimo de Email (si se ingresó algo)
        If Not String.IsNullOrWhiteSpace(TBEmail.Text) AndAlso Not TBEmail.Text.Contains("@") Then

            MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBEmail.Focus()
            Exit Sub

        End If

        ' 2. Captura de datos
        Dim dni As String = TBDNI.Text.Trim()
        Dim nombre As String = TBName.Text.Trim()
        Dim apellido As String = TBLastName.Text.Trim()
        Dim telefono As String = TBPhone.Text.Trim()
        Dim email As String = TBEmail.Text.Trim()

        ' MÁS ADELANTE EN BD: INSERT INTO Clientes (dni, nombre_apellido, telefono, email, estado) VALUES (...)
        Console.WriteLine($"Nuevo cliente a registrar: DNI {dni} - {nombre} {apellido}")

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class