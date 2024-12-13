Public Class PriorityQueueVectorLists
    Private priorityQueue As List(Of LinkedList(Of Integer))

    Public Sub New(priorityLevels As Integer)
        priorityQueue = New List(Of LinkedList(Of Integer))(priorityLevels)
        For i As Integer = 0 To priorityLevels - 1
            priorityQueue.Add(New LinkedList(Of Integer)())
        Next
    End Sub

    Public Sub Enqueue(value As Integer, priority As Integer)
        If priority < 0 OrElse priority >= priorityQueue.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(priority), "Invalid priority level.")
        End If

        priorityQueue(priority).AddLast(value)
    End Sub

    Public Function Dequeue() As Integer
        For i As Integer = 0 To priorityQueue.Count - 1
            If priorityQueue(i).Count > 0 Then
                Dim value As Integer = priorityQueue(i).First.Value
                priorityQueue(i).RemoveFirst()
                Return value
            End If
        Next

        Throw New InvalidOperationException("Priority queue is empty.")
    End Function

    Public Function GetQueueElements() As List(Of LinkedList(Of Integer))
        Return priorityQueue
    End Function
End Class
