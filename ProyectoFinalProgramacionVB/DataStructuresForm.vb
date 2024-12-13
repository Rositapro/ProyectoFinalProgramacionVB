Public Class DataStructuresForm
    Private Sub btnLinear_Click(sender As Object, e As EventArgs) Handles btnLinear.Click
        Dim linearForm = New LinearStructuresForm()
        linearForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnNonLinear_Click(sender As Object, e As EventArgs) Handles btnNonLinear.Click
        Dim nonLinearForm = New NonLinearStructuresForm()
        nonLinearForm.Show()
        Me.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainForm As New Form1()
        mainForm.Show()
        Me.Close()
    End Sub
End Class