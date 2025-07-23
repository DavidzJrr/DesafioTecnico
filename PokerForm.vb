Public Class PokerForm
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click, btnEvaluate.Click
        Dim hands As New List(Of String) From {
            TextHand1.Text.Trim,
            TextHand2.Text.Trim,
            TextHand3.Text.Trim,
            TextHand4.Text.Trim,
            TextHand5.Text.Trim
        }

        For i = 0 To 4
            Dim handEval = EvaluateHand(hands(i))
            MsgBox($"Player {i + 1} has: " & handEval)

        Next
    End Sub

    Function EvaluateHand(strHand As String) As String
        Dim lstCards = strHand.Split(" "c)
        If lstCards.Length <> 5 Then Return "Invalid Hand"

        Dim dicRankOrder As New Dictionary(Of String, Integer) From {
        {"2", 2}, {"3", 3}, {"4", 4}, {"5", 5}, {"6", 6},
        {"7", 7}, {"8", 8}, {"9", 9}, {"10", 10},
        {"J", 11}, {"Q", 12}, {"K", 13}, {"A", 14}
        }

        Dim lstIntRanks As New List(Of Integer)
        Dim lstStrSuits As New List(Of Char)
        Dim dicRankCounts As New Dictionary(Of Integer, Integer)

        For Each strCard In lstCards
            Dim strRank = strCard.Substring(0, strCard.Length - 1).ToUpper()
            Dim strSuit = strCard.Last()

            If Not dicRankOrder.ContainsKey(strRank) Then Return "Invalid Card: " & strCard

            Dim intRank = dicRankOrder(strRank)
            lstIntRanks.Add(intRank)
            lstStrSuits.Add(strSuit)

            If Not dicRankCounts.ContainsKey(intRank) Then dicRankCounts(intRank) = 0
            dicRankCounts(intRank) += 1
        Next

        lstIntRanks.Sort()

        Dim booIsFlush = lstStrSuits.Distinct().Count() = 1
        Dim booIsStraight = False

        If lstIntRanks.Distinct().Count = 5 Then
            Dim intMinRank = lstIntRanks.Min()
            Dim intMaxRank = lstIntRanks.Max()
            booIsStraight = (intMaxRank - intMinRank = 4)

            If lstIntRanks.SequenceEqual({2, 3, 4, 5, 14}) Then
                booIsStraight = True
                lstIntRanks = New List(Of Integer) From {1, 2, 3, 4, 5}
            End If
        End If

        If booIsStraight AndAlso booIsFlush Then
            If lstIntRanks.Max() = 14 Then Return "Royal Flush"
            Return "Straight Flush"
        End If

        If dicRankCounts.ContainsValue(4) Then Return "Four of a Kind"
        If dicRankCounts.ContainsValue(3) AndAlso dicRankCounts.ContainsValue(2) Then Return "Full House"
        If booIsFlush Then Return "Flush"
        If booIsStraight Then Return "Straight"
        If dicRankCounts.ContainsValue(3) Then Return "Three of a Kind"
        If dicRankCounts.Where(Function(kvp) kvp.Value = 2).Count() = 2 Then Return "Two Pair"
        If dicRankCounts.ContainsValue(2) Then Return "Pair"

        Return "High Card"
    End Function

End Class