Public Class CircularsList
    Private head As CircularListsNode

    Public Sub New()
        head = Nothing
    End Sub

    Public Sub Add(value As Integer)
        Dim newNode As New CircularListsNode With {.value = value}

        If head Is Nothing Then
            head = newNode
            head.Next = head
        ElseIf value < head.Value Then
            Dim current As CircularListsNode = head
            Do While current.Next IsNot head
                current = current.Next
            Loop
            newNode.Next = head
            current.Next = newNode
            head = newNode
        Else
            Dim current As CircularListsNode = head
            Do While current.Next IsNot head AndAlso current.Next.Value < value
                current = current.Next
            Loop
            newNode.Next = current.Next
            current.Next = newNode
        End If
    End Sub

    Public Sub Remove(value As Integer)
        If head Is Nothing Then
            MessageBox.Show("The list is empty.")
            Return
        End If

        Dim current As CircularListsNode = head
        If head.Value = value Then
            If head.Next Is head Then
                head = Nothing
            Else
                Do While current.Next IsNot head
                    current = current.Next
                Loop
                head = head.Next
                current.Next = head
            End If
            MessageBox.Show("Node removed successfully.")
            Return
        End If

        Do While current.Next IsNot head
            If current.Next.Value = value Then
                current.Next = current.Next.Next
                MessageBox.Show("Node removed successfully.")
                Return
            End If
            current = current.Next
        Loop

        MessageBox.Show("Node not found.")
    End Sub

    Public Function Contains(value As Integer) As Boolean
        If head Is Nothing Then Return False

        Dim current As CircularListsNode = head
        Do
            If current.Value = value Then Return True
            current = current.Next
        Loop While current IsNot head

        Return False
    End Function

    Public Function Display() As String()
        If head Is Nothing Then
            MessageBox.Show("The list is empty.")
            Return New String() {}
        End If

        Dim result As New List(Of String)()
        Dim current As CircularListsNode = head

        Do
            result.Add(current.Value.ToString())
            current = current.Next
        Loop While current IsNot head

        Return result.ToArray()
    End Function

    Public Function Count() As Integer
        If head Is Nothing Then Return 0

        Dim contar As Integer = 1
        Dim current As CircularListsNode = head
        Do While current.Next IsNot head
            contar += 1
            current = current.Next
        Loop
        Return contar
    End Function
End Class
