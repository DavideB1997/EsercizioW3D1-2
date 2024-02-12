Imports System.Security.Principal

Public Class Esercizio
    Inherits System.Web.UI.Page



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ConfigurationManager.AppSettings.Get("nome") & ConfigurationManager.AppSettings.Get("Cognome")
    End Sub

End Class
