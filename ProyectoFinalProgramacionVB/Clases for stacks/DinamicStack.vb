Public Class DinamicStack
    Private top As NodeStacks

    ' Constructor
    Public Sub New()
        top = Nothing ' Inicializa top como Nothing
    End Sub

    ' Método para agregar un nodo (Push)
    Public Sub Push(newNode As NodeStacks)
        If IsEmpty() Then
            top = newNode
            Return
        End If

        newNode.Next = top
        top = newNode
    End Sub

    ' Método para remover y retornar el nodo superior (Pop)
    Public Function Pop() As NodeStacks
        If Not IsEmpty() Then
            Dim current As NodeStacks = top
            top = top.Next
            current.Next = Nothing
            Return current
        End If
        Return Nothing
    End Function

    ' Método para ver el nodo superior sin eliminarlo (Peek)
    Public Function Peek() As NodeStacks
        If IsEmpty() Then
            Return Nothing
        End If
        Return top
    End Function

    ' Método para verificar si la pila está vacía
    Public Function IsEmpty() As Boolean
        Return top Is Nothing
    End Function

    ' Método para contar el número de elementos en la pila
    Public Function Size() As Integer
        Dim count As Integer = 0
        Dim current As NodeStacks = top

        While current IsNot Nothing
            count += 1
            current = current.Next
        End While

        Return count
    End Function
End Class
