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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiveStatsForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CornerLossLabel = New System.Windows.Forms.Label()
        Me.GuessLossLabel = New System.Windows.Forms.Label()
        Me.SafeLossLabel = New System.Windows.Forms.Label()
        Me.RandomLossLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GamesPlayedBox = New System.Windows.Forms.Label()
        Me.GuessesMadeBox = New System.Windows.Forms.Label()
        Me.WinsBox = New System.Windows.Forms.Label()
        Me.SuccessfulGuessesBox = New System.Windows.Forms.Label()
        Me.LossesBox = New System.Windows.Forms.Label()
        Me.UnsuccessfulGuessesBox = New System.Windows.Forms.Label()
        Me.WinPercentBox = New System.Windows.Forms.Label()
        Me.GuessPercentBox = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Games Played"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Wins"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Losses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Win Percentage"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(151, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Guesses Made"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(151, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Successful Guesses"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(151, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Unsuccessful Guesses"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(151, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Percentage Successful Guesses"
        '
        'CornerLossLabel
        '
        Me.CornerLossLabel.AutoSize = True
        Me.CornerLossLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CornerLossLabel.ForeColor = System.Drawing.Color.White
        Me.CornerLossLabel.Location = New System.Drawing.Point(26, 313)
        Me.CornerLossLabel.Name = "CornerLossLabel"
        Me.CornerLossLabel.Size = New System.Drawing.Size(57, 19)
        Me.CornerLossLabel.TabIndex = 18
        Me.CornerLossLabel.Text = "Corner"
        '
        'GuessLossLabel
        '
        Me.GuessLossLabel.AutoSize = True
        Me.GuessLossLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLossLabel.ForeColor = System.Drawing.Color.White
        Me.GuessLossLabel.Location = New System.Drawing.Point(26, 392)
        Me.GuessLossLabel.Name = "GuessLossLabel"
        Me.GuessLossLabel.Size = New System.Drawing.Size(51, 19)
        Me.GuessLossLabel.TabIndex = 19
        Me.GuessLossLabel.Text = "Guess"
        '
        'SafeLossLabel
        '
        Me.SafeLossLabel.AutoSize = True
        Me.SafeLossLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SafeLossLabel.ForeColor = System.Drawing.Color.White
        Me.SafeLossLabel.Location = New System.Drawing.Point(199, 313)
        Me.SafeLossLabel.Name = "SafeLossLabel"
        Me.SafeLossLabel.Size = New System.Drawing.Size(39, 19)
        Me.SafeLossLabel.TabIndex = 20
        Me.SafeLossLabel.Text = "Safe"
        '
        'RandomLossLabel
        '
        Me.RandomLossLabel.AutoSize = True
        Me.RandomLossLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomLossLabel.ForeColor = System.Drawing.Color.White
        Me.RandomLossLabel.Location = New System.Drawing.Point(199, 392)
        Me.RandomLossLabel.Name = "RandomLossLabel"
        Me.RandomLossLabel.Size = New System.Drawing.Size(68, 19)
        Me.RandomLossLabel.TabIndex = 21
        Me.RandomLossLabel.Text = "Random"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(19, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Percentage of Games lost by:"
        '
        'GamesPlayedBox
        '
        Me.GamesPlayedBox.AutoSize = True
        Me.GamesPlayedBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamesPlayedBox.ForeColor = System.Drawing.Color.White
        Me.GamesPlayedBox.Location = New System.Drawing.Point(32, 40)
        Me.GamesPlayedBox.Name = "GamesPlayedBox"
        Me.GamesPlayedBox.Size = New System.Drawing.Size(19, 19)
        Me.GamesPlayedBox.TabIndex = 23
        Me.GamesPlayedBox.Text = "0"
        '
        'GuessesMadeBox
        '
        Me.GuessesMadeBox.AutoSize = True
        Me.GuessesMadeBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessesMadeBox.ForeColor = System.Drawing.Color.White
        Me.GuessesMadeBox.Location = New System.Drawing.Point(162, 40)
        Me.GuessesMadeBox.Name = "GuessesMadeBox"
        Me.GuessesMadeBox.Size = New System.Drawing.Size(19, 19)
        Me.GuessesMadeBox.TabIndex = 24
        Me.GuessesMadeBox.Text = "0"
        '
        'WinsBox
        '
        Me.WinsBox.AutoSize = True
        Me.WinsBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinsBox.ForeColor = System.Drawing.Color.White
        Me.WinsBox.Location = New System.Drawing.Point(32, 98)
        Me.WinsBox.Name = "WinsBox"
        Me.WinsBox.Size = New System.Drawing.Size(19, 19)
        Me.WinsBox.TabIndex = 25
        Me.WinsBox.Text = "0"
        '
        'SuccessfulGuessesBox
        '
        Me.SuccessfulGuessesBox.AutoSize = True
        Me.SuccessfulGuessesBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuccessfulGuessesBox.ForeColor = System.Drawing.Color.White
        Me.SuccessfulGuessesBox.Location = New System.Drawing.Point(162, 98)
        Me.SuccessfulGuessesBox.Name = "SuccessfulGuessesBox"
        Me.SuccessfulGuessesBox.Size = New System.Drawing.Size(19, 19)
        Me.SuccessfulGuessesBox.TabIndex = 26
        Me.SuccessfulGuessesBox.Text = "0"
        '
        'LossesBox
        '
        Me.LossesBox.AutoSize = True
        Me.LossesBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LossesBox.ForeColor = System.Drawing.Color.White
        Me.LossesBox.Location = New System.Drawing.Point(32, 167)
        Me.LossesBox.Name = "LossesBox"
        Me.LossesBox.Size = New System.Drawing.Size(19, 19)
        Me.LossesBox.TabIndex = 27
        Me.LossesBox.Text = "0"
        '
        'UnsuccessfulGuessesBox
        '
        Me.UnsuccessfulGuessesBox.AutoSize = True
        Me.UnsuccessfulGuessesBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnsuccessfulGuessesBox.ForeColor = System.Drawing.Color.White
        Me.UnsuccessfulGuessesBox.Location = New System.Drawing.Point(162, 167)
        Me.UnsuccessfulGuessesBox.Name = "UnsuccessfulGuessesBox"
        Me.UnsuccessfulGuessesBox.Size = New System.Drawing.Size(19, 19)
        Me.UnsuccessfulGuessesBox.TabIndex = 28
        Me.UnsuccessfulGuessesBox.Text = "0"
        '
        'WinPercentBox
        '
        Me.WinPercentBox.AutoSize = True
        Me.WinPercentBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinPercentBox.ForeColor = System.Drawing.Color.White
        Me.WinPercentBox.Location = New System.Drawing.Point(32, 242)
        Me.WinPercentBox.Name = "WinPercentBox"
        Me.WinPercentBox.Size = New System.Drawing.Size(0, 19)
        Me.WinPercentBox.TabIndex = 29
        '
        'GuessPercentBox
        '
        Me.GuessPercentBox.AutoSize = True
        Me.GuessPercentBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessPercentBox.ForeColor = System.Drawing.Color.White
        Me.GuessPercentBox.Location = New System.Drawing.Point(162, 242)
        Me.GuessPercentBox.Name = "GuessPercentBox"
        Me.GuessPercentBox.Size = New System.Drawing.Size(0, 19)
        Me.GuessPercentBox.TabIndex = 30
        '
        'LiveStatsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(393, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuessPercentBox)
        Me.Controls.Add(Me.WinPercentBox)
        Me.Controls.Add(Me.UnsuccessfulGuessesBox)
        Me.Controls.Add(Me.LossesBox)
        Me.Controls.Add(Me.SuccessfulGuessesBox)
        Me.Controls.Add(Me.WinsBox)
        Me.Controls.Add(Me.GuessesMadeBox)
        Me.Controls.Add(Me.GamesPlayedBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RandomLossLabel)
        Me.Controls.Add(Me.SafeLossLabel)
        Me.Controls.Add(Me.GuessLossLabel)
        Me.Controls.Add(Me.CornerLossLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LiveStatsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CornerLossLabel As Label
    Friend WithEvents GuessLossLabel As Label
    Friend WithEvents SafeLossLabel As Label
    Friend WithEvents RandomLossLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GamesPlayedBox As Label
    Friend WithEvents GuessesMadeBox As Label
    Friend WithEvents WinsBox As Label
    Friend WithEvents SuccessfulGuessesBox As Label
    Friend WithEvents LossesBox As Label
    Friend WithEvents UnsuccessfulGuessesBox As Label
    Friend WithEvents WinPercentBox As Label
    Friend WithEvents GuessPercentBox As Label
End Class
