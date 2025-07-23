<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnConverter = New Button()
        btnPoker = New Button()
        Label1 = New Label()
        btnPalindrome = New Button()
        SuspendLayout()
        ' 
        ' btnConverter
        ' 
        btnConverter.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnConverter.Font = New Font("Segoe UI", 9.0F)
        btnConverter.Location = New Point(145, 179)
        btnConverter.Name = "btnConverter"
        btnConverter.Size = New Size(138, 75)
        btnConverter.TabIndex = 0
        btnConverter.Text = "Amount Converter"
        btnConverter.UseVisualStyleBackColor = True
        ' 
        ' btnPoker
        ' 
        btnPoker.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnPoker.Font = New Font("Segoe UI", 9.0F)
        btnPoker.Location = New Point(331, 310)
        btnPoker.Name = "btnPoker"
        btnPoker.Size = New Size(138, 75)
        btnPoker.TabIndex = 1
        btnPoker.Text = "Poker Hand"
        btnPoker.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold Or FontStyle.Underline)
        Label1.Location = New Point(278, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 32)
        Label1.TabIndex = 2
        Label1.Text = "Spinutech Code Test"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnPalindrome
        ' 
        btnPalindrome.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnPalindrome.Font = New Font("Segoe UI", 9.0F)
        btnPalindrome.Location = New Point(519, 179)
        btnPalindrome.Name = "btnPalindrome"
        btnPalindrome.Size = New Size(138, 75)
        btnPalindrome.TabIndex = 3
        btnPalindrome.Text = "Check Palindrome"
        btnPalindrome.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnPalindrome)
        Controls.Add(Label1)
        Controls.Add(btnPoker)
        Controls.Add(btnConverter)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Underline)
        Name = "Form1"
        Text = "Spinutech"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConverter As Button
    Friend WithEvents btnPoker As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPalindrome As Button

End Class
