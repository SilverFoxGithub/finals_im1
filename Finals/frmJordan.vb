Imports MySql.Data.MySqlClient
Public Class frmJordan
    Dim checkoutForm As frmCheckout
    Private Sub frmJordan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJordanData()
    End Sub
    Private Sub LoadJordanData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM jordan"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim jordanTable As New DataTable()
                    adapter.Fill(jordanTable)
                    dViewJordan.DataSource = jordanTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Jordan data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnJSearch_Click(sender As Object, e As EventArgs) Handles btnJSearch.Click
        SearchJordanData()
    End Sub
    Private Sub btnJClear_Click(sender As Object, e As EventArgs) Handles btnJClear.Click
        ClearJordanInput()
    End Sub
    Private Sub btnJBack_Click(sender As Object, e As EventArgs) Handles btnJBack.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddProductToCheckout()
    End Sub
    Private Sub SearchJordanData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM jordan " &
                                      "WHERE model LIKE @model " &
                                      "AND color LIKE @color " &
                                      "AND size = @size " &
                                      "AND category = @category " &
                                      "AND price = @price"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@model", "%" & txtJModel.Text & "%")
                    cmd.Parameters.AddWithValue("@color", "%" & txtJColor.Text & "%")
                    cmd.Parameters.AddWithValue("@size", cmbSize.SelectedItem)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@price", tBarPrice.Value)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim jordanTable As New DataTable()
                        adapter.Fill(jordanTable)
                        dViewJordan.DataSource = jordanTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching Jordan data: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearJordanInput()
        txtJModel.Clear()
        txtJColor.Clear()
        cmbSize.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        tBarPrice.Value = tBarPrice.Minimum

        LoadJordanData()
    End Sub
    Private Sub AddProductToCheckout()
        If dViewJordan.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dViewJordan.SelectedRows(0).Cells("id").Value)
            Dim productName As String = dViewJordan.SelectedRows(0).Cells("model").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(dViewJordan.SelectedRows(0).Cells("price").Value)

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