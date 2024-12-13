<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataStructuresForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataStructuresForm))
        label2 = New Label()
        btnLinear = New Button()
        btnBack = New Button()
        btnNonLinear = New Button()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(40, 109)
        label2.Name = "label2"
        label2.Size = New Size(530, 120)
        label2.TabIndex = 7
        label2.Text = resources.GetString("label2.Text")
        label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLinear
        ' 
        btnLinear.Location = New Point(129, 257)
        btnLinear.Margin = New Padding(3, 2, 3, 2)
        btnLinear.Name = "btnLinear"
        btnLinear.Size = New Size(82, 22)
        btnLinear.TabIndex = 8
        btnLinear.Text = "Linear"
        btnLinear.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(241, 291)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 22)
        btnBack.TabIndex = 9
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnNonLinear
        ' 
        btnNonLinear.Location = New Point(351, 257)
        btnNonLinear.Margin = New Padding(3, 2, 3, 2)
        btnNonLinear.Name = "btnNonLinear"
        btnNonLinear.Size = New Size(82, 22)
        btnNonLinear.TabIndex = 10
        btnNonLinear.Text = "Non Linear"
        btnNonLinear.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(187, 48)
        label1.Name = "label1"
        label1.Size = New Size(215, 37)
        label1.TabIndex = 11
        label1.Text = "Data Structures"
        ' 
        ' DataStructuresForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(610, 339)
        Controls.Add(label1)
        Controls.Add(btnNonLinear)
        Controls.Add(btnBack)
        Controls.Add(btnLinear)
        Controls.Add(label2)
        Name = "DataStructuresForm"
        Text = "DataStructuresForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents label2 As Label
    Private WithEvents btnLinear As Button
    Private WithEvents btnBack As Button
    Private WithEvents btnNonLinear As Button
    Private WithEvents label1 As Label
End Class
