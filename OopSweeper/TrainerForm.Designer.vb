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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrainerForm))
        Me.SimpleButton = New System.Windows.Forms.Button()
        Me.NonTrivialButton = New System.Windows.Forms.Button()
        Me.BruteForceButton = New System.Windows.Forms.Button()
        Me.GuessButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SimpleButton
        '
        Me.SimpleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SimpleButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton.ForeColor = System.Drawing.Color.White
        Me.SimpleButton.Location = New System.Drawing.Point(12, 14)
        Me.SimpleButton.Name = "SimpleButton"
        Me.SimpleButton.Size = New System.Drawing.Size(108, 54)
        Me.SimpleButton.TabIndex = 0
        Me.SimpleButton.Text = "Simple"
        Me.SimpleButton.UseVisualStyleBackColor = True
        '
        'NonTrivialButton
        '
        Me.NonTrivialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NonTrivialButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonTrivialButton.ForeColor = System.Drawing.Color.White
        Me.NonTrivialButton.Location = New System.Drawing.Point(12, 73)
        Me.NonTrivialButton.Name = "NonTrivialButton"
        Me.NonTrivialButton.Size = New System.Drawing.Size(108, 54)
        Me.NonTrivialButton.TabIndex = 1
        Me.NonTrivialButton.Text = "Non-Trivial"
        Me.NonTrivialButton.UseVisualStyleBackColor = True
        '
        'BruteForceButton
        '
        Me.BruteForceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BruteForceButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BruteForceButton.ForeColor = System.Drawing.Color.White
        Me.BruteForceButton.Location = New System.Drawing.Point(12, 132)
        Me.BruteForceButton.Name = "BruteForceButton"
        Me.BruteForceButton.Size = New System.Drawing.Size(108, 54)
        Me.BruteForceButton.TabIndex = 2
        Me.BruteForceButton.Text = "Brute Force"
        Me.BruteForceButton.UseVisualStyleBackColor = True
        '
        'GuessButton
        '
        Me.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuessButton.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuessButton.ForeColor = System.Drawing.Color.White
        Me.GuessButton.Location = New System.Drawing.Point(12, 191)
        Me.GuessButton.Name = "GuessButton"
        Me.GuessButton.Size = New System.Drawing.Size(108, 54)
        Me.GuessButton.TabIndex = 3
        Me.GuessButton.Text = "Guess"
        Me.GuessButton.UseVisualStyleBackColor = True
        '
        'TrainerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(130, 259)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuessButton)
        Me.Controls.Add(Me.BruteForceButton)
        Me.Controls.Add(Me.NonTrivialButton)
        Me.Controls.Add(Me.SimpleButton)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TrainerForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton As Button
    Friend WithEvents NonTrivialButton As Button
    Friend WithEvents BruteForceButton As Button
    Friend WithEvents GuessButton As Button
End Class
