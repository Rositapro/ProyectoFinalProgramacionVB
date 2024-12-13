Public Class NodeDoubleQueueList
    Public Property Value As Integer
    Public Property [Next] As NodeDoubleQueueList
    Public Property Prev As NodeDoubleQueueList

    Public Sub New(value As Integer)
        Me.Value = value
        Me.Next = Nothing
        Me.Prev = Nothing
    End Sub
End Class
