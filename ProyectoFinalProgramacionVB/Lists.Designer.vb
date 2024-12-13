<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lists
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lists))
        tabControl = New TabControl()
        tabPage1 = New TabPage()
        txtZipCode = New TextBox()
        label4 = New Label()
        btnCountSingleList = New Button()
        txtPhoneNumber = New TextBox()
        label3 = New Label()
        txtName = New TextBox()
        label5 = New Label()
        btnRemoveSingleList = New Button()
        btnContainsSingleList = New Button()
        btnAddSingleList = New Button()
        txtValue = New TextBox()
        label6 = New Label()
        tabPage2 = New TabPage()
        btnContainsCircularsLists = New Button()
        lstNodes = New ListBox()
        btnCountCircularsLists = New Button()
        lblValue = New Label()
        btnRemoveCircularsLists = New Button()
        txtValueCircularList = New TextBox()
        btnAddCircularsLists = New Button()
        tabPage3 = New TabPage()
        btnSearchDoubleList = New Button()
        lblData = New Label()
        btnDeleteDoubleList = New Button()
        txtDataDoubleList = New TextBox()
        btnAggDoubleList = New Button()
        lvDisplayDoubleList = New ListView()
        tabPage4 = New TabPage()
        btnContainsDoubleCircularList = New Button()
        btnRemoveDoubleCircularList = New Button()
        btnAddDoubleCircularList = New Button()
        txtNumberDoubleCircularList = New TextBox()
        label7 = New Label()
        btnBack = New Button()
        label2 = New Label()
        label1 = New Label()
        tabControl.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        tabPage3.SuspendLayout()
        tabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl
        ' 
        tabControl.Controls.Add(tabPage1)
        tabControl.Controls.Add(tabPage2)
        tabControl.Controls.Add(tabPage3)
        tabControl.Controls.Add(tabPage4)
        tabControl.Location = New Point(502, 17)
        tabControl.Margin = New Padding(3, 2, 3, 2)
        tabControl.Name = "tabControl"
        tabControl.SelectedIndex = 0
        tabControl.Size = New Size(718, 304)
        tabControl.TabIndex = 7
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(txtZipCode)
        tabPage1.Controls.Add(label4)
        tabPage1.Controls.Add(btnCountSingleList)
        tabPage1.Controls.Add(txtPhoneNumber)
        tabPage1.Controls.Add(label3)
        tabPage1.Controls.Add(txtName)
        tabPage1.Controls.Add(label5)
        tabPage1.Controls.Add(btnRemoveSingleList)
        tabPage1.Controls.Add(btnContainsSingleList)
        tabPage1.Controls.Add(btnAddSingleList)
        tabPage1.Controls.Add(txtValue)
        tabPage1.Controls.Add(label6)
        tabPage1.Location = New Point(4, 24)
        tabPage1.Margin = New Padding(3, 2, 3, 2)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 2, 3, 2)
        tabPage1.Size = New Size(710, 276)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Singles"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' txtZipCode
        ' 
        txtZipCode.Font = New Font("Segoe UI", 20F)
        txtZipCode.Location = New Point(221, 192)
        txtZipCode.Name = "txtZipCode"
        txtZipCode.Size = New Size(212, 43)
        txtZipCode.TabIndex = 24
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 20F)
        label4.Location = New Point(80, 197)
        label4.Name = "label4"
        label4.Size = New Size(125, 37)
        label4.TabIndex = 23
        label4.Text = "Zip Code"
        ' 
        ' btnCountSingleList
        ' 
        btnCountSingleList.Font = New Font("Segoe UI", 20F)
        btnCountSingleList.Location = New Point(475, 192)
        btnCountSingleList.Name = "btnCountSingleList"
        btnCountSingleList.Size = New Size(159, 43)
        btnCountSingleList.TabIndex = 22
        btnCountSingleList.Text = "Count"
        btnCountSingleList.UseVisualStyleBackColor = True
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI", 20F)
        txtPhoneNumber.Location = New Point(221, 143)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(212, 43)
        txtPhoneNumber.TabIndex = 21
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 20F)
        label3.Location = New Point(113, 145)
        label3.Name = "label3"
        label3.Size = New Size(92, 37)
        label3.TabIndex = 20
        label3.Text = "Phone"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 20F)
        txtName.Location = New Point(221, 94)
        txtName.Name = "txtName"
        txtName.Size = New Size(212, 43)
        txtName.TabIndex = 19
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Segoe UI", 20F)
        label5.Location = New Point(113, 96)
        label5.Name = "label5"
        label5.Size = New Size(88, 37)
        label5.TabIndex = 18
        label5.Text = "Name"
        ' 
        ' btnRemoveSingleList
        ' 
        btnRemoveSingleList.Font = New Font("Segoe UI", 20F)
        btnRemoveSingleList.Location = New Point(475, 143)
        btnRemoveSingleList.Name = "btnRemoveSingleList"
        btnRemoveSingleList.Size = New Size(159, 43)
        btnRemoveSingleList.TabIndex = 17
        btnRemoveSingleList.Text = "Remove"
        btnRemoveSingleList.UseVisualStyleBackColor = True
        ' 
        ' btnContainsSingleList
        ' 
        btnContainsSingleList.Font = New Font("Segoe UI", 20F)
        btnContainsSingleList.Location = New Point(475, 94)
        btnContainsSingleList.Name = "btnContainsSingleList"
        btnContainsSingleList.Size = New Size(159, 43)
        btnContainsSingleList.TabIndex = 16
        btnContainsSingleList.Text = "Contains"
        btnContainsSingleList.UseVisualStyleBackColor = True
        ' 
        ' btnAddSingleList
        ' 
        btnAddSingleList.Font = New Font("Segoe UI", 20F)
        btnAddSingleList.Location = New Point(475, 45)
        btnAddSingleList.Name = "btnAddSingleList"
        btnAddSingleList.Size = New Size(159, 43)
        btnAddSingleList.TabIndex = 15
        btnAddSingleList.Text = "Add"
        btnAddSingleList.UseVisualStyleBackColor = True
        ' 
        ' txtValue
        ' 
        txtValue.Font = New Font("Segoe UI", 20F)
        txtValue.Location = New Point(221, 45)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(212, 43)
        txtValue.TabIndex = 14
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 20F)
        label6.Location = New Point(113, 47)
        label6.Name = "label6"
        label6.Size = New Size(82, 37)
        label6.TabIndex = 13
        label6.Text = "Value"
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(btnContainsCircularsLists)
        tabPage2.Controls.Add(lstNodes)
        tabPage2.Controls.Add(btnCountCircularsLists)
        tabPage2.Controls.Add(lblValue)
        tabPage2.Controls.Add(btnRemoveCircularsLists)
        tabPage2.Controls.Add(txtValueCircularList)
        tabPage2.Controls.Add(btnAddCircularsLists)
        tabPage2.Location = New Point(4, 24)
        tabPage2.Margin = New Padding(3, 2, 3, 2)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 2, 3, 2)
        tabPage2.Size = New Size(710, 276)
        tabPage2.TabIndex = 1
        tabPage2.Text = "Circulars"
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnContainsCircularsLists
        ' 
        btnContainsCircularsLists.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnContainsCircularsLists.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnContainsCircularsLists.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnContainsCircularsLists.Location = New Point(290, 127)
        btnContainsCircularsLists.Margin = New Padding(3, 2, 3, 2)
        btnContainsCircularsLists.Name = "btnContainsCircularsLists"
        btnContainsCircularsLists.Size = New Size(101, 42)
        btnContainsCircularsLists.TabIndex = 17
        btnContainsCircularsLists.Text = "Contains"
        btnContainsCircularsLists.UseVisualStyleBackColor = False
        ' 
        ' lstNodes
        ' 
        lstNodes.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        lstNodes.Font = New Font("Agency FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstNodes.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lstNodes.FormattingEnabled = True
        lstNodes.ItemHeight = 34
        lstNodes.Location = New Point(396, 22)
        lstNodes.Margin = New Padding(3, 2, 3, 2)
        lstNodes.Name = "lstNodes"
        lstNodes.Size = New Size(206, 208)
        lstNodes.TabIndex = 13
        ' 
        ' btnCountCircularsLists
        ' 
        btnCountCircularsLists.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnCountCircularsLists.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCountCircularsLists.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnCountCircularsLists.Location = New Point(290, 176)
        btnCountCircularsLists.Margin = New Padding(3, 2, 3, 2)
        btnCountCircularsLists.Name = "btnCountCircularsLists"
        btnCountCircularsLists.Size = New Size(101, 42)
        btnCountCircularsLists.TabIndex = 16
        btnCountCircularsLists.Text = "Count"
        btnCountCircularsLists.UseVisualStyleBackColor = False
        ' 
        ' lblValue
        ' 
        lblValue.AutoSize = True
        lblValue.Font = New Font("Bernard MT Condensed", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblValue.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        lblValue.Location = New Point(72, 23)
        lblValue.Name = "lblValue"
        lblValue.Size = New Size(76, 31)
        lblValue.TabIndex = 11
        lblValue.Text = "Value"
        ' 
        ' btnRemoveCircularsLists
        ' 
        btnRemoveCircularsLists.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnRemoveCircularsLists.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnRemoveCircularsLists.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnRemoveCircularsLists.Location = New Point(290, 80)
        btnRemoveCircularsLists.Margin = New Padding(3, 2, 3, 2)
        btnRemoveCircularsLists.Name = "btnRemoveCircularsLists"
        btnRemoveCircularsLists.Size = New Size(101, 42)
        btnRemoveCircularsLists.TabIndex = 15
        btnRemoveCircularsLists.Text = "Remove"
        btnRemoveCircularsLists.UseVisualStyleBackColor = False
        ' 
        ' txtValueCircularList
        ' 
        txtValueCircularList.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        txtValueCircularList.Font = New Font("Agency FB", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtValueCircularList.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        txtValueCircularList.Location = New Point(157, 22)
        txtValueCircularList.Margin = New Padding(3, 2, 3, 2)
        txtValueCircularList.Multiline = True
        txtValueCircularList.Name = "txtValueCircularList"
        txtValueCircularList.Size = New Size(126, 30)
        txtValueCircularList.TabIndex = 12
        ' 
        ' btnAddCircularsLists
        ' 
        btnAddCircularsLists.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnAddCircularsLists.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddCircularsLists.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnAddCircularsLists.Location = New Point(290, 30)
        btnAddCircularsLists.Margin = New Padding(3, 2, 3, 2)
        btnAddCircularsLists.Name = "btnAddCircularsLists"
        btnAddCircularsLists.Size = New Size(101, 42)
        btnAddCircularsLists.TabIndex = 14
        btnAddCircularsLists.Text = "Add"
        btnAddCircularsLists.UseVisualStyleBackColor = False
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(btnSearchDoubleList)
        tabPage3.Controls.Add(lblData)
        tabPage3.Controls.Add(btnDeleteDoubleList)
        tabPage3.Controls.Add(txtDataDoubleList)
        tabPage3.Controls.Add(btnAggDoubleList)
        tabPage3.Controls.Add(lvDisplayDoubleList)
        tabPage3.Location = New Point(4, 24)
        tabPage3.Margin = New Padding(3, 2, 3, 2)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3, 2, 3, 2)
        tabPage3.Size = New Size(710, 276)
        tabPage3.TabIndex = 2
        tabPage3.Text = "Doubles"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSearchDoubleList
        ' 
        btnSearchDoubleList.Location = New Point(432, 195)
        btnSearchDoubleList.Margin = New Padding(3, 2, 3, 2)
        btnSearchDoubleList.Name = "btnSearchDoubleList"
        btnSearchDoubleList.Size = New Size(82, 22)
        btnSearchDoubleList.TabIndex = 21
        btnSearchDoubleList.Text = "Search"
        btnSearchDoubleList.UseVisualStyleBackColor = True
        ' 
        ' lblData
        ' 
        lblData.AutoSize = True
        lblData.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblData.Location = New Point(435, 72)
        lblData.Name = "lblData"
        lblData.Size = New Size(62, 30)
        lblData.TabIndex = 17
        lblData.Text = "Data"
        ' 
        ' btnDeleteDoubleList
        ' 
        btnDeleteDoubleList.Location = New Point(432, 169)
        btnDeleteDoubleList.Margin = New Padding(3, 2, 3, 2)
        btnDeleteDoubleList.Name = "btnDeleteDoubleList"
        btnDeleteDoubleList.Size = New Size(82, 22)
        btnDeleteDoubleList.TabIndex = 20
        btnDeleteDoubleList.Text = "Delete"
        btnDeleteDoubleList.UseVisualStyleBackColor = True
        ' 
        ' txtDataDoubleList
        ' 
        txtDataDoubleList.Location = New Point(432, 110)
        txtDataDoubleList.Margin = New Padding(3, 2, 3, 2)
        txtDataDoubleList.Name = "txtDataDoubleList"
        txtDataDoubleList.Size = New Size(110, 23)
        txtDataDoubleList.TabIndex = 16
        ' 
        ' btnAggDoubleList
        ' 
        btnAggDoubleList.Location = New Point(432, 142)
        btnAggDoubleList.Margin = New Padding(3, 2, 3, 2)
        btnAggDoubleList.Name = "btnAggDoubleList"
        btnAggDoubleList.Size = New Size(82, 22)
        btnAggDoubleList.TabIndex = 19
        btnAggDoubleList.Text = "Agg"
        btnAggDoubleList.UseVisualStyleBackColor = True
        ' 
        ' lvDisplayDoubleList
        ' 
        lvDisplayDoubleList.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lvDisplayDoubleList.Location = New Point(195, 62)
        lvDisplayDoubleList.Margin = New Padding(3, 2, 3, 2)
        lvDisplayDoubleList.Name = "lvDisplayDoubleList"
        lvDisplayDoubleList.Size = New Size(193, 161)
        lvDisplayDoubleList.TabIndex = 18
        lvDisplayDoubleList.UseCompatibleStateImageBehavior = False
        lvDisplayDoubleList.View = View.Details
        ' 
        ' tabPage4
        ' 
        tabPage4.Controls.Add(btnContainsDoubleCircularList)
        tabPage4.Controls.Add(btnRemoveDoubleCircularList)
        tabPage4.Controls.Add(btnAddDoubleCircularList)
        tabPage4.Controls.Add(txtNumberDoubleCircularList)
        tabPage4.Controls.Add(label7)
        tabPage4.Location = New Point(4, 24)
        tabPage4.Margin = New Padding(3, 2, 3, 2)
        tabPage4.Name = "tabPage4"
        tabPage4.Padding = New Padding(3, 2, 3, 2)
        tabPage4.Size = New Size(710, 276)
        tabPage4.TabIndex = 3
        tabPage4.Text = "Double Circulars"
        tabPage4.UseVisualStyleBackColor = True
        ' 
        ' btnContainsDoubleCircularList
        ' 
        btnContainsDoubleCircularList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnContainsDoubleCircularList.Location = New Point(485, 164)
        btnContainsDoubleCircularList.Name = "btnContainsDoubleCircularList"
        btnContainsDoubleCircularList.Size = New Size(97, 37)
        btnContainsDoubleCircularList.TabIndex = 9
        btnContainsDoubleCircularList.Text = "Contains"
        btnContainsDoubleCircularList.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveDoubleCircularList
        ' 
        btnRemoveDoubleCircularList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemoveDoubleCircularList.Location = New Point(485, 122)
        btnRemoveDoubleCircularList.Name = "btnRemoveDoubleCircularList"
        btnRemoveDoubleCircularList.Size = New Size(97, 37)
        btnRemoveDoubleCircularList.TabIndex = 8
        btnRemoveDoubleCircularList.Text = "Remove"
        btnRemoveDoubleCircularList.UseVisualStyleBackColor = True
        ' 
        ' btnAddDoubleCircularList
        ' 
        btnAddDoubleCircularList.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddDoubleCircularList.Location = New Point(485, 78)
        btnAddDoubleCircularList.Name = "btnAddDoubleCircularList"
        btnAddDoubleCircularList.Size = New Size(97, 37)
        btnAddDoubleCircularList.TabIndex = 7
        btnAddDoubleCircularList.Text = "Add"
        btnAddDoubleCircularList.UseVisualStyleBackColor = True
        ' 
        ' txtNumberDoubleCircularList
        ' 
        txtNumberDoubleCircularList.Location = New Point(206, 104)
        txtNumberDoubleCircularList.Name = "txtNumberDoubleCircularList"
        txtNumberDoubleCircularList.Size = New Size(199, 23)
        txtNumberDoubleCircularList.TabIndex = 6
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label7.Location = New Point(133, 107)
        label7.Name = "label7"
        label7.Size = New Size(71, 21)
        label7.TabIndex = 5
        label7.Text = "Number:"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(152, 227)
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
        label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(12, 17)
        label2.Name = "label2"
        label2.Size = New Size(74, 37)
        label2.TabIndex = 5
        label2.Text = "Lists"
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(12, 69)
        label1.Name = "label1"
        label1.Size = New Size(402, 135)
        label1.TabIndex = 4
        label1.Text = resources.GetString("label1.Text")
        ' 
        ' Lists
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1239, 382)
        Controls.Add(tabControl)
        Controls.Add(btnBack)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Lists"
        Text = "Lists"
        tabControl.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        tabPage3.ResumeLayout(False)
        tabPage3.PerformLayout()
        tabPage4.ResumeLayout(False)
        tabPage4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents tabControl As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents txtZipCode As TextBox
    Private WithEvents label4 As Label
    Private WithEvents btnCountSingleList As Button
    Private WithEvents txtPhoneNumber As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtName As TextBox
    Private WithEvents label5 As Label
    Private WithEvents btnRemoveSingleList As Button
    Private WithEvents btnContainsSingleList As Button
    Private WithEvents btnAddSingleList As Button
    Private WithEvents txtValue As TextBox
    Private WithEvents label6 As Label
    Private WithEvents tabPage2 As TabPage
    Private WithEvents btnContainsCircularsLists As Button
    Private WithEvents lstNodes As ListBox
    Private WithEvents btnCountCircularsLists As Button
    Private WithEvents lblValue As Label
    Private WithEvents btnRemoveCircularsLists As Button
    Private WithEvents txtValueCircularList As TextBox
    Private WithEvents btnAddCircularsLists As Button
    Private WithEvents tabPage3 As TabPage
    Private WithEvents btnSearchDoubleList As Button
    Private WithEvents lblData As Label
    Private WithEvents btnDeleteDoubleList As Button
    Private WithEvents txtDataDoubleList As TextBox
    Private WithEvents btnAggDoubleList As Button
    Private WithEvents lvDisplayDoubleList As ListView
    Private WithEvents tabPage4 As TabPage
    Private WithEvents btnContainsDoubleCircularList As Button
    Private WithEvents btnRemoveDoubleCircularList As Button
    Private WithEvents btnAddDoubleCircularList As Button
    Private WithEvents txtNumberDoubleCircularList As TextBox
    Private WithEvents label7 As Label
    Private WithEvents btnBack As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
