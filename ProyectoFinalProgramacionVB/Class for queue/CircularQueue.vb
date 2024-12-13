Public Class CircularQueue
    Private queue() As Integer
    Private front As Integer
    Private rear As Integer
    Private count As Integer
    Private size As Integer

    ' Constructor
    Public Sub New(capacity As Integer)
        size = capacity
        ReDim queue(size - 1) ' Inicializa el arreglo con la capacidad dada
        front = 0
        rear = -1
        count = 0
    End Sub

    ' Método para agregar un elemento a la cola circular
    Public Sub Enqueue(element As Integer)
        If count = size Then
            Throw New InvalidOperationException("Queue is full")
        End If

        rear = (rear + 1) Mod size ' Mueve rear a la siguiente posición
        queue(rear) = element
        count += 1
    End Sub

    ' Método para eliminar un elemento de la cola circular
    Public Function Dequeue() As Integer
        If count = 0 Then
            Throw New InvalidOperationException("Queue is empty")
        End If

        Dim element As Integer = queue(front)
        front = (front + 1) Mod size ' Mueve front a la siguiente posición
        count -= 1
        Return element
    End Function

    ' Método para obtener los elementos actuales en la cola
    Public Function GetQueueElements() As Integer()
        Dim elements(count - 1) As Integer
        For i As Integer = 0 To count - 1
            elements(i) = queue((front + i) Mod size)
        Next
        Return elements
    End Function
End Class
