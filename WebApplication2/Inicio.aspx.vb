Imports AccesoDatos.accesoDatosSQL

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarConexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Boolean
        resultado = login(TextBox1.Text, TextBox2.Text)
        If (resultado) Then
            Session.Contents("correo") = TextBox1.Text
            Response.Redirect("pagina.aspx")
        ElseIf (Not resultado) Then
            Label2.Text = "Datos de acceso incorrectos. Inténtalo de nuevo."
        Else
            Label2.Text = "Ha ocurrido un problema inesperado. Inténtalo de nuevo."
        End If
    End Sub


End Class