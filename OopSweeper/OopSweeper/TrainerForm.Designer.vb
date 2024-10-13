<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrainerForm
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
        Me.SimpleButton = New System.Windows.Forms.Button()
        Me.NonTrivialButton = New System.Windows.Forms.Button()
        Me.BruteForceButton = New System.Windows.Forms.Button()
        Me.GuessButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SimpleButton
        '
        Me.SimpleButton.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton.Name = "SimpleButton"
        Me.SimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton.TabIndex = 0
        Me.SimpleButton.Text = "Simple"
        Me.SimpleButton.UseVisualStyleBackColor = True
        '
        'NonTrivialButton
        '
        Me.NonTrivialButton.Location = New System.Drawing.Point(12, 51)
        Me.NonTrivialButton.Name = "NonTrivialButton"
        Me.NonTrivialButton.Size = New System.Drawing.Size(75, 23)
        Me.NonTrivialButton.TabIndex = 1
        Me.NonTrivialButton.Text = "Non-Trivial"
        Me.NonTrivialButton.UseVisualStyleBackColor = True
        '
        'BruteForceButton
        '
        Me.BruteForceButton.Location = New System.Drawing.Point(12, 91)
        Me.BruteForceButton.Name = "BruteForceButton"
        Me.BruteForceButton.Size = New System.Drawing.Size(75, 23)
        Me.BruteForceButton.TabIndex = 2
        Me.BruteForceButton.Text = "Brute Force"
        Me.BruteForceButton.UseVisualStyleBackColor = True
        '
        'GuessButton
        '
        Me.GuessButton.Location = New System.Drawing.Point(12, 131)
        Me.GuessButton.Name = "GuessButton"
        Me.GuessButton.Size = New System.Drawing.Size(75, 23)
        Me.GuessButton.TabIndex = 3
        Me.GuessButton.Text = "Guess"
        Me.GuessButton.UseVisualStyleBackColor = True
        '
        'TrainerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 180)
        Me.Controls.Add(Me.GuessButton)
        Me.Controls.Add(Me.BruteForceButton)
        Me.Controls.Add(Me.NonTrivialButton)
        Me.Controls.Add(Me.SimpleButton)
        Me.Name = "TrainerForm"
        Me.Text = "TrainerForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton As Button
    Friend WithEvents NonTrivialButton As Button
    Friend WithEvents BruteForceButton As Button
    Friend WithEvents GuessButton As Button
End Class
