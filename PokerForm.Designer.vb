<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextHand1 = New TextBox()
        TextHand2 = New TextBox()
        TextHand3 = New TextBox()
        TextHand4 = New TextBox()
        TextHand5 = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' TextHand1
        ' 
        TextHand1.Location = New Point(303, 91)
        TextHand1.Name = "TextHand1"
        TextHand1.Size = New Size(150, 31)
        TextHand1.TabIndex = 0
        ' 
        ' TextHand2
        ' 
        TextHand2.Location = New Point(303, 159)
        TextHand2.Name = "TextHand2"
        TextHand2.Size = New Size(150, 31)
        TextHand2.TabIndex = 1
        ' 
        ' TextHand3
        ' 
        TextHand3.Location = New Point(303, 232)
        TextHand3.Name = "TextHand3"
        TextHand3.Size = New Size(150, 31)
        TextHand3.TabIndex = 2
        ' 
        ' TextHand4
        ' 
        TextHand4.Location = New Point(303, 299)
        TextHand4.Name = "TextHand4"
        TextHand4.Size = New Size(150, 31)
        TextHand4.TabIndex = 3
        ' 
        ' TextHand5
        ' 
        TextHand5.Location = New Point(303, 365)
        TextHand5.Name = "TextHand5"
        TextHand5.Size = New Size(150, 31)
        TextHand5.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(596, 94)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(112, 34)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' PokerForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEvaluate)
        Controls.Add(TextHand5)
        Controls.Add(TextHand4)
        Controls.Add(TextHand3)
        Controls.Add(TextHand2)
        Controls.Add(TextHand1)
        Name = "PokerForm"
        Text = "PokerForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextHand1 As TextBox
    Friend WithEvents TextHand2 As TextBox
    Friend WithEvents TextHand3 As TextBox
    Friend WithEvents TextHand4 As TextBox
    Friend WithEvents TextHand5 As TextBox
    Friend WithEvents btnEvaluate As Button
End Class
