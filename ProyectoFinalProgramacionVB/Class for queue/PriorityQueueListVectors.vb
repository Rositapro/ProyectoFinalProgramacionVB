Public Class PriorityQueueListVectors
    Private priorityQueue As LinkedList(Of List(Of Integer))

    Public Sub New(priorityLevels As Integer)
        priorityQueue = New LinkedList(Of List(Of Integer))()
        For i As Integer = 0 To priorityLevels - 1
            priorityQueue.AddLast(New List(Of Integer)())
        Next
    End Sub

    Public Sub Enqueue(value As Integer, priority As Integer)
        If priority < 0 OrElse priority >= priorityQueue.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(priority), "Invalid priority level.")
        End If

        Dim node As LinkedListNode(Of List(Of Integer)) = GetNodeByPriority(priority)
        node.Value.Add(value)
    End Sub

    Public Function Dequeue() As Integer
        For Each list As List(Of Integer) In priorityQueue
            If list.Count > 0 Then
                Dim value As Integer = list(0)
                list.RemoveAt(0)
                Return value
            End If
        Next

        Throw New InvalidOperationException("Priority queue is empty.")
    End Function

    Public Function GetQueueElements() As LinkedList(Of List(Of Integer))
        Return priorityQueue
    End Function

    Private Function GetNodeByPriority(priority As Integer) As LinkedListNode(Of List(Of Integer))
        Dim current As LinkedListNode(Of List(Of Integer)) = priorityQueue.First
        For i As Integer = 0 To priority - 1
            current = current.Next
        Next
        Return current
    End Function
End Class
