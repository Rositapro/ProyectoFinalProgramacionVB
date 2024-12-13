Public Class DoubleCircularList
    Private head As DoubleCircularListNode

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(value As Integer)
        Dim newNode As New DoubleCircularListNode(value)

        If head Is Nothing Then
            head = newNode
            head.Next = head
            head.Prev = head
            Return
        End If

        If value < head.Value Then
            newNode.Next = head
            newNode.Prev = head.Prev
            head.Prev.Next = newNode
            head.Prev = newNode
            head = newNode
            Return
        End If

        Dim current As DoubleCircularListNode = head

        While current.Next IsNot head AndAlso current.Next.Value < value
            current = current.Next
        End While

        newNode.Next = current.Next
        newNode.Prev = current
        current.Next.Prev = newNode
        current.Next = newNode
    End Sub

    Public Sub Remove(value As Integer)
        If head Is Nothing Then Return

        Dim current As DoubleCircularListNode = head

        Do
            If current.Value = value Then
                If current Is head AndAlso current.Next Is head Then
                    head = Nothing
                    Return
                End If

                current.Prev.Next = current.Next
                current.Next.Prev = current.Prev

                If current Is head Then head = current.Next
                Return
            End If
            current = current.Next
        Loop While current IsNot head
    End Sub

    Public Function Contains(value As Integer) As Boolean
        If head Is Nothing Then Return False

        Dim current As DoubleCircularListNode = head

        Do
            If current.Value = value Then Return True
            current = current.Next
        Loop While current IsNot head

        Return False
    End Function

    Public Overrides Function ToString() As String
        If head Is Nothing Then Return "The list is empty"

        Dim result As String = ""
        Dim current As DoubleCircularListNode = head

        Do
            result &= current.Value & " "
            current = current.Next
        Loop While current IsNot head

        Return result.Trim()
    End Function
End Class
