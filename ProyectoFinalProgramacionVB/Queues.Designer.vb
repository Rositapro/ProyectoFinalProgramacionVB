<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Queues
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        label2 = New Label()
        label1 = New Label()
        btnBack = New Button()
        tabControl1 = New TabControl()
        tabPage1 = New TabPage()
        label23 = New Label()
        btnShowSingleQueueVector = New Button()
        label7 = New Label()
        label3 = New Label()
        lstSimpleQueueVector = New ListBox()
        txtElementSimpleQueueVector = New TextBox()
        btnDequeueSimpleQueueVector = New Button()
        btnEnqueueSimpleQueueVector = New Button()
        tabPage2 = New TabPage()
        label24 = New Label()
        btnShowSimpleQueueList = New Button()
        label4 = New Label()
        lstSimpleQueueList = New ListBox()
        txtElementSimpleQueueList = New TextBox()
        btnDequeueSimpleQueueList = New Button()
        btnEnqueueSimpleQueueList = New Button()
        tabPage3 = New TabPage()
        label25 = New Label()
        label6 = New Label()
        btnShowElementsCircularQueue = New Button()
        label5 = New Label()
        lstCircularQueue = New ListBox()
        txtElementCircularQueue = New TextBox()
        btnDequeueCircularQueue = New Button()
        btnEnqueueCircularQueue = New Button()
        tabPage4 = New TabPage()
        label26 = New Label()
        btnShowDoubleQueueVector = New Button()
        btnRemoveRearDoubleQueueVector = New Button()
        btnRemoveFrontDoubleQueueVector = New Button()
        btnInsertRearDoubleQueueVector = New Button()
        btnInsertFrontDoubleQueueVector = New Button()
        label8 = New Label()
        txtElementDoubleQueueVector = New TextBox()
        lstDoubleQueueVector = New ListBox()
        tabPage5 = New TabPage()
        label22 = New Label()
        btnShowDoubleQueueList = New Button()
        btnRemoveRearDoubleQueueList = New Button()
        btnRemoveFrontDoubleQueueList = New Button()
        btnInsertRearDoubleQueueList = New Button()
        btnInsertFrontDoubleQueueList = New Button()
        label9 = New Label()
        txtElementDoubleQueueList = New TextBox()
        lstDoubleQueueList = New ListBox()
        tabPage6 = New TabPage()
        label27 = New Label()
        label12 = New Label()
        txtPriorityPriorityQueueVV = New TextBox()
        btnShowPriorityQueueVV = New Button()
        label10 = New Label()
        label11 = New Label()
        lstPriorityQueueVV = New ListBox()
        txtElementPriorityQueueVV = New TextBox()
        btnDequeuePriorityQueueVV = New Button()
        btnEnqueuePriorityQueueVV = New Button()
        tabPage7 = New TabPage()
        label28 = New Label()
        label13 = New Label()
        txtPriorityPriorityQueueVL = New TextBox()
        btnShowPriorityQueueVL = New Button()
        label14 = New Label()
        label15 = New Label()
        lstPriorityQueueVL = New ListBox()
        txtElementPriorityQueueVL = New TextBox()
        btnDequeuePriorityQueueVL = New Button()
        btnEnqueuePriorityQueueVL = New Button()
        tabPage8 = New TabPage()
        label29 = New Label()
        label16 = New Label()
        txtPriorityPriorityQueueLV = New TextBox()
        btnShowPriorityQueueLV = New Button()
        label17 = New Label()
        label18 = New Label()
        lstPriorityQueueLV = New ListBox()
        txtElementPriorityQueueLV = New TextBox()
        btnDeququqPriorityQueueLV = New Button()
        btnEnqueuePriorityQueueLV = New Button()
        tabPage9 = New TabPage()
        label30 = New Label()
        label19 = New Label()
        txtPriorityPriorityQueueLL = New TextBox()
        btnShowPriorityQueueLL = New Button()
        label20 = New Label()
        label21 = New Label()
        lstPriorityQueueLL = New ListBox()
        txtElementPriorityQueueLL = New TextBox()
        btnDequeuePriorityQueueLL = New Button()
        btnEnqueuePriorityQueueLL = New Button()
        tabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        tabPage3.SuspendLayout()
        tabPage4.SuspendLayout()
        tabPage5.SuspendLayout()
        tabPage6.SuspendLayout()
        tabPage7.SuspendLayout()
        tabPage8.SuspendLayout()
        tabPage9.SuspendLayout()
        SuspendLayout()
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(12, 35)
        label2.Name = "label2"
        label2.Size = New Size(99, 37)
        label2.TabIndex = 12
        label2.Text = "Queue"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(12, 88)
        label1.Name = "label1"
        label1.Size = New Size(339, 45)
        label1.TabIndex = 11
        label1.Text = "A queue is a data structure characterized by inserting elements" & vbCrLf & "at one end and extracting them at the other. " & vbCrLf & "This behavior is based on the ""first in, first out"" (FIFO) principle."
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(148, 180)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 10
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Controls.Add(tabPage3)
        tabControl1.Controls.Add(tabPage4)
        tabControl1.Controls.Add(tabPage5)
        tabControl1.Controls.Add(tabPage6)
        tabControl1.Controls.Add(tabPage7)
        tabControl1.Controls.Add(tabPage8)
        tabControl1.Controls.Add(tabPage9)
        tabControl1.Location = New Point(449, 13)
        tabControl1.Margin = New Padding(3, 2, 3, 2)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(598, 314)
        tabControl1.TabIndex = 9
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(label23)
        tabPage1.Controls.Add(btnShowSingleQueueVector)
        tabPage1.Controls.Add(label7)
        tabPage1.Controls.Add(label3)
        tabPage1.Controls.Add(lstSimpleQueueVector)
        tabPage1.Controls.Add(txtElementSimpleQueueVector)
        tabPage1.Controls.Add(btnDequeueSimpleQueueVector)
        tabPage1.Controls.Add(btnEnqueueSimpleQueueVector)
        tabPage1.Location = New Point(4, 24)
        tabPage1.Margin = New Padding(3, 2, 3, 2)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 2, 3, 2)
        tabPage1.Size = New Size(590, 286)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Simple Queue (vector)"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' label23
        ' 
        label23.AutoSize = True
        label23.Location = New Point(54, 22)
        label23.Name = "label23"
        label23.Size = New Size(125, 15)
        label23.TabIndex = 19
        label23.Text = "Simple Queue (vector)"
        ' 
        ' btnShowSingleQueueVector
        ' 
        btnShowSingleQueueVector.Location = New Point(130, 154)
        btnShowSingleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnShowSingleQueueVector.Name = "btnShowSingleQueueVector"
        btnShowSingleQueueVector.Size = New Size(82, 22)
        btnShowSingleQueueVector.TabIndex = 18
        btnShowSingleQueueVector.Text = "Show"
        btnShowSingleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(307, 22)
        label7.Name = "label7"
        label7.Size = New Size(63, 15)
        label7.TabIndex = 17
        label7.Text = "capacity: 5"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(54, 47)
        label3.Name = "label3"
        label3.Size = New Size(53, 15)
        label3.TabIndex = 4
        label3.Text = "Element:"
        ' 
        ' lstSimpleQueueVector
        ' 
        lstSimpleQueueVector.FormattingEnabled = True
        lstSimpleQueueVector.ItemHeight = 15
        lstSimpleQueueVector.Location = New Point(304, 43)
        lstSimpleQueueVector.Margin = New Padding(3, 2, 3, 2)
        lstSimpleQueueVector.Name = "lstSimpleQueueVector"
        lstSimpleQueueVector.Size = New Size(269, 214)
        lstSimpleQueueVector.TabIndex = 3
        ' 
        ' txtElementSimpleQueueVector
        ' 
        txtElementSimpleQueueVector.Location = New Point(114, 43)
        txtElementSimpleQueueVector.Margin = New Padding(3, 2, 3, 2)
        txtElementSimpleQueueVector.Name = "txtElementSimpleQueueVector"
        txtElementSimpleQueueVector.Size = New Size(110, 23)
        txtElementSimpleQueueVector.TabIndex = 2
        ' 
        ' btnDequeueSimpleQueueVector
        ' 
        btnDequeueSimpleQueueVector.Location = New Point(130, 114)
        btnDequeueSimpleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnDequeueSimpleQueueVector.Name = "btnDequeueSimpleQueueVector"
        btnDequeueSimpleQueueVector.Size = New Size(82, 22)
        btnDequeueSimpleQueueVector.TabIndex = 1
        btnDequeueSimpleQueueVector.Text = "Dequeue"
        btnDequeueSimpleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueSimpleQueueVector
        ' 
        btnEnqueueSimpleQueueVector.Location = New Point(130, 76)
        btnEnqueueSimpleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnEnqueueSimpleQueueVector.Name = "btnEnqueueSimpleQueueVector"
        btnEnqueueSimpleQueueVector.Size = New Size(82, 22)
        btnEnqueueSimpleQueueVector.TabIndex = 0
        btnEnqueueSimpleQueueVector.Text = "Enqueue"
        btnEnqueueSimpleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(label24)
        tabPage2.Controls.Add(btnShowSimpleQueueList)
        tabPage2.Controls.Add(label4)
        tabPage2.Controls.Add(lstSimpleQueueList)
        tabPage2.Controls.Add(txtElementSimpleQueueList)
        tabPage2.Controls.Add(btnDequeueSimpleQueueList)
        tabPage2.Controls.Add(btnEnqueueSimpleQueueList)
        tabPage2.Location = New Point(4, 24)
        tabPage2.Margin = New Padding(3, 2, 3, 2)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 2, 3, 2)
        tabPage2.Size = New Size(590, 286)
        tabPage2.TabIndex = 1
        tabPage2.Text = "Simple Queue (List)"
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' label24
        ' 
        label24.AutoSize = True
        label24.Location = New Point(54, 22)
        label24.Name = "label24"
        label24.Size = New Size(107, 15)
        label24.TabIndex = 20
        label24.Text = "Simple Queue (list)"
        ' 
        ' btnShowSimpleQueueList
        ' 
        btnShowSimpleQueueList.Location = New Point(130, 154)
        btnShowSimpleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnShowSimpleQueueList.Name = "btnShowSimpleQueueList"
        btnShowSimpleQueueList.Size = New Size(82, 22)
        btnShowSimpleQueueList.TabIndex = 16
        btnShowSimpleQueueList.Text = "Show"
        btnShowSimpleQueueList.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(54, 47)
        label4.Name = "label4"
        label4.Size = New Size(53, 15)
        label4.TabIndex = 9
        label4.Text = "Element:"
        ' 
        ' lstSimpleQueueList
        ' 
        lstSimpleQueueList.FormattingEnabled = True
        lstSimpleQueueList.ItemHeight = 15
        lstSimpleQueueList.Location = New Point(304, 43)
        lstSimpleQueueList.Margin = New Padding(3, 2, 3, 2)
        lstSimpleQueueList.Name = "lstSimpleQueueList"
        lstSimpleQueueList.Size = New Size(269, 214)
        lstSimpleQueueList.TabIndex = 8
        ' 
        ' txtElementSimpleQueueList
        ' 
        txtElementSimpleQueueList.Location = New Point(114, 43)
        txtElementSimpleQueueList.Margin = New Padding(3, 2, 3, 2)
        txtElementSimpleQueueList.Name = "txtElementSimpleQueueList"
        txtElementSimpleQueueList.Size = New Size(110, 23)
        txtElementSimpleQueueList.TabIndex = 7
        ' 
        ' btnDequeueSimpleQueueList
        ' 
        btnDequeueSimpleQueueList.Location = New Point(130, 114)
        btnDequeueSimpleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnDequeueSimpleQueueList.Name = "btnDequeueSimpleQueueList"
        btnDequeueSimpleQueueList.Size = New Size(82, 22)
        btnDequeueSimpleQueueList.TabIndex = 6
        btnDequeueSimpleQueueList.Text = "Dequeue"
        btnDequeueSimpleQueueList.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueSimpleQueueList
        ' 
        btnEnqueueSimpleQueueList.Location = New Point(130, 76)
        btnEnqueueSimpleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnEnqueueSimpleQueueList.Name = "btnEnqueueSimpleQueueList"
        btnEnqueueSimpleQueueList.Size = New Size(82, 22)
        btnEnqueueSimpleQueueList.TabIndex = 5
        btnEnqueueSimpleQueueList.Text = "Enqueue"
        btnEnqueueSimpleQueueList.UseVisualStyleBackColor = True
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(label25)
        tabPage3.Controls.Add(label6)
        tabPage3.Controls.Add(btnShowElementsCircularQueue)
        tabPage3.Controls.Add(label5)
        tabPage3.Controls.Add(lstCircularQueue)
        tabPage3.Controls.Add(txtElementCircularQueue)
        tabPage3.Controls.Add(btnDequeueCircularQueue)
        tabPage3.Controls.Add(btnEnqueueCircularQueue)
        tabPage3.Location = New Point(4, 24)
        tabPage3.Margin = New Padding(3, 2, 3, 2)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3, 2, 3, 2)
        tabPage3.Size = New Size(590, 286)
        tabPage3.TabIndex = 2
        tabPage3.Text = "Circular Queue (Vector)"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' label25
        ' 
        label25.AutoSize = True
        label25.Location = New Point(54, 22)
        label25.Name = "label25"
        label25.Size = New Size(130, 15)
        label25.TabIndex = 21
        label25.Text = "Circular Queue (vector)"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(307, 28)
        label6.Name = "label6"
        label6.Size = New Size(63, 15)
        label6.TabIndex = 16
        label6.Text = "capacity: 5"
        ' 
        ' btnShowElementsCircularQueue
        ' 
        btnShowElementsCircularQueue.Location = New Point(130, 154)
        btnShowElementsCircularQueue.Margin = New Padding(3, 2, 3, 2)
        btnShowElementsCircularQueue.Name = "btnShowElementsCircularQueue"
        btnShowElementsCircularQueue.Size = New Size(82, 22)
        btnShowElementsCircularQueue.TabIndex = 15
        btnShowElementsCircularQueue.Text = "Show"
        btnShowElementsCircularQueue.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(54, 47)
        label5.Name = "label5"
        label5.Size = New Size(53, 15)
        label5.TabIndex = 14
        label5.Text = "Element:"
        ' 
        ' lstCircularQueue
        ' 
        lstCircularQueue.FormattingEnabled = True
        lstCircularQueue.ItemHeight = 15
        lstCircularQueue.Location = New Point(304, 43)
        lstCircularQueue.Margin = New Padding(3, 2, 3, 2)
        lstCircularQueue.Name = "lstCircularQueue"
        lstCircularQueue.Size = New Size(269, 214)
        lstCircularQueue.TabIndex = 13
        ' 
        ' txtElementCircularQueue
        ' 
        txtElementCircularQueue.Location = New Point(114, 43)
        txtElementCircularQueue.Margin = New Padding(3, 2, 3, 2)
        txtElementCircularQueue.Name = "txtElementCircularQueue"
        txtElementCircularQueue.Size = New Size(110, 23)
        txtElementCircularQueue.TabIndex = 12
        ' 
        ' btnDequeueCircularQueue
        ' 
        btnDequeueCircularQueue.Location = New Point(130, 114)
        btnDequeueCircularQueue.Margin = New Padding(3, 2, 3, 2)
        btnDequeueCircularQueue.Name = "btnDequeueCircularQueue"
        btnDequeueCircularQueue.Size = New Size(82, 22)
        btnDequeueCircularQueue.TabIndex = 11
        btnDequeueCircularQueue.Text = "Dequeue"
        btnDequeueCircularQueue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueCircularQueue
        ' 
        btnEnqueueCircularQueue.Location = New Point(130, 76)
        btnEnqueueCircularQueue.Margin = New Padding(3, 2, 3, 2)
        btnEnqueueCircularQueue.Name = "btnEnqueueCircularQueue"
        btnEnqueueCircularQueue.Size = New Size(82, 22)
        btnEnqueueCircularQueue.TabIndex = 10
        btnEnqueueCircularQueue.Text = "Enqueue"
        btnEnqueueCircularQueue.UseVisualStyleBackColor = True
        ' 
        ' tabPage4
        ' 
        tabPage4.Controls.Add(label26)
        tabPage4.Controls.Add(btnShowDoubleQueueVector)
        tabPage4.Controls.Add(btnRemoveRearDoubleQueueVector)
        tabPage4.Controls.Add(btnRemoveFrontDoubleQueueVector)
        tabPage4.Controls.Add(btnInsertRearDoubleQueueVector)
        tabPage4.Controls.Add(btnInsertFrontDoubleQueueVector)
        tabPage4.Controls.Add(label8)
        tabPage4.Controls.Add(txtElementDoubleQueueVector)
        tabPage4.Controls.Add(lstDoubleQueueVector)
        tabPage4.Location = New Point(4, 24)
        tabPage4.Margin = New Padding(3, 2, 3, 2)
        tabPage4.Name = "tabPage4"
        tabPage4.Padding = New Padding(3, 2, 3, 2)
        tabPage4.Size = New Size(590, 286)
        tabPage4.TabIndex = 3
        tabPage4.Text = "Double Queue (Vector)"
        tabPage4.UseVisualStyleBackColor = True
        ' 
        ' label26
        ' 
        label26.AutoSize = True
        label26.Location = New Point(54, 22)
        label26.Name = "label26"
        label26.Size = New Size(127, 15)
        label26.TabIndex = 22
        label26.Text = "Double Queue (Vector)"
        ' 
        ' btnShowDoubleQueueVector
        ' 
        btnShowDoubleQueueVector.Location = New Point(105, 186)
        btnShowDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnShowDoubleQueueVector.Name = "btnShowDoubleQueueVector"
        btnShowDoubleQueueVector.Size = New Size(82, 22)
        btnShowDoubleQueueVector.TabIndex = 21
        btnShowDoubleQueueVector.Text = "Show"
        btnShowDoubleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveRearDoubleQueueVector
        ' 
        btnRemoveRearDoubleQueueVector.Location = New Point(165, 130)
        btnRemoveRearDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnRemoveRearDoubleQueueVector.Name = "btnRemoveRearDoubleQueueVector"
        btnRemoveRearDoubleQueueVector.Size = New Size(82, 40)
        btnRemoveRearDoubleQueueVector.TabIndex = 20
        btnRemoveRearDoubleQueueVector.Text = "Remove" & vbCrLf & "Rear"
        btnRemoveRearDoubleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveFrontDoubleQueueVector
        ' 
        btnRemoveFrontDoubleQueueVector.Location = New Point(51, 133)
        btnRemoveFrontDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnRemoveFrontDoubleQueueVector.Name = "btnRemoveFrontDoubleQueueVector"
        btnRemoveFrontDoubleQueueVector.Size = New Size(82, 38)
        btnRemoveFrontDoubleQueueVector.TabIndex = 19
        btnRemoveFrontDoubleQueueVector.Text = "Remove" & vbCrLf & "Front"
        btnRemoveFrontDoubleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' btnInsertRearDoubleQueueVector
        ' 
        btnInsertRearDoubleQueueVector.Location = New Point(165, 91)
        btnInsertRearDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnInsertRearDoubleQueueVector.Name = "btnInsertRearDoubleQueueVector"
        btnInsertRearDoubleQueueVector.Size = New Size(82, 38)
        btnInsertRearDoubleQueueVector.TabIndex = 18
        btnInsertRearDoubleQueueVector.Text = "Insert" & vbCrLf & "Rear"
        btnInsertRearDoubleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' btnInsertFrontDoubleQueueVector
        ' 
        btnInsertFrontDoubleQueueVector.Location = New Point(51, 91)
        btnInsertFrontDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        btnInsertFrontDoubleQueueVector.Name = "btnInsertFrontDoubleQueueVector"
        btnInsertFrontDoubleQueueVector.Size = New Size(82, 38)
        btnInsertFrontDoubleQueueVector.TabIndex = 17
        btnInsertFrontDoubleQueueVector.Text = "Insert" & vbCrLf & "Front"
        btnInsertFrontDoubleQueueVector.UseVisualStyleBackColor = True
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(54, 47)
        label8.Name = "label8"
        label8.Size = New Size(53, 15)
        label8.TabIndex = 16
        label8.Text = "Element:"
        ' 
        ' txtElementDoubleQueueVector
        ' 
        txtElementDoubleQueueVector.Location = New Point(114, 43)
        txtElementDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        txtElementDoubleQueueVector.Name = "txtElementDoubleQueueVector"
        txtElementDoubleQueueVector.Size = New Size(110, 23)
        txtElementDoubleQueueVector.TabIndex = 15
        ' 
        ' lstDoubleQueueVector
        ' 
        lstDoubleQueueVector.FormattingEnabled = True
        lstDoubleQueueVector.ItemHeight = 15
        lstDoubleQueueVector.Location = New Point(304, 43)
        lstDoubleQueueVector.Margin = New Padding(3, 2, 3, 2)
        lstDoubleQueueVector.Name = "lstDoubleQueueVector"
        lstDoubleQueueVector.Size = New Size(269, 214)
        lstDoubleQueueVector.TabIndex = 14
        ' 
        ' tabPage5
        ' 
        tabPage5.Controls.Add(label22)
        tabPage5.Controls.Add(btnShowDoubleQueueList)
        tabPage5.Controls.Add(btnRemoveRearDoubleQueueList)
        tabPage5.Controls.Add(btnRemoveFrontDoubleQueueList)
        tabPage5.Controls.Add(btnInsertRearDoubleQueueList)
        tabPage5.Controls.Add(btnInsertFrontDoubleQueueList)
        tabPage5.Controls.Add(label9)
        tabPage5.Controls.Add(txtElementDoubleQueueList)
        tabPage5.Controls.Add(lstDoubleQueueList)
        tabPage5.Location = New Point(4, 24)
        tabPage5.Margin = New Padding(3, 2, 3, 2)
        tabPage5.Name = "tabPage5"
        tabPage5.Padding = New Padding(3, 2, 3, 2)
        tabPage5.Size = New Size(590, 286)
        tabPage5.TabIndex = 4
        tabPage5.Text = "Double Queue (List)"
        tabPage5.UseVisualStyleBackColor = True
        ' 
        ' label22
        ' 
        label22.AutoSize = True
        label22.Location = New Point(54, 22)
        label22.Name = "label22"
        label22.Size = New Size(109, 15)
        label22.TabIndex = 30
        label22.Text = "Double Queue (list)"
        ' 
        ' btnShowDoubleQueueList
        ' 
        btnShowDoubleQueueList.Location = New Point(105, 186)
        btnShowDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnShowDoubleQueueList.Name = "btnShowDoubleQueueList"
        btnShowDoubleQueueList.Size = New Size(82, 22)
        btnShowDoubleQueueList.TabIndex = 29
        btnShowDoubleQueueList.Text = "Show"
        btnShowDoubleQueueList.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveRearDoubleQueueList
        ' 
        btnRemoveRearDoubleQueueList.Location = New Point(165, 130)
        btnRemoveRearDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnRemoveRearDoubleQueueList.Name = "btnRemoveRearDoubleQueueList"
        btnRemoveRearDoubleQueueList.Size = New Size(82, 40)
        btnRemoveRearDoubleQueueList.TabIndex = 28
        btnRemoveRearDoubleQueueList.Text = "Remove" & vbCrLf & "Rear"
        btnRemoveRearDoubleQueueList.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveFrontDoubleQueueList
        ' 
        btnRemoveFrontDoubleQueueList.Location = New Point(51, 133)
        btnRemoveFrontDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnRemoveFrontDoubleQueueList.Name = "btnRemoveFrontDoubleQueueList"
        btnRemoveFrontDoubleQueueList.Size = New Size(82, 38)
        btnRemoveFrontDoubleQueueList.TabIndex = 27
        btnRemoveFrontDoubleQueueList.Text = "Remove" & vbCrLf & "Front"
        btnRemoveFrontDoubleQueueList.UseVisualStyleBackColor = True
        ' 
        ' btnInsertRearDoubleQueueList
        ' 
        btnInsertRearDoubleQueueList.Location = New Point(165, 91)
        btnInsertRearDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnInsertRearDoubleQueueList.Name = "btnInsertRearDoubleQueueList"
        btnInsertRearDoubleQueueList.Size = New Size(82, 38)
        btnInsertRearDoubleQueueList.TabIndex = 26
        btnInsertRearDoubleQueueList.Text = "Insert" & vbCrLf & "Rear"
        btnInsertRearDoubleQueueList.UseVisualStyleBackColor = True
        ' 
        ' btnInsertFrontDoubleQueueList
        ' 
        btnInsertFrontDoubleQueueList.Location = New Point(51, 91)
        btnInsertFrontDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        btnInsertFrontDoubleQueueList.Name = "btnInsertFrontDoubleQueueList"
        btnInsertFrontDoubleQueueList.Size = New Size(82, 38)
        btnInsertFrontDoubleQueueList.TabIndex = 25
        btnInsertFrontDoubleQueueList.Text = "Insert" & vbCrLf & "Front"
        btnInsertFrontDoubleQueueList.UseVisualStyleBackColor = True
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Location = New Point(54, 47)
        label9.Name = "label9"
        label9.Size = New Size(53, 15)
        label9.TabIndex = 24
        label9.Text = "Element:"
        ' 
        ' txtElementDoubleQueueList
        ' 
        txtElementDoubleQueueList.Location = New Point(114, 43)
        txtElementDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        txtElementDoubleQueueList.Name = "txtElementDoubleQueueList"
        txtElementDoubleQueueList.Size = New Size(110, 23)
        txtElementDoubleQueueList.TabIndex = 23
        ' 
        ' lstDoubleQueueList
        ' 
        lstDoubleQueueList.FormattingEnabled = True
        lstDoubleQueueList.ItemHeight = 15
        lstDoubleQueueList.Location = New Point(304, 43)
        lstDoubleQueueList.Margin = New Padding(3, 2, 3, 2)
        lstDoubleQueueList.Name = "lstDoubleQueueList"
        lstDoubleQueueList.Size = New Size(269, 214)
        lstDoubleQueueList.TabIndex = 22
        ' 
        ' tabPage6
        ' 
        tabPage6.Controls.Add(label27)
        tabPage6.Controls.Add(label12)
        tabPage6.Controls.Add(txtPriorityPriorityQueueVV)
        tabPage6.Controls.Add(btnShowPriorityQueueVV)
        tabPage6.Controls.Add(label10)
        tabPage6.Controls.Add(label11)
        tabPage6.Controls.Add(lstPriorityQueueVV)
        tabPage6.Controls.Add(txtElementPriorityQueueVV)
        tabPage6.Controls.Add(btnDequeuePriorityQueueVV)
        tabPage6.Controls.Add(btnEnqueuePriorityQueueVV)
        tabPage6.Location = New Point(4, 24)
        tabPage6.Margin = New Padding(3, 2, 3, 2)
        tabPage6.Name = "tabPage6"
        tabPage6.Padding = New Padding(3, 2, 3, 2)
        tabPage6.Size = New Size(590, 286)
        tabPage6.TabIndex = 5
        tabPage6.Text = "priority queues (vectors of vectors)"
        tabPage6.UseVisualStyleBackColor = True
        ' 
        ' label27
        ' 
        label27.AutoSize = True
        label27.Location = New Point(54, 22)
        label27.Name = "label27"
        label27.Size = New Size(187, 15)
        label27.TabIndex = 28
        label27.Text = "Priority Queue (vectors of vectors)"
        ' 
        ' label12
        ' 
        label12.AutoSize = True
        label12.Location = New Point(54, 82)
        label12.Name = "label12"
        label12.Size = New Size(48, 15)
        label12.TabIndex = 27
        label12.Text = "Priority:"
        ' 
        ' txtPriorityPriorityQueueVV
        ' 
        txtPriorityPriorityQueueVV.Location = New Point(114, 78)
        txtPriorityPriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        txtPriorityPriorityQueueVV.Name = "txtPriorityPriorityQueueVV"
        txtPriorityPriorityQueueVV.Size = New Size(110, 23)
        txtPriorityPriorityQueueVV.TabIndex = 26
        ' 
        ' btnShowPriorityQueueVV
        ' 
        btnShowPriorityQueueVV.Location = New Point(130, 190)
        btnShowPriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        btnShowPriorityQueueVV.Name = "btnShowPriorityQueueVV"
        btnShowPriorityQueueVV.Size = New Size(82, 22)
        btnShowPriorityQueueVV.TabIndex = 25
        btnShowPriorityQueueVV.Text = "Show"
        btnShowPriorityQueueVV.UseVisualStyleBackColor = True
        ' 
        ' label10
        ' 
        label10.AutoSize = True
        label10.Location = New Point(307, 22)
        label10.Name = "label10"
        label10.Size = New Size(63, 15)
        label10.TabIndex = 24
        label10.Text = "capacity: 5"
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(54, 47)
        label11.Name = "label11"
        label11.Size = New Size(53, 15)
        label11.TabIndex = 23
        label11.Text = "Element:"
        ' 
        ' lstPriorityQueueVV
        ' 
        lstPriorityQueueVV.FormattingEnabled = True
        lstPriorityQueueVV.ItemHeight = 15
        lstPriorityQueueVV.Location = New Point(304, 43)
        lstPriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        lstPriorityQueueVV.Name = "lstPriorityQueueVV"
        lstPriorityQueueVV.Size = New Size(269, 214)
        lstPriorityQueueVV.TabIndex = 22
        ' 
        ' txtElementPriorityQueueVV
        ' 
        txtElementPriorityQueueVV.Location = New Point(114, 43)
        txtElementPriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        txtElementPriorityQueueVV.Name = "txtElementPriorityQueueVV"
        txtElementPriorityQueueVV.Size = New Size(110, 23)
        txtElementPriorityQueueVV.TabIndex = 21
        ' 
        ' btnDequeuePriorityQueueVV
        ' 
        btnDequeuePriorityQueueVV.Location = New Point(130, 150)
        btnDequeuePriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        btnDequeuePriorityQueueVV.Name = "btnDequeuePriorityQueueVV"
        btnDequeuePriorityQueueVV.Size = New Size(82, 22)
        btnDequeuePriorityQueueVV.TabIndex = 20
        btnDequeuePriorityQueueVV.Text = "Dequeue"
        btnDequeuePriorityQueueVV.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePriorityQueueVV
        ' 
        btnEnqueuePriorityQueueVV.Location = New Point(130, 112)
        btnEnqueuePriorityQueueVV.Margin = New Padding(3, 2, 3, 2)
        btnEnqueuePriorityQueueVV.Name = "btnEnqueuePriorityQueueVV"
        btnEnqueuePriorityQueueVV.Size = New Size(82, 22)
        btnEnqueuePriorityQueueVV.TabIndex = 19
        btnEnqueuePriorityQueueVV.Text = "Enqueue"
        btnEnqueuePriorityQueueVV.UseVisualStyleBackColor = True
        ' 
        ' tabPage7
        ' 
        tabPage7.Controls.Add(label28)
        tabPage7.Controls.Add(label13)
        tabPage7.Controls.Add(txtPriorityPriorityQueueVL)
        tabPage7.Controls.Add(btnShowPriorityQueueVL)
        tabPage7.Controls.Add(label14)
        tabPage7.Controls.Add(label15)
        tabPage7.Controls.Add(lstPriorityQueueVL)
        tabPage7.Controls.Add(txtElementPriorityQueueVL)
        tabPage7.Controls.Add(btnDequeuePriorityQueueVL)
        tabPage7.Controls.Add(btnEnqueuePriorityQueueVL)
        tabPage7.Location = New Point(4, 24)
        tabPage7.Margin = New Padding(3, 2, 3, 2)
        tabPage7.Name = "tabPage7"
        tabPage7.Padding = New Padding(3, 2, 3, 2)
        tabPage7.Size = New Size(590, 286)
        tabPage7.TabIndex = 6
        tabPage7.Text = "priority queues (vectors of lists)"
        tabPage7.UseVisualStyleBackColor = True
        ' 
        ' label28
        ' 
        label28.AutoSize = True
        label28.Location = New Point(54, 22)
        label28.Name = "label28"
        label28.Size = New Size(169, 15)
        label28.TabIndex = 37
        label28.Text = "Priority Queue (vectors of lists)"
        ' 
        ' label13
        ' 
        label13.AutoSize = True
        label13.Location = New Point(54, 82)
        label13.Name = "label13"
        label13.Size = New Size(48, 15)
        label13.TabIndex = 36
        label13.Text = "Priority:"
        ' 
        ' txtPriorityPriorityQueueVL
        ' 
        txtPriorityPriorityQueueVL.Location = New Point(114, 78)
        txtPriorityPriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        txtPriorityPriorityQueueVL.Name = "txtPriorityPriorityQueueVL"
        txtPriorityPriorityQueueVL.Size = New Size(110, 23)
        txtPriorityPriorityQueueVL.TabIndex = 35
        ' 
        ' btnShowPriorityQueueVL
        ' 
        btnShowPriorityQueueVL.Location = New Point(130, 190)
        btnShowPriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        btnShowPriorityQueueVL.Name = "btnShowPriorityQueueVL"
        btnShowPriorityQueueVL.Size = New Size(82, 22)
        btnShowPriorityQueueVL.TabIndex = 34
        btnShowPriorityQueueVL.Text = "Show"
        btnShowPriorityQueueVL.UseVisualStyleBackColor = True
        ' 
        ' label14
        ' 
        label14.AutoSize = True
        label14.Location = New Point(307, 22)
        label14.Name = "label14"
        label14.Size = New Size(63, 15)
        label14.TabIndex = 33
        label14.Text = "capacity: 5"
        ' 
        ' label15
        ' 
        label15.AutoSize = True
        label15.Location = New Point(54, 47)
        label15.Name = "label15"
        label15.Size = New Size(53, 15)
        label15.TabIndex = 32
        label15.Text = "Element:"
        ' 
        ' lstPriorityQueueVL
        ' 
        lstPriorityQueueVL.FormattingEnabled = True
        lstPriorityQueueVL.ItemHeight = 15
        lstPriorityQueueVL.Location = New Point(304, 43)
        lstPriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        lstPriorityQueueVL.Name = "lstPriorityQueueVL"
        lstPriorityQueueVL.Size = New Size(269, 214)
        lstPriorityQueueVL.TabIndex = 31
        ' 
        ' txtElementPriorityQueueVL
        ' 
        txtElementPriorityQueueVL.Location = New Point(114, 43)
        txtElementPriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        txtElementPriorityQueueVL.Name = "txtElementPriorityQueueVL"
        txtElementPriorityQueueVL.Size = New Size(110, 23)
        txtElementPriorityQueueVL.TabIndex = 30
        ' 
        ' btnDequeuePriorityQueueVL
        ' 
        btnDequeuePriorityQueueVL.Location = New Point(130, 150)
        btnDequeuePriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        btnDequeuePriorityQueueVL.Name = "btnDequeuePriorityQueueVL"
        btnDequeuePriorityQueueVL.Size = New Size(82, 22)
        btnDequeuePriorityQueueVL.TabIndex = 29
        btnDequeuePriorityQueueVL.Text = "Dequeue"
        btnDequeuePriorityQueueVL.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePriorityQueueVL
        ' 
        btnEnqueuePriorityQueueVL.Location = New Point(130, 112)
        btnEnqueuePriorityQueueVL.Margin = New Padding(3, 2, 3, 2)
        btnEnqueuePriorityQueueVL.Name = "btnEnqueuePriorityQueueVL"
        btnEnqueuePriorityQueueVL.Size = New Size(82, 22)
        btnEnqueuePriorityQueueVL.TabIndex = 28
        btnEnqueuePriorityQueueVL.Text = "Enqueue"
        btnEnqueuePriorityQueueVL.UseVisualStyleBackColor = True
        ' 
        ' tabPage8
        ' 
        tabPage8.Controls.Add(label29)
        tabPage8.Controls.Add(label16)
        tabPage8.Controls.Add(txtPriorityPriorityQueueLV)
        tabPage8.Controls.Add(btnShowPriorityQueueLV)
        tabPage8.Controls.Add(label17)
        tabPage8.Controls.Add(label18)
        tabPage8.Controls.Add(lstPriorityQueueLV)
        tabPage8.Controls.Add(txtElementPriorityQueueLV)
        tabPage8.Controls.Add(btnDeququqPriorityQueueLV)
        tabPage8.Controls.Add(btnEnqueuePriorityQueueLV)
        tabPage8.Location = New Point(4, 24)
        tabPage8.Margin = New Padding(3, 2, 3, 2)
        tabPage8.Name = "tabPage8"
        tabPage8.Padding = New Padding(3, 2, 3, 2)
        tabPage8.Size = New Size(590, 286)
        tabPage8.TabIndex = 7
        tabPage8.Text = "priority queues (lists of vectors)"
        tabPage8.UseVisualStyleBackColor = True
        ' 
        ' label29
        ' 
        label29.AutoSize = True
        label29.Location = New Point(54, 22)
        label29.Name = "label29"
        label29.Size = New Size(169, 15)
        label29.TabIndex = 46
        label29.Text = "Priority Queue (lists of vectors)"
        ' 
        ' label16
        ' 
        label16.AutoSize = True
        label16.Location = New Point(54, 82)
        label16.Name = "label16"
        label16.Size = New Size(48, 15)
        label16.TabIndex = 45
        label16.Text = "Priority:"
        ' 
        ' txtPriorityPriorityQueueLV
        ' 
        txtPriorityPriorityQueueLV.Location = New Point(114, 78)
        txtPriorityPriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        txtPriorityPriorityQueueLV.Name = "txtPriorityPriorityQueueLV"
        txtPriorityPriorityQueueLV.Size = New Size(110, 23)
        txtPriorityPriorityQueueLV.TabIndex = 44
        ' 
        ' btnShowPriorityQueueLV
        ' 
        btnShowPriorityQueueLV.Location = New Point(130, 190)
        btnShowPriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        btnShowPriorityQueueLV.Name = "btnShowPriorityQueueLV"
        btnShowPriorityQueueLV.Size = New Size(82, 22)
        btnShowPriorityQueueLV.TabIndex = 43
        btnShowPriorityQueueLV.Text = "Show"
        btnShowPriorityQueueLV.UseVisualStyleBackColor = True
        ' 
        ' label17
        ' 
        label17.AutoSize = True
        label17.Location = New Point(307, 22)
        label17.Name = "label17"
        label17.Size = New Size(63, 15)
        label17.TabIndex = 42
        label17.Text = "capacity: 5"
        ' 
        ' label18
        ' 
        label18.AutoSize = True
        label18.Location = New Point(54, 47)
        label18.Name = "label18"
        label18.Size = New Size(53, 15)
        label18.TabIndex = 41
        label18.Text = "Element:"
        ' 
        ' lstPriorityQueueLV
        ' 
        lstPriorityQueueLV.FormattingEnabled = True
        lstPriorityQueueLV.ItemHeight = 15
        lstPriorityQueueLV.Location = New Point(304, 43)
        lstPriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        lstPriorityQueueLV.Name = "lstPriorityQueueLV"
        lstPriorityQueueLV.Size = New Size(269, 214)
        lstPriorityQueueLV.TabIndex = 40
        ' 
        ' txtElementPriorityQueueLV
        ' 
        txtElementPriorityQueueLV.Location = New Point(114, 43)
        txtElementPriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        txtElementPriorityQueueLV.Name = "txtElementPriorityQueueLV"
        txtElementPriorityQueueLV.Size = New Size(110, 23)
        txtElementPriorityQueueLV.TabIndex = 39
        ' 
        ' btnDeququqPriorityQueueLV
        ' 
        btnDeququqPriorityQueueLV.Location = New Point(130, 150)
        btnDeququqPriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        btnDeququqPriorityQueueLV.Name = "btnDeququqPriorityQueueLV"
        btnDeququqPriorityQueueLV.Size = New Size(82, 22)
        btnDeququqPriorityQueueLV.TabIndex = 38
        btnDeququqPriorityQueueLV.Text = "Dequeue"
        btnDeququqPriorityQueueLV.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePriorityQueueLV
        ' 
        btnEnqueuePriorityQueueLV.Location = New Point(130, 112)
        btnEnqueuePriorityQueueLV.Margin = New Padding(3, 2, 3, 2)
        btnEnqueuePriorityQueueLV.Name = "btnEnqueuePriorityQueueLV"
        btnEnqueuePriorityQueueLV.Size = New Size(82, 22)
        btnEnqueuePriorityQueueLV.TabIndex = 37
        btnEnqueuePriorityQueueLV.Text = "Enqueue"
        btnEnqueuePriorityQueueLV.UseVisualStyleBackColor = True
        ' 
        ' tabPage9
        ' 
        tabPage9.Controls.Add(label30)
        tabPage9.Controls.Add(label19)
        tabPage9.Controls.Add(txtPriorityPriorityQueueLL)
        tabPage9.Controls.Add(btnShowPriorityQueueLL)
        tabPage9.Controls.Add(label20)
        tabPage9.Controls.Add(label21)
        tabPage9.Controls.Add(lstPriorityQueueLL)
        tabPage9.Controls.Add(txtElementPriorityQueueLL)
        tabPage9.Controls.Add(btnDequeuePriorityQueueLL)
        tabPage9.Controls.Add(btnEnqueuePriorityQueueLL)
        tabPage9.Location = New Point(4, 24)
        tabPage9.Margin = New Padding(3, 2, 3, 2)
        tabPage9.Name = "tabPage9"
        tabPage9.Padding = New Padding(3, 2, 3, 2)
        tabPage9.Size = New Size(590, 286)
        tabPage9.TabIndex = 8
        tabPage9.Text = "priority queues (lists of lists)"
        tabPage9.UseVisualStyleBackColor = True
        ' 
        ' label30
        ' 
        label30.AutoSize = True
        label30.Location = New Point(54, 22)
        label30.Name = "label30"
        label30.Size = New Size(151, 15)
        label30.TabIndex = 55
        label30.Text = "Priority Queue (lists of lists)"
        ' 
        ' label19
        ' 
        label19.AutoSize = True
        label19.Location = New Point(54, 82)
        label19.Name = "label19"
        label19.Size = New Size(48, 15)
        label19.TabIndex = 54
        label19.Text = "Priority:"
        ' 
        ' txtPriorityPriorityQueueLL
        ' 
        txtPriorityPriorityQueueLL.Location = New Point(114, 78)
        txtPriorityPriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        txtPriorityPriorityQueueLL.Name = "txtPriorityPriorityQueueLL"
        txtPriorityPriorityQueueLL.Size = New Size(110, 23)
        txtPriorityPriorityQueueLL.TabIndex = 53
        ' 
        ' btnShowPriorityQueueLL
        ' 
        btnShowPriorityQueueLL.Location = New Point(130, 190)
        btnShowPriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        btnShowPriorityQueueLL.Name = "btnShowPriorityQueueLL"
        btnShowPriorityQueueLL.Size = New Size(82, 22)
        btnShowPriorityQueueLL.TabIndex = 52
        btnShowPriorityQueueLL.Text = "Show"
        btnShowPriorityQueueLL.UseVisualStyleBackColor = True
        ' 
        ' label20
        ' 
        label20.AutoSize = True
        label20.Location = New Point(307, 22)
        label20.Name = "label20"
        label20.Size = New Size(63, 15)
        label20.TabIndex = 51
        label20.Text = "capacity: 5"
        ' 
        ' label21
        ' 
        label21.AutoSize = True
        label21.Location = New Point(54, 47)
        label21.Name = "label21"
        label21.Size = New Size(53, 15)
        label21.TabIndex = 50
        label21.Text = "Element:"
        ' 
        ' lstPriorityQueueLL
        ' 
        lstPriorityQueueLL.FormattingEnabled = True
        lstPriorityQueueLL.ItemHeight = 15
        lstPriorityQueueLL.Location = New Point(304, 43)
        lstPriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        lstPriorityQueueLL.Name = "lstPriorityQueueLL"
        lstPriorityQueueLL.Size = New Size(269, 214)
        lstPriorityQueueLL.TabIndex = 49
        ' 
        ' txtElementPriorityQueueLL
        ' 
        txtElementPriorityQueueLL.Location = New Point(114, 43)
        txtElementPriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        txtElementPriorityQueueLL.Name = "txtElementPriorityQueueLL"
        txtElementPriorityQueueLL.Size = New Size(110, 23)
        txtElementPriorityQueueLL.TabIndex = 48
        ' 
        ' btnDequeuePriorityQueueLL
        ' 
        btnDequeuePriorityQueueLL.Location = New Point(130, 150)
        btnDequeuePriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        btnDequeuePriorityQueueLL.Name = "btnDequeuePriorityQueueLL"
        btnDequeuePriorityQueueLL.Size = New Size(82, 22)
        btnDequeuePriorityQueueLL.TabIndex = 47
        btnDequeuePriorityQueueLL.Text = "Dequeue"
        btnDequeuePriorityQueueLL.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePriorityQueueLL
        ' 
        btnEnqueuePriorityQueueLL.Location = New Point(130, 112)
        btnEnqueuePriorityQueueLL.Margin = New Padding(3, 2, 3, 2)
        btnEnqueuePriorityQueueLL.Name = "btnEnqueuePriorityQueueLL"
        btnEnqueuePriorityQueueLL.Size = New Size(82, 22)
        btnEnqueuePriorityQueueLL.TabIndex = 46
        btnEnqueuePriorityQueueLL.Text = "Enqueue"
        btnEnqueuePriorityQueueLL.UseVisualStyleBackColor = True
        ' 
        ' Queues
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1179, 427)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnBack)
        Controls.Add(tabControl1)
        Name = "Queues"
        Text = "Queues"
        tabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        tabPage3.ResumeLayout(False)
        tabPage3.PerformLayout()
        tabPage4.ResumeLayout(False)
        tabPage4.PerformLayout()
        tabPage5.ResumeLayout(False)
        tabPage5.PerformLayout()
        tabPage6.ResumeLayout(False)
        tabPage6.PerformLayout()
        tabPage7.ResumeLayout(False)
        tabPage7.PerformLayout()
        tabPage8.ResumeLayout(False)
        tabPage8.PerformLayout()
        tabPage9.ResumeLayout(False)
        tabPage9.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnBack As Button
    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label23 As Label
    Private WithEvents btnShowSingleQueueVector As Button
    Private WithEvents label7 As Label
    Private WithEvents label3 As Label
    Private WithEvents lstSimpleQueueVector As ListBox
    Private WithEvents txtElementSimpleQueueVector As TextBox
    Private WithEvents btnDequeueSimpleQueueVector As Button
    Private WithEvents btnEnqueueSimpleQueueVector As Button
    Private WithEvents tabPage2 As TabPage
    Private WithEvents label24 As Label
    Private WithEvents btnShowSimpleQueueList As Button
    Private WithEvents label4 As Label
    Private WithEvents lstSimpleQueueList As ListBox
    Private WithEvents txtElementSimpleQueueList As TextBox
    Private WithEvents btnDequeueSimpleQueueList As Button
    Private WithEvents btnEnqueueSimpleQueueList As Button
    Private WithEvents tabPage3 As TabPage
    Private WithEvents label25 As Label
    Private WithEvents label6 As Label
    Private WithEvents btnShowElementsCircularQueue As Button
    Private WithEvents label5 As Label
    Private WithEvents lstCircularQueue As ListBox
    Private WithEvents txtElementCircularQueue As TextBox
    Private WithEvents btnDequeueCircularQueue As Button
    Private WithEvents btnEnqueueCircularQueue As Button
    Private WithEvents tabPage4 As TabPage
    Private WithEvents label26 As Label
    Private WithEvents btnShowDoubleQueueVector As Button
    Private WithEvents btnRemoveRearDoubleQueueVector As Button
    Private WithEvents btnRemoveFrontDoubleQueueVector As Button
    Private WithEvents btnInsertRearDoubleQueueVector As Button
    Private WithEvents btnInsertFrontDoubleQueueVector As Button
    Private WithEvents label8 As Label
    Private WithEvents txtElementDoubleQueueVector As TextBox
    Private WithEvents lstDoubleQueueVector As ListBox
    Private WithEvents tabPage5 As TabPage
    Private WithEvents label22 As Label
    Private WithEvents btnShowDoubleQueueList As Button
    Private WithEvents btnRemoveRearDoubleQueueList As Button
    Private WithEvents btnRemoveFrontDoubleQueueList As Button
    Private WithEvents btnInsertRearDoubleQueueList As Button
    Private WithEvents btnInsertFrontDoubleQueueList As Button
    Private WithEvents label9 As Label
    Private WithEvents txtElementDoubleQueueList As TextBox
    Private WithEvents lstDoubleQueueList As ListBox
    Private WithEvents tabPage6 As TabPage
    Private WithEvents label27 As Label
    Private WithEvents label12 As Label
    Private WithEvents txtPriorityPriorityQueueVV As TextBox
    Private WithEvents btnShowPriorityQueueVV As Button
    Private WithEvents label10 As Label
    Private WithEvents label11 As Label
    Private WithEvents lstPriorityQueueVV As ListBox
    Private WithEvents txtElementPriorityQueueVV As TextBox
    Private WithEvents btnDequeuePriorityQueueVV As Button
    Private WithEvents btnEnqueuePriorityQueueVV As Button
    Private WithEvents tabPage7 As TabPage
    Private WithEvents label28 As Label
    Private WithEvents label13 As Label
    Private WithEvents txtPriorityPriorityQueueVL As TextBox
    Private WithEvents btnShowPriorityQueueVL As Button
    Private WithEvents label14 As Label
    Private WithEvents label15 As Label
    Private WithEvents lstPriorityQueueVL As ListBox
    Private WithEvents txtElementPriorityQueueVL As TextBox
    Private WithEvents btnDequeuePriorityQueueVL As Button
    Private WithEvents btnEnqueuePriorityQueueVL As Button
    Private WithEvents tabPage8 As TabPage
    Private WithEvents label29 As Label
    Private WithEvents label16 As Label
    Private WithEvents txtPriorityPriorityQueueLV As TextBox
    Private WithEvents btnShowPriorityQueueLV As Button
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents lstPriorityQueueLV As ListBox
    Private WithEvents txtElementPriorityQueueLV As TextBox
    Private WithEvents btnDeququqPriorityQueueLV As Button
    Private WithEvents btnEnqueuePriorityQueueLV As Button
    Private WithEvents tabPage9 As TabPage
    Private WithEvents label30 As Label
    Private WithEvents label19 As Label
    Private WithEvents txtPriorityPriorityQueueLL As TextBox
    Private WithEvents btnShowPriorityQueueLL As Button
    Private WithEvents label20 As Label
    Private WithEvents label21 As Label
    Private WithEvents lstPriorityQueueLL As ListBox
    Private WithEvents txtElementPriorityQueueLL As TextBox
    Private WithEvents btnDequeuePriorityQueueLL As Button
    Private WithEvents btnEnqueuePriorityQueueLL As Button
End Class
