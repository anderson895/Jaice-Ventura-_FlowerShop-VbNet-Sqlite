<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersSummaryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersSummaryForm))
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.dataPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ordersSummaryTable = New System.Windows.Forms.DataGridView()
        Me.titlePanel = New System.Windows.Forms.Panel()
        Me.backButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.bottomPanel = New System.Windows.Forms.Panel()
        Me.topPanel = New System.Windows.Forms.Panel()
        Me.removeAllButton = New System.Windows.Forms.Button()
        Me.mainPanel.SuspendLayout()
        Me.dataPanel.SuspendLayout()
        CType(Me.ordersSummaryTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.titlePanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.mainPanel.TabIndex = 2
        '
        'dataPanel
        '
        Me.dataPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dataPanel.Controls.Add(Me.removeAllButton)
        Me.dataPanel.Controls.Add(Me.Label8)
        Me.dataPanel.Controls.Add(Me.ordersSummaryTable)
        Me.dataPanel.Location = New System.Drawing.Point(-9, 256)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(1330, 664)
        Me.dataPanel.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(552, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(309, 33)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Orders Summary Table"
        '
        'ordersSummaryTable
        '
        Me.ordersSummaryTable.AllowUserToAddRows = False
        Me.ordersSummaryTable.AllowUserToDeleteRows = False
        Me.ordersSummaryTable.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ordersSummaryTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ordersSummaryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ordersSummaryTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ordersSummaryTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ordersSummaryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ordersSummaryTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ordersSummaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ordersSummaryTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.ordersSummaryTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ordersSummaryTable.Location = New System.Drawing.Point(51, 66)
        Me.ordersSummaryTable.MultiSelect = False
        Me.ordersSummaryTable.Name = "ordersSummaryTable"
        Me.ordersSummaryTable.ReadOnly = True
        Me.ordersSummaryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ordersSummaryTable.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ordersSummaryTable.Size = New System.Drawing.Size(1280, 520)
        Me.ordersSummaryTable.TabIndex = 0
        '
        'titlePanel
        '
        Me.titlePanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.titlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.titlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.titlePanel.Controls.Add(Me.backButton)
        Me.titlePanel.Controls.Add(Me.Label3)
        Me.titlePanel.Controls.Add(Me.Label1)
        Me.titlePanel.Controls.Add(Me.logoPanel)
        Me.titlePanel.Location = New System.Drawing.Point(-9, 49)
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
        'bottomPanel
        '
        Me.bottomPanel.BackColor = System.Drawing.Color.DimGray
        Me.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottomPanel.Location = New System.Drawing.Point(0, 920)
        Me.bottomPanel.Name = "bottomPanel"
        Me.bottomPanel.Size = New System.Drawing.Size(1333, 29)
        Me.bottomPanel.TabIndex = 1
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
        'removeAllButton
        '
        Me.removeAllButton.BackColor = System.Drawing.Color.Transparent
        Me.removeAllButton.BackgroundImage = CType(resources.GetObject("removeAllButton.BackgroundImage"), System.Drawing.Image)
        Me.removeAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.removeAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeAllButton.ForeColor = System.Drawing.SystemColors.Control
        Me.removeAllButton.Location = New System.Drawing.Point(1251, 612)
        Me.removeAllButton.Name = "removeAllButton"
        Me.removeAllButton.Size = New System.Drawing.Size(29, 31)
        Me.removeAllButton.TabIndex = 10
        Me.removeAllButton.UseVisualStyleBackColor = False
        '
        'OrdersSummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "OrdersSummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersSummaryForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainPanel.ResumeLayout(False)
        Me.dataPanel.ResumeLayout(False)
        CType(Me.ordersSummaryTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.titlePanel.ResumeLayout(False)
        Me.titlePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents dataPanel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents ordersSummaryTable As DataGridView
    Friend WithEvents titlePanel As Panel
    Friend WithEvents backButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents logoPanel As Panel
    Friend WithEvents bottomPanel As Panel
    Friend WithEvents topPanel As Panel
    Friend WithEvents removeAllButton As Button
End Class
