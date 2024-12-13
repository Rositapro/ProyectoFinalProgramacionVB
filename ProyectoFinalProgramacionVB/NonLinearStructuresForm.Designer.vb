<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NonLinearStructuresForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NonLinearStructuresForm))
        btnGraphs = New Button()
        btnBinariTree = New Button()
        btnBack = New Button()
        label2 = New Label()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' btnGraphs
        ' 
        btnGraphs.Location = New Point(449, 186)
        btnGraphs.Margin = New Padding(3, 2, 3, 2)
        btnGraphs.Name = "btnGraphs"
        btnGraphs.Size = New Size(82, 43)
        btnGraphs.TabIndex = 13
        btnGraphs.Text = "Graphs"
        btnGraphs.UseVisualStyleBackColor = True
        ' 
        ' btnBinariTree
        ' 
        btnBinariTree.Location = New Point(170, 186)
        btnBinariTree.Margin = New Padding(3, 2, 3, 2)
        btnBinariTree.Name = "btnBinariTree"
        btnBinariTree.Size = New Size(82, 43)
        btnBinariTree.TabIndex = 12
        btnBinariTree.Text = "Binari" & vbCrLf & "Tree"
        btnBinariTree.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(300, 249)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 11
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(52, 98)
        label2.Name = "label2"
        label2.Size = New Size(566, 45)
        label2.TabIndex = 10
        label2.Text = resources.GetString("label2.Text")
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(170, 47)
        label1.Name = "label1"
        label1.Size = New Size(332, 37)
        label1.TabIndex = 9
        label1.Text = "Nonlinear data structure"
        ' 
        ' NonLinearStructuresForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(710, 318)
        Controls.Add(btnGraphs)
        Controls.Add(btnBinariTree)
        Controls.Add(btnBack)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "NonLinearStructuresForm"
        Text = "NonLinearStructuresForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnGraphs As Button
    Private WithEvents btnBinariTree As Button
    Private WithEvents btnBack As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
