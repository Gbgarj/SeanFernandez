<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Label1 = New Label()
        lblSubTotal = New Label()
        Label3 = New Label()
        txtAmountReceived = New TextBox()
        Label4 = New Label()
        btnCalculate = New Button()
        btnConfirm = New Button()
        lblVAT = New Label()
        Label5 = New Label()
        lblTotalAmount = New Label()
        Label7 = New Label()
        lblChange = New Label()
        Button13 = New Button()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.Location = New Point(25, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Sub Total:"
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.AutoSize = True
        lblSubTotal.Font = New Font("Calibri", 9.75F)
        lblSubTotal.Location = New Point(102, 61)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(14, 15)
        lblSubTotal.TabIndex = 1
        lblSubTotal.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.Location = New Point(25, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 2
        Label3.Text = "Amount Received:"
        ' 
        ' txtAmountReceived
        ' 
        txtAmountReceived.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        txtAmountReceived.BorderStyle = BorderStyle.FixedSingle
        txtAmountReceived.Font = New Font("Calibri", 9.75F)
        txtAmountReceived.Location = New Point(143, 162)
        txtAmountReceived.Name = "txtAmountReceived"
        txtAmountReceived.Size = New Size(75, 23)
        txtAmountReceived.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F)
        Label4.Location = New Point(25, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 15)
        Label4.TabIndex = 4
        Label4.Text = "Change:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnCalculate.Cursor = Cursors.Hand
        btnCalculate.FlatAppearance.BorderSize = 0
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        btnCalculate.ForeColor = SystemColors.ButtonHighlight
        btnCalculate.Location = New Point(41, 265)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(127, 46)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.Red
        btnConfirm.Cursor = Cursors.Hand
        btnConfirm.FlatAppearance.BorderSize = 0
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.Font = New Font("Arial Black", 9F, FontStyle.Bold)
        btnConfirm.ForeColor = SystemColors.ButtonHighlight
        btnConfirm.Location = New Point(190, 265)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(127, 44)
        btnConfirm.TabIndex = 7
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' lblVAT
        ' 
        lblVAT.AutoSize = True
        lblVAT.Font = New Font("Calibri", 9.75F)
        lblVAT.Location = New Point(102, 95)
        lblVAT.Name = "lblVAT"
        lblVAT.Size = New Size(14, 15)
        lblVAT.TabIndex = 9
        lblVAT.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F)
        Label5.Location = New Point(25, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 8
        Label5.Text = "VAT (12%):"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Calibri", 9.75F)
        lblTotalAmount.Location = New Point(122, 128)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(14, 15)
        lblTotalAmount.TabIndex = 11
        lblTotalAmount.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 9.75F)
        Label7.Location = New Point(25, 128)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 15)
        Label7.TabIndex = 10
        Label7.Text = "Total Amount:"
        ' 
        ' lblChange
        ' 
        lblChange.AutoSize = True
        lblChange.Font = New Font("Calibri", 9.75F)
        lblChange.Location = New Point(93, 197)
        lblChange.Name = "lblChange"
        lblChange.Size = New Size(14, 15)
        lblChange.TabIndex = 12
        lblChange.Text = "0"
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(337, 3)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 13
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button13)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 33)
        Panel1.TabIndex = 14
        ' 
        ' PaymentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 359)
        Controls.Add(Panel1)
        Controls.Add(lblChange)
        Controls.Add(lblTotalAmount)
        Controls.Add(Label7)
        Controls.Add(lblVAT)
        Controls.Add(Label5)
        Controls.Add(btnConfirm)
        Controls.Add(btnCalculate)
        Controls.Add(Label4)
        Controls.Add(txtAmountReceived)
        Controls.Add(Label3)
        Controls.Add(lblSubTotal)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "PaymentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaymentForm"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAmountReceived As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblVAT As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel1 As Panel
End Class
