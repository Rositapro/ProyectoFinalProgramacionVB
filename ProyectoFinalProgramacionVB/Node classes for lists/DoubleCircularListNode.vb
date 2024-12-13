Public Class DoubleCircularListNode
    Public Property Value As Integer
    Public Property [Next] As DoubleCircularListNode
    Public Property Prev As DoubleCircularListNode

    Public Sub New()
        Value = 0
        [Next] = Nothing
        Prev = Nothing
    End Sub

    Public Sub New(value As Integer)
        Me.Value = value
        [Next] = Nothing
        Prev = Nothing
    End Sub

    Public Overrides Function ToString() As String
        Return Value.ToString() & ","
    End Function
End Class
