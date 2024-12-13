Public Class Form1
    Private Sub btnDataStructures_Click(sender As Object, e As EventArgs) Handles btnDataStructures.Click
        Dim dataStructuresForm = New DataStructuresForm()
        dataStructuresForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAlgorithms_Click(sender As Object, e As EventArgs) Handles btnAlgorithms.Click
        Dim algorithmsForm = New AlgorithmsForm()
        algorithmsForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
