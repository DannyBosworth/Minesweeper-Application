<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomBoardForm
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
        Me.XSizeBox = New System.Windows.Forms.TextBox()
        Me.YSizeBox = New System.Windows.Forms.TextBox()
        Me.GenerateBoardButton = New System.Windows.Forms.Button()
        Me.SolveButton = New System.Windows.Forms.Button()
        Me.ImageButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserOptionsBox = New System.Windows.Forms.GroupBox()
        Me.FlagWarningLabel = New System.Windows.Forms.Label()
        Me.ClearShadingButton = New System.Windows.Forms.Button()
        Me.ReturnToMenuButton = New System.Windows.Forms.Button()
        Me.GuessLabel = New System.Windows.Forms.Label()
        Me.MineLabel = New System.Windows.Forms.Label()
        Me.SafeLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SolvedBoardBox = New System.Windows.Forms.PictureBox()
        Me.UserOptionsBox.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolvedBoardBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XSizeBox
        '
        Me.XSizeBox.Location = New System.Drawing.Point(6, 120)
        Me.XSizeBox.Name = "XSizeBox"
        Me.XSizeBox.Size = New System.Drawing.Size(50, 20)
        Me.XSizeBox.TabIndex = 0
        '
        'YSizeBox
        '
        Me.YSizeBox.Location = New System.Drawing.Point(66, 120)
        Me.YSizeBox.Name = "YSizeBox"
        Me.YSizeBox.Size = New System.Drawing.Size(52, 20)
        Me.YSizeBox.TabIndex = 1
        '
        'GenerateBoardButton
        '
        Me.GenerateBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateBoardButton.Location = New System.Drawing.Point(137, 87)
        Me.GenerateBoardButton.Name = "GenerateBoardButton"
        Me.GenerateBoardButton.Size = New System.Drawing.Size(214, 53)
        Me.GenerateBoardButton.TabIndex = 2
        Me.GenerateBoardButton.Text = "Generate Empty Board"
        Me.GenerateBoardButton.UseVisualStyleBackColor = True
        '
        'SolveButton
        '
        Me.SolveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SolveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolveButton.Location = New System.Drawing.Point(8, 232)
        Me.SolveButton.Name = "SolveButton"
        Me.SolveButton.Size = New System.Drawing.Size(62, 56)
        Me.SolveButton.TabIndex = 4
        Me.SolveButton.Text = "Solve"
        Me.SolveButton.UseVisualStyleBackColor = True
        '
        'ImageButton
        '
        Me.ImageButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImageButton.Location = New System.Drawing.Point(6, 166)
        Me.ImageButton.Name = "ImageButton"
        Me.ImageButton.Size = New System.Drawing.Size(328, 48)
        Me.ImageButton.TabIndex = 6
        Me.ImageButton.Text = "Use Image From Clipboard"
        Me.ImageButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.Location = New System.Drawing.Point(76, 232)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(61, 56)
        Me.ResetButton.TabIndex = 9
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Height"
        '
        'UserOptionsBox
        '
        Me.UserOptionsBox.Controls.Add(Me.FlagWarningLabel)
        Me.UserOptionsBox.Controls.Add(Me.ClearShadingButton)
        Me.UserOptionsBox.Controls.Add(Me.ReturnToMenuButton)
        Me.UserOptionsBox.Controls.Add(Me.GuessLabel)
        Me.UserOptionsBox.Controls.Add(Me.MineLabel)
        Me.UserOptionsBox.Controls.Add(Me.SafeLabel)
        Me.UserOptionsBox.Controls.Add(Me.PictureBox3)
        Me.UserOptionsBox.Controls.Add(Me.PictureBox2)
        Me.UserOptionsBox.Controls.Add(Me.PictureBox1)
        Me.UserOptionsBox.Controls.Add(Me.Label4)
        Me.UserOptionsBox.Controls.Add(Me.Label3)
        Me.UserOptionsBox.Controls.Add(Me.ResetButton)
        Me.UserOptionsBox.Controls.Add(Me.GenerateBoardButton)
        Me.UserOptionsBox.Controls.Add(Me.YSizeBox)
        Me.UserOptionsBox.Controls.Add(Me.SolveButton)
        Me.UserOptionsBox.Controls.Add(Me.Label2)
        Me.UserOptionsBox.Controls.Add(Me.XSizeBox)
        Me.UserOptionsBox.Controls.Add(Me.ImageButton)
        Me.UserOptionsBox.Controls.Add(Me.Label1)
        Me.UserOptionsBox.Location = New System.Drawing.Point(10, 0)
        Me.UserOptionsBox.Name = "UserOptionsBox"
        Me.UserOptionsBox.Size = New System.Drawing.Size(361, 398)
        Me.UserOptionsBox.TabIndex = 12
        Me.UserOptionsBox.TabStop = False
        '
        'FlagWarningLabel
        '
        Me.FlagWarningLabel.AutoSize = True
        Me.FlagWarningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.FlagWarningLabel.Location = New System.Drawing.Point(7, 319)
        Me.FlagWarningLabel.Name = "FlagWarningLabel"
        Me.FlagWarningLabel.Size = New System.Drawing.Size(0, 16)
        Me.FlagWarningLabel.TabIndex = 22
        '
        'ClearShadingButton
        '
        Me.ClearShadingButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearShadingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearShadingButton.Location = New System.Drawing.Point(201, 344)
        Me.ClearShadingButton.Name = "ClearShadingButton"
        Me.ClearShadingButton.Size = New System.Drawing.Size(133, 48)
        Me.ClearShadingButton.TabIndex = 21
        Me.ClearShadingButton.Text = "Clear Shading"
        Me.ClearShadingButton.UseVisualStyleBackColor = True
        '
        'ReturnToMenuButton
        '
        Me.ReturnToMenuButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReturnToMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnToMenuButton.Location = New System.Drawing.Point(6, 344)
        Me.ReturnToMenuButton.Name = "ReturnToMenuButton"
        Me.ReturnToMenuButton.Size = New System.Drawing.Size(174, 48)
        Me.ReturnToMenuButton.TabIndex = 20
        Me.ReturnToMenuButton.Text = "Return To Menu"
        Me.ReturnToMenuButton.UseVisualStyleBackColor = True
        '
        'GuessLabel
        '
        Me.GuessLabel.AutoSize = True
        Me.GuessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessLabel.Location = New System.Drawing.Point(180, 278)
        Me.GuessLabel.Name = "GuessLabel"
        Me.GuessLabel.Size = New System.Drawing.Size(56, 20)
        Me.GuessLabel.TabIndex = 19
        Me.GuessLabel.Text = "Guess"
        '
        'MineLabel
        '
        Me.MineLabel.AutoSize = True
        Me.MineLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MineLabel.Location = New System.Drawing.Point(180, 250)
        Me.MineLabel.Name = "MineLabel"
        Me.MineLabel.Size = New System.Drawing.Size(43, 20)
        Me.MineLabel.TabIndex = 18
        Me.MineLabel.Text = "Mine"
        '
        'SafeLabel
        '
        Me.SafeLabel.AutoSize = True
        Me.SafeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SafeLabel.Location = New System.Drawing.Point(180, 221)
        Me.SafeLabel.Name = "SafeLabel"
        Me.SafeLabel.Size = New System.Drawing.Size(43, 20)
        Me.SafeLabel.TabIndex = 17
        Me.SafeLabel.Text = "Safe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(305, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Make Your Own Board"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(147, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "OR"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox3.Location = New System.Drawing.Point(153, 278)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Red
        Me.PictureBox2.Location = New System.Drawing.Point(153, 250)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Lime
        Me.PictureBox1.Location = New System.Drawing.Point(153, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'SolvedBoardBox
        '
        Me.SolvedBoardBox.Location = New System.Drawing.Point(0, 0)
        Me.SolvedBoardBox.Name = "SolvedBoardBox"
        Me.SolvedBoardBox.Size = New System.Drawing.Size(10, 363)
        Me.SolvedBoardBox.TabIndex = 8
        Me.SolvedBoardBox.TabStop = False
        Me.SolvedBoardBox.Visible = False
        '
        'CustomBoardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 410)
        Me.Controls.Add(Me.UserOptionsBox)
        Me.Controls.Add(Me.SolvedBoardBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "CustomBoardForm"
        Me.Text = "CustomBoardForm"
        Me.UserOptionsBox.ResumeLayout(False)
        Me.UserOptionsBox.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolvedBoardBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XSizeBox As TextBox
    Friend WithEvents YSizeBox As TextBox
    Friend WithEvents GenerateBoardButton As Button
    Friend WithEvents SolveButton As Button
    Friend WithEvents ImageButton As Button
    Friend WithEvents SolvedBoardBox As PictureBox
    Friend WithEvents BoardGrid As DataGridView
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserOptionsBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GuessLabel As Label
    Friend WithEvents MineLabel As Label
    Friend WithEvents SafeLabel As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReturnToMenuButton As Button
    Friend WithEvents ClearShadingButton As Button
    Friend WithEvents FlagWarningLabel As Label
End Class
