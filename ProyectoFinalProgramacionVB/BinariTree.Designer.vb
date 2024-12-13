<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinariTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BinariTree))
        label3 = New Label()
        txtResultado = New TextBox()
        txtValorNodo = New TextBox()
        pnlArbol = New Panel()
        label2 = New Label()
        label1 = New Label()
        btnAgregarBinariTreeNode = New Button()
        btnInorden = New Button()
        btnPreorden = New Button()
        btnPostorden = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Location = New Point(669, 15)
        label3.Name = "label3"
        label3.Size = New Size(35, 15)
        label3.TabIndex = 28
        label3.Text = "Value"
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(669, 193)
        txtResultado.Margin = New Padding(3, 2, 3, 2)
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(110, 23)
        txtResultado.TabIndex = 27
        ' 
        ' txtValorNodo
        ' 
        txtValorNodo.Location = New Point(669, 38)
        txtValorNodo.Margin = New Padding(3, 2, 3, 2)
        txtValorNodo.Name = "txtValorNodo"
        txtValorNodo.Size = New Size(110, 23)
        txtValorNodo.TabIndex = 26
        ' 
        ' pnlArbol
        ' 
        pnlArbol.Location = New Point(822, 15)
        pnlArbol.Margin = New Padding(3, 2, 3, 2)
        pnlArbol.Name = "pnlArbol"
        pnlArbol.Size = New Size(381, 226)
        pnlArbol.TabIndex = 25
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(24, 55)
        label2.Name = "label2"
        label2.Size = New Size(502, 150)
        label2.TabIndex = 24
        label2.Text = resources.GetString("label2.Text")
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(16, 15)
        label1.Name = "label1"
        label1.Size = New Size(154, 37)
        label1.TabIndex = 23
        label1.Text = "Binari Tree"
        ' 
        ' btnAgregarBinariTreeNode
        ' 
        btnAgregarBinariTreeNode.Location = New Point(669, 78)
        btnAgregarBinariTreeNode.Margin = New Padding(3, 2, 3, 2)
        btnAgregarBinariTreeNode.Name = "btnAgregarBinariTreeNode"
        btnAgregarBinariTreeNode.Size = New Size(82, 22)
        btnAgregarBinariTreeNode.TabIndex = 22
        btnAgregarBinariTreeNode.Text = "Agg"
        btnAgregarBinariTreeNode.UseVisualStyleBackColor = True
        ' 
        ' btnInorden
        ' 
        btnInorden.Location = New Point(669, 104)
        btnInorden.Margin = New Padding(3, 2, 3, 2)
        btnInorden.Name = "btnInorden"
        btnInorden.Size = New Size(82, 22)
        btnInorden.TabIndex = 21
        btnInorden.Text = "Inorden"
        btnInorden.UseVisualStyleBackColor = True
        ' 
        ' btnPreorden
        ' 
        btnPreorden.Location = New Point(669, 131)
        btnPreorden.Margin = New Padding(3, 2, 3, 2)
        btnPreorden.Name = "btnPreorden"
        btnPreorden.Size = New Size(82, 22)
        btnPreorden.TabIndex = 20
        btnPreorden.Text = "Preorden"
        btnPreorden.UseVisualStyleBackColor = True
        ' 
        ' btnPostorden
        ' 
        btnPostorden.Location = New Point(669, 157)
        btnPostorden.Margin = New Padding(3, 2, 3, 2)
        btnPostorden.Name = "btnPostorden"
        btnPostorden.Size = New Size(82, 22)
        btnPostorden.TabIndex = 19
        btnPostorden.Text = "Postorden"
        btnPostorden.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(43, 228)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 18
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' BinariTree
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1241, 388)
        Controls.Add(label3)
        Controls.Add(txtResultado)
        Controls.Add(txtValorNodo)
        Controls.Add(pnlArbol)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnAgregarBinariTreeNode)
        Controls.Add(btnInorden)
        Controls.Add(btnPreorden)
        Controls.Add(btnPostorden)
        Controls.Add(btnBack)
        Name = "BinariTree"
        Text = "BinariTree"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label3 As Label
    Private WithEvents txtResultado As TextBox
    Private WithEvents txtValorNodo As TextBox
    Private WithEvents pnlArbol As Panel
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnAgregarBinariTreeNode As Button
    Private WithEvents btnInorden As Button
    Private WithEvents btnPreorden As Button
    Private WithEvents btnPostorden As Button
    Private WithEvents btnBack As Button
End Class
