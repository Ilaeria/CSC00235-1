'Project:       CSC00235 Major Assignment
'Programmer:    Jennifer Doherty
'Date:          01/05/2014
'Description:   Program required for major assignment. Creates and plays a 
'               random number game between the user and the computer.
'Version:		1.0
Option Strict On
Option Explicit On
Option Infer Off

Public Class NewGameDataForm

    Friend ValidNewGameBoolean As Boolean

    Private Sub NewGameDataForm_Load(sender As Object, e As EventArgs
                                     ) Handles MyBase.Load

        'Set up the form controls.
        Me.Text = "New Game"
        PlayerNameLabel.Text = "Enter your name:"
        GameBoardRowsLabel.Text = "Number of rows:"
        GameBoardColumnsLabel.Text = "Number of columns:"
        StartGameButton.Text = "Start Game"
        CancelButton.Text = "Cancel"
    End Sub

    Private Sub StartGameButton_Click(sender As Object, e As EventArgs
                                      ) Handles StartGameButton.Click

        'Check the game data is valid and set up the game form.

        Dim NewGameRowsInteger As Integer
        Dim NewGameColumnsInteger As Integer
        Dim NewGamePlayerNameString As String
        Dim ValidRowsBoolean As Boolean
        Dim ValidColumnsBoolean As Boolean
        Dim ValidPlayerNameBoolean As Boolean

        Try
            'Convert the number of rows to numeric.
            NewGameRowsInteger = Integer.Parse(GameBoardRowsTextBox.Text)

            'Check the number of rows is valid.
            If NewGameRowsInteger < 2 Or NewGameRowsInteger > 20 Then
                MessageBox.Show("Number of rows must be between 2 and 20",
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                With GameBoardRowsTextBox
                    .Focus()
                    .SelectAll()
                End With
            Else
                GameForm.GameBoardRowsInteger = NewGameRowsInteger
                ValidRowsBoolean = True
            End If

            Try
                'Convert the number of columns to numeric.
                NewGameColumnsInteger = Integer.Parse(
                    GameBoardColumnsTextBox.Text)

                'Check the number of columns is valid.
                If NewGameColumnsInteger < 2 Or NewGameColumnsInteger > 20 Then
                    MessageBox.Show(
                        "Number of columns must be between 2 and 20",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation)
                    With GameBoardColumnsTextBox
                        .Focus()
                        .SelectAll()
                    End With
                Else
                    GameForm.GameBoardColumnsInteger = NewGameColumnsInteger
                    ValidColumnsBoolean = True

                    'Check the player name is valid.
                    If PlayerNameTextBox.Text <> "" Then
                        NewGamePlayerNameString = PlayerNameTextBox.Text
                        ValidPlayerNameBoolean = IsAlpha(
                            NewGamePlayerNameString)

                        If ValidPlayerNameBoolean = True Then
                            GameForm.PlayerNameString = NewGamePlayerNameString
                        Else
                            MessageBox.Show(
                                "Name must be between 2 and 20 letters only",
                                "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                            With PlayerNameTextBox
                                .Focus()
                                .SelectAll()
                            End With
                        End If

                    Else
                        MessageBox.Show(
                            "Name must contain at least two letters", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        With PlayerNameTextBox
                            .Focus()
                            .SelectAll()
                        End With
                    End If
                End If

            Catch ColumnsException As FormatException
                'Handles a columns format exception.
                MessageBox.Show(
                    "Number of columns must be a whole number " &
                    "between 2 and 20",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With GameBoardColumnsTextBox
                    .Focus()
                    .SelectAll()
                End With
            End Try

        Catch RowsException As FormatException
            'Handles a rows format exception.
            MessageBox.Show(
                "Number of rows must be a whole number between 2 and 20",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With GameBoardRowsTextBox
                .Focus()
                .SelectAll()
            End With

        Catch Exception As Exception
            'Handles any other exception.
            MessageBox.Show("Please enter valid new game details", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With GameBoardColumnsTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

        If ValidRowsBoolean And ValidColumnsBoolean And
            ValidPlayerNameBoolean = True Then
            ValidNewGameBoolean = True
        Else
            ValidNewGameBoolean = False
        End If

        If ValidNewGameBoolean = True Then
            Me.Close()
        Else
            With PlayerNameTextBox
                .Focus()
                .SelectAll()
            End With
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs
                                   ) Handles CancelButton.Click

        'Clears and hides the modal New Game form.
        PlayerNameTextBox.Text = ""
        GameBoardRowsTextBox.Text = ""
        GameBoardColumnsTextBox.Text = ""
        Me.Close()

    End Sub

    Private Function IsAlpha(ByVal TestString As String) As Boolean
        'Checks that the player's name is a reasonable length
        'and alphabetical characters only.
        'Code adapted from http://www.freevbcode.com/ShowCode.asp?ID=1086.

        Dim TempString As String
        Dim LengthInteger As Integer
        Dim CounterInteger As Integer
        Dim CharacterString As String

        'Returns true if all characters in a string of between 2 and 20 
        'characters are alphabetical.
        'Returns false otherwise or for empty string.

        TempString = TestString
        LengthInteger = Len(TempString)
        If LengthInteger < 2 Or LengthInteger > 20 Then Return False

        If LengthInteger > 0 Then
            For CounterInteger = 1 To LengthInteger
                CharacterString = Mid(TempString, CounterInteger, 1)
                If Not CharacterString Like "[A-Za-z]" Then Return False
            Next
        End If

        Return True
    End Function

End Class