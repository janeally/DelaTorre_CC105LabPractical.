<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Panel1 = New Panel()
        Label10 = New Label()
        PictureBox1 = New PictureBox()
        DAshboard = New Button()
        Button5 = New Button()
        Button7 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Profiles = New PictureBox()
        label5 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Profiles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(179, 455)
        Panel1.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.DarkGray
        Label10.Font = New Font("Ravie", 8F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(33, 90)
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
        DAshboard.Size = New Size(179, 36)
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
        Button5.Size = New Size(177, 36)
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
        Button7.Size = New Size(179, 36)
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
        Button4.Size = New Size(179, 36)
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
        Button3.Size = New Size(179, 36)
        Button3.TabIndex = 62
        Button3.Text = "Product"
        Button3.UseVisualStyleBackColor = False
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
        Button1.Size = New Size(174, 40)
        Button1.TabIndex = 57
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Profiles
        ' 
        Profiles.BackColor = Color.LightYellow
        Profiles.BorderStyle = BorderStyle.FixedSingle
        Profiles.Location = New Point(332, 90)
        Profiles.Name = "Profiles"
        Profiles.Size = New Size(128, 126)
        Profiles.SizeMode = PictureBoxSizeMode.StretchImage
        Profiles.TabIndex = 53
        Profiles.TabStop = False
        ' 
        ' label5
        ' 
        label5.AutoSize = True
        label5.Font = New Font("STXihei", 9.75F)
        label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        label5.Location = New Point(300, 239)
        label5.Name = "label5"
        label5.Size = New Size(81, 14)
        label5.TabIndex = 71
        label5.Text = "Created By:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(387, 234)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 72
        Label1.Text = "Jane Dela Torre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(387, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 20)
        Label2.TabIndex = 74
        Label2.Text = "1st Year - D"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("STXihei", 9.75F)
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Location = New Point(263, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 14)
        Label3.TabIndex = 73
        Label3.Text = "Year and Section:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Location = New Point(387, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 76
        Label4.Text = "CC103"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("STXihei", 9.75F)
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(324, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 14)
        Label6.TabIndex = 75
        Label6.Text = "Subject:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label7.Location = New Point(387, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(163, 20)
        Label7.TabIndex = 78
        Label7.Text = "Julius Ceazar Aboltivo"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("STXihei", 9.75F)
        Label8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label8.Location = New Point(289, 346)
        Label8.Name = "Label8"
        Label8.Size = New Size(92, 14)
        Label8.TabIndex = 77
        Label8.Text = "Submitted To:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.AppWorkspace
        Label9.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(347, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 37)
        Label9.TabIndex = 79
        Label9.Text = "Profile"
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(628, 450)
        Controls.Add(Label9)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(label5)
        Controls.Add(Profiles)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "About"
        StartPosition = FormStartPosition.CenterScreen
        Text = "About"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Profiles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Private WithEvents Label10 As Label
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents DAshboard As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Profiles As PictureBox
    Private WithEvents label5 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label9 As Label
End Class
