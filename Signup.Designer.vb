<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        Label12 = New Label()
        birth = New DateTimePicker()
        mail = New TextBox()
        Label11 = New Label()
        PictureBox1 = New PictureBox()
        Label10 = New Label()
        section = New ComboBox()
        button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        year = New ComboBox()
        course = New ComboBox()
        lname = New TextBox()
        US = New TextBox()
        label1 = New Label()
        fname = New TextBox()
        label2 = New Label()
        label3 = New Label()
        conpass = New TextBox()
        PS = New TextBox()
        label9 = New Label()
        label8 = New Label()
        label4 = New Label()
        label5 = New Label()
        GroupBox1 = New GroupBox()
        label6 = New Label()
        label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label12.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label12.Location = New Point(251, 313)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 13)
        Label12.TabIndex = 51
        Label12.Text = "Birth date:"
        Label12.UseWaitCursor = True
        ' 
        ' birth
        ' 
        birth.Location = New Point(251, 329)
        birth.Name = "birth"
        birth.Size = New Size(158, 22)
        birth.TabIndex = 50
        birth.UseWaitCursor = True
        ' 
        ' mail
        ' 
        mail.BorderStyle = BorderStyle.FixedSingle
        mail.Location = New Point(49, 329)
        mail.Name = "mail"
        mail.Size = New Size(159, 22)
        mail.TabIndex = 49
        mail.TextAlign = HorizontalAlignment.Center
        mail.UseWaitCursor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label11.Location = New Point(51, 313)
        Label11.Name = "Label11"
        Label11.Size = New Size(38, 13)
        Label11.TabIndex = 48
        Label11.Text = "Email:"
        Label11.UseWaitCursor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(444, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(369, 528)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 49
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.FlatStyle = FlatStyle.Popup
        Label10.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(124, 482)
        Label10.Name = "Label10"
        Label10.Size = New Size(198, 13)
        Label10.TabIndex = 47
        Label10.Text = "Don't have an account? Click sign-up"
        Label10.UseWaitCursor = True
        ' 
        ' section
        ' 
        section.FormattingEnabled = True
        section.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"})
        section.Location = New Point(250, 273)
        section.Name = "section"
        section.Size = New Size(159, 21)
        section.TabIndex = 30
        section.UseWaitCursor = True
        ' 
        ' button2
        ' 
        button2.BackColor = Color.LightCoral
        button2.Location = New Point(122, 401)
        button2.Name = "button2"
        button2.Size = New Size(207, 31)
        button2.TabIndex = 41
        button2.Text = "Sign-Up"
        button2.UseVisualStyleBackColor = False
        button2.UseWaitCursor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(122, 438)
        Button1.Name = "Button1"
        Button1.Size = New Size(207, 29)
        Button1.TabIndex = 43
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Button3.Location = New Point(165, 178)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 22)
        Button3.TabIndex = 44
        Button3.Text = "show"
        Button3.UseVisualStyleBackColor = False
        Button3.UseWaitCursor = True
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 7F, FontStyle.Bold)
        Button4.Location = New Point(368, 178)
        Button4.Name = "Button4"
        Button4.Size = New Size(41, 22)
        Button4.TabIndex = 45
        Button4.Text = "show"
        Button4.UseVisualStyleBackColor = False
        Button4.UseWaitCursor = True
        ' 
        ' year
        ' 
        year.FormattingEnabled = True
        year.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        year.Location = New Point(51, 273)
        year.Name = "year"
        year.Size = New Size(155, 21)
        year.TabIndex = 29
        year.UseWaitCursor = True
        ' 
        ' course
        ' 
        course.FormattingEnabled = True
        course.Items.AddRange(New Object() {"COMPUTER SCIENCE", "HOTEL MANAGEMENT", "CRIMINOLOGY", "EDUCATION", "BUSINESS ADMINISTRATION"})
        course.Location = New Point(250, 227)
        course.Name = "course"
        course.Size = New Size(159, 21)
        course.TabIndex = 42
        course.UseWaitCursor = True
        ' 
        ' lname
        ' 
        lname.BorderStyle = BorderStyle.FixedSingle
        lname.Location = New Point(250, 133)
        lname.Name = "lname"
        lname.Size = New Size(159, 22)
        lname.TabIndex = 35
        lname.TextAlign = HorizontalAlignment.Center
        lname.UseWaitCursor = True
        ' 
        ' US
        ' 
        US.BorderStyle = BorderStyle.FixedSingle
        US.Location = New Point(51, 225)
        US.Name = "US"
        US.Size = New Size(157, 22)
        US.TabIndex = 31
        US.TextAlign = HorizontalAlignment.Center
        US.UseWaitCursor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Tahoma", 20F, FontStyle.Bold)
        label1.ForeColor = SystemColors.ActiveCaptionText
        label1.Location = New Point(165, 44)
        label1.Name = "label1"
        label1.Size = New Size(136, 33)
        label1.TabIndex = 21
        label1.Text = "SIGN-UP"
        label1.UseWaitCursor = True
        ' 
        ' fname
        ' 
        fname.BorderStyle = BorderStyle.FixedSingle
        fname.Location = New Point(51, 133)
        fname.Name = "fname"
        fname.Size = New Size(159, 22)
        fname.TabIndex = 34
        fname.TextAlign = HorizontalAlignment.Center
        fname.UseWaitCursor = True
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label2.Location = New Point(53, 209)
        label2.Name = "label2"
        label2.Size = New Size(62, 13)
        label2.TabIndex = 22
        label2.Text = "Username:"
        label2.UseWaitCursor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label3.Location = New Point(53, 162)
        label3.Name = "label3"
        label3.Size = New Size(60, 13)
        label3.TabIndex = 23
        label3.Text = "Password:"
        label3.UseWaitCursor = True
        ' 
        ' conpass
        ' 
        conpass.BorderStyle = BorderStyle.FixedSingle
        conpass.Location = New Point(250, 178)
        conpass.Name = "conpass"
        conpass.Size = New Size(159, 22)
        conpass.TabIndex = 33
        conpass.TextAlign = HorizontalAlignment.Center
        conpass.UseWaitCursor = True
        ' 
        ' PS
        ' 
        PS.BorderStyle = BorderStyle.FixedSingle
        PS.Location = New Point(51, 178)
        PS.Name = "PS"
        PS.Size = New Size(155, 22)
        PS.TabIndex = 32
        PS.TextAlign = HorizontalAlignment.Center
        PS.UseWaitCursor = True
        ' 
        ' label9
        ' 
        label9.AutoSize = True
        label9.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label9.Location = New Point(251, 257)
        label9.Name = "label9"
        label9.Size = New Size(48, 13)
        label9.TabIndex = 37
        label9.Text = "Section:"
        label9.UseWaitCursor = True
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label8.Location = New Point(53, 257)
        label8.Name = "label8"
        label8.Size = New Size(32, 13)
        label8.TabIndex = 28
        label8.Text = "Year:"
        label8.UseWaitCursor = True
        ' 
        ' label4
        ' 
        label4.AutoSize = True
        label4.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label4.Location = New Point(251, 162)
        label4.Name = "label4"
        label4.Size = New Size(105, 13)
        label4.TabIndex = 24
        label4.Text = "Confirm Password:"
        label4.UseWaitCursor = True
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label5.Location = New Point(53, 117)
        label5.Name = "label5"
        label5.Size = New Size(64, 13)
        label5.TabIndex = 25
        label5.Text = "First name:"
        label5.UseWaitCursor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.WhiteSmoke
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(birth)
        GroupBox1.Controls.Add(mail)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(section)
        GroupBox1.Controls.Add(button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(year)
        GroupBox1.Controls.Add(course)
        GroupBox1.Controls.Add(lname)
        GroupBox1.Controls.Add(US)
        GroupBox1.Controls.Add(label1)
        GroupBox1.Controls.Add(fname)
        GroupBox1.Controls.Add(label2)
        GroupBox1.Controls.Add(label3)
        GroupBox1.Controls.Add(conpass)
        GroupBox1.Controls.Add(PS)
        GroupBox1.Controls.Add(label9)
        GroupBox1.Controls.Add(label8)
        GroupBox1.Controls.Add(label4)
        GroupBox1.Controls.Add(label5)
        GroupBox1.Controls.Add(label6)
        GroupBox1.Controls.Add(label7)
        GroupBox1.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        GroupBox1.Location = New Point(0, -8)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(447, 535)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.UseWaitCursor = True
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label6.Location = New Point(251, 117)
        label6.Name = "label6"
        label6.Size = New Size(63, 13)
        label6.TabIndex = 26
        label6.Text = "Last name:"
        label6.UseWaitCursor = True
        ' 
        ' label7
        ' 
        label7.AutoSize = True
        label7.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label7.Location = New Point(251, 211)
        label7.Name = "label7"
        label7.Size = New Size(46, 13)
        label7.TabIndex = 27
        label7.Text = "Course:"
        label7.UseWaitCursor = True
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(811, 526)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents Label12 As Label
    Friend WithEvents birth As DateTimePicker
    Private WithEvents mail As TextBox
    Private WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label10 As Label
    Private WithEvents section As ComboBox
    Private WithEvents button2 As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button3 As Button
    Private WithEvents Button4 As Button
    Private WithEvents year As ComboBox
    Friend WithEvents course As ComboBox
    Private WithEvents lname As TextBox
    Private WithEvents US As TextBox
    Private WithEvents label1 As Label
    Private WithEvents fname As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents conpass As TextBox
    Private WithEvents PS As TextBox
    Private WithEvents label9 As Label
    Private WithEvents label8 As Label
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
End Class
