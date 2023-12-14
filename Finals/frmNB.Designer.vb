<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNB
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmNB))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblPrice = New Label()
        tBarPrice = New TrackBar()
        cmbCategory = New ComboBox()
        cmbSize = New ComboBox()
        btnNBBack = New Button()
        btnNBSearch = New Button()
        btnNBClear = New Button()
        dViewNewBalance = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtNBColor = New TextBox()
        txtNBModel = New TextBox()
        btnAddToCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(dViewNewBalance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(144, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(345, 45)
        Label1.TabIndex = 18
        Label1.Text = "New Balance Sneakers"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(14, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(253, 272)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 70
        lblPrice.Text = "Price"
        ' 
        ' tBarPrice
        ' 
        tBarPrice.Location = New Point(92, 267)
        tBarPrice.Name = "tBarPrice"
        tBarPrice.Size = New Size(147, 45)
        tBarPrice.TabIndex = 69
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Casual", "Running", "Basketball", "Skateboarding"})
        cmbCategory.Location = New Point(92, 320)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(147, 23)
        cmbCategory.TabIndex = 68
        ' 
        ' cmbSize
        ' 
        cmbSize.FormattingEnabled = True
        cmbSize.Items.AddRange(New Object() {"8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5"})
        cmbSize.Location = New Point(92, 154)
        cmbSize.Name = "cmbSize"
        cmbSize.Size = New Size(147, 23)
        cmbSize.TabIndex = 67
        ' 
        ' btnNBBack
        ' 
        btnNBBack.Location = New Point(240, 378)
        btnNBBack.Name = "btnNBBack"
        btnNBBack.Size = New Size(75, 23)
        btnNBBack.TabIndex = 66
        btnNBBack.Text = "Back"
        btnNBBack.UseVisualStyleBackColor = True
        ' 
        ' btnNBSearch
        ' 
        btnNBSearch.Location = New Point(146, 378)
        btnNBSearch.Name = "btnNBSearch"
        btnNBSearch.Size = New Size(75, 23)
        btnNBSearch.TabIndex = 65
        btnNBSearch.Text = "Search"
        btnNBSearch.UseVisualStyleBackColor = True
        ' 
        ' btnNBClear
        ' 
        btnNBClear.Location = New Point(52, 378)
        btnNBClear.Name = "btnNBClear"
        btnNBClear.Size = New Size(75, 23)
        btnNBClear.TabIndex = 64
        btnNBClear.Text = "Clear"
        btnNBClear.UseVisualStyleBackColor = True
        ' 
        ' dViewNewBalance
        ' 
        dViewNewBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dViewNewBalance.Location = New Point(337, 83)
        dViewNewBalance.Name = "dViewNewBalance"
        dViewNewBalance.RowTemplate.Height = 25
        dViewNewBalance.Size = New Size(442, 268)
        dViewNewBalance.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(32, 320)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 62
        Label8.Text = "Category:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(32, 267)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 61
        Label7.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 211)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 60
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 59
        Label5.Text = "Size:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 58
        Label4.Text = "Model:"
        ' 
        ' txtNBColor
        ' 
        txtNBColor.Location = New Point(92, 208)
        txtNBColor.Name = "txtNBColor"
        txtNBColor.Size = New Size(199, 23)
        txtNBColor.TabIndex = 57
        ' 
        ' txtNBModel
        ' 
        txtNBModel.Location = New Point(92, 101)
        txtNBModel.Name = "txtNBModel"
        txtNBModel.Size = New Size(199, 23)
        txtNBModel.TabIndex = 56
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(337, 378)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(97, 23)
        btnAddToCart.TabIndex = 71
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' frmNB
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddToCart)
        Controls.Add(lblPrice)
        Controls.Add(tBarPrice)
        Controls.Add(cmbCategory)
        Controls.Add(cmbSize)
        Controls.Add(btnNBBack)
        Controls.Add(btnNBSearch)
        Controls.Add(btnNBClear)
        Controls.Add(dViewNewBalance)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNBColor)
        Controls.Add(txtNBModel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmNB"
        Text = "New Balance"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(dViewNewBalance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents tBarPrice As TrackBar
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents btnNBBack As Button
    Friend WithEvents btnNBSearch As Button
    Friend WithEvents btnNBClear As Button
    Friend WithEvents dViewNewBalance As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNBColor As TextBox
    Friend WithEvents txtNBModel As TextBox
    Friend WithEvents btnAddToCart As Button
End Class
