<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGameDataForm
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
        Me.PlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.GameBoardRowsTextBox = New System.Windows.Forms.TextBox()
        Me.GameBoardColumnsTextBox = New System.Windows.Forms.TextBox()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.GameBoardRowsLabel = New System.Windows.Forms.Label()
        Me.GameBoardColumnsLabel = New System.Windows.Forms.Label()
        Me.StartGameButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayerNameTextBox
        '
        Me.PlayerNameTextBox.Location = New System.Drawing.Point(172, 13)
        Me.PlayerNameTextBox.Name = "PlayerNameTextBox"
        Me.PlayerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlayerNameTextBox.TabIndex = 0
        '
        'GameBoardRowsTextBox
        '
        Me.GameBoardRowsTextBox.Location = New System.Drawing.Point(171, 40)
        Me.GameBoardRowsTextBox.Name = "GameBoardRowsTextBox"
        Me.GameBoardRowsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GameBoardRowsTextBox.TabIndex = 1
        '
        'GameBoardColumnsTextBox
        '
        Me.GameBoardColumnsTextBox.Location = New System.Drawing.Point(170, 67)
        Me.GameBoardColumnsTextBox.Name = "GameBoardColumnsTextBox"
        Me.GameBoardColumnsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GameBoardColumnsTextBox.TabIndex = 2
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(12, 16)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(90, 13)
        Me.PlayerNameLabel.TabIndex = 3
        Me.PlayerNameLabel.Text = "PlayerNameLabel"
        '
        'GameBoardRowsLabel
        '
        Me.GameBoardRowsLabel.AutoSize = True
        Me.GameBoardRowsLabel.Location = New System.Drawing.Point(12, 43)
        Me.GameBoardRowsLabel.Name = "GameBoardRowsLabel"
        Me.GameBoardRowsLabel.Size = New System.Drawing.Size(116, 13)
        Me.GameBoardRowsLabel.TabIndex = 4
        Me.GameBoardRowsLabel.Text = "GameBoardRowsLabel"
        '
        'GameBoardColumnsLabel
        '
        Me.GameBoardColumnsLabel.AutoSize = True
        Me.GameBoardColumnsLabel.Location = New System.Drawing.Point(12, 70)
        Me.GameBoardColumnsLabel.Name = "GameBoardColumnsLabel"
        Me.GameBoardColumnsLabel.Size = New System.Drawing.Size(129, 13)
        Me.GameBoardColumnsLabel.TabIndex = 5
        Me.GameBoardColumnsLabel.Text = "GameBoardColumnsLabel"
        '
        'StartGameButton
        '
        Me.StartGameButton.Location = New System.Drawing.Point(194, 94)
        Me.StartGameButton.Name = "StartGameButton"
        Me.StartGameButton.Size = New System.Drawing.Size(75, 23)
        Me.StartGameButton.TabIndex = 6
        Me.StartGameButton.Text = "StartGameButton"
        Me.StartGameButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(194, 123)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 7
        Me.CancelButton.Text = "CancelButton"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'NewGameDataForm
        '
        Me.AcceptButton = Me.StartGameButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(284, 158)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.StartGameButton)
        Me.Controls.Add(Me.GameBoardColumnsLabel)
        Me.Controls.Add(Me.GameBoardRowsLabel)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.GameBoardColumnsTextBox)
        Me.Controls.Add(Me.GameBoardRowsTextBox)
        Me.Controls.Add(Me.PlayerNameTextBox)
        Me.Name = "NewGameDataForm"
        Me.Text = "NewGameDataForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GameBoardRowsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GameBoardColumnsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayerNameLabel As System.Windows.Forms.Label
    Friend WithEvents GameBoardRowsLabel As System.Windows.Forms.Label
    Friend WithEvents GameBoardColumnsLabel As System.Windows.Forms.Label
    Friend WithEvents StartGameButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
End Class
