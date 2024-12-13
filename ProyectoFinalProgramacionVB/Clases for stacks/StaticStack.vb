Public Class StaticStack
    Private elements() As Integer ' Arreglo para almacenar los elementos
    Private top As Integer ' Índice del elemento superior de la pila

    ' Constructor
    Public Sub New()
        elements = New Integer(7) {} ' Inicializa el arreglo con tamaño 8
        top = -1 ' Inicializa la pila como vacía
    End Sub

    ' Método para insertar un elemento en la pila
    Public Sub Push(dato As Integer)
        If IsFull() Then
            MessageBox.Show("La pila está llena.")
            Return
        End If
        top += 1
        elements(top) = dato
    End Sub

    ' Método para eliminar y retornar el elemento superior de la pila
    Public Function Pop() As String
        If IsEmpty() Then
            Return "La pila está vacía."
        End If
        Dim value As Integer = elements(top)
        top -= 1
        Return value.ToString()
    End Function

    ' Método para ver el elemento superior sin eliminarlo
    Public Function Peek() As String
        If IsEmpty() Then
            Return "La pila está vacía."
        End If
        Return elements(top).ToString()
    End Function

    ' Método para verificar si la pila está vacía
    Public Function IsEmpty() As Boolean
        Return top = -1
    End Function

    ' Método para verificar si la pila está llena
    Public Function IsFull() As Boolean
        Return top = elements.Length - 1
    End Function

    ' Método para obtener el tamaño actual de la pila
    Public Function Size() As Integer
        Return top + 1
    End Function
End Class
