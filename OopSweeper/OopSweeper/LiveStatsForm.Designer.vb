<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiveStatsForm
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
        Me.GamesPlayedBox = New System.Windows.Forms.TextBox()
        Me.WinsBox = New System.Windows.Forms.TextBox()
        Me.LossesBox = New System.Windows.Forms.TextBox()
        Me.WinPercentBox = New System.Windows.Forms.TextBox()
        Me.GuessesMadeBox = New System.Windows.Forms.TextBox()
        Me.SuccessfulGuessesBox = New System.Windows.Forms.TextBox()
        Me.UnsuccessfulGuessesBox = New System.Windows.Forms.TextBox()
        Me.GuessPercentBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReturnToMenuButton = New System.Windows.Forms.Button()
        Me.LosingTable = New System.Windows.Forms.DataGridView()
        Me.CornerLossLabel = New System.Windows.Forms.Label()
        Me.GuessLossLabel = New System.Windows.Forms.Label()
        Me.SafeLossLabel = New System.Windows.Forms.Label()
        Me.RandomLossLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.LosingTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GamesPlayedBox
        '
        Me.GamesPlayedBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesPlayedBox.Location = New System.Drawing.Point(12, 40)
        Me.GamesPlayedBox.Name = "GamesPlayedBox"
        Me.GamesPlayedBox.Size = New System.Drawing.Size(100, 26)
        Me.GamesPlayedBox.TabIndex = 0
        Me.GamesPlayedBox.Text = "0"
        '
        'WinsBox
        '
        Me.WinsBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinsBox.Location = New System.Drawing.Point(12, 98)
        Me.WinsBox.Name = "WinsBox"
        Me.WinsBox.Size = New System.Drawing.Size(100, 26)
        Me.WinsBox.TabIndex = 1
        Me.WinsBox.Text = "0"
        '
        'LossesBox
        '
        Me.LossesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LossesBox.Location = New System.Drawing.Point(12, 167)
        Me.LossesBox.Name = "LossesBox"
        Me.LossesBox.Size = New System.Drawing.Size(100, 26)
        Me.LossesBox.TabIndex = 2
        Me.LossesBox.Text = "0"
        '
        'WinPercentBox
        '
        Me.WinPercentBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinPercentBox.Location = New System.Drawing.Point(12, 242)
        Me.WinPercentBox.Name = "WinPercentBox"
        Me.WinPercentBox.Size = New System.Drawing.Size(100, 26)
        Me.WinPercentBox.TabIndex = 3
        '
        'GuessesMadeBox
        '
        Me.GuessesMadeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessesMadeBox.Location = New System.Drawing.Point(155, 40)
        Me.GuessesMadeBox.Name = "GuessesMadeBox"
        Me.GuessesMadeBox.Size = New System.Drawing.Size(100, 26)
        Me.GuessesMadeBox.TabIndex = 4
        Me.GuessesMadeBox.Text = "0"
        '
        'SuccessfulGuessesBox
        '
        Me.SuccessfulGuessesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessfulGuessesBox.Location = New System.Drawing.Point(155, 98)
        Me.SuccessfulGuessesBox.Name = "SuccessfulGuessesBox"
        Me.SuccessfulGuessesBox.Size = New System.Drawing.Size(100, 26)
        Me.SuccessfulGuessesBox.TabIndex = 5
        Me.SuccessfulGuessesBox.Text = "0"
        '
        'UnsuccessfulGuessesBox
        '
        Me.UnsuccessfulGuessesBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsuccessfulGuessesBox.Location = New System.Drawing.Point(155, 167)
        Me.UnsuccessfulGuessesBox.Name = "UnsuccessfulGuessesBox"
        Me.UnsuccessfulGuessesBox.Size = New System.Drawing.Size(100, 26)
        Me.UnsuccessfulGuessesBox.TabIndex = 6
        Me.UnsuccessfulGuessesBox.Text = "0"
        '
        'GuessPercentBox
        '
        Me.GuessPercentBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessPercentBox.Location = New System.Drawing.Point(155, 242)
        Me.GuessPercentBox.Name = "GuessPercentBox"
        Me.GuessPercentBox.Size = New System.Drawing.Size(100, 26)
        Me.GuessPercentBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Games Played"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Wins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Losses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Win Percentage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(151, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Guesses Made"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Successful Guesses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(151, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Unsuccessful Guesses"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(151, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Percentage Successful Guesses"
        '
        'ReturnToMenuButton
        '
        Me.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenuButton.Location = New System.Drawing.Point(12, 437)
        Me.ReturnToMenuButton.Name = "ReturnToMenuButton"
        Me.ReturnToMenuButton.Size = New System.Drawing.Size(177, 35)
        Me.ReturnToMenuButton.TabIndex = 16
        Me.ReturnToMenuButton.Text = "RETURN TO MENU"
        Me.ReturnToMenuButton.UseVisualStyleBackColor = True
        '
        'LosingTable
        '
        Me.LosingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LosingTable.Location = New System.Drawing.Point(12, 298)
        Me.LosingTable.Name = "LosingTable"
        Me.LosingTable.Size = New System.Drawing.Size(243, 132)
        Me.LosingTable.TabIndex = 17
        '
        'CornerLossLabel
        '
        Me.CornerLossLabel.AutoSize = True
        Me.CornerLossLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CornerLossLabel.Location = New System.Drawing.Point(261, 298)
        Me.CornerLossLabel.Name = "CornerLossLabel"
        Me.CornerLossLabel.Size = New System.Drawing.Size(120, 20)
        Me.CornerLossLabel.TabIndex = 18
        Me.CornerLossLabel.Text = "Percent Corner:"
        '
        'GuessLossLabel
        '
        Me.GuessLossLabel.AutoSize = True
        Me.GuessLossLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLossLabel.Location = New System.Drawing.Point(261, 334)
        Me.GuessLossLabel.Name = "GuessLossLabel"
        Me.GuessLossLabel.Size = New System.Drawing.Size(119, 20)
        Me.GuessLossLabel.TabIndex = 19
        Me.GuessLossLabel.Text = "Percent Guess:"
        '
        'SafeLossLabel
        '
        Me.SafeLossLabel.AutoSize = True
        Me.SafeLossLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SafeLossLabel.Location = New System.Drawing.Point(261, 373)
        Me.SafeLossLabel.Name = "SafeLossLabel"
        Me.SafeLossLabel.Size = New System.Drawing.Size(106, 20)
        Me.SafeLossLabel.TabIndex = 20
        Me.SafeLossLabel.Text = "Percent Safe:"
        '
        'RandomLossLabel
        '
        Me.RandomLossLabel.AutoSize = True
        Me.RandomLossLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomLossLabel.Location = New System.Drawing.Point(261, 410)
        Me.RandomLossLabel.Name = "RandomLossLabel"
        Me.RandomLossLabel.Size = New System.Drawing.Size(133, 20)
        Me.RandomLossLabel.TabIndex = 21
        Me.RandomLossLabel.Text = "Percent Random:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "How Lost:"
        '
        'LiveStatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 484)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RandomLossLabel)
        Me.Controls.Add(Me.SafeLossLabel)
        Me.Controls.Add(Me.GuessLossLabel)
        Me.Controls.Add(Me.CornerLossLabel)
        Me.Controls.Add(Me.LosingTable)
        Me.Controls.Add(Me.ReturnToMenuButton)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GuessPercentBox)
        Me.Controls.Add(Me.UnsuccessfulGuessesBox)
        Me.Controls.Add(Me.SuccessfulGuessesBox)
        Me.Controls.Add(Me.GuessesMadeBox)
        Me.Controls.Add(Me.WinPercentBox)
        Me.Controls.Add(Me.LossesBox)
        Me.Controls.Add(Me.WinsBox)
        Me.Controls.Add(Me.GamesPlayedBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "LiveStatsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LiveStatsForm"
        CType(Me.LosingTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GamesPlayedBox As System.Windows.Forms.TextBox
    Friend WithEvents WinsBox As System.Windows.Forms.TextBox
    Friend WithEvents LossesBox As System.Windows.Forms.TextBox
    Friend WithEvents WinPercentBox As System.Windows.Forms.TextBox
    Friend WithEvents GuessesMadeBox As System.Windows.Forms.TextBox
    Friend WithEvents SuccessfulGuessesBox As System.Windows.Forms.TextBox
    Friend WithEvents UnsuccessfulGuessesBox As System.Windows.Forms.TextBox
    Friend WithEvents GuessPercentBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ReturnToMenuButton As System.Windows.Forms.Button
    Friend WithEvents LosingTable As DataGridView
    Friend WithEvents CornerLossLabel As Label
    Friend WithEvents GuessLossLabel As Label
    Friend WithEvents SafeLossLabel As Label
    Friend WithEvents RandomLossLabel As Label
    Friend WithEvents Label9 As Label
End Class
