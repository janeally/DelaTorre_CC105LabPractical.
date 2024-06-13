Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Dashboard


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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1Form As New Form1
        Form1Form.Show()
        Hide()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the function to create rounded corners for GroupBox1 and GroupBox2
        ApplyRoundedCorners(GroupBox1, 20)
        ApplyRoundedCorners(GroupBox2, 15)

        ' Load user profile information into the form elements
        Profiles.Image = PublicVariables.Profile
        usernem.Text = PublicVariables.user
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent

        Label13.BackColor = System.Drawing.Color.Transparent
        Label5.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent


        emel.BackColor = System.Drawing.Color.Transparent
        birthday.BackColor = System.Drawing.Color.Transparent
        usernem.BackColor = System.Drawing.Color.Transparent
        nem.BackColor = System.Drawing.Color.Transparent
        Profiles.Image = PublicVariables.Profile
        Label1.Text = $"{PublicVariables.firstname} {PublicVariables.lastname}"
        Label3.Text = PublicVariables.email
        Label2.Text = PublicVariables.birthday
        label4.Text = $"{PublicVariables.kurso} {PublicVariables.taon} - {PublicVariables.sec}"


        ' Set the desired diameter of the circle (in pixels)
        Dim diameter As Integer = 58

        ' Calculate the radius of the circle (half of the diameter)
        Dim radius As Integer = diameter \ 2

        ' Calculate the center coordinates of the circle
        Dim centerX As Integer = Profiles.Width \ 2
        Dim centerY As Integer = Profiles.Height \ 2

        ' Calculate the bounding rectangle for the circle
        Dim rectX As Integer = centerX - radius
        Dim rectY As Integer = centerY - radius

        ' Create a circular graphics path
        Dim graphicsPath As New GraphicsPath()
        graphicsPath.AddEllipse(rectX, rectY, diameter, diameter)

        ' Set the region of the PictureBox to the circular graphics path
        Profiles.Region = New Region(graphicsPath)

        ' Set the PictureBox's SizeMode property to Stretch to stretch the image
        Profiles.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub ApplyRoundedCorners(groupBox As GroupBox, cornerRadius As Integer)
        ' Create a rounded rectangle graphics path
        Dim rect As New Rectangle(0, 0, groupBox.Width, groupBox.Height)
        Dim graphicsPath As New GraphicsPath()
        graphicsPath.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90)
        graphicsPath.AddArc(rect.Right - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90)
        graphicsPath.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        graphicsPath.AddArc(rect.X, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90)
        graphicsPath.CloseFigure()

        ' Apply the rounded rectangle graphics path to the GroupBox's region
        groupBox.Region = New Region(graphicsPath)
    End Sub





    Private Sub LibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibraryToolStripMenuItem.Click
        Dim library As New Product
        library.Show()
        Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim abouts As New About
        abouts.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim dashboardform As New Dashboard
        dashboardform.Show()
        Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim profiles As New Profile
        profiles.Show()
        Hide()
    End Sub





    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim profiles As New Profile
        profiles.Show()
        Hide()
    End Sub





    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dashboardform As New Dashboard
        dashboardform.Show()
        Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim profiles As New Profile
        profiles.Show()
        Hide()
    End Sub
End Class