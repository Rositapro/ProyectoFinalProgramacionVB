<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SortingAlgorithmsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SortingAlgorithmsForm))
        tabControl1 = New TabControl()
        tabPage1 = New TabPage()
        label4 = New Label()
        ComBoxSelect = New ComboBox()
        LsBoxOrder = New ListBox()
        TxtDataNum = New TextBox()
        LblInstructurs = New Label()
        BtnInsert = New Button()
        label3 = New Label()
        tabPage2 = New TabPage()
        label9 = New Label()
        label6 = New Label()
        label5 = New Label()
        lBoxunsorted = New ListBox()
        btnSort = New Button()
        lboxArray = New ListBox()
        btnRandom = New Button()
        tbArray = New TextBox()
        cbOption = New ComboBox()
        tabPage4 = New TabPage()
        dataGridView1 = New DataGridView()
        label7 = New Label()
        btnShellSort = New Button()
        txtInput = New TextBox()
        tabPage5 = New TabPage()
        label8 = New Label()
        cBOrdenCountingSort = New ComboBox()
        lblTimeElapsed = New Label()
        dgvOutputCountingSort = New DataGridView()
        dataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        btnCountingSort = New Button()
        lblValues = New Label()
        txtInputCountingSort = New TextBox()
        BucketSort = New TabPage()
        cbxOrderBucketSort = New ComboBox()
        lstvBucket = New ListView()
        lstvOrder = New ListView()
        txtOrderBucketSort = New TextBox()
        btnBucketSort = New Button()
        tabPage7 = New TabPage()
        btnClearListMergeSort = New Button()
        lblNumbers = New Label()
        txtInputMergeSort = New TextBox()
        btnIngresarMergeSort = New Button()
        btnMezclaDirecta = New Button()
        btnMezclaNatural = New Button()
        btnMergeSort = New Button()
        listViewStepsMergeSort = New ListView()
        tabPage3 = New TabPage()
        btnShuffleGnomeSort = New Button()
        btnSortGnomeSort = New Button()
        listBoxGnomeSort = New ListBox()
        tabPage6 = New TabPage()
        btnClearPidgeonHola = New Button()
        btnSortPidgeonHola = New Button()
        txtOutputPidgeonHola = New TextBox()
        label11 = New Label()
        txtInputPidgeonHola = New TextBox()
        label10 = New Label()
        tabPage8 = New TabPage()
        dataGridViewStepsCombSort = New DataGridView()
        btnSortCombSort = New Button()
        tabPage9 = New TabPage()
        lstSortedRadixSort = New ListBox()
        txtNumbersRadixSort = New TextBox()
        btnMSDRadixSort = New Button()
        btnLSDRadixSort = New Button()
        btnRandomizeRadixSort = New Button()
        btnBack = New Button()
        label2 = New Label()
        label1 = New Label()
        tabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        tabPage4.SuspendLayout()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        tabPage5.SuspendLayout()
        CType(dgvOutputCountingSort, ComponentModel.ISupportInitialize).BeginInit()
        BucketSort.SuspendLayout()
        tabPage7.SuspendLayout()
        tabPage3.SuspendLayout()
        tabPage6.SuspendLayout()
        tabPage8.SuspendLayout()
        CType(dataGridViewStepsCombSort, ComponentModel.ISupportInitialize).BeginInit()
        tabPage9.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Controls.Add(tabPage4)
        tabControl1.Controls.Add(tabPage5)
        tabControl1.Controls.Add(BucketSort)
        tabControl1.Controls.Add(tabPage7)
        tabControl1.Controls.Add(tabPage3)
        tabControl1.Controls.Add(tabPage6)
        tabControl1.Controls.Add(tabPage8)
        tabControl1.Controls.Add(tabPage9)
        tabControl1.Location = New Point(573, 11)
        tabControl1.Margin = New Padding(3, 2, 3, 2)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(706, 319)
        tabControl1.TabIndex = 7
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(label4)
        tabPage1.Controls.Add(ComBoxSelect)
        tabPage1.Controls.Add(LsBoxOrder)
        tabPage1.Controls.Add(TxtDataNum)
        tabPage1.Controls.Add(LblInstructurs)
        tabPage1.Controls.Add(BtnInsert)
        tabPage1.Controls.Add(label3)
        tabPage1.Location = New Point(4, 24)
        tabPage1.Margin = New Padding(3, 2, 3, 2)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 2, 3, 2)
        tabPage1.Size = New Size(698, 291)
        tabPage1.TabIndex = 0
        tabPage1.Text = "BubbleSort, CocktailSort, InsertionSort"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(63, 133)
        label4.Name = "label4"
        label4.Size = New Size(117, 15)
        label4.TabIndex = 14
        label4.Text = "Tipo de organisacion"
        ' 
        ' ComBoxSelect
        ' 
        ComBoxSelect.FormattingEnabled = True
        ComBoxSelect.Items.AddRange(New Object() {"Bubblesort", "Cocktail sort", "Insertion sort"})
        ComBoxSelect.Location = New Point(196, 129)
        ComBoxSelect.Name = "ComBoxSelect"
        ComBoxSelect.Size = New Size(121, 23)
        ComBoxSelect.TabIndex = 13
        ' 
        ' LsBoxOrder
        ' 
        LsBoxOrder.Font = New Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LsBoxOrder.FormattingEnabled = True
        LsBoxOrder.ItemHeight = 40
        LsBoxOrder.Location = New Point(368, 68)
        LsBoxOrder.Name = "LsBoxOrder"
        LsBoxOrder.Size = New Size(300, 84)
        LsBoxOrder.TabIndex = 12
        ' 
        ' TxtDataNum
        ' 
        TxtDataNum.Location = New Point(37, 96)
        TxtDataNum.Margin = New Padding(3, 2, 3, 2)
        TxtDataNum.Name = "TxtDataNum"
        TxtDataNum.Size = New Size(217, 23)
        TxtDataNum.TabIndex = 11
        ' 
        ' LblInstructurs
        ' 
        LblInstructurs.AutoSize = True
        LblInstructurs.Location = New Point(27, 70)
        LblInstructurs.Name = "LblInstructurs"
        LblInstructurs.Size = New Size(241, 15)
        LblInstructurs.TabIndex = 10
        LblInstructurs.Text = "Ingresa 10 numeros seprados por un espacio"
        ' 
        ' BtnInsert
        ' 
        BtnInsert.Location = New Point(258, 96)
        BtnInsert.Margin = New Padding(3, 2, 3, 2)
        BtnInsert.Name = "BtnInsert"
        BtnInsert.Size = New Size(82, 22)
        BtnInsert.TabIndex = 9
        BtnInsert.Text = "Insertar"
        BtnInsert.UseVisualStyleBackColor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label3.Location = New Point(22, 17)
        label3.Name = "label3"
        label3.Size = New Size(520, 37)
        label3.TabIndex = 8
        label3.Text = "BubbleSort, CocktailSort, InsertionSort"
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(label9)
        tabPage2.Controls.Add(label6)
        tabPage2.Controls.Add(label5)
        tabPage2.Controls.Add(lBoxunsorted)
        tabPage2.Controls.Add(btnSort)
        tabPage2.Controls.Add(lboxArray)
        tabPage2.Controls.Add(btnRandom)
        tabPage2.Controls.Add(tbArray)
        tabPage2.Controls.Add(cbOption)
        tabPage2.Location = New Point(4, 24)
        tabPage2.Margin = New Padding(3, 2, 3, 2)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 2, 3, 2)
        tabPage2.Size = New Size(698, 291)
        tabPage2.TabIndex = 1
        tabPage2.Text = "SelectionSort, HeapSort, QuickSort "
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Location = New Point(383, 109)
        label9.Name = "label9"
        label9.Size = New Size(61, 15)
        label9.TabIndex = 17
        label9.Text = "Organized"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(156, 109)
        label6.Name = "label6"
        label6.Size = New Size(75, 15)
        label6.TabIndex = 16
        label6.Text = "Disorganized"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(427, 25)
        label5.Name = "label5"
        label5.Size = New Size(61, 15)
        label5.TabIndex = 15
        label5.Text = "Algorithm"
        ' 
        ' lBoxunsorted
        ' 
        lBoxunsorted.FormattingEnabled = True
        lBoxunsorted.ItemHeight = 15
        lBoxunsorted.Location = New Point(153, 125)
        lBoxunsorted.Name = "lBoxunsorted"
        lBoxunsorted.Size = New Size(120, 124)
        lBoxunsorted.TabIndex = 14
        ' 
        ' btnSort
        ' 
        btnSort.Location = New Point(295, 68)
        btnSort.Name = "btnSort"
        btnSort.Size = New Size(75, 23)
        btnSort.TabIndex = 13
        btnSort.Text = "Sort"
        btnSort.UseVisualStyleBackColor = True
        ' 
        ' lboxArray
        ' 
        lboxArray.FormattingEnabled = True
        lboxArray.ItemHeight = 15
        lboxArray.Location = New Point(380, 125)
        lboxArray.Name = "lboxArray"
        lboxArray.Size = New Size(120, 124)
        lboxArray.TabIndex = 12
        ' 
        ' btnRandom
        ' 
        btnRandom.Location = New Point(153, 38)
        btnRandom.Name = "btnRandom"
        btnRandom.Size = New Size(75, 23)
        btnRandom.TabIndex = 10
        btnRandom.Text = "Random"
        btnRandom.UseVisualStyleBackColor = True
        ' 
        ' tbArray
        ' 
        tbArray.Location = New Point(235, 41)
        tbArray.Name = "tbArray"
        tbArray.Size = New Size(184, 23)
        tbArray.TabIndex = 9
        ' 
        ' cbOption
        ' 
        cbOption.FormattingEnabled = True
        cbOption.Items.AddRange(New Object() {"Selectionsort", "Heapsort", "Quicksort"})
        cbOption.Location = New Point(424, 41)
        cbOption.Name = "cbOption"
        cbOption.Size = New Size(121, 23)
        cbOption.TabIndex = 8
        ' 
        ' tabPage4
        ' 
        tabPage4.Controls.Add(dataGridView1)
        tabPage4.Controls.Add(label7)
        tabPage4.Controls.Add(btnShellSort)
        tabPage4.Controls.Add(txtInput)
        tabPage4.Location = New Point(4, 24)
        tabPage4.Margin = New Padding(3, 2, 3, 2)
        tabPage4.Name = "tabPage4"
        tabPage4.Padding = New Padding(3, 2, 3, 2)
        tabPage4.Size = New Size(698, 291)
        tabPage4.TabIndex = 3
        tabPage4.Text = "ShellSort"
        tabPage4.UseVisualStyleBackColor = True
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Location = New Point(140, 106)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersWidth = 51
        dataGridView1.Size = New Size(418, 174)
        dataGridView1.TabIndex = 9
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(143, 16)
        label7.Name = "label7"
        label7.Size = New Size(35, 15)
        label7.TabIndex = 8
        label7.Text = "Array"
        ' 
        ' btnShellSort
        ' 
        btnShellSort.Location = New Point(140, 62)
        btnShellSort.Name = "btnShellSort"
        btnShellSort.Size = New Size(120, 23)
        btnShellSort.TabIndex = 7
        btnShellSort.Text = "Activate Shell sort"
        btnShellSort.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(140, 32)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(180, 23)
        txtInput.TabIndex = 6
        ' 
        ' tabPage5
        ' 
        tabPage5.Controls.Add(label8)
        tabPage5.Controls.Add(cBOrdenCountingSort)
        tabPage5.Controls.Add(lblTimeElapsed)
        tabPage5.Controls.Add(dgvOutputCountingSort)
        tabPage5.Controls.Add(btnCountingSort)
        tabPage5.Controls.Add(lblValues)
        tabPage5.Controls.Add(txtInputCountingSort)
        tabPage5.Location = New Point(4, 24)
        tabPage5.Margin = New Padding(3, 2, 3, 2)
        tabPage5.Name = "tabPage5"
        tabPage5.Padding = New Padding(3, 2, 3, 2)
        tabPage5.Size = New Size(698, 291)
        tabPage5.TabIndex = 4
        tabPage5.Text = "CountingSort"
        tabPage5.UseVisualStyleBackColor = True
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(534, 9)
        label8.Name = "label8"
        label8.Size = New Size(40, 15)
        label8.TabIndex = 310
        label8.Text = "Orden"
        ' 
        ' cBOrdenCountingSort
        ' 
        cBOrdenCountingSort.FormattingEnabled = True
        cBOrdenCountingSort.Location = New Point(531, 32)
        cBOrdenCountingSort.Margin = New Padding(3, 2, 3, 2)
        cBOrdenCountingSort.Name = "cBOrdenCountingSort"
        cBOrdenCountingSort.Size = New Size(133, 23)
        cBOrdenCountingSort.TabIndex = 309
        ' 
        ' lblTimeElapsed
        ' 
        lblTimeElapsed.AutoSize = True
        lblTimeElapsed.Location = New Point(510, 69)
        lblTimeElapsed.Name = "lblTimeElapsed"
        lblTimeElapsed.Size = New Size(141, 15)
        lblTimeElapsed.TabIndex = 308
        lblTimeElapsed.Text = "Tiempo de ordenamiento"
        ' 
        ' dgvOutputCountingSort
        ' 
        dgvOutputCountingSort.AllowUserToAddRows = False
        dgvOutputCountingSort.AllowUserToDeleteRows = False
        dgvOutputCountingSort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOutputCountingSort.Columns.AddRange(New DataGridViewColumn() {dataGridViewTextBoxColumn1})
        dgvOutputCountingSort.EnableHeadersVisualStyles = False
        dgvOutputCountingSort.Location = New Point(126, 100)
        dgvOutputCountingSort.Margin = New Padding(3, 2, 3, 2)
        dgvOutputCountingSort.Name = "dgvOutputCountingSort"
        dgvOutputCountingSort.RowHeadersWidth = 51
        dgvOutputCountingSort.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOutputCountingSort.Size = New Size(482, 176)
        dgvOutputCountingSort.TabIndex = 307
        ' 
        ' dataGridViewTextBoxColumn1
        ' 
        dataGridViewTextBoxColumn1.MinimumWidth = 6
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1"
        dataGridViewTextBoxColumn1.Width = 500
        ' 
        ' btnCountingSort
        ' 
        btnCountingSort.Location = New Point(212, 64)
        btnCountingSort.Margin = New Padding(3, 2, 3, 2)
        btnCountingSort.Name = "btnCountingSort"
        btnCountingSort.Size = New Size(82, 22)
        btnCountingSort.TabIndex = 306
        btnCountingSort.Text = "Sort"
        btnCountingSort.UseVisualStyleBackColor = True
        ' 
        ' lblValues
        ' 
        lblValues.AutoSize = True
        lblValues.Location = New Point(51, 9)
        lblValues.Name = "lblValues"
        lblValues.Size = New Size(40, 15)
        lblValues.TabIndex = 305
        lblValues.Text = "Values"
        ' 
        ' txtInputCountingSort
        ' 
        txtInputCountingSort.Font = New Font("Segoe UI", 15F)
        txtInputCountingSort.Location = New Point(48, 28)
        txtInputCountingSort.Margin = New Padding(3, 2, 3, 2)
        txtInputCountingSort.Name = "txtInputCountingSort"
        txtInputCountingSort.Size = New Size(456, 34)
        txtInputCountingSort.TabIndex = 304
        ' 
        ' BucketSort
        ' 
        BucketSort.Controls.Add(cbxOrderBucketSort)
        BucketSort.Controls.Add(lstvBucket)
        BucketSort.Controls.Add(lstvOrder)
        BucketSort.Controls.Add(txtOrderBucketSort)
        BucketSort.Controls.Add(btnBucketSort)
        BucketSort.Location = New Point(4, 24)
        BucketSort.Margin = New Padding(3, 2, 3, 2)
        BucketSort.Name = "BucketSort"
        BucketSort.Padding = New Padding(3, 2, 3, 2)
        BucketSort.Size = New Size(698, 291)
        BucketSort.TabIndex = 5
        BucketSort.Text = "BucketSort"
        BucketSort.UseVisualStyleBackColor = True
        ' 
        ' cbxOrderBucketSort
        ' 
        cbxOrderBucketSort.FormattingEnabled = True
        cbxOrderBucketSort.Location = New Point(38, 26)
        cbxOrderBucketSort.Name = "cbxOrderBucketSort"
        cbxOrderBucketSort.Size = New Size(121, 23)
        cbxOrderBucketSort.TabIndex = 11
        ' 
        ' lstvBucket
        ' 
        lstvBucket.Location = New Point(385, 14)
        lstvBucket.Name = "lstvBucket"
        lstvBucket.Size = New Size(264, 116)
        lstvBucket.TabIndex = 9
        lstvBucket.UseCompatibleStateImageBehavior = False
        ' 
        ' lstvOrder
        ' 
        lstvOrder.Location = New Point(386, 167)
        lstvOrder.Name = "lstvOrder"
        lstvOrder.Size = New Size(263, 125)
        lstvOrder.TabIndex = 8
        lstvOrder.UseCompatibleStateImageBehavior = False
        ' 
        ' txtOrderBucketSort
        ' 
        txtOrderBucketSort.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOrderBucketSort.Location = New Point(38, 68)
        txtOrderBucketSort.Multiline = True
        txtOrderBucketSort.Name = "txtOrderBucketSort"
        txtOrderBucketSort.ReadOnly = True
        txtOrderBucketSort.ScrollBars = ScrollBars.Vertical
        txtOrderBucketSort.Size = New Size(295, 56)
        txtOrderBucketSort.TabIndex = 7
        ' 
        ' btnBucketSort
        ' 
        btnBucketSort.Font = New Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBucketSort.Location = New Point(122, 130)
        btnBucketSort.Name = "btnBucketSort"
        btnBucketSort.Size = New Size(122, 32)
        btnBucketSort.TabIndex = 6
        btnBucketSort.Text = "Bucket Sort "
        btnBucketSort.UseVisualStyleBackColor = True
        ' 
        ' tabPage7
        ' 
        tabPage7.Controls.Add(btnClearListMergeSort)
        tabPage7.Controls.Add(lblNumbers)
        tabPage7.Controls.Add(txtInputMergeSort)
        tabPage7.Controls.Add(btnIngresarMergeSort)
        tabPage7.Controls.Add(btnMezclaDirecta)
        tabPage7.Controls.Add(btnMezclaNatural)
        tabPage7.Controls.Add(btnMergeSort)
        tabPage7.Controls.Add(listViewStepsMergeSort)
        tabPage7.Location = New Point(4, 24)
        tabPage7.Margin = New Padding(3, 2, 3, 2)
        tabPage7.Name = "tabPage7"
        tabPage7.Padding = New Padding(3, 2, 3, 2)
        tabPage7.Size = New Size(698, 291)
        tabPage7.TabIndex = 6
        tabPage7.Text = "MergeSort"
        tabPage7.UseVisualStyleBackColor = True
        ' 
        ' btnClearListMergeSort
        ' 
        btnClearListMergeSort.Location = New Point(237, 218)
        btnClearListMergeSort.Name = "btnClearListMergeSort"
        btnClearListMergeSort.Size = New Size(75, 23)
        btnClearListMergeSort.TabIndex = 15
        btnClearListMergeSort.Text = "Clear list"
        btnClearListMergeSort.UseVisualStyleBackColor = True
        ' 
        ' lblNumbers
        ' 
        lblNumbers.AutoSize = True
        lblNumbers.Location = New Point(20, 84)
        lblNumbers.Name = "lblNumbers"
        lblNumbers.Size = New Size(56, 15)
        lblNumbers.TabIndex = 14
        lblNumbers.Text = "Numbers"
        ' 
        ' txtInputMergeSort
        ' 
        txtInputMergeSort.Location = New Point(74, 79)
        txtInputMergeSort.Name = "txtInputMergeSort"
        txtInputMergeSort.Size = New Size(151, 23)
        txtInputMergeSort.TabIndex = 13
        ' 
        ' btnIngresarMergeSort
        ' 
        btnIngresarMergeSort.Location = New Point(237, 79)
        btnIngresarMergeSort.Name = "btnIngresarMergeSort"
        btnIngresarMergeSort.Size = New Size(75, 23)
        btnIngresarMergeSort.TabIndex = 12
        btnIngresarMergeSort.Text = "Ingresar"
        btnIngresarMergeSort.UseVisualStyleBackColor = True
        ' 
        ' btnMezclaDirecta
        ' 
        btnMezclaDirecta.Location = New Point(237, 140)
        btnMezclaDirecta.Name = "btnMezclaDirecta"
        btnMezclaDirecta.Size = New Size(75, 23)
        btnMezclaDirecta.TabIndex = 11
        btnMezclaDirecta.Text = "Directa"
        btnMezclaDirecta.UseVisualStyleBackColor = True
        ' 
        ' btnMezclaNatural
        ' 
        btnMezclaNatural.Location = New Point(237, 172)
        btnMezclaNatural.Name = "btnMezclaNatural"
        btnMezclaNatural.Size = New Size(75, 23)
        btnMezclaNatural.TabIndex = 10
        btnMezclaNatural.Text = "Natural"
        btnMezclaNatural.UseVisualStyleBackColor = True
        ' 
        ' btnMergeSort
        ' 
        btnMergeSort.Location = New Point(237, 111)
        btnMergeSort.Name = "btnMergeSort"
        btnMergeSort.Size = New Size(75, 23)
        btnMergeSort.TabIndex = 9
        btnMergeSort.Text = "Merge"
        btnMergeSort.UseVisualStyleBackColor = True
        ' 
        ' listViewStepsMergeSort
        ' 
        listViewStepsMergeSort.FullRowSelect = True
        listViewStepsMergeSort.GridLines = True
        listViewStepsMergeSort.Location = New Point(351, 61)
        listViewStepsMergeSort.Name = "listViewStepsMergeSort"
        listViewStepsMergeSort.Size = New Size(323, 181)
        listViewStepsMergeSort.TabIndex = 8
        listViewStepsMergeSort.UseCompatibleStateImageBehavior = False
        listViewStepsMergeSort.View = View.Details
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(btnShuffleGnomeSort)
        tabPage3.Controls.Add(btnSortGnomeSort)
        tabPage3.Controls.Add(listBoxGnomeSort)
        tabPage3.Location = New Point(4, 24)
        tabPage3.Margin = New Padding(3, 2, 3, 2)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3, 2, 3, 2)
        tabPage3.Size = New Size(698, 291)
        tabPage3.TabIndex = 7
        tabPage3.Text = "GnomeSort"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnShuffleGnomeSort
        ' 
        btnShuffleGnomeSort.Location = New Point(200, 173)
        btnShuffleGnomeSort.Name = "btnShuffleGnomeSort"
        btnShuffleGnomeSort.Size = New Size(126, 33)
        btnShuffleGnomeSort.TabIndex = 5
        btnShuffleGnomeSort.Text = "Shuffle"
        btnShuffleGnomeSort.UseVisualStyleBackColor = True
        ' 
        ' btnSortGnomeSort
        ' 
        btnSortGnomeSort.Location = New Point(364, 173)
        btnSortGnomeSort.Name = "btnSortGnomeSort"
        btnSortGnomeSort.Size = New Size(126, 33)
        btnSortGnomeSort.TabIndex = 4
        btnSortGnomeSort.Text = "Sort"
        btnSortGnomeSort.UseVisualStyleBackColor = True
        ' 
        ' listBoxGnomeSort
        ' 
        listBoxGnomeSort.Font = New Font("Segoe UI", 20F)
        listBoxGnomeSort.FormattingEnabled = True
        listBoxGnomeSort.ItemHeight = 37
        listBoxGnomeSort.Location = New Point(32, 53)
        listBoxGnomeSort.Name = "listBoxGnomeSort"
        listBoxGnomeSort.Size = New Size(623, 41)
        listBoxGnomeSort.TabIndex = 3
        ' 
        ' tabPage6
        ' 
        tabPage6.Controls.Add(btnClearPidgeonHola)
        tabPage6.Controls.Add(btnSortPidgeonHola)
        tabPage6.Controls.Add(txtOutputPidgeonHola)
        tabPage6.Controls.Add(label11)
        tabPage6.Controls.Add(txtInputPidgeonHola)
        tabPage6.Controls.Add(label10)
        tabPage6.Location = New Point(4, 24)
        tabPage6.Margin = New Padding(3, 2, 3, 2)
        tabPage6.Name = "tabPage6"
        tabPage6.Padding = New Padding(3, 2, 3, 2)
        tabPage6.Size = New Size(698, 291)
        tabPage6.TabIndex = 8
        tabPage6.Text = "PidgeonHolesSort"
        tabPage6.UseVisualStyleBackColor = True
        ' 
        ' btnClearPidgeonHola
        ' 
        btnClearPidgeonHola.Location = New Point(283, 209)
        btnClearPidgeonHola.Margin = New Padding(3, 2, 3, 2)
        btnClearPidgeonHola.Name = "btnClearPidgeonHola"
        btnClearPidgeonHola.Size = New Size(82, 22)
        btnClearPidgeonHola.TabIndex = 5
        btnClearPidgeonHola.Text = "Clear"
        btnClearPidgeonHola.UseVisualStyleBackColor = True
        ' 
        ' btnSortPidgeonHola
        ' 
        btnSortPidgeonHola.Location = New Point(62, 209)
        btnSortPidgeonHola.Margin = New Padding(3, 2, 3, 2)
        btnSortPidgeonHola.Name = "btnSortPidgeonHola"
        btnSortPidgeonHola.Size = New Size(82, 22)
        btnSortPidgeonHola.TabIndex = 4
        btnSortPidgeonHola.Text = "Sort"
        btnSortPidgeonHola.UseVisualStyleBackColor = True
        ' 
        ' txtOutputPidgeonHola
        ' 
        txtOutputPidgeonHola.Location = New Point(62, 154)
        txtOutputPidgeonHola.Margin = New Padding(3, 2, 3, 2)
        txtOutputPidgeonHola.Name = "txtOutputPidgeonHola"
        txtOutputPidgeonHola.Size = New Size(225, 23)
        txtOutputPidgeonHola.TabIndex = 3
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(65, 125)
        label11.Name = "label11"
        label11.Size = New Size(59, 15)
        label11.TabIndex = 2
        label11.Text = "Resultado"
        ' 
        ' txtInputPidgeonHola
        ' 
        txtInputPidgeonHola.Location = New Point(62, 81)
        txtInputPidgeonHola.Margin = New Padding(3, 2, 3, 2)
        txtInputPidgeonHola.Name = "txtInputPidgeonHola"
        txtInputPidgeonHola.Size = New Size(225, 23)
        txtInputPidgeonHola.TabIndex = 1
        ' 
        ' label10
        ' 
        label10.AutoSize = True
        label10.Location = New Point(65, 54)
        label10.Name = "label10"
        label10.Size = New Size(250, 15)
        label10.TabIndex = 0
        label10.Text = "Ingresa números válidos separados por comas"
        ' 
        ' tabPage8
        ' 
        tabPage8.Controls.Add(dataGridViewStepsCombSort)
        tabPage8.Controls.Add(btnSortCombSort)
        tabPage8.Location = New Point(4, 24)
        tabPage8.Margin = New Padding(3, 2, 3, 2)
        tabPage8.Name = "tabPage8"
        tabPage8.Padding = New Padding(3, 2, 3, 2)
        tabPage8.Size = New Size(698, 291)
        tabPage8.TabIndex = 9
        tabPage8.Text = "CombSort"
        tabPage8.UseVisualStyleBackColor = True
        ' 
        ' dataGridViewStepsCombSort
        ' 
        dataGridViewStepsCombSort.AllowUserToOrderColumns = True
        dataGridViewStepsCombSort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridViewStepsCombSort.Location = New Point(142, 28)
        dataGridViewStepsCombSort.Margin = New Padding(3, 2, 3, 2)
        dataGridViewStepsCombSort.Name = "dataGridViewStepsCombSort"
        dataGridViewStepsCombSort.RowHeadersWidth = 51
        dataGridViewStepsCombSort.Size = New Size(416, 178)
        dataGridViewStepsCombSort.TabIndex = 5
        ' 
        ' btnSortCombSort
        ' 
        btnSortCombSort.Location = New Point(142, 226)
        btnSortCombSort.Margin = New Padding(3, 2, 3, 2)
        btnSortCombSort.Name = "btnSortCombSort"
        btnSortCombSort.Size = New Size(178, 41)
        btnSortCombSort.TabIndex = 4
        btnSortCombSort.Text = "Ordenar"
        btnSortCombSort.UseVisualStyleBackColor = True
        ' 
        ' tabPage9
        ' 
        tabPage9.Controls.Add(lstSortedRadixSort)
        tabPage9.Controls.Add(txtNumbersRadixSort)
        tabPage9.Controls.Add(btnMSDRadixSort)
        tabPage9.Controls.Add(btnLSDRadixSort)
        tabPage9.Controls.Add(btnRandomizeRadixSort)
        tabPage9.Location = New Point(4, 24)
        tabPage9.Margin = New Padding(3, 2, 3, 2)
        tabPage9.Name = "tabPage9"
        tabPage9.Padding = New Padding(3, 2, 3, 2)
        tabPage9.Size = New Size(698, 291)
        tabPage9.TabIndex = 10
        tabPage9.Text = "RadixSort"
        tabPage9.UseVisualStyleBackColor = True
        ' 
        ' lstSortedRadixSort
        ' 
        lstSortedRadixSort.FormattingEnabled = True
        lstSortedRadixSort.ItemHeight = 15
        lstSortedRadixSort.Location = New Point(244, 60)
        lstSortedRadixSort.Margin = New Padding(3, 2, 3, 2)
        lstSortedRadixSort.Name = "lstSortedRadixSort"
        lstSortedRadixSort.Size = New Size(238, 154)
        lstSortedRadixSort.TabIndex = 4
        ' 
        ' txtNumbersRadixSort
        ' 
        txtNumbersRadixSort.Location = New Point(24, 22)
        txtNumbersRadixSort.Margin = New Padding(3, 2, 3, 2)
        txtNumbersRadixSort.Name = "txtNumbersRadixSort"
        txtNumbersRadixSort.Size = New Size(458, 23)
        txtNumbersRadixSort.TabIndex = 3
        ' 
        ' btnMSDRadixSort
        ' 
        btnMSDRadixSort.Location = New Point(136, 97)
        btnMSDRadixSort.Margin = New Padding(3, 2, 3, 2)
        btnMSDRadixSort.Name = "btnMSDRadixSort"
        btnMSDRadixSort.Size = New Size(82, 22)
        btnMSDRadixSort.TabIndex = 2
        btnMSDRadixSort.Text = "MSD"
        btnMSDRadixSort.UseVisualStyleBackColor = True
        ' 
        ' btnLSDRadixSort
        ' 
        btnLSDRadixSort.Location = New Point(136, 60)
        btnLSDRadixSort.Margin = New Padding(3, 2, 3, 2)
        btnLSDRadixSort.Name = "btnLSDRadixSort"
        btnLSDRadixSort.Size = New Size(82, 22)
        btnLSDRadixSort.TabIndex = 1
        btnLSDRadixSort.Text = "LSD"
        btnLSDRadixSort.UseVisualStyleBackColor = True
        ' 
        ' btnRandomizeRadixSort
        ' 
        btnRandomizeRadixSort.Location = New Point(24, 60)
        btnRandomizeRadixSort.Margin = New Padding(3, 2, 3, 2)
        btnRandomizeRadixSort.Name = "btnRandomizeRadixSort"
        btnRandomizeRadixSort.Size = New Size(82, 22)
        btnRandomizeRadixSort.TabIndex = 0
        btnRandomizeRadixSort.Text = "Randomize"
        btnRandomizeRadixSort.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(216, 213)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 6
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(12, 73)
        label2.Name = "label2"
        label2.Size = New Size(535, 105)
        label2.TabIndex = 5
        label2.Text = resources.GetString("label2.Text")
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(12, 17)
        label1.Name = "label1"
        label1.Size = New Size(264, 37)
        label1.TabIndex = 4
        label1.Text = "Sorting Algorithms"
        ' 
        ' SortingAlgorithmsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1301, 441)
        Controls.Add(tabControl1)
        Controls.Add(btnBack)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "SortingAlgorithmsForm"
        Text = "SortingAlgorithmsForm"
        tabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        tabPage4.ResumeLayout(False)
        tabPage4.PerformLayout()
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        tabPage5.ResumeLayout(False)
        tabPage5.PerformLayout()
        CType(dgvOutputCountingSort, ComponentModel.ISupportInitialize).EndInit()
        BucketSort.ResumeLayout(False)
        BucketSort.PerformLayout()
        tabPage7.ResumeLayout(False)
        tabPage7.PerformLayout()
        tabPage3.ResumeLayout(False)
        tabPage6.ResumeLayout(False)
        tabPage6.PerformLayout()
        tabPage8.ResumeLayout(False)
        CType(dataGridViewStepsCombSort, ComponentModel.ISupportInitialize).EndInit()
        tabPage9.ResumeLayout(False)
        tabPage9.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label4 As Label
    Private WithEvents ComBoxSelect As ComboBox
    Private WithEvents LsBoxOrder As ListBox
    Private WithEvents TxtDataNum As TextBox
    Private WithEvents LblInstructurs As Label
    Private WithEvents BtnInsert As Button
    Private WithEvents label3 As Label
    Private WithEvents tabPage2 As TabPage
    Private WithEvents label9 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents lBoxunsorted As ListBox
    Private WithEvents btnSort As Button
    Private WithEvents lboxArray As ListBox
    Private WithEvents btnRandom As Button
    Private WithEvents tbArray As TextBox
    Private WithEvents cbOption As ComboBox
    Private WithEvents tabPage4 As TabPage
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents label7 As Label
    Private WithEvents btnShellSort As Button
    Private WithEvents txtInput As TextBox
    Private WithEvents tabPage5 As TabPage
    Private WithEvents label8 As Label
    Private WithEvents cBOrdenCountingSort As ComboBox
    Private WithEvents lblTimeElapsed As Label
    Private WithEvents dgvOutputCountingSort As DataGridView
    Private WithEvents dataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Private WithEvents btnCountingSort As Button
    Private WithEvents lblValues As Label
    Private WithEvents txtInputCountingSort As TextBox
    Private WithEvents BucketSort As TabPage
    Private WithEvents cbxOrderBucketSort As ComboBox
    Private WithEvents lstvBucket As ListView
    Private WithEvents lstvOrder As ListView
    Private WithEvents txtOrderBucketSort As TextBox
    Private WithEvents btnBucketSort As Button
    Private WithEvents tabPage7 As TabPage
    Private WithEvents btnClearListMergeSort As Button
    Private WithEvents lblNumbers As Label
    Private WithEvents txtInputMergeSort As TextBox
    Private WithEvents btnIngresarMergeSort As Button
    Private WithEvents btnMezclaDirecta As Button
    Private WithEvents btnMezclaNatural As Button
    Private WithEvents btnMergeSort As Button
    Private WithEvents listViewStepsMergeSort As ListView
    Private WithEvents tabPage3 As TabPage
    Private WithEvents btnShuffleGnomeSort As Button
    Private WithEvents btnSortGnomeSort As Button
    Private WithEvents listBoxGnomeSort As ListBox
    Private WithEvents tabPage6 As TabPage
    Private WithEvents btnClearPidgeonHola As Button
    Private WithEvents btnSortPidgeonHola As Button
    Private WithEvents txtOutputPidgeonHola As TextBox
    Private WithEvents label11 As Label
    Private WithEvents txtInputPidgeonHola As TextBox
    Private WithEvents label10 As Label
    Private WithEvents tabPage8 As TabPage
    Private WithEvents dataGridViewStepsCombSort As DataGridView
    Private WithEvents btnSortCombSort As Button
    Private WithEvents tabPage9 As TabPage
    Private WithEvents lstSortedRadixSort As ListBox
    Private WithEvents txtNumbersRadixSort As TextBox
    Private WithEvents btnMSDRadixSort As Button
    Private WithEvents btnLSDRadixSort As Button
    Private WithEvents btnRandomizeRadixSort As Button
    Private WithEvents btnBack As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
