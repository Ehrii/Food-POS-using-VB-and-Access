Imports System.Data.OleDb

Public Class frmAudit
    Dim conn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter(cmd)


    Private Sub viewer()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()

        conn.Open()
        cmd = conn.CreateCommand
        cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("select * from AuditTrail ", conn)
        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 153
        conn.Close()
    End Sub
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = connStr
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        disabledControl()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "INSERT INTO AuditTrail values('" + txtAcc.Text + "', '" + txtName.Text + "', '" + txtLogDate.Text + "', '" + txtTimeIn.Text + "','" + txtTimeOut.Text + "','" + txtPosition.Text + "','" + txtAction.Text + "')"
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Added", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populateAudit() 'populates the database quickly' 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewer()
        btnView.Enabled = False

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "Update AuditTrail set [UserName]='" & txtName.Text & "',[LogDate]='" & txtLogDate.Text & "',[LoginTime]='" & txtTimeIn.Text & "',
                [LogoutTime]='" & txtTimeOut.Text & "',[Position]='" & txtPosition.Text & "',[Action]='" & txtAcc.Text & "' WHERE [AccountNum]=" & txtAcc.Text & ""
            populateAudit()

            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Updated", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populateAudit() 'populates the database quickly' 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.Open()
            cmd = conn.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Delete * from AuditTrail where [AccountNum] = " + txtAcc.Text + ""
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Record Deleted", "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populateAudit() 'populates the database quickly' 


            txtAcc.Clear()
            txtName.Clear()
            txtLogDate.Clear()
            txtTimeIn.Clear()
            txtTimeOut.Clear()
            txtPosition.Clear()
            txtAction.Clear()
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            txtAcc.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            txtName.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            txtLogDate.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            txtTimeIn.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            txtTimeOut.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
            txtPosition.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
            txtAction.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Audit Trail", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        enabledControl()
    End Sub

    Private Sub disabledControl()
        txtAcc.Enabled = False
        txtAction.Enabled = False
        txtLogDate.Enabled = False
        txtName.Enabled = False
        txtPosition.Enabled = False
        txtTimeIn.Enabled = False
        txtTimeOut.Enabled = False
    End Sub

    Private Sub enabledControl()
        txtAcc.Enabled = True
        txtAction.Enabled = True
        txtLogDate.Enabled = True
        txtName.Enabled = True
        txtPosition.Enabled = True
        txtTimeIn.Enabled = True
        txtTimeOut.Enabled = True
    End Sub
End Class

