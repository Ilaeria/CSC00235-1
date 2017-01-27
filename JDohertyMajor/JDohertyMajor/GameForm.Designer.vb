<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameForm
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
        Me.NewGameButton = New System.Windows.Forms.Button()
        Me.PlayerScoreTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        Me.ComputerScoreTextBox = New System.Windows.Forms.TextBox()
        Me.ComputerLabel = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.HighScoresButton = New System.Windows.Forms.Button()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.CurrentGameGroupBox = New System.Windows.Forms.GroupBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.HighScoresListBox = New System.Windows.Forms.ListBox()
        Me.HighScoresListLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NewGameButton
        '
        Me.NewGameButton.Location = New System.Drawing.Point(12, 11)
        Me.NewGameButton.Name = "NewGameButton"
        Me.NewGameButton.Size = New System.Drawing.Size(75, 23)
        Me.NewGameButton.TabIndex = 0
        Me.NewGameButton.Text = "NewGameButton"
        Me.NewGameButton.UseVisualStyleBackColor = True
        '
        'PlayerScoreTextBox
        '
        Me.PlayerScoreTextBox.Enabled = False
        Me.PlayerScoreTextBox.Location = New System.Drawing.Point(572, 13)
        Me.PlayerScoreTextBox.Name = "PlayerScoreTextBox"
        Me.PlayerScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlayerScoreTextBox.TabIndex = 1
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Location = New System.Drawing.Point(504, 16)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(62, 13)
        Me.PlayerLabel.TabIndex = 2
        Me.PlayerLabel.Text = "PlayerLabel"
        Me.PlayerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComputerScoreTextBox
        '
        Me.ComputerScoreTextBox.Enabled = False
        Me.ComputerScoreTextBox.Location = New System.Drawing.Point(571, 40)
        Me.ComputerScoreTextBox.Name = "ComputerScoreTextBox"
        Me.ComputerScoreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ComputerScoreTextBox.TabIndex = 3
        '
        'ComputerLabel
        '
        Me.ComputerLabel.AutoSize = True
        Me.ComputerLabel.Location = New System.Drawing.Point(488, 43)
        Me.ComputerLabel.Name = "ComputerLabel"
        Me.ComputerLabel.Size = New System.Drawing.Size(78, 13)
        Me.ComputerLabel.TabIndex = 4
        Me.ComputerLabel.Text = "ComputerLabel"
        Me.ComputerLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(12, 38)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(75, 23)
        Me.PlayButton.TabIndex = 5
        Me.PlayButton.Text = "PlayButton"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'HighScoresButton
        '
        Me.HighScoresButton.Location = New System.Drawing.Point(174, 11)
        Me.HighScoresButton.Name = "HighScoresButton"
        Me.HighScoresButton.Size = New System.Drawing.Size(75, 23)
        Me.HighScoresButton.TabIndex = 6
        Me.HighScoresButton.Text = "HighScoresButton"
        Me.HighScoresButton.UseVisualStyleBackColor = True
        '
        'HelpButton
        '
        Me.HelpButton.Location = New System.Drawing.Point(174, 38)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(75, 23)
        Me.HelpButton.TabIndex = 7
        Me.HelpButton.Text = "HelpButton"
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(727, 427)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 8
        Me.QuitButton.Text = "QuitButton"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'CurrentGameGroupBox
        '
        Me.CurrentGameGroupBox.Location = New System.Drawing.Point(12, 68)
        Me.CurrentGameGroupBox.Name = "CurrentGameGroupBox"
        Me.CurrentGameGroupBox.Size = New System.Drawing.Size(554, 382)
        Me.CurrentGameGroupBox.TabIndex = 9
        Me.CurrentGameGroupBox.TabStop = False
        Me.CurrentGameGroupBox.Text = "CurrentGameGroupBox"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(572, 68)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "SaveButton"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        Me.OpenFileDialog1.Title = "Show High Scores"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        Me.SaveFileDialog1.Title = "Save Score"
        '
        'HighScoresListBox
        '
        Me.HighScoresListBox.FormattingEnabled = True
        Me.HighScoresListBox.Location = New System.Drawing.Point(572, 123)
        Me.HighScoresListBox.Name = "HighScoresListBox"
        Me.HighScoresListBox.Size = New System.Drawing.Size(230, 290)
        Me.HighScoresListBox.TabIndex = 11
        Me.HighScoresListBox.Visible = False
        '
        'HighScoresListLabel
        '
        Me.HighScoresListLabel.AutoSize = True
        Me.HighScoresListLabel.Location = New System.Drawing.Point(573, 98)
        Me.HighScoresListLabel.Name = "HighScoresListLabel"
        Me.HighScoresListLabel.Size = New System.Drawing.Size(104, 13)
        Me.HighScoresListLabel.TabIndex = 12
        Me.HighScoresListLabel.Text = "HighScoresListLabel"
        '
        'GameForm
        '
        Me.AcceptButton = Me.PlayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(814, 462)
        Me.Controls.Add(Me.HighScoresListLabel)
        Me.Controls.Add(Me.HighScoresListBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CurrentGameGroupBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.HelpButton)
        Me.Controls.Add(Me.HighScoresButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.ComputerLabel)
        Me.Controls.Add(Me.ComputerScoreTextBox)
        Me.Controls.Add(Me.PlayerLabel)
        Me.Controls.Add(Me.PlayerScoreTextBox)
        Me.Controls.Add(Me.NewGameButton)
        Me.Name = "GameForm"
        Me.Text = "GameForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewGameButton As System.Windows.Forms.Button
    Friend WithEvents PlayerScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayerLabel As System.Windows.Forms.Label
    Friend WithEvents ComputerScoreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComputerLabel As System.Windows.Forms.Label
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents HighScoresButton As System.Windows.Forms.Button
    Friend WithEvents HelpButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents CurrentGameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HighScoresListBox As System.Windows.Forms.ListBox
    Friend WithEvents HighScoresListLabel As System.Windows.Forms.Label

End Class
