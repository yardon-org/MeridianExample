Imports AccessHelpers

Public Class DropsDowns
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not (Page.IsPostBack) Then
            Dim helper = New HelperMethods

            With SiteDropDown
                .DataSource = helper.GetSiteLookup()
                .DataTextField = "SiteName"
                .DataValueField = "SiteId"
                .DataBind()
            End With

            With DocumentTypeDropDown
                .DataSource = helper.GetDocTypeLookup()
                .DataTextField = "DocType"
                .DataValueField = "DocTypeId"
                .DataBind()
            End With
        End If
    End Sub

    Protected Sub EditSiteButton_Click(sender As Object, e As EventArgs) Handles EditSiteButton.Click
        Dim url = $"EditSite.aspx?SiteName={SiteDropDown.SelectedItem.Text}"
        Session("SiteId") = SiteDropDown.SelectedItem.Value
        Response.Redirect(url)
    End Sub

    Protected Sub EditDocTypeButton_Click(sender As Object, e As EventArgs) Handles EditDocTypeButton.Click
        Session("DocType") = DocumentTypeDropDown.SelectedItem.Text
        Server.Transfer("EditDocType.aspx", True)
    End Sub
End Class