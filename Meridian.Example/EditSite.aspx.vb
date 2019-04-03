Imports AccessHelpers

Public Class EditSite
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Field1.Text = Request.QueryString("SiteName")
        End If
    End Sub

    Protected Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim helper = New HelperMethods()

        helper.UpdateSiteName(Session("SiteId"), Field1.Text)
    End Sub
End Class