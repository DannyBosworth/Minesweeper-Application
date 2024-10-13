Imports System.IO
Public Class CustomBoardForm
    Private TitleBarSize As Integer = Height - ClientRectangle.Height
    Private BoardBitmap As Bitmap
    Private Img As Boolean
    Private CustomBoardArray(,) As Rectangle
    Private CustomStateArray(,) As Char
    Private MouseLocation As Point

    Public Sub Form_Unload(sender As Object, e As EventArgs) Handles Me.Closing
        myMenuForm.Show()
    End Sub
    Private Sub GenerateBoard() Handles GenerateBoardButton.Click
        If Not Integer.TryParse(XSizeBox.Text, vbNull) OrElse Not Integer.TryParse(YSizeBox.Text, vbNull) Then ErrorMessage("Invalid value entered") : Exit Sub
        If XSizeBox.Text > 50 OrElse YSizeBox.Text > 50 Then ErrorMessage("Value cannot be over 50") : Exit Sub
        BoardBitmap = New Bitmap(CInt(XSizeBox.Text) * 16, CInt(YSizeBox.Text) * 16)
        SolvedBoardBox.Width = XSizeBox.Text * 16
        SolvedBoardBox.Height = YSizeBox.Text * 16
        ReDim CustomBoardArray(XSizeBox.Text - 1, YSizeBox.Text - 1)
        ReDim CustomStateArray(XSizeBox.Text - 1, YSizeBox.Text - 1)
        Using g = Graphics.FromImage(BoardBitmap)
            For x = 0 To XSizeBox.Text - 1
                For y = 0 To YSizeBox.Text - 1
                    CustomBoardArray(x, y) = New Rectangle(x * 16, y * 16, 15, 15)
                    CustomStateArray(x, y) = "u"
                    g.DrawImage(My.Resources.UnknownCell, CustomBoardArray(x, y).Location)
                Next
            Next
        End Using
        SolvedBoardBox.Image = BoardBitmap
        ResizeForm()
        SolvedBoardBox.Show()
        Img = False
    End Sub

    Sub DisplaySolvedBoard(Board As Bitmap)
        SafeLabel.Text = "Safe"
        GuessLabel.Text = "Guess"
        MineLabel.Text = "Mine"
        Dim Solved As SolvedBoard = SolveBoard(Board, Img)
        If Solved Is Nothing Then
            If Img Then ErrorMessage("Couldn't find board or Board is Invalid") Else ErrorMessage("Invalid Board")
            Exit Sub
        End If
        SolvedBoardBox.Size = New Size(Solved.Board.Width, Solved.Board.Height)
        BoardBitmap = Solved.Board
        Using g = Graphics.FromImage(BoardBitmap)
            If Solved.SafeCells.Count <> 0 Then
                SafeLabel.Text = "Safe (Count: " & Solved.SafeCells.Count & ")"
                For Each SafeCell In Solved.SafeCells
                    g.DrawImage(My.Resources.SafeCell, SafeCell.GetIndex.X * 16, SafeCell.GetIndex.Y * 16)
                    If Not Img Then CustomStateArray(SafeCell.GetIndex.X, SafeCell.GetIndex.Y) = "S"
                Next
            ElseIf Solved.Guess.GetCell IsNot Nothing Then
                GuessLabel.Text = "Guess (" & Solved.Guess.GetChanceSafe & "& Chance)"
                g.DrawImage(My.Resources.GuessCell, Solved.Guess.GetCell.GetIndex.X * 16, Solved.Guess.GetCell.GetIndex.Y * 16)
                If Not Img Then CustomStateArray(Solved.Guess.GetCell.GetIndex.X, Solved.Guess.GetCell.GetIndex.Y) = "G"
            End If
            For Each MineCell In Solved.MinesList
                MineLabel.Text = "Mine (Count: " & Solved.MinesList.Count & ")"
                g.DrawImage(My.Resources.MineCell, MineCell.GetIndex.X * 16, MineCell.GetIndex.Y * 16)
                If Not Img AndAlso CustomStateArray(MineCell.GetIndex.X, MineCell.GetIndex.Y) <> "f" Then CustomStateArray(MineCell.GetIndex.X, MineCell.GetIndex.Y) = "M"
            Next
        End Using
        SolvedBoardBox.Image = BoardBitmap
        ResizeForm()
        SolvedBoardBox.Show()
    End Sub
    Private Sub ImageButton_Click(sender As Object, e As EventArgs) Handles ImageButton.Click
        Img = True
        If Clipboard.GetImage Is Nothing Then ErrorMessage("No image found") : Img = False : Exit Sub
        DisplaySolvedBoard(Clipboard.GetImage())
    End Sub

    Private Sub ResizeForm()
        UserOptionsBox.Location = New Point(SolvedBoardBox.Location.X + SolvedBoardBox.Width + 10, UserOptionsBox.Location.Y)
        Size = New Size(UserOptionsBox.Location.X + UserOptionsBox.Width + 10, Math.Max(UserOptionsBox.Height + 43, SolvedBoardBox.Height + 43) + 43)
        SolvedBoardBox.Location = New Point(0, (Size.Height - SolvedBoardBox.Height) / 2)
        UserOptionsBox.Location = New Point(UserOptionsBox.Location.X, (Size.Height - UserOptionsBox.Height) / 2)
    End Sub
    Private Sub SolvedBoardBox_Click(sender As Object, e As MouseEventArgs) Handles SolvedBoardBox.Click
        If Not Img Then
            For Each Rect In CustomBoardArray
                If Rect.Contains(e.Location) Then
                    If e.Button = MouseButtons.Left Then
                        Using ChoiceForm As New CellChoiceForm
                            ChoiceForm.ShowDialog()
                            If ChoiceForm.ChosenCell IsNot Nothing Then DrawCell(ChoiceForm.ChosenCell, ChoiceForm.ChosenState, Rect)
                        End Using
                    Else
                        If CustomStateArray(Rect.X / 16, Rect.Y / 16) <> "f" Then
                            DrawCell(My.Resources.FlagCell, "f", Rect)
                        Else
                            DrawCell(My.Resources.UnknownCell, "u", Rect)
                        End If
                    End If
                End If
            Next
            SolvedBoardBox.Image = BoardBitmap
        End If
    End Sub
    Sub DrawCell(ChosenCell As Bitmap, ChosenState As Char, Rect As Rectangle)
        Using g = Graphics.FromImage(BoardBitmap)
            g.DrawImage(ChosenCell, Rect.Location)
            CustomStateArray(Rect.X / 16, Rect.Y / 16) = ChosenState
        End Using
        SolvedBoardBox.Image = BoardBitmap
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If SolvedBoardBox.Image IsNot Nothing Then
            If Img Then
                SolvedBoardBox.Image = Nothing
                UserOptionsBox.Location = New Point(10, 0)
                SolvedBoardBox.Location = New Point(0, 0)
                Size = New Size(UserOptionsBox.Right, UserOptionsBox.Bottom + TitleBarSize)
                SafeLabel.Text = "Safe"
                MineLabel.Text = "Mine"
                GuessLabel.Text = "Guess"
            Else
                XSizeBox.Text = CustomBoardArray.GetUpperBound(0) + 1
                YSizeBox.Text = CustomBoardArray.GetUpperBound(1) + 1
                GenerateBoard()
                SafeLabel.Text = "Safe"
                MineLabel.Text = "Mine"
                GuessLabel.Text = "Guess"
            End If
        End If
    End Sub

    Private Sub ReturnToMenuButton_Click(sender As Object, e As EventArgs) Handles ReturnToMenuButton.Click
        Hide()
        myMenuForm.Show()
    End Sub

    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click
        If Not Img Then
            If SolvedBoardBox.Image IsNot Nothing Then
                ClearShading()
                DisplaySolvedBoard(SolvedBoardBox.Image)
            Else
                ErrorMessage("No Board")
            End If
        Else
            ErrorMessage("Please Generate a Custom Board")
        End If
    End Sub

    Private Sub ClearShading() Handles ClearShadingButton.Click
        If SolvedBoardBox.Image IsNot Nothing Then
            Dim ClearedBoard As Bitmap = SolvedBoardBox.Image
            Using g = Graphics.FromImage(ClearedBoard)
                For x = 0 To CustomStateArray.GetUpperBound(0)
                    For y = 0 To CustomStateArray.GetUpperBound(1)
                        If CustomStateArray(x, y) = "S" OrElse CustomStateArray(x, y) = "G" OrElse CustomStateArray(x, y) = "M" Then
                            g.DrawImage(My.Resources.UnknownCell, New Point(x * 16, y * 16))
                        ElseIf CustomStateArray(x, y) = "f" Then
                            g.DrawImage(My.Resources.FlagCell, New Point(x * 16, y * 16))
                        End If
                    Next
                Next
            End Using
            SolvedBoardBox.Image = ClearedBoard
        End If
    End Sub

    Private Sub SolvedBoardBox_Hover(sender As Object, e As MouseEventArgs) Handles SolvedBoardBox.MouseMove
        If Not Img Then SolvedBoardBox.Cursor = Cursors.Hand Else SolvedBoardBox.Cursor = Cursors.Default
        SolvedBoardBox.Focus()
        MouseLocation = e.Location
    End Sub

    Private Sub SolvedBoardBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SolvedBoardBox.KeyDown
        For Each Rect In CustomBoardArray
            If Rect.Contains(MouseLocation) Then
                Select Case e.KeyCode
                    Case Keys.D0
                        DrawCell(My.Resources.BlankCell, "0", Rect)
                    Case Keys.D1
                        DrawCell(My.Resources._1Cell, "1", Rect)
                    Case Keys.D2
                        DrawCell(My.Resources._2Cell, "2", Rect)
                    Case Keys.D3
                        DrawCell(My.Resources._3Cell, "3", Rect)
                    Case Keys.D4
                        DrawCell(My.Resources._4Cell, "4", Rect)
                    Case Keys.D5
                        DrawCell(My.Resources._5Cell, "5", Rect)
                    Case Keys.D6
                        DrawCell(My.Resources._6Cell, "6", Rect)
                    Case Keys.D7
                        DrawCell(My.Resources._7Cell, "7", Rect)
                    Case Keys.D8
                        DrawCell(My.Resources._8Cell, "8", Rect)
                    Case Keys.U
                        DrawCell(My.Resources.UnknownCell, "u", Rect)
                    Case Keys.M
                        DrawCell(My.Resources.FlagCell, "f", Rect)
                End Select
            End If
        Next




    End Sub

    Private Sub SaveImageButton_Click(sender As Object, e As EventArgs) Handles SaveImageButton.Click
        If BoardBitmap IsNot Nothing Then
            SaveImage.Filter = "Image Files(*.png)|*.png"
            If SaveImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
                BoardBitmap.Save(SaveImage.FileName)
            End If
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