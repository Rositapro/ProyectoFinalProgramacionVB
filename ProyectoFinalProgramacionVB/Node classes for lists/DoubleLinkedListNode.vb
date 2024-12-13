Public Class DoubleLinkedListNode
    Public Property Data As Integer
    Public Property [Next] As DoubleLinkedListNode
    Public Property Prev As DoubleLinkedListNode

    Public Sub New(data As Integer)
        Me.Data = data
        [Next] = Nothing
        Prev = Nothing
    End Sub
End Class
