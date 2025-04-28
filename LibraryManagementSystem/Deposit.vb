Imports MySql.Data.MySqlClient

Public Class Deposit

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
    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btn_deposit_Click(sender As Object, e As EventArgs) Handles btn_deposit.Click
        Dim depositAmount As Decimal = txt_deposit.Text

        If depositAmount >= 100 Then
            Dim prevBalance As Decimal = Currentbalance
            Currentbalance += depositAmount
            Try
                Dim query As String = "INSERT INTO transactions (account_id, amount, transaction_type, date_transacted, previous_balance, current_balance) 
                                    VALUES (@id, @amount, @transaction_type, @date_transacted, @previous_balance, @current_balance)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@id", loggedInUserId)
                cmd.Parameters.AddWithValue("@amount", depositAmount)
                cmd.Parameters.AddWithValue("@transaction_type", "deposit")
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
                txt_deposit.Text = ""
            Catch ex As MySqlException
                MessageBox.Show("unsuccessful: " & ex.Message)

            Catch ex As Exception
                MessageBox.Show("unsuccessful: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Amount does not meet the minimum threshold", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub deposit_formclosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub txt_deposit_TextChanged(sender As Object, e As EventArgs) Handles txt_deposit.TextChanged
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
End Class