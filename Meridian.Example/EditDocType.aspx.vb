Imports AccessHelpers

Public Class EditDocType
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Field1.Text = Session("DocType")
    End Sub

    Protected Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If Not Page.IsPostBack Then
            Dim helper = New HelperMethods()

            helper.UpdateSiteName(Session("DocTypeId"), Field1.Text)
        End If
    End Sub
End Class