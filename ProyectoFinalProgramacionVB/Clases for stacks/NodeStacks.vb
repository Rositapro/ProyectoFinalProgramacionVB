Public Class NodeStacks
    ' Propiedad para almacenar el dato
    Public Property Data As Integer

    ' Propiedad para apuntar al siguiente nodo
    Public Property [Next] As NodeStacks

    ' Constructor sin parámetros
    Public Sub New()
        Data = 0
        [Next] = Nothing ' El siguiente nodo inicialmente es Nothing
    End Sub

    ' Constructor con un parámetro
    Public Sub New(data As Integer)
        Me.Data = data
        [Next] = Nothing ' El siguiente nodo inicialmente es Nothing
    End Sub

    ' Método ToString para representar los datos del nodo
    Public Overrides Function ToString() As String
        Return Data.ToString()
    End Function
End Class
