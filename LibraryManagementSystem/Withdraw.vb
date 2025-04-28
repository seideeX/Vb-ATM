Imports MySql.Data.MySqlClient

Public Class Withdraw
    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)

    Private loggedInUserId As Integer
    Private Currentbalance As Decimal
    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loggedInUserId = userId
    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim query As String = "SELECT * FROM accounts as a INNER JOIN owners as o ON a.owner_id = o.owner_id WHERE account_id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", loggedInUserId)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Currentbalance = reader("balance")
                lbl_balance.Text = Currentbalance.ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("unsuccessful: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_withdraw_Click(sender As Object, e As EventArgs) Handles btn_withdraw.Click
        Dim withdrawAmount As Decimal = txt_withdraw.Text

        If withdrawAmount < Currentbalance Then
            Dim prevBalance As Decimal = Currentbalance
            Currentbalance -= withdrawAmount
            Try
                Dim query As String = "INSERT INTO transactions (account_id, amount, transaction_type, date_transacted, previous_balance, current_balance) 
                                    VALUES (@id, @amount, @transaction_type, @date_transacted, @previous_balance, @current_balance)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", loggedInUserId)
                cmd.Parameters.AddWithValue("@amount", withdrawAmount)
                cmd.Parameters.AddWithValue("@transaction_type", "withdrawal")
                cmd.Parameters.AddWithValue("@date_transacted", Date.UtcNow)
                cmd.Parameters.AddWithValue("@previous_balance", prevBalance)
                cmd.Parameters.AddWithValue("@current_balance", Currentbalance)

                conn.Open()
                cmd.ExecuteNonQuery()

                Dim query2 As String = "UPDATE accounts SET balance = @balance WHERE account_id = @id"
                Dim cmd2 As New MySqlCommand(query2, conn)
                cmd2.Parameters.AddWithValue("@id", loggedInUserId)
                cmd2.Parameters.AddWithValue("@balance", Currentbalance)
                cmd2.ExecuteNonQuery()

                conn.Close()
                lbl_balance.Text = Currentbalance.ToString()
                MessageBox.Show("Transaction Successfull", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_withdraw.Text = ""
            Catch ex As MySqlException
                MessageBox.Show("unsuccessful: " & ex.Message)

            Catch ex As Exception
                MessageBox.Show("unsuccessful: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Amount is greater then you current balance", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub WithdrawClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim userDashboard As New Form1(loggedInUserId)
        If result = DialogResult.No Then
            e.Cancel = True
        Else
            userDashboard.Show()
        End If
    End Sub
End Class