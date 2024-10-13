Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary


Class MenuForm


    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Hide()
        myGameplayForm.Show()
    End Sub
    Private Sub StatsButton_Click(sender As Object, e As EventArgs) Handles StatsButton.Click
        Hide()
        myStatsForm = New OverallStatsForm
        myStatsForm.Show()
    End Sub

    'Private Sub LimitedPlayButton_Click(sender As Object, e As EventArgs)
    '    Dim myGameNumForm As New GameNumForm
    '    myGameNumForm.ShowDialog()
    'End Sub

    Sub StartGame(GameCount As Integer, Delay As Integer)
        myGame.PlayGame(GameCount)
    End Sub

    Private Sub CustomBoardButton_Click(sender As Object, e As EventArgs) Handles CustomBoardButton.Click
        Dim myCustomBoardForm As New CustomBoardForm
        Hide()
        myCustomBoardForm.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub


    Private Sub TrainerButton_Click(sender As Object, e As EventArgs) Handles TrainerButton.Click
        Hide()
        myTrainerForm = New TrainerForm
        myStatsForm = New OverallStatsForm
        myTrainerForm.Show()
        myGameplayForm.Show()
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

    'Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Cursor = New Cursor(New IO.MemoryStream(My.Resources.Rowanmouse))
    'End Sub
End Class