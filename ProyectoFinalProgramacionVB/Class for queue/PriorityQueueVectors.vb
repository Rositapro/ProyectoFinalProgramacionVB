Public Class PriorityQueueVectors
    Private priorityQueue As List(Of List(Of Integer))

    Public Sub New(priorityLevels As Integer)
        priorityQueue = New List(Of List(Of Integer))(priorityLevels)
        For i As Integer = 0 To priorityLevels - 1
            priorityQueue.Add(New List(Of Integer)())
        Next
    End Sub

    Public Sub Enqueue(value As Integer, priority As Integer)
        If priority < 0 OrElse priority >= priorityQueue.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(priority), "Invalid priority level.")
        End If
        priorityQueue(priority).Add(value)
    End Sub

    Public Function Dequeue() As Integer
        For Each list In priorityQueue
            If list.Count > 0 Then
                Dim value As Integer = list(0)
                list.RemoveAt(0)
                Return value
            End If
        Next
        Throw New InvalidOperationException("Priority queue is empty.")
    End Function

    Public Function GetQueueElements() As List(Of Integer)()
        Return priorityQueue.ToArray()
    End Function
End Class
