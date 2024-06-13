<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label4 = New Label()
        password = New TextBox()
        label1 = New Label()
        username = New TextBox()
        LOG = New Button()
        button1 = New Button()
        label3 = New Label()
        label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(487, 359)
        Label4.Name = "Label4"
        Label4.Size = New Size(198, 13)
        Label4.TabIndex = 49
        Label4.Text = "Don't have an account? Click sign-up"
        ' 
        ' password
        ' 
        password.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        password.Location = New Point(531, 196)
        password.Multiline = True
        password.Name = "password"
        password.Size = New Size(179, 26)
        password.TabIndex = 48
        password.TextAlign = HorizontalAlignment.Center
        ' 
        ' label1
        ' 
        label1.Font = New Font("Tahoma", 15F, FontStyle.Bold)
        label1.ForeColor = SystemColors.ActiveCaptionText
        label1.Location = New Point(480, 69)
        label1.Name = "label1"
        label1.Size = New Size(198, 42)
        label1.TabIndex = 41
        label1.Text = "LOGIN"
        label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' username
        ' 
        username.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        username.Location = New Point(531, 157)
        username.Multiline = True
        username.Name = "username"
        username.Size = New Size(179, 26)
        username.TabIndex = 47
        username.TextAlign = HorizontalAlignment.Center
        ' 
        ' LOG
        ' 
        LOG.BackColor = Color.LightCoral
        LOG.Location = New Point(480, 276)
        LOG.Name = "LOG"
        LOG.Size = New Size(205, 35)
        LOG.TabIndex = 46
        LOG.Text = "Login"
        LOG.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.FlatStyle = FlatStyle.System
        button1.Location = New Point(480, 317)
        button1.Name = "button1"
        button1.Size = New Size(205, 30)
        button1.TabIndex = 45
        button1.Text = "Sign up"
        button1.UseVisualStyleBackColor = True
        ' 
        ' label3
        ' 
        label3.AutoSize = True
        label3.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        label3.ForeColor = SystemColors.ActiveCaptionText
        label3.Location = New Point(439, 203)
        label3.Name = "label3"
        label3.Size = New Size(86, 19)
        label3.TabIndex = 43
        label3.Text = "Password:"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.FlatStyle = FlatStyle.Popup
        label2.Font = New Font("Yu Gothic", 11.25F, FontStyle.Bold)
        label2.ForeColor = SystemColors.ActiveCaptionText
        label2.Location = New Point(435, 161)
        label2.Name = "label2"
        label2.Size = New Size(90, 19)
        label2.TabIndex = 42
        label2.Text = "Username:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(389, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 438)
        Controls.Add(Label4)
        Controls.Add(password)
        Controls.Add(label1)
        Controls.Add(username)
        Controls.Add(LOG)
        Controls.Add(button1)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents Label4 As Label
    Private WithEvents password As TextBox
    Private WithEvents label1 As Label
    Private WithEvents username As TextBox
    Private WithEvents LOG As Button
    Private WithEvents button1 As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
