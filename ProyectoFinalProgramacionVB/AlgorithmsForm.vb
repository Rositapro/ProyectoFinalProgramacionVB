Public Class AlgorithmsForm

    Private Sub btnSorting_Click(sender As Object, e As EventArgs) Handles btnSorting.Click
        Dim sortingForm = New SortingAlgorithmsForm()
        sortingForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchForm = New SearchAlgorithmsForm()
        searchForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainForm = New Form1()
        mainForm.Show()
        Me.Close()
    End Sub
End Class