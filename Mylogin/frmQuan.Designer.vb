<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQuan
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
        Me.borderlessForm = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.lblQuan = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New Guna.UI2.WinForms.Guna2Button()
        Me.txtQuan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'borderlessForm
        '
        Me.borderlessForm.ContainerControl = Me
        Me.borderlessForm.DockIndicatorTransparencyValue = 0.6R
        Me.borderlessForm.TransparentWhileDrag = True
        '
        'lblQuan
        '
        Me.lblQuan.AutoSize = True
        Me.lblQuan.Font = New System.Drawing.Font("Trebuchet MS", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuan.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblQuan.Location = New System.Drawing.Point(12, 35)
        Me.lblQuan.Name = "lblQuan"
        Me.lblQuan.Size = New System.Drawing.Size(276, 43)
        Me.lblQuan.TabIndex = 1
        Me.lblQuan.Text = "Enter Quantity:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-5, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 23)
        Me.Panel1.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.AutoRoundedCorners = True
        Me.btnOk.BorderRadius = 15
        Me.btnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOk.FillColor = System.Drawing.Color.Transparent
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(157, 103)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(150, 32)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        '
        'txtQuan
        '
        Me.txtQuan.AutoRoundedCorners = True
        Me.txtQuan.BorderRadius = 20
        Me.txtQuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuan.DefaultText = ""
        Me.txtQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQuan.FillColor = System.Drawing.Color.LightSkyBlue
        Me.txtQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuan.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuan.ForeColor = System.Drawing.Color.Navy
        Me.txtQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQuan.Location = New System.Drawing.Point(298, 35)
        Me.txtQuan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuan.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtQuan.PlaceholderText = ""
        Me.txtQuan.SelectedText = ""
        Me.txtQuan.Size = New System.Drawing.Size(142, 43)
        Me.txtQuan.TabIndex = 6
        Me.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmQuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 147)
        Me.Controls.Add(Me.txtQuan)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblQuan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents borderlessForm As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblQuan As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnOk As Guna.UI2.WinForms.Guna2Button
    Public WithEvents txtQuan As Guna.UI2.WinForms.Guna2TextBox
End Class
