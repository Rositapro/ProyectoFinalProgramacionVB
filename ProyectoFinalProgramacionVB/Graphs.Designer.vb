<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graphs
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
        btnRemoveAll = New Button()
        btnShowDFSRecursive = New Button()
        label6 = New Label()
        btnShowBFS = New Button()
        btnRemoveNode = New Button()
        txtStartNode = New TextBox()
        btnShowDFS = New Button()
        chkDirected = New CheckBox()
        label5 = New Label()
        txtWeight = New TextBox()
        txtGraphRepresentation = New TextBox()
        btnRemoveEdge = New Button()
        btnAddEdge = New Button()
        label4 = New Label()
        txtTo = New TextBox()
        label3 = New Label()
        txtFrom = New TextBox()
        label7 = New Label()
        txtNode = New TextBox()
        btnAddNode = New Button()
        btnBack = New Button()
        label2 = New Label()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' btnRemoveAll
        ' 
        btnRemoveAll.Location = New Point(926, 36)
        btnRemoveAll.Name = "btnRemoveAll"
        btnRemoveAll.Size = New Size(84, 23)
        btnRemoveAll.TabIndex = 67
        btnRemoveAll.Text = "Remove All"
        btnRemoveAll.UseVisualStyleBackColor = True
        ' 
        ' btnShowDFSRecursive
        ' 
        btnShowDFSRecursive.Location = New Point(607, 258)
        btnShowDFSRecursive.Name = "btnShowDFSRecursive"
        btnShowDFSRecursive.Size = New Size(75, 39)
        btnShowDFSRecursive.TabIndex = 66
        btnShowDFSRecursive.Text = "Show DFS Recursive Algorithm"
        btnShowDFSRecursive.UseVisualStyleBackColor = True
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Location = New Point(455, 229)
        label6.Name = "label6"
        label6.Size = New Size(66, 15)
        label6.TabIndex = 65
        label6.Text = "Node Start:"
        ' 
        ' btnShowBFS
        ' 
        btnShowBFS.Location = New Point(444, 258)
        btnShowBFS.Name = "btnShowBFS"
        btnShowBFS.Size = New Size(75, 39)
        btnShowBFS.TabIndex = 64
        btnShowBFS.Text = "Show BFS Algorithm"
        btnShowBFS.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveNode
        ' 
        btnRemoveNode.Location = New Point(832, 35)
        btnRemoveNode.Name = "btnRemoveNode"
        btnRemoveNode.Size = New Size(75, 23)
        btnRemoveNode.TabIndex = 63
        btnRemoveNode.Text = "Remove"
        btnRemoveNode.UseVisualStyleBackColor = True
        ' 
        ' txtStartNode
        ' 
        txtStartNode.Location = New Point(533, 229)
        txtStartNode.Name = "txtStartNode"
        txtStartNode.Size = New Size(104, 23)
        txtStartNode.TabIndex = 62
        ' 
        ' btnShowDFS
        ' 
        btnShowDFS.Location = New Point(526, 258)
        btnShowDFS.Name = "btnShowDFS"
        btnShowDFS.Size = New Size(75, 39)
        btnShowDFS.TabIndex = 61
        btnShowDFS.Text = "Show DFS Algorithm"
        btnShowDFS.UseVisualStyleBackColor = True
        ' 
        ' chkDirected
        ' 
        chkDirected.AutoSize = True
        chkDirected.Location = New Point(451, 200)
        chkDirected.Name = "chkDirected"
        chkDirected.Size = New Size(70, 19)
        chkDirected.TabIndex = 60
        chkDirected.Text = "Directed"
        chkDirected.UseVisualStyleBackColor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Location = New Point(444, 158)
        label5.Name = "label5"
        label5.Size = New Size(48, 15)
        label5.TabIndex = 59
        label5.Text = "Weight:"
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(525, 158)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(104, 23)
        txtWeight.TabIndex = 58
        ' 
        ' txtGraphRepresentation
        ' 
        txtGraphRepresentation.Font = New Font("Yu Gothic Medium", 11F)
        txtGraphRepresentation.Location = New Point(739, 64)
        txtGraphRepresentation.Multiline = True
        txtGraphRepresentation.Name = "txtGraphRepresentation"
        txtGraphRepresentation.Size = New Size(362, 202)
        txtGraphRepresentation.TabIndex = 57
        ' 
        ' btnRemoveEdge
        ' 
        btnRemoveEdge.Location = New Point(650, 115)
        btnRemoveEdge.Name = "btnRemoveEdge"
        btnRemoveEdge.Size = New Size(75, 39)
        btnRemoveEdge.TabIndex = 56
        btnRemoveEdge.Text = "Remove Edge"
        btnRemoveEdge.UseVisualStyleBackColor = True
        ' 
        ' btnAddEdge
        ' 
        btnAddEdge.Location = New Point(650, 77)
        btnAddEdge.Name = "btnAddEdge"
        btnAddEdge.Size = New Size(75, 23)
        btnAddEdge.TabIndex = 55
        btnAddEdge.Text = "Add Edge"
        btnAddEdge.UseVisualStyleBackColor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Location = New Point(447, 115)
        label4.Name = "label4"
        label4.Size = New Size(53, 15)
        label4.TabIndex = 54
        label4.Text = "Node to:"
        ' 
        ' txtTo
        ' 
        txtTo.Location = New Point(525, 115)
        txtTo.Name = "txtTo"
        txtTo.Size = New Size(104, 23)
        txtTo.TabIndex = 53
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(444, 77)
        label3.Name = "label3"
        label3.Size = New Size(70, 15)
        label3.TabIndex = 52
        label3.Text = "Node From:"
        ' 
        ' txtFrom
        ' 
        txtFrom.Location = New Point(525, 77)
        txtFrom.Name = "txtFrom"
        txtFrom.Size = New Size(104, 23)
        txtFrom.TabIndex = 51
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Location = New Point(447, 39)
        label7.Name = "label7"
        label7.Size = New Size(74, 15)
        label7.TabIndex = 50
        label7.Text = "Node Name:"
        ' 
        ' txtNode
        ' 
        txtNode.Location = New Point(526, 36)
        txtNode.Name = "txtNode"
        txtNode.Size = New Size(180, 23)
        txtNode.TabIndex = 49
        ' 
        ' btnAddNode
        ' 
        btnAddNode.Location = New Point(739, 33)
        btnAddNode.Name = "btnAddNode"
        btnAddNode.Size = New Size(75, 23)
        btnAddNode.TabIndex = 48
        btnAddNode.Text = "Add Node"
        btnAddNode.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(171, 205)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 47
        btnBack.Text = "back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(11, 79)
        label2.Name = "label2"
        label2.Size = New Size(372, 60)
        label2.TabIndex = 46
        label2.Text = "Graphs are data structures used to model problems " & vbCrLf & "and represent relationships between objects or physical entities." & vbCrLf & vbCrLf & "They consist of a set of nodes or vertices, connected by edges or arcs."
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(11, 24)
        label1.Name = "label1"
        label1.Size = New Size(107, 37)
        label1.TabIndex = 45
        label1.Text = "Graphs"
        ' 
        ' Graph
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1174, 421)
        Controls.Add(btnRemoveAll)
        Controls.Add(btnShowDFSRecursive)
        Controls.Add(label6)
        Controls.Add(btnShowBFS)
        Controls.Add(btnRemoveNode)
        Controls.Add(txtStartNode)
        Controls.Add(btnShowDFS)
        Controls.Add(chkDirected)
        Controls.Add(label5)
        Controls.Add(txtWeight)
        Controls.Add(txtGraphRepresentation)
        Controls.Add(btnRemoveEdge)
        Controls.Add(btnAddEdge)
        Controls.Add(label4)
        Controls.Add(txtTo)
        Controls.Add(label3)
        Controls.Add(txtFrom)
        Controls.Add(label7)
        Controls.Add(txtNode)
        Controls.Add(btnAddNode)
        Controls.Add(btnBack)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "Graph"
        Text = "Graph"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnRemoveAll As Button
    Private WithEvents btnShowDFSRecursive As Button
    Private WithEvents label6 As Label
    Private WithEvents btnShowBFS As Button
    Private WithEvents btnRemoveNode As Button
    Private WithEvents txtStartNode As TextBox
    Private WithEvents btnShowDFS As Button
    Private WithEvents chkDirected As CheckBox
    Private WithEvents label5 As Label
    Private WithEvents txtWeight As TextBox
    Private WithEvents txtGraphRepresentation As TextBox
    Private WithEvents btnRemoveEdge As Button
    Private WithEvents btnAddEdge As Button
    Private WithEvents label4 As Label
    Private WithEvents txtTo As TextBox
    Private WithEvents label3 As Label
    Private WithEvents txtFrom As TextBox
    Private WithEvents label7 As Label
    Private WithEvents txtNode As TextBox
    Private WithEvents btnAddNode As Button
    Private WithEvents btnBack As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
