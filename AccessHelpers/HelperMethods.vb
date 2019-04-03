Imports Contracts
Imports ServiceLayer
Imports Repository
Public Class HelperMethods

    Private svc As RepositoryService

    Public Sub New()
        svc = New RepositoryService(New dbAccess)
    End Sub

    Public Function GetSiteLookup() As List(Of SiteLookupResponse)
        Return svc.GetSiteLookup()
    End Function

    Public Function GetDocTypeLookup() As List(Of DocTypeLookupResponse)
        Return svc.GetDocTypeLookup()
    End Function

    Public Sub UpdateSiteName(siteId As String, siteName As String)
        Dim request = New UpdateSiteRequest With
                {
                    .SiteId = siteId,
                    .SiteName = siteName
                }

        svc.UpdateSite(request)
    End Sub

    Public Sub UpdateDocType(DocTypeId As String, docTypeName As String)
        Dim request = New UpdateDocTypeRequest With
        {
                .DocType = docTypeName,
                .DocTypeId = DocTypeId
        }

        svc.UpdateDocType(request)
    End Sub
End Class
