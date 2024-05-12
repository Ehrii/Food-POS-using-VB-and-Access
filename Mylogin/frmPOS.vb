Imports System.Data.OleDb
Public Class frmPOS

    Public total As Double
    Public prodName As String
    Public prodPrice As Double
    Public prodQuan As Integer
    Public btnCheck As Boolean
    Public rdoValue As String
    Dim accNum As String

    'Public variables used for the quantity form, and order details form' 

    Private Sub btnAppetizer_Click(sender As Object, e As EventArgs) Handles btnAppetizer.Click
        pnlAppetizer.Visible = True
        pnlBreakfast.Visible = False
        pnlDessert.Visible = False
        pnlDrinks.Visible = False
        pnlGrill.Visible = False
        pnlSea.Visible = False
        pnlSnacks.Visible = False
    End Sub

    Private Sub btnBreakfast_Click(sender As Object, e As EventArgs) Handles btnBreakfast.Click

        pnlBreakfast.Visible = True
        pnlAppetizer.Visible = False
        pnlDessert.Visible = False
        pnlDrinks.Visible = False
        pnlGrill.Visible = False
        pnlSea.Visible = False
        pnlSnacks.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlDrinks.Visible = True
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        pnlDessert.Visible = False
        pnlGrill.Visible = False
        pnlSea.Visible = False
        pnlSnacks.Visible = False
    End Sub

    Private Sub btnGrill_Click(sender As Object, e As EventArgs) Handles btnGrill.Click
        pnlGrill.Visible = True
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        pnlDessert.Visible = False
        pnlSea.Visible = False
        pnlSnacks.Visible = False
    End Sub

    Private Sub btnSea_Click(sender As Object, e As EventArgs) Handles btnSea.Click
        pnlSea.Visible = True
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        pnlDessert.Visible = False
        pnlSnacks.Visible = False
    End Sub

    Private Sub btnSnack_Click(sender As Object, e As EventArgs) Handles btnSnack.Click
        pnlSnacks.Visible = True
        pnlSea.Visible = False
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        pnlDessert.Visible = False
    End Sub

    Private Sub btnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        pnlDessert.Visible = True
        pnlSnacks.Visible = False
        pnlSea.Visible = False
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rdoDineIn.Enabled = False
        rdoTakeOut.Enabled = False
        btnComplete.Enabled = False
        btnAppetizer.Visible = False
        btnBreakfast.Visible = False
        btnDessert.Visible = False
        btnDrinks.Visible = False
        btnGrill.Visible = False
        btnSea.Visible = False
        btnSnack.Visible = False
        btnCancelOr.Enabled = False
        pnlFood.Visible = True
        pnlDessert.Visible = False
        pnlSnacks.Visible = False
        pnlSea.Visible = False
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
    End Sub
    Private Sub picCeaser_Click(sender As Object, e As EventArgs) Handles picCeaser.Click
        prodName = "1 Bowl of Ceaser salad"
        prodPrice = 250.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picChef_Click(sender As Object, e As EventArgs) Handles picChef.Click
        prodName = "1 Bowl of Chef salad"
        prodPrice = 260.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picLumpia_Click(sender As Object, e As EventArgs) Handles picLumpia.Click
        prodName = "8-pc. Lumpiang Shanghai"
        prodPrice = 120.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picCalamares_Click(sender As Object, e As EventArgs) Handles picCalamares.Click
        prodName = "7-pc. Calamares"
        prodPrice = 140.0
        Call DisplayProd(prodPrice)

    End Sub
    '-----Dessert----'
    Private Sub picChoco_Click(sender As Object, e As EventArgs) Handles picChoco.Click
        prodName = "1cup. Chocolate Ice Cream"
        prodPrice = 75.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picStrawCream_Click(sender As Object, e As EventArgs) Handles picStrawCream.Click
        prodName = "1cup. Strawberry Ice Cream"
        prodPrice = 75.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picHalo_Click(sender As Object, e As EventArgs) Handles picHalo.Click
        prodName = "1cup. Special Halo-Halo"
        prodPrice = 90.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picOreo_Click(sender As Object, e As EventArgs) Handles picOreo.Click
        prodName = "Oreo Milkshake"
        prodPrice = 110.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picBrown_Click(sender As Object, e As EventArgs) Handles picBrown.Click
        prodName = "6-pc. Brownies"
        prodPrice = 65.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picBanana_Click(sender As Object, e As EventArgs) Handles picBanana.Click
        prodName = "1pc. Banana Split"
        prodPrice = 110.0
        Call DisplayProd(prodPrice)
    End Sub
    Private Sub picStraw_Click(sender As Object, e As EventArgs) Handles picStraw.Click
        prodName = "1pc. Strawberry Yogurt"
        prodPrice = 90.0
        Call DisplayProd(prodPrice)
    End Sub
    '-----Snacks----'
    Private Sub picNacho_Click(sender As Object, e As EventArgs) Handles picNacho.Click
        prodName = "1 set of Nachos with cheese dip"
        prodPrice = 80.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picPotato_Click(sender As Object, e As EventArgs) Handles picPotato.Click
        prodName = "1 pack of Potato Chips"
        prodPrice = 60.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picPop_Click(sender As Object, e As EventArgs) Handles picPop.Click
        prodName = "1 pc. Large cheese popcorn"
        prodPrice = 75.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCorn_Click(sender As Object, e As EventArgs) Handles picCorn.Click
        prodName = "2 pc. Corndog"
        prodPrice = 40.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picPizza_Click(sender As Object, e As EventArgs) Handles picPizza.Click
        prodName = "1 Box. Hawaiian Pizza"
        prodPrice = 140.0
        Call DisplayProd(prodPrice)
    End Sub

    '----Seafood----'
    Private Sub picSalmon_Click(sender As Object, e As EventArgs) Handles picSalmon.Click
        prodName = "1 pc. Honey Garlic Salmon"
        prodPrice = 55.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCrabSoup_Click(sender As Object, e As EventArgs) Handles picCrabSoup.Click
        prodName = "1 pc. Corn Crab Soup"
        prodPrice = 60.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCrab_Click(sender As Object, e As EventArgs) Handles picCrab.Click
        prodName = "1 pc. Garlic Buttered Crab"
        prodPrice = 90.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCasserole_Click(sender As Object, e As EventArgs) Handles picCasserole.Click
        prodName = "1 pc. Tuna Casserole"
        prodPrice = 80.0
        Call DisplayProd(prodPrice)
    End Sub

    '-----Grilled-----'
    Private Sub picGrillPiz_Click(sender As Object, e As EventArgs) Handles picGrillPiz.Click
        prodName = "1 pc. Grilled Pizza"
        prodPrice = 100.0
        Call DisplayProd(prodPrice)

    End Sub

    Private Sub picBbq_Click(sender As Object, e As EventArgs) Handles picBbq.Click
        prodName = "4 pc. Grilled Barbecue"
        prodPrice = 40.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picPatties_Click(sender As Object, e As EventArgs) Handles picPatties.Click
        prodName = "4 pc. Grilled Barbecue"
        prodPrice = 50.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picBrie_Click(sender As Object, e As EventArgs) Handles picBrie.Click
        prodName = "A pan of Grilled Brie"
        prodPrice = 90.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picPork_Click(sender As Object, e As EventArgs) Handles picPork.Click
        prodName = "Grilled Pork Tenderloin"
        prodPrice = 110.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picTurkey_Click(sender As Object, e As EventArgs) Handles picTurkey.Click
        prodName = "A plate of Grilled Turkey"
        prodPrice = 190.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picHarissa_Click(sender As Object, e As EventArgs) Handles picHarissa.Click
        prodName = " Harissa Grilled Chicken"
        prodPrice = 120.0
        Call DisplayProd(prodPrice)

        '----Drinks----
    End Sub

    Private Sub picCola_Click(sender As Object, e As EventArgs) Handles picCola.Click
        prodName = "Coca-cola"
        prodPrice = 20.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picStrawsmooth_Click(sender As Object, e As EventArgs) Handles picStrawsmooth.Click
        prodName = "Strawberry Smoothies"
        prodPrice = 70.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picChocosmooth_Click(sender As Object, e As EventArgs) Handles picChocosmooth.Click
        prodName = "Chocolate Smoothies"
        prodPrice = 70.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCookiessmooth_Click(sender As Object, e As EventArgs) Handles picCookiessmooth.Click
        prodName = "Cookies & Creama smoothies"
        prodPrice = 80.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picWater_Click(sender As Object, e As EventArgs) Handles picWater.Click
        prodName = "Wilkins mineral water"
        prodPrice = 15.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picTea_Click(sender As Object, e As EventArgs) Handles picTea.Click
        prodName = "Lemon iced tea"
        prodPrice = 20.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCaramel_Click(sender As Object, e As EventArgs) Handles picCaramel.Click
        prodName = "Caramel smoothie"
        prodPrice = 90.0
        Call DisplayProd(prodPrice)
    End Sub
    '----breakfast----'
    Private Sub PicPancakes_Click(sender As Object, e As EventArgs) Handles picPancakes.Click
        prodName = "3-pc. Pancakes"
        prodPrice = 60.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picCrois_Click(sender As Object, e As EventArgs) Handles picCrois.Click
        prodName = "1-pc. Croissant"
        prodPrice = 15.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picWaff_Click(sender As Object, e As EventArgs) Handles picWaff.Click
        prodName = "2-pc. Waffles"
        prodPrice = 25.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        prodName = "2-pc. Sunny side up egg"
        prodPrice = 40.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picMuff_Click(sender As Object, e As EventArgs) Handles picMuff.Click
        prodName = "3-pc. Banana Muffins"
        prodPrice = 40.0
        Call DisplayProd(prodPrice)
    End Sub

    Private Sub picGarlicRice_Click(sender As Object, e As EventArgs) Handles picGarlicRice.Click
        prodName = "Garlic Fried Rice"
        prodPrice = 15.0
        Call DisplayProd(prodPrice)
    End Sub

    Public Sub DisplayProd(prodPrice As Double)
        'Shows the quantity form'
        frmQuan.Show()
    End Sub


    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        If rdoDineIn.Checked = True Then
            rdoValue = "Dine-In"
        ElseIf rdoTakeOut.Checked = True Then
            rdoValue = "Take-Out"
        End If
        If rdoDineIn.Checked = False And rdoTakeOut.Checked = False Then
            MessageBox.Show("Please choose an order type first.Thank you!", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf lvOrders.Items.Count = 0 Then
            MessageBox.Show("Please choose an order first.Thank you!", "Order Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            frmCheckOut.lblCustomer.Text = lblCustom.Text
            frmCheckOut.lblInvoice.Text = lblInvoice.Text
            frmCheckOut.txtAddress.Text = ""
            frmCheckOut.txtCity.Text = ""
            frmCheckOut.txtPhone.Text = ""
            frmCheckOut.txtCash.Text = ""
            frmCheckOut.txtTotalAmt.Text = ""
            frmCheckOut.txtChange.Clear()
            frmCheckOut.GetSales()
            frmCheckOut.Show()
        End If

    End Sub
    Private Sub btnPass_Click(sender As Object, e As EventArgs) Handles btnPass.Click
        frmPass.Show()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        frmCustom.Show()
    End Sub

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click
        Me.Hide()

        With frmList
            .TopLevel = False
            frmBackground.pnlShow.Controls.Add(frmList)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub lblReset_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReset.LinkClicked
        lvOrders.Items.Clear()
        lblBalance.Text = "TOTAL:"
        frmQuan.Orderquan = 0
        total = 0
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        frmBackground.Hide()
        accNum = frmLogin.txtUser.Text
        total = 0
        frmQuan.Orderquan = 0
        lblCustom.Text = "Customer Name: "
        lblInvoice.Text = "Invoice No: "
        lblBalance.Text = "TOTAL: "
        lvOrders.Items.Clear()
        total = 0
        frmQuan.Orderquan = 0
        rdoDineIn.Enabled = False
        rdoTakeOut.Enabled = False
        btnComplete.Enabled = False
        btnAppetizer.Visible = False
        btnBreakfast.Visible = False
        btnDessert.Visible = False
        btnDrinks.Visible = False
        btnGrill.Visible = False
        btnSea.Visible = False
        btnSnack.Visible = False
        pnlFood.Visible = True
        pnlDessert.Visible = False
        pnlSnacks.Visible = False
        pnlSea.Visible = False
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        frmCustom.txtFNAME.Clear()
        frmCustom.txtMNAME.Clear()
        frmCustom.txtLNAME.Clear()
        frmLogin.txtUser.Clear()
        frmLogin.txtPass.Clear()
        frmLogin.Show()

        'For Audit trail'
        connect()
        Dim com As OleDbCommand
        Dim myreader As OleDbDataReader
        Dim logIn, logOut, logDate As Date
        Dim pos, act As String

        logIn = frmLogin.logIn
        logDate = Today.ToShortDateString
        logOut = TimeOfDay.ToLongTimeString
        pos = frmLogin.pos
        act = frmLogin.act

        com = New OleDbCommand
        com.Connection = conn
        com.CommandText = "Insert into AuditTrail values ('" & accNum & "','" & lblCashName.Text & "','" & logDate & "','" & logIn & "','" & logOut & "','" & pos & "','" & act & "')"
        com.ExecuteNonQuery()
        Call populateAudit()

    End Sub

    Private Sub btnCancelOr_Click(sender As Object, e As EventArgs) Handles btnCancelOr.Click
        lblCustom.Text = "Customer Name: "
        lblInvoice.Text = "Invoice No: "
        lblBalance.Text = "TOTAL: "
        lvOrders.Items.Clear()
        total = 0
        frmQuan.Orderquan = 0
        frmCheckOut.txtTotalAmt.Text = ""
        frmCheckOut.txtAddress.Clear()
        frmCheckOut.txtCash.Clear()
        frmCheckOut.txtChange.Text = ""
        frmCheckOut.txtCity.Clear()
        frmCheckOut.txtPhone.Clear()
        frmCheckOut.cboPayment.Text = ""
        frmCheckOut.cboDisc.Text = ""
        rdoDineIn.Enabled = False
        rdoTakeOut.Enabled = False
        btnComplete.Enabled = False
        btnAppetizer.Visible = False
        btnBreakfast.Visible = False
        btnDessert.Visible = False
        btnDrinks.Visible = False
        btnGrill.Visible = False
        btnSea.Visible = False
        btnSnack.Visible = False
        pnlFood.Visible = True
        pnlDessert.Visible = False
        pnlSnacks.Visible = False
        pnlSea.Visible = False
        pnlGrill.Visible = False
        pnlDrinks.Visible = False
        pnlBreakfast.Visible = False
        pnlAppetizer.Visible = False
        frmCustom.txtFNAME.Clear()
        frmCustom.txtMNAME.Clear()
        frmCustom.txtLNAME.Clear()
    End Sub
End Class