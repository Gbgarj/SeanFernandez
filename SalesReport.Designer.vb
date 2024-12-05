<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReport))
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button13 = New Button()
        Panel15 = New Panel()
        btnInventoryReport = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnLogout = New Button()
        Panel1 = New Panel()
        Panel4 = New Panel()
        lblLowestSales = New Label()
        Label15 = New Label()
        Panel3 = New Panel()
        Panel7 = New Panel()
        lblHighestSales = New Label()
        Label8 = New Label()
        lblTotalSales = New Label()
        Label6 = New Label()
        Panel6 = New Panel()
        cmbFilter = New ComboBox()
        Label14 = New Label()
        Panel5 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        DataGridView2 = New DataGridView()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel15.SuspendLayout()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(861, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel15.Controls.Add(btnInventoryReport)
        Panel15.Controls.Add(Button4)
        Panel15.Controls.Add(Button3)
        Panel15.Controls.Add(Button2)
        Panel15.Controls.Add(Button1)
        Panel15.Controls.Add(btnLogout)
        Panel15.Dock = DockStyle.Left
        Panel15.Location = New Point(0, 46)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(71, 483)
        Panel15.TabIndex = 34
        ' 
        ' btnInventoryReport
        ' 
        btnInventoryReport.Cursor = Cursors.Hand
        btnInventoryReport.Dock = DockStyle.Bottom
        btnInventoryReport.FlatAppearance.BorderSize = 0
        btnInventoryReport.FlatStyle = FlatStyle.Flat
        btnInventoryReport.Image = CType(resources.GetObject("btnInventoryReport.Image"), Image)
        btnInventoryReport.Location = New Point(0, 1)
        btnInventoryReport.Name = "btnInventoryReport"
        btnInventoryReport.Size = New Size(71, 83)
        btnInventoryReport.TabIndex = 10
        btnInventoryReport.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button4.Cursor = Cursors.Hand
        Button4.Dock = DockStyle.Bottom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(0, 84)
        Button4.Name = "Button4"
        Button4.Size = New Size(71, 83)
        Button4.TabIndex = 9
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Bottom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(0, 167)
        Button3.Name = "Button3"
        Button3.Size = New Size(71, 83)
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
        Button2.Location = New Point(0, 250)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 83)
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
        Button1.Location = New Point(0, 333)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 83)
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
        btnLogout.Location = New Point(0, 416)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(71, 67)
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
        Panel1.Size = New Size(897, 46)
        Panel1.TabIndex = 33
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.Controls.Add(lblLowestSales)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Panel3)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(lblHighestSales)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(lblTotalSales)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(DataGridView2)
        Panel4.Controls.Add(Panel2)
        Panel4.Controls.Add(DataGridView1)
        Panel4.Location = New Point(71, 46)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(823, 482)
        Panel4.TabIndex = 48
        ' 
        ' lblLowestSales
        ' 
        lblLowestSales.AutoSize = True
        lblLowestSales.Font = New Font("Calibri", 9.75F)
        lblLowestSales.Location = New Point(202, 944)
        lblLowestSales.Name = "lblLowestSales"
        lblLowestSales.Size = New Size(50, 15)
        lblLowestSales.TabIndex = 67
        lblLowestSales.Text = "Product"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 9.75F)
        Label15.Location = New Point(46, 943)
        Label15.Name = "Label15"
        Label15.Size = New Size(119, 15)
        Label15.TabIndex = 66
        Label15.Text = "Lowest Product Sale:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel3.Location = New Point(8, 484)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(795, 9)
        Panel3.TabIndex = 65
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(47, 972)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(200, 23)
        Panel7.TabIndex = 64
        ' 
        ' lblHighestSales
        ' 
        lblHighestSales.AutoSize = True
        lblHighestSales.Font = New Font("Calibri", 9.75F)
        lblHighestSales.Location = New Point(202, 914)
        lblHighestSales.Name = "lblHighestSales"
        lblHighestSales.Size = New Size(50, 15)
        lblHighestSales.TabIndex = 63
        lblHighestSales.Text = "Product"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 9.75F)
        Label8.Location = New Point(46, 913)
        Label8.Name = "Label8"
        Label8.Size = New Size(123, 15)
        Label8.TabIndex = 62
        Label8.Text = "Highest Product Sale:"
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Calibri", 9.75F)
        lblTotalSales.Location = New Point(682, 915)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(31, 15)
        lblTotalSales.TabIndex = 61
        lblTotalSales.Text = "0.00"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 9.75F)
        Label6.Location = New Point(591, 913)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 60
        Label6.Text = "Total Sales:"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.Window
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(cmbFilter)
        Panel6.Location = New Point(113, 536)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(134, 31)
        Panel6.TabIndex = 59
        ' 
        ' cmbFilter
        ' 
        cmbFilter.DropDownHeight = 120
        cmbFilter.FlatStyle = FlatStyle.Flat
        cmbFilter.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmbFilter.FormattingEnabled = True
        cmbFilter.IntegralHeight = False
        cmbFilter.Items.AddRange(New Object() {"All", "Daily", "Weekly", "Monthly"})
        cmbFilter.Location = New Point(3, 3)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(126, 23)
        cmbFilter.TabIndex = 41
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(47, 542)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 15)
        Label14.TabIndex = 58
        Label14.Text = "Filter by:"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Red
        Panel5.Controls.Add(Label10)
        Panel5.Controls.Add(Label11)
        Panel5.Controls.Add(Label12)
        Panel5.Controls.Add(Label13)
        Panel5.Location = New Point(46, 584)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(720, 35)
        Panel5.TabIndex = 57
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 9.75F)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(579, 11)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 15)
        Label10.TabIndex = 3
        Label10.Text = "TOTAL AMOUNT"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9.75F)
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(410, 11)
        Label11.Name = "Label11"
        Label11.Size = New Size(92, 15)
        Label11.TabIndex = 2
        Label11.Text = "QUANTITY SOLD"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 9.75F)
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(259, 11)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 15)
        Label12.TabIndex = 1
        Label12.Text = "PRODUCT"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9.75F)
        Label13.ForeColor = SystemColors.ButtonHighlight
        Label13.Location = New Point(67, 11)
        Label13.Name = "Label13"
        Label13.Size = New Size(92, 15)
        Label13.TabIndex = 0
        Label13.Text = "PRODUCT CODE"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(46, 597)
        DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridView2.Size = New Size(720, 299)
        DataGridView2.TabIndex = 56
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(46, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(720, 35)
        Panel2.TabIndex = 49
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(579, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 3
        Label4.Text = "TOTAL AMOUNT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(410, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 2
        Label3.Text = "QUANTITY SOLD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(269, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "PRODUCT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(67, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 15)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT CODE"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(46, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        DataGridView1.Size = New Size(720, 299)
        DataGridView1.TabIndex = 48
        ' 
        ' SalesReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 529)
        Controls.Add(Panel4)
        Controls.Add(Panel15)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SalesReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = resources.GetString("$this.Text")
        Panel15.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button13 As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents btnInventoryReport As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblHighestSales As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblLowestSales As Label
    Friend WithEvents Label15 As Label
End Class
