<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSignUpForm))
        Panel1 = New Panel()
        Button13 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        register = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        firstname = New TextBox()
        Panel3 = New Panel()
        lastname = New TextBox()
        Panel4 = New Panel()
        username = New TextBox()
        password = New TextBox()
        Panel5 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button13)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(480, 32)
        Panel1.TabIndex = 0
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(453, 3)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 1
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(156, 141)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 15)
        Label1.TabIndex = 2
        Label1.Text = "Manager Account Registration"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(205, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 65)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' register
        ' 
        register.BackColor = Color.Red
        register.FlatAppearance.BorderSize = 0
        register.FlatStyle = FlatStyle.Flat
        register.Font = New Font("Arial Black", 8.25F, FontStyle.Bold)
        register.ForeColor = Color.White
        register.Location = New Point(61, 393)
        register.Name = "register"
        register.Size = New Size(166, 44)
        register.TabIndex = 7
        register.Text = "REGSITER"
        register.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(251, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 44)
        Button2.TabIndex = 8
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(firstname)
        Panel2.Location = New Point(61, 209)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(166, 38)
        Panel2.TabIndex = 9
        ' 
        ' firstname
        ' 
        firstname.BorderStyle = BorderStyle.None
        firstname.Font = New Font("Calibri", 11.25F)
        firstname.Location = New Point(3, 6)
        firstname.Multiline = True
        firstname.Name = "firstname"
        firstname.PlaceholderText = "First Name"
        firstname.Size = New Size(166, 32)
        firstname.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lastname)
        Panel3.Location = New Point(251, 210)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(166, 38)
        Panel3.TabIndex = 10
        ' 
        ' lastname
        ' 
        lastname.BorderStyle = BorderStyle.None
        lastname.Font = New Font("Calibri", 11.25F)
        lastname.Location = New Point(3, 6)
        lastname.Multiline = True
        lastname.Name = "lastname"
        lastname.PlaceholderText = "Last Name"
        lastname.Size = New Size(166, 32)
        lastname.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(username)
        Panel4.Location = New Point(61, 268)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(356, 38)
        Panel4.TabIndex = 11
        ' 
        ' username
        ' 
        username.BorderStyle = BorderStyle.None
        username.Font = New Font("Calibri", 11.25F)
        username.Location = New Point(3, 6)
        username.Multiline = True
        username.Name = "username"
        username.PlaceholderText = "Username"
        username.Size = New Size(348, 32)
        username.TabIndex = 2
        ' 
        ' password
        ' 
        password.BorderStyle = BorderStyle.None
        password.Font = New Font("Calibri", 11.25F)
        password.Location = New Point(3, 6)
        password.Multiline = True
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(348, 32)
        password.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(password)
        Panel5.Location = New Point(61, 328)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(356, 38)
        Panel5.TabIndex = 12
        ' 
        ' AdminSignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 500)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(register)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminSignUpForm"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents register As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents firstname As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lastname As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents username As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Panel5 As Panel
End Class
