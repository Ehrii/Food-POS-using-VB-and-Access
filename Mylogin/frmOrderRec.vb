Imports System.Data.OleDb
Public Class frmOrderRec
    Private Sub frmOrderRec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateOrderRec()
        connect()
        DisabledControl()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnClear.Enabled = False

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim connstring As String
        Dim command As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        connstring = connStr
        myConnection.ConnectionString = connstring
        myConnection.Open()
        Dim total As Integer = Val(txtTotalAmt.Text)

        command = "Insert into [Transaction] values('" & txtInvoice.Text & "','" & txtCustom.Text & "','" & total & "','" & txtDate.Text & "','" & txtOrderQuan.Text & "','" & txtContact.Text & "','" & txtCashier.Text & "','" & txtOrderType.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)
        cmd.Parameters.Add(New OleDbParameter("Invoice", CType(txtInvoice.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Customer Name", CType(txtCustom.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("TotalAmt", CType(txtTotalAmt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Order Date", CType(txtDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("OrderQuantity", CType(txtOrderQuan.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Contact", CType(txtContact.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Cashier", CType(txtCashier.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Order Type", CType(txtOrderType.Text, String)))
        MsgBox("Insertion of records successful")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            populateOrderRec()
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

        Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM [Transaction] WHERE [Invoice] =@Invoice", myConnection)
        cmd.Parameters.Add(New OleDbParameter("@Invoice", CType(txtInvoice.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            populateOrderRec()
            clearRecords()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim connstring As String
        Dim command As String
        Dim myConnection As OleDbConnection = New OleDbConnection
        connstring = connStr
        myConnection.ConnectionString = connstring
        myConnection.Open()
        Dim total As Integer = Val(txtTotalAmt.Text)
        command = "Update [Transaction] set CustomerName='" & txtCustom.Text & "',TotalAmt='" & txtTotalAmt.Text & "',OrderDate='" & txtDate.Text & "',OrderQuantity='" & txtOrderQuan.Text & "',Contact='" & txtContact.Text & "',Cashier='" & txtCashier.Text & "',OrderType='" & txtOrderType.Text & "' WHERE Invoice='" & txtInvoice.Text & "'"

        Dim cmd As OleDbCommand = New OleDbCommand(command, myConnection)

        MsgBox("Updating of records successful")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            populateOrderRec()
            clearRecords()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub clearRecords()
        txtInvoice.Clear()
        txtCustom.Clear()
        txtTotalAmt.Clear()
        txtOrderQuan.Clear()
        txtContact.Clear()
        txtCashier.Clear()
        txtOrderType.Clear()
        txtDate.Clear()
    End Sub


    Private Sub DisabledControl()
        txtInvoice.Enabled = False
        txtCustom.Enabled = False
        txtTotalAmt.Enabled = False
        txtOrderQuan.Enabled = False
        txtContact.Enabled = False
        txtCashier.Enabled = False
        txtOrderType.Enabled = False
        txtDate.Enabled = False
    End Sub


    Private Sub EnabledControl()
        txtInvoice.Enabled = True
        txtCustom.Enabled = True
        txtTotalAmt.Enabled = True
        txtOrderQuan.Enabled = True
        txtContact.Enabled = True
        txtCashier.Enabled = True
        txtOrderType.Enabled = True
        txtDate.Enabled = True
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtInvoice.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtCustom.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtTotalAmt.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtDate.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtOrderQuan.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        txtContact.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        txtCashier.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        txtOrderType.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
    End Sub
End Class