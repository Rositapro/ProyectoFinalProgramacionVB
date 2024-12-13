Public Class Organization
    Public Event OnSwap As Action(Of Integer())

    Private swapped As Boolean

    Public Sub BubbleSort(ByVal array As Integer())
        Dim size As Integer = array.Length

        ' Bucle externo para las pasadas sobre el arreglo
        For quantity As Integer = 0 To size - 2
            swapped = False
            ' Bucle interno para comparar e intercambiar elementos adyacentes
            For current As Integer = 0 To size - quantity - 2
                ' If (array(current) < array(current + 1)) 
                If array(current) > array(current + 1) Then
                    ' Intercambiar elementos
                    Dim temporal As Integer = array(current)
                    array(current) = array(current + 1)
                    array(current + 1) = temporal
                    swapped = True
                    RaiseEvent OnSwap(array)
                End If
            Next
            If Not swapped Then
                Exit For
            End If
        Next
    End Sub

    Public Sub Cocktail_Sort(ByVal array As Integer())
        Dim [end] As Integer = array.Length - 1
        swapped = True

        ' Bucle externo que sigue ejecutándose mientras se hagan intercambios
        For start As Integer = 0 To [end] AndAlso swapped
            [end] -= 1
            swapped = False

            ' Bucle para la pasada de izquierda a derecha
            For current As Integer = start To [end] - 1
                ' If (array(current) < array(current + 1))
                If array(current) > array(current + 1) Then
                    Dim temporal As Integer = array(current)
                    array(current) = array(current + 1)
                    array(current + 1) = temporal
                    swapped = True
                    RaiseEvent OnSwap(array) ' Llamada al evento después de cada intercambio
                End If
            Next

            ' Si no hubo intercambios en la pasada, el arreglo ya está ordenado
            If Not swapped Then
                Exit For
            End If

            swapped = False

            ' Bucle para la pasada de derecha a izquierda
            For i As Integer = [end] - 1 To start Step -1
                ' If (array(i) < array(i + 1))
                If array(i) > array(i + 1) Then
                    Dim temporal As Integer = array(i)
                    array(i) = array(i + 1)
                    array(i + 1) = temporal
                    swapped = True
                    RaiseEvent OnSwap(array) ' Llamada al evento después de cada intercambio
                End If
            Next
        Next
    End Sub

    Public Sub Insertionsort(ByVal array As Integer())
        Dim largo As Integer = array.Length

        For i As Integer = 1 To largo - 1
            Dim elemento As Integer = array(i)
            Dim j As Integer = i - 1

            ' Mover elementos mayores a una posición adelante
            ' array(j) < elemento
            While j >= 0 AndAlso array(j) > elemento
                array(j + 1) = array(j)
                j -= 1
                RaiseEvent OnSwap(array)
            End While
            array(j + 1) = elemento
            RaiseEvent OnSwap(array)
        Next
    End Sub

    Public Function DesordenarArreglo(ByVal array As Integer()) As Integer()
        Dim random As New Random()

        For i As Integer = 0 To array.Length - 1
            Dim j As Integer = random.Next(i, array.Length) ' Índice aleatorio desde i hasta el final
            ' Intercambiar elementos en las posiciones i y j
            Dim temp As Integer = array(i)
            array(i) = array(j)
            array(j) = temp
        Next

        Return array
    End Function
End Class
