<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManage))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtAcc = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtOccu = New System.Windows.Forms.TextBox()
        Me.txtReli = New System.Windows.Forms.TextBox()
        Me.txtEdu = New System.Windows.Forms.TextBox()
        Me.lblAccNum = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblEdu = New System.Windows.Forms.Label()
        Me.lblReli = New System.Windows.Forms.Label()
        Me.lblOccu = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblTitle1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(148, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(136, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(839, 404)
        Me.DataGridView1.TabIndex = 1
        '
        'txtAcc
        '
        Me.txtAcc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcc.Location = New System.Drawing.Point(15, 453)
        Me.txtAcc.Name = "txtAcc"
        Me.txtAcc.Size = New System.Drawing.Size(100, 23)
        Me.txtAcc.TabIndex = 2
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(150, 453)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 23)
        Me.txtFName.TabIndex = 3
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(285, 453)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(100, 23)
        Me.txtMName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(673, 453)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 23)
        Me.txtEmail.TabIndex = 7
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(538, 453)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(100, 23)
        Me.txtAdd.TabIndex = 6
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(411, 453)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(100, 23)
        Me.txtLName.TabIndex = 5
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(538, 508)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 23)
        Me.txtPassword.TabIndex = 12
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(411, 508)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 23)
        Me.txtPhone.TabIndex = 11
        '
        'txtOccu
        '
        Me.txtOccu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccu.Location = New System.Drawing.Point(285, 508)
        Me.txtOccu.Name = "txtOccu"
        Me.txtOccu.Size = New System.Drawing.Size(100, 23)
        Me.txtOccu.TabIndex = 10
        '
        'txtReli
        '
        Me.txtReli.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReli.Location = New System.Drawing.Point(150, 508)
        Me.txtReli.Name = "txtReli"
        Me.txtReli.Size = New System.Drawing.Size(100, 23)
        Me.txtReli.TabIndex = 9
        '
        'txtEdu
        '
        Me.txtEdu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdu.Location = New System.Drawing.Point(15, 508)
        Me.txtEdu.Name = "txtEdu"
        Me.txtEdu.Size = New System.Drawing.Size(100, 23)
        Me.txtEdu.TabIndex = 8
        '
        'lblAccNum
        '
        Me.lblAccNum.AutoSize = True
        Me.lblAccNum.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccNum.Location = New System.Drawing.Point(12, 432)
        Me.lblAccNum.Name = "lblAccNum"
        Me.lblAccNum.Size = New System.Drawing.Size(108, 18)
        Me.lblAccNum.TabIndex = 15
        Me.lblAccNum.Text = "Account Number:"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(162, 432)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(77, 18)
        Me.lblFName.TabIndex = 16
        Me.lblFName.Text = "First Name:"
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMName.Location = New System.Drawing.Point(297, 432)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(83, 18)
        Me.lblMName.TabIndex = 17
        Me.lblMName.Text = "Middle Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(699, 432)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 18)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "Email:"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLName.Location = New System.Drawing.Point(421, 432)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(75, 18)
        Me.lblLName.TabIndex = 18
        Me.lblLName.Text = "Last Name:"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(557, 432)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(59, 18)
        Me.lblAdd.TabIndex = 19
        Me.lblAdd.Text = "Address:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(841, 432)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(55, 18)
        Me.lblGender.TabIndex = 20
        Me.lblGender.Text = "Gender:"
        '
        'lblEdu
        '
        Me.lblEdu.AutoSize = True
        Me.lblEdu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdu.Location = New System.Drawing.Point(27, 487)
        Me.lblEdu.Name = "lblEdu"
        Me.lblEdu.Size = New System.Drawing.Size(70, 18)
        Me.lblEdu.TabIndex = 21
        Me.lblEdu.Text = "Education:"
        '
        'lblReli
        '
        Me.lblReli.AutoSize = True
        Me.lblReli.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReli.Location = New System.Drawing.Point(171, 487)
        Me.lblReli.Name = "lblReli"
        Me.lblReli.Size = New System.Drawing.Size(59, 18)
        Me.lblReli.TabIndex = 22
        Me.lblReli.Text = "Religion:"
        '
        'lblOccu
        '
        Me.lblOccu.AutoSize = True
        Me.lblOccu.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccu.Location = New System.Drawing.Point(302, 487)
        Me.lblOccu.Name = "lblOccu"
        Me.lblOccu.Size = New System.Drawing.Size(78, 18)
        Me.lblOccu.TabIndex = 23
        Me.lblOccu.Text = "Occupation:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(433, 489)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(47, 18)
        Me.lblPhone.TabIndex = 24
        Me.lblPhone.Text = "Phone:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(557, 487)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(66, 18)
        Me.lblPass.TabIndex = 25
        Me.lblPass.Text = "Password:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(679, 486)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(88, 18)
        Me.lblDOB.TabIndex = 26
        Me.lblDOB.Text = "Date of Birth:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(12, 109)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(102, 50)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 43)
        Me.btnAdd.TabIndex = 35
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(12, 60)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 43)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtBirth
        '
        Me.txtBirth.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirth.Location = New System.Drawing.Point(673, 508)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.Size = New System.Drawing.Size(100, 23)
        Me.txtBirth.TabIndex = 48
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(817, 453)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 23)
        Me.txtGender.TabIndex = 49
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 165)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 50)
        Me.btnClear.TabIndex = 50
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(12, 324)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(102, 43)
        Me.btnEdit.TabIndex = 51
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(13, 373)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(102, 43)
        Me.btnReset.TabIndex = 52
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle2.Location = New System.Drawing.Point(813, 489)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(75, 22)
        Me.lblTitle2.TabIndex = 77
        Me.lblTitle2.Text = "MANAGE"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle1.Location = New System.Drawing.Point(879, 473)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(109, 65)
        Me.lblTitle1.TabIndex = 76
        Me.lblTitle1.Text = "CFE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(813, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "RECORDS"
        '
        'frmManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1000, 549)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtBirth)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblOccu)
        Me.Controls.Add(Me.lblReli)
        Me.Controls.Add(Me.lblEdu)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblMName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblAccNum)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtOccu)
        Me.Controls.Add(Me.txtReli)
        Me.Controls.Add(Me.txtEdu)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtAcc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmManage"
        Me.Text = "frmManage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtAcc As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtOccu As TextBox
    Friend WithEvents txtReli As TextBox
    Friend WithEvents txtEdu As TextBox
    Friend WithEvents lblAccNum As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents lblMName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblEdu As Label
    Friend WithEvents lblReli As Label
    Friend WithEvents lblOccu As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lblTitle1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
End Class
