Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class GameplayForm

    Private Board As GameBoard
    Public Stopped As Boolean = False
    Private ComputerPlaying As Boolean
    Public WithEvents Timer As New Timer
    Private Time As Decimal
    Private Random As Boolean = False
    Private Sub GameplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Board = New GameBoard(30, 16, 99)
        BoardBox.Image = Board.GetBoard
        TimeBox.Text = 0
    End Sub

    Sub GameFromStats(States As String)
        Show()
        Board = New GameBoard(States)
        BoardBox.Image = Board.GetBoard
        BoardBox.Size = BoardBox.Image.Size
        ResizeForm()
        TimeBox.Text = 0
    End Sub

    Public Sub Form_Unload() Handles Me.Closing
        myMenuForm.Show()
    End Sub


    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TimeBox.Text += 0.1
    End Sub

    Private Sub DifficultyButtonPressed(sender As Button, e As EventArgs) Handles BeginnerButton.Click, IntermediateButton.Click, ExpertButton.Click
        Select Case sender.Text
            Case "Beginner"
                Board = New GameBoard(9, 9, 10)
            Case "Intermediate"
                Board = New GameBoard(16, 16, 40)
            Case "Expert"
                Board = New GameBoard(30, 16, 99)
        End Select
        BoardBox.Image = Board.GetBoard
        BoardBox.Size = BoardBox.Image.Size
        ResizeForm()
    End Sub
    Sub ResizeForm()
        UserOptionsBox.Location = New Point(BoardBox.Location.X + BoardBox.Width + 10, UserOptionsBox.Location.Y)
        Size = New Size(UserOptionsBox.Location.X + UserOptionsBox.Width + 10, Math.Max(UserOptionsBox.Height + 43, BoardBox.Height + 43))
        BoardBox.Location = New Point(0, (Size.Height - 43 - BoardBox.Height) / 2)
        UserOptionsBox.Location = New Point(UserOptionsBox.Location.X, (Size.Height - 43 - UserOptionsBox.Height) / 2)
    End Sub

    Private Sub GenerateNewSizeBoard(sender As Object, e As EventArgs) Handles GenerateBoardButton.Click
        If Integer.TryParse(XSizeBox.Value, vbNull) AndAlso Integer.TryParse(YSizeBox.Value, vbNull) AndAlso Integer.TryParse(MinesBox.Value, vbNull) AndAlso MinesBox.Value < XSizeBox.Value * YSizeBox.Value Then
            Board = New GameBoard(XSizeBox.Value, YSizeBox.Value, MinesBox.Value)
            BoardBox.Image = Board.GetBoard
            BoardBox.Size = BoardBox.Image.Size
            ResizeForm()
        End If
    End Sub

    Private Sub OpenCellClick(sender As Object, e As MouseEventArgs) Handles BoardBox.Click
        If Board.GetEndResult = "" Then
            If e.Button = MouseButtons.Left Then Board.UpdateBoard(e.Location, True) Else Board.UpdateBoard(e.Location, False)
            If Board.GetEndResult = "Won" Then ResetButton.Image = My.Resources.ResetButtonWon : Timer.Stop()
            If Board.GetEndResult = "Loss" Then ResetButton.Image = My.Resources.ResetButtonLost : Timer.Stop()
            BoardBox.Image = Board.GetBoard
            ComputerPlaying = False
            If Board.GetEndResult <> "" Then WriteStatsToFile()
        End If
    End Sub

    Public Sub OpenCellProgram(Location As Point)
        If Board.GetEndResult = "" Then
            Board.UpdateBoard(Location, True)
            If Board.GetEndResult = "Won" Then ResetButton.Image = My.Resources.ResetButtonWon : Timer.Stop()
            If Board.GetEndResult = "Loss" Then ResetButton.Image = My.Resources.ResetButtonLost : Timer.Stop()
            BoardBox.Image = Board.GetBoard
            ComputerPlaying = True
            If Board.GetEndResult <> "" Then WriteStatsToFile()
            Application.DoEvents()
        End If

    End Sub

    Public Sub ResetGame() Handles ResetButton.Click
        If Not Random Then
            Board = New GameBoard(Board.GetBoard.Width / 16, Board.GetBoard.Height / 16, Board.GetMines)
        Else
            Dim r As New Random
            Dim Width As Integer = r.Next(9, 31)
            Dim Height As Integer = r.Next(9, 31)
            Dim Mines As Integer = r.Next(10 / 81 * Width * Height, 99 / 480 * Width * Height + 1)
            Board = New GameBoard(Width, Height, Mines)
        End If
        BoardBox.Image = Board.GetBoard
        BoardBox.Size = BoardBox.Image.Size
        ResizeForm()
        Board.IsFirstMove = True
        ResetButton.Image = My.Resources.ResetButton
        TimeBox.Text = 0
        Timer.Stop()
    End Sub

    Private Sub ReturnToMenuButton_Click(sender As Object, e As EventArgs) Handles ReturnToMenuButton.Click
        ResetGame()
        Stopped = True
        Hide()
        If myTrainerForm IsNot Nothing Then myTrainerForm.Hide()
        myMenuForm.Show()
    End Sub

    Private Sub WriteStatsToFile()
        Dim Writer As StreamWriter
        If ComputerPlaying Then
            Writer = New StreamWriter(Directory.GetCurrentDirectory + "\ComputerStats.txt", True)
            Writer.WriteLine(Board.GetDifficulty & "," & Board.Get3BV & "," & TimeBox.Text & "," & Board.GetEndResult & "," & myGame.HardestAlgorithm & "," & Board.GetStates)
        Else
            Writer = New StreamWriter(Directory.GetCurrentDirectory + "\HumanStats.txt", True)
            Writer.WriteLine(Board.GetDifficulty & "," & Board.Get3BV & "," & TimeBox.Text & "," & Board.GetEndResult & "," & "" & "," & Board.GetStates)
        End If
        Writer.Close()
    End Sub

    Public Function GetBoardStates() As Char(,)
        If Board.GetEndResult <> "" Then myGame.GameOver = Board.GetEndResult : Return Nothing
        Dim States(Board.GetCells.GetUpperBound(0), Board.GetCells.GetUpperBound(1)) As Char
        For x = 0 To Board.GetCells.GetUpperBound(0)
            For y = 0 To Board.GetCells.GetUpperBound(1)
                If Board.GetCells(x, y).IsOpen Then
                    If Board.GetCells(x, y).GetState = "m" Then Return Nothing
                    States(x, y) = Board.GetCells(x, y).GetState
                    myGame.FirstMove = False
                Else
                    States(x, y) = "u"
                End If
            Next
        Next
        Return States
    End Function

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        If ComputerPlaying Then Stopped = False : myGame.PlayGame(-1) : Exit Sub
        Stopped = False
        myGame.PlayGame(-1)
    End Sub

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        Board.Reset()
        TimeBox.Text = 0
        Timer.Stop()
        BoardBox.Image = Board.GetBoard
    End Sub

    Private Sub RandomPlayButton_Click(sender As Object, e As EventArgs) Handles RandomPlayButton.Click
        If Random = False Then
            Random = True
            RandomPlayButton.BackColor = Color.Green
        Else
            Random = False
            RandomPlayButton.BackColor = Color.Red
        End If
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Stopped = True
    End Sub

    Private Sub TimeBox_TextChanged(sender As Object, e As EventArgs) Handles TimeBox.TextChanged

    End Sub
End Class

<Serializable> Public Class GameBoard

    Private Board As Bitmap
    Private CellRects As Rectangle(,)
    Private GameCells As GameCell(,)
    Private MineCount As Integer
    Private OpenedCount As Integer
    Private Ended As String
    Private FirstMove As Boolean
    Private _3BV As Integer
    Private Difficulty As String
    Sub New(Width As Integer, Height As Integer, Mines As Integer)
        MineCount = Mines
        ResetGame(Width, Height)
    End Sub

    Sub ResetGame(Width As Integer, Height As Integer)
        NewGame(Width, Height)
        GenerateMines()
        For Each Cell In GameCells
            If Cell.GetState <> "m" Then Cell.GenerateAdjacentCells(GameCells, New Point(GameCells.GetUpperBound(0), GameCells.GetUpperBound(1)))
        Next
        Generate3BV()
    End Sub

    Sub New(States As String)
        Dim Width As Integer
        Dim Height As Integer
        Dim Index As Integer
        Dim x As Integer
        Dim y As Integer
        Do
            Width = Width & States(Index)
            Index += 1
        Loop Until States(Index) = " "
        Do
            Height = Height & States(Index)
            Index += 1
        Loop Until States(Index) = " "
        Index += 1
        Do
            MineCount = MineCount & States(Index)
            Index += 1
        Loop Until States(Index) = " "
        Index += 1
        ReDim GameCells(Width - 1, Height - 1)
        NewGame(Width, Height)
        Do
            Do
                x = x & States(Index)
                Index += 1
            Loop Until States(Index) = ","
            Index += 1
            Do
                y = y & States(Index)
                Index += 1
            Loop Until States(Index) = " "
            Index += 1
            GameCells(x, y).GetState = "m"
            x = Nothing
            y = Nothing
        Loop Until Index = States.Length

        For Each Cell In GameCells
            If Cell.GetState <> "m" Then Cell.GenerateAdjacentCells(GameCells, New Point(GameCells.GetUpperBound(0), GameCells.GetUpperBound(1)))
        Next

        Generate3BV()
    End Sub

    Sub NewGame(Width As Integer, Height As Integer)

        ReDim GameCells(Width - 1, Height - 1)
        ReDim CellRects(Width - 1, Height - 1)

        If Width = 30 AndAlso Height = 16 AndAlso MineCount = 99 Then
            Difficulty = "Expert"
        ElseIf Width = 16 AndAlso Height = 16 AndAlso MineCount = 40 Then
            Difficulty = "Intermediate"
        ElseIf Width = 9 AndAlso Height = 9 AndAlso MineCount = 10 Then
            Difficulty = "Beginner"
        Else
            Difficulty = "Custom" & Width & "/" & Height
        End If

        Ended = ""
        FirstMove = True
        OpenedCount = 0

        Board = New Bitmap(Width * 16, Height * 16)
        Using g = Graphics.FromImage(Board)
            For x = 0 To CellRects.GetUpperBound(0)
                For y = 0 To CellRects.GetUpperBound(1)
                    CellRects(x, y) = New Rectangle(x * 16, y * 16, 15, 15)
                    g.DrawImage(My.Resources.UnknownCell, x * 16, y * 16)
                Next
            Next
        End Using

        For y = 0 To GameCells.GetUpperBound(1)
            For x = 0 To GameCells.GetUpperBound(0)
                GameCells(x, y) = New GameCell(New Point(x, y))
            Next
        Next

    End Sub


    Function GetStates() As String
        Dim States As String = GameCells.GetUpperBound(0) + 1 & " " & GameCells.GetUpperBound(1) + 1 & " " & MineCount & " "
        For Each Cell In GameCells
            If Cell.GetState = "m" Then States += Cell.GetIndex.X & "," & Cell.GetIndex.Y & " "
        Next
        Return States
    End Function

    Sub Reset()
        Using g = Graphics.FromImage(Board)
            For x = 0 To CellRects.GetUpperBound(0)
                For y = 0 To CellRects.GetUpperBound(1)
                    CellRects(x, y) = New Rectangle(x * 16, y * 16, 15, 15)
                    g.DrawImage(My.Resources.UnknownCell, x * 16, y * 16)
                Next
            Next
        End Using
        For Each Cell In GameCells
            Cell.IsOpen = False
            Cell.IsFlagged = False
        Next
        Ended = ""
        FirstMove = True
        OpenedCount = 0
    End Sub

    Private Sub Generate3BV()
        _3BV = 0
        For Each Cell In GameCells
            If Not Cell.IsMarked Then
                If Cell.GetState = "0" Then
                    _3BV += 1
                    Cell.IsMarked = True
                    Mark0s(Cell)
                End If
            End If
        Next
        For Each Cell In GameCells
            If Not Cell.IsMarked AndAlso Not Cell.GetState = "m" Then Cell.IsMarked = True : _3BV += 1
        Next
    End Sub

    Sub Mark0s(Cell As GameCell)
        For Each Adjacent In Cell.GetAdjacents
            If Not Adjacent.IsMarked Then
                Adjacent.IsMarked = True
                If Adjacent.GetState = "0" Then Mark0s(Adjacent)
            End If
        Next
    End Sub

    Sub UpdateBoard(Location As Point, LeftClick As Boolean)
        Using g = Graphics.FromImage(Board)
            For Each Rect In CellRects
                If Rect.Contains(Location) Then
                    If LeftClick Then
                        If Not GameCells(Rect.X / 16, Rect.Y / 16).IsOpen And Not GameCells(Rect.X / 16, Rect.Y / 16).IsFlagged Then
                            Threading.Thread.Sleep(myGameplayForm.DelayBox.Value)
                            OpenCell(Rect.Location, g)
                        Else
                            If GameCells(Rect.X / 16, Rect.Y / 16).GetState <> "0" Then
                                If GameCells(Rect.X / 16, Rect.Y / 16).GetAdjacents.FindAll(Function(x) x.IsFlagged).Count = Val(GameCells(Rect.X / 16, Rect.Y / 16).GetState) Then
                                    For Each Adjacent In GameCells(Rect.X / 16, Rect.Y / 16).GetAdjacents
                                        If Not Adjacent.IsFlagged And Not Adjacent.IsOpen Then OpenCell(Adjacent.GetLocation, g)
                                    Next
                                End If
                            End If
                        End If
                    Else
                        If Not GameCells(Rect.X / 16, Rect.Y / 16).IsOpen Then
                            If Not GameCells(Rect.X / 16, Rect.Y / 16).IsFlagged Then
                                g.DrawImage(My.Resources.FlagCell, Rect.Location)
                                GameCells(Rect.X / 16, Rect.Y / 16).IsFlagged = True
                            Else
                                g.DrawImage(My.Resources.UnknownCell, Rect.Location)
                                GameCells(Rect.X / 16, Rect.Y / 16).IsFlagged = False
                            End If
                        End If
                    End If
                End If
            Next
        End Using
    End Sub

    Sub OpenCell(Location As Point, g As Graphics)
        If FirstMove Then myGameplayForm.Timer.Start()
        If Ended = "" Then
            GameCells(Location.X / 16, Location.Y / 16).IsOpen = True
            '     OpenedCount += 1
            Select Case GameCells(Location.X / 16, Location.Y / 16).GetState
                Case "0"
                    g.DrawImage(My.Resources.BlankCell, Location)
                    If Not GameCells(Location.X / 16, Location.Y / 16).IsOpen Then Open0Cells(g, GameCells(Location.X / 16, Location.Y / 16))
                Case "1"
                    g.DrawImage(My.Resources._1Cell, Location)
                Case "2"
                    g.DrawImage(My.Resources._2Cell, Location)
                Case "3"
                    g.DrawImage(My.Resources._3Cell, Location)
                Case "4"
                    g.DrawImage(My.Resources._4Cell, Location)
                Case "5"
                    g.DrawImage(My.Resources._5Cell, Location)
                Case "6"
                    g.DrawImage(My.Resources._6Cell, Location)
                Case "7"
                    g.DrawImage(My.Resources._7Cell, Location)
                Case "8"
                    g.DrawImage(My.Resources._8Cell, Location)
                Case "m"
                    If FirstMove Then ReDim GameCells(GameCells.GetUpperBound(0), GameCells.GetUpperBound(1)) : ResetGame(GameCells.GetUpperBound(0) + 1, GameCells.GetUpperBound(1) + 1) : OpenCell(Location, g) : Exit Select
                    EndGameLost(Location, g)
            End Select
            CheckIfWon(g)
        End If
        FirstMove = False
    End Sub

    Sub CheckIfWon(g As Graphics)
        For Each Cell In GameCells
            If Cell.IsOpen Then OpenedCount += 1
        Next
        If OpenedCount = Board.Width / 16 * Board.Height / 16 - MineCount Then
            For Each Cell In GameCells
                If Cell.GetState = "m" Then g.DrawImage(My.Resources.FlagCell, Cell.GetLocation)
            Next
            Ended = "Won"
        End If
        OpenedCount = 0
    End Sub

    Sub EndGameLost(Location As Point, g As Graphics)
        For Each Cell In GameCells
            If Cell.GetState = "m" Then g.DrawImage(My.Resources.LostMineCell, Cell.GetLocation)
        Next
        g.DrawImage(My.Resources.OpenedMineCell, Location)
        Ended = "Loss"
    End Sub
    Sub Open0Cells(g As Graphics, Cell As GameCell)
        For Each Adjacent In Cell.GetAdjacents
            If Not Adjacent.IsOpen Then OpenCell(Adjacent.GetLocation, g)
        Next
    End Sub

    Sub GenerateMines()
        Dim r As New Random
        For m = 0 To MineCount - 1
            Do
                Dim x As Integer = r.Next(0, GameCells.GetUpperBound(0) + 1)
                Dim y As Integer = r.Next(0, GameCells.GetUpperBound(1) + 1)
                If GameCells(x, y).GetState <> "m" Then GameCells(x, y).GetState = "m" : Exit Do
            Loop
        Next
    End Sub
    ReadOnly Property GetBoard As Bitmap
        Get
            Return Board
        End Get
    End Property

    ReadOnly Property GetMines As Integer
        Get
            Return MineCount
        End Get
    End Property

    Property IsFirstMove As Boolean
        Get
            Return FirstMove
        End Get
        Set(value As Boolean)
            FirstMove = value
        End Set
    End Property

    ReadOnly Property GetEndResult As String
        Get
            Return Ended
        End Get
    End Property

    ReadOnly Property GetCells() As GameCell(,)
        Get
            Return GameCells
        End Get
    End Property

    ReadOnly Property Get3BV As Integer
        Get
            Return _3BV
        End Get
    End Property

    ReadOnly Property GetDifficulty As String
        Get
            Return Difficulty
        End Get
    End Property
End Class

<Serializable> Public Class GameCell
    Private State As Char
    Private Index As Point
    Private Location As Point
    Private AdjacentCells As New List(Of GameCell)
    Private Opened As Boolean
    Private Flagged As Boolean
    Private Marked As Boolean
    Sub New(BoardIndex As Point)
        Index = BoardIndex
        Location = New Point(Index.X * 16, Index.Y * 16)
        State = ""
        Opened = False
        Marked = False
    End Sub

    Sub GenerateAdjacentCells(CellStates As GameCell(,), Dimensions As Point)
        Dim MineCount As Integer
        For x = -1 To 1
            For y = -1 To 1
                If x = 0 AndAlso y = 0 Then Continue For
                If Index.X + x <= Dimensions.X AndAlso Index.Y + y <= Dimensions.Y AndAlso Index.X + x >= 0 AndAlso Index.Y + y >= 0 Then
                    If CellStates(Index.X + x, Index.Y + y).GetState = "m" Then MineCount += 1
                    AdjacentCells.Add(CellStates(Index.X + x, Index.Y + y))
                End If
            Next
        Next
        CellStates(Index.X, Index.Y).GetState = CStr(MineCount)
    End Sub

    Property IsOpen As Boolean
        Get
            Return Opened
        End Get
        Set(value As Boolean)
            Opened = value
        End Set
    End Property
    Property GetState As Char
        Get
            Return State
        End Get
        Set(value As Char)
            State = value
        End Set
    End Property

    Property IsFlagged As Boolean
        Get
            Return Flagged
        End Get
        Set(value As Boolean)
            Flagged = value
        End Set
    End Property

    ReadOnly Property GetIndex As Point
        Get
            Return Index
        End Get
    End Property

    ReadOnly Property GetLocation As Point
        Get
            Return Location
        End Get
    End Property

    ReadOnly Property GetAdjacents As List(Of GameCell)
        Get
            Return AdjacentCells
        End Get
    End Property

    Property IsMarked As Boolean
        Get
            Return Marked
        End Get
        Set(value As Boolean)
            Marked = value
        End Set
    End Property
End Class