Public Class frmCustom
    Dim pos As New frmPOS
    Dim GenRnd As New Random
    Public invoiceNum As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtFNAME.Clear()
        txtMNAME.Clear()
        txtLNAME.Clear()
        Me.Hide()

    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim fname, lname, mname As String
        fname = txtFNAME.Text
        mname = txtMNAME.Text
        lname = txtLNAME.Text
        frmPOS.btnCancelOr.Enabled = True
        If fname = "" Or mname = "" Or lname = "" Then
            MessageBox.Show("Please type the customer's full name!", "Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            frmPOS.lblInvoice.Text = "Invoice No: " & "000-" & GenRnd.Next(1000, 9999)
            invoiceNum = frmPOS.lblInvoice.Text
            frmPOS.lblCustom.Text = "Customer Name: " & lname & "," & fname & " " & mname
            frmPOS.btnAppetizer.Visible = True
            frmPOS.btnBreakfast.Visible = True
            frmPOS.btnDessert.Visible = True
            frmPOS.btnDrinks.Visible = True
            frmPOS.btnGrill.Visible = True
            frmPOS.btnSea.Visible = True
            frmPOS.btnSnack.Visible = True
            frmPOS.btnComplete.Enabled = True
            frmPOS.rdoDineIn.Enabled = True
            frmPOS.rdoTakeOut.Enabled = True

            Me.Hide()
        End If
    End Sub
    Private Sub frmCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFNAME.Clear()
        txtMNAME.Clear()
        txtLNAME.Clear()
    End Sub

End Class