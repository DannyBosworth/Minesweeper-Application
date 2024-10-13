Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Module GamePlayModule
    Public myMenuForm As MenuForm
    Public myStatsForm As OverallStatsForm
    Public myGame As New Game
    Public myGameplayForm As GameplayForm
    Public myLiveStatsForm As LiveStatsForm
    Public myTrainerForm As TrainerForm

    Sub Main() ' startup for program, runs main menu form
        myMenuForm = New MenuForm
        myGameplayForm = New GameplayForm
        Application.Run(myMenuForm)
        Main()
    End Sub
    Function DeepClone(Of T)(ByRef orig As T) As T
        If orig Is Nothing Then Return Nothing

        Dim formatter As New BinaryFormatter()
        Dim stream As New MemoryStream()

        formatter.Serialize(stream, orig)
        stream.Seek(0, SeekOrigin.Begin)

        Return formatter.Deserialize(stream)

    End Function
    Sub ErrorMessage(Message As String)
        MsgBox(Message, MsgBoxStyle.Critical, "Error")
    End Sub
    Class Game
        Private myConstraintSolver As ConstraintSolver
        Public GameOver As String = ""
        Public FirstMove As Boolean
        Private BoardStates As Char(,)
        Protected Cells(,) As Cell
        Protected SafeCells As New List(Of Cell)
        Private SafeCellStrategy As New List(Of String)
        Private CurrentStrategy As String
        Protected Guess As New BestGuessCell
        Private GameCount As Integer = 0
        Private MoveCount As Integer = 0
        Private MoveCounts As New List(Of Integer)
        Public HardestAlgorithm As String

        Public Sub PlayGame(GamesToPlay As Integer)

            BoardStates = myGameplayForm.GetBoardStates


            Guess = New BestGuessCell
            FirstMove = True
            OpenStatsForm() : Application.DoEvents() ' opens the live stats form

            Do Until GameCount = GamesToPlay OrElse myGameplayForm.Stopped ' main loop for gameplay

                BoardStates = myGameplayForm.GetBoardStates

                If BoardStates Is Nothing Then EndGame()

                If FirstMove Then myGameplayForm.ResetGame() : FirstMove = False : myGameplayForm.OpenCellProgram(New Point(0, 0)) : GameOver = "" : Continue Do
                ' if its the first move then click on the top right corner

                Cells = GetCells()
                If GameOver <> "" Then EndGame() : MoveCount = 0 : Continue Do ' if the game has been won or lost then call the EndGame method and reset FirstMove

                SafeCells.Clear()
                SafeCellStrategy.Clear() 'clear safecell info for new loop

                If Guess.GetUsed Then myLiveStatsForm.GuessUpdate("Success") 'if the last loop resulted in a guess being used then it was a success as the game isnt over
                Guess = New BestGuessCell ' reset guess info

                EvaluateBoard() 'run algorithms to determine safecells/best guess

                If SafeCells.Count <> 0 Then

                    For Each SafeCell In SafeCells 'click each safecell and increment the amount of moves used
                        MoveCount += 1
                        myGameplayForm.OpenCellProgram(SafeCell.GetLocation)
                        CurrentStrategy = "Safe" 'if the game is lost this loop then a safecell was clicked to lose it
                    Next

                Else

                    If myConstraintSolver.GetGuess IsNot Nothing Then Guess = myConstraintSolver.GetGuess
                    MakeInformedMove() 'no safecells are known so make the next best move
                    MoveCount += 1

                End If
            Loop
        End Sub

        Private Sub OpenStatsForm()

            If myLiveStatsForm Is Nothing Then myLiveStatsForm = New LiveStatsForm Else myLiveStatsForm.Show() : Exit Sub

            Dim r As New Random

            If Not myGameplayForm.Bounds.IntersectsWith(myLiveStatsForm.Bounds) Then

                myLiveStatsForm.Show() 'display live stats form if it doesnt overlap with the game board

            Else

                If myGameplayForm.Bounds.Width + myLiveStatsForm.Bounds.Width > Screen.PrimaryScreen.Bounds.Width OrElse myGameplayForm.Bounds.Height + myLiveStatsForm.Bounds.Height > Screen.PrimaryScreen.Bounds.Height Then Exit Sub
                'if the live stats form is too big to fit on the screen with no overlap then dont display it at all
                Do
                    myLiveStatsForm.Bounds = New Rectangle(r.Next(Screen.PrimaryScreen.Bounds.Width - myLiveStatsForm.Width), r.Next(Screen.PrimaryScreen.Bounds.Height - myLiveStatsForm.Height), myLiveStatsForm.Bounds.Width, myLiveStatsForm.Bounds.Height)
                    'randomly assign the form a location until it doesnt intersect with the board
                Loop Until Not myGameplayForm.Bounds.IntersectsWith(myLiveStatsForm.Bounds)
                myLiveStatsForm.Show()
            End If
        End Sub
        Private Function EvaluateBoard()
            For Each Cell In Cells 'gathering info about each cell
                Cell.GenerateAdjacents(Cells, BoardStates.GetUpperBound(0), BoardStates.GetUpperBound(1))
                Cell.CheckIfMine()
                Cell.CheckIfUseless()
            Next
            Dim SafeCount As Integer
            Do
                For Each Cell In Cells ' running the simple algorithm on all relevant cells
                    For Each SafeCell In Cell.SimpleFinder()
                        If Not SafeCells.Contains(SafeCell) Then SafeCells.Add(SafeCell)
                        SafeCellStrategy.Add("Simple") ' updating the strategy list with the technique used
                        If HardestAlgorithm = "" Then HardestAlgorithm = "Simple"
                    Next
                Next
                If SafeCells.Count <> 0 Then
                    For Each Cell In Cells
                        If Cell.Adjacents.Except(SafeCells).Count = Val(Cell.CellContents) Then
                            For Each Mine In Cell.Adjacents.Except(SafeCells)
                                Mine.IsMine = True
                            Next
                        End If
                    Next
                End If
                If SafeCells.Count = 0 Then
                    myConstraintSolver = New ConstraintSolver(Cells, SafeCells)
                    myConstraintSolver.FindNonTrivialSolutions()
                    SafeCells = myConstraintSolver.GetSafeCells
                End If
                SafeCount = SafeCells.Count
            Loop Until SafeCells.Count = SafeCount
            Return SafeCells ' returns safecells to be clicked
        End Function
        Private Sub MakeInformedMove()
            If Guess.GetCell IsNot Nothing Then
                HardestAlgorithm = "Guess"
                If MoveCounts.Count = 0 Then MoveCounts.Add(245)
                Dim x As Decimal = Cells.Length + ((99 / 480 * Cells.Length) ^ 2 / Cells.Length) 'custom made formula to approximate the difficulty of the board (assumes 
                If Guess.GetChanceSafe < 1 - (99 / 480) AndAlso MoveCount <= MoveCounts.Average Then ' And MoveCount < (0.000487671 * x ^ 2 + 0.0689299 * x + 13.3836) / 2 Then 'http://www.minesweeper.info/articles/3BV_Limits_On_Trial.pdf
                    If FindCorner() IsNot Nothing Then
                        myGameplayForm.OpenCellProgram(FindCorner.GetLocation) 'click on the first unopened corner cell
                    Else
                        myGameplayForm.OpenCellProgram(Guess.GetCell.GetLocation) ' if no corners are available then use the best guess instead
                        Guess.GetUsed = True
                        CurrentStrategy = "Guess"
                    End If
                Else
                    myGameplayForm.OpenCellProgram(Guess.GetCell.GetLocation) ' if the conditions to click a corner are not met then use the best guess
                    Guess.GetUsed = True
                    CurrentStrategy = "Guess"
                End If
            Else
                If FindCorner() IsNot Nothing Then ' if there is no guess then click the corner if possible
                    myGameplayForm.OpenCellProgram(FindCorner.GetLocation)
                Else
                    ClickRandom() ' failing all other possibilities (no corners or guess) then click a random cell
                End If
            End If
        End Sub

        Private Function FindCorner() As Cell 'looks at each corner and returns the first unopened one
            If Cells(0, Cells.GetUpperBound(1)).CellContents = "u" AndAlso SafeToClick(Cells(0, Cells.GetUpperBound(1))) Then
                CurrentStrategy = "Corner"
                Return Cells(0, Cells.GetUpperBound(1))
            ElseIf Cells(Cells.GetUpperBound(0), 0).CellContents = "u" AndAlso SafeToClick(Cells(Cells.GetUpperBound(0), 0)) Then
                CurrentStrategy = "Corner"
                Return Cells(Cells.GetUpperBound(0), 0)
            ElseIf Cells(Cells.GetUpperBound(0), Cells.GetUpperBound(1)).CellContents = "u" AndAlso SafeToClick(Cells(Cells.GetUpperBound(0), Cells.GetUpperBound(1))) Then
                CurrentStrategy = "Corner"
                Return Cells(Cells.GetUpperBound(0), Cells.GetUpperBound(1))
            End If
            Return Nothing
        End Function

        Function SafeToClick(Cell As Cell) As Boolean
            If Cell.IsMine Then Return False
            Dim x = Cell.GetIndex.X
            Dim y = Cell.GetIndex.Y
            If x = 0 Then
                For a = 0 To 2
                    For b = 0 To -2
                        If Cells(x + a, y + b).Adjacents.Count <> 0 Then Return False
                    Next
                Next
            ElseIf y = 0 Then
                For a = 0 To -2
                    For b = 0 To 2
                        If Cells(x + a, y + b).Adjacents.Count <> 0 Then Return False
                    Next
                Next
            Else
                For a = 0 To -2
                    For b = 0 To -2
                        If Cells(x + a, y + b).Adjacents.Count <> 0 Then Return False
                    Next
                Next
            End If
            Return True
        End Function
        Private Sub EndGame() ' runs when the game is either won or lost
            myLiveStatsForm.GameEndUpdate(GameOver) ' update the live stats
            If Guess.GetUsed And GameOver = "Loss" Then myLiveStatsForm.GuessUpdate("Fail") ' if a guess was used and the game was lost it was unsucessful
            If GameOver = "Loss" Then
                myLiveStatsForm.UpdateTable(CurrentStrategy) ' updating the strategy used when the game was lost
            End If
            FirstMove = True ' resetting the game and counters
            If GameOver = "Won" Then MoveCounts.Add(MoveCount) ' recording the amount of clicks used for each win
            MoveCount = 0
            myGameplayForm.ResetGame()
            HardestAlgorithm = ""
            GameCount += 1
        End Sub
        Overridable Function GetCells() As Cell(,)
            ReDim Cells(BoardStates.GetUpperBound(0), BoardStates.GetUpperBound(1))
            For x = 0 To BoardStates.GetUpperBound(0)
                For y = 0 To BoardStates.GetUpperBound(1)
                    Cells(x, y) = New Cell(BoardStates(x, y), New Point(x, y))
                Next
            Next
            Return Cells
        End Function
        Private Sub ClickRandom()  ' finding the first unknown cell which isnt a mine and clicking it
            For Each Cell In Cells
                If Cell.CellContents = "u" And Not Cell.IsMine Then
                    myGameplayForm.OpenCellProgram(Cell.GetLocation)
                    CurrentStrategy = "Random"
                    Exit Sub
                End If
            Next
        End Sub

    End Class

    Class ConstraintSolver ' acts as the second algorithm used to solve the board
        Private Guess As BestGuessCell
        Private SafeCells As List(Of Cell)
        Private OldCells(,) As Cell
        Private Cells(,) As Cell
        Private EquationList As New List(Of CoupledEquation)
        Private VariableList As New List(Of Variable)
        Sub New(CellArray As Cell(,), SafeCellList As List(Of Cell))
            OldCells = CellArray
            Cells = DeepClone(CellArray) ' two copies needed so changing one wont affect the other
            SafeCells = SafeCellList
        End Sub

        Public Sub FindNonTrivialSolutions()
            For Each Cell In Cells
                Cell.ReduceCell() ' remove the known mines from each cells adjacent
                If Cell.IsUseless = False Then AddToEquation(Cell) ' add it to a relevant equation for use in brute force if needed
            Next
            CombineEquations() ' combine equations with common variables to save useless computation
            Dim SharedAdjacentCount As Integer
            For Each Cell In Cells
                If Not Cell.IsUseless Then ' only consider relevant cells
                    For Each OtherCell In Cells
                        If Not OtherCell.IsUseless AndAlso Cell IsNot OtherCell AndAlso Not Cell.Adjacents.Count < OtherCell.Adjacents.Count Then ' only if cell has a higher number of adjacents then othercell to avoid negative errors
                            SharedAdjacentCount = Cell.CountSharedAdjacents(OtherCell) ' counting the number of common adjacent cells between the two
                            If SharedAdjacentCount = OtherCell.Adjacents.Count Then ' if cell contains all the adjacents of other cell then other cell can be substituted into it
                                Cell.RemoveSharedAdjacents(OtherCell) ' remove all the shared adjacents and subtract the number in othercell from the number in cell
                                If Val(Cell.CellContents) = 0 Then ' if there are no more mines left after the subtraction then the remaining adjacents must be safe
                                    For Each Adjacent In Cell.Adjacents
                                        If SafeCells.Find(Function(x) x.GetIndex = Adjacent.GetIndex) Is Nothing AndAlso Not Cells(OtherCell.GetIndex.X, OtherCell.GetIndex.Y).Adjacents.Contains(Adjacent) Then
                                            SafeCells.Add(Adjacent)
                                            '  SafeCellStrategy.Add("Non Trivial")
                                        End If
                                    Next
                                    OldCells(OtherCell.GetIndex.X, OtherCell.GetIndex.Y).UpdateMines(SafeCells) ' marking any known mines
                                    Cell.IsUseless = True
                                End If
                            End If
                        End If
                    Next
                End If
            Next
            If SafeCells.Count = 0 Then ' if no safecells are found then move to brute force
                EvaluateEquations()
            Else
                If myGame IsNot Nothing Then If myGame.HardestAlgorithm = "Safe" OrElse myGame.HardestAlgorithm = "" Then myGame.HardestAlgorithm = "Non-Trivial"
            End If
        End Sub

        Private Sub AddToEquation(Cell As Cell)
            Dim AddedtoEquation As Boolean = False
            If EquationList.Count = 0 Then ' if there is no equations then make a new one
                EquationList.Add(New CoupledEquation(Cell, EquationList, VariableList))
            Else
                For Each Equation In EquationList
                    For Each Adjacent In Cell.Adjacents
                        If Equation.GetVariables.Count + Cell.Adjacents.Count < 15 Then ' more than 15 variables in an equation becomes slow to compute
                            If Equation.GetVariables.Find(Function(x) x.GetCell Is Adjacent) IsNot Nothing Then ' if one of the cells adjacents is in an equation already then add to that one
                                Equation.AddVariable(Cell, EquationList, VariableList)
                                AddedtoEquation = True
                                Exit For
                            End If
                        End If
                    Next
                    If AddedtoEquation Then Exit For
                Next
                If Not AddedtoEquation Then EquationList.Add(New CoupledEquation(Cell, EquationList, VariableList)) ' if no equations contain any of the cells adjacents then make a new one
            End If
        End Sub

        Private Sub CombineEquations()
            For Each Equation In EquationList
                Dim VariableReplacements As New List(Of Variable)
                For Each Variable In Equation.GetVariables ' finding all copies of variables in equations which aren't the same in memory
                    If Not VariableList.Contains(Variable) Then
                        VariableReplacements.Add(VariableList.Find(Function(x) x.GetCell Is Variable.GetCell))
                    End If
                Next
                For Each Variable In VariableReplacements ' replacing the bad copies with a common version of each so they're updated simultaneously
                    Equation.GetVariables(Equation.GetVariables.FindIndex(Function(x) x.GetCell Is Variable.GetCell)) = Variable
                    For Each Constraint In Equation.GetConstraints ' doing the same for constraints
                        If Constraint.GetVariables.Contains(Variable) Then Constraint.GetVariables(Constraint.GetVariables.FindIndex(Function(x) x.GetCell Is Variable.GetCell)) = Variable
                    Next
                Next
            Next
            Dim EquationsToRemove As New List(Of CoupledEquation)
            For Each Equation In EquationList
                For Each OtherEquation In EquationList
                    If Equation IsNot OtherEquation AndAlso Not EquationsToRemove.Contains(OtherEquation) AndAlso Equation.GetVariables.Count > OtherEquation.GetVariables.Count Then ' avoiding negative errors when comparing equations
                        If Equation.GetVariables.Count + OtherEquation.GetVariables.Except(Equation.GetVariables).Count <= 15 Then ' keeping variable count under 16
                            If Equation.GetVariables.Find(Function(x) OtherEquation.GetVariables.Contains(x)) IsNot Nothing Then ' if they share a varibale then combine them
                                For Each Variable In OtherEquation.GetVariables
                                    If Not Equation.GetVariables.Contains(Variable) Then Equation.GetVariables.Add(Variable)
                                Next
                                For Each Constraint In OtherEquation.GetConstraints
                                    If Not Equation.GetConstraints.Contains(Constraint) Then Equation.GetConstraints.Add(Constraint)
                                Next
                                EquationsToRemove.Add(OtherEquation)
                            End If
                        Else
                            If OtherEquation.GetVariables.Except(Equation.GetVariables) Is Nothing Then ' if equation has all the variables other equation contains then remove it anyway
                                EquationsToRemove.Add(OtherEquation)
                            End If
                        End If
                    End If
                Next
            Next
            For Each Equation In EquationsToRemove ' remove excess equations
                EquationList.Remove(Equation)
            Next
        End Sub

        Private Sub EvaluateEquations()
            For Each Equation In EquationList ' tallying the variables frequency in the constraints to order them
                For Each Constraint In Equation.GetConstraints
                    For Each Variable In Constraint.GetVariables
                        Variable.GetTally += 1
                    Next
                Next
            Next
            'Parallel.ForEach(EquationList, Sub(Equation)
            '                                   Dim Solver As New BruteForceSolver(Equation, Cells, SafeCells, Guess)
            '                                   Solver.FindSolutions()
            '                                   Solver.DeduceSafeCells()
            '                                   For Each SafeCell In Solver.GetSafeCells
            '                                       If Not SafeCells.Contains(SafeCell) Then SafeCells.Add(SafeCell)
            '                                   Next
            '                               End Sub)
            For Each Equation In EquationList
                Dim Solver As New BruteForceSolver(Equation, Cells, SafeCells, OldCells)
                Solver.FindSolutions()
                Solver.DeduceSafeCells()
                For Each SafeCell In Solver.GetSafeCells
                    If Not SafeCells.Contains(SafeCell) Then SafeCells.Add(SafeCell)
                Next
                If SafeCells.Count = 0 Then
                    If Guess Is Nothing Then
                        Guess = Solver.GetGuess
                    ElseIf Solver.GetGuess.GetChanceSafe > Guess.GetChanceSafe Then
                        Guess = Solver.GetGuess
                    End If
                End If
            Next
        End Sub

        ReadOnly Property GetSafeCells As List(Of Cell)
            Get
                Return SafeCells
            End Get
        End Property

        ReadOnly Property GetGuess As BestGuessCell
            Get
                Return Guess
            End Get
        End Property

    End Class

    Class BruteForceSolver
        Private OldCells As Cell(,)
        Private Cells(,) As Cell
        Private SafeCells As List(Of Cell)
        Private Guess As BestGuessCell
        Private Equation As CoupledEquation
        Private VariableStack As New Stack(Of Variable)
        Private ReturnToStack As New Stack(Of Variable)
        Private VariablesToCheck As New List(Of Variable)
        Private Solutions As New List(Of Solution)
        Private SolutionFound As Boolean = True
        Public Sub New(EquationToSolve As CoupledEquation, CellArray(,) As Cell, SafeCellList As List(Of Cell), OriginalCells As Cell(,))
            OldCells = OriginalCells
            Guess = New BestGuessCell
            Cells = CellArray
            SafeCells = SafeCellList
            Equation = EquationToSolve
            Equation.GetVariables = Equation.GetVariables.OrderByDescending(Function(x) x.GetTally).ToList
            VariablesToCheck = Equation.GetVariables
        End Sub

        Public Sub FindSolutions()
            Do
                CreateStack()
                For Each Constraint In Equation.GetConstraints
                    If Not Constraint.IsSatisfied Then
                        SolutionFound = False
                        Exit For
                    End If
                Next
                If SolutionFound Then
                    Solutions.Add(New Solution(DeepClone(VariableStack).ToList))
                End If
                SolutionFound = True
                If ReturnToStack.Count = 0 Then Exit Do
                Do Until VariableStack.Peek Is ReturnToStack.Peek
                    VariableStack.Pop()
                Loop
                ReturnToStack.Pop()
                VariablesToCheck = Equation.GetVariables.GetRange(Equation.GetVariables.IndexOf(VariableStack.Peek), Equation.GetVariables.Count - Equation.GetVariables.IndexOf(VariableStack.Pop))
                For Each Variable In VariablesToCheck
                    If Variable IsNot VariablesToCheck(0) Then Variable.GetStatus = 0
                Next
            Loop
        End Sub

        Private Sub CreateStack()
            For Each Variable In VariablesToCheck
                If Variable.GetStatus = 1 Then
                    Variable.GetStatus = 0
                ElseIf Variable.GetStatus = 0 Then
                    Variable.GetStatus = 1
                End If
                For Each Constraint In Equation.GetConstraints
                    If Constraint.GetVariables.Find(Function(x) x.GetCell.GetIndex = Variable.GetCell.GetIndex) IsNot Nothing Then
                        If GetMineCount(VariablesToCheck.FindAll(Function(x) Constraint.GetIndexes.Contains(x.GetCell.GetIndex))) > Constraint.GetTotalMines Then
                            Variable.GetStatus = 0
                        End If
                    End If
                Next
                If Variable.GetStatus = 1 Then ReturnToStack.Push(Variable)
                VariableStack.Push(Variable)
            Next
        End Sub

        Private Function GetMineCount(ByRef ConstraintVariables As List(Of Variable)) As Integer
            Return TryCast(ConstraintVariables, IEnumerable(Of Variable)).Count(Function(x) x.GetStatus = 1)
        End Function

        Public Sub DeduceSafeCells()
            Dim CheckForConsistency As New List(Of Variable)
            For x = 0 To Solutions(0).GetVariables.Count - 1
                For Each Solution In Solutions
                    CheckForConsistency.Add(Solution.GetVariables.Find(Function(y) y.GetCell.GetIndex = Solutions(0).GetVariables(x).GetCell.GetIndex))
                Next
                If TryCast(CheckForConsistency, IEnumerable(Of Variable)).Count(Function(y) y.GetStatus = 0) = Solutions.Count Then
                    If Not SafeCells.Contains(Cells(CheckForConsistency(0).GetCell.GetIndex.X, CheckForConsistency(0).GetCell.GetIndex.Y)) Then SafeCells.Add(Cells(CheckForConsistency(0).GetCell.GetIndex.X, CheckForConsistency(0).GetCell.GetIndex.Y)) : If myGame.HardestAlgorithm <> "Guess" Then myGame.HardestAlgorithm = "Brute Force"               ' Strategies.Add("Coupled Multiple Solution")
                End If
                If TryCast(CheckForConsistency, IEnumerable(Of Variable)).Count(Function(y) y.GetStatus = 1) = Solutions.Count Then OldCells(CheckForConsistency(0).GetCell.GetIndex.X, CheckForConsistency(0).GetCell.GetIndex.Y).IsMine = True
                If SafeCells.Count = 0 Then Guess.BestGuess(Cells(CheckForConsistency(0).GetCell.GetIndex.X, CheckForConsistency(0).GetCell.GetIndex.Y), TryCast(CheckForConsistency, IEnumerable(Of Variable)).Count(Function(y) y.GetStatus = 0) / CheckForConsistency.Count)
                CheckForConsistency.Clear()
            Next
        End Sub
        ReadOnly Property GetSafeCells As List(Of Cell)
            Get
                Return SafeCells
            End Get
        End Property

        ReadOnly Property GetGuess As BestGuessCell
            Get
                Return Guess
            End Get
        End Property
    End Class
    Class BestGuessCell
        Private Cell As Cell
        Private ChanceSafe As Decimal
        Private Used As Boolean
        Public Sub BestGuess(NewGuess As Cell, NewChance As Decimal)
            If Cell Is Nothing Then
                Cell = NewGuess
                ChanceSafe = Math.Round(NewChance, 2)
            ElseIf NewChance > ChanceSafe Then
                Cell = NewGuess
                ChanceSafe = Math.Round(NewChance, 2)
            End If
        End Sub

        ReadOnly Property GetCell As Cell
            Get
                Return Cell
            End Get
        End Property

        ReadOnly Property GetChanceSafe As Decimal
            Get
                Return ChanceSafe
            End Get
        End Property

        Property GetUsed As Boolean
            Get
                Return Used
            End Get
            Set(value As Boolean)
                Used = value
            End Set
        End Property
    End Class

    <Serializable> Class Solution
        Private Variables As List(Of Variable)

        Public Sub New(VariablesinSolution As List(Of Variable))
            Variables = VariablesinSolution
        End Sub

        ReadOnly Property GetVariables As List(Of Variable)
            Get
                Return Variables
            End Get
        End Property

    End Class

    <Serializable> Class Constraint
        Private ConstraintVariables As New List(Of Variable)
        Private Mines As Integer

        Public Sub New(Cell As Cell, Variables As List(Of Variable), ByRef EquationList As List(Of CoupledEquation))
            For Each Equation In EquationList
                If Equation.GetConstraints.Find(Function(x) x.GetVariables Is Variables And x.GetTotalMines = Val(Cell.CellContents)) IsNot Nothing Then Exit Sub
            Next
            ConstraintVariables.AddRange(Variables)
            Mines = Val(Cell.CellContents)
        End Sub

        Private Function GetMineCount(ByRef ConstraintVariables As List(Of Variable)) As Integer
            Return TryCast(ConstraintVariables, IEnumerable(Of Variable)).Count(Function(x) x.GetStatus = 1)
        End Function

        ReadOnly Property IsSatisfied As Boolean
            Get
                If GetMineCount(GetVariables) = Mines Then Return True
                Return False
            End Get
        End Property
        ReadOnly Property GetVariables As List(Of Variable)
            Get
                Return ConstraintVariables
            End Get
        End Property
        ReadOnly Property GetTotalMines As Integer
            Get
                Return Mines
            End Get
        End Property

        ReadOnly Property GetIndexes As List(Of Point)
            Get
                Dim Indexes As New List(Of Point)
                For Each Variable In ConstraintVariables
                    Indexes.Add(Variable.GetCell.GetIndex)
                Next
                Return Indexes
            End Get
        End Property

        ReadOnly Property GetStatuses As List(Of Integer)
            Get
                Dim Status As New List(Of Integer)
                For Each Variable In ConstraintVariables
                    Status.Add(Variable.GetStatus)
                Next
                Return Status
            End Get
        End Property
    End Class

    <Serializable> Class Variable
        Private Cell As Cell
        Private Tally As Integer
        Private Status As Integer

        Public Sub New(NewCell As Cell)
            Cell = NewCell
            Tally = 0
            Status = 0
        End Sub
        ReadOnly Property GetCell As Cell
            Get
                Return Cell
            End Get
        End Property
        Property GetTally As Integer
            Get
                Return Tally
            End Get
            Set(value As Integer)
                Tally = value
            End Set
        End Property
        Property GetStatus As Integer
            Get
                Return Status
            End Get
            Set(value As Integer)
                Status = value
            End Set
        End Property
    End Class
    <Serializable> Class CoupledEquation
        Private Solutions As New List(Of Solution)
        Private Variables As New List(Of Variable)
        Private Constraints As New List(Of Constraint)
        Public Sub New(Cell As Cell, ByRef EquationList As List(Of CoupledEquation), ByRef VariableList As List(Of Variable))
            For Each Adjacent In Cell.Adjacents
                Variables.Add(New Variable(Adjacent))
            Next
            For Each Variable In Variables
                If Not VariableList.Contains(Variable) Then VariableList.Add(Variable)
            Next
            Constraints.Add(New Constraint(Cell, VariableList.FindAll(Function(x) Cell.Adjacents.Contains(x.GetCell)), EquationList))
        End Sub

        Public Sub AddVariable(Cell As Cell, ByRef EquationList As List(Of CoupledEquation), ByRef VariableList As List(Of Variable))
            Dim Found = False
            For Each Adjacent In Cell.Adjacents
                For Each Variable In Variables
                    If Adjacent Is Variable.GetCell Then : Found = True : Exit For : End If
                Next
                If Not Found Then Variables.Add(New Variable(Adjacent))
                Found = False
            Next
            For Each Variable In Variables
                If VariableList.Find(Function(x) x.GetCell Is Variable.GetCell) Is Nothing Then VariableList.Add(Variable)
            Next
            Constraints.Add(New Constraint(Cell, VariableList.FindAll(Function(x) Cell.Adjacents.Contains(x.GetCell)), EquationList))
        End Sub
        Property GetVariables() As List(Of Variable)
            Get
                Return Variables
            End Get
            Set(value As List(Of Variable))
                Variables = value
            End Set
        End Property

        ReadOnly Property GetConstraints As List(Of Constraint)
            Get
                Return Constraints
            End Get
        End Property

        ReadOnly Property GetIndexes As List(Of Point)
            Get
                Dim Indexes As New List(Of Point)
                For Each Variable In Variables
                    Indexes.Add(Variable.GetCell.GetIndex)
                Next
                Return Indexes
            End Get
        End Property

        Property GetSolutions As List(Of Solution)
            Get
                Return Solutions
            End Get
            Set(value As List(Of Solution))
                Solutions = value
            End Set
        End Property
    End Class

    <Serializable> Class Cell
        Private Colour As String
        Private Contents As Char
        Private Location As Point
        Private Index As Point
        Private AdjacentCells As New List(Of Cell)
        Private Useless As Boolean
        Private Mine As Boolean

        Public Sub New(Board As Bitmap, CellLocation As Point, CellIndex As Point, ByRef GameOver As String)
            Mine = False
            Useless = False
            Location = CellLocation
            Index = CellIndex
            GetCellColour(Board, Location, GameOver)
            Contents = GetCellState()
        End Sub

        Public Sub New(Board As Bitmap, CellLocation As Point, CellIndex As Point)
            Mine = False
            Useless = False
            Location = CellLocation
            Index = CellIndex
            GetCellColour(Board, Location)
            Contents = GetCellState()
        End Sub

        Public Sub New(State As Char, ArrIndex As Point)
            Contents = State
            Index = ArrIndex
            Location = New Point(ArrIndex.X * 16, ArrIndex.Y * 16)
            Mine = False
            Useless = False
        End Sub

        Private Sub GetCellColour(Board As Bitmap, Location As Point)
            Colour = ColorTranslator.ToHtml(Board.GetPixel(Location.X, Location.Y))
            If Colour = "#C0C0C0" Then
                If ColorTranslator.ToHtml(Board.GetPixel(Location.X + 1, Location.Y)) = "#000000" Then
                    Colour = "#000000"
                ElseIf ColorTranslator.ToHtml(Board.GetPixel(Location.X - 7, Location.Y - 7)) <> "#FFFFFF" Then
                    Colour = "#FFFFFF"
                End If
            ElseIf Colour = "#000000" Then
                If ColorTranslator.ToHtml(Board.GetPixel(Location.X, Location.Y - 1)) = "#FF0000" Then
                    Colour = "#C0C0C0"
                    Mine = True
                Else
                    Colour = Nothing
                End If
            End If
        End Sub
        Private Sub GetCellColour(Board As Bitmap, Location As Point, ByRef GameOver As String)
            Colour = ColorTranslator.ToHtml(Board.GetPixel(Location.X, Location.Y))
            If Colour = "#C0C0C0" Then
                If ColorTranslator.ToHtml(Board.GetPixel(Location.X + 1, Location.Y)) = "#000000" Then
                    Colour = "#000000"
                ElseIf ColorTranslator.ToHtml(Board.GetPixel(Location.X - 7, Location.Y - 7)) <> "#FFFFFF" Then
                    Colour = "#FFFFFF"
                End If
            ElseIf Colour = "#000000" Then
                If ColorTranslator.ToHtml(Board.GetPixel(Location.X, Location.Y - 1)) = "#FF0000" Then
                    GameOver = "Won"
                Else
                    GameOver = "Loss"
                End If
            End If
        End Sub
        Private Function GetCellState() As String
            If Colour = "#C0C0C0" Then Useless = True : Return "u"
            If Colour = "#FFFFFF" Then Useless = True : Return "0"
            If Colour = "#0000FF" Then Return "1"
            If Colour = "#008000" Then Return "2"
            If Colour = "#FF0000" Then Return "3"
            If Colour = "#000080" Then Return "4"
            If Colour = "#800000" Then Return "5"
            If Colour = "#008080" Then Return "6"
            If Colour = "#000000" Then Return "7"
            If Colour = "#808080" Then Return "8"
            Return Nothing
        End Function

        Public Sub CheckIfUseless()
            Dim MineCount = 0
            If AdjacentCells.Count <> 0 And Not Useless Then
                For Each AdjacentCell In AdjacentCells
                    If AdjacentCell.Mine Then MineCount += 1
                Next
                If MineCount = AdjacentCells.Count Then Useless = True
            End If
        End Sub

        Public Sub GenerateAdjacents(Cells(,) As Cell, BoardWidth As Integer, BoardHeight As Integer)
                If Contents <> "u" Then
                    AdjacentCells.Clear()
                    If Index.X <> BoardWidth Then If Cells(Index.X + 1, Index.Y).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X + 1, Index.Y))
                    If Index.Y <> BoardHeight Then If Cells(Index.X, Index.Y + 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X, Index.Y + 1))
                    If Index.X <> 0 Then If Cells(Index.X - 1, Index.Y).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X - 1, Index.Y))
                    If Index.Y <> 0 Then If Cells(Index.X, Index.Y - 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X, Index.Y - 1))
                    If Index.X <> BoardWidth And Index.Y <> BoardHeight Then If Cells(Index.X + 1, Index.Y + 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X + 1, Index.Y + 1))
                    If Index.X <> 0 And Index.Y <> 0 Then If Cells(Index.X - 1, Index.Y - 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X - 1, Index.Y - 1))
                    If Index.X <> BoardWidth And Index.Y <> 0 Then If Cells(Index.X + 1, Index.Y - 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X + 1, Index.Y - 1))
                    If Index.X <> 0 And Index.Y <> BoardHeight Then If Cells(Index.X - 1, Index.Y + 1).CellContents = "u" Then AdjacentCells.Add(Cells(Index.X - 1, Index.Y + 1))
                End If
        End Sub

        Public Sub CheckIfMine()
            If Not Useless Then
                If Adjacents.Count = Val(Contents) Then
                    For Each Cell In AdjacentCells
                        Cell.Mine = True
                    Next
                End If
            End If
        End Sub



        Public Function SimpleFinder() As List(Of Cell)
            Dim SafeCells As New List(Of Cell)
            '      If Not Useless Then
            Dim MineCount = 0
            For Each Cell In AdjacentCells : If Cell.Mine Then MineCount += 1
            Next
            If MineCount = Val(Contents) Then
                For Each Cell In AdjacentCells
                    If Not Cell.Mine Then
                        SafeCells.Add(Cell)
                        Useless = True
                    End If
                Next
            ElseIf MineCount > Val(Contents) Then
                SafeCells = Nothing
            End If
            '     End If
            Return SafeCells
        End Function

        Public Sub ReduceCell()
            If Val(Contents) > AdjacentCells.Count Then Useless = True
            If Useless = False Then
                Dim CellsToRemove As New List(Of Cell)
                For Each Cell In AdjacentCells
                    If Cell.Mine = True Then
                        CellsToRemove.Add(Cell)
                        Contents = CStr(Val(Contents) - 1)
                    End If
                Next
                For Each Cell In CellsToRemove
                    AdjacentCells.Remove(Cell)
                Next
            End If
        End Sub

        Public Function CountSharedAdjacents(OtherCell As Cell) As Integer
            Dim Count As Integer = 0
            For Each AdjacentCell In OtherCell.Adjacents
                If Adjacents.Contains(AdjacentCell) Then
                    Count += 1
                End If
            Next
            Return Count
        End Function

        Public Sub RemoveSharedAdjacents(OtherCell As Cell)
            For Each AdjacentCell In OtherCell.Adjacents
                Adjacents.Remove(AdjacentCell)
            Next
            Contents = CStr(Val(Contents) - Val(OtherCell.Contents))
        End Sub

        Public Sub UpdateMines(SafeCells As List(Of Cell))
            Dim SafeCount As Integer = 0
            For Each AdjacentCell In Adjacents
                If SafeCells.Find(Function(x) x.Index = AdjacentCell.Index) IsNot Nothing Then SafeCount += 1
            Next
            If Adjacents.Count - SafeCount = Val(Contents) Then
                For Each AdjacentCell In Adjacents
                    If SafeCells.Find(Function(x) x.Index = AdjacentCell.Index) Is Nothing Then AdjacentCell.Mine = True
                Next
            End If
        End Sub
        ReadOnly Property CellColour As String
            Get
                Return Colour
            End Get
        End Property

        Property CellContents As Char
            Get
                Return Contents
            End Get
            Set(value As Char)
                Contents = value
            End Set
        End Property

        ReadOnly Property Adjacents As List(Of Cell)
            Get
                Return AdjacentCells
            End Get
        End Property
        Property IsUseless As Boolean
            Get
                Return Useless
            End Get
            Set(value As Boolean)
                Useless = value
            End Set
        End Property

        Property IsMine As Boolean
            Get
                Return Mine
            End Get
            Set(value As Boolean)
                Mine = value
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

    End Class

End Module