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
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.CustomBoardButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatsButton = New System.Windows.Forms.Button()
        Me.TrainerButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Location = New System.Drawing.Point(12, 12)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(157, 162)
        Me.PlayButton.TabIndex = 0
        Me.PlayButton.Text = "PLAY"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'CustomBoardButton
        '
        Me.CustomBoardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomBoardButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomBoardButton.Location = New System.Drawing.Point(342, 12)
        Me.CustomBoardButton.Name = "CustomBoardButton"
        Me.CustomBoardButton.Size = New System.Drawing.Size(157, 162)
        Me.CustomBoardButton.TabIndex = 3
        Me.CustomBoardButton.Text = "CUSTOM " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BOARD"
        Me.CustomBoardButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(668, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(157, 162)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatsButton
        '
        Me.StatsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StatsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatsButton.Location = New System.Drawing.Point(175, 12)
        Me.StatsButton.Name = "StatsButton"
        Me.StatsButton.Size = New System.Drawing.Size(157, 162)
        Me.StatsButton.TabIndex = 5
        Me.StatsButton.Text = "STATS"
        Me.StatsButton.UseVisualStyleBackColor = True
        '
        'TrainerButton
        '
        Me.TrainerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrainerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrainerButton.Location = New System.Drawing.Point(505, 12)
        Me.TrainerButton.Name = "TrainerButton"
        Me.TrainerButton.Size = New System.Drawing.Size(157, 162)
        Me.TrainerButton.TabIndex = 6
        Me.TrainerButton.Text = "TRAINER"
        Me.TrainerButton.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 189)
        Me.Controls.Add(Me.TrainerButton)
        Me.Controls.Add(Me.StatsButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CustomBoardButton)
        Me.Controls.Add(Me.PlayButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "MenuForm"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents CustomBoardButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StatsButton As Button
    Friend WithEvents TrainerButton As Button
End Class
