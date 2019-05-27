Public Class frmScores
    Private Sub frmScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader

        'open and write the records.txt file
        If IO.File.Exists("records.txt") Then
            inFile = IO.File.OpenText("records.txt")
            txtScores.Text = inFile.ReadToEnd
        End If
    End Sub
End Class