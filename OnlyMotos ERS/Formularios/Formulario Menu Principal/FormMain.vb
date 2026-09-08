Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar FormMain mientras se valida el Login
        Me.Hide()

        Dim loginForm As New FormLogin()

        If loginForm.ShowDialog() = DialogResult.OK Then
            Me.Show()
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub OpenChildForm(Of T As {Form, New})()

        For Each child As Form In Me.MdiChildren

            If TypeOf child Is T Then

                child.BringToFront()
                Exit Sub

            End If

        Next

        Dim newForm As New T()
        newForm.MdiParent = Me
        newForm.Show()

    End Sub

    Private Sub TSMIRegisterSell_Click(sender As Object, e As EventArgs) Handles TSMIRegisterSell.Click
        OpenChildForm(Of FormSellMoto)()
    End Sub

    Private Sub TSMISellHistory_Click(sender As Object, e As EventArgs) Handles TSMISellHistory.Click
        OpenChildForm(Of FormSellHistory)()
    End Sub

    Private Sub TSMIManageProducts_Click(sender As Object, e As EventArgs) Handles TSMIManageProducts.Click
        OpenChildForm(Of FormManageProducts)()
    End Sub

    Private Sub TSMISeeProducts_Click(sender As Object, e As EventArgs) Handles TSMISeeProducts.Click
        OpenChildForm(Of FormSeeProducts)()
    End Sub

    Private Sub TSMIManageClients_Click(sender As Object, e As EventArgs) Handles TSMIManageClients.Click

        OpenChildForm(Of FormManageClients)()

    End Sub

    Private Sub TSMISeeClients_Click(sender As Object, e As EventArgs) Handles TSMISeeClients.Click
        OpenChildForm(Of FormSeeClients)()
    End Sub

    Private Sub TSMISeeUsers_Click(sender As Object, e As EventArgs) Handles TSMISeeUsers.Click
        'OpenChildForm(Of FormSeeUsers)()
    End Sub

    Private Sub TSMIBackup_Click(sender As Object, e As EventArgs) Handles TSMIBackup.Click
        ' Lógica de copia de seguridad
    End Sub

    Private Sub TSMIReports_Click(sender As Object, e As EventArgs)
        ' Lógica de generación de reportes
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