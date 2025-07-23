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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' TextHand1
        ' 
        TextHand1.Location = New Point(156, 99)
        TextHand1.Name = "TextHand1"
        TextHand1.Size = New Size(180, 31)
        TextHand1.TabIndex = 0
        ' 
        ' TextHand2
        ' 
        TextHand2.Location = New Point(156, 167)
        TextHand2.Name = "TextHand2"
        TextHand2.Size = New Size(180, 31)
        TextHand2.TabIndex = 1
        ' 
        ' TextHand3
        ' 
        TextHand3.Location = New Point(156, 235)
        TextHand3.Name = "TextHand3"
        TextHand3.Size = New Size(180, 31)
        TextHand3.TabIndex = 2
        ' 
        ' TextHand4
        ' 
        TextHand4.Location = New Point(156, 303)
        TextHand4.Name = "TextHand4"
        TextHand4.Size = New Size(180, 31)
        TextHand4.TabIndex = 3
        ' 
        ' TextHand5
        ' 
        TextHand5.Location = New Point(156, 371)
        TextHand5.Name = "TextHand5"
        TextHand5.Size = New Size(180, 31)
        TextHand5.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(510, 235)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(119, 32)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 6
        Label1.Text = "Player 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 25)
        Label2.TabIndex = 7
        Label2.Text = "Player 2:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(72, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 8
        Label3.Text = "Player 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(72, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 25)
        Label4.TabIndex = 9
        Label4.Text = "Player 4:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(72, 377)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 25)
        Label5.TabIndex = 10
        Label5.Text = "Player 5:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(300, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 25)
        Label6.TabIndex = 11
        Label6.Text = "Please insert your hand!"
        ' 
        ' PokerForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
