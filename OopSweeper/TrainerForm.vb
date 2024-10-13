Public Class TrainerForm
    Private Sub TrainerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStatsForm.InitiateTables()
    End Sub

    Sub FindGame(Difficulty As String)
    End Sub


    Sub StartGame(sender As Button, e As MouseEventArgs) Handles SimpleButton.Click, NonTrivialButton.Click, BruteForceButton.Click, GuessButton.Click
        Dim r As New Random
        Dim RandomGame As DataRow
        Dim Difficulty As String = ""

        Select Case sender.Name
            Case "SimpleButton"
                Difficulty = "Simple"
            Case "NonTrivialButton"
                Difficulty = "Non-Trivial"
            Case "BruteForceButton"
                Difficulty = "Brute Force"
            Case "GuessButton"
                Difficulty = "Guess"
        End Select

        Do
            RandomGame = myStatsForm.ComputerStats.GetTable.Rows(r.Next(0, myStatsForm.ComputerStats.GetTable.Rows.Count - 1))
        Loop Until RandomGame.ItemArray(4) = Difficulty
        myGameplayForm.GameFromStats(myStatsForm.ComputerStats.GetGame(RandomGame))
    End Sub


















    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
End Class