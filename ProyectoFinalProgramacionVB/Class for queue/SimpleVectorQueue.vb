Public Class SimpleVectorQueue
    Private queue() As Integer
    Private front As Integer
    Private rear As Integer
    Private size As Integer

    Public Sub New(capacity As Integer)
        ReDim queue(capacity - 1)
        front = -1
        rear = -1
        size = capacity
    End Sub

    Public Sub Enqueue(element As Integer)
        If rear = size - 1 Then
            Throw New InvalidOperationException("Queue is full")
        End If

        If front = -1 Then front = 0
        rear += 1
        queue(rear) = element
    End Sub

    Public Function Dequeue() As Integer
        If front = -1 OrElse front > rear Then
            Throw New InvalidOperationException("Queue is empty")
        End If

        Dim element As Integer = queue(front)
        If front = rear Then
            front = -1
            rear = -1
        Else
            front += 1
        End If

        Return element
    End Function

    Public Function GetQueueElements() As Integer()
        If front = -1 Then Return Array.Empty(Of Integer)()

        Dim elements(rear - front) As Integer
        Array.Copy(queue, front, elements, 0, elements.Length)
        Return elements
    End Function
End Class
