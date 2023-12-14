Imports MySql.Data.MySqlClient
Public Class frmAdidas
    Dim checkoutForm As frmCheckout
    Private Sub frmAdidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAdidasData()
    End Sub
    Private Sub LoadAdidasData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM adidas"
                Using adapter As New MySqlDataAdapter(query, connection)
                    Dim adidasTable As New DataTable()
                    adapter.Fill(adidasTable)
                    dViewAdidas.DataSource = adidasTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading Adidas data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnASearch_Click(sender As Object, e As EventArgs) Handles btnASearch.Click
        SearchAdidasData()
    End Sub
    Private Sub btnAClear_Click(sender As Object, e As EventArgs) Handles btnAClear.Click
        ClearAdidasInput()
    End Sub
    Private Sub btnABack_Click(sender As Object, e As EventArgs) Handles btnABack.Click
        frmMain.Show()
        Me.Close()
    End Sub
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddProductToCheckout()
    End Sub
    Private Sub SearchAdidasData()
        Try
            Using connection As New MySqlConnection(common.getDBConnectionX.ConnectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM adidas " &
                                      "WHERE model LIKE @model " &
                                      "AND color LIKE @color " &
                                      "AND size = @size " &
                                      "AND category = @category " &
                                      "AND price = @price"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@model", "%" & txtAModel.Text & "%")
                    cmd.Parameters.AddWithValue("@color", "%" & txtAColor.Text & "%")
                    cmd.Parameters.AddWithValue("@size", cmbSize.SelectedItem)
                    cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem)
                    cmd.Parameters.AddWithValue("@price", tBarPrice.Value)

                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim adidasTable As New DataTable()
                        adapter.Fill(adidasTable)
                        dViewAdidas.DataSource = adidasTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching Adidas data: " & ex.Message)
        End Try
    End Sub
    Private Sub ClearAdidasInput()
        txtAModel.Clear()
        txtAColor.Clear()
        cmbSize.SelectedIndex = -1
        cmbCategory.SelectedIndex = -1
        tBarPrice.Value = tBarPrice.Minimum

        LoadAdidasData()
    End Sub
    Private Sub AddProductToCheckout()
        If dViewAdidas.SelectedRows.Count > 0 Then
            Dim productID As Integer = Convert.ToInt32(dViewAdidas.SelectedRows(0).Cells("id").Value)
            Dim productName As String = dViewAdidas.SelectedRows(0).Cells("model").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(dViewAdidas.SelectedRows(0).Cells("price").Value)

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