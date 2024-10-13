<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameplayForm
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
        Me.BoardBox = New System.Windows.Forms.PictureBox()
        Me.UserOptionsBox = New System.Windows.Forms.GroupBox()
        Me.RandomPlayButton = New System.Windows.Forms.Button()
        Me.ReplayButton = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.TimeBox = New System.Windows.Forms.TextBox()
        Me.MinesBox = New System.Windows.Forms.NumericUpDown()
        Me.YSizeBox = New System.Windows.Forms.NumericUpDown()
        Me.XSizeBox = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DelayBox = New System.Windows.Forms.NumericUpDown()
        Me.ExpertButton = New System.Windows.Forms.Button()
        Me.IntermediateButton = New System.Windows.Forms.Button()
        Me.BeginnerButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlagWarningLabel = New System.Windows.Forms.Label()
        Me.ReturnToMenuButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GenerateBoardButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BoardBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserOptionsBox.SuspendLayout()
        CType(Me.MinesBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YSizeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XSizeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BoardBox
        '
        Me.BoardBox.Location = New System.Drawing.Point(3, 82)
        Me.BoardBox.Name = "BoardBox"
        Me.BoardBox.Size = New System.Drawing.Size(480, 256)
        Me.BoardBox.TabIndex = 0
        Me.BoardBox.TabStop = False
        '
        'UserOptionsBox
        '
        Me.UserOptionsBox.Controls.Add(Me.RandomPlayButton)
        Me.UserOptionsBox.Controls.Add(Me.ReplayButton)
        Me.UserOptionsBox.Controls.Add(Me.TimeLabel)
        Me.UserOptionsBox.Controls.Add(Me.ResetButton)
        Me.UserOptionsBox.Controls.Add(Me.TimeBox)
        Me.UserOptionsBox.Controls.Add(Me.MinesBox)
        Me.UserOptionsBox.Controls.Add(Me.YSizeBox)
        Me.UserOptionsBox.Controls.Add(Me.XSizeBox)
        Me.UserOptionsBox.Controls.Add(Me.Label6)
        Me.UserOptionsBox.Controls.Add(Me.DelayBox)
        Me.UserOptionsBox.Controls.Add(Me.ExpertButton)
        Me.UserOptionsBox.Controls.Add(Me.IntermediateButton)
        Me.UserOptionsBox.Controls.Add(Me.BeginnerButton)
        Me.UserOptionsBox.Controls.Add(Me.StopButton)
        Me.UserOptionsBox.Controls.Add(Me.Label5)
        Me.UserOptionsBox.Controls.Add(Me.FlagWarningLabel)
        Me.UserOptionsBox.Controls.Add(Me.ReturnToMenuButton)
        Me.UserOptionsBox.Controls.Add(Me.Label4)
        Me.UserOptionsBox.Controls.Add(Me.GenerateBoardButton)
        Me.UserOptionsBox.Controls.Add(Me.PlayButton)
        Me.UserOptionsBox.Controls.Add(Me.Label2)
        Me.UserOptionsBox.Controls.Add(Me.Label1)
        Me.UserOptionsBox.Location = New System.Drawing.Point(489, 3)
        Me.UserOptionsBox.Name = "UserOptionsBox"
        Me.UserOptionsBox.Size = New System.Drawing.Size(361, 398)
        Me.UserOptionsBox.TabIndex = 13
        Me.UserOptionsBox.TabStop = False
        '
        'RandomPlayButton
        '
        Me.RandomPlayButton.BackColor = System.Drawing.Color.Red
        Me.RandomPlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RandomPlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RandomPlayButton.Location = New System.Drawing.Point(228, 196)
        Me.RandomPlayButton.Name = "RandomPlayButton"
        Me.RandomPlayButton.Size = New System.Drawing.Size(121, 58)
        Me.RandomPlayButton.TabIndex = 36
        Me.RandomPlayButton.Text = "Play Random Boards"
        Me.RandomPlayButton.UseVisualStyleBackColor = False
        '
        'ReplayButton
        '
        Me.ReplayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReplayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplayButton.Location = New System.Drawing.Point(101, 196)
        Me.ReplayButton.Name = "ReplayButton"
        Me.ReplayButton.Size = New System.Drawing.Size(121, 58)
        Me.ReplayButton.TabIndex = 35
        Me.ReplayButton.Text = "Reset Current Game"
        Me.ReplayButton.UseVisualStyleBackColor = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(197, 345)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(43, 20)
        Me.TimeLabel.TabIndex = 34
        Me.TimeLabel.Text = "Time"
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Image = Global.OopSweeper.My.Resources.Resources.ResetButton
        Me.ResetButton.Location = New System.Drawing.Point(13, 260)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(74, 79)
        Me.ResetButton.TabIndex = 9
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TimeBox
        '
        Me.TimeBox.Location = New System.Drawing.Point(194, 372)
        Me.TimeBox.Name = "TimeBox"
        Me.TimeBox.ReadOnly = True
        Me.TimeBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeBox.TabIndex = 33
        '
        'MinesBox
        '
        Me.MinesBox.Location = New System.Drawing.Point(134, 120)
        Me.MinesBox.Maximum = New Decimal(New Integer() {2499, 0, 0, 0})
        Me.MinesBox.Name = "MinesBox"
        Me.MinesBox.Size = New System.Drawing.Size(46, 20)
        Me.MinesBox.TabIndex = 32
        '
        'YSizeBox
        '
        Me.YSizeBox.Location = New System.Drawing.Point(72, 120)
        Me.YSizeBox.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.YSizeBox.Name = "YSizeBox"
        Me.YSizeBox.Size = New System.Drawing.Size(46, 20)
        Me.YSizeBox.TabIndex = 31
        '
        'XSizeBox
        '
        Me.XSizeBox.Location = New System.Drawing.Point(15, 120)
        Me.XSizeBox.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.XSizeBox.Name = "XSizeBox"
        Me.XSizeBox.Size = New System.Drawing.Size(46, 20)
        Me.XSizeBox.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Delay (ms)"
        '
        'DelayBox
        '
        Me.DelayBox.Location = New System.Drawing.Point(13, 228)
        Me.DelayBox.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.DelayBox.Name = "DelayBox"
        Me.DelayBox.Size = New System.Drawing.Size(82, 20)
        Me.DelayBox.TabIndex = 29
        '
        'ExpertButton
        '
        Me.ExpertButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExpertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExpertButton.Location = New System.Drawing.Point(239, 146)
        Me.ExpertButton.Name = "ExpertButton"
        Me.ExpertButton.Size = New System.Drawing.Size(95, 37)
        Me.ExpertButton.TabIndex = 28
        Me.ExpertButton.Text = "Expert"
        Me.ExpertButton.UseVisualStyleBackColor = True
        '
        'IntermediateButton
        '
        Me.IntermediateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IntermediateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntermediateButton.Location = New System.Drawing.Point(119, 146)
        Me.IntermediateButton.Name = "IntermediateButton"
        Me.IntermediateButton.Size = New System.Drawing.Size(114, 37)
        Me.IntermediateButton.TabIndex = 27
        Me.IntermediateButton.Text = "Intermediate"
        Me.IntermediateButton.UseVisualStyleBackColor = True
        '
        'BeginnerButton
        '
        Me.BeginnerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BeginnerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginnerButton.Location = New System.Drawing.Point(25, 146)
        Me.BeginnerButton.Name = "BeginnerButton"
        Me.BeginnerButton.Size = New System.Drawing.Size(88, 37)
        Me.BeginnerButton.TabIndex = 26
        Me.BeginnerButton.Text = "Beginner"
        Me.BeginnerButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.Location = New System.Drawing.Point(227, 260)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(128, 79)
        Me.StopButton.TabIndex = 25
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(130, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Mines"
        '
        'FlagWarningLabel
        '
        Me.FlagWarningLabel.AutoSize = True
        Me.FlagWarningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.FlagWarningLabel.Location = New System.Drawing.Point(7, 370)
        Me.FlagWarningLabel.Name = "FlagWarningLabel"
        Me.FlagWarningLabel.Size = New System.Drawing.Size(0, 16)
        Me.FlagWarningLabel.TabIndex = 22
        '
        'ReturnToMenuButton
        '
        Me.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenuButton.Location = New System.Drawing.Point(6, 345)
        Me.ReturnToMenuButton.Name = "ReturnToMenuButton"
        Me.ReturnToMenuButton.Size = New System.Drawing.Size(174, 48)
        Me.ReturnToMenuButton.TabIndex = 20
        Me.ReturnToMenuButton.Text = "Return To Menu"
        Me.ReturnToMenuButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Play The Game"
        '
        'GenerateBoardButton
        '
        Me.GenerateBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateBoardButton.Location = New System.Drawing.Point(201, 87)
        Me.GenerateBoardButton.Name = "GenerateBoardButton"
        Me.GenerateBoardButton.Size = New System.Drawing.Size(150, 53)
        Me.GenerateBoardButton.TabIndex = 2
        Me.GenerateBoardButton.Text = "Generate Custom Board"
        Me.GenerateBoardButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Location = New System.Drawing.Point(93, 260)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(128, 79)
        Me.PlayButton.TabIndex = 4
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Height"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Width"
        '
        'GameplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 409)
        Me.Controls.Add(Me.UserOptionsBox)
        Me.Controls.Add(Me.BoardBox)
        Me.Name = "GameplayForm"
        Me.Text = "GameplayForm"
        CType(Me.BoardBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserOptionsBox.ResumeLayout(False)
        Me.UserOptionsBox.PerformLayout()
        CType(Me.MinesBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YSizeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XSizeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelayBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BoardBox As PictureBox
    Friend WithEvents UserOptionsBox As GroupBox
    Friend WithEvents FlagWarningLabel As Label
    Friend WithEvents ReturnToMenuButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ResetButton As Button
    Friend WithEvents GenerateBoardButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StopButton As Button
    Friend WithEvents ExpertButton As Button
    Friend WithEvents IntermediateButton As Button
    Friend WithEvents BeginnerButton As Button
    Friend WithEvents MinesBox As NumericUpDown
    Friend WithEvents YSizeBox As NumericUpDown
    Friend WithEvents XSizeBox As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents DelayBox As NumericUpDown
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents TimeBox As System.Windows.Forms.TextBox
    Friend WithEvents ReplayButton As Button
    Friend WithEvents RandomPlayButton As Button
End Class
