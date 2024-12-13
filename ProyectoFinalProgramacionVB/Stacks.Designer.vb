<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stacks))
        tabControl1 = New TabControl()
        tabPage1 = New TabPage()
        btnSizeStaticStack = New Button()
        label3 = New Label()
        LblData = New Label()
        btnPeekStaticStack = New Button()
        btnPopStaticStack = New Button()
        btnPushStaticStack = New Button()
        lstStaticStack = New ListBox()
        txtInputStaticStack = New TextBox()
        tabPage2 = New TabPage()
        BtnSizeDynamicStack = New Button()
        label4 = New Label()
        lstDynamicStack = New ListBox()
        btnPeekDynamicStack = New Button()
        btnPopDynamicStack = New Button()
        txtDataDynamicStack = New TextBox()
        btnPushDynamicStack = New Button()
        label2 = New Label()
        label1 = New Label()
        btnBack = New Button()
        tabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Location = New Point(446, 17)
        tabControl1.Margin = New Padding(3, 2, 3, 2)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(773, 307)
        tabControl1.TabIndex = 10
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(btnSizeStaticStack)
        tabPage1.Controls.Add(label3)
        tabPage1.Controls.Add(LblData)
        tabPage1.Controls.Add(btnPeekStaticStack)
        tabPage1.Controls.Add(btnPopStaticStack)
        tabPage1.Controls.Add(btnPushStaticStack)
        tabPage1.Controls.Add(lstStaticStack)
        tabPage1.Controls.Add(txtInputStaticStack)
        tabPage1.Location = New Point(4, 24)
        tabPage1.Margin = New Padding(3, 2, 3, 2)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 2, 3, 2)
        tabPage1.Size = New Size(765, 279)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Static Stack"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnSizeStaticStack
        ' 
        btnSizeStaticStack.Location = New Point(146, 212)
        btnSizeStaticStack.Name = "btnSizeStaticStack"
        btnSizeStaticStack.Size = New Size(76, 40)
        btnSizeStaticStack.TabIndex = 23
        btnSizeStaticStack.Text = "Size"
        btnSizeStaticStack.UseVisualStyleBackColor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(15, 34)
        label3.Name = "label3"
        label3.Size = New Size(74, 15)
        label3.TabIndex = 22
        label3.Text = "data to enter"
        ' 
        ' LblData
        ' 
        LblData.AutoSize = True
        LblData.Location = New Point(396, 4)
        LblData.Name = "LblData"
        LblData.Size = New Size(208, 15)
        LblData.TabIndex = 21
        LblData.Text = "Static stack with a space of 8 elements"
        ' 
        ' btnPeekStaticStack
        ' 
        btnPeekStaticStack.Location = New Point(146, 166)
        btnPeekStaticStack.Name = "btnPeekStaticStack"
        btnPeekStaticStack.Size = New Size(76, 40)
        btnPeekStaticStack.TabIndex = 20
        btnPeekStaticStack.Text = "Peek"
        btnPeekStaticStack.UseVisualStyleBackColor = True
        ' 
        ' btnPopStaticStack
        ' 
        btnPopStaticStack.Location = New Point(146, 117)
        btnPopStaticStack.Name = "btnPopStaticStack"
        btnPopStaticStack.Size = New Size(76, 40)
        btnPopStaticStack.TabIndex = 19
        btnPopStaticStack.Text = "Pop"
        btnPopStaticStack.UseVisualStyleBackColor = True
        ' 
        ' btnPushStaticStack
        ' 
        btnPushStaticStack.Location = New Point(146, 64)
        btnPushStaticStack.Name = "btnPushStaticStack"
        btnPushStaticStack.Size = New Size(76, 40)
        btnPushStaticStack.TabIndex = 18
        btnPushStaticStack.Text = "Push"
        btnPushStaticStack.UseVisualStyleBackColor = True
        ' 
        ' lstStaticStack
        ' 
        lstStaticStack.Font = New Font("Berlin Sans FB", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstStaticStack.FormattingEnabled = True
        lstStaticStack.ItemHeight = 46
        lstStaticStack.Location = New Point(393, 20)
        lstStaticStack.Name = "lstStaticStack"
        lstStaticStack.Size = New Size(319, 188)
        lstStaticStack.TabIndex = 17
        ' 
        ' txtInputStaticStack
        ' 
        txtInputStaticStack.Location = New Point(103, 29)
        txtInputStaticStack.Name = "txtInputStaticStack"
        txtInputStaticStack.Size = New Size(193, 23)
        txtInputStaticStack.TabIndex = 16
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(BtnSizeDynamicStack)
        tabPage2.Controls.Add(label4)
        tabPage2.Controls.Add(lstDynamicStack)
        tabPage2.Controls.Add(btnPeekDynamicStack)
        tabPage2.Controls.Add(btnPopDynamicStack)
        tabPage2.Controls.Add(txtDataDynamicStack)
        tabPage2.Controls.Add(btnPushDynamicStack)
        tabPage2.Location = New Point(4, 24)
        tabPage2.Margin = New Padding(3, 2, 3, 2)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 2, 3, 2)
        tabPage2.Size = New Size(765, 279)
        tabPage2.TabIndex = 1
        tabPage2.Text = "Dynamic stack"
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' BtnSizeDynamicStack
        ' 
        BtnSizeDynamicStack.Location = New Point(146, 212)
        BtnSizeDynamicStack.Name = "BtnSizeDynamicStack"
        BtnSizeDynamicStack.Size = New Size(76, 40)
        BtnSizeDynamicStack.TabIndex = 20
        BtnSizeDynamicStack.Text = "Size"
        BtnSizeDynamicStack.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(15, 34)
        label4.Name = "label4"
        label4.Size = New Size(74, 15)
        label4.TabIndex = 19
        label4.Text = "data to enter"
        ' 
        ' lstDynamicStack
        ' 
        lstDynamicStack.Font = New Font("Berlin Sans FB", 27.75F, FontStyle.Bold)
        lstDynamicStack.FormattingEnabled = True
        lstDynamicStack.ItemHeight = 46
        lstDynamicStack.Location = New Point(393, 20)
        lstDynamicStack.Name = "lstDynamicStack"
        lstDynamicStack.Size = New Size(276, 188)
        lstDynamicStack.TabIndex = 18
        ' 
        ' btnPeekDynamicStack
        ' 
        btnPeekDynamicStack.Location = New Point(146, 166)
        btnPeekDynamicStack.Name = "btnPeekDynamicStack"
        btnPeekDynamicStack.Size = New Size(76, 40)
        btnPeekDynamicStack.TabIndex = 17
        btnPeekDynamicStack.Text = "Peek"
        btnPeekDynamicStack.UseVisualStyleBackColor = True
        ' 
        ' btnPopDynamicStack
        ' 
        btnPopDynamicStack.Location = New Point(146, 117)
        btnPopDynamicStack.Name = "btnPopDynamicStack"
        btnPopDynamicStack.Size = New Size(76, 40)
        btnPopDynamicStack.TabIndex = 16
        btnPopDynamicStack.Text = "Pop"
        btnPopDynamicStack.UseVisualStyleBackColor = True
        ' 
        ' txtDataDynamicStack
        ' 
        txtDataDynamicStack.Location = New Point(103, 29)
        txtDataDynamicStack.Name = "txtDataDynamicStack"
        txtDataDynamicStack.Size = New Size(193, 23)
        txtDataDynamicStack.TabIndex = 15
        ' 
        ' btnPushDynamicStack
        ' 
        btnPushDynamicStack.Location = New Point(146, 64)
        btnPushDynamicStack.Name = "btnPushDynamicStack"
        btnPushDynamicStack.Size = New Size(76, 40)
        btnPushDynamicStack.TabIndex = 14
        btnPushDynamicStack.Text = "Push"
        btnPushDynamicStack.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(12, 68)
        label2.Name = "label2"
        label2.Size = New Size(368, 75)
        label2.TabIndex = 9
        label2.Text = resources.GetString("label2.Text")
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold)
        label1.Location = New Point(12, 17)
        label1.Name = "label1"
        label1.Size = New Size(97, 37)
        label1.TabIndex = 8
        label1.Text = "Stacks"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(135, 204)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Stacks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1258, 394)
        Controls.Add(tabControl1)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnBack)
        Name = "Stacks"
        Text = "Stacks"
        tabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents btnSizeStaticStack As Button
    Private WithEvents label3 As Label
    Private WithEvents LblData As Label
    Private WithEvents btnPeekStaticStack As Button
    Private WithEvents btnPopStaticStack As Button
    Private WithEvents btnPushStaticStack As Button
    Private WithEvents lstStaticStack As ListBox
    Private WithEvents txtInputStaticStack As TextBox
    Private WithEvents tabPage2 As TabPage
    Private WithEvents BtnSizeDynamicStack As Button
    Private WithEvents label4 As Label
    Private WithEvents lstDynamicStack As ListBox
    Private WithEvents btnPeekDynamicStack As Button
    Private WithEvents btnPopDynamicStack As Button
    Private WithEvents txtDataDynamicStack As TextBox
    Private WithEvents btnPushDynamicStack As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnBack As Button
End Class
