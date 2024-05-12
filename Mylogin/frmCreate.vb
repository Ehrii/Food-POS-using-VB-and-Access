Imports System.Data.OleDb
Public Class frmCreate
    Dim accNum As Integer = 1000 'Starting number'
    Dim com As String
    Dim myreader As OleDbDataReader
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateAcc()
        connect()

        If frmManage.DataGridView1.Rows.Count > 1 Then
            com = "Select AccNum from Accounts where AccNum =(select max (AccNum) from Accounts)"
            Dim cmd1 As New OleDbCommand(com, conn)
            myreader = cmd1.ExecuteReader
            myreader.Read()
            accNum += 1
            accNum = myreader("AccNum")
            'Gets the maximum AccNumber to increment whenever a user created an account'
        End If
    End Sub


    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim newStr, msg As String
        If txtConfirmPass.Text <> txtPass.Text Then
            MessageBox.Show("Passwords Do not match!", "Password Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        If (txtFirstName.Text = Nothing Or txtMiddleName.Text = Nothing Or txtLastName.Text = Nothing Or
            txtAdd.Text = Nothing Or txtEmail.Text = Nothing Or cmbGender.Text = Nothing Or
            txtEdu.Text = Nothing Or txtReli.Text = Nothing Or txtOccu.Text = Nothing Or txtPhone.Text = Nothing Or txtPass.Text = Nothing Or
            txtConfirmPass.Text = Nothing) Then
            MsgBox("Enter Credentials", MsgBoxStyle.Exclamation)
            If txtFirstName.Text = "" Then
                msg = msg + " First Name,"
            End If

            If txtMiddleName.Text = "" Then
                msg = msg + " Middle Name,"
            End If

            If txtLastName.Text = "" Then
                msg = msg & " Last Name,"
            End If
            If txtAdd.Text = "" Then
                msg = msg & " Address,"
            End If
            If txtEmail.Text = "" Then
                msg = msg & " Email,"
            End If
            If cmbGender.Text = "" Then
                msg = msg & " Gender,"
            End If
            If txtEdu.Text = "" Then
                msg = msg & " Education,"
            End If
            If txtReli.Text = "" Then
                msg = msg & " Religion,"
            End If
            If txtOccu.Text = "" Then
                msg = msg & " Occupation,"
            End If
            If txtPhone.Text = "" Then
                msg = msg & " Phone,"
            End If
            If txtPass.Text = "" Then
                msg = msg & " Password,"
            End If
            If txtConfirmPass.Text = "" Then
                msg = msg & " Confirm Password field,"
            End If

            newStr = msg.TrimEnd(",")
            MessageBox.Show("Please Enter your : " & newStr & ".", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            Dim gender As String = cmbGender.Text
            Dim dateofBirth As String = dtpDOB.Value.ToShortDateString
            accNum += 1
            'Gets the account number in the last row, and increments it"

            Dim comm As OleDbCommand
            Call connect()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "Insert into Accounts values ('" & accNum & "','" & txtFirstName.Text & "','" & txtMiddleName.Text & "','" & txtLastName.Text & "','" & txtAdd.Text & "','" & txtEmail.Text & "','" & gender & "','" & txtEdu.Text & "','" & txtReli.Text & "','" & txtOccu.Text & "' ,'" & txtPhone.Text & "','" & txtPass.Text & "','" & dateofBirth & "')"
            comm.ExecuteNonQuery()
            Call populateAcc()
            MessageBox.Show("Account Created", "CFE Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Your Account Number is:" & accNum, "CFE Account Creation Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAdd.Clear()
            txtConfirmPass.Clear()
            txtEdu.Clear()
            txtEmail.Clear()
            txtFirstName.Clear()
            txtLastName.Clear()
            txtMiddleName.Clear()
            txtOccu.Clear()
            txtPass.Clear()
            txtPhone.Clear()
            txtReli.Clear()
        End If
    End Sub


End Class