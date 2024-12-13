Public Class Heapsort
    Private UpdateListBoxAction As Action(Of Integer())

    Public Sub New(updateListBoxAction As Action(Of Integer()))
        Me.UpdateListBoxAction = updateListBoxAction
    End Sub

    Public Async Function HeapsortAsync(array As Integer()) As Task
        Dim n = array.Length

        For i = n \ 2 - 1 To 0 Step -1
            Await HeapifyAsync(array, n, i)
        Next

        For i = n - 1 To 0 Step -1
            Dim temp = array(0)
            array(0) = array(i)
            array(i) = temp

            UpdateListBoxAction?.Invoke(array)
            Await Task.Delay(500)

            Await HeapifyAsync(array, i, 0)
        Next
    End Function

    Private Async Function HeapifyAsync(array As Integer(), n As Integer, i As Integer) As Task
        Dim largest = i
        Dim left = 2 * i + 1
        Dim right = 2 * i + 2

        If left < n AndAlso array(left) > array(largest) Then largest = left
        If right < n AndAlso array(right) > array(largest) Then largest = right

        If largest <> i Then
            Dim swap = array(i)
            array(i) = array(largest)
            array(largest) = swap

            UpdateListBoxAction?.Invoke(array)
            Await Task.Delay(500)

            Await HeapifyAsync(array, n, largest)
        End If
    End Function
End Class
