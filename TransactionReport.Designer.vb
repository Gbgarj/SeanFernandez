<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionReport))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel15 = New Panel()
        btnInventory = New Button()
        btn = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnLogout = New Button()
        Panel1 = New Panel()
        Button13 = New Button()
        dtpFrom = New DateTimePicker()
        dtpTo = New DateTimePicker()
        Label3 = New Label()
        Label5 = New Label()
        btnFilter = New Button()
        TransactionGridView = New DataGridView()
        Panel2 = New Panel()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel15.SuspendLayout()
        Panel1.SuspendLayout()
        CType(TransactionGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel15.Controls.Add(btnInventory)
        Panel15.Controls.Add(btn)
        Panel15.Controls.Add(Button3)
        Panel15.Controls.Add(Button2)
        Panel15.Controls.Add(Button1)
        Panel15.Controls.Add(btnLogout)
        Panel15.Dock = DockStyle.Left
        Panel15.Location = New Point(0, 46)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(71, 560)
        Panel15.TabIndex = 36
        ' 
        ' btnInventory
        ' 
        btnInventory.Cursor = Cursors.Hand
        btnInventory.Dock = DockStyle.Bottom
        btnInventory.FlatAppearance.BorderSize = 0
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), Image)
        btnInventory.Location = New Point(0, 0)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(71, 95)
        btnInventory.TabIndex = 10
        btnInventory.UseVisualStyleBackColor = True
        ' 
        ' btn
        ' 
        btn.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn.Cursor = Cursors.Hand
        btn.Dock = DockStyle.Bottom
        btn.FlatAppearance.BorderSize = 0
        btn.FlatStyle = FlatStyle.Flat
        btn.Image = CType(resources.GetObject("btn.Image"), Image)
        btn.Location = New Point(0, 95)
        btn.Name = "btn"
        btn.Size = New Size(71, 89)
        btn.TabIndex = 9
        btn.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Bottom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(0, 184)
        Button3.Name = "Button3"
        Button3.Size = New Size(71, 89)
        Button3.TabIndex = 8
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Bottom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(0, 273)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 96)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Bottom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(0, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 99)
        Button1.TabIndex = 6
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Black
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(0, 468)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(71, 92)
        btnLogout.TabIndex = 5
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Red
        Panel1.Controls.Add(Button13)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(951, 46)
        Panel1.TabIndex = 35
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(930, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' dtpFrom
        ' 
        dtpFrom.Font = New Font("Calibri", 9.75F)
        dtpFrom.Location = New Point(210, 82)
        dtpFrom.Name = "dtpFrom"
        dtpFrom.Size = New Size(200, 23)
        dtpFrom.TabIndex = 43
        ' 
        ' dtpTo
        ' 
        dtpTo.Font = New Font("Calibri", 9.75F)
        dtpTo.Location = New Point(210, 119)
        dtpTo.Name = "dtpTo"
        dtpTo.Size = New Size(200, 23)
        dtpTo.TabIndex = 44
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(124, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 45
        Label3.Text = "FILTER FROM:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(124, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 46
        Label5.Text = "FILTER TO:"
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnFilter.Cursor = Cursors.Hand
        btnFilter.FlatAppearance.BorderSize = 0
        btnFilter.FlatStyle = FlatStyle.Flat
        btnFilter.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = SystemColors.ButtonHighlight
        btnFilter.Location = New Point(425, 82)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(104, 58)
        btnFilter.TabIndex = 47
        btnFilter.Text = "FILTER"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' TransactionGridView
        ' 
        TransactionGridView.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TransactionGridView.BorderStyle = BorderStyle.None
        TransactionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TransactionGridView.Location = New Point(124, 192)
        TransactionGridView.Name = "TransactionGridView"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        TransactionGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        TransactionGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        TransactionGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        TransactionGridView.ScrollBars = ScrollBars.Vertical
        TransactionGridView.Size = New Size(773, 364)
        TransactionGridView.TabIndex = 41
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(124, 181)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(773, 37)
        Panel2.TabIndex = 50
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(587, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 3
        Label4.Text = "TOTAL AMOUNT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(359, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 1
        Label2.Text = "DATE"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(75, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 0
        Label1.Text = "TRANSACTION ID"
        ' 
        ' TransactionReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 606)
        Controls.Add(Panel2)
        Controls.Add(TransactionGridView)
        Controls.Add(btnFilter)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(dtpTo)
        Controls.Add(dtpFrom)
        Controls.Add(Panel15)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "TransactionReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TransactionReport"
        Panel15.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(TransactionGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnInventory As Button
    Friend WithEvents btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents TransactionGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
