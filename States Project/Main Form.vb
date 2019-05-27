'Mukhammad Mirsodikov - P3

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Dim intMin As Integer 'variable for the minute
    Dim intSec As Integer 'variable for the second
    Dim strName As String 'variable for the name of the player
    Private intProgress As Integer 'variable for the progress of the player (out of 50)

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'enables the text box and the button
        txtState.Enabled = True
        btnCheck.Enabled = True

        'gives focus to the text box
        txtState.Focus()
        strName = txtName.Text.Trim
        If strName = String.Empty Then
            strName = "No Name" 'if there is no name entered then make the name "No Name"
        End If
        txtName.Enabled = False

        'determine what kind of time limit is needed
        Select Case True
            Case radMin.Checked 'no time limit
                tmrLimit.Interval = 1000 '= 1 second
                tmrLimit.Start() 'start the 10 minute timer
                intMin = 9 '9 minutes
                intSec = 60 '60 seconds
            Case radNoLim.Checked
                tmrNoLimit.Interval = 1000 '= 1 second
                tmrNoLimit.Start() 'start the stopwatch
                intMin = 0 '0 minutes
                intSec = 0 '0 seconds
        End Select

        'turn off the button after it has been clicked
        btnNewGame.Enabled = False
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim inFile As IO.StreamReader
        Dim strGuess As String
        Dim intSpace As Integer

        strGuess = txtState.Text.Trim
        'capitalize the first letter of the state
        'does not work for states with two words i.e New York, New Jersey, New Hampshire, etc.
        strGuess = strGuess.Substring(0, 1).ToUpper + strGuess.Substring(1, strGuess.Length - 1)
        'if state has two words i.e New York, North Dakota, New Mexico, etc., capitalize the second word
        If strGuess.Contains(" ") Then
            intSpace = strGuess.IndexOf(" ")
            strGuess = strGuess.Substring(0, intSpace) + " " + strGuess.Substring(intSpace + 1, 1).ToUpper + strGuess.Substring(intSpace + 2)
        End If

        If IO.File.Exists("states.txt") Then
            inFile = IO.File.OpenText("states.txt")
            Do Until inFile.Peek = -1
                'checking to see if the strGuess matches with any state names in states.txt or already in the list box
                If strGuess = inFile.ReadLine AndAlso lstGuess.Items.Contains(strGuess) = False Then
                    lstGuess.Items.Add(strGuess) 'add the state to the list box
                    intProgress += 1 'the counter for how many states have been guessed so far
                    lblProgress.Text = intProgress.ToString & " / 50"
                End If
            Loop
        End If

        'autoscroll the listbox
        lstGuess.SelectedIndex = lstGuess.Items.Count - 1
        'bring the focus back to the text box and select the current text
        txtState.Focus()
        txtState.SelectAll()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrLimit.Tick
        'timer for the 10 minute time limit
        intSec -= 1 'subtract 1 from intSec every 1000 miliseconds = 1 second

        If intSec = 0 And intMin = 0 OrElse intProgress = 50 Then 'check to see if the timer has hit 0:00 or if all 50 states have been guessed
            tmrLimit.Stop() 'stop the timer
            'turn off the text box and the check button
            txtState.Enabled = False
            btnCheck.Enabled = False
            'display a time
            lblTime.Text = "0:00"
            MessageBox.Show("Out of time!", "States Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf intSec = 0 Then 'check to see if a minute has passed by
            intMin -= 1 'subtract 1 from intMin
            intSec = 59 'set intSec back to a full minute
        End If

        lblTime.Text = intMin.ToString & ":" & intSec.ToString 'display the time in a 0:00 format

        If intSec < 10 Then
            lblTime.Text = intMin.ToString & ":0" & intSec.ToString 'when seconds are less than 10 then add a leading 0 to make it look like 0:00
        End If

    End Sub

    Private Sub closeForm(sender As Object, e As EventArgs) Handles btnExit.Click, mnuFileExit.Click
        Me.Close()

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim outFile As IO.StreamWriter

        'save the game the user had finished
        If IO.File.Exists("records.txt") Then
            outFile = IO.File.AppendText("records.txt") 'adds on to the text file instead of erasing it
            outFile.WriteLine("Name: " & strName) 'adds the name of the user
            outFile.WriteLine("States: ")
            For intSub As Integer = 0 To lstGuess.Items.Count - 1
                outFile.WriteLine(lstGuess.Items(intSub).ToString) 'adds all the states the player has guessed
            Next
            outFile.WriteLine("Progress: " & lblProgress.Text) 'add the progress of the player
            Select Case True 'determine what kind of time limit was used
                Case radMin.Checked
                    'add that it was a 10 minute time limit
                    'add the remaining time left in the label
                    outFile.WriteLine("10-Minute Time Limit: " & lblTime.Text & ControlChars.NewLine)
                Case radNoLim.Checked
                    'add that there was no time limit
                    'add how long it took to finish
                    outFile.WriteLine("No Time Limit: " & lblTime.Text & ControlChars.NewLine)
            End Select
            outFile.WriteLine("---------------------------------" & ControlChars.NewLine) 'add a seperator between each person

            'stop both of the timers
            tmrLimit.Stop()
            tmrNoLimit.Stop()

            'message box for a succesful save
            MessageBox.Show("Save succesful!", "States Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
            outFile.Close()
        End If

    End Sub

    Private Sub mnuFileInfo_Click(sender As Object, e As EventArgs) Handles mnuFileInfo.Click
        Dim inFile As IO.StreamReader

        'a file that has the description of what the purpose of the program is
        If IO.File.Exists("information.txt") Then
            inFile = IO.File.OpenText("information.txt")
            MessageBox.Show(inFile.ReadToEnd, "States Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles tmrNoLimit.Tick
        'the timer with no time limit
        intSec += 1 'add 1 to intSec every 1000 miliseconds = 1 second

        If intSec < 10 Then
            lblTime.Text = intMin.ToString & ":0" & intSec.ToString 'format the time so it looks better
        Else
            lblTime.Text = intMin.ToString & ":" & intSec.ToString 'display the time as it is
        End If

        If intSec >= 59 Then 'check if a minute has passed
            intMin += 1 'add 1 to minute
            intSec = 0 'set the seconds back to 0
        End If

        If intProgress = 50 Then 'if all 50 states have been found, stop the timer
            tmrNoLimit.Stop()
        End If

    End Sub

    Private Sub mnuFileScores_Click(sender As Object, e As EventArgs) Handles mnuFileScores.Click
        'show the form that has the text box with the records on it
        frmScores.Show()

    End Sub
End Class
