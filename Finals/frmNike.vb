Imports MySql.Data.MySqlClient
Public Class frmNike
    Dim checkoutForm As frmCheckout

    Private Sub frmNike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNikeData()
    End Sub
    Private Sub LoadNikeData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM nike"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim nikeTable As New DataTable()
                    adapter.Fill(nikeTable)
                    dViewNike.DataSource = nikeTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Nike data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnNSearch_Click(sender As Object, e As EventArgs) Handles btnNSearch.Click
        SearchNikeData()
    End Sub
    Private Sub btnNClear_Click(sender As Object, e As EventArgs) Handles btnNClear.Click
        ClearNikeInput()
    End Sub
    Private Sub btnNBack_Click(sender As Object, e As EventArgs) Handles btnNBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddProductToCheckout()
    End Sub
    Private Sub SearchNikeData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM nike " &
                                      "WHERE model LIKE @model " &
                                      "AND color LIKE @color " &
                                      "AND size = @size " &
                                      "AND category = @category " &
                                      "AND price = @price"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@model", "%" & txtNModel.Text & "%")
                    cmd.Parameters.AddWithValue("@color", "%" & txtNColor.Text & "%")
                    cmd.Parameters.AddWithValue("@size", cmbSize.SelectedItem)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@price", tBarPrice.Value)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim nikeTable As New DataTable()
                        adapter.Fill(nikeTable)
                        dViewNike.DataSource = nikeTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching Nike data: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearNikeInput()
        txtNModel.Clear()
        txtNColor.Clear()
        cmbSize.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        tBarPrice.Value = tBarPrice.Minimum

        LoadNikeData()
    End Sub
    Private Sub AddProductToCheckout()
        If dViewNike.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dViewNike.SelectedRows(0).Cells("id").Value)
            Dim productName As String = dViewNike.SelectedRows(0).Cells("model").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(dViewNike.SelectedRows(0).Cells("price").Value)

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
