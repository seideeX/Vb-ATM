Imports MySql.Data.MySqlClient

Public Class Form1

    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)

    Private loggedInUserId As Integer

    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        loggedInUserId = userId

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim query As String = "SELECT * FROM accounts as a INNER JOIN owners as o ON a.owner_id = o.owner_id WHERE account_id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", loggedInUserId)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim name As String = reader("firstname").ToString().ToUpper()

                Label1.Text += name
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("unsuccessful: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub RegisterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim transactions As New TransactionHistory(loggedInUserId)
        transactions.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim editAccount As New EditAccount(loggedInUserId)
        editAccount.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deposit As New Deposit(loggedInUserId)
        Me.Hide()
        deposit.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim withdraw As New Withdraw(loggedInUserId)
        Me.Hide()
        withdraw.Show()
    End Sub
End Class
