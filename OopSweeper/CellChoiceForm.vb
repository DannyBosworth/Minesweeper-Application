﻿Public Class CellChoiceForm
    Public ChosenCell As Image
    Public ChosenState As Char
    Public Sub CellChosen(sender As Object, e As EventArgs) Handles BlankCell.Click, Cell1.Click, Cell2.Click, Cell3.Click,
                                                                    Cell4.Click, Cell5.Click, Cell6.Click, Cell7.Click, Cell8.Click, UnknownCell.Click
        If sender Is BlankCell Then
            ChosenState = "0"
            ChosenCell = My.Resources.BlankCell
        ElseIf sender Is Cell1 Then
            ChosenState = "1"
            ChosenCell = My.Resources._1Cell
        ElseIf sender Is Cell2 Then
            ChosenState = "2"
            ChosenCell = My.Resources._2Cell
        ElseIf sender Is Cell3 Then
            ChosenState = "3"
            ChosenCell = My.Resources._3Cell
        ElseIf sender Is Cell4 Then
            ChosenState = "4"
            ChosenCell = My.Resources._4Cell
        ElseIf sender Is Cell5 Then
            ChosenState = "5"
            ChosenCell = My.Resources._5Cell
        ElseIf sender Is Cell6 Then
            ChosenState = "6"
            ChosenCell = My.Resources._6Cell
        ElseIf sender Is Cell7 Then
            ChosenState = "7"
            ChosenCell = My.Resources._7Cell
        ElseIf sender Is Cell8 Then
            ChosenState = "8"
            ChosenCell = My.Resources._8Cell
        ElseIf sender Is UnknownCell Then
            ChosenState = "u"
            ChosenCell = My.Resources.UnknownCell
        End If

        DialogResult = DialogResult.OK

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