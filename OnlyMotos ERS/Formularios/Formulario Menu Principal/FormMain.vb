Public Class FormMain

    ' Variables para guardar los datos del usuario logueado en toda la sesión
    Private rolActual As String
    Private nombreUsuarioActual As String

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarSesion()

    End Sub

    Private Sub CargarSesion()
        ' Ocultar FormMain mientras se valida el Login
        Me.Hide()

        Dim loginForm As New FormLogin()

        If loginForm.ShowDialog() = DialogResult.OK Then

            rolActual = loginForm.RolObtenido
            nombreUsuarioActual = loginForm.NombreObtenido
            ConfigurarPermisosPorRol()
            Me.Show()

        Else

            Application.Exit()

        End If
    End Sub

    Private Sub ConfigurarPermisosPorRol()

        Me.Text = "OnlyMotos ERP - Usuario: " & nombreUsuarioActual & " [" & rolActual & "]"

        CurrentUserRole = rolActual

        If rolActual = "Vendedor" Then

            TSMIBackup.Enabled = False
            TSMIBackup.Visible = False
            TSMIRestore.Enabled = False
            TSMIRestore.Visible = False
            UsuariosToolStripMenuItem.Enabled = False
            UsuariosToolStripMenuItem.Visible = False
            TSMIManageProducts.Enabled = False
            TSMIManageProducts.Visible = False
            ProductosToolStripMenuItem.Enabled = True
            ProductosToolStripMenuItem.Visible = True
            GestionDeClientesToolStripMenuItem.Enabled = True
            GestionDeClientesToolStripMenuItem.Visible = True
            VentasToolStripMenuItem.Enabled = True
            VentasToolStripMenuItem.Visible = True


        ElseIf rolActual = "Supervisor" Then

            TSMIBackup.Enabled = False
            TSMIBackup.Visible = False
            TSMIRestore.Enabled = False
            TSMIRestore.Visible = False
            GestionDeClientesToolStripMenuItem.Enabled = False
            GestionDeClientesToolStripMenuItem.Visible = False
            VentasToolStripMenuItem.Enabled = False
            VentasToolStripMenuItem.Visible = False
            UsuariosToolStripMenuItem.Enabled = False
            UsuariosToolStripMenuItem.Visible = False
            ProductosToolStripMenuItem.Enabled = True
            ProductosToolStripMenuItem.Visible = True
            TSMIManageProducts.Enabled = True
            TSMIManageProducts.Visible = True

        Else

            TSMIBackup.Enabled = True
            TSMIBackup.Visible = True
            ProductosToolStripMenuItem.Enabled = False
            ProductosToolStripMenuItem.Visible = False
            VentasToolStripMenuItem.Enabled = False
            VentasToolStripMenuItem.Visible = False
            GestionDeClientesToolStripMenuItem.Enabled = False
            GestionDeClientesToolStripMenuItem.Visible = False
            TSMIManageProducts.Enabled = True
            TSMIManageProducts.Visible = True
            UsuariosToolStripMenuItem.Enabled = True
            UsuariosToolStripMenuItem.Visible = True

        End If
        ' Si es Administrador, tiene acceso total, no hace falta tocar nada.
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

    Private Sub TSMIManageUsers_Click(sender As Object, e As EventArgs) Handles TSMIManageUsers.Click
        OpenChildForm(Of FormManageUsers)()
    End Sub

    Private Sub TSMISeeUsers_Click(sender As Object, e As EventArgs) Handles TSMISeeUsers.Click
        OpenChildForm(Of FormSeeUsers)()
    End Sub

    Private Sub TSMIRestore_Click(sender As Object, e As EventArgs) Handles TSMIRestore.Click
        OpenChildForm(Of FormRestore)()
    End Sub

    Private Sub TSMIBackup_Click(sender As Object, e As EventArgs) Handles TSMIBackup.Click
        OpenChildForm(Of FormBackUp)()
    End Sub

    Private Sub TSMIReports_Click(sender As Object, e As EventArgs) Handles TSMIReports.Click
        OpenChildForm(Of FormReports)()
    End Sub

    Private Sub TSMILogout_Click(sender As Object, e As EventArgs) Handles TSMILogout.Click

        Dim response As DialogResult = MessageBox.Show("¿Desea cerrar la sesión actual?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            CargarSesion()

        End If

    End Sub

    Private Sub TSMIExit_Click(sender As Object, e As EventArgs) Handles TSMIExit.Click

        Dim response As DialogResult = MessageBox.Show("¿Está seguro de que desea salir de OnlyMotos ERS?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

End Class