Imports System.Data.OleDb

Public Class frmPass
    Dim pass As String
    Dim accNum As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        txtConfirm.Clear()
        txtNew.Clear()
        txtOld.Clear()
    End Sub
    Private Sub frmPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accNum = frmLogin.txtUser.Text
        pass = frmLogin.txtPass.Text
        populateAcc()
    End Sub

    Private Sub btnConfirmPass_Click(sender As Object, e As EventArgs) Handles btnConfirmPass.Click
        Dim com, oldPass As String
        Dim myreader As OleDbDataReader
        Dim dset As New DataSet

        com = "Select*from Accounts where AccNum=" + frmLogin.txtUser.Text + ""
        Dim cmd1 As New OleDbCommand(com, conn)
        myreader = cmd1.ExecuteReader
        myreader.Read()
        oldPass = myreader("Password")


        If (txtOld.Text = "" And txtNew.Text = "" And txtConfirm.Text = "") Then
            MessageBox.Show("All information are required")

        ElseIf (txtOld.Text <> oldPass) Then
            MessageBox.Show("Invalid Old password!")

        ElseIf (txtNew.Text <> txtConfirm.Text) Then
            MessageBox.Show("New password and confirmation password didn't matched")
        Else
            connect()
            Dim cmd As New OleDbCommand("UPDATE Accounts SET [Password] = @Pwd where AccNum like @AccNum", conn)

            With cmd.Parameters
                cmd.Parameters.AddWithValue("@Pwd", txtConfirm.Text)
                cmd.Parameters.AddWithValue("@AccNum", accNum)
            End With
            cmd.ExecuteNonQuery()
            populateAcc()
            MessageBox.Show("Password Changed", "Account Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        txtConfirm.Clear()
        txtNew.Clear()
        txtOld.Clear()

    End Sub
End Class