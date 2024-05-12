Imports System.Data.OleDb
Public Class frmOrder

    Private Sub BtnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        frmPOS.lvOrders.Items.Clear()
        frmPOS.total = 0
        frmQuan.Orderquan = 0
        frmCheckOut.txtTotalAmt.Text = ""
        frmCheckOut.txtAddress.Clear()
        frmCheckOut.txtCash.Clear()
        frmCheckOut.txtChange.Text = ""
        frmCheckOut.txtCity.Clear()
        frmCheckOut.txtPhone.Clear()
        frmCheckOut.cboPayment.Text = ""
        frmCheckOut.cboDisc.Text = ""
        Me.Hide()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim comm As OleDbCommand
        connect()

        Dim invoiceNum, CustomerName, Contact, Cashier, OrderType As String
        Dim totalAmt, OrderQuan As Integer
        Dim dateToday As Date
        invoiceNum = frmCustom.invoiceNum
        CustomerName = frmCustom.txtFNAME.Text & " " & frmCustom.txtMNAME.Text & "," & frmCustom.txtLNAME.Text
        totalAmt = FormatNumber(Val(frmCheckOut.txtTotalAmt.Text), 2)
        OrderQuan = frmQuan.Orderquan
        Contact = frmCheckOut.txtPhone.Text
        Cashier = frmPOS.lblCashName.Text
        dateToday = Today.ToShortDateString
        OrderType = lblOrType.Text

        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "insert into [Transaction] values ('" & invoiceNum & "','" & CustomerName & "','" & totalAmt & "','" & dateToday & "','" & OrderQuan & "','" & Contact & "','" & Cashier & "','" & OrderType & "')"
        comm.ExecuteNonQuery()
        frmPOS.lblCustom.Text = "Customer Name: "
        frmPOS.lblInvoice.Text = "Invoice No: "
        frmPOS.lblBalance.Text = "TOTAL: "
        frmPOS.lvOrders.Items.Clear()
        frmPOS.lblBalance.Text = "TOTAL:"
        frmPOS.total = 0
        frmQuan.Orderquan = 0
        frmPOS.rdoDineIn.Enabled = False
        frmPOS.rdoTakeOut.Enabled = False
        frmPOS.btnComplete.Enabled = False
        frmPOS.btnAppetizer.Visible = False
        frmPOS.btnBreakfast.Visible = False
        frmPOS.btnDessert.Visible = False
        frmPOS.btnDrinks.Visible = False
        frmPOS.btnGrill.Visible = False
        frmPOS.btnSea.Visible = False
        frmPOS.btnSnack.Visible = False
        frmPOS.pnlFood.Visible = True
        frmPOS.pnlDessert.Visible = False
        frmPOS.pnlSnacks.Visible = False
        frmPOS.pnlSea.Visible = False
        frmPOS.pnlGrill.Visible = False
        frmPOS.pnlDrinks.Visible = False
        frmPOS.pnlBreakfast.Visible = False
        frmPOS.pnlAppetizer.Visible = False
        frmCustom.txtFNAME.Clear()
        frmCustom.txtMNAME.Clear()
        frmCustom.txtLNAME.Clear()
        Me.Hide()
    End Sub
End Class