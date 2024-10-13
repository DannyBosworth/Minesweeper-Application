<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverallStatsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverallStatsForm))
        Me.BarTime = New System.Windows.Forms.TrackBar()
        Me.DifficultyBox = New System.Windows.Forms.ComboBox()
        Me.StatsTable = New System.Windows.Forms.DataGridView()
        Me.Bar3BV = New System.Windows.Forms.TrackBar()
        Me.MinTime = New System.Windows.Forms.Label()
        Me.MaxTime = New System.Windows.Forms.Label()
        Me.Min3BV = New System.Windows.Forms.Label()
        Me.Max3BV = New System.Windows.Forms.Label()
        Me.CheckTime = New System.Windows.Forms.CheckBox()
        Me.Check3BV = New System.Windows.Forms.CheckBox()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ReturnToMenuButton = New System.Windows.Forms.Button()
        Me.ResultBox = New System.Windows.Forms.ComboBox()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StatsPageLabel = New System.Windows.Forms.Label()
        Me.SwitchViewButton = New System.Windows.Forms.Button()
        CType(Me.BarTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar3BV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarTime
        '
        Me.BarTime.Location = New System.Drawing.Point(545, 340)
        Me.BarTime.Maximum = 2
        Me.BarTime.Name = "BarTime"
        Me.BarTime.Size = New System.Drawing.Size(121, 45)
        Me.BarTime.TabIndex = 5
        '
        'DifficultyBox
        '
        Me.DifficultyBox.FormattingEnabled = True
        Me.DifficultyBox.Items.AddRange(New Object() {"All", "Beginner", "Intermediate", "Expert", "Custom"})
        Me.DifficultyBox.Location = New System.Drawing.Point(491, 181)
        Me.DifficultyBox.Name = "DifficultyBox"
        Me.DifficultyBox.Size = New System.Drawing.Size(121, 21)
        Me.DifficultyBox.TabIndex = 6
        '
        'StatsTable
        '
        Me.StatsTable.AllowUserToAddRows = False
        Me.StatsTable.AllowUserToDeleteRows = False
        Me.StatsTable.AllowUserToResizeColumns = False
        Me.StatsTable.AllowUserToResizeRows = False
        Me.StatsTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.StatsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StatsTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.StatsTable.Location = New System.Drawing.Point(12, 60)
        Me.StatsTable.Name = "StatsTable"
        Me.StatsTable.ReadOnly = True
        Me.StatsTable.Size = New System.Drawing.Size(442, 560)
        Me.StatsTable.TabIndex = 7
        '
        'Bar3BV
        '
        Me.Bar3BV.Location = New System.Drawing.Point(545, 438)
        Me.Bar3BV.Maximum = 2
        Me.Bar3BV.Name = "Bar3BV"
        Me.Bar3BV.Size = New System.Drawing.Size(117, 45)
        Me.Bar3BV.TabIndex = 8
        '
        'MinTime
        '
        Me.MinTime.AutoSize = True
        Me.MinTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinTime.ForeColor = System.Drawing.Color.White
        Me.MinTime.Location = New System.Drawing.Point(487, 341)
        Me.MinTime.Name = "MinTime"
        Me.MinTime.Size = New System.Drawing.Size(18, 20)
        Me.MinTime.TabIndex = 11
        Me.MinTime.Text = "0"
        '
        'MaxTime
        '
        Me.MaxTime.AutoSize = True
        Me.MaxTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxTime.ForeColor = System.Drawing.Color.White
        Me.MaxTime.Location = New System.Drawing.Point(668, 341)
        Me.MaxTime.Name = "MaxTime"
        Me.MaxTime.Size = New System.Drawing.Size(18, 20)
        Me.MaxTime.TabIndex = 12
        Me.MaxTime.Text = "0"
        '
        'Min3BV
        '
        Me.Min3BV.AutoSize = True
        Me.Min3BV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min3BV.ForeColor = System.Drawing.Color.White
        Me.Min3BV.Location = New System.Drawing.Point(487, 438)
        Me.Min3BV.Name = "Min3BV"
        Me.Min3BV.Size = New System.Drawing.Size(18, 20)
        Me.Min3BV.TabIndex = 13
        Me.Min3BV.Text = "0"
        '
        'Max3BV
        '
        Me.Max3BV.AutoSize = True
        Me.Max3BV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Max3BV.ForeColor = System.Drawing.Color.White
        Me.Max3BV.Location = New System.Drawing.Point(668, 438)
        Me.Max3BV.Name = "Max3BV"
        Me.Max3BV.Size = New System.Drawing.Size(18, 20)
        Me.Max3BV.TabIndex = 14
        Me.Max3BV.Text = "0"
        '
        'CheckTime
        '
        Me.CheckTime.AutoSize = True
        Me.CheckTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckTime.ForeColor = System.Drawing.Color.White
        Me.CheckTime.Location = New System.Drawing.Point(725, 340)
        Me.CheckTime.Name = "CheckTime"
        Me.CheckTime.Size = New System.Drawing.Size(107, 23)
        Me.CheckTime.TabIndex = 17
        Me.CheckTime.Text = "Less Than?"
        Me.CheckTime.UseVisualStyleBackColor = True
        '
        'Check3BV
        '
        Me.Check3BV.AutoSize = True
        Me.Check3BV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check3BV.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check3BV.ForeColor = System.Drawing.Color.White
        Me.Check3BV.Location = New System.Drawing.Point(725, 437)
        Me.Check3BV.Name = "Check3BV"
        Me.Check3BV.Size = New System.Drawing.Size(107, 23)
        Me.Check3BV.TabIndex = 18
        Me.Check3BV.Text = "Less Than?"
        Me.Check3BV.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.White
        Me.ResetButton.Location = New System.Drawing.Point(697, 193)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(101, 62)
        Me.ResetButton.TabIndex = 20
        Me.ResetButton.Text = "Reset Filter"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ReturnToMenuButton
        '
        Me.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnToMenuButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenuButton.ForeColor = System.Drawing.Color.White
        Me.ReturnToMenuButton.Location = New System.Drawing.Point(611, 9)
        Me.ReturnToMenuButton.Name = "ReturnToMenuButton"
        Me.ReturnToMenuButton.Size = New System.Drawing.Size(219, 33)
        Me.ReturnToMenuButton.TabIndex = 21
        Me.ReturnToMenuButton.Text = "RETURN TO MENU"
        Me.ReturnToMenuButton.UseVisualStyleBackColor = True
        '
        'ResultBox
        '
        Me.ResultBox.FormattingEnabled = True
        Me.ResultBox.Items.AddRange(New Object() {"All", "Win", "Loss"})
        Me.ResultBox.Location = New System.Drawing.Point(491, 251)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(121, 21)
        Me.ResultBox.TabIndex = 22
        '
        'CountLabel
        '
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountLabel.ForeColor = System.Drawing.Color.White
        Me.CountLabel.Location = New System.Drawing.Point(12, 630)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(46, 13)
        Me.CountLabel.TabIndex = 23
        Me.CountLabel.Text = "Count : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(479, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Filter Difficulty:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(479, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Filter Result:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(487, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Filter Time:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(487, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Filter 3BV:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(479, 552)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Sort By Clicking Column Headers"
        '
        'StatsPageLabel
        '
        Me.StatsPageLabel.AutoSize = True
        Me.StatsPageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StatsPageLabel.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsPageLabel.ForeColor = System.Drawing.Color.White
        Me.StatsPageLabel.Location = New System.Drawing.Point(12, 9)
        Me.StatsPageLabel.Name = "StatsPageLabel"
        Me.StatsPageLabel.Size = New System.Drawing.Size(201, 35)
        Me.StatsPageLabel.TabIndex = 30
        Me.StatsPageLabel.Text = "Human Stats:"
        '
        'SwitchViewButton
        '
        Me.SwitchViewButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SwitchViewButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwitchViewButton.ForeColor = System.Drawing.Color.White
        Me.SwitchViewButton.Location = New System.Drawing.Point(286, 9)
        Me.SwitchViewButton.Name = "SwitchViewButton"
        Me.SwitchViewButton.Size = New System.Drawing.Size(219, 33)
        Me.SwitchViewButton.TabIndex = 31
        Me.SwitchViewButton.Text = "Switch Stats Page"
        Me.SwitchViewButton.UseVisualStyleBackColor = True
        '
        'OverallStatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.SwitchViewButton)
        Me.Controls.Add(Me.StatsPageLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CountLabel)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.ReturnToMenuButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Check3BV)
        Me.Controls.Add(Me.CheckTime)
        Me.Controls.Add(Me.Max3BV)
        Me.Controls.Add(Me.Min3BV)
        Me.Controls.Add(Me.MaxTime)
        Me.Controls.Add(Me.MinTime)
        Me.Controls.Add(Me.Bar3BV)
        Me.Controls.Add(Me.StatsTable)
        Me.Controls.Add(Me.DifficultyBox)
        Me.Controls.Add(Me.BarTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OverallStatsForm"
        CType(Me.BarTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar3BV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarTime As TrackBar
    Friend WithEvents DifficultyBox As ComboBox
    Friend WithEvents StatsTable As DataGridView
    Friend WithEvents Bar3BV As TrackBar
    Friend WithEvents MinTime As Label
    Friend WithEvents MaxTime As Label
    Friend WithEvents Min3BV As Label
    Friend WithEvents Max3BV As Label
    Friend WithEvents CheckTime As CheckBox
    Friend WithEvents Check3BV As CheckBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents ReturnToMenuButton As Button
    Friend WithEvents ResultBox As ComboBox
    Friend WithEvents CountLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StatsPageLabel As Label
    Friend WithEvents SwitchViewButton As Button
End Class
