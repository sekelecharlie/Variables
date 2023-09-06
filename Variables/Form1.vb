Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'Declaration of Variables
        Dim strFirstName As String
        Dim strLastName As String


        strFirstName = "Charlie"
        strLastName = "Sekele"

        MsgBox("Hi " & strFirstName)
        MsgBox("You are Mr " & strLastName)

        MsgBox("Your full name is " & strFirstName & " " & strLastName)


    End Sub
End Class
