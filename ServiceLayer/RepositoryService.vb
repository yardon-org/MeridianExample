Imports Contracts

Public Class RepositoryService

    Private repository As IRepository
    Public Sub New(repo As IRepository)
        repository = repo
    End Sub

    Public Function GetSiteLookup() As List(Of SiteLookupResponse)
        Try
            Dim dt = repository.GetSiteLookup().Tables(0)

            Dim response As New List(Of SiteLookupResponse)

            For Each dRow As DataRow In dt.Rows
                Dim s As New SiteLookupResponse With
                    {
                        .SiteId = dRow("SiteId"),
                        .SIteName = dRow("SiteName")
                    }
                response.Add(s)
            Next

            Return response

        Catch ex As Exception
            Throw New ServiceLayerException("Failed to read from Repository", ex)

        End Try
    End Function

    Public Function GetDocTypeLookup() As List(Of DocTypeLookupResponse)
        Try
            Dim dt = repository.GetDocTypeLookup().Tables(0)

            Dim response As New List(Of DocTypeLookupResponse)

            For Each dRow As DataRow In dt.Rows
                Dim s As New DocTypeLookupResponse With
                        {
                        .DocTypeId = dRow("DocTypeId"),
                        .DocType = dRow("DocType")
                        }
                response.Add(s)
            Next

            Return response

        Catch ex As Exception
            Throw New ServiceLayerException("Failed to read from Repository", ex)

        End Try
    End Function

    Public Sub UpdateSite(request As UpdateSiteRequest)
        repository.UpdateSite(request)
    End Sub

    Public Sub UpdateDocType(request As UpdateDocTypeRequest)
        repository.UpdateDocType(request)
    End Sub
End Class
