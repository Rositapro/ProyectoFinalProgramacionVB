Public Class DoubleQueueVector
    Private deque() As Integer
    Private front As Integer
    Private rear As Integer
    Private size As Integer
    Private count As Integer

    Public Sub New(capacity As Integer)
        size = capacity
        ReDim deque(size - 1)
        front = 0
        rear = -1
        count = 0
    End Sub

    Public Sub InsertFront(value As Integer)
        If count = size Then
            Throw New InvalidOperationException("Deque is full")
        End If

        front = (front - 1 + size) Mod size
        deque(front) = value
        count += 1
    End Sub

    Public Sub InsertRear(value As Integer)
        If count = size Then
            Throw New InvalidOperationException("Deque is full")
        End If

        rear = (rear + 1) Mod size
        deque(rear) = value
        count += 1
    End Sub

    Public Function RemoveFront() As Integer
        If count = 0 Then
            Throw New InvalidOperationException("Deque is empty")
        End If

        Dim value As Integer = deque(front)
        front = (front + 1) Mod size
        count -= 1
        Return value
    End Function

    Public Function RemoveRear() As Integer
        If count = 0 Then
            Throw New InvalidOperationException("Deque is empty")
        End If

        Dim value As Integer = deque(rear)
        rear = (rear - 1 + size) Mod size
        count -= 1
        Return value
    End Function

    Public Function GetDequeElements() As Integer()
        Dim elements(count - 1) As Integer
        For i As Integer = 0 To count - 1
            elements(i) = deque((front + i) Mod size)
        Next
        Return elements
    End Function
End Class
