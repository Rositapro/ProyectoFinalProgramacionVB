<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAlgorithmsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchAlgorithmsForm))
        tabControl1 = New TabControl()
        tabPage1 = New TabPage()
        label3 = New Label()
        tabPage2 = New TabPage()
        label4 = New Label()
        tabPage3 = New TabPage()
        label5 = New Label()
        label2 = New Label()
        label1 = New Label()
        btnBack = New Button()
        tabControl1.SuspendLayout()
        tabPage1.SuspendLayout()
        tabPage2.SuspendLayout()
        tabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tabControl1
        ' 
        tabControl1.Controls.Add(tabPage1)
        tabControl1.Controls.Add(tabPage2)
        tabControl1.Controls.Add(tabPage3)
        tabControl1.Location = New Point(30, 131)
        tabControl1.Margin = New Padding(3, 2, 3, 2)
        tabControl1.Name = "tabControl1"
        tabControl1.SelectedIndex = 0
        tabControl1.Size = New Size(679, 182)
        tabControl1.TabIndex = 7
        ' 
        ' tabPage1
        ' 
        tabPage1.Controls.Add(label3)
        tabPage1.Location = New Point(4, 24)
        tabPage1.Margin = New Padding(3, 2, 3, 2)
        tabPage1.Name = "tabPage1"
        tabPage1.Padding = New Padding(3, 2, 3, 2)
        tabPage1.Size = New Size(671, 154)
        tabPage1.TabIndex = 0
        tabPage1.Text = "Sequential search (arrays)"
        tabPage1.UseVisualStyleBackColor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(126, 40)
        label3.Name = "label3"
        label3.Size = New Size(389, 60)
        label3.TabIndex = 0
        label3.Text = resources.GetString("label3.Text")
        ' 
        ' tabPage2
        ' 
        tabPage2.Controls.Add(label4)
        tabPage2.Location = New Point(4, 24)
        tabPage2.Margin = New Padding(3, 2, 3, 2)
        tabPage2.Name = "tabPage2"
        tabPage2.Padding = New Padding(3, 2, 3, 2)
        tabPage2.Size = New Size(671, 154)
        tabPage2.TabIndex = 1
        tabPage2.Text = "Sequential search (lists)"
        tabPage2.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(106, 51)
        label4.Name = "label4"
        label4.Size = New Size(421, 45)
        label4.TabIndex = 0
        label4.Text = resources.GetString("label4.Text")
        ' 
        ' tabPage3
        ' 
        tabPage3.Controls.Add(label5)
        tabPage3.Location = New Point(4, 24)
        tabPage3.Margin = New Padding(3, 2, 3, 2)
        tabPage3.Name = "tabPage3"
        tabPage3.Padding = New Padding(3, 2, 3, 2)
        tabPage3.Size = New Size(671, 154)
        tabPage3.TabIndex = 2
        tabPage3.Text = "Binary Search"
        tabPage3.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(23, 38)
        label5.Name = "label5"
        label5.Size = New Size(570, 75)
        label5.TabIndex = 1
        label5.Text = resources.GetString("label5.Text")
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(30, 83)
        label2.Name = "label2"
        label2.Size = New Size(549, 45)
        label2.TabIndex = 6
        label2.Text = resources.GetString("label2.Text")
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(30, 34)
        label1.Name = "label1"
        label1.Size = New Size(246, 37)
        label1.TabIndex = 5
        label1.Text = "SearchAlgorithms"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(310, 327)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' SearchAlgorithmsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tabControl1)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnBack)
        Name = "SearchAlgorithmsForm"
        Text = "SearchAlgorithmsForm"
        tabControl1.ResumeLayout(False)
        tabPage1.ResumeLayout(False)
        tabPage1.PerformLayout()
        tabPage2.ResumeLayout(False)
        tabPage2.PerformLayout()
        tabPage3.ResumeLayout(False)
        tabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents tabControl1 As TabControl
    Private WithEvents tabPage1 As TabPage
    Private WithEvents label3 As Label
    Private WithEvents tabPage2 As TabPage
    Private WithEvents label4 As Label
    Private WithEvents tabPage3 As TabPage
    Private WithEvents label5 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnBack As Button
End Class
