Public Class SimpleQueueList
    Private front As NodeSimpleQueueList
    Private rear As NodeSimpleQueueList

    Public Sub New()
        front = Nothing
        rear = Nothing
    End Sub

    Public Sub Enqueue(value As Integer)
        Dim newNode As New NodeSimpleQueueList(value)

        If rear Is Nothing Then
            front = newNode
            rear = newNode
        Else
            rear.Next = newNode
            rear = newNode
        End If
    End Sub

    Public Function Dequeue() As Integer
        If front Is Nothing Then
            Throw New InvalidOperationException("Queue is empty")
        End If

        Dim value As Integer = front.Value
        front = front.Next

        If front Is Nothing Then
            rear = Nothing
        End If

        Return value
    End Function

    Public Function GetQueueElements() As IEnumerable(Of Integer)
        Dim elements As New List(Of Integer)()
        Dim current As NodeSimpleQueueList = front

        While current IsNot Nothing
            elements.Add(current.Value)
            current = current.Next
        End While

        Return elements
    End Function
End Class
