<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLoginForm))
        Panel1 = New Panel()
        Button13 = New Button()
        txtUsername = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LoginButton = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Panel2 = New Panel()
        Panel3 = New Panel()
        txtPassword = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button13)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(399, 31)
        Panel1.TabIndex = 0
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(372, 3)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 1
        Button13.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Cursor = Cursors.IBeam
        txtUsername.Font = New Font("Calibri", 12F)
        txtUsername.Location = New Point(-1, 3)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(294, 32)
        txtUsername.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 11.25F)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(46, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 11
        Label1.Text = "         Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 11.25F)
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Image = CType(resources.GetObject("Label2.Image"), Image)
        Label2.ImageAlign = ContentAlignment.MiddleLeft
        Label2.Location = New Point(46, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 18)
        Label2.TabIndex = 13
        Label2.Text = "         Password"
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.Red
        LoginButton.Cursor = Cursors.Hand
        LoginButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = SystemColors.ButtonHighlight
        LoginButton.Location = New Point(46, 341)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(146, 43)
        LoginButton.TabIndex = 15
        LoginButton.Text = "LOGIN"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(165, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 72)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(208, 341)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 43)
        Button2.TabIndex = 17
        Button2.Text = "REGISTER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtUsername)
        Panel2.Location = New Point(50, 202)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(8, 0, 0, 0)
        Panel2.Size = New Size(298, 36)
        Panel2.TabIndex = 18
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtPassword)
        Panel3.Location = New Point(50, 274)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(8, 0, 0, 0)
        Panel3.Size = New Size(298, 36)
        Panel3.TabIndex = 19
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Cursor = Cursors.IBeam
        txtPassword.Font = New Font("Calibri", 12F)
        txtPassword.Location = New Point(-1, 3)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(294, 31)
        txtPassword.TabIndex = 10
        ' 
        ' AdminLoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 435)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(LoginButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPassword As TextBox
End Class
