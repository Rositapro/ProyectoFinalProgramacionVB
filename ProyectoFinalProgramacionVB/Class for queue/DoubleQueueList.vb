Public Class DoubleQueueList
    Private front As NodeDoubleQueueList
    Private rear As NodeDoubleQueueList
    Private count As Integer

    Public Sub New()
        front = Nothing
        rear = Nothing
        count = 0
    End Sub

    Public Sub InsertFront(value As Integer)
        Dim newNode As New NodeDoubleQueueList(value)

        If count = 0 Then
            front = newNode
            rear = newNode
        Else
            newNode.Next = front
            front.Prev = newNode
            front = newNode
        End If

        count += 1
    End Sub

    Public Sub InsertRear(value As Integer)
        Dim newNode As New NodeDoubleQueueList(value)

        If count = 0 Then
            front = newNode
            rear = newNode
        Else
            newNode.Prev = rear
            rear.Next = newNode
            rear = newNode
        End If

        count += 1
    End Sub

    Public Function RemoveFront() As Integer
        If count = 0 Then
            Throw New InvalidOperationException("Deque is empty")
        End If

        Dim value As Integer = front.Value
        front = front.Next

        If front IsNot Nothing Then
            front.Prev = Nothing
        Else
            rear = Nothing
        End If

        count -= 1
        Return value
    End Function

    Public Function RemoveRear() As Integer
        If count = 0 Then
            Throw New InvalidOperationException("Deque is empty")
        End If

        Dim value As Integer = rear.Value
        rear = rear.Prev

        If rear IsNot Nothing Then
            rear.Next = Nothing
        Else
            front = Nothing
        End If

        count -= 1
        Return value
    End Function

    Public Function GetDequeElements() As Integer()
        Dim elements(count - 1) As Integer
        Dim current As NodeDoubleQueueList = front

        For i As Integer = 0 To count - 1
            elements(i) = current.Value
            current = current.Next
        Next

        Return elements
    End Function

    Public Function GetCount() As Integer
        Return count
    End Function
End Class
