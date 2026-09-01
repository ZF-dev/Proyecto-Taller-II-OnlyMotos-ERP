Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar FormMain mientras se valida el Login
        Me.Hide()

        Dim loginForm As New FormLogin()

        ' Evaluar si el usuario se autenticó correctamente
        If loginForm.ShowDialog() = DialogResult.OK Then
            Me.Show()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub TSMILogout_Click(sender As Object, e As EventArgs) Handles TSMILogout.Click
        Dim response As DialogResult = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then
            Me.Hide()

            Dim loginForm As New FormLogin()

            If loginForm.ShowDialog() = DialogResult.OK Then

                Me.Show()

            Else

                Application.Exit()

            End If

        End If

    End Sub

    Private Sub TSMIExit_Click(sender As Object, e As EventArgs) Handles TSMIExit.Click
        Dim response As DialogResult = MessageBox.Show("¿Está seguro de que desea salir de OnlyMotos ERS?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            Application.Exit()

        End If
    End Sub

End Class