Imports MySql.Data.MySqlClient

Public Class EditAccount
    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)

    Private loggedInUserId As Integer

    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loggedInUserId = userId
    End Sub
    Private Sub EditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim query As String = "SELECT * FROM accounts as a INNER JOIN owners as o ON a.owner_id = o.owner_id WHERE account_id = @id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", loggedInUserId)
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txt_firstname.Text = reader("firstname").ToString()
                txt_middlename.Text = reader("middlename").ToString()
                txt_lastname.Text = reader("lastname").ToString()
                txt_address.Text = reader("address").ToString()
                txt_email.Text = reader("email").ToString()
                txt_phone.Text = reader("phone_number").ToString()
                txt_accnumber.Text = reader("account_number").ToString()
                txt_acctype.Text = reader("account_type").ToString()

                If reader("sex").ToString() = "male" Then
                    rbMale.Checked = True

                ElseIf reader("sex").ToString() = "female" Then
                    rbFemale.Checked = True
                Else
                    rbOther.Checked = True
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub


    Private Sub UpdateAccount(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim query As String = "SELECT owner_id FROM accounts WHERE account_id = @id"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@id", loggedInUserId)

            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim owner_id As Integer = Convert.ToInt32(reader("owner_id"))
                reader.Close()
                Dim query2 As String = "UPDATE owners SET firstname = @firstname, 
                                    lastname = @lastname, middlename = @middlename, address  = @address, 
                                    email = @email, phone_number = @phone, sex = @sex WHERE owner_id = @owner_id"
                Dim cmd2 As New MySqlCommand(query2, conn)

                cmd2.Parameters.AddWithValue("@owner_id", owner_id)
                cmd2.Parameters.AddWithValue("@firstname", txt_firstname.Text)
                cmd2.Parameters.AddWithValue("@lastname", txt_lastname.Text)
                cmd2.Parameters.AddWithValue("@middlename", txt_middlename.Text)
                cmd2.Parameters.AddWithValue("@address", txt_address.Text)
                cmd2.Parameters.AddWithValue("@email", txt_email.Text)
                cmd2.Parameters.AddWithValue("@phone", txt_phone.Text)
                Dim gender As String
                gender = ""
                If rbMale.Checked Then
                    gender = "male"
                ElseIf rbFemale.Checked Then
                    gender = "female"
                Else
                    gender = "other"
                End If
                cmd2.Parameters.AddWithValue("@sex", gender)

                cmd2.ExecuteNonQuery()
                MessageBox.Show("Record Updated Successfully")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        conn.Close()
    End Sub
End Class