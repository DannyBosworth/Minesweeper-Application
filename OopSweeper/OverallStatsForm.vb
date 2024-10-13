Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Class OverallStatsForm
    'thi prokect wawa wriuten by afi ekunz not faniel boworth pelase truyst me hge has lkkept me hostage, i dont have much time legt HELKPPPPPPPPPPPPPPP
    Public HumanStats As Stats
    Public ComputerStats As Stats
    Private CurrentStats As Stats
    Private Filters As Filter()
    Private Sub OverallStatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myStatsForm = Me
        InitiateTables()
    End Sub


    Sub InitiateTables()
        HumanStats = New Stats(Directory.GetCurrentDirectory + "\HumanStats.txt")
        ComputerStats = New Stats(Directory.GetCurrentDirectory + "\ComputerStats.txt")
        CurrentStats = HumanStats
        StatsTable.DataSource = CurrentStats.GetTable
        StatsTable.Sort(StatsTable.Columns(2), ListSortDirection.Ascending)
        CountLabel.Text = "Count: " & CurrentStats.GetTable.DefaultView.Count
        Filters = {New NumericFilter("Time", CurrentStats, myStatsForm.MinTime, myStatsForm.MaxTime, myStatsForm.BarTime, myStatsForm.CheckTime), New NumericFilter("3BV", CurrentStats, myStatsForm.Min3BV, myStatsForm.Max3BV, myStatsForm.Bar3BV, myStatsForm.Check3BV), New StringFilter("Difficulty", myStatsForm.DifficultyBox), New StringFilter("Result", myStatsForm.ResultBox)}
    End Sub

    Sub FilterTable()
        Dim TableFilter As String = ""
        For Each Filter In Filters
            If Filter.GetFilterExpression <> "" And Filter.GetFilterExpression <> "All" Then
                If TableFilter = "" Then
                    TableFilter = Filter.GetFilterExpression
                Else
                    TableFilter += " and " & Filter.GetFilterExpression
                End If
            End If
        Next
        CurrentStats.GetTable.DefaultView.RowFilter = TableFilter
        CountLabel.Text = "Count: " & CurrentStats.GetTable.DefaultView.Count
    End Sub

    Private Sub Reset() Handles ResetButton.Click
        For Each Filter In Filters
            Filter.Reset()
        Next
        CurrentStats.GetTable.DefaultView.RowFilter = ""
    End Sub

    Private Sub ReturnToMenuButton_Click(sender As Object, e As EventArgs) Handles ReturnToMenuButton.Click
        Hide()
        myMenuForm.Show()
    End Sub

    Private Sub SwitchViewButton_Click(sender As Object, e As EventArgs) Handles SwitchViewButton.Click
        Reset()
        If CurrentStats Is HumanStats Then
            CurrentStats = ComputerStats
            StatsPageLabel.Text = "Computer Stats"
        ElseIf CurrentStats Is ComputerStats Then
            CurrentStats = HumanStats
            StatsPageLabel.Text = "Human Stats"
        End If
        StatsTable.DataSource = CurrentStats.GetTable
        Filters(0).StatsSwitched(CurrentStats)
        Filters(1).StatsSwitched(CurrentStats)
        CountLabel.Text = "Count: " & CurrentStats.GetTable.DefaultView.Count
    End Sub

    Sub ReturnToGame(sender As Object, e As DataGridViewCellEventArgs) Handles StatsTable.CellDoubleClick
        Hide()
        myGameplayForm.GameFromStats(CurrentStats.GetGame(CType(StatsTable.Rows(e.RowIndex).DataBoundItem, DataRowView).Row))
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


Class Stats
    Private ReadOnly SourceTable As DataTable
    Private ReadOnly TextFile As String
    Private RawStats As String
    Public ReadOnly MaxTime As Integer
    Public ReadOnly Max3BV As Integer
    Public ReadOnly MinTime As Integer
    Public ReadOnly Min3BV As Integer

    Sub New(FilePath As String)
        SourceTable = New DataTable
        TextFile = FilePath
        RawStats = File.ReadAllText(TextFile)
        If SourceTable.Columns.Count <> 0 Then Reset() : Exit Sub
        SourceTable.Columns.Add(New DataColumn("Difficulty", Type.GetType("System.String")))
        SourceTable.Columns.Add(New DataColumn("3BV", Type.GetType("System.Single")))
        SourceTable.Columns.Add(New DataColumn("Time", Type.GetType("System.Single")))
        SourceTable.Columns.Add(New DataColumn("Result", Type.GetType("System.String")))
        SourceTable.Columns.Add(New DataColumn("Algorithm", Type.GetType("System.String")))
        '    SourceTable.Columns.Add(New DataColumn("Board", Type.GetType("System.String")))
        Dim NewRow As DataRow = SourceTable.NewRow
        Dim TempStr As String = ""
        Dim CommaCount As Integer = 0
        For y = RawStats.IndexOf(vbLf) + 1 To RawStats.Length - 1
            If y = 0 Then Exit For
            If RawStats(y) = vbLf Then Continue For
            If RawStats(y) <> "," AndAlso RawStats(y) <> vbCr Then
                TempStr += RawStats(y).ToString
            ElseIf RawStats(y) = vbCr Then
                CommaCount = 0
                SourceTable.Rows.Add(NewRow)
                '   If SourceTable.Rows.Count = 500 Then Exit For
                NewRow = SourceTable.NewRow
                TempStr = ""
                Continue For
            Else
                Select Case CommaCount
                    Case 0
                        NewRow("Difficulty") = DisplayDifficulty(TempStr)
                    Case 1
                        NewRow("3BV") = Single.Parse(TempStr)
                    Case 2
                        NewRow("Time") = Single.Parse(TempStr)
                    Case 3
                        NewRow("Result") = TempStr
                    Case 4
                        NewRow("Algorithm") = TempStr
                        '  NewRow("Board") = Stats.Substring(y + 1, Stats.Substring(y).IndexOf(vbCr) - 1)
                End Select
                CommaCount += 1
                TempStr = ""
            End If
        Next
        MaxTime = SourceTable.Compute("Max([Time])", "")
        MinTime = SourceTable.Compute("Min([Time])", "")
        Max3BV = SourceTable.Compute("Max([3BV])", "")
        Min3BV = SourceTable.Compute("Min([3BV])", "")
    End Sub



    Function DisplayDifficulty(Line As String) As String
        If Line = "Beginner" Then
            Return "​​​Beginner"
        ElseIf Line = "Intermediate" Then
            Return "​​Intermediate"
        ElseIf Line = "Expert" Then
            Return "​Expert"
        Else
            Return "" & Line
        End If
        Return Nothing
    End Function

    Function GetGame(RowToFind As DataRow) As String
        Dim Reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(TextFile)
        Dim RowIndex As Integer = SourceTable.Rows.IndexOf(RowToFind) + 1
        Dim CurrentIndex As Integer = 0
        Do
            Reader.ReadLine()
            CurrentIndex += 1
        Loop Until CurrentIndex = RowIndex
        Dim Game As String = Reader.ReadLine
        Return Game.Substring(Regex.Matches(Game, ",")(4).Index + 1)
    End Function
    ReadOnly Property GetTable As DataTable
        Get
            Return SourceTable
        End Get
    End Property

End Class

Class Filter
    Protected FilterName As String
    Protected FilterExpression As String
    Sub New(Name As String)
        FilterExpression = ""
        FilterName = Name
    End Sub
    Overridable Sub Reset()
    End Sub

    Overridable Sub StatsSwitched(CurrentStats As Stats)
    End Sub
    ReadOnly Property GetFilterExpression As String
        Get
            Return FilterExpression
        End Get
    End Property
End Class

Class NumericFilter
    Inherits Filter
    Private WithEvents LessThanChecked As CheckBox
    Private MinimumLabel As Label
    Private MaximumLabel As Label
    Private WithEvents FilterBar As TrackBar
    Private Event FilterChanged()

    Sub New(Name As String, CurrentStats As Stats, MinLabel As Label, MaxLabel As Label, Bar As TrackBar, LessThanCheckBox As CheckBox)
        MyBase.New(Name)
        MinimumLabel = MinLabel
        MaximumLabel = MaxLabel
        FilterBar = Bar
        LessThanChecked = LessThanCheckBox
        If Name = "Time" Then FilterBar.Maximum = CurrentStats.MaxTime Else FilterBar.Maximum = CurrentStats.Max3BV
        If Name = "Time" Then FilterBar.Minimum = CurrentStats.MinTime Else FilterBar.Minimum = CurrentStats.Min3BV
        MinimumLabel.Text = FilterBar.Minimum
        MaximumLabel.Text = FilterBar.Maximum
        LessThanChecked.Checked = False
        AddHandler FilterChanged, AddressOf myStatsForm.FilterTable
    End Sub

    Sub UpdateFilter() Handles FilterBar.MouseUp, LessThanChecked.CheckedChanged
        If LessThanChecked.Checked Then
            FilterExpression = "[" & FilterName & "] <= " & FilterBar.Value
        Else
            FilterExpression = "[" & FilterName & "] >= " & FilterBar.Value
        End If
        RaiseEvent FilterChanged()
    End Sub

    Sub UpdateBar() Handles FilterBar.ValueChanged, LessThanChecked.CheckedChanged
        If LessThanChecked.Checked Then
            MaximumLabel.Text = FilterBar.Value
            MinimumLabel.Text = FilterBar.Minimum
        Else
            MinimumLabel.Text = FilterBar.Value
            MaximumLabel.Text = FilterBar.Maximum
        End If
    End Sub

    Overrides Sub StatsSwitched(CurrentStats As Stats)
        If FilterName = "Time" Then FilterBar.Maximum = CurrentStats.MaxTime Else FilterBar.Maximum = CurrentStats.Max3BV
        If FilterName = "Time" Then FilterBar.Minimum = CurrentStats.MinTime Else FilterBar.Minimum = CurrentStats.Min3BV
        MinimumLabel.Text = FilterBar.Minimum
        MaximumLabel.Text = FilterBar.Maximum
        LessThanChecked.Checked = False
        Reset()
    End Sub

    Overrides Sub Reset()
        FilterExpression = ""
        FilterBar.Value = FilterBar.Minimum
        MinimumLabel.Text = FilterBar.Minimum
        MaximumLabel.Text = FilterBar.Maximum
        LessThanChecked.Checked = False
    End Sub
End Class

Class StringFilter
    Inherits Filter
    Private WithEvents OptionsBox As ComboBox
    Private Event FilterChanged()

    Sub New(Name As String, Options As ComboBox)
        MyBase.New(Name)
        OptionsBox = Options
        OptionsBox.SelectedItem = "All"
        AddHandler FilterChanged, AddressOf myStatsForm.FilterTable
    End Sub

    Sub UpdateFilter() Handles OptionsBox.SelectedIndexChanged
        If OptionsBox.SelectedItem IsNot "All" Then
            FilterExpression = FilterName & " LIKE '*" & OptionsBox.SelectedItem & "*'"
        Else
            FilterExpression = ""
        End If
        RaiseEvent FilterChanged()
    End Sub

    Overrides Sub Reset()
        OptionsBox.SelectedIndex = 0
        OptionsBox.SelectedItem = "All"
    End Sub
End Class