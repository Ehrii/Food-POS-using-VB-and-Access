Imports System.Data.OleDb
Public Class frmLogin
    Public logIn As Date
    Public pos As String
    Public act As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
        txtPass.Text = ""
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim com As String
        Dim myreader As OleDbDataReader
        connect()
        'com = "Select*from Accounts where AccNum ='" & txtUser.Text & "'"
        If txtPass.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Enter Credentials", MsgBoxStyle.Exclamation)
        Else
            connect()
            Dim cmd As New OleDbCommand("Select count(*) from Accounts where AccNum=? and Password=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = txtUser.Text
            cmd.Parameters.AddWithValue("@2", OleDb.OleDbType.VarChar).Value = txtPass.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())


            If (count > 0) Then
                'Information used for the POS cashier name, and welcome form'
                logIn = TimeOfDay.ToLongTimeString
                pos = "Cashier"
                act = "Logged-In to the CFE POS System"
                MsgBox("Login Succeed", MsgBoxStyle.Information)

                com = "Select*from Accounts where AccNum=" + txtUser.Text + ""
                Dim cmd1 As New OleDbCommand(com, conn)
                myreader = cmd1.ExecuteReader()
                myreader.Read()
                frmPOS.lblCashName.Text = myreader("FirstName") & " " & myreader("MiddleName") & " " & myreader("LastName")
                frmWelcome.lblWelc.Text = "Hi," & myreader("FirstName") & " " & myreader("MiddleName") & " Welcome to CFC!"
                frmBackground.Show()


                With frmPOS
                    .TopLevel = False
                    frmBackground.pnlShow.Controls.Add(frmPOS)
                    .BringToFront()
                    .Show()
                End With
                With frmWelcome
                    .TopLevel = False
                    frmBackground.pnlShow.Controls.Add(frmWelcome)
                    .BringToFront()
                    .Show()
                End With
                Me.Hide()
            Else
                MsgBox("Account not found check credentials", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub lblCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreate.LinkClicked
        anima1.ShowSync(frmCreate)
    End Sub

    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click
        Me.Hide()

    End Sub

    Private Sub chkPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked = True Then
            txtPass.PasswordChar = ""
        End If

        If chkPass.Checked = False Then
            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        frmAdmin.Show()
    End Sub

End Class