<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryReport))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel15 = New Panel()
        Button5 = New Button()
        btnTransactionReport = New Button()
        btnSalesReport = New Button()
        btnProductInventory = New Button()
        btnOrderingApp = New Button()
        btnLogout = New Button()
        Panel1 = New Panel()
        Button13 = New Button()
        dgvInventory = New DataGridView()
        Panel2 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        txtLowStockLevel = New TextBox()
        btnEditLowStock = New Button()
        Button1 = New Button()
        Panel15.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel15.Controls.Add(Button5)
        Panel15.Controls.Add(btnTransactionReport)
        Panel15.Controls.Add(btnSalesReport)
        Panel15.Controls.Add(btnProductInventory)
        Panel15.Controls.Add(btnOrderingApp)
        Panel15.Controls.Add(btnLogout)
        Panel15.Dock = DockStyle.Left
        Panel15.Location = New Point(0, 46)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(71, 560)
        Panel15.TabIndex = 38
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
        Button5.Size = New Size(71, 95)
        Button5.TabIndex = 10
        Button5.UseVisualStyleBackColor = True
        ' 
        ' btnTransactionReport
        ' 
        btnTransactionReport.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnTransactionReport.Cursor = Cursors.Hand
        btnTransactionReport.Dock = DockStyle.Bottom
        btnTransactionReport.FlatAppearance.BorderSize = 0
        btnTransactionReport.FlatStyle = FlatStyle.Flat
        btnTransactionReport.Image = CType(resources.GetObject("btnTransactionReport.Image"), Image)
        btnTransactionReport.Location = New Point(0, 95)
        btnTransactionReport.Name = "btnTransactionReport"
        btnTransactionReport.Size = New Size(71, 89)
        btnTransactionReport.TabIndex = 9
        btnTransactionReport.UseVisualStyleBackColor = False
        ' 
        ' btnSalesReport
        ' 
        btnSalesReport.Cursor = Cursors.Hand
        btnSalesReport.Dock = DockStyle.Bottom
        btnSalesReport.FlatAppearance.BorderSize = 0
        btnSalesReport.FlatStyle = FlatStyle.Flat
        btnSalesReport.Image = CType(resources.GetObject("btnSalesReport.Image"), Image)
        btnSalesReport.Location = New Point(0, 184)
        btnSalesReport.Name = "btnSalesReport"
        btnSalesReport.Size = New Size(71, 89)
        btnSalesReport.TabIndex = 8
        btnSalesReport.UseVisualStyleBackColor = True
        ' 
        ' btnProductInventory
        ' 
        btnProductInventory.Cursor = Cursors.Hand
        btnProductInventory.Dock = DockStyle.Bottom
        btnProductInventory.FlatAppearance.BorderSize = 0
        btnProductInventory.FlatStyle = FlatStyle.Flat
        btnProductInventory.Image = CType(resources.GetObject("btnProductInventory.Image"), Image)
        btnProductInventory.Location = New Point(0, 273)
        btnProductInventory.Name = "btnProductInventory"
        btnProductInventory.Size = New Size(71, 96)
        btnProductInventory.TabIndex = 7
        btnProductInventory.UseVisualStyleBackColor = True
        ' 
        ' btnOrderingApp
        ' 
        btnOrderingApp.Cursor = Cursors.Hand
        btnOrderingApp.Dock = DockStyle.Bottom
        btnOrderingApp.FlatAppearance.BorderSize = 0
        btnOrderingApp.FlatStyle = FlatStyle.Flat
        btnOrderingApp.Image = CType(resources.GetObject("btnOrderingApp.Image"), Image)
        btnOrderingApp.Location = New Point(0, 369)
        btnOrderingApp.Name = "btnOrderingApp"
        btnOrderingApp.Size = New Size(71, 99)
        btnOrderingApp.TabIndex = 6
        btnOrderingApp.UseVisualStyleBackColor = True
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
        Panel1.TabIndex = 37
        ' 
        ' Button13
        ' 
        Button13.BackgroundImageLayout = ImageLayout.Stretch
        Button13.Cursor = Cursors.Hand
        Button13.FlatAppearance.BorderSize = 0
        Button13.FlatStyle = FlatStyle.Flat
        Button13.Image = CType(resources.GetObject("Button13.Image"), Image)
        Button13.Location = New Point(915, 12)
        Button13.Name = "Button13"
        Button13.Size = New Size(24, 24)
        Button13.TabIndex = 0
        Button13.UseVisualStyleBackColor = True
        ' 
        ' dgvInventory
        ' 
        dgvInventory.BackgroundColor = SystemColors.Control
        dgvInventory.BorderStyle = BorderStyle.None
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvInventory.DefaultCellStyle = DataGridViewCellStyle1
        dgvInventory.Location = New Point(106, 107)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.Size = New Size(805, 318)
        dgvInventory.TabIndex = 39
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Red
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(106, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(805, 37)
        Panel2.TabIndex = 51
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(658, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 15)
        Label3.TabIndex = 4
        Label3.Text = "LOW STOCK LEVEL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(473, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 15)
        Label4.TabIndex = 3
        Label4.Text = "CURRENT STOCK "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(279, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 1
        Label2.Text = "PRODUCT NAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(103, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "PRODUCT ID"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel3.Controls.Add(txtLowStockLevel)
        Panel3.Location = New Point(579, 440)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(83, 48)
        Panel3.TabIndex = 53
        ' 
        ' txtLowStockLevel
        ' 
        txtLowStockLevel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtLowStockLevel.BorderStyle = BorderStyle.None
        txtLowStockLevel.Location = New Point(3, 15)
        txtLowStockLevel.Multiline = True
        txtLowStockLevel.Name = "txtLowStockLevel"
        txtLowStockLevel.PlaceholderText = "Edit..."
        txtLowStockLevel.Size = New Size(76, 28)
        txtLowStockLevel.TabIndex = 28
        txtLowStockLevel.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnEditLowStock
        ' 
        btnEditLowStock.BackColor = Color.Red
        btnEditLowStock.Cursor = Cursors.Hand
        btnEditLowStock.FlatAppearance.BorderSize = 0
        btnEditLowStock.FlatStyle = FlatStyle.Flat
        btnEditLowStock.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditLowStock.ForeColor = SystemColors.ButtonHighlight
        btnEditLowStock.Location = New Point(671, 440)
        btnEditLowStock.Name = "btnEditLowStock"
        btnEditLowStock.Size = New Size(117, 48)
        btnEditLowStock.TabIndex = 52
        btnEditLowStock.Text = "UPDATE"
        btnEditLowStock.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(794, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 48)
        Button1.TabIndex = 54
        Button1.Text = "RESTOCK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' InventoryReport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(951, 606)
        Controls.Add(Button1)
        Controls.Add(Panel3)
        Controls.Add(btnEditLowStock)
        Controls.Add(Panel2)
        Controls.Add(dgvInventory)
        Controls.Add(Panel15)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "InventoryReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InventoryReport"
        Panel15.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnTransactionReport As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnProductInventory As Button
    Friend WithEvents btnOrderingApp As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button13 As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtLowStockLevel As TextBox
    Friend WithEvents btnEditLowStock As Button
    Friend WithEvents Button1 As Button
End Class
