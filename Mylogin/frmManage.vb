Imports System.Data.OleDb
Public Class frmManage

    Private Sub frmManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateAcc()
        DisabledControl()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnClear.Enabled = False

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtAcc.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtFName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtMName.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtLName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtAdd.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtEmail.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtGender.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtEdu.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        txtReli.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        txtOccu.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        txtPhone.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        txtPassword.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        txtBirth.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connstring As String
        Dim command As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        connstring = connStr
        myConnection.ConnectionString = connstring
        myConnection.Open()
        Dim AccNum As Integer = Val(txtAcc.Text)


        command = "Insert into [Accounts] values('" & AccNum & "','" & txtFName.Text & "','" & txtMName.Text & "','" & txtLName.Text & "','" & txtAdd.Text & "','" & txtEmail.Text & "','" & txtGender.Text & "','" & txtEdu.Text & "','" & txtReli.Text & "','" & txtOccu.Text & "' ,'" & txtPhone.Text & "','" & txtPassword.Text & "','" & txtBirth.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        cmd.Parameters.Add(New OleDbParameter("AccNum", CType(txtAcc.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MiddName", CType(txtMName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtLName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtAdd.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Email", CType(txtEmail.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(txtGender.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Education", CType(txtEdu.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Religion", CType(txtReli.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Occupation", CType(txtOccu.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Phone", CType(txtPhone.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtPassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DateofBirth", CType(txtBirth.Text, String)))
        MsgBox("Insertion of records successful")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            populateAcc()
            clearRecords()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim connstring As String
        Dim command As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        connstring = connStr
        myConnection.ConnectionString = connstring
        myConnection.Open()
        MsgBox("Deletion of records successful")

        Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM [Accounts] WHERE [AccNum] =@AccNum", myConnection)
        cmd.Parameters.Add(New OleDbParameter("@AccNum", CType(txtAcc.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            populateAcc()
            clearRecords()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim pro As String
        Dim connstring As String
        Dim command As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        connstring = connStr
        myConnection.ConnectionString = connstring
        myConnection.Open()
        Dim AccNum As Integer = Val(txtAcc.Text)
        MsgBox("Updating of records successful")
        command = "Update Accounts set [FirstName]='" & txtFName.Text & "',[MiddleName]='" & txtMName.Text & "',[LastName]='" & txtLName.Text & "',
        [Address]='" & txtAdd.Text & "',[Email]='" & txtEmail.Text & "',[Gender]='" & txtGender.Text & "',[Education]='" & txtEdu.Text & "',[Religion]='" & txtReli.Text & "',[Occupation]='" & txtOccu.Text & "' ,[Phone]='" & txtPhone.Text & "',
        [Password]='" & txtPassword.Text & "',[DateofBirth]='" & txtBirth.Text & "' WHERE [AccNum]=" & txtAcc.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            clearRecords()
            populateAcc()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub


    Private Sub clearRecords()
        txtAcc.Clear()
        txtFName.Clear()
        txtMName.Clear()
        txtLName.Clear()
        txtAdd.Clear()
        txtEmail.Clear()
        txtGender.Clear()
        txtEdu.Clear()
        txtReli.Clear()
        txtOccu.Clear()
        txtPhone.Clear()
        txtPassword.Clear()
        txtBirth.Clear()
    End Sub


    Private Sub DisabledControl()
        txtAcc.Enabled = False
        txtFName.Enabled = False
        txtMName.Enabled = False
        txtLName.Enabled = False
        txtAdd.Enabled = False
        txtEmail.Enabled = False
        txtGender.Enabled = False
        txtEdu.Enabled = False
        txtReli.Enabled = False
        txtOccu.Enabled = False
        txtPhone.Enabled = False
        txtPassword.Enabled = False
        txtBirth.Enabled = False
    End Sub


    Private Sub EnabledControl()
        txtAcc.Enabled = True
        txtFName.Enabled = True
        txtMName.Enabled = True
        txtLName.Enabled = True
        txtAdd.Enabled = True
        txtEmail.Enabled = True
        txtGender.Enabled = True
        txtEdu.Enabled = True
        txtReli.Enabled = True
        txtOccu.Enabled = True
        txtPhone.Enabled = True
        txtPassword.Enabled = True
        txtBirth.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnClear.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        EnabledControl()


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        DisabledControl()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnClear.Enabled = False
        btnDelete.Enabled = True
        btnEdit.Enabled = True


    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearRecords()
    End Sub


End Class