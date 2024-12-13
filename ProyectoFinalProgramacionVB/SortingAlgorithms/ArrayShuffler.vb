Public Class ArrayShuffler
    Private Shared rand As New Random()

    ' Método para mezclar un arreglo
    Public Shared Sub Shuffle(ByVal array() As Integer)
        For i As Integer = array.Length - 1 To 1 Step -1
            Dim j As Integer = rand.Next(i + 1)
            Dim temp As Integer = array(i)
            array(i) = array(j)
            array(j) = temp
        Next
    End Sub
End Class
