Imports MySql.Data.MySqlClient
Public Class frmVans
    Dim checkoutForm As frmCheckout
    Private Sub frmVans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVansData()
    End Sub
    Private Sub LoadVansData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM vans"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim vansTable As New DataTable()
                    adapter.Fill(vansTable)
                    dViewVans.DataSource = vansTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Vans data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnVSearch_Click(sender As Object, e As EventArgs) Handles btnVSearch.Click
        SearchVansData()
    End Sub
    Private Sub btnVClear_Click(sender As Object, e As EventArgs) Handles btnVClear.Click
        ClearVansInput()
    End Sub
    Private Sub btnVBack_Click(sender As Object, e As EventArgs) Handles btnVBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddProductToCheckout()
    End Sub
    Private Sub SearchVansData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM vans " &
                                      "WHERE model LIKE @model " &
                                      "AND color LIKE @color " &
                                      "AND size = @size " &
                                      "AND category = @category " &
                                      "AND price = @price"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@model", "%" & txtVModel.Text & "%")
                    cmd.Parameters.AddWithValue("@color", "%" & txtVColor.Text & "%")
                    cmd.Parameters.AddWithValue("@size", cmbSize.SelectedItem)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@price", tBarPrice.Value)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim vansTable As New DataTable()
                        adapter.Fill(vansTable)
                        dViewVans.DataSource = vansTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching Vans data: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearVansInput()
        txtVModel.Clear()
        txtVColor.Clear()
        cmbSize.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        tBarPrice.Value = tBarPrice.Minimum

        LoadVansData()
    End Sub
    Private Sub AddProductToCheckout()
        If dViewVans.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dViewVans.SelectedRows(0).Cells("id").Value)
            Dim productName As String = dViewVans.SelectedRows(0).Cells("model").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(dViewVans.SelectedRows(0).Cells("price").Value)

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