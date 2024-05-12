<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderRec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderRec))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblOrderType = New System.Windows.Forms.Label()
        Me.Cashier = New System.Windows.Forms.Label()
        Me.Contact = New System.Windows.Forms.Label()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblCustom = New System.Windows.Forms.Label()
        Me.lblInvoice = New System.Windows.Forms.Label()
        Me.OrderQuan = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.txtCustom = New System.Windows.Forms.TextBox()
        Me.txtTotalAmt = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtOrderQuan = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.txtOrderType = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(213, 584)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(89, 43)
        Me.btnClear.TabIndex = 54
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(118, 584)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(89, 43)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(118, 535)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 43)
        Me.btnAdd.TabIndex = 52
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(213, 535)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 43)
        Me.btnUpdate.TabIndex = 51
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblOrderType
        '
        Me.lblOrderType.AutoSize = True
        Me.lblOrderType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderType.Location = New System.Drawing.Point(708, 578)
        Me.lblOrderType.Name = "lblOrderType"
        Me.lblOrderType.Size = New System.Drawing.Size(77, 18)
        Me.lblOrderType.TabIndex = 66
        Me.lblOrderType.Text = "Order Type:"
        '
        'Cashier
        '
        Me.Cashier.AutoSize = True
        Me.Cashier.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cashier.Location = New System.Drawing.Point(592, 578)
        Me.Cashier.Name = "Cashier"
        Me.Cashier.Size = New System.Drawing.Size(57, 18)
        Me.Cashier.TabIndex = 65
        Me.Cashier.Text = "Cashier:"
        '
        'Contact
        '
        Me.Contact.AutoSize = True
        Me.Contact.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.Location = New System.Drawing.Point(450, 578)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(58, 18)
        Me.Contact.TabIndex = 64
        Me.Contact.Text = "Contact:"
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderDate.Location = New System.Drawing.Point(704, 525)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(77, 18)
        Me.lblOrderDate.TabIndex = 63
        Me.lblOrderDate.Text = "Order Date:"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(578, 525)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(89, 18)
        Me.lblTotalAmt.TabIndex = 62
        Me.lblTotalAmt.Text = "Total Amount:"
        '
        'lblCustom
        '
        Me.lblCustom.AutoSize = True
        Me.lblCustom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustom.Location = New System.Drawing.Point(427, 526)
        Me.lblCustom.Name = "lblCustom"
        Me.lblCustom.Size = New System.Drawing.Size(106, 18)
        Me.lblCustom.TabIndex = 61
        Me.lblCustom.Text = "Customer Name:"
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice.Location = New System.Drawing.Point(339, 523)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(55, 18)
        Me.lblInvoice.TabIndex = 70
        Me.lblInvoice.Text = "Invoice:"
        '
        'OrderQuan
        '
        Me.OrderQuan.AutoSize = True
        Me.OrderQuan.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderQuan.Location = New System.Drawing.Point(317, 578)
        Me.OrderQuan.Name = "OrderQuan"
        Me.OrderQuan.Size = New System.Drawing.Size(100, 18)
        Me.OrderQuan.TabIndex = 69
        Me.OrderQuan.Text = "Order Quantity:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 523)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(817, 535)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(89, 43)
        Me.btnEdit.TabIndex = 72
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(817, 584)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 43)
        Me.btnReset.TabIndex = 73
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(107, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "RECORDS"
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle2.Location = New System.Drawing.Point(107, 3)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(61, 22)
        Me.lblTitle2.TabIndex = 80
        Me.lblTitle2.Text = "ORDER"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle1.Location = New System.Drawing.Point(1, -11)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(109, 65)
        Me.lblTitle1.TabIndex = 79
        Me.lblTitle1.Text = "CFE"
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(320, 547)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(89, 20)
        Me.txtInvoice.TabIndex = 82
        '
        'txtCustom
        '
        Me.txtCustom.Location = New System.Drawing.Point(434, 547)
        Me.txtCustom.Name = "txtCustom"
        Me.txtCustom.Size = New System.Drawing.Size(89, 20)
        Me.txtCustom.TabIndex = 83
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Location = New System.Drawing.Point(578, 547)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.Size = New System.Drawing.Size(89, 20)
        Me.txtTotalAmt.TabIndex = 84
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(696, 547)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(89, 20)
        Me.txtDate.TabIndex = 85
        '
        'txtOrderQuan
        '
        Me.txtOrderQuan.Location = New System.Drawing.Point(320, 607)
        Me.txtOrderQuan.Name = "txtOrderQuan"
        Me.txtOrderQuan.Size = New System.Drawing.Size(89, 20)
        Me.txtOrderQuan.TabIndex = 86
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(434, 607)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(89, 20)
        Me.txtContact.TabIndex = 87
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(578, 607)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(89, 20)
        Me.txtCashier.TabIndex = 88
        '
        'txtOrderType
        '
        Me.txtOrderType.Location = New System.Drawing.Point(696, 607)
        Me.txtOrderType.Name = "txtOrderType"
        Me.txtOrderType.Size = New System.Drawing.Size(89, 20)
        Me.txtOrderType.TabIndex = 89
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(24, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 465)
        Me.DataGridView1.TabIndex = 90
        '
        'frmOrderRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 639)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtOrderType)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtOrderQuan)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.txtCustom)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInvoice)
        Me.Controls.Add(Me.OrderQuan)
        Me.Controls.Add(Me.lblOrderType)
        Me.Controls.Add(Me.Cashier)
        Me.Controls.Add(Me.Contact)
        Me.Controls.Add(Me.lblOrderDate)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.lblCustom)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOrderRec"
        Me.Text = "frmOrderRec"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblOrderType As Label
    Friend WithEvents Cashier As Label
    Friend WithEvents Contact As Label
    Friend WithEvents lblOrderDate As Label
    Friend WithEvents lblTotalAmt As Label
    Friend WithEvents lblCustom As Label
    Friend WithEvents lblInvoice As Label
    Friend WithEvents OrderQuan As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtInvoice As TextBox
    Friend WithEvents txtCustom As TextBox
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtOrderQuan As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtCashier As TextBox
    Friend WithEvents txtOrderType As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
