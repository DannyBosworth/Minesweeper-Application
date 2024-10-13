Public Class TrainerForm

    Private SimpleGames As New List(Of String)
    Private NonTrivialGames As New List(Of String)
    Private BruteForceGames As New List(Of String)
    Private GuessGames As New List(Of String)
    Private Sub TrainerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStatsForm.InitiateTables()
        For Each Game As DataRow In myStatsForm.ComputerStats.GetTable.Rows
            If Game.ItemArray(3) = "Won" Then
                Select Case Game.ItemArray(4)
                    Case "Simple"
                        SimpleGames.Add(Game.ItemArray(5))
                    Case "Non-Trivial"
                        NonTrivialGames.Add(Game.ItemArray(5))
                    Case "Brute Force"
                        BruteForceGames.Add(Game.ItemArray(5))
                    Case "Guess"
                        GuessGames.Add(Game.ItemArray(5))
                End Select
            End If
        Next
    End Sub


    Sub StartGame(sender As Button, e As MouseEventArgs) Handles SimpleButton.Click, NonTrivialButton.Click, BruteForceButton.Click, GuessButton.Click
        Dim r As New Random
        Select Case sender.Name
            Case "SimpleButton"
                If SimpleGames.Count <> 0 Then myGameplayForm.GameFromStats(SimpleGames(r.Next(0, SimpleGames.Count - 1)))
            Case "NonTrivialButton"
                If NonTrivialGames.Count <> 0 Then myGameplayForm.GameFromStats(NonTrivialGames(r.Next(0, NonTrivialGames.Count - 1)))
            Case "BruteForceButton"
                If BruteForceGames.Count <> 0 Then myGameplayForm.GameFromStats(BruteForceGames(r.Next(0, BruteForceGames.Count - 1)))
            Case "GuessButton"
                If GuessGames.Count <> 0 Then myGameplayForm.GameFromStats(GuessGames(r.Next(0, GuessGames.Count - 1)))
        End Select
    End Sub
End Class