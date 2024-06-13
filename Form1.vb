
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1



    ' Connection string to your database
    Dim connectionString As String = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True"











    Private Sub Clear_Click_1(sender As Object, e As EventArgs)
        username.Clear()
        password.Clear()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim signUpForm As New Signup
        signUpForm.Show()
        Hide()
    End Sub

    Private Sub password_TextChanged_1(sender As Object, e As EventArgs) Handles password.TextChanged
        password.PasswordChar = "*"c
    End Sub

    Private Sub LOG_Click_1(sender As Object, e As EventArgs) Handles LOG.Click
        ' Check if the username or password fields are empty
        If String.IsNullOrEmpty(username.Text) OrElse String.IsNullOrEmpty(password.Text) Then
            username.Clear()
            password.Clear()
            MessageBox.Show("Please fill out the sign-up form before attempting to log in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim signUpForm As New Signup
            signUpForm.Show()
            Hide()
            Exit Sub
        End If

        ' Check if the user is registered
        If String.IsNullOrEmpty(PublicVariables.user) OrElse String.IsNullOrEmpty(PublicVariables.pass) Then
            username.Clear()
            password.Clear()
            MessageBox.Show("The user is not found. Please sign up first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Exit Sub
        End If



        ' Check if the entered username and password match the registered ones
        If username.Text = PublicVariables.user AndAlso password.Text = PublicVariables.pass Then
            ' Password is correct, show login successful message
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim dashboardform As New Dashboard
            dashboardform.Show()
            Hide()
        Else
            ' Password is incorrect, show error message
            username.Clear()
            password.Clear()
            MessageBox.Show("Password or username is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub LOG_MouseEnter(sender As Object, e As EventArgs)
        ' Change the text color when the mouse enters the label
        LOG.ForeColor = Color.LightGreen ' Set hover color
    End Sub

    Private Sub LOG__MouseLeave(sender As Object, e As EventArgs)
        ' Revert the text color when the mouse leaves the label
        LOG.ForeColor = SystemColors.ControlText ' Revert to default text color
    End Sub


End Class
