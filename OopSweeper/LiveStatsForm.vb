Public Class LiveStatsForm

    Private dt As New DataTable
    Sub GameEndUpdate(Outcome As String)
        GamesPlayedBox.Text += 1
        If Outcome = "Won" Then WinsBox.Text += 1
        If Outcome = "Loss" Then LossesBox.Text += 1
        Application.DoEvents()
        WinPercentBox.Text = Math.Round(WinsBox.Text / GamesPlayedBox.Text * 100, 2)
        Application.DoEvents()
    End Sub
    Sub GuessUpdate(Outcome As String)
        GuessesMadeBox.Text += 1
        If Outcome = "Success" Then SuccessfulGuessesBox.Text += 1
        If Outcome = "Fail" Then UnsuccessfulGuessesBox.Text += 1
        Application.DoEvents()
        GuessPercentBox.Text = Math.Round(SuccessfulGuessesBox.Text / GuessesMadeBox.Text * 100, 2)
        Application.DoEvents()
    End Sub


    Private Sub LiveStatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add(New DataColumn("Strategy", Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("Count", Type.GetType("System.Single")))
        dt.Rows.Add("Corner", 0)
        dt.Rows.Add("Guess", 0)
        dt.Rows.Add("Safe", 0)
        dt.Rows.Add("Random", 0)
    End Sub

    Sub AddToTable(Strategy As String)
        If Visible Then
            Dim NewRow = dt.NewRow
            NewRow("Count") = 1
            NewRow("Strategy") = Strategy
            dt.Rows.Add(NewRow)
            UpdateLabels()
        End If
    End Sub
    Sub UpdateTable(Strategy As String)
        If Visible Then
            Dim Row = dt.Select("Strategy = '" & Strategy & "'")
            Row(0)("Count") += 1
            UpdateLabels()
        End If
    End Sub

    Sub UpdateLabels()
        If Visible Then
            CornerLossLabel.Text = "Percent Corner: " & Math.Round(dt.Rows(0)("Count") / dt.Compute(" SUM(Count)", "") * 100, 2)
            GuessLossLabel.Text = "Percent Guess: " & Math.Round(dt.Rows(1)("Count") / dt.Compute(" SUM(Count)", "") * 100, 2)
            SafeLossLabel.Text = "Percent Safe: " & Math.Round(dt.Rows(2)("Count") / dt.Compute(" SUM(Count)", "") * 100, 2)
            RandomLossLabel.Text = "Percent Random: " & Math.Round(dt.Rows(3)("Count") / dt.Compute(" SUM(Count)", "") * 100, 2)
        End If
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