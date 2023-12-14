Public Class frmMain

    Private Sub btnNike_Click(sender As Object, e As EventArgs) Handles btnNike.Click
        frmNike.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdidas_Click(sender As Object, e As EventArgs) Handles btnAdidas.Click
        frmAdidas.Show()
        Me.Hide()
    End Sub

    Private Sub btnNewBalance_Click(sender As Object, e As EventArgs) Handles btnNewBalance.Click
        frmNB.Show()
        Me.Hide()
    End Sub

    Private Sub btnJordan_Click(sender As Object, e As EventArgs) Handles btnJordan.Click
        frmJordan.Show()
        Me.Hide()
    End Sub

    Private Sub btnVans_Click(sender As Object, e As EventArgs) Handles btnVans.Click
        frmVans.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        frmCheckout.Show()
        Me.Hide()
    End Sub
End Class
