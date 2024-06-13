<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Button8 = New Button()
        update = New Button()
        SCT = New ComboBox()
        YR = New ComboBox()
        CS = New ComboBox()
        email = New TextBox()
        address = New TextBox()
        ngalan = New TextBox()
        label2 = New Label()
        label3 = New Label()
        conpass = New TextBox()
        pass = New TextBox()
        label9 = New Label()
        label8 = New Label()
        label4 = New Label()
        label5 = New Label()
        label6 = New Label()
        Label1 = New Label()
        btn_Upload = New Button()
        pbProfile = New PictureBox()
        Label7 = New Label()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        DAshboard = New Button()
        Button5 = New Button()
        Button7 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Panel1 = New Panel()
        Button1 = New Button()
        Panel2 = New Panel()
        CType(pbProfile, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button8.BackgroundImageLayout = ImageLayout.None
        Button8.FlatStyle = FlatStyle.System
        Button8.Location = New Point(478, 317)
        Button8.Name = "Button8"
        Button8.Size = New Size(84, 26)
        Button8.TabIndex = 84
        Button8.Text = "Cancel"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' update
        ' 
        update.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        update.BackgroundImageLayout = ImageLayout.None
        update.FlatStyle = FlatStyle.System
        update.Location = New Point(478, 285)
        update.Name = "update"
        update.Size = New Size(84, 26)
        update.TabIndex = 83
        update.Text = "Update"
        update.UseVisualStyleBackColor = False
        ' 
        ' SCT
        ' 
        SCT.Enabled = False
        SCT.FormattingEnabled = True
        SCT.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"})
        SCT.Location = New Point(259, 151)
        SCT.Name = "SCT"
        SCT.Size = New Size(159, 23)
        SCT.TabIndex = 75
        ' 
        ' YR
        ' 
        YR.Enabled = False
        YR.FormattingEnabled = True
        YR.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        YR.Location = New Point(259, 266)
        YR.Name = "YR"
        YR.Size = New Size(155, 23)
        YR.TabIndex = 74
        ' 
        ' CS
        ' 
        CS.Enabled = False
        CS.FormattingEnabled = True
        CS.Items.AddRange(New Object() {"COMPUTER SCIENCE", "HOTEL MANAGEMENT", "CRIMINOLOGY", "EDUCATION", "BUSINESS ADMINISTRATION"})
        CS.Location = New Point(259, 209)
        CS.Name = "CS"
        CS.Size = New Size(159, 23)
        CS.TabIndex = 82
        ' 
        ' email
        ' 
        email.BorderStyle = BorderStyle.FixedSingle
        email.Enabled = False
        email.Location = New Point(60, 210)
        email.Name = "email"
        email.Size = New Size(159, 23)
        email.TabIndex = 80
        email.TextAlign = HorizontalAlignment.Center
        ' 
        ' address
        ' 
        address.BorderStyle = BorderStyle.FixedSingle
        address.Enabled = False
        address.Location = New Point(60, 266)
        address.Name = "address"
        address.Size = New Size(157, 23)
        address.TabIndex = 76
        address.TextAlign = HorizontalAlignment.Center
        ' 
        ' ngalan
        ' 
        ngalan.BorderStyle = BorderStyle.FixedSingle
        ngalan.Enabled = False
        ngalan.Location = New Point(60, 151)
        ngalan.Name = "ngalan"
        ngalan.Size = New Size(159, 23)
        ngalan.TabIndex = 79
        ngalan.TextAlign = HorizontalAlignment.Center
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label2.Location = New Point(62, 250)
        label2.Name = "label2"
        label2.Size = New Size(52, 13)
        label2.TabIndex = 67
        label2.Text = "Address:"
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label3.Location = New Point(62, 330)
        label3.Name = "label3"
        label3.Size = New Size(60, 13)
        label3.TabIndex = 68
        label3.Text = "Password:"
        ' 
        ' conpass
        ' 
        conpass.BorderStyle = BorderStyle.FixedSingle
        conpass.Enabled = False
        conpass.Location = New Point(259, 346)
        conpass.Name = "conpass"
        conpass.Size = New Size(159, 23)
        conpass.TabIndex = 78
        conpass.TextAlign = HorizontalAlignment.Center
        ' 
        ' pass
        ' 
        pass.BorderStyle = BorderStyle.FixedSingle
        pass.Enabled = False
        pass.Location = New Point(60, 346)
        pass.Name = "pass"
        pass.Size = New Size(155, 23)
        pass.TabIndex = 77
        pass.TextAlign = HorizontalAlignment.Center
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label9.Location = New Point(260, 135)
        label9.Name = "label9"
        label9.Size = New Size(48, 13)
        label9.TabIndex = 81
        label9.Text = "Section:"
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label8.Location = New Point(259, 250)
        label8.Name = "label8"
        label8.Size = New Size(32, 13)
        label8.TabIndex = 73
        label8.Text = "Year:"
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label4.Location = New Point(259, 330)
        label4.Name = "label4"
        label4.Size = New Size(105, 13)
        label4.TabIndex = 69
        label4.Text = "Confirm Password:"
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label5.Location = New Point(62, 135)
        label5.Name = "label5"
        label5.Size = New Size(41, 13)
        label5.TabIndex = 70
        label5.Text = "Name:"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label6.Location = New Point(60, 193)
        label6.Name = "label6"
        label6.Size = New Size(38, 13)
        label6.TabIndex = 71
        label6.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(260, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 13)
        Label1.TabIndex = 72
        Label1.Text = "Course:"
        ' 
        ' btn_Upload
        ' 
        btn_Upload.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btn_Upload.BackgroundImageLayout = ImageLayout.None
        btn_Upload.Enabled = False
        btn_Upload.FlatStyle = FlatStyle.System
        btn_Upload.Location = New Point(478, 206)
        btn_Upload.Name = "btn_Upload"
        btn_Upload.Size = New Size(84, 26)
        btn_Upload.TabIndex = 66
        btn_Upload.Text = "Upload"
        btn_Upload.UseVisualStyleBackColor = False
        ' 
        ' pbProfile
        ' 
        pbProfile.BackColor = Color.LightYellow
        pbProfile.BorderStyle = BorderStyle.FixedSingle
        pbProfile.Location = New Point(455, 63)
        pbProfile.Name = "pbProfile"
        pbProfile.Size = New Size(128, 126)
        pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfile.TabIndex = 52
        pbProfile.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.DarkSeaGreen
        Label7.Font = New Font("Tahoma", 20F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(191, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 33)
        Label7.TabIndex = 39
        Label7.Text = "Profile"
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.DarkGray
        Label10.Font = New Font("Ravie", 8F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(26, 87)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(8, 8, 16, 8)
        Label10.Size = New Size(123, 32)
        Label10.TabIndex = 72
        Label10.Text = "Web Novel"
        Label10.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DarkGray
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(54, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(67, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 71
        PictureBox1.TabStop = False
        ' 
        ' DAshboard
        ' 
        DAshboard.BackColor = Color.DarkGray
        DAshboard.BackgroundImageLayout = ImageLayout.None
        DAshboard.FlatAppearance.BorderColor = Color.DarkGray
        DAshboard.FlatStyle = FlatStyle.Flat
        DAshboard.Location = New Point(0, 153)
        DAshboard.Name = "DAshboard"
        DAshboard.Size = New Size(184, 36)
        DAshboard.TabIndex = 67
        DAshboard.Text = "Dashboard"
        DAshboard.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkGray
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.FlatAppearance.BorderColor = Color.DarkGray
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(0, 313)
        Button5.Name = "Button5"
        Button5.Size = New Size(184, 36)
        Button5.TabIndex = 65
        Button5.Text = "Profile"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.DarkGray
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.FlatAppearance.BorderColor = Color.DarkGray
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(0, 271)
        Button7.Name = "Button7"
        Button7.Size = New Size(184, 36)
        Button7.TabIndex = 64
        Button7.Text = "About"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGray
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.FlatAppearance.BorderColor = Color.DarkGray
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(0, 229)
        Button4.Name = "Button4"
        Button4.Size = New Size(184, 36)
        Button4.TabIndex = 63
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGray
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatAppearance.BorderColor = Color.DarkGray
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(0, 195)
        Button3.Name = "Button3"
        Button3.Size = New Size(184, 36)
        Button3.TabIndex = 62
        Button3.Text = "Product"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGray
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(DAshboard)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(184, 455)
        Panel1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatAppearance.BorderColor = Color.DarkGray
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Button1.Location = New Point(3, 388)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 40)
        Button1.TabIndex = 57
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSeaGreen
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(Button8)
        Panel2.Controls.Add(update)
        Panel2.Controls.Add(SCT)
        Panel2.Controls.Add(YR)
        Panel2.Controls.Add(CS)
        Panel2.Controls.Add(email)
        Panel2.Controls.Add(address)
        Panel2.Controls.Add(ngalan)
        Panel2.Controls.Add(label2)
        Panel2.Controls.Add(label3)
        Panel2.Controls.Add(conpass)
        Panel2.Controls.Add(pass)
        Panel2.Controls.Add(label9)
        Panel2.Controls.Add(label8)
        Panel2.Controls.Add(label4)
        Panel2.Controls.Add(label5)
        Panel2.Controls.Add(label6)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(btn_Upload)
        Panel2.Controls.Add(pbProfile)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(182, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(618, 455)
        Panel2.TabIndex = 9
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Profile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Profile"
        CType(pbProfile, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button8 As Button
    Friend WithEvents update As Button
    Private WithEvents SCT As ComboBox
    Private WithEvents YR As ComboBox
    Friend WithEvents CS As ComboBox
    Private WithEvents email As TextBox
    Private WithEvents address As TextBox
    Private WithEvents ngalan As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents conpass As TextBox
    Private WithEvents pass As TextBox
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents btn_Upload As Button
    Friend WithEvents pbProfile As PictureBox
    Private WithEvents Label7 As Label
    Private WithEvents Label10 As Label
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents DAshboard As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
