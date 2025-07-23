Public Class Form1
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnConverter.Click
        Dim strtype As String = "amount"
        Dim strValidInput As String
        strValidInput = InputValidation(strtype)

        If strValidInput = "0" Then
            MsgBox("The amount is: Zero dollars")
        ElseIf strValidInput = "" Then
            MsgBox("Process cancelled.")
        Else
            MsgBox("Process started...")

            Dim strTextResult As String = AmountToWords(strValidInput)

            MsgBox("The amount is: " & vbCrLf & strTextResult)
        End If
    End Sub

    Private Shared Function InputValidation(strType As String) As String
        Dim strUserInput As String
        Dim booValidInput As Boolean = False

        Do
            strUserInput = InputBox("Please enter the " & strType & ":", "Input Required")
            If String.IsNullOrWhiteSpace(strUserInput) Then
                MessageBox.Show("Input is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Not IsNumeric(strUserInput) Then
                MessageBox.Show("Input must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf DialogResult.Cancel Then
                Return ""
            Else
                booValidInput = True
            End If

        Loop Until booValidInput Or DialogResult.Cancel

        Return strUserInput
    End Function

    Function AmountToWords(decAmount As Decimal) As String
        Dim strParts() As String = decAmount.ToString("F2").Split("."c)
        Dim integerPart As Long = Convert.ToInt64(strParts(0))
        Dim strDecimalPart As String = strParts(1)

        Dim strWords As String = NumberToWords(integerPart)

        Return strWords & " and " & strDecimalPart & "/100 dollars"
    End Function

    Function NumberToWords(number As Long) As String
        If number = 0 Then Return "Zero"

        Dim strTextNumber As String = ""

        Dim billions As Long = number \ 1000000000
        If billions > 0 Then
            strTextNumber &= ThreeDigitToWords(billions) & " billion "
            number = number Mod 1000000000
        End If

        Dim millions As Long = number \ 1000000
        If millions > 0 Then
            strTextNumber &= ThreeDigitToWords(millions) & " million "
            number = number Mod 1000000
        End If

        Dim thousands As Long = number \ 1000
        If thousands > 0 Then
            strTextNumber &= ThreeDigitToWords(thousands) & " thousand "
            number = number Mod 1000
        End If

        If number > 0 Then
            strTextNumber &= ThreeDigitToWords(number)
        End If

        Return strTextNumber.Trim()
    End Function

    Function ThreeDigitToWords(intNumber As Integer) As String
        Dim strResult As String = ""

        Dim intHundreds As Integer = intNumber \ 100
        If intHundreds > 0 Then
            strResult &= UnitToText(intHundreds) & " hundred "
            intNumber = intNumber Mod 100
        End If

        If intNumber > 0 Then
            If intNumber < 20 Then
                strResult &= UnitToText(intNumber)
            Else
                Dim intTens As Integer = intNumber \ 10
                Dim intUnits As Integer = intNumber Mod 10
                strResult &= TensToText(intTens)
                If intUnits > 0 Then
                    strResult &= "-" & UnitToText(intUnits)
                End If
            End If
        End If

        Return strResult.Trim()
    End Function

    Function UnitToText(unit As Integer) As String
        Select Case unit
            Case 1 : Return "One"
            Case 2 : Return "Two"
            Case 3 : Return "Three"
            Case 4 : Return "Four"
            Case 5 : Return "Five"
            Case 6 : Return "Six"
            Case 7 : Return "Seven"
            Case 8 : Return "Eight"
            Case 9 : Return "Nine"
            Case 10 : Return "Ten"
            Case 11 : Return "Eleven"
            Case 12 : Return "Twelve"
            Case 13 : Return "Thirteen"
            Case 14 : Return "Fourteen"
            Case 15 : Return "Fifteen"
            Case 16 : Return "Sixteen"
            Case 17 : Return "Seventeen"
            Case 18 : Return "Eighteen"
            Case 19 : Return "Nineteen"
            Case Else : Return ""
        End Select
    End Function

    Function TensToText(tens As Integer) As String
        Select Case tens
            Case 2 : Return "Twenty"
            Case 3 : Return "Thirty"
            Case 4 : Return "Forty"
            Case 5 : Return "Fifty"
            Case 6 : Return "Sixty"
            Case 7 : Return "Seventy"
            Case 8 : Return "Eighty"
            Case 9 : Return "Ninety"
            Case Else : Return ""
        End Select
    End Function

    Private Sub btnPalindrome_Click(sender As Object, e As EventArgs) Handles btnPalindrome.Click
        Dim strtype As String = "number"
        Dim strValidInput As String
        Dim intNumber As Long

        strValidInput = InputValidation(strtype)

        If strValidInput = "" Then
            MsgBox("Process cancelled.")
        Else
            intNumber = Convert.ToInt64(strValidInput)

            If intNumber < 0 Then
                MsgBox("Please enter a non-negative integer.")
                Return
            End If

            If IsPalindrome(intNumber) Then
                MsgBox(intNumber & " is a palindrome.")
            Else
                MsgBox(intNumber & " is not a palindrome.")
            End If
        End If
    End Sub

    Function IsPalindrome(number As Long) As Boolean
        Dim original As String = number.ToString()

        Dim reversed As String = StrReverse(original)

        Return original = reversed
    End Function

    Private Sub btnPoker_Click(sender As Object, e As EventArgs) Handles btnPoker.Click
        Dim frmNewForm As New PokerForm()
        frmNewForm.Show()
    End Sub

End Class
