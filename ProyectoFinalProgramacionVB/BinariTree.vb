Public Class BinariTree
    Private raiz As BinariTreeNode = Nothing
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim nonLinearStructuresForm = New NonLinearStructuresForm()
        nonLinearStructuresForm.Show()
        Me.Close()
    End Sub

    ' Método para agregar un nodo
    Private Sub AgregarNodo(valor As Integer)
        raiz = AgregarNodoRecursivo(raiz, valor)
        pnlArbol.Invalidate() ' Redibuja el panel
    End Sub
    Private Function AgregarNodoRecursivo(raiz As BinariTreeNode, valor As Integer) As BinariTreeNode
        If raiz Is Nothing Then
            Return New BinariTreeNode(valor)
        End If

        If valor < raiz.Valor Then
            raiz.Izquierda = AgregarNodoRecursivo(raiz.Izquierda, valor)
        ElseIf valor > raiz.Valor Then
            raiz.Derecha = AgregarNodoRecursivo(raiz.Derecha, valor)
        End If

        Return raiz
    End Function

    ' Métodos de recorrido
    Private Sub RecorridoInorden(raiz As BinariTreeNode, ByRef resultado As String)
        If raiz IsNot Nothing Then
            RecorridoInorden(raiz.Izquierda, resultado)
            resultado &= raiz.Valor & " "
            RecorridoInorden(raiz.Derecha, resultado)
        End If
    End Sub

    Private Sub RecorridoPreorden(raiz As BinariTreeNode, ByRef resultado As String)
        If raiz IsNot Nothing Then
            resultado &= raiz.Valor & " "
            RecorridoPreorden(raiz.Izquierda, resultado)
            RecorridoPreorden(raiz.Derecha, resultado)
        End If
    End Sub

    Private Sub RecorridoPostorden(raiz As BinariTreeNode, ByRef resultado As String)
        If raiz IsNot Nothing Then
            RecorridoPostorden(raiz.Izquierda, resultado)
            RecorridoPostorden(raiz.Derecha, resultado)
            resultado &= raiz.Valor & " "
        End If
    End Sub

    ' Evento Paint para dibujar el árbol
    Private Sub pnlArbol_Paint(sender As Object, e As PaintEventArgs) Handles pnlArbol.Paint
        If raiz IsNot Nothing Then
            Dim panelWidth As Integer = pnlArbol.Width
            Dim startX As Integer = panelWidth / 2
            Dim startY As Integer = 30
            Dim espacio As Integer = panelWidth / 4

            DibujarArbol(e.Graphics, raiz, startX, startY, espacio)
        End If
    End Sub

    Private Sub DibujarArbol(g As Graphics, nodo As BinariTreeNode, x As Integer, y As Integer, espacio As Integer)
        If nodo Is Nothing Then Return

        ' Dibuja el nodo
        g.FillEllipse(Brushes.LightBlue, x - 20, y - 20, 40, 40)
        g.DrawEllipse(Pens.Black, x - 20, y - 20, 40, 40)
        g.DrawString(nodo.Valor.ToString(), Me.Font, Brushes.Black, x - 10, y - 10)

        ' Dibuja las líneas hacia los hijos
        If nodo.Izquierda IsNot Nothing Then
            g.DrawLine(Pens.Black, x, y, x - espacio, y + 60)
            DibujarArbol(g, nodo.Izquierda, x - espacio, y + 60, espacio / 2)
        End If
        If nodo.Derecha IsNot Nothing Then
            g.DrawLine(Pens.Black, x, y, x + espacio, y + 60)
            DibujarArbol(g, nodo.Derecha, x + espacio, y + 60, espacio / 2)
        End If
    End Sub

    Private Sub btnAgregarBinariTreeNode_Click(sender As Object, e As EventArgs) Handles btnAgregarBinariTreeNode.Click
        Dim valor As Integer
        If Integer.TryParse(txtValorNodo.Text, valor) Then
            AgregarNodo(valor)
            txtValorNodo.Clear()
            MessageBox.Show($"Nodo con valor {valor} agregado.")
        Else
            MessageBox.Show("Por favor ingrese un número válido.")
        End If
    End Sub

    Private Sub btnInorden_Click(sender As Object, e As EventArgs) Handles btnInorden.Click
        Dim resultado As String = ""
        RecorridoInorden(raiz, resultado)
        MessageBox.Show("Inorden: " & resultado, "Recorrido Inorden")
    End Sub

    Private Sub btnPreorden_Click(sender As Object, e As EventArgs) Handles btnPreorden.Click
        Dim resultado As String = ""
        RecorridoPreorden(raiz, resultado)
        MessageBox.Show("Preorden: " & resultado, "Recorrido Preorden")
    End Sub

    Private Sub btnPostorden_Click(sender As Object, e As EventArgs) Handles btnPostorden.Click
        Dim resultado As String = ""
        RecorridoPostorden(raiz, resultado)
        MessageBox.Show("Postorden: " & resultado, "Recorrido Postorden")
    End Sub
End Class

