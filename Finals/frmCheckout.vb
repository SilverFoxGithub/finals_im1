Imports MySql.Data.MySqlClient

Public Class frmCheckout
    Private selectedProducts As New List(Of Product)()
    Private Class Product
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property Price As Decimal
    End Class
    Public Class Order
        Public Property Product As String
        Public Property ProductDetails As String
        Public Property PaymentMethod As String
        Public Property ShippingMethod As String
        Public Property SpecialInstructions As String
    End Class

    Public Sub AddProductToCart(productID As Integer, productName As String, price As Decimal)
        Dim newProduct As New Product() With {
            .ProductID = productID,
            .ProductName = productName,
            .Price = price
        }

        selectedProducts.Add(newProduct)

        UpdateSelectedProductsDataGridView()
    End Sub

    Private Sub UpdateSelectedProductsDataGridView()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = selectedProducts
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim newOrder As New Order With {
            .Product = txtProduct.Text(),
            .ProductDetails = txtProductID.Text(),
            .PaymentMethod = cmbPayment.SelectedItem.ToString(),
            .ShippingMethod = cmbShipping.SelectedItem.ToString(),
            .SpecialInstructions = txtSpecialInstructions.Text
        }

        InsertOrderIntoDatabase(newOrder)

        selectedProducts.Clear()
        UpdateSelectedProductsDataGridView()

        Me.Close()
    End Sub

    Private Sub InsertOrderIntoDatabase(order As Order)
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO orders (product, productdetails, shipping, payment, comment) " &
                                      "VALUES (@product, @productdetails, @shipping, @payment, @comment)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@product", order.Product)
                    cmd.Parameters.AddWithValue("@productdetails", order.ProductDetails)
                    cmd.Parameters.AddWithValue("@shipping", order.ShippingMethod)
                    cmd.Parameters.AddWithValue("@payment", order.PaymentMethod)
                    cmd.Parameters.AddWithValue("@comment", order.SpecialInstructions)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Order placed successfully!")
        Catch ex As Exception
            MessageBox.Show("Error placing the order: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmMain.Show()
        Me.Close()
    End Sub
End Class