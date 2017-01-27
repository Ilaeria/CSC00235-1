'Project:       CSC00235 Major Assignment
'Programmer:    Jennifer Doherty
'Date:          01/05/2014
'Description:   Program required for major assignment. Creates and plays a 
'               random number game between the user and the computer.
'Version:		1.0
Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO

Public Class GameForm

    Friend PlayerNameString As String
    Friend GameBoardRowsInteger As Integer
    Friend GameBoardColumnsInteger As Integer
    Private GameInProgressBoolean As Boolean
    Private GameBoardSizeInteger As Integer
    Private HighScoresStreamWriter As StreamWriter
    Private HighScoresStreamReader As StreamReader

    'Array to hold the random number values of the game board.
    Private GameBoardArrayInteger() As Integer
    'Array to hold the value of whether a tile in the current game board 
    'has been played.
    Private PlayedTilesArrayBoolean() As Boolean
    'Array to hold the text boxes that make up the game board tiles.
    Private GameBoardTilesArrayTextBox() As TextBox

    Private Sub GameForm_Load(sender As Object, e As EventArgs
                              ) Handles MyBase.Load

        'Set up the initial form controls.
        Me.Text = "Chance!"
        NewGameButton.Text = "New Game"
        CurrentGameGroupBox.Text = ""
        SaveButton.Text = "Save"
        ComputerLabel.Text = "Computer:"
        HighScoresButton.Text = "High Scores"
        HelpButton.Text = "Help"
        QuitButton.Text = "Quit"
        PlayerScoreTextBox.Enabled = False
        ComputerScoreTextBox.Enabled = False
        HighScoresListBox.Visible = False
        With PlayButton
            .Text = "Play!"
            .Enabled = False
            .Visible = False
        End With
        With HighScoresListLabel
            .Text = "High Scores:"
            .Visible = False
        End With
        ClearForm()
    End Sub

    Private Sub ClearForm()

        'Clears the game board and scores.
        ComputerLabel.Visible = False
        With PlayerLabel
            .Text = "Player:"
            .Visible = False
        End With
        With PlayerScoreTextBox
            .Visible = False
            .Text = ""
        End With
        With ComputerScoreTextBox
            .Visible = False
            .Text = ""
        End With
        With SaveButton
            .Enabled = False
            .Visible = False
        End With
        With CurrentGameGroupBox
            .Visible = False
            .Controls.Clear()
        End With
    End Sub

    Private Sub NewGameButton_Click(sender As Object, e As EventArgs
                                    ) Handles NewGameButton.Click

        'Clears the game form and sets up a new game with the user's input.

        Dim GameBoardRandom As Random = New Random(DateTime.Now.Millisecond)
        Dim IndexInteger As Integer = 0
        Dim NewGameDialogResult As DialogResult
        Dim GameBoardTextBox As TextBox

        'If game is in progress, ask for confirmation.
        If GameInProgressBoolean = True Then
            NewGameDialogResult = MessageBox.Show(
                "Abandon this game and start again?", "Are you sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)

            If NewGameDialogResult = Windows.Forms.DialogResult.Yes Then
                ClearForm()
            Else
                Exit Sub
            End If

        Else
            'Clear the form.
            ClearForm()
        End If

        'Get the user's input for the new game via a modal window.
        NewGameDataForm.ShowDialog()

        'If the game data input was valid, set up the game window.
        If NewGameDataForm.ValidNewGameBoolean = True Then

            PlayerLabel.Text = PlayerNameString & ":"
            GameInProgressBoolean = True
            GameBoardSizeInteger = ((GameBoardColumnsInteger) *
                                    (GameBoardRowsInteger) - 1)

            CurrentGameGroupBox.Visible = True
            PlayerLabel.Visible = True
            ComputerLabel.Visible = True
            With PlayerScoreTextBox
                .Visible = True
                .Text = "0"
                .BackColor = Color.LightSkyBlue
            End With
            With ComputerScoreTextBox
                .Visible = True
                .Text = "0"
                .BackColor = Color.LightGoldenrodYellow
            End With
            With PlayButton
                .Visible = True
                .Enabled = True
            End With

            'Initialise the game board array 
            'and populate it with random numbers.
            ReDim GameBoardArrayInteger(GameBoardSizeInteger)
            IndexInteger = 0
            Do Until IndexInteger > GameBoardSizeInteger
                GameBoardArrayInteger(IndexInteger) = GameBoardRandom.Next(
                    1, 101)
                IndexInteger += 1
            Loop

            'Initialse the game board tiles array 
            'and populate it with text boxes.
            'Code for game board adapted from 
            'http://checktechno.blogspot.com.au/2012/11/add-control-in-your-form-dynamically.html

            ReDim GameBoardTilesArrayTextBox(GameBoardSizeInteger)
            IndexInteger = 0
            For index1 As Integer = 0 To GameBoardColumnsInteger - 1
                For index2 As Integer = 0 To GameBoardRowsInteger - 1
                    GameBoardTextBox = New TextBox()
                    With GameBoardTextBox
                        .Name = "GameBoardTextBox" & index1.ToString &
                            index2.ToString
                        .Width = CInt(CurrentGameGroupBox.Width /
                            GameBoardColumnsInteger)
                        .Left = index1 * CInt(CurrentGameGroupBox.Width /
                            GameBoardColumnsInteger)
                        .Height = CInt(CurrentGameGroupBox.Height /
                            GameBoardRowsInteger)
                        .Top = index2 * CInt(CurrentGameGroupBox.Height /
                            GameBoardRowsInteger)
                        .Text = GameBoardArrayInteger(IndexInteger).ToString
                        .Enabled = False
                        .Visible = False
                        .BackColor = Color.Gray
                    End With
                    CurrentGameGroupBox.Controls.Add(GameBoardTextBox)
                    GameBoardTilesArrayTextBox(IndexInteger) = GameBoardTextBox
                    IndexInteger += 1
                Next index2
            Next index1

            'Initialise the played tiles array
            'and mark all game board tiles as unplayed.
            ReDim PlayedTilesArrayBoolean(GameBoardSizeInteger)
            IndexInteger = 0
            Do Until IndexInteger > GameBoardSizeInteger
                PlayedTilesArrayBoolean(IndexInteger) = False
                IndexInteger += 1
            Loop

        Else
            MessageBox.Show("Please enter valid new game details", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs
                                 ) Handles QuitButton.Click

        'Quits the game.
        Me.Close()

    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs
                                 ) Handles HelpButton.Click

        'Shows the play instructions.

        Dim MessageString As String
        MessageString = "Chance! is a random number game you play " &
            "against the computer." &
            Environment.NewLine & Environment.NewLine &
            "Click the ""New Game"" button to enter your name and " &
            "choose the game board size." &
            Environment.NewLine & Environment.NewLine &
            "Click the ""Play"" button to randomly choose tiles " &
            "for you and the computer." &
            Environment.NewLine & Environment.NewLine &
            "The game is over once all tiles are chosen." &
            Environment.NewLine & Environment.NewLine &
            "Click the ""Save"" button to save your score. " &
            Environment.NewLine & Environment.NewLine &
            "Click the ""High Scores"" button to view all the high scores." &
            Environment.NewLine & Environment.NewLine &
            "Good luck!"

        MessageBox.Show(MessageString, "How to play", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs
                                 ) Handles PlayButton.Click

        'Randomly chooses an unplayed tile for the player and the computer.

        Dim PlayedTileRandom As Random = New Random(DateTime.Now.Millisecond)
        Dim TurnCompletePlayerBoolean As Boolean = False
        Dim TurnCompleteComputerBoolean As Boolean = False
        Dim PlayedTileIndexInteger As Integer
        Dim TurnScorePlayerInteger As Integer
        Dim TurnScoreComputerInteger As Integer
        Dim TilesRemainingBoolean As Boolean
        Dim IndexInteger As Integer
        Dim MessageString As String

        'Check if there are unplayed tiles.
        IndexInteger = 0
        Do
            TilesRemainingBoolean = False
            If PlayedTilesArrayBoolean(IndexInteger) = False Then
                TilesRemainingBoolean = True
                IndexInteger += 1
            Else
                IndexInteger += 1
            End If
        Loop Until TilesRemainingBoolean = True Or IndexInteger >
            GameBoardSizeInteger

        'If there are unplayed tiles, have the player's turn.
        If TilesRemainingBoolean = True Then
            Do
                PlayedTileIndexInteger = PlayedTileRandom.Next(
                    0, (GameBoardSizeInteger + 1))
                Select Case PlayedTilesArrayBoolean(PlayedTileIndexInteger)
                    Case Is = False
                        PlayedTilesArrayBoolean(PlayedTileIndexInteger) = True
                        TurnScorePlayerInteger = GameBoardArrayInteger(
                            PlayedTileIndexInteger)
                        PlayerScoreTextBox.Text =
                            (Integer.Parse(PlayerScoreTextBox.Text) +
                             TurnScorePlayerInteger).ToString
                        With GameBoardTilesArrayTextBox(PlayedTileIndexInteger)
                            .Visible = True
                            .BackColor = Color.LightSkyBlue
                        End With
                        TurnCompletePlayerBoolean = True
                    Case Is = True
                        TurnCompletePlayerBoolean = False
                End Select
            Loop Until TurnCompletePlayerBoolean = True
        Else
            TurnCompletePlayerBoolean = False
        End If

        'Check for unplayed tiles again.
        IndexInteger = 0
        Do
            TilesRemainingBoolean = False
            If PlayedTilesArrayBoolean(IndexInteger) = False Then
                TilesRemainingBoolean = True
                IndexInteger += 1
            Else
                IndexInteger += 1
            End If
        Loop Until TilesRemainingBoolean = True Or IndexInteger >
            GameBoardSizeInteger

        'If there are still unplayed tiles, have the computer's turn.
        If TilesRemainingBoolean = True Then
            Do
                PlayedTileIndexInteger = PlayedTileRandom.Next(
                    0, (GameBoardSizeInteger + 1))
                Select Case PlayedTilesArrayBoolean(PlayedTileIndexInteger)
                    Case Is = False
                        PlayedTilesArrayBoolean(PlayedTileIndexInteger) = True
                        TurnScoreComputerInteger = GameBoardArrayInteger(
                            PlayedTileIndexInteger)
                        ComputerScoreTextBox.Text =
                            (Integer.Parse(ComputerScoreTextBox.Text) +
                             TurnScoreComputerInteger).ToString
                        With GameBoardTilesArrayTextBox(PlayedTileIndexInteger)
                            .Visible = True
                            .BackColor = Color.LightGoldenrodYellow
                        End With
                        TurnCompleteComputerBoolean = True
                    Case Is = True
                        TurnCompleteComputerBoolean = False
                End Select
            Loop Until TurnCompleteComputerBoolean = True
        Else
            TurnCompleteComputerBoolean = False
        End If

        'If either the player or the computer could not complete their turn, 
        'the game is over. Show a message with the result.
        If TurnCompletePlayerBoolean = False Or
            TurnCompleteComputerBoolean = False Then

            If Integer.Parse(ComputerScoreTextBox.Text) >
                Integer.Parse(PlayerScoreTextBox.Text) Then
                MessageString = "You lost!" &
                    Environment.NewLine &
                    PlayerNameString & ": " &
                    PlayerScoreTextBox.Text &
                    Environment.NewLine &
                    "Computer: " &
                    ComputerScoreTextBox.Text
            ElseIf Integer.Parse(PlayerScoreTextBox.Text) >
                Integer.Parse(ComputerScoreTextBox.Text) Then
                MessageString = "You won!" &
                    Environment.NewLine &
                    PlayerNameString & ": " &
                    PlayerScoreTextBox.Text &
                    Environment.NewLine &
                    "Computer: " &
                    ComputerScoreTextBox.Text
            Else
                MessageString = "It's a draw!" &
                    Environment.NewLine &
                    PlayerNameString & ": " &
                    PlayerScoreTextBox.Text &
                    Environment.NewLine &
                    "Computer: " &
                    ComputerScoreTextBox.Text
            End If

            MessageBox.Show(MessageString, "Game Over!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            GameInProgressBoolean = False
            With SaveButton
                .Visible = True
                .Enabled = True
            End With
        Else
            GameInProgressBoolean = True
        End If

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs
                                 ) Handles SaveButton.Click

        'Opens the high scores file and appends the current score.

        Dim ResponseDialogResult As DialogResult

        'Check that the file isn't open already.
        If HighScoresStreamWriter IsNot Nothing Then
            HighScoresStreamWriter.Close()
        End If

        'Set up and display the Save As dialog.
        With SaveFileDialog1
            .InitialDirectory = Directory.GetCurrentDirectory()
            .FileName = "HighScores.txt"
            .Title = "Save your score"
            ResponseDialogResult = .ShowDialog()
        End With

        'Write the score if the player didn't click the Cancel button.
        If ResponseDialogResult <> Windows.Forms.DialogResult.Cancel Then
            HighScoresStreamWriter = New StreamWriter(SaveFileDialog1.FileName, True)
            HighScoresStreamWriter.WriteLine(PlayerNameString)
            HighScoresStreamWriter.WriteLine(PlayerScoreTextBox.Text)
            HighScoresStreamWriter.Close()
        End If

    End Sub

    Private Sub HighScoresButton_Click(sender As Object, e As EventArgs
                                       ) Handles HighScoresButton.Click

        'Load the scores file to display the high scores.

        Dim HighScoresString As String
        Dim ResponseDialogResult As DialogResult

        'Check that the file isn't open already.
        If HighScoresStreamReader IsNot Nothing Then
            HighScoresStreamReader.Close()
        End If

        Try
            'Try to open the high score file.
            With OpenFileDialog1
                .InitialDirectory = Directory.GetCurrentDirectory()
                .FileName = "HighScores.txt"
                .Title = "Load high scores"
                ResponseDialogResult = .ShowDialog()
            End With

            'Check the player didn't click the Cancel button.
            If ResponseDialogResult <> Windows.Forms.DialogResult.Cancel Then
                HighScoresStreamReader = New StreamReader(
                    OpenFileDialog1.FileName)

                'Clear any existing content in the high scores list box.
                HighScoresListBox.Items.Clear()

                'Load the high scores in to the high scores list box.
                Do Until HighScoresStreamReader.Peek = -1
                    HighScoresString = HighScoresStreamReader.ReadLine() &
                        " " & HighScoresStreamReader.ReadLine()
                    HighScoresListBox.Items.Add(HighScoresString)
                Loop

                'Close the file.
                HighScoresStreamReader.Close()

                'Display the high scores list box.
                HighScoresListBox.Visible = True
                HighScoresListLabel.Visible = True
            End If

        Catch ex As Exception
            'No file exists.
            MessageBox.Show("File does not exist.")
        End Try

    End Sub
End Class
