Public Class frmCheckOut
    Dim vatpercentage = 0.12, totalAmt, disc As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtTotalAmt.Clear()
        txtAddress.Clear()
        txtAmount.Clear()
        txtCash.Clear()
        txtChange.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtVat.Clear()
        txtVatable.Clear()
        cboPayment.Text = ""
        cboDisc.Text = ""
        Me.Hide()

    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click


        If txtCash.Text = "" Then
            MessageBox.Show("Please enter a cash amount!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If txtCash.Text < totalAmt Then
            MessageBox.Show("Insufficient amount!", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim amt, change As Double
        amt = CDbl(txtCash.Text)
        change = amt - Val(txtTotalAmt.Text)
        txtChange.Text = FormatNumber(change, 2)




    End Sub
    Private Sub Guna2GradientButton12_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If txtAddress.Text = "" Or txtCash.Text = "" Or txtCity.Text = "" Or cboPayment.Text = "" Or cboDisc.Text = "" Or txtPhone.Text = "" Then
            MessageBox.Show("Please fill out the following details, before paying..", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Me.Hide()
            frmOrder.Show()
            GetOrder()
        End If

    End Sub

    Public Sub GetSales()
        txtAmount.Enabled = False
        txtVat.Enabled = False
        txtVatable.Enabled = False
        txtTotalAmt.Enabled = False
        txtChange.Enabled = False
        txtCash.Enabled = False
        'totalAmt = FormatNumber(frmPOS.total, 2)
        txtAmount.Text = FormatNumber(frmPOS.total, 2)
        txtVat.Text = FormatNumber(frmPOS.total, 2) * FormatNumber(vatpercentage, 2)
        txtVatable.Text = FormatNumber(frmPOS.total, 2) - Val(FormatNumber(txtVat.Text, 2))
    End Sub

    Private Sub GetOrder()
        frmOrder.lblFName.Text = frmCustom.txtFNAME.Text
        frmOrder.lblMName.Text = frmCustom.txtMNAME.Text
        frmOrder.lblLName.Text = frmCustom.txtLNAME.Text
        frmOrder.lblOrType.Text = frmPOS.rdoValue
        frmOrder.lblAdd.Text = txtAddress.Text
        frmOrder.lblCity.Text = txtCity.Text
        frmOrder.lblPhone.Text = txtPhone.Text
        frmOrder.lblTotalAmt.Text = txtTotalAmt.Text
        frmOrder.lblPayMethod.Text = cboPayment.Text
        frmOrder.lblCashPaid.Text = txtCash.Text
        frmOrder.lblChange.Text = txtChange.Text
        frmOrder.lblDisc.Text = cboDisc.Text

    End Sub

    'Numpad buttons used only for inputting the cash amount' 
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtCash.Text = txtCash.Text + "1"
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtCash.Text = txtCash.Text + "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtCash.Text = txtCash.Text + "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtCash.Text = txtCash.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtCash.Text = txtCash.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtCash.Text = txtCash.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtCash.Text = txtCash.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtCash.Text = txtCash.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtCash.Text = txtCash.Text + "9"
    End Sub

    Private Sub btnDoubleZero_Click(sender As Object, e As EventArgs) Handles btnDoubleZero.Click
        txtCash.Text = txtCash.Text + "00"
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtCash.Text = txtCash.Text + "0"
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        txtCash.Text = txtCash.Text + "."
    End Sub

    Private Sub frmCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblCustomer.Text = frmPOS.lblCustom.Text
        MessageBox.Show("Fill out the following details in the Check-Out form. Thank you!", "Order Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("You Ordered " & frmQuan.Orderquan & " Meals", "Order Count", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCash.Enabled = False
        txtTotalAmt.Text = ""
        txtAddress.Clear()
        txtCash.Clear()
        txtChange.Text = ""
        txtCity.Clear()
        txtPhone.Clear()
        cboPayment.Text = ""
        cboDisc.Text = ""


    End Sub
    Private Sub btnCompute_Click_1(sender As Object, e As EventArgs) Handles btnCompute.Click
        If cboDisc.Text = "" Then
            MessageBox.Show("Choose a discount first", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        txtCash.Enabled = True

        If cboDisc.SelectedIndex = 1 Then
            disc = 0
        ElseIf cboDisc.SelectedIndex = 2 Then
            disc = FormatNumber(txtAmount.Text, 2) * 0.15
        ElseIf cboDisc.SelectedIndex = 3 Then
            disc = FormatNumber(txtAmount.Text, 2) * 0.2
        ElseIf cboDisc.SelectedIndex = 4 Then
            disc = FormatNumber(txtAmount.Text, 2) * 0.25
        End If
        txtTotalAmt.Text = FormatNumber(txtAmount.Text, 2) - FormatNumber(disc, 2)
        totalAmt = FormatNumber(txtTotalAmt.Text, 2)
    End Sub


End Class