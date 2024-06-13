
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Signup

    Private Profile As Image

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click

        If String.IsNullOrEmpty(US.Text) OrElse
           String.IsNullOrEmpty(PS.Text) OrElse
           String.IsNullOrEmpty(conpass.Text) OrElse
           String.IsNullOrEmpty(fname.Text) OrElse
           String.IsNullOrEmpty(lname.Text) OrElse
           String.IsNullOrEmpty(course.Text) OrElse
           String.IsNullOrEmpty(year.Text) OrElse
           String.IsNullOrEmpty(mail.Text) OrElse
           String.IsNullOrEmpty(section.Text) Then


            MessageBox.Show("Please fill out all fields to sign up.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If PS.Text <> conpass.Text Then
            MessageBox.Show("Your password do not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        MessageBox.Show("Thank you for signing up!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim Form1Form As New Form1
        Form1Form.Show()
        Hide()
        PublicVariables.user = US.Text
        PublicVariables.pass = PS.Text
        PublicVariables.con = conpass.Text

        PublicVariables.firstname = fname.Text
        PublicVariables.lastname = lname.Text
        PublicVariables.kurso = course.Text
        PublicVariables.taon = year.Text
        PublicVariables.sec = section.Text
        PublicVariables.birthday = birth.Text
        PublicVariables.email = mail.Text


    End Sub



    Private Sub PS_TextChanged(sender As Object, e As EventArgs) Handles PS.TextChanged
        ' Set PasswordChar for PS TextBox
        PS.PasswordChar = "*"c


    End Sub

    Private Sub conpass_TextChanged(sender As Object, e As EventArgs) Handles conpass.TextChanged
        ' Set PasswordChar for ConPass TextBox
        conpass.PasswordChar = "*"c

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Toggle password visibility
        If PS.PasswordChar = ChrW(0) Then
            PS.PasswordChar = "*"c ' Set back to password mode
        Else
            PS.PasswordChar = ChrW(0) ' Show password in plain text
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If conpass.PasswordChar = ChrW(0) Then
            conpass.PasswordChar = "*"c ' Set back to password mode
        Else
            conpass.PasswordChar = ChrW(0) ' Show password in plain text
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1Form As New Form1
        Form1Form.Show()
        Hide()
    End Sub


End Class