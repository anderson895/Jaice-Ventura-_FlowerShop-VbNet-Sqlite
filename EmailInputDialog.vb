Imports System.Windows.Forms

Public Class EmailInputDialog
    Public Property UserEmail As String = String.Empty

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim email As String = emailTextBox.Text.Trim()

        ' Validate email format
        If Not IsValidEmail(email) Then
            MessageBox.Show("Invalid email format. Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Set the user-entered email
        UserEmail = email

        ' Close the dialog
        Me.Close()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ' Close the dialog without setting the email
        Me.Close()
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Use a simple regex pattern for email validation
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Return System.Text.RegularExpressions.Regex.IsMatch(email, pattern)
    End Function
End Class
