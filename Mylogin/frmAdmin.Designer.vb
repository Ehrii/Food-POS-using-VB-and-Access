<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkPass = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnSignIn = New Guna.UI.WinForms.GunaButton()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 36)
        Me.Panel1.TabIndex = 0
        '
        'chkPass
        '
        Me.chkPass.BackColor = System.Drawing.Color.Transparent
        Me.chkPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.chkPass.CheckedOffColor = System.Drawing.Color.Transparent
        Me.chkPass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPass.FillColor = System.Drawing.Color.White
        Me.chkPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.chkPass.Location = New System.Drawing.Point(245, 186)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(111, 20)
        Me.chkPass.TabIndex = 14
        Me.chkPass.Text = "Show Password"
        '
        'btnSignIn
        '
        Me.btnSignIn.Animated = True
        Me.btnSignIn.AnimationHoverSpeed = 0.07!
        Me.btnSignIn.AnimationSpeed = 0.03!
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnSignIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnSignIn.BorderColor = System.Drawing.Color.Black
        Me.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSignIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Image = Nothing
        Me.btnSignIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSignIn.Location = New System.Drawing.Point(245, 236)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSignIn.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnSignIn.OnHoverImage = Nothing
        Me.btnSignIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnSignIn.Size = New System.Drawing.Size(252, 42)
        Me.btnSignIn.TabIndex = 13
        Me.btnSignIn.Text = "Log In"
        Me.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.AutoRoundedCorners = True
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderRadius = 15
        Me.txtUser.BorderThickness = 0
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.DefaultText = ""
        Me.txtUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.IconLeft = CType(resources.GetObject("txtUser.IconLeft"), System.Drawing.Image)
        Me.txtUser.Location = New System.Drawing.Point(245, 68)
        Me.txtUser.MaxLength = 15
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtUser.PlaceholderText = "User ID"
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(214, 32)
        Me.txtUser.TabIndex = 16
        '
        'txtPass
        '
        Me.txtPass.AcceptsTab = True
        Me.txtPass.AutoRoundedCorners = True
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BorderColor = System.Drawing.Color.Gray
        Me.txtPass.BorderRadius = 15
        Me.txtPass.BorderThickness = 0
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.DefaultText = ""
        Me.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.IconLeft = CType(resources.GetObject("txtPass.IconLeft"), System.Drawing.Image)
        Me.txtPass.Location = New System.Drawing.Point(245, 126)
        Me.txtPass.MaxLength = 15
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtPass.PlaceholderText = "Password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(214, 32)
        Me.txtPass.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(549, 346)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.chkPass)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRATOR ONLY"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnSignIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
