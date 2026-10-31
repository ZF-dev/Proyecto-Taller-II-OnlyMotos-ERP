Public Class FormReports
    Private Sub FormReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyRolePermissions()

    End Sub

    Private Sub ApplyRolePermissions()

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

    Private Sub BReportUsers_Click(sender As Object, e As EventArgs) Handles BReportUsers.Click
        ' Qué muestra: Un listado consolidado de todos los usuarios del sistema,
        ' diferenciando entre activos e inactivos (los que sufrieron baja lógica)
        ' y agrupados por su tipo de perfil (Administrador, Supervisor, Vendedor).
    End Sub

    ' --- EVENTOS DE LOS REPORTES ---

    Private Sub BReportSalesUsers_Click(sender As Object, e As EventArgs) Handles BReportSalesUser.Click

        Try
            Cursor = Cursors.WaitCursor

            Dim ReportsNegocio As New ReportsNegocio()

            Dim dt As DataTable = ReportsNegocio.ListarVentasPorUsuario()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron registros de ventas para procesar el reporte.", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            GeneradorReportePDF.GenerarReporteVentasUsuario(dt)

        Catch ex As Exception

            MessageBox.Show("Ocurrió un error al generar el reporte: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            Cursor = Cursors.Default

        End Try

    End Sub

End Class