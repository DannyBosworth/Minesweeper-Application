<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatsButton = New System.Windows.Forms.Button()
        Me.TrainerButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.CustomBoardButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.White
        Me.ExitButton.Location = New System.Drawing.Point(664, 30)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(157, 162)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatsButton
        '
        Me.StatsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatsButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsButton.ForeColor = System.Drawing.Color.White
        Me.StatsButton.Location = New System.Drawing.Point(175, 30)
        Me.StatsButton.Name = "StatsButton"
        Me.StatsButton.Size = New System.Drawing.Size(157, 162)
        Me.StatsButton.TabIndex = 5
        Me.StatsButton.Text = "STATS"
        Me.StatsButton.UseVisualStyleBackColor = True
        '
        'TrainerButton
        '
        Me.TrainerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrainerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TrainerButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainerButton.ForeColor = System.Drawing.Color.White
        Me.TrainerButton.Location = New System.Drawing.Point(501, 30)
        Me.TrainerButton.Name = "TrainerButton"
        Me.TrainerButton.Size = New System.Drawing.Size(157, 162)
        Me.TrainerButton.TabIndex = 6
        Me.TrainerButton.Text = "TRAINER"
        Me.TrainerButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.Color.White
        Me.PlayButton.Location = New System.Drawing.Point(12, 30)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(157, 162)
        Me.PlayButton.TabIndex = 7
        Me.PlayButton.Text = "PLAY"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'CustomBoardButton
        '
        Me.CustomBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomBoardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomBoardButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomBoardButton.ForeColor = System.Drawing.Color.White
        Me.CustomBoardButton.Location = New System.Drawing.Point(338, 30)
        Me.CustomBoardButton.Name = "CustomBoardButton"
        Me.CustomBoardButton.Size = New System.Drawing.Size(157, 162)
        Me.CustomBoardButton.TabIndex = 8
        Me.CustomBoardButton.Text = "CUSTOM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BOARD"
        Me.CustomBoardButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.CustomBoardButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.TrainerButton)
        Me.Controls.Add(Me.StatsButton)
        Me.Controls.Add(Me.ExitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MenuForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ExitButton As Button
    Friend WithEvents StatsButton As Button
    Friend WithEvents TrainerButton As Button
    Friend WithEvents PlayButton As Button
    Friend WithEvents CustomBoardButton As Button
End Class
