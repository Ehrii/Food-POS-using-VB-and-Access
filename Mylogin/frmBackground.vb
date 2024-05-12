Imports System.Data.OleDb
Public Class frmBackground
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = TimeString & "                 " & DateString
    End Sub
    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click
        Me.Hide()
    End Sub
    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click

        'Retrieves user data from the database , and displays it on the Account Details form' 
        Dim com As String
        Dim myreader As OleDbDataReader
        Dim dset As New DataSet
        connect()

        com = "Select*from Accounts where AccNum=" + frmLogin.txtUser.Text + ""
        Dim cmd1 As New OleDbCommand(com, conn)
        myreader = cmd1.ExecuteReader
        myreader.Read()
        frmAcc.lblFName.Text = myreader("FirstName")
        frmAcc.lblMName.Text = myreader("MiddleName")
        frmAcc.lblLName.Text = myreader("LastName")
        frmAcc.lblAdd.Text = myreader("Address")
        frmAcc.lblPhone.Text = myreader("Phone")
        frmAcc.lblGender.Text = myreader("Gender")
        frmAcc.lblEdu.Text = myreader("Education")
        frmAcc.lblReli.Text = myreader("Religion")
        frmAcc.lblOccu.Text = myreader("Occupation")
        frmAcc.lblDOB.Text = myreader("DateofBirth")
        frmAcc.lblAcc.Text = myreader("AccNum")
        frmAcc.lblEmail.Text = myreader("Email")
        frmAcc.lblPass.Text = myreader("Password")
        frmAcc.Show()
    End Sub
End Class