Imports MySql.Data.MySqlClient

Public Class frmRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmpass As String = txtConfirm.Text

        If password <> confirmpass Then
            MessageBox.Show("Passwords do not match. Please re-enter.")
            Return
        End If

        Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
            connection.Open()

            Dim query As String = "INSERT INTO register (username, email, password, confirmpass) VALUES (@username, @email, @password, @confirmpass)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@confirmpass", confirmpass)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Registration successful!")
                Else
                    MessageBox.Show("Registration failed. Please try again.")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class