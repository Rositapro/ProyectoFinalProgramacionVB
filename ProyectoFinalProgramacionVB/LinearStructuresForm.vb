Public Class LinearStructuresForm
    Private Sub btnLists_Click(sender As Object, e As EventArgs) Handles btnLists.Click
        Dim lists = New Lists()
        lists.Show()
        Me.Hide()
    End Sub

    Private Sub btnStacks_Click(sender As Object, e As EventArgs) Handles btnStacks.Click
        Dim stacks = New Stacks()
        stacks.Show()
        Me.Hide()
    End Sub

    Private Sub btnQueues_Click(sender As Object, e As EventArgs) Handles btnQueues.Click
        Dim qeues = New Queues()
        Queues.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dataStructuresForm = New DataStructuresForm()
        dataStructuresForm.Show()
        Me.Close()

    End Sub
End Class