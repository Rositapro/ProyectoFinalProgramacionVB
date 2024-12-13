Public Class Edge
    Public Property ToNode As NodeGraph
    Public Property Weight As Integer

    Public Sub New(toNode As NodeGraph, weight As Integer)
        Me.ToNode = toNode
        Me.Weight = weight
    End Sub

    Public Sub New(toNode As NodeGraph)
        Me.ToNode = toNode
    End Sub
End Class
