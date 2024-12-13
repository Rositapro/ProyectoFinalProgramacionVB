Public Class LinkedList
    Private head As SingleListNode

    ' Constructor que inicializa la lista como vacía (head es Nothing).
    Public Sub New()
        head = Nothing
    End Sub

    ' Método para agregar un nodo manteniendo el orden ascendente.
    Public Sub Add(newNode As SingleListNode)
        If head Is Nothing Then
            head = newNode
            Return
        End If

        If newNode.Value < head.Value Then
            newNode.Next = head
            head = newNode
            Return
        End If

        Dim current As SingleListNode = head
        While current.Next IsNot Nothing AndAlso current.Next.Value < newNode.Value
            current = current.Next
        End While

        newNode.Next = current.Next
        current.Next = newNode
    End Sub

    ' Método para eliminar un nodo por su valor.
    Public Sub Remove(value As Integer)
        If head Is Nothing Then
            Return
        End If

        If head.Value = value Then
            head = head.Next
            Return
        End If

        Dim current As SingleListNode = head
        While current.Next IsNot Nothing
            If current.Next.Value = value Then
                current.Next = current.Next.Next
                Return
            End If
            current = current.Next
        End While
    End Sub

    ' Método para verificar si un valor existe en la lista.
    Public Function Contains(value As Integer) As Boolean
        Dim current As SingleListNode = head
        While current IsNot Nothing
            If current.Value = value Then
                Return True
            End If
            current = current.Next
        End While
        Return False
    End Function

    ' Método para contar el número de nodos en la lista.
    Public Function Count() As Integer
        Dim contar As Integer = 0
        Dim current As SingleListNode = head
        While current IsNot Nothing
            contar += 1
            current = current.Next
        End While
        Return contar
    End Function

    ' Método para representar la lista como una cadena.
    Public Overrides Function ToString() As String
        Dim result As String = ""
        Dim current As SingleListNode = head
        While current IsNot Nothing
            result &= current.ToString() & " "
            current = current.Next
        End While
        Return result
    End Function
End Class
