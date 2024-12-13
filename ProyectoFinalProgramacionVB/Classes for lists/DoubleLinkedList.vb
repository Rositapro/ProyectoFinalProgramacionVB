Public Class DoubleLinkedList
    Private head As DoubleLinkedListNode ' Puntero al primer nodo de la lista.

    ' Constructor que inicializa la lista como vacía (head es Nothing).
    Public Sub New()
        head = Nothing
    End Sub

    ' Método para agregar un nodo manteniendo el orden numérico ascendente.
    Public Sub Add(data As Integer)
        Dim newDoubleLinkedListNode As New DoubleLinkedListNode(data)

        If head Is Nothing OrElse head.Data >= data Then ' Insertar al inicio si está vacía o el valor es menor.
            newDoubleLinkedListNode.Next = head
            If head IsNot Nothing Then head.Prev = newDoubleLinkedListNode
            head = newDoubleLinkedListNode
        Else
            Dim current As DoubleLinkedListNode = head
            While current.Next IsNot Nothing AndAlso current.Next.Data < data
                current = current.Next
            End While

            newDoubleLinkedListNode.Next = current.Next
            If current.Next IsNot Nothing Then current.Next.Prev = newDoubleLinkedListNode
            current.Next = newDoubleLinkedListNode
            newDoubleLinkedListNode.Prev = current
        End If
    End Sub

    ' Método para eliminar un nodo por su valor.
    Public Sub Delete(data As Integer)
        If head Is Nothing Then ' Si la lista está vacía, no hacer nada.
            Return
        End If

        Dim current As DoubleLinkedListNode = head

        ' Buscar el nodo con el valor especificado.
        While current IsNot Nothing AndAlso current.Data <> data
            current = current.Next
        End While

        If current Is Nothing Then ' Si no se encontró el valor, salir.
            Return
        End If

        ' Ajustar los punteros de los nodos adyacentes.
        If current.Prev IsNot Nothing Then
            current.Prev.Next = current.Next
        Else
            head = current.Next ' Si el nodo a eliminar es la cabeza, mover la cabeza.
        End If

        If current.Next IsNot Nothing Then
            current.Next.Prev = current.Prev
        End If
    End Sub

    ' Método para buscar un número en la lista.
    Public Function Search(data As Integer) As Boolean
        Dim current As DoubleLinkedListNode = head

        ' Recorrer la lista buscando el dato.
        While current IsNot Nothing
            If current.Data = data Then
                Return True
            End If
            current = current.Next
        End While
        Return False ' Retornar false si no se encontró el dato.
    End Function

    ' Método para obtener la cabeza de la lista.
    Public Function GetHead() As DoubleLinkedListNode
        Return head
    End Function
End Class
