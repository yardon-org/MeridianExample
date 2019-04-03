Public Class ServiceLayerException
    Inherits Exception

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

    Public Sub New(message As String, e As Exception)
        MyBase.New(message, e)
    End Sub
End Class
