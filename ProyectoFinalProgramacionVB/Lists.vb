Public Class Lists
    Private singlelist As New LinkedList()
    Private circularlist As New CircularsList()
    Private doublelist As New DoubleLinkedList()
    Private dcll As New DoubleCircularList()
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim linearStructuresForm As New LinearStructuresForm()
        linearStructuresForm.Show()
        Me.Close()
    End Sub

    Private Sub btnAddSingleList_Click(sender As Object, e As EventArgs) Handles btnAddSingleList.Click
        If singlelist.Contains(Integer.Parse(txtValue.Text)) Then
            MessageBox.Show("Value already exists in the linked list")
            Return
        End If

        Dim singlelistnode As New SingleListNode(Integer.Parse(txtValue.Text), txtName.Text, txtPhoneNumber.Text, txtZipCode.Text)
        singlelist.Add(singlelistnode)
        MessageBox.Show(singlelist.ToString())
    End Sub

    Private Sub btnContainsSingleList_Click(sender As Object, e As EventArgs) Handles btnContainsSingleList.Click
        If singlelist.Contains(Integer.Parse(txtValue.Text)) Then
            MessageBox.Show("Value exists in the linked list")
        Else
            MessageBox.Show("Value does not exist in the linked list")
        End If
    End Sub

    Private Sub btnRemoveSingleList_Click(sender As Object, e As EventArgs) Handles btnRemoveSingleList.Click
        If singlelist.Contains(Integer.Parse(txtValue.Text)) Then
            singlelist.Remove(Integer.Parse(txtValue.Text))
            MessageBox.Show(singlelist.ToString())
        Else
            MessageBox.Show("Value does not exist in the linked list")
        End If
    End Sub

    Private Sub btnCountSingleList_Click(sender As Object, e As EventArgs) Handles btnCountSingleList.Click
        MessageBox.Show("The linked list contains " & singlelist.Count & " node(s)")
    End Sub
    Private Sub UpdateListNodes()
        lstNodes.Items.Clear()
        Dim nodes = circularlist.Display()
        For Each node In nodes
            lstNodes.Items.Add(node)
        Next
    End Sub
    Private Sub btnAddCircularsLists_Click(sender As Object, e As EventArgs) Handles btnAddCircularsLists.Click
        Dim value As Integer
        If Integer.TryParse(txtValueCircularList.Text, value) Then
            circularlist.Add(value)
            MessageBox.Show("Node added successfully!")
            txtValueCircularList.Clear()
            UpdateListNodes()
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub btnRemoveCircularsLists_Click(sender As Object, e As EventArgs) Handles btnRemoveCircularsLists.Click
        Dim value As Integer
        If Integer.TryParse(txtValueCircularList.Text, value) Then
            circularlist.Remove(value)
            txtValueCircularList.Clear()
            UpdateListNodes()
        Else
            MessageBox.Show("Please enter a valid integer.")
        End If
    End Sub

    Private Sub btnContainsCircularsLists_Click(sender As Object, e As EventArgs) Handles btnContainsCircularsLists.Click
        If txtValueCircularList.Text = "" Then
            MessageBox.Show("Enter a valid value")
        ElseIf circularlist.Contains(Integer.Parse(txtValueCircularList.Text)) Then
            MessageBox.Show("Value exists in the linked list")
        Else
            MessageBox.Show("Value does not exist in the linked list")
        End If
    End Sub

    Private Sub btnCountCircularsLists_Click(sender As Object, e As EventArgs) Handles btnCountCircularsLists.Click
        MessageBox.Show("The linked list contains " & circularlist.Count() & " node(s)")

    End Sub

    Private Sub btnAggDoubleList_Click(sender As Object, e As EventArgs) Handles btnAggDoubleList.Click
        Dim value As Integer
        If Integer.TryParse(txtDataDoubleList.Text, value) Then
            doublelist.Add(value)
            UpdateDoubleLinkedListView()
            MessageBox.Show($"Se agregó {value} a la lista.")
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtDataDoubleList.Clear()
    End Sub

    Private Sub btnDeleteDoubleList_Click(sender As Object, e As EventArgs) Handles btnDeleteDoubleList.Click
        Dim value As Integer
        If Integer.TryParse(txtDataDoubleList.Text, value) Then
            doublelist.Delete(value)
            UpdateDoubleLinkedListView()
            MessageBox.Show($"Se eliminó {value} de la lista (si existía).")
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtDataDoubleList.Clear()
    End Sub

    Private Sub btnSearchDoubleList_Click(sender As Object, e As EventArgs) Handles btnSearchDoubleList.Click
        Dim value As Integer
        If Integer.TryParse(txtDataDoubleList.Text, value) Then
            Dim found As Boolean = doublelist.Search(value)
            If found Then
                MessageBox.Show($"El número {value} se encuentra en la lista.")
            Else
                MessageBox.Show($"El número {value} no se encuentra en la lista.")
            End If
        Else
            MessageBox.Show("Por favor, ingrese un valor numérico válido.")
        End If
        txtDataDoubleList.Clear()
    End Sub

    Private Sub UpdateDoubleLinkedListView()
        lvDisplayDoubleList.Items.Clear()
        Dim current As DoubleLinkedListNode = doublelist.GetHead()
        Dim position As Integer = 1

        While current IsNot Nothing
            Dim item As New ListViewItem(position.ToString())
            item.SubItems.Add(current.Data.ToString())
            lvDisplayDoubleList.Items.Add(item)
            current = current.Next
            position += 1
        End While
    End Sub

    Private Sub btnAddDoubleCircularList_Click(sender As Object, e As EventArgs) Handles btnAddDoubleCircularList.Click
        'If dcll.Contains(Integer.Parse(txtNumberDoubleCircularList.Text)) Then
        '    MessageBox.Show("The value already exists.")
        '    Return
        'End If

        'Dim node As New DoubleCircularListNode(Integer.Parse(txtNumberDoubleCircularList.Text))
        'dcll.Add(node)
        'MessageBox.Show(dcll.ToString())
    End Sub

    Private Sub btnRemoveDoubleCircularList_Click(sender As Object, e As EventArgs) Handles btnRemoveDoubleCircularList.Click
        If dcll.Contains(Integer.Parse(txtNumberDoubleCircularList.Text)) Then
            dcll.Remove(Integer.Parse(txtNumberDoubleCircularList.Text))
            MessageBox.Show(dcll.ToString())
        Else
            MessageBox.Show("Value " & txtNumberDoubleCircularList.Text & " does not exist in the doubly circular linked list")
        End If
    End Sub

    Private Sub btnContainsDoubleCircularList_Click(sender As Object, e As EventArgs) Handles btnContainsDoubleCircularList.Click
        If dcll.Contains(Integer.Parse(txtNumberDoubleCircularList.Text)) Then
            MessageBox.Show("Value " & txtNumberDoubleCircularList.Text & " exists in the doubly circular linked list")
        Else
            MessageBox.Show("Value " & txtNumberDoubleCircularList.Text & " does not exist in the doubly circular linked list")
        End If
    End Sub

End Class