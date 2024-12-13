<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinearStructuresForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinearStructuresForm))
        btnBack = New Button()
        btnQueues = New Button()
        btnStacks = New Button()
        btnLists = New Button()
        label2 = New Label()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(284, 238)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnQueues
        ' 
        btnQueues.Location = New Point(458, 162)
        btnQueues.Margin = New Padding(3, 2, 3, 2)
        btnQueues.Name = "btnQueues"
        btnQueues.Size = New Size(82, 22)
        btnQueues.TabIndex = 10
        btnQueues.Text = "Queues"
        btnQueues.UseVisualStyleBackColor = True
        ' 
        ' btnStacks
        ' 
        btnStacks.Location = New Point(284, 162)
        btnStacks.Margin = New Padding(3, 2, 3, 2)
        btnStacks.Name = "btnStacks"
        btnStacks.Size = New Size(82, 22)
        btnStacks.TabIndex = 9
        btnStacks.Text = "Stacks"
        btnStacks.UseVisualStyleBackColor = True
        ' 
        ' btnLists
        ' 
        btnLists.Location = New Point(102, 162)
        btnLists.Margin = New Padding(3, 2, 3, 2)
        btnLists.Name = "btnLists"
        btnLists.Size = New Size(82, 22)
        btnLists.TabIndex = 8
        btnLists.Text = "Lists"
        btnLists.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(33, 89)
        label2.Name = "label2"
        label2.Size = New Size(544, 45)
        label2.TabIndex = 7
        label2.Text = resources.GetString("label2.Text")
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(162, 40)
        label1.Name = "label1"
        label1.Size = New Size(284, 37)
        label1.TabIndex = 6
        label1.Text = "Linear data structure"
        ' 
        ' LinearStructuresForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(675, 320)
        Controls.Add(btnBack)
        Controls.Add(btnQueues)
        Controls.Add(btnStacks)
        Controls.Add(btnLists)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "LinearStructuresForm"
        Text = "LinearStructuresForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnBack As Button
    Private WithEvents btnQueues As Button
    Private WithEvents btnStacks As Button
    Private WithEvents btnLists As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
