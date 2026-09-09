Public Class FormReports
    Private Sub FormReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyRolePermissions()

    End Sub

    Private Sub ApplyRolePermissions()

        ' Mostrar el usuario y rol actual en la interfaz
        GBCurrentSession.Text = $"Usuario: {CurrentUserName} | Rol: {CurrentUserRole}"

        Select Case CurrentUserRole
            Case "Administrador"
                ' El administrador tiene acceso total a todos los reportes
                BReportUsers.Visible = True
                BReportSales.Visible = False
                BReportSalesUser.Visible = False
                BReportFinancial.Visible = False
                BReportSalesRange.Visible = False
                LStart.Visible = False
                LEnd.Visible = False
                DTPStart.Visible = False
                DTPEnd.Visible = False

            Case "Supervisor"
                ' El supervisor ve ventas, stock y actividad, pero no reportes financieros avanzados
                BReportSales.Visible = True
                BReportSalesUser.Visible = True
                BReportFinancial.Visible = True
                BReportSalesRange.Visible = False
                BReportUsers.Visible = False
                LStart.Visible = False
                LEnd.Visible = False
                DTPStart.Visible = False
                DTPEnd.Visible = False

            Case "Vendedor"
                ' El vendedor solo ve sus reportes básicos de ventas y stock
                BReportSales.Visible = True
                BReportSalesRange.Visible = True
                BReportUsers.Visible = False
                BReportFinancial.Visible = False
                BReportSalesUser.Visible = False

            Case Else
                ' Si no hay rol reconocido, oculta todo por seguridad
                BReportSales.Visible = False
                BReportSalesUser.Visible = False
                BReportFinancial.Visible = False
                BReportUsers.Visible = False
                BReportSalesRange.Visible = False
                LStart.Visible = False
                LEnd.Visible = False
                DTPStart.Visible = False
                DTPEnd.Visible = False

        End Select

    End Sub

    ' --- BOTONES PARA SIMULAR CAMBIO DE ROL EN TIEMPO REAL (TESTING) ---

    Private Sub BSimulateAdmin_Click(sender As Object, e As EventArgs) Handles BSimulateAdmin.Click
        CurrentUserRole = "Administrador"
        ApplyRolePermissions()
    End Sub

    Private Sub BSimulateSeller_Click(sender As Object, e As EventArgs) Handles BSimulateSeller.Click
        CurrentUserRole = "Vendedor"
        ApplyRolePermissions()
    End Sub

    Private Sub BSimulateSupervisor_Click(sender As Object, e As EventArgs) Handles BSimulateSupervisor.Click
        CurrentUserRole = "Supervisor"
        ApplyRolePermissions()
    End Sub

    ' --- EVENTOS DE LOS REPORTES ---

End Class