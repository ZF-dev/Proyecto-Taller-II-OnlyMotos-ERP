Imports System.ComponentModel
Public Class FormLogin

    ' atributos vacíos donde el Negocio guardará el rol y el nombre si el login es exitoso
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property RolObtenido As String = ""

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property NombreObtenido As String = ""

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click

        Dim negocio As New IngresoUsuario()

        Dim userIngresado As String = TBUser.Text.Trim()
        Dim passIngresada As String = TBPassword.Text.Trim()

        ' Variables locales que recibirá el Negocio por ByRef
        Dim rolTemp As String = ""
        Dim nombreTemp As String = ""

        Dim esValido As Boolean = negocio.ValidarLogin(userIngresado, passIngresada, rolTemp, nombreTemp)

        If String.IsNullOrWhiteSpace(TBUser.Text) OrElse String.IsNullOrWhiteSpace(TBPassword.Text) Then

            MessageBox.Show("por favor ingrese usuario y contraseña", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        If Not ValidadorContraseña.IsValidPassword(TBPassword.Text) Then

            MessageBox.Show("La contraseña ingresada no es válida. Debe contener minimo 8 caracteres.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBPassword.Focus()
            TBPassword.SelectAll()

            Exit Sub

        End If

        If esValido Then

            RolObtenido = rolTemp
            NombreObtenido = nombreTemp
            MessageBox.Show("¡Bienvenido, " & NombreObtenido & "!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Else

            MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TBPassword.Clear()
            TBUser.Focus()

        End If

    End Sub

    Private Sub BCancel_Click(sender As Object, e As EventArgs) Handles BCancel.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

End Class
