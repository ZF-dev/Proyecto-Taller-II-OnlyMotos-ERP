Public Class FormLogin
    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        If String.IsNullOrWhiteSpace(TBUser.Text) OrElse String.IsNullOrWhiteSpace(TBPassword.Text) Then

            MessageBox.Show("por favor ingrese usuario y contraseña", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub
End Class
