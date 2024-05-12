Public Class frmQuan
    Public Orderquan As Integer

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If txtQuan.Text = "" Then
            MessageBox.Show("No quantity entered!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            frmPOS.prodQuan = txtQuan.Text
            Orderquan += txtQuan.Text
            Dim prodtotPrice As Double
            Dim objItem As ListViewItem
            prodtotPrice = frmPOS.prodQuan * frmPOS.prodPrice
            objItem = frmPOS.lvOrders.Items.Add(frmPOS.prodName)
            With objItem
                .SubItems.Add(frmPOS.prodQuan)
                .SubItems.Add(FormatNumber(prodtotPrice, 2))
            End With
            frmPOS.total += prodtotPrice
            frmPOS.lblBalance.Text = "TOTAL:₱" & FormatNumber(frmPOS.total, 2)
            txtQuan.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub frmQuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

