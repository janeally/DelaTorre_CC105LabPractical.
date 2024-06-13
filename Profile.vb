Imports System.Reflection.Emit

Public Class Profile
    Private Sub btn_Upload_Click(sender As Object, e As EventArgs) Handles btn_Upload.Click

        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*"
        If openFileDialog.ShowDialog = DialogResult.OK Then
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
            pbProfile.Image = Image.FromFile(openFileDialog.FileName)
            PublicVariables.Profile = pbProfile.Image
        End If
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ngalan.Text = $"{PublicVariables.firstname} {PublicVariables.lastname}"
        CS.Text = PublicVariables.kurso
        YR.Text = PublicVariables.taon
        SCT.Text = PublicVariables.sec
        pbProfile.Image = PublicVariables.Profile
        pass.Text = PublicVariables.pass
        email.Text = PublicVariables.email
        address.Text = PublicVariables.place



        Label1.BackColor = System.Drawing.Color.Transparent
        label2.BackColor = System.Drawing.Color.Transparent
        label3.BackColor = System.Drawing.Color.Transparent
        label4.BackColor = System.Drawing.Color.Transparent
        label5.BackColor = System.Drawing.Color.Transparent
        label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        label8.BackColor = System.Drawing.Color.Transparent
        label9.BackColor = System.Drawing.Color.Transparent


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim dashboardform As New Dashboard
        dashboardform.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim library As New Product
        library.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim signUpForm As New Signup
        signUpForm.Show()
        Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim abouts As New About
        abouts.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim profiles As New Profile
        profiles.Show()
        Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles update.Click
        ' Enable all text boxes
        ngalan.Enabled = True
        SCT.Enabled = True
        CS.Enabled = True
        YR.Enabled = True
        pass.Enabled = True
        conpass.Enabled = True
        btn_Upload.Enabled = True
        email.Enabled = True
        address.Enabled = True


        If update.Text = "Update" Then
            ' Change the text of the button to "Save"
            update.Text = "Save"
        Else
            ' Check if the passwords match
            If pass.Text <> conpass.Text Then
                MessageBox.Show("Your password do not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Check if any of the required textboxes are empty
            If String.IsNullOrEmpty(ngalan.Text) OrElse String.IsNullOrEmpty(SCT.Text) OrElse String.IsNullOrEmpty(CS.Text) OrElse String.IsNullOrEmpty(YR.Text) OrElse String.IsNullOrEmpty(pass.Text) OrElse String.IsNullOrEmpty(conpass.Text) OrElse String.IsNullOrEmpty(address.Text) Then
                MessageBox.Show("Some information is missing! Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' All conditions met, show success message
            MessageBox.Show("Profile update successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Reset the text of the button to "Update"
            update.Text = "Update"
            PublicVariables.firstname = ngalan.Text.Substring(0, ngalan.Text.IndexOf(" "))
            PublicVariables.lastname = ngalan.Text.Substring(ngalan.Text.IndexOf(" ") + 1)
            PublicVariables.kurso = CS.Text
            PublicVariables.taon = YR.Text
            PublicVariables.sec = SCT.Text
            PublicVariables.Profile = pbProfile.Image
            PublicVariables.pass = pass.Text
            PublicVariables.email = email.Text
            PublicVariables.place = address.Text

        End If

    End Sub


    Private Sub DAshboard_Click(sender As Object, e As EventArgs) Handles DAshboard.Click
        Dim dashboardform As New Dashboard
        dashboardform.Show()
        Hide()
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged
        pass.PasswordChar = "•"c
    End Sub

    Private Sub conpass_TextChanged(sender As Object, e As EventArgs) Handles conpass.TextChanged
        conpass.PasswordChar = "•"c
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ngalan.Enabled = False
        SCT.Enabled = False
        CS.Enabled = False
        YR.Enabled = False
        pass.Enabled = False
        conpass.Enabled = False
        btn_Upload.Enabled = False
        email.Enabled = False
        address.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1Form As New Form1
        Form1Form.Show()
        Hide()
    End Sub
End Class