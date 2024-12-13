Public Class Queues
    Private ReadOnly simpleVectorQueue As New SimpleVectorQueue(5)
    Private ReadOnly simpleQueueList As New SimpleQueueList()
    Private ReadOnly circularQueue As New CircularQueue(5)
    Private ReadOnly doubleQueueVector As New DoubleQueueVector(5)
    Private ReadOnly doubleQueueList As New DoubleQueueList()
    Private ReadOnly priorityQueueVectors As New PriorityQueueVectors(5)
    Private ReadOnly priorityQueueVectorLists As New PriorityQueueVectorLists(5)
    Private ReadOnly priorityQueueListVectors As New PriorityQueueListVectors(5)
    Private ReadOnly priorityQueueLists As New PriorityQueueLists(5)
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim linearStructuresForm As New LinearStructuresForm()
        linearStructuresForm.Show()
        Me.Close()
    End Sub

    Private Sub btnEnqueueSimpleQueueVector_Click(sender As Object, e As EventArgs) Handles btnEnqueueSimpleQueueVector.Click
        Try
            Dim element As Integer = Integer.Parse(txtElementSimpleQueueVector.Text)
            simpleVectorQueue.Enqueue(element)
            UpdateSimpleQueueVectorDisplay()
            txtElementSimpleQueueVector.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeueSimpleQueueVector_Click(sender As Object, e As EventArgs) Handles btnDequeueSimpleQueueVector.Click
        Try
            Dim element As Integer = simpleVectorQueue.Dequeue()
            MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateSimpleQueueVectorDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateSimpleQueueVectorDisplay()
        lstSimpleQueueVector.Items.Clear()
        For Each item In simpleVectorQueue.GetQueueElements()
            lstSimpleQueueVector.Items.Add(item)
        Next
    End Sub
    Private Sub btnShowSingleQueueVector_Click(sender As Object, e As EventArgs) Handles btnShowSingleQueueVector.Click
        Try
            Dim elements() As Integer = simpleVectorQueue.GetQueueElements()
            If elements.Length = 0 Then
                MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim elementsString As String = String.Join(", ", elements)
                MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnqueueSimpleQueueList_Click(sender As Object, e As EventArgs) Handles btnEnqueueSimpleQueueList.Click
        Try
            Dim element As Integer = Integer.Parse(txtElementSimpleQueueList.Text)
            simpleQueueList.Enqueue(element)
            UpdateSimpleQueueListDisplay()
            txtElementSimpleQueueList.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeueSimpleQueueList_Click(sender As Object, e As EventArgs) Handles btnDequeueSimpleQueueList.Click
        Try
            Dim element As Integer = simpleQueueList.Dequeue()
            MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateSimpleQueueListDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateSimpleQueueListDisplay()
        lstSimpleQueueList.Items.Clear()
        For Each item In simpleQueueList.GetQueueElements()
            lstSimpleQueueList.Items.Add(item)
        Next
    End Sub
    Private Sub btnShowSimpleQueueList_Click(sender As Object, e As EventArgs) Handles btnShowSimpleQueueList.Click
        Try
            Dim elements = simpleQueueList.GetQueueElements()
            If Not elements.Any() Then
                MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim elementsString As String = String.Join(", ", elements)
                MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnqueueCircularQueue_Click(sender As Object, e As EventArgs) Handles btnEnqueueCircularQueue.Click
        Try
            Dim element As Integer = Integer.Parse(txtElementCircularQueue.Text)
            circularQueue.Enqueue(element)
            UpdateCircularQueueDisplay()
            txtElementCircularQueue.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeueCircularQueue_Click(sender As Object, e As EventArgs) Handles btnDequeueCircularQueue.Click
        Try
            Dim element As Integer = circularQueue.Dequeue()
            MessageBox.Show($"Dequeued element: {element}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateCircularQueueDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowElementsCircularQueue_Click(sender As Object, e As EventArgs) Handles btnShowElementsCircularQueue.Click
        Try
            Dim elements() As Integer = circularQueue.GetQueueElements()
            If elements.Length = 0 Then
                MessageBox.Show("The queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim elementsString As String = String.Join(", ", elements)
                MessageBox.Show($"Queue Elements: {elementsString}", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateCircularQueueDisplay()
        lstCircularQueue.Items.Clear()
        For Each item In circularQueue.GetQueueElements()
            lstCircularQueue.Items.Add(item)
        Next
    End Sub
    Private Sub btnInsertFrontDoubleQueueVector_Click(sender As Object, e As EventArgs) Handles btnInsertFrontDoubleQueueVector.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementDoubleQueueVector.Text)
            doubleQueueVector.InsertFront(value)
            UpdateDoubleDequeueVectorDisplay()
            txtElementDoubleQueueVector.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveFrontDoubleQueueVector_Click(sender As Object, e As EventArgs) Handles btnRemoveFrontDoubleQueueVector.Click
        Try
            Dim value As Integer = doubleQueueVector.RemoveFront()
            MessageBox.Show($"Removed from front: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDoubleDequeueVectorDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsertRearDoubleQueueVector_Click(sender As Object, e As EventArgs) Handles btnInsertRearDoubleQueueVector.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementDoubleQueueVector.Text)
            doubleQueueVector.InsertRear(value)
            UpdateDoubleDequeueVectorDisplay()
            txtElementDoubleQueueVector.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveRearDoubleQueueVector_Click(sender As Object, e As EventArgs) Handles btnRemoveRearDoubleQueueVector.Click
        Try
            Dim value As Integer = doubleQueueVector.RemoveRear()
            MessageBox.Show($"Removed from rear: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDoubleDequeueVectorDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowDoubleQueueVector_Click(sender As Object, e As EventArgs) Handles btnShowDoubleQueueVector.Click
        Try
            Dim elements = doubleQueueVector.GetDequeElements()
            If Not elements.Any() Then
                MessageBox.Show("Deque is empty.", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim elementsString As String = String.Join(", ", elements)
                MessageBox.Show($"Deque Elements: {elementsString}", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateDoubleDequeueVectorDisplay()
        lstDoubleQueueVector.Items.Clear()
        For Each item In doubleQueueVector.GetDequeElements()
            lstDoubleQueueVector.Items.Add(item)
        Next
    End Sub
    Private Sub btnInsertFrontDoubleQueueList_Click(sender As Object, e As EventArgs) Handles btnInsertFrontDoubleQueueList.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementDoubleQueueList.Text)
            doubleQueueList.InsertFront(value)
            UpdateDoubleQueueListDisplay()
            txtElementDoubleQueueList.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveFrontDoubleQueueList_Click(sender As Object, e As EventArgs) Handles btnRemoveFrontDoubleQueueList.Click
        Try
            Dim value As Integer = doubleQueueList.RemoveFront()
            MessageBox.Show($"Removed from front: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDoubleQueueListDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsertRearDoubleQueueList_Click(sender As Object, e As EventArgs) Handles btnInsertRearDoubleQueueList.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementDoubleQueueList.Text)
            doubleQueueList.InsertRear(value)
            UpdateDoubleQueueListDisplay()
            txtElementDoubleQueueList.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveRearDoubleQueueList_Click(sender As Object, e As EventArgs) Handles btnRemoveRearDoubleQueueList.Click
        Try
            Dim value As Integer = doubleQueueList.RemoveRear()
            MessageBox.Show($"Removed from rear: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateDoubleQueueListDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowDoubleQueueList_Click(sender As Object, e As EventArgs) Handles btnShowDoubleQueueList.Click
        Try
            Dim elements = doubleQueueList.GetDequeElements()
            If Not elements.Any() Then
                MessageBox.Show("Deque is empty.", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim elementsString As String = String.Join(", ", elements)
                MessageBox.Show($"Deque Elements: {elementsString}", "Deque Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateDoubleQueueListDisplay()
        lstDoubleQueueList.Items.Clear()
        For Each item In doubleQueueList.GetDequeElements()
            lstDoubleQueueList.Items.Add(item)
        Next
    End Sub
    Private Sub btnEnqueuePriorityQueueVV_Click(sender As Object, e As EventArgs) Handles btnEnqueuePriorityQueueVV.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementPriorityQueueVV.Text)
            Dim priority As Integer = Integer.Parse(txtPriorityPriorityQueueVV.Text)
            priorityQueueVectors.Enqueue(value, priority)
            UpdatePriorityQueueVVDisplay()
            txtElementPriorityQueueVV.Clear()
            txtPriorityPriorityQueueVV.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeuePriorityQueueVV_Click(sender As Object, e As EventArgs) Handles btnDequeuePriorityQueueVV.Click
        Try
            Dim value As Integer = priorityQueueVectors.Dequeue()
            MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdatePriorityQueueVVDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowPriorityQueueVV_Click(sender As Object, e As EventArgs) Handles btnShowPriorityQueueVV.Click
        Try
            Dim queueElements = priorityQueueVectors.GetQueueElements()
            lstPriorityQueueVV.Items.Clear()
            For i As Integer = 0 To queueElements.Length - 1
                If queueElements(i).Count > 0 Then
                    Dim priorityElements As String = $"Priority {i}: {String.Join(", ", queueElements(i))}"
                    lstPriorityQueueVV.Items.Add(priorityElements)
                End If
            Next

            If lstPriorityQueueVV.Items.Count = 0 Then
                MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdatePriorityQueueVVDisplay()
        lstPriorityQueueVV.Items.Clear()
        Dim queueElements = priorityQueueVectors.GetQueueElements()

        For i As Integer = 0 To queueElements.Length - 1
            If queueElements(i).Count > 0 Then
                Dim priorityElements As String = $"Priority {i}: {String.Join(", ", queueElements(i))}"
                lstPriorityQueueVV.Items.Add(priorityElements)
            End If
        Next
    End Sub
    Private Sub btnEnqueuePriorityQueueVL_Click(sender As Object, e As EventArgs) Handles btnEnqueuePriorityQueueVL.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementPriorityQueueVL.Text)
            Dim priority As Integer = Integer.Parse(txtPriorityPriorityQueueVL.Text)
            priorityQueueVectorLists.Enqueue(value, priority)
            UpdateQueueDisplay()
            txtElementPriorityQueueVL.Clear()
            txtPriorityPriorityQueueVL.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeuePriorityQueueVL_Click(sender As Object, e As EventArgs) Handles btnDequeuePriorityQueueVL.Click
        Try
            Dim value As Integer = priorityQueueVectorLists.Dequeue()
            MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateQueueDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowPriorityQueueVL_Click(sender As Object, e As EventArgs) Handles btnShowPriorityQueueVL.Click
        Try
            Dim queueElements = priorityQueueVectorLists.GetQueueElements()
            lstPriorityQueueVL.Items.Clear()
            For i As Integer = 0 To queueElements.Count - 1
                If queueElements(i).Count > 0 Then
                    Dim priorityElements As String = $"Priority {i}: {String.Join(", ", queueElements(i))}"
                    lstPriorityQueueVL.Items.Add(priorityElements)
                End If
            Next

            If lstPriorityQueueVL.Items.Count = 0 Then
                MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateQueueDisplay()
        lstPriorityQueueVL.Items.Clear()
        Dim queueElements = priorityQueueVectorLists.GetQueueElements()

        For i As Integer = 0 To queueElements.Count - 1
            If queueElements(i).Count > 0 Then
                Dim priorityElements As String = $"Priority {i}: {String.Join(", ", queueElements(i))}"
                lstPriorityQueueVL.Items.Add(priorityElements)
            End If
        Next
    End Sub
    Private Sub btnEnqueuePriorityQueueLV_Click(sender As Object, e As EventArgs) Handles btnEnqueuePriorityQueueLV.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementPriorityQueueLL.Text)
            Dim priority As Integer = Integer.Parse(txtPriorityPriorityQueueLL.Text)
            priorityQueueLists.Enqueue(value, priority)
            UpdatePriorityQueueLLDisplay()
            txtElementPriorityQueueLL.Clear()
            txtPriorityPriorityQueueLL.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeququqPriorityQueueLV_Click(sender As Object, e As EventArgs) Handles btnDeququqPriorityQueueLV.Click
        Try
            Dim value As Integer = priorityQueueLists.Dequeue()
            MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdatePriorityQueueLLDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowPriorityQueueLV_Click(sender As Object, e As EventArgs) Handles btnShowPriorityQueueLV.Click
        Try
            Dim queueElements = priorityQueueLists.GetQueueElements()
            lstPriorityQueueLL.Items.Clear()

            Dim priority As Integer = 0
            For Each list In queueElements
                If list.Count > 0 Then
                    Dim priorityElements As String = $"Priority {priority}: {String.Join(", ", list)}"
                    lstPriorityQueueLL.Items.Add(priorityElements)
                End If
                priority += 1
            Next

            If lstPriorityQueueLL.Items.Count = 0 Then
                MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdatePriorityQueueLLDisplay()
        lstPriorityQueueLL.Items.Clear()

        Dim queueElements = priorityQueueLists.GetQueueElements()
        Dim priority As Integer = 0

        For Each list In queueElements
            If list.Count > 0 Then
                Dim priorityElements As String = $"Priority {priority}: {String.Join(", ", list)}"
                lstPriorityQueueLL.Items.Add(priorityElements)
            End If
            priority += 1
        Next
    End Sub

    Private Sub btnEnqueuePriorityQueueLL_Click(sender As Object, e As EventArgs) Handles btnEnqueuePriorityQueueLL.Click
        Try
            Dim value As Integer = Integer.Parse(txtElementPriorityQueueLV.Text)
            Dim priority As Integer = Integer.Parse(txtPriorityPriorityQueueLV.Text)
            priorityQueueListVectors.Enqueue(value, priority)
            UpdatePriorityQueueLVDisplay()
            txtElementPriorityQueueLV.Clear()
            txtPriorityPriorityQueueLV.Clear()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDequeuePriorityQueueLL_Click(sender As Object, e As EventArgs) Handles btnDequeuePriorityQueueLL.Click
        Try
            Dim value As Integer = priorityQueueListVectors.Dequeue()
            MessageBox.Show($"Dequeued: {value}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdatePriorityQueueLVDisplay()
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnShowPriorityQueueLL_Click(sender As Object, e As EventArgs) Handles btnShowPriorityQueueLL.Click
        Try
            Dim queueElements = priorityQueueListVectors.GetQueueElements()
            lstPriorityQueueLV.Items.Clear()
            Dim priorityIndex As Integer = 0 ' Manually track the priority index

            For Each priorityList In queueElements
                If priorityList.Count <= 0 Then
                    Continue For ' Skip empty priority lists
                End If

                ' Use the priorityIndex to show the correct priority level
                Dim priorityElements As String = $"Priority {priorityIndex}: {String.Join(", ", priorityList)}"
                lstPriorityQueueLV.Items.Add(priorityElements)
                priorityIndex += 1 ' Increment the priority index
            Next

            If lstPriorityQueueLV.Items.Count = 0 Then
                MessageBox.Show("Priority queue is empty.", "Queue Elements", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdatePriorityQueueLVDisplay()
        lstPriorityQueueLV.Items.Clear()
        Dim queueElements = priorityQueueListVectors.GetQueueElements()
        Dim priorityIndex As Integer = 0

        For Each priorityList In queueElements
            If priorityList.Count > 0 Then
                Dim priorityElements As String = $"Priority {priorityIndex}: {String.Join(", ", priorityList)}"
                lstPriorityQueueLV.Items.Add(priorityElements)
            End If
            priorityIndex += 1
        Next
    End Sub
End Class