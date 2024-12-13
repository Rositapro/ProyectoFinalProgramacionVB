Public Class PriorityQueueLists
    Private priorityQueue As LinkedList(Of LinkedList(Of Integer))

    Public Sub New(priorityLevels As Integer)
        priorityQueue = New LinkedList(Of LinkedList(Of Integer))()
        For i As Integer = 0 To priorityLevels - 1
            priorityQueue.AddLast(New LinkedList(Of Integer)())
        Next
    End Sub

    Public Sub Enqueue(value As Integer, priority As Integer)
        If priority < 0 OrElse priority >= priorityQueue.Count Then
            Throw New ArgumentOutOfRangeException(NameOf(priority), "Invalid priority level.")
        End If

        Dim node As LinkedListNode(Of LinkedList(Of Integer)) = GetPriorityNode(priority)
        node.Value.AddLast(value)
    End Sub

    Public Function Dequeue() As Integer
        For Each list As LinkedList(Of Integer) In priorityQueue
            If list.Count > 0 Then
                Dim value As Integer = list.First.Value
                list.RemoveFirst()
                Return value
            End If
        Next

        Throw New InvalidOperationException("Priority queue is empty.")
    End Function

    Public Function GetQueueElements() As LinkedList(Of LinkedList(Of Integer))
        Return priorityQueue
    End Function

    Private Function GetPriorityNode(priority As Integer) As LinkedListNode(Of LinkedList(Of Integer))
        Dim current As LinkedListNode(Of LinkedList(Of Integer)) = priorityQueue.First
        For i As Integer = 0 To priority - 1
            current = current.Next
        Next
        Return current
    End Function
End Class
