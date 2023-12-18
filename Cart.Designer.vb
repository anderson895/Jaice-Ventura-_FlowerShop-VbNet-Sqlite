<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cart))
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.dataPanel = New System.Windows.Forms.Panel()
        Me.ordersSummaryButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.placeOrderButton = New System.Windows.Forms.Button()
        Me.removeAllButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cartTable = New System.Windows.Forms.DataGridView()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.addEmailButton = New System.Windows.Forms.Button()
        Me.titlePanel.SuspendLayout()
        Me.dataPanel.SuspendLayout()
        CType(Me.cartTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'topPanel
        '
        Me.topPanel.BackColor = System.Drawing.Color.DimGray
        Me.topPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.topPanel.Location = New System.Drawing.Point(0, 0)
        Me.topPanel.Name = "topPanel"
        Me.topPanel.Size = New System.Drawing.Size(1333, 43)
        Me.topPanel.TabIndex = 0
        '
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.Color.DimGray
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 1013)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(1333, 27)
        Me.bottomPanel.TabIndex = 1
        '
        'titlePanel
        '
        Me.titlePanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.titlePanel.Controls.Add(Me.addEmailButton)
        Me.titlePanel.Controls.Add(Me.backButton)
        Me.titlePanel.Controls.Add(Me.Label3)
        Me.titlePanel.Controls.Add(Me.Label1)
        Me.titlePanel.Controls.Add(Me.logoPanel)
        Me.titlePanel.Location = New System.Drawing.Point(0, 49)
        Me.titlePanel.Name = "titlePanel"
        Me.titlePanel.Size = New System.Drawing.Size(1330, 201)
        Me.titlePanel.TabIndex = 2
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BackgroundImage = CType(resources.GetObject("backButton.BackgroundImage"), System.Drawing.Image)
        Me.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backButton.ForeColor = System.Drawing.SystemColors.Control
        Me.backButton.Location = New System.Drawing.Point(37, 5)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(37, 38)
        Me.backButton.TabIndex = 8
        Me.backButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Script MT Bold", 24.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(614, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(325, 39)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Flower, Gifts and More"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 81)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enchanted Bloom"
        '
        'logoPanel
        '
        Me.logoPanel.BackgroundImage = Global.FlowerShop.My.Resources.Resources.logo
        Me.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoPanel.Location = New System.Drawing.Point(170, 15)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(190, 167)
        Me.logoPanel.TabIndex = 0
        '
        'dataPanel
        '
        Me.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dataPanel.Controls.Add(Me.ordersSummaryButton)
        Me.dataPanel.Controls.Add(Me.deleteButton)
        Me.dataPanel.Controls.Add(Me.totalLabel)
        Me.dataPanel.Controls.Add(Me.Label2)
        Me.dataPanel.Controls.Add(Me.placeOrderButton)
        Me.dataPanel.Controls.Add(Me.removeAllButton)
        Me.dataPanel.Controls.Add(Me.Label8)
        Me.dataPanel.Controls.Add(Me.cartTable)
        Me.dataPanel.Location = New System.Drawing.Point(0, 256)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(1330, 757)
        Me.dataPanel.TabIndex = 3
        '
        'ordersSummaryButton
        '
        Me.ordersSummaryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ordersSummaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ordersSummaryButton.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordersSummaryButton.Location = New System.Drawing.Point(1066, 697)
        Me.ordersSummaryButton.Name = "ordersSummaryButton"
        Me.ordersSummaryButton.Size = New System.Drawing.Size(229, 46)
        Me.ordersSummaryButton.TabIndex = 25
        Me.ordersSummaryButton.Text = "ORDERS SUMMARY"
        Me.ordersSummaryButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(1066, 609)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(170, 37)
        Me.deleteButton.TabIndex = 24
        Me.deleteButton.Text = "DELETE ITEM"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.ForeColor = System.Drawing.Color.Red
        Me.totalLabel.Location = New System.Drawing.Point(233, 617)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(21, 23)
        Me.totalLabel.TabIndex = 23
        Me.totalLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 615)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 42)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Subtotal:"
        '
        'placeOrderButton
        '
        Me.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.placeOrderButton.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeOrderButton.Location = New System.Drawing.Point(452, 614)
        Me.placeOrderButton.Name = "placeOrderButton"
        Me.placeOrderButton.Size = New System.Drawing.Size(471, 46)
        Me.placeOrderButton.TabIndex = 21
        Me.placeOrderButton.Text = "PLACE ORDER"
        Me.placeOrderButton.UseVisualStyleBackColor = False
        '
        'removeAllButton
        '
        Me.removeAllButton.BackColor = System.Drawing.Color.Transparent
        Me.removeAllButton.BackgroundImage = CType(resources.GetObject("removeAllButton.BackgroundImage"), System.Drawing.Image)
        Me.removeAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.removeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeAllButton.ForeColor = System.Drawing.SystemColors.Control
        Me.removeAllButton.Location = New System.Drawing.Point(1276, 609)
        Me.removeAllButton.Name = "removeAllButton"
        Me.removeAllButton.Size = New System.Drawing.Size(29, 31)
        Me.removeAllButton.TabIndex = 9
        Me.removeAllButton.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(558, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(270, 33)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Shopping Cart Table"
        '
        'cartTable
        '
        Me.cartTable.AllowUserToAddRows = False
        Me.cartTable.AllowUserToDeleteRows = False
        Me.cartTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cartTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.cartTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cartTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cartTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.cartTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cartTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.cartTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cartTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.cartTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.cartTable.Location = New System.Drawing.Point(51, 66)
        Me.cartTable.MultiSelect = False
        Me.cartTable.Name = "cartTable"
        Me.cartTable.ReadOnly = True
        Me.cartTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cartTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.cartTable.Size = New System.Drawing.Size(1280, 520)
        Me.cartTable.TabIndex = 0
        '
        'mainPanel
        '
        Me.mainPanel.AutoScroll = True
        Me.mainPanel.Controls.Add(Me.dataPanel)
        Me.mainPanel.Controls.Add(Me.titlePanel)
        Me.mainPanel.Controls.Add(Me.bottomPanel)
        Me.mainPanel.Controls.Add(Me.topPanel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1350, 729)
        Me.mainPanel.TabIndex = 1
        '
        'addEmailButton
        '
        Me.addEmailButton.BackColor = System.Drawing.Color.Transparent
        Me.addEmailButton.BackgroundImage = CType(resources.GetObject("addEmailButton.BackgroundImage"), System.Drawing.Image)
        Me.addEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEmailButton.ForeColor = System.Drawing.SystemColors.Control
        Me.addEmailButton.Location = New System.Drawing.Point(1260, 9)
        Me.addEmailButton.Name = "addEmailButton"
        Me.addEmailButton.Size = New System.Drawing.Size(37, 38)
        Me.addEmailButton.TabIndex = 9
        Me.addEmailButton.UseVisualStyleBackColor = False
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        Me.dataPanel.ResumeLayout(False)
        Me.dataPanel.PerformLayout()
        CType(Me.cartTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents topPanel As Panel
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents titlePanel As Panel
    Friend WithEvents backButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logoPanel As Panel
    Friend WithEvents dataPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents cartTable As DataGridView
    Friend WithEvents mainPanel As Panel
    Friend WithEvents removeAllButton As Button
    Friend WithEvents placeOrderButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents ordersSummaryButton As Button
    Friend WithEvents addEmailButton As Button
End Class
