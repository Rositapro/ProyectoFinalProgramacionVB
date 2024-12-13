Public Class NodeSimpleQueueList
    Public Property Value As Integer
    Public Property [Next] As NodeSimpleQueueList

    Public Sub New(value As Integer)
        Me.Value = value
        [Next] = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return Value.ToString()
    End Function
End Class
