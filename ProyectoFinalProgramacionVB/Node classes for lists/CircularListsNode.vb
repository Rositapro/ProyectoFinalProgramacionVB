Public Class CircularListsNode
    Public Property Value As Integer
    Public Property [Next] As CircularListsNode

    Public Sub New()
        Value = 0
        [Next] = Nothing
    End Sub

    Public Sub New(value As Integer)
        Me.Value = value
        [Next] = Nothing
    End Sub
End Class
