Public Class BinariTreeNode
    Public Property Valor As Integer
    Public Property Izquierda As BinariTreeNode
    Public Property Derecha As BinariTreeNode

    Public Sub New(valor As Integer)
        Me.Valor = valor
        Izquierda = Nothing
        Derecha = Nothing
    End Sub
End Class
