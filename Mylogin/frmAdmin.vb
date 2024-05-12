Imports System.Data.OleDb
Public Class frmAdmin
    Public logIn As Date
    Public pos As String
    Public act As String
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        'Identifies if the UserId and Password entered by the user is within the database' 


        If txtPass.Text = Nothing Or txtPass.Text = Nothing Then
            MsgBox("Enter Credentials", MsgBoxStyle.Exclamation)
        Else
            connect()
            Dim cmd As New OleDbCommand("Select count(*) from tblAdmin where UserId=? and Password=?", conn)
            cmd.Parameters.AddWithValue("@1", OleDb.OleDbType.VarChar).Value = txtUser.Text
            cmd.Parameters.AddWithValue("@2", OleDb.OleDbType.VarChar).Value = txtPass.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                frmLogin.Hide()
                logIn = TimeOfDay.ToLongTimeString
                pos = "Administrator"
                act = "Logged into the CFE Administaration system"

                MsgBox("Login Succeed", MsgBoxStyle.Information)
                frmDashBoard.Show()
                Me.Hide()

            Else
                MsgBox("Account not found check credentials", MsgBoxStyle.Critical)
            End If
        End If


    End Sub

    Private Sub chkPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkPass.CheckedChanged
        If chkPass.Checked = True Then
            txtPass.PasswordChar = ""
        End If

        If chkPass.Checked = False Then
            txtPass.PasswordChar = "*"
        End If
    End Sub


End Class