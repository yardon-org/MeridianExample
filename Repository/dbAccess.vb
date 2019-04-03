Imports System.Configuration
Imports System.Data.SqlClient
Imports Contracts

Public Class dbAccess
    Implements IRepository
    Private connStr As String = ConfigurationManager.ConnectionStrings("MeridianExampleDBConnectionString").ConnectionString ' "server=(local);Database=MeridianExampleDB;Integrated Security=true;"

    Public Function GetSiteLookup() As DataSet Implements IRepository.GetSiteLookup
        Return RunSelectQuery("GetAllSites")
    End Function

    Public Function GetDocTypeLookup() As DataSet Implements IRepository.GetDocTypeLookup
        Return RunSelectQuery("GetAllDocTypes")
    End Function

    Public Sub UpdateSite(request As UpdateSiteRequest) Implements IRepository.UpdateSite
        Dim params As New List(Of SqlParameter)

        With params
            .Add(New SqlParameter With {
                        .ParameterName = "@SiteId",
                        .SqlValue = SqlDbType.Int,
                        .Value = request.SiteId
                 })
            .Add(New SqlParameter With {
                        .ParameterName = "@SiteName",
                        .SqlValue = SqlDbType.VarChar,
                        .Size = 150,
                        .Value = request.SiteName
                 })
        End With

        RunUpdate("UpdateSite", params.ToArray())
    End Sub

    Public Sub UpdateDocType(request As UpdateDocTypeRequest) Implements IRepository.UpdateDocType
        Dim params As New List(Of SqlParameter)

        With params
            .Add(New SqlParameter("@DocTypeId", SqlDbType.Int).Value = Integer.Parse(request.DocTypeId))
            .Add(New SqlParameter("@DocTypeName", SqlDbType.VarChar, 100).Value = request.DocType)
        End With

        RunUpdate("UpdateDocType", params.ToArray())
    End Sub

    Private Function RunSelectQuery(spName As String) As DataSet
        Using dbCon As New SqlConnection(connStr)
            dbCon.Open()

            Using dbCmd As New SqlCommand
                With dbCmd
                    .Connection = dbCon
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = spName
                End With

                Dim dataAdapter As New SqlDataAdapter(dbCmd)
                Dim ds As New DataSet

                dataAdapter.Fill(ds)

                Return ds
            End Using
        End Using
    End Function

    Private Sub RunUpdate(spName As String, params As SqlParameter())
        Using dbCon As New SqlConnection(connStr)
            dbCon.Open()

            Using dbCmd As New SqlCommand
                With dbCmd
                    .Connection = dbCon
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = spName
                    .Parameters.AddRange(params)
                End With

                dbCmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
