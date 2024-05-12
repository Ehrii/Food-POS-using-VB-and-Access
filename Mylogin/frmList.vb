Imports System.Data.OleDb
Public Class frmList
    Dim cmd As New OleDbCommand
    Dim com As String
    Dim dr As OleDbDataReader
    Dim dset As New DataSet
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        With frmPOS
            .TopLevel = False
            frmBackground.pnlShow.Controls.Add(frmPOS)
            .BringToFront()
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub frmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCashier.Text = "Cashier Name: " & frmPOS.lblCashName.Text
    End Sub

    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click

        If cboInventory.SelectedItem = "Weekly" Then
            connect()


            dgvList.Rows.Clear()
            cmd = New OleDbCommand("Select Invoice, CustomerName,TotalAmt,OrderDate,OrderQuantity,Contact,Cashier,OrderType from [Transaction] where DatePart ('ww',[OrderDate]) = DatePart('ww',Date()) and Year (OrderDate) = Year(Date())", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvList.Rows.Add(dr.Item("Invoice").ToString, dr.Item("CustomerName").ToString, dr.Item("TotalAmt").ToString, dr.Item("OrderDate").ToShortDateString,
               dr.Item("OrderQuantity").ToString, dr.Item("Contact").ToString, dr.Item("Cashier").ToString, dr.Item("OrderType").ToString)

            End While
            conn.Close()
        End If

        If cboInventory.SelectedItem = "Monthly" Then
            connect()

            dgvList.Rows.Clear()
            cmd = New OleDbCommand("Select Invoice, CustomerName,TotalAmt,OrderDate,OrderQuantity,Contact,Cashier,OrderType from [Transaction] where Year ([OrderDate]) = Year(Now()) and Month ([OrderDate]) = Month(Now())", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvList.Rows.Add(dr.Item("Invoice").ToString, dr.Item("CustomerName").ToString, dr.Item("TotalAmt").ToString, dr.Item("OrderDate").ToShortDateString,
               dr.Item("OrderQuantity").ToString, dr.Item("Contact").ToString, dr.Item("Cashier").ToString, dr.Item("OrderType").ToString)

            End While
            conn.Close()
        End If

        If cboInventory.SelectedItem = "Yearly" Then
            connect()

            dgvList.Rows.Clear()
            cmd = New OleDbCommand("Select Invoice, CustomerName,TotalAmt,OrderDate,OrderQuantity,Contact,Cashier,OrderType from [Transaction] where Year ([OrderDate]) = Year(Date()) ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                dgvList.Rows.Add(dr.Item("Invoice").ToString, dr.Item("CustomerName").ToString, dr.Item("TotalAmt").ToString, dr.Item("OrderDate").ToShortDateString,
               dr.Item("OrderQuantity").ToString, dr.Item("Contact").ToString, dr.Item("Cashier").ToString, dr.Item("OrderType").ToString)
            End While
            conn.Close()
        End If

    End Sub
End Class