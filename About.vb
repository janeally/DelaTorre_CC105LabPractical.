Imports System.Reflection.Emit

Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Profiles.Image = PublicVariables.Profile
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent
        label5.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent
        Label9.BackColor = System.Drawing.Color.Transparent

    End Sub

    Private Sub DAshboard_Click(sender As Object, e As EventArgs) Handles DAshboard.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form1Form As New Form1
        Form1Form.Show()
        Hide()
    End Sub
End Class