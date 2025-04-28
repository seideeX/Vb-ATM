Imports MySql.Data.MySqlClient

Public Class TransactionHistory
    Private loggedInUserId As Integer
    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loggedInUserId = userId
    End Sub

    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)


    Private Sub TransactionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            BindData()
        Catch ex As Exception
            MessageBox.Show("unable to Connect")
        End Try
    End Sub

    Private Sub BindData()
        Try
            Dim query As String = "SELECT * FROM transactions WHERE account_id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", loggedInUserId)

            conn.Open()

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)
            reader.Close()
            conn.Close()

            DataGridView1.DataSource = dt

            DataGridView1.Columns("transaction_id").HeaderText = "ID"
            DataGridView1.Columns("transaction_type").HeaderText = "Transaction Type"
            DataGridView1.Columns("amount").HeaderText = "Amount"
            DataGridView1.Columns("date_transacted").HeaderText = "Date of Transaction"
            DataGridView1.Columns("previous_balance").HeaderText = "Previous Balance"
            DataGridView1.Columns("current_balance").HeaderText = "Current Balance"

            DataGridView1.Columns("created_at").Visible = False
            DataGridView1.Columns("updated_at").Visible = False
            DataGridView1.Columns("account_id").Visible = False

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub AddButtonColumns()
        If DataGridView1.Columns.Contains("Edit") = False Then
            Dim editBtn As New DataGridViewButtonColumn
            editBtn.HeaderText = "Edit"
            editBtn.Text = "Edit"
            editBtn.Name = "Edit"
            editBtn.UseColumnTextForButtonValue = True

            DataGridView1.Columns.Add(editBtn)
        End If

        If DataGridView1.Columns.Contains("Delete") = False Then
            Dim deleteBtn As New DataGridViewButtonColumn
            deleteBtn.HeaderText = "Delete"
            deleteBtn.Text = "Delete"
            deleteBtn.Name = "Delete"
            deleteBtn.UseColumnTextForButtonValue = True

            DataGridView1.Columns.Add(deleteBtn)
        End If
    End Sub

    Private Sub TransactionFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub
End Class