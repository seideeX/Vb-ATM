Imports MySql.Data.MySqlClient


Public Class RegisterForm
    Dim connStr As String = "server=localhost;userid=root;password='';database=test_db"
    Dim conn As New MySqlConnection(connStr)
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("unable to Connect")
        End Try
    End Sub

    Private Sub CloseForm(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim loginForm As New Login()
        Dim result As New DialogResult
        result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then
            e.Cancel = True
        Else
            loginForm.Show()
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim gender As String

        gender = ""
        If rbMale.Checked Then
            gender = "male"
        ElseIf rbFemale.Checked Then
            gender = "female"
        Else
            gender = "other"
        End If

        Dim fields As Object = {txt_lastname, txt_firstname, txt_middlename, txt_email, txt_address, txt_phone, txt_accnumber, cmb_acctype}

        Dim fieldComplete As Boolean
        fieldComplete = True

        For i As Integer = 0 To fields.length - 1
            If fields(i).Text = "" Or gender = "" Then
                fieldComplete = False
                Exit For
            End If
        Next

        If fieldComplete = False Then
            MessageBox.Show("Please Fill out all Fields", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim query As String = "INSERT INTO owners (firstname, middlename, lastname, sex, email, address, phone_number) 
                                    VALUES(@firstname, @middlename, @lastname, @sex, @email, @address, @phone_number)"
                Dim cmd As New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
                cmd.Parameters.AddWithValue("@middlename", txt_middlename.Text)
                cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
                cmd.Parameters.AddWithValue("@email", txt_email.Text)
                cmd.Parameters.AddWithValue("@address", txt_address.Text)
                cmd.Parameters.AddWithValue("@phone_number", txt_phone.Text)
                cmd.Parameters.AddWithValue("@sex", gender)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                MessageBox.Show("Data Successfully Added!")
            Catch ex As Exception
                MessageBox.Show("unsuccessfull: " & ex.Message)
            End Try

        End If

    End Sub
End Class