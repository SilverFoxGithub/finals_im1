Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If

        AuthenticateUser(username, password)
    End Sub

    Private Sub AuthenticateUser(username As String, password As String)
        Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
            connection.Open()

            Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        MessageBox.Show("Login successful!")
                        frmMain.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs)
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
End Class