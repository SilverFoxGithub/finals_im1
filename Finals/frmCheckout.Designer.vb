<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmCheckout))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnCheckout = New Button()
        btnCancel = New Button()
        DataGridView1 = New DataGridView()
        cmbPayment = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        cmbShipping = New ComboBox()
        txtSpecialInstructions = New TextBox()
        Label4 = New Label()
        grpbxOrder = New GroupBox()
        txtProduct = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtProductID = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sacred Hertz Straight", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(96, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 34)
        Label1.TabIndex = 0
        Label1.Text = "Check Out"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(78, 69)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Location = New Point(345, 577)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(100, 23)
        btnCheckout.TabIndex = 2
        btnCheckout.Text = "Place Order"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(464, 577)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(345, 55)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(443, 506)
        DataGridView1.TabIndex = 4
        ' 
        ' cmbPayment
        ' 
        cmbPayment.FormattingEnabled = True
        cmbPayment.Items.AddRange(New Object() {"Bank Transfer", "Over-the-Counter", "Cash on Delivery"})
        cmbPayment.Location = New Point(24, 234)
        cmbPayment.Name = "cmbPayment"
        cmbPayment.Size = New Size(280, 23)
        cmbPayment.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 216)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 15)
        Label2.TabIndex = 6
        Label2.Text = "Select Payment Method:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 8
        Label3.Text = "Delivery Option:"
        ' 
        ' cmbShipping
        ' 
        cmbShipping.FormattingEnabled = True
        cmbShipping.Items.AddRange(New Object() {"Standard Delivery", "Fast Shipping", "Pick-up Delivery"})
        cmbShipping.Location = New Point(24, 283)
        cmbShipping.Name = "cmbShipping"
        cmbShipping.Size = New Size(280, 23)
        cmbShipping.TabIndex = 7
        ' 
        ' txtSpecialInstructions
        ' 
        txtSpecialInstructions.Location = New Point(24, 332)
        txtSpecialInstructions.Multiline = True
        txtSpecialInstructions.Name = "txtSpecialInstructions"
        txtSpecialInstructions.Size = New Size(280, 101)
        txtSpecialInstructions.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(24, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 15)
        Label4.TabIndex = 10
        Label4.Text = "Special Instructions:"
        ' 
        ' grpbxOrder
        ' 
        grpbxOrder.Location = New Point(24, 439)
        grpbxOrder.Name = "grpbxOrder"
        grpbxOrder.Size = New Size(280, 161)
        grpbxOrder.TabIndex = 11
        grpbxOrder.TabStop = False
        grpbxOrder.Text = "Order Details"
        ' 
        ' txtProduct
        ' 
        txtProduct.Location = New Point(24, 120)
        txtProduct.Name = "txtProduct"
        txtProduct.Size = New Size(279, 23)
        txtProduct.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 102)
        Label5.Name = "Label5"
        Label5.Size = New Size(87, 15)
        Label5.TabIndex = 13
        Label5.Text = "Product Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 15
        Label6.Text = "Product ID:"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(24, 174)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(279, 23)
        txtProductID.TabIndex = 14
        ' 
        ' frmCheckout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 612)
        Controls.Add(Label6)
        Controls.Add(txtProductID)
        Controls.Add(Label5)
        Controls.Add(txtProduct)
        Controls.Add(grpbxOrder)
        Controls.Add(Label4)
        Controls.Add(txtSpecialInstructions)
        Controls.Add(Label3)
        Controls.Add(cmbShipping)
        Controls.Add(Label2)
        Controls.Add(cmbPayment)
        Controls.Add(DataGridView1)
        Controls.Add(btnCancel)
        Controls.Add(btnCheckout)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "frmCheckout"
        Text = "Check Out"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbShipping As ComboBox
    Friend WithEvents txtSpecialInstructions As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpbxOrder As GroupBox
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProductID As TextBox
End Class
