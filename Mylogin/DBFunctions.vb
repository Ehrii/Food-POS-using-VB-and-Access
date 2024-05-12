Imports System.Data.OleDb
Module DBFunctions

    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Public connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\John Eriel\Documents\vb.net data\POSDatabase.accdb"
    Public conn As New OleDbConnection(connStr)


    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function


    'A function used to populate the records of the data grid view' 
    'Fills up with recent records'
    'Used globally throughout the final project'
    Function populateTrans()
        Dim da1 As New OleDbDataAdapter
        Dim dset1 As New DataSet
        da1 = New OleDbDataAdapter("Select * from [Transaction]", conn)
        dset1 = New DataSet
        da1.Fill(dset1, "Transaction")
        frmList.dgvList.DataSource = dset1.Tables("Transaction").DefaultView
    End Function

    Function populateOrderRec()
        Dim da2 As New OleDbDataAdapter
        Dim dset2 As New DataSet
        da2 = New OleDbDataAdapter("Select * from [Transaction]", conn)
        dset2 = New DataSet
        da2.Fill(dset2, "Transaction")
        frmOrderRec.DataGridView1.DataSource = dset2.Tables("Transaction").DefaultView
    End Function

    Function populateAcc()
        Dim da3 As New OleDbDataAdapter
        Dim dset3 As New DataSet
        da3 = New OleDbDataAdapter("Select * from Accounts", conn)
        dset3 = New DataSet
        da3.Fill(dset3, "Accounts")
        frmManage.DataGridView1.DataSource = dset3.Tables("Accounts").DefaultView
    End Function

    Function populateAudit()
        Dim da4 As New OleDbDataAdapter
        Dim dset4 As New DataSet
        da4 = New OleDbDataAdapter("Select * from AuditTrail", conn)
        dset4 = New DataSet
        da4.Fill(dset4, "AuditTrail")
        frmAudit.DataGridView1.DataSource = dset4.Tables("AuditTrail").DefaultView
    End Function

End Module
