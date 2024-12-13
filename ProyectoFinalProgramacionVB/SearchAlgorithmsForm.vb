Public Class SearchAlgorithmsForm
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim algorithmsForm = New AlgorithmsForm()
        algorithmsForm.Show()
        Me.Close()
    End Sub
End Class