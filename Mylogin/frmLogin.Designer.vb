<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.p1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.P3 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.p2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAdmin = New Guna.UI.WinForms.GunaButton()
        Me.lblCreate1 = New System.Windows.Forms.Label()
        Me.txtUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chkPass = New Guna.UI.WinForms.GunaCheckBox()
        Me.lblCreate = New Guna.UI.WinForms.GunaLinkLabel()
        Me.btnSignIn = New Guna.UI.WinForms.GunaButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnEx = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.p1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p2.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.Color.Transparent
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.l3)
        Me.p1.Controls.Add(Me.PictureBox3)
        Me.p1.Controls.Add(Me.PictureBox1)
        Me.p1.Controls.Add(Me.l1)
        Me.p1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.FillColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.p1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.p1.Location = New System.Drawing.Point(-4, 26)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(376, 513)
        Me.p1.TabIndex = 3
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.l2, Guna.UI.Animation.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(209, 210)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(152, 32)
        Me.l2.TabIndex = 2
        Me.l2.Text = "POS SYSTEM"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.l3, Guna.UI.Animation.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(213, 246)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(110, 20)
        Me.l3.TabIndex = 1
        Me.l3.Text = "Authentication"
        '
        'PictureBox3
        '
        Me.anima1.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(34, 119)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(171, 188)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.anima1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 244)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.l1, Guna.UI.Animation.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(193, 137)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(144, 86)
        Me.l1.TabIndex = 0
        Me.l1.Text = "CFE"
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        Me.anima1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation2
        '
        'P3
        '
        Me.P3.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.anima1.SetDecoration(Me.P3, Guna.UI.Animation.DecorationType.None)
        Me.P3.Location = New System.Drawing.Point(-17, 26)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(777, 17)
        Me.P3.TabIndex = 14
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.Label84, Guna.UI.Animation.DecorationType.None)
        Me.Label84.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.White
        Me.Label84.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label84.Location = New System.Drawing.Point(44, 2)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(212, 22)
        Me.Label84.TabIndex = 30
        Me.Label84.Text = "LOG-IN TO YOUR ACCOUNT"
        '
        'p2
        '
        Me.p2.Controls.Add(Me.btnAdmin)
        Me.p2.Controls.Add(Me.lblCreate1)
        Me.p2.Controls.Add(Me.txtUser)
        Me.p2.Controls.Add(Me.txtPass)
        Me.p2.Controls.Add(Me.chkPass)
        Me.p2.Controls.Add(Me.lblCreate)
        Me.p2.Controls.Add(Me.btnSignIn)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.p2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.p2.Location = New System.Drawing.Point(370, 39)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(673, 513)
        Me.p2.TabIndex = 32
        '
        'btnAdmin
        '
        Me.btnAdmin.Animated = True
        Me.btnAdmin.AnimationHoverSpeed = 0.07!
        Me.btnAdmin.AnimationSpeed = 0.03!
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnAdmin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnAdmin.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btnAdmin, Guna.UI.Animation.DecorationType.None)
        Me.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdmin.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Image = Nothing
        Me.btnAdmin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdmin.Location = New System.Drawing.Point(52, 292)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btnAdmin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAdmin.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnAdmin.OnHoverImage = Nothing
        Me.btnAdmin.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdmin.Size = New System.Drawing.Size(252, 42)
        Me.btnAdmin.TabIndex = 14
        Me.btnAdmin.Text = "Sign in as Administrator "
        Me.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCreate1
        '
        Me.lblCreate1.AutoSize = True
        Me.lblCreate1.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.lblCreate1, Guna.UI.Animation.DecorationType.None)
        Me.lblCreate1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCreate1.Location = New System.Drawing.Point(49, 358)
        Me.lblCreate1.Name = "lblCreate1"
        Me.lblCreate1.Size = New System.Drawing.Size(103, 17)
        Me.lblCreate1.TabIndex = 13
        Me.lblCreate1.Text = "No Account yet?"
        '
        'txtUser
        '
        Me.txtUser.AutoRoundedCorners = True
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderColor = System.Drawing.Color.Transparent
        Me.txtUser.BorderRadius = 15
        Me.txtUser.BorderThickness = 0
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.txtUser, Guna.UI.Animation.DecorationType.None)
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
        Me.txtUser.Location = New System.Drawing.Point(65, 69)
        Me.txtUser.MaxLength = 15
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtUser.PlaceholderText = "Account Number"
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(214, 32)
        Me.txtUser.TabIndex = 12
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
        Me.anima1.SetDecoration(Me.txtPass, Guna.UI.Animation.DecorationType.None)
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
        Me.txtPass.Location = New System.Drawing.Point(65, 122)
        Me.txtPass.MaxLength = 15
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.PlaceholderForeColor = System.Drawing.SystemColors.ControlDark
        Me.txtPass.PlaceholderText = "Password"
        Me.txtPass.SelectedText = ""
        Me.txtPass.Size = New System.Drawing.Size(214, 32)
        Me.txtPass.TabIndex = 11
        '
        'chkPass
        '
        Me.chkPass.BackColor = System.Drawing.Color.Transparent
        Me.chkPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.chkPass.CheckedOffColor = System.Drawing.Color.Transparent
        Me.chkPass.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.chkPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.anima1.SetDecoration(Me.chkPass, Guna.UI.Animation.DecorationType.None)
        Me.chkPass.FillColor = System.Drawing.Color.White
        Me.chkPass.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.chkPass.Location = New System.Drawing.Point(65, 176)
        Me.chkPass.Name = "chkPass"
        Me.chkPass.Size = New System.Drawing.Size(111, 20)
        Me.chkPass.TabIndex = 10
        Me.chkPass.Text = "Show Password"
        '
        'lblCreate
        '
        Me.lblCreate.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblCreate.AutoSize = True
        Me.lblCreate.BackColor = System.Drawing.Color.Transparent
        Me.anima1.SetDecoration(Me.lblCreate, Guna.UI.Animation.DecorationType.None)
        Me.lblCreate.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.lblCreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.LinkColor = System.Drawing.Color.Transparent
        Me.lblCreate.Location = New System.Drawing.Point(158, 358)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(96, 17)
        Me.lblCreate.TabIndex = 9
        Me.lblCreate.TabStop = True
        Me.lblCreate.Text = "Create Account"
        Me.lblCreate.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        '
        'btnSignIn
        '
        Me.btnSignIn.Animated = True
        Me.btnSignIn.AnimationHoverSpeed = 0.07!
        Me.btnSignIn.AnimationSpeed = 0.03!
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnSignIn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnSignIn.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.btnSignIn, Guna.UI.Animation.DecorationType.None)
        Me.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSignIn.FocusedColor = System.Drawing.Color.Empty
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Image = Nothing
        Me.btnSignIn.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSignIn.Location = New System.Drawing.Point(52, 231)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSignIn.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnSignIn.OnHoverImage = Nothing
        Me.btnSignIn.OnPressedColor = System.Drawing.Color.Black
        Me.btnSignIn.Size = New System.Drawing.Size(252, 42)
        Me.btnSignIn.TabIndex = 8
        Me.btnSignIn.Text = "Log In"
        Me.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Transparent
        Me.Panel12.Controls.Add(Me.btnEx)
        Me.anima1.SetDecoration(Me.Panel12, Guna.UI.Animation.DecorationType.None)
        Me.Panel12.Location = New System.Drawing.Point(665, -1)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(102, 23)
        Me.Panel12.TabIndex = 34
        '
        'btnEx
        '
        Me.anima1.SetDecoration(Me.btnEx, Guna.UI.Animation.DecorationType.None)
        Me.btnEx.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEx.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEx.FillColor = System.Drawing.Color.Transparent
        Me.btnEx.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnEx.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEx.ForeColor = System.Drawing.Color.White
        Me.btnEx.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.btnEx.Image = CType(resources.GetObject("btnEx.Image"), System.Drawing.Image)
        Me.btnEx.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btnEx.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnEx.Location = New System.Drawing.Point(60, 4)
        Me.btnEx.Name = "btnEx"
        Me.btnEx.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnEx.Size = New System.Drawing.Size(20, 20)
        Me.btnEx.TabIndex = 30
        Me.btnEx.Text = "Guna2GradientCircleButton1"
        '
        'PictureBox2
        '
        Me.anima1.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 15
        Me.Guna2Elipse1.TargetControl = Me
        '
        'frmLogin
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 505)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.p1)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents p1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents P3 As Panel
    Friend WithEvents p2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents chkPass As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents lblCreate As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents btnSignIn As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnEx As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents lblCreate1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnAdmin As Guna.UI.WinForms.GunaButton
End Class
