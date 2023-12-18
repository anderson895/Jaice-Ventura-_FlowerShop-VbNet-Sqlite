<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaceOrderForm
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
        Me.components = New System.ComponentModel.Container()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.paymentTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.placeOrderButton = New System.Windows.Forms.Button()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.deliveryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.Label8)
        Me.mainPanel.Controls.Add(Me.paymentTextBox)
        Me.mainPanel.Controls.Add(Me.Label4)
        Me.mainPanel.Controls.Add(Me.placeOrderButton)
        Me.mainPanel.Controls.Add(Me.addressTextBox)
        Me.mainPanel.Controls.Add(Me.nameTextBox)
        Me.mainPanel.Controls.Add(Me.totalLabel)
        Me.mainPanel.Controls.Add(Me.Label3)
        Me.mainPanel.Controls.Add(Me.Label2)
        Me.mainPanel.Controls.Add(Me.deliveryDatePicker)
        Me.mainPanel.Controls.Add(Me.Label1)
        Me.mainPanel.Controls.Add(Me.nameLabel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(552, 388)
        Me.mainPanel.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(154, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 33)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Order Information"
        '
        'paymentTextBox
        '
        Me.paymentTextBox.Font = New System.Drawing.Font("Century", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentTextBox.Location = New System.Drawing.Point(431, 257)
        Me.paymentTextBox.Name = "paymentTextBox"
        Me.paymentTextBox.Size = New System.Drawing.Size(94, 28)
        Me.paymentTextBox.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 22)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Enter Your Payment:"
        '
        'placeOrderButton
        '
        Me.placeOrderButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.placeOrderButton.Font = New System.Drawing.Font("Century", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeOrderButton.Location = New System.Drawing.Point(44, 312)
        Me.placeOrderButton.Name = "placeOrderButton"
        Me.placeOrderButton.Size = New System.Drawing.Size(471, 46)
        Me.placeOrderButton.TabIndex = 27
        Me.placeOrderButton.Text = "PLACE ORDER"
        Me.placeOrderButton.UseVisualStyleBackColor = False
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Century", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(166, 132)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(359, 28)
        Me.addressTextBox.TabIndex = 26
        '
        'nameTextBox
        '
        Me.nameTextBox.Font = New System.Drawing.Font("Century", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTextBox.Location = New System.Drawing.Point(166, 89)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(188, 28)
        Me.nameTextBox.TabIndex = 25
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.ForeColor = System.Drawing.Color.Red
        Me.totalLabel.Location = New System.Drawing.Point(109, 263)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(21, 23)
        Me.totalLabel.TabIndex = 24
        Me.totalLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Delivery Date"
        '
        'deliveryDatePicker
        '
        Me.deliveryDatePicker.CalendarFont = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryDatePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryDatePicker.Location = New System.Drawing.Point(21, 222)
        Me.deliveryDatePicker.Name = "deliveryDatePicker"
        Me.deliveryDatePicker.Size = New System.Drawing.Size(251, 23)
        Me.deliveryDatePicker.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Your Address"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(17, 95)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(112, 22)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Your Name"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PlaceOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 388)
        Me.Controls.Add(Me.mainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "PlaceOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PlaceOrderForm"
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents nameLabel As Label
    Friend WithEvents deliveryDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents placeOrderButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents paymentTextBox As TextBox
    Friend WithEvents Label8 As Label
End Class
