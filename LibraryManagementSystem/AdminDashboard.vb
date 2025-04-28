Imports MySql.Data.MySqlClient

Public Class AdminDashboard
    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BindData()
            AddColumnButtons()
        Catch ex As Exception
            MessageBox.Show("unable to Connect")
        End Try
    End Sub

    Private Sub BindData()
        Dim query As String = "SELECT * FROM accounts as a INNER JOIN owners as o ON a.owner_id = o.owner_id"
        Dim cmd As New MySqlCommand(query, conn)

        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim dt As New DataTable()
        dt.Load(reader)
        reader.Close()
        conn.Close()

        DataGridView1.DataSource = dt

        DataGridView1.Columns("account_id").HeaderText = "Account ID"
        DataGridView1.Columns("email").HeaderText = "Email"
        DataGridView1.Columns("firstname").HeaderText = "First Name"
        DataGridView1.Columns("middlename").HeaderText = "Middle Name"
        DataGridView1.Columns("lastname").HeaderText = "Lastname"
        DataGridView1.Columns("sex").HeaderText = "Sex"

        DataGridView1.Columns("owner_id").Visible = False
        DataGridView1.Columns("owner_id1").Visible = False
        DataGridView1.Columns("balance").Visible = False
        DataGridView1.Columns("account_type").Visible = False
        DataGridView1.Columns("username").Visible = False
        DataGridView1.Columns("password").Visible = False
        DataGridView1.Columns("created_at").Visible = False
        DataGridView1.Columns("updated_at").Visible = False
        DataGridView1.Columns("created_at1").Visible = False
        DataGridView1.Columns("updated_at1").Visible = False

        DataGridView1.Columns("phone_number").Visible = False
        DataGridView1.Columns("address").Visible = False

    End Sub

    Private Sub AddColumnButtons()
        If DataGridView1.Columns.Contains("Edit") = False Then
            Dim editBtn As New DataGridViewButtonColumn
            editBtn.HeaderText = "Edit"
            editBtn.Text = "Edit"
            editBtn.Name = "Edit"
            editBtn.UseColumnTextForButtonValue = True

            DataGridView1.Columns.Add(editBtn)
        End If

        If DataGridView1.Columns.Contains("Delete") = False Then
            Dim delBtn As New DataGridViewButtonColumn
            delBtn.HeaderText = "Delete"
            delBtn.Text = "Delete"
            delBtn.Name = "Delete"
            delBtn.UseColumnTextForButtonValue = True

            DataGridView1.Columns.Add(delBtn)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim registerAccountForm As New RegisterForm
        registerAccountForm.ShowDialog()
    End Sub

    Private Sub EditCellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
                Dim accountId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("account_id").Value)

                Dim editAccountDetails As New EditAccount(accountId)
                editAccountDetails.ShowDialog()

                BindData()
                AddColumnButtons()


            ElseIf DataGridView1.Columns(e.ColumnIndex).Name = "Delete" Then
                Dim accountId As Integer = Convert.ToInt32(DataGridView1.Rows(e.RowIndex).Cells("account_id").Value)
                Dim result As New DialogResult
                result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE o FROM owners o INNER JOIN accounts a ON o.owner_id = a.owner_id WHERE a.account_id = @acc_id;"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@acc_id", accountId)
                    conn.Open()

                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Deleted Succussfully!")
                    BindData()
                    AddColumnButtons()
                End If
            End If
        End If
    End Sub

End Class