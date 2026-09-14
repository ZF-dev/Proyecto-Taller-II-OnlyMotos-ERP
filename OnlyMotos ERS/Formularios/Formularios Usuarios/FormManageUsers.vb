Public Class FormManageUsers
    Private Sub FormManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        ' Permitir solo letras, espacios y teclas de control (retroceso, etc.)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBLastName.KeyPress
        ' Permitir solo letras, espacios y teclas de control (retroceso, etc.)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' --- BOTONES DE ACCIÓN ---

    Private Sub BSave_Click(sender As Object, e As EventArgs) Handles BSave.Click
        ' 1. Validaciones de campos obligatorios
        If String.IsNullOrWhiteSpace(TBName.Text) OrElse String.IsNullOrWhiteSpace(TBLastName.Text) Then

            MessageBox.Show("Por favor complete el nombre y el apellido del usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBName.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBDNI.Text) Then

            MessageBox.Show("Ingrese el número de DNI.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBDNI.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBUser.Text) OrElse String.IsNullOrWhiteSpace(TBPassword.Text) Then

            MessageBox.Show("Debe ingresar un nombre de usuario y una contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBUser.Focus()
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(TBEmail.Text) Then

            MessageBox.Show("Por favor, ingrese una dirección de correo electrónico.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBEmail.Focus()
            Exit Sub

        ElseIf Not IsValidEmail(TBEmail.Text) Then

            MessageBox.Show("El correo electrónico ingresado no tiene un formato válido (ejemplo: usuario@dominio.com).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBEmail.Focus()
            TBEmail.SelectAll()
            Exit Sub

        End If

        If CBProfile.SelectedIndex = -1 Then

            MessageBox.Show("Por favor seleccione un perfil de la lista desplegable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CBProfile.Focus()
            Exit Sub

        End If

        MessageBox.Show($"Usuario '{TBUser.Text}' registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class