<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductInventoryApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductInventoryApp))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button13 = New Button()
        btnUpdate = New Button()
        dgvProducts = New DataGridView()
        Panel2 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Panel15 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        btnLogout = New Button()
        Panel3 = New Panel()
        txtQuantity = New TextBox()
        Panel1.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel15.SuspendLayout()
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
        Panel1.Size = New Size(858, 46)
        Panel1.TabIndex = 22
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(822, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Red
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = SystemColors.ButtonHighlight
        btnUpdate.Location = New Point(702, 486)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(117, 48)
        btnUpdate.TabIndex = 24
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' dgvProducts
        ' 
        dgvProducts.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvProducts.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        dgvProducts.Location = New Point(110, 160)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.Size = New Size(709, 308)
        dgvProducts.TabIndex = 28
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(110, 147)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(709, 45)
        Panel2.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(592, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 3
        Label4.Text = "QUANTITY"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(436, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 2
        Label3.Text = "PRICE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(265, 18)
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
        Label1.Location = New Point(86, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT ID"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Red
        btnSearch.Cursor = Cursors.Hand
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), Image)
        btnSearch.Location = New Point(779, 80)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(40, 33)
        btnSearch.TabIndex = 31
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.Font = New Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(110, 80)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(663, 33)
        txtSearch.TabIndex = 30
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel15.Controls.Add(Button5)
        Panel15.Controls.Add(Button4)
        Panel15.Controls.Add(Button3)
        Panel15.Controls.Add(Button2)
        Panel15.Controls.Add(Button1)
        Panel15.Controls.Add(btnLogout)
        Panel15.Dock = DockStyle.Left
        Panel15.Location = New Point(0, 46)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(71, 522)
        Panel15.TabIndex = 32
        ' 
        ' Button5
        ' 
        Button5.Cursor = Cursors.Hand
        Button5.Dock = DockStyle.Bottom
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(0, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(71, 90)
        Button5.TabIndex = 13
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.Dock = DockStyle.Bottom
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(0, 90)
        Button4.Name = "Button4"
        Button4.Size = New Size(71, 90)
        Button4.TabIndex = 12
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Bottom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(0, 180)
        Button3.Name = "Button3"
        Button3.Size = New Size(71, 90)
        Button3.TabIndex = 11
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Bottom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(0, 270)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 85)
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
        Button1.Location = New Point(0, 355)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 85)
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
        btnLogout.Location = New Point(0, 440)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(71, 82)
        btnLogout.TabIndex = 5
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel3.Controls.Add(txtQuantity)
        Panel3.Location = New Point(613, 486)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(83, 48)
        Panel3.TabIndex = 34
        ' 
        ' txtQuantity
        ' 
        txtQuantity.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtQuantity.BorderStyle = BorderStyle.None
        txtQuantity.Location = New Point(3, 15)
        txtQuantity.Multiline = True
        txtQuantity.Name = "txtQuantity"
        txtQuantity.PlaceholderText = "Edit..."
        txtQuantity.Size = New Size(76, 28)
        txtQuantity.TabIndex = 28
        txtQuantity.TextAlign = HorizontalAlignment.Center
        ' 
        ' ProductInventoryApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(858, 568)
        Controls.Add(Panel3)
        Controls.Add(Panel15)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Panel2)
        Controls.Add(dgvProducts)
        Controls.Add(btnUpdate)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ProductInventoryApp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
End Class
