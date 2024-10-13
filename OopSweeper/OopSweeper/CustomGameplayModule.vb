
Module CustomGamePlayModule

    Function SolveBoard(UserImage As Bitmap, Img As Boolean) As SolvedBoard
        Dim Board As New CustomBoard(UserImage, Img)
        If Board.GetBoard Is Nothing Then Return Nothing
        Dim myCustomGame As New CustomGame(Board)
        myCustomGame.SolveBoard()
        Return myCustomGame.GetSolved
    End Function

    Class CustomGame
        Inherits Game
        Private Board As CustomBoard
        Private Solved As SolvedBoard
        Sub New(CurrentBoard As CustomBoard)
            Board = CurrentBoard
        End Sub

        Sub SolveBoard()
            Cells = GetCells()
            If Cells Is Nothing Then ErrorMessage("Game Already Finished") : Exit Sub
            Guess = New BestGuessCell
            For Each Cell In Cells
                Cell.GenerateAdjacents(Cells, Board.GetBoard.Width / 16 - 1, Board.GetBoard.Height / 16 - 1)
                If Cell.Adjacents.Count < Val(Cell.CellContents) Then Solved = Nothing : Exit Sub
                Cell.CheckIfMine()
                Cell.CheckIfUseless()
            Next
            Dim SafeCount As Integer
            Dim myConstraintSolver As ConstraintSolver
            Do
                SafeCount = SafeCells.Count
                For Each Cell In Cells
                    Try
                        For Each SafeCell In Cell.SimpleFinder
                            If Not SafeCells.Contains(SafeCell) Then SafeCells.Add(SafeCell)
                        Next
                    Catch
                        Solved = Nothing
                        Exit Sub
                    End Try

                Next
                For Each Cell In Cells
                    If Cell.Adjacents.Except(SafeCells).Count = Val(Cell.CellContents) Then
                        For Each Mine In Cell.Adjacents.Except(SafeCells)
                            Mine.IsMine = True
                        Next
                    End If
                Next
                myConstraintSolver = New ConstraintSolver(Cells, SafeCells)
                myConstraintSolver.FindNonTrivialSolutions()
                For Each SafeCell In myConstraintSolver.GetSafeCells
                    If Not SafeCells.Contains(SafeCell) Then SafeCells.Add(SafeCell)
                Next
            Loop Until SafeCount = SafeCells.Count
            If SafeCells.Count = 0 AndAlso myConstraintSolver.GetGuess IsNot Nothing Then Guess = myConstraintSolver.GetGuess
            Solved = New SolvedBoard(SafeCells, Board.GetBoard, Guess)
            For Each Cell In Cells
                If Cell.IsMine Then
                    Solved.MinesList.Add(Cell)
                End If
            Next
            For Each Cell In Cells
                '  If Cell.Adjacents.FindAll(Function(x) Solved.MinesList.Contains(x)).Count > Val(Cell.CellContents) Then Solved = Nothing : Exit Sub
                '  If Cell.Adjacents.FindAll(Function(x) Solved.MinesList.Contains(x)).Count < Val(Cell.CellContents) Then
                If Cell.Adjacents.FindAll(Function(x) Not SafeCells.Contains(x)).Count < Val(Cell.CellContents) Then Solved = Nothing : Exit Sub
            Next
        End Sub
        Overrides Function GetCells() As Cell(,)
            Dim Cells(Board.GetBoard.Width / 16 - 1, Board.GetBoard.Height / 16 - 1) As Cell
            Dim xCounter
            Dim yCounter = 0
            For y = 8 To Board.GetBoard.Height - 8 Step 16
                xCounter = 0
                For x = 8 To Board.GetBoard.Width - 8 Step 16
                    Cells(xCounter, yCounter) = New Cell(Board.GetBoard, New Point(x, y), New Point(xCounter, yCounter))
                    If Cells(xCounter, yCounter).CellContents = Nothing Then Return Nothing
                    If xCounter <> Board.GetBoard.Width / 16 - 1 Then
                        xCounter += 1
                    Else
                        xCounter = 0
                    End If
                Next
                yCounter += 1
            Next
            Return Cells
        End Function

        ReadOnly Property GetSolved As SolvedBoard
            Get
                Return Solved
            End Get
        End Property
    End Class
    Class CustomBoard
        Private Board As Bitmap
        Private CellBitmaps() As Bitmap = {My.Resources.BlankCell, My.Resources.UnknownCell, My.Resources._1Cell, My.Resources._2Cell,
                                            My.Resources._3Cell, My.Resources._4Cell, My.Resources._5Cell,
                                            My.Resources._6Cell, My.Resources._7Cell, My.Resources._8Cell}
        Private StartCoord As Point
        Private EndCoord As Point
        Sub New(UserImage As Bitmap, Img As Boolean)
            If Img Then
                StartCoord = FindStart(UserImage)
                If StartCoord.X > UserImage.Width Then Exit Sub
                EndCoord = FindEnd(UserImage)
                If EndCoord.X > UserImage.Width Then Exit Sub
            Else
                StartCoord = New Point(0, 0)
                EndCoord = New Point(UserImage.Width - 1, UserImage.Height - 1)
            End If
            Dim BoardRect As New Rectangle(StartCoord.X, StartCoord.Y, EndCoord.X - StartCoord.X + 1, EndCoord.Y - StartCoord.Y + 1)
            Board = New Bitmap(BoardRect.Width, BoardRect.Height)
            Using grp = Graphics.FromImage(Board)
                grp.DrawImage(UserImage, New Rectangle(0, 0, BoardRect.Width, BoardRect.Height), BoardRect, GraphicsUnit.Pixel)
            End Using
        End Sub
        Private Function FindStart(UserImage As Bitmap) As Point
            For y As Integer = 0 To UserImage.Height - My.Resources.UnknownCell.Height - 1

                For x As Integer = 0 To UserImage.Width - My.Resources.UnknownCell.Width - 1
                    Dim clr As Color = UserImage.GetPixel(x, y)
                    For Each Cell In CellBitmaps
                        If clr = Cell.GetPixel(0, 0) AndAlso IsInnerImage(UserImage, Cell, x, y) Or clr = Cell.GetPixel(0, 0) AndAlso IsInnerImage(UserImage, Cell, x, y) Then
                            Return New Point(x, y)
                        End If
                    Next
                Next
            Next
            Return New Point(UserImage.Width + 1, UserImage.Height + 1)
        End Function
        Private Function FindEnd(UserImage As Bitmap) As Point
            For y = UserImage.Height - 1 To My.Resources.UnknownCell.Height Step -1
                For x = UserImage.Width - 1 To My.Resources.UnknownCell.Width Step -1
                    Dim clr As Color = UserImage.GetPixel(x, y)
                    For Each Cell In CellBitmaps
                        If clr = Cell.GetPixel(Cell.Width - 1, Cell.Height - 1) AndAlso IsInnerImage(UserImage, Cell, x - Cell.Width + 1, y - Cell.Height + 1) Or
                            clr = Cell.GetPixel(Cell.Width - 1, Cell.Height - 1) AndAlso IsInnerImage(UserImage, Cell, x - Cell.Width + 1, y - Cell.Height + 1) Then
                            Return New Point(x, y)
                        End If
                    Next
                Next

            Next
            Return New Point(UserImage.Width + 1, UserImage.Height + 1)
        End Function
        Private Function IsInnerImage(UserImage As Bitmap, CellBitmap As Bitmap, left As Integer, top As Integer) As Boolean
            For y As Integer = top To top + CellBitmap.Height - 1

                For x As Integer = left To left + CellBitmap.Width - 1
                    If UserImage.GetPixel(x, y) <> CellBitmap.GetPixel(x - left, y - top) Then Return False
                Next
            Next

            Return True
        End Function
        ReadOnly Property GetBoard As Bitmap
            Get
                Return Board
            End Get
        End Property
    End Class

    Public Class SolvedBoard
        Public MinesList As New List(Of Cell)
        Public SafeCells As New List(Of Cell)
        Public Guess As New BestGuessCell
        Public Board As Bitmap
        Sub New(CellList As List(Of Cell), GameBoard As Bitmap, BestGuess As BestGuessCell)
            Board = GameBoard
            If CellList.Count <> 0 Then SafeCells = CellList Else Guess = BestGuess
        End Sub
    End Class
End Module
