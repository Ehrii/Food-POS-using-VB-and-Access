Imports System.Data.OleDb
Public Class frmDashBoard
    Private Sub btnAudit_Click(sender As Object, e As EventArgs) Handles btnAudit.Click
        Panel5.Controls.Clear()
        frmAudit.TopLevel = False
        Panel5.Controls.Add(frmAudit)
        frmAudit.Show()
    End Sub
    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Panel5.Controls.Clear()
        frmManage.TopLevel = False
        Panel5.Controls.Add(frmManage)
        frmManage.Show()
    End Sub
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Panel5.Controls.Clear()
        frmOrderRec.TopLevel = False
        Panel5.Controls.Add(frmOrderRec)
        frmOrderRec.Show()
    End Sub

    Private Sub frmDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        Dim user_cmd As New OleDbCommand
        Dim user_stmt, user_stmt1, user_stmt2, user_stmt3 As String
        Dim buyerstotalCount As String
        Dim usertotalCount As String
        Dim orderstotalCount As Double
        Dim revenuetotalCount As Double

        user_stmt = "SELECT count(*)FROM [Transaction]"
        user_cmd = New OleDbCommand(user_stmt, conn)
        If (buyerstotalCount = user_cmd.ExecuteScalar() Is Nothing) Then
            buyerstotalCount = "0"
        Else
            buyerstotalCount = user_cmd.ExecuteScalar()
        End If

        user_stmt1 = "SELECT count(*)FROM [Accounts]"
        user_cmd = New OleDbCommand(user_stmt1, conn)

        If (usertotalCount = user_cmd.ExecuteScalar() Is Nothing) Then
            usertotalCount = "0"
        Else
            usertotalCount = user_cmd.ExecuteScalar()
        End If


        user_stmt2 = "SELECT SUM(OrderQuantity) FROM [Transaction]"
        user_cmd = New OleDbCommand(user_stmt2, conn)

        If (user_cmd.ExecuteScalar() Is Nothing) Then
            orderstotalCount = 0

        End If

        If Not IsDBNull((user_cmd.ExecuteScalar())) Then
            orderstotalCount = user_cmd.ExecuteScalar()
        End If


        user_stmt3 = "SELECT SUM(TotalAmt) FROM [Transaction]"
        user_cmd = New OleDbCommand(user_stmt3, conn)
        If (user_cmd.ExecuteScalar() Is Nothing) Then
            revenuetotalCount = 0
        End If

        If Not IsDBNull((user_cmd.ExecuteScalar())) Then
            revenuetotalCount = user_cmd.ExecuteScalar()
        End If

        lblBuyers.Text = buyerstotalCount
        lblEmp.Text = usertotalCount
        lblProd.Text = orderstotalCount
        lblRevenue.Text = "₱" & FormatNumber(revenuetotalCount, 2)
        conn.Close()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        connect()
        Dim com As OleDbCommand
        Dim num As Integer
        Dim myreader As OleDbDataReader
        Dim logIn, logOut, logDate As String
        Dim pos, act As String
        Dim accNum As String = frmAdmin.txtUser.Text
        logIn = frmAdmin.logIn.ToLongTimeString
        logDate = Today.ToShortDateString
        logOut = TimeOfDay.ToLongTimeString
        accNum = 24900
        pos = frmAdmin.pos
        act = frmAdmin.act
        com = New OleDbCommand
        com.Connection = conn
        com.CommandText = "Insert into AuditTrail values ('" & accNum & "','" & lblName.Text & "','" & logDate & "','" & logIn & "','" & logOut & "','" & pos & "','" & act & "')"
        com.ExecuteNonQuery()
        Call populateAudit()
        Me.Hide()
        frmAdmin.txtPass.Clear()
        frmAdmin.txtUser.Clear()
        frmLogin.Show()
    End Sub
End Class