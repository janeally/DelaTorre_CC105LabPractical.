Public Class Product
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dashboardform As New Dashboard
        dashboardform.Show()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim library As New Product
        library.Show()
        Hide()
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim profiles As New Profile
        profiles.Show()
        Hide()
    End Sub
End Class