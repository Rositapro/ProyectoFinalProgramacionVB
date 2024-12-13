Public Class Quicksort
    Private UpdateListBoxAction As Action(Of Integer())

    Public Sub New(updateListBoxAction As Action(Of Integer()))
        Me.UpdateListBoxAction = updateListBoxAction
    End Sub

    Public Async Function QuicksortAsync(arr As Integer(), low As Integer, high As Integer) As Task
        If low < high Then
            Dim pivotIndex = Await PartitionAsync(arr, low, high)
            Await QuicksortAsync(arr, low, pivotIndex - 1)
            Await QuicksortAsync(arr, pivotIndex + 1, high)
        End If
    End Function

    Private Async Function PartitionAsync(arr As Integer(), low As Integer, high As Integer) As Task(Of Integer)
        Dim pivot = arr(high)
        Dim i = low - 1

        For j = low To high - 1
            If arr(j) <= pivot Then
                i += 1
                Swap(arr, i, j)
                UpdateListBoxAction?.Invoke(arr)
                Await Task.Delay(500)
            End If
        Next

        Swap(arr, i + 1, high)
        UpdateListBoxAction?.Invoke(arr)
        Await Task.Delay(500)

        Return i + 1
    End Function

    Private Sub Swap(arr As Integer(), i As Integer, j As Integer)
        Dim temp = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub
End Class
