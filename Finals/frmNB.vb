Imports MySql.Data.MySqlClient
Public Class frmNB
    Dim checkoutForm As frmCheckout
    Private Sub frmNB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNewBalanceData()
    End Sub
    Private Sub LoadNewBalanceData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM new_balance"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim newbalanceTable As New DataTable()
                    adapter.Fill(newbalanceTable)
                    dViewNewBalance.DataSource = newbalanceTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading New Balance data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnNBSearch_Click(sender As Object, e As EventArgs) Handles btnNBSearch.Click
        SearchNewBalanceData()
    End Sub
    Private Sub btnNBClear_Click(sender As Object, e As EventArgs) Handles btnNBClear.Click
        ClearNewBalanceInput()
    End Sub
    Private Sub btnNBBack_Click(sender As Object, e As EventArgs) Handles btnNBBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddProductToCheckout()
    End Sub
    Private Sub SearchNewBalanceData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM new_balance " &
                                      "WHERE model LIKE @model " &
                                      "AND color LIKE @color " &
                                      "AND size = @size " &
                                      "AND category = @category " &
                                      "AND price = @price"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@model", "%" & txtNBModel.Text & "%")
                    cmd.Parameters.AddWithValue("@color", "%" & txtNBColor.Text & "%")
                    cmd.Parameters.AddWithValue("@size", cmbSize.SelectedItem)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@price", tBarPrice.Value)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim newbalanceTable As New DataTable()
                        adapter.Fill(newbalanceTable)
                        dViewNewBalance.DataSource = newbalanceTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching New Balance data: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearNewBalanceInput()
        txtNBModel.Clear()
        txtNBColor.Clear()
        cmbSize.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        tBarPrice.Value = tBarPrice.Minimum

        LoadNewBalanceData()
    End Sub
    Private Sub AddProductToCheckout()
        If dViewNewBalance.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dViewNewBalance.SelectedRows(0).Cells("id").Value)
            Dim productName As String = dViewNewBalance.SelectedRows(0).Cells("model").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(dViewNewBalance.SelectedRows(0).Cells("price").Value)

            If checkoutForm Is Nothing OrElse checkoutForm.IsDisposed Then
                checkoutForm = New frmCheckout()
            End If

            checkoutForm.AddProductToCart(productID, productName, price)

            If Not checkoutForm.Visible Then
                checkoutForm.Show()
            End If
        Else
            MessageBox.Show("Please select a product before adding to the cart.")
        End If
    End Sub
End Class