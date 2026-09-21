<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        TSMIRegisterSell = New ToolStripMenuItem()
        TSMISellHistory = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        TSMIManageProducts = New ToolStripMenuItem()
        TSMISeeProducts = New ToolStripMenuItem()
        GestionDeClientesToolStripMenuItem = New ToolStripMenuItem()
        TSMIManageClients = New ToolStripMenuItem()
        TSMISeeClients = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        TSMIManageUsers = New ToolStripMenuItem()
        TSMISeeUsers = New ToolStripMenuItem()
        TSMIReports = New ToolStripMenuItem()
        SistemaToolStripMenuItem = New ToolStripMenuItem()
        TSMIBackup = New ToolStripMenuItem()
        TSMIRestore = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        TSMILogout = New ToolStripMenuItem()
        TSMIExit = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {VentasToolStripMenuItem, ProductosToolStripMenuItem, GestionDeClientesToolStripMenuItem, UsuariosToolStripMenuItem, TSMIReports, SistemaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMIRegisterSell, TSMISellHistory})
        VentasToolStripMenuItem.Image = My.Resources.Resources.Icono_ventas_Chiquito
        VentasToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(69, 20)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' TSMIRegisterSell
        ' 
        TSMIRegisterSell.Name = "TSMIRegisterSell"
        TSMIRegisterSell.Size = New Size(157, 22)
        TSMIRegisterSell.Text = "Registrar ventas"
        ' 
        ' TSMISellHistory
        ' 
        TSMISellHistory.Name = "TSMISellHistory"
        TSMISellHistory.Size = New Size(157, 22)
        TSMISellHistory.Text = "Lista de ventas"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMIManageProducts, TSMISeeProducts})
        ProductosToolStripMenuItem.Image = My.Resources.Resources.Icono_Productos_Chiquito
        ProductosToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(89, 20)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' TSMIManageProducts
        ' 
        TSMIManageProducts.Name = "TSMIManageProducts"
        TSMIManageProducts.Size = New Size(148, 22)
        TSMIManageProducts.Text = "Agregar Moto"
        ' 
        ' TSMISeeProducts
        ' 
        TSMISeeProducts.Name = "TSMISeeProducts"
        TSMISeeProducts.Size = New Size(148, 22)
        TSMISeeProducts.Text = "Ver Motos"
        ' 
        ' GestionDeClientesToolStripMenuItem
        ' 
        GestionDeClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMIManageClients, TSMISeeClients})
        GestionDeClientesToolStripMenuItem.Image = My.Resources.Resources.Icono_Clientes_Chiquito
        GestionDeClientesToolStripMenuItem.Name = "GestionDeClientesToolStripMenuItem"
        GestionDeClientesToolStripMenuItem.Size = New Size(77, 20)
        GestionDeClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' TSMIManageClients
        ' 
        TSMIManageClients.Name = "TSMIManageClients"
        TSMIManageClients.Size = New Size(149, 22)
        TSMIManageClients.Text = "Nuevo Cliente"
        ' 
        ' TSMISeeClients
        ' 
        TSMISeeClients.Name = "TSMISeeClients"
        TSMISeeClients.Size = New Size(149, 22)
        TSMISeeClients.Text = "Ver Clientes"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMIManageUsers, TSMISeeUsers})
        UsuariosToolStripMenuItem.Image = My.Resources.Resources.Icono_usuarios_Chiquito
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(80, 20)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' TSMIManageUsers
        ' 
        TSMIManageUsers.Name = "TSMIManageUsers"
        TSMIManageUsers.Size = New Size(162, 22)
        TSMIManageUsers.Text = "Alta de Usuarios"
        ' 
        ' TSMISeeUsers
        ' 
        TSMISeeUsers.Name = "TSMISeeUsers"
        TSMISeeUsers.Size = New Size(162, 22)
        TSMISeeUsers.Text = "Lista de Usuarios"
        ' 
        ' TSMIReports
        ' 
        TSMIReports.Image = My.Resources.Resources.Icono_Reportes_Chiquito
        TSMIReports.Name = "TSMIReports"
        TSMIReports.Size = New Size(81, 20)
        TSMIReports.Text = "Reportes"
        ' 
        ' SistemaToolStripMenuItem
        ' 
        SistemaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TSMIBackup, TSMIRestore, ToolStripMenuItem1, TSMILogout, TSMIExit})
        SistemaToolStripMenuItem.Image = My.Resources.Resources.Icono_Sistema_Chiquito
        SistemaToolStripMenuItem.ImageAlign = ContentAlignment.BottomLeft
        SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        SistemaToolStripMenuItem.Size = New Size(76, 20)
        SistemaToolStripMenuItem.Text = "Sistema"
        ' 
        ' TSMIBackup
        ' 
        TSMIBackup.Name = "TSMIBackup"
        TSMIBackup.Size = New Size(143, 22)
        TSMIBackup.Text = "Back Up"
        ' 
        ' TSMIRestore
        ' 
        TSMIRestore.Name = "TSMIRestore"
        TSMIRestore.Size = New Size(143, 22)
        TSMIRestore.Text = "Restore"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(140, 6)
        ' 
        ' TSMILogout
        ' 
        TSMILogout.Name = "TSMILogout"
        TSMILogout.Size = New Size(143, 22)
        TSMILogout.Text = "Cerrar Sesion"
        ' 
        ' TSMIExit
        ' 
        TSMIExit.Name = "TSMIExit"
        TSMIExit.Size = New Size(143, 22)
        TSMIExit.Text = "Salir"
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "FormMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OnlyMotos ERP"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIRegisterSell As ToolStripMenuItem
    Friend WithEvents TSMISellHistory As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIManageProducts As ToolStripMenuItem
    Friend WithEvents TSMISeeProducts As ToolStripMenuItem
    Friend WithEvents GestionDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIManageClients As ToolStripMenuItem
    Friend WithEvents TSMISeeClients As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIManageUsers As ToolStripMenuItem
    Friend WithEvents TSMISeeUsers As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMIBackup As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents TSMILogout As ToolStripMenuItem
    Friend WithEvents TSMIExit As ToolStripMenuItem
    Friend WithEvents TSMIReports As ToolStripMenuItem
    Friend WithEvents TSMIRestore As ToolStripMenuItem
End Class
