<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlgorithmsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlgorithmsForm))
        label1 = New Label()
        label2 = New Label()
        btnSorting = New Button()
        btnSearch = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(196, 35)
        label1.Name = "label1"
        label1.Size = New Size(161, 37)
        label1.TabIndex = 4
        label1.Text = "Algorithms"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(86, 92)
        label2.Name = "label2"
        label2.Size = New Size(420, 45)
        label2.TabIndex = 5
        label2.Text = resources.GetString("label2.Text")
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSorting
        ' 
        btnSorting.Location = New Point(155, 169)
        btnSorting.Margin = New Padding(3, 2, 3, 2)
        btnSorting.Name = "btnSorting"
        btnSorting.Size = New Size(82, 22)
        btnSorting.TabIndex = 6
        btnSorting.Text = "Sorting"
        btnSorting.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(300, 169)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(82, 22)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(223, 220)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' AlgorithmsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(623, 308)
        Controls.Add(btnBack)
        Controls.Add(btnSearch)
        Controls.Add(btnSorting)
        Controls.Add(label2)
        Controls.Add(label1)
        Name = "AlgorithmsForm"
        Text = "AlgorithmsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnSorting As Button
    Private WithEvents btnSearch As Button
    Private WithEvents btnBack As Button
End Class
