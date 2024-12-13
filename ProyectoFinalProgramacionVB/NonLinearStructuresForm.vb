Imports Windows.Win32

Public Class NonLinearStructuresForm
    Private Sub btnBinariTree_Click(sender As Object, e As EventArgs) Handles btnBinariTree.Click
        Dim tree = New BinariTree()
        tree.Show()
        Me.Hide()
    End Sub

    Private Sub btnGraphs_Click(sender As Object, e As EventArgs) Handles btnGraphs.Click
        Dim graphs = New Graphs()
        graphs.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dataStructuresForm = New DataStructuresForm()
        dataStructuresForm.Show()
        Me.Close()
    End Sub
End Class