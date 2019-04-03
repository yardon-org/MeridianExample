Public Interface IRepository
    Function GetSiteLookup() As DataSet

    Function GetDocTypeLookup() As DataSet

    Sub UpdateSite(request As UpdateSiteRequest)

    Sub UpdateDocType(request As UpdateDocTypeRequest)
End Interface
