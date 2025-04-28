Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class Login
    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            Dim dashboardForm As New AdminDashboard()
            dashboardForm.Show()
            Me.Hide()
        Else
            Try

                Dim query As String = "SELECT * FROM accounts WHERE username = @username and password = @password"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then

                    Dim userId As Integer = reader("account_id")

                    Dim dashboardForm As New Form1(userId)
                    dashboardForm.Show()
                    Me.Hide()
                    reader.Close()
                    MessageBox.Show("Login Successfull", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Wrong Credentials", "Login Error", MessageBoxButtons.RetryCancel)
                End If

            Catch ex As Exception
                MessageBox.Show("unsuccessful: " & ex.Message)
            End Try
        End If

        conn.Close()



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim registerAccountForm As New RegisterForm
        Me.Hide()
        registerAccountForm.Show()
    End Sub

    Private Sub Form_Closed(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("unable to Connect")
        End Try
    End Sub
End Class