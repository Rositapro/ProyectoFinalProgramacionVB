Public Class Selectionsort
    Private UpdateListBoxAction As Action(Of Integer())

    Public Sub New(ByVal updateListBoxAction As Action(Of Integer()))
        Me.UpdateListBoxAction = updateListBoxAction
    End Sub

    Public Async Function SelectionSortAsync(ByVal array() As Integer) As Task
        Dim n As Integer = array.Length

        For i As Integer = 0 To n - 2
            ' Encuentra el índice del elemento mínimo en el subarreglo no ordenado
            Dim minIndex As Integer = i
            For j As Integer = i + 1 To n - 1
                If array(j) < array(minIndex) Then
                    minIndex = j
                End If
            Next

            ' Intercambia el elemento mínimo con el primer elemento no ordenado
            Dim temp As Integer = array(minIndex)
            array(minIndex) = array(i)
            array(i) = temp

            ' Pausa para visualizar el cambio y actualizar el ListBox
            Await Task.Delay(500)
            UpdateListBoxAction?.Invoke(array)
        Next
    End Function
End Class
