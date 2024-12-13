<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        label1 = New Label()
        btnExit = New Button()
        btnAlgorithms = New Button()
        btnDataStructures = New Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(175, 60)
        label1.Name = "label1"
        label1.Size = New Size(186, 64)
        label1.TabIndex = 7
        label1.Text = "Data Structure " & vbCrLf & "Final Project"
        label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(223, 220)
        btnExit.Margin = New Padding(3, 2, 3, 2)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(82, 22)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnAlgorithms
        ' 
        btnAlgorithms.Location = New Point(318, 144)
        btnAlgorithms.Margin = New Padding(3, 2, 3, 2)
        btnAlgorithms.Name = "btnAlgorithms"
        btnAlgorithms.Size = New Size(82, 53)
        btnAlgorithms.TabIndex = 5
        btnAlgorithms.Text = "Algorithms"
        btnAlgorithms.UseVisualStyleBackColor = True
        ' 
        ' btnDataStructures
        ' 
        btnDataStructures.Location = New Point(130, 144)
        btnDataStructures.Margin = New Padding(3, 2, 3, 2)
        btnDataStructures.Name = "btnDataStructures"
        btnDataStructures.Size = New Size(88, 53)
        btnDataStructures.TabIndex = 4
        btnDataStructures.Text = "Data" & vbCrLf & "Structures"
        btnDataStructures.UseVisualStyleBackColor = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(569, 347)
        Controls.Add(label1)
        Controls.Add(btnExit)
        Controls.Add(btnAlgorithms)
        Controls.Add(btnDataStructures)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label1 As Label
    Private WithEvents btnExit As Button
    Private WithEvents btnAlgorithms As Button
    Private WithEvents btnDataStructures As Button

End Class
