<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJordan
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmJordan))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblPrice = New Label()
        tBarPrice = New TrackBar()
        cmbCategory = New ComboBox()
        cmbSize = New ComboBox()
        btnJBack = New Button()
        btnJSearch = New Button()
        btnJClear = New Button()
        dViewJordan = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtJColor = New TextBox()
        txtJModel = New TextBox()
        btnAddToCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(dViewJordan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(146, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 45)
        Label1.TabIndex = 18
        Label1.Text = "Jordan Sneakers"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(253, 273)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 85
        lblPrice.Text = "Price"
        ' 
        ' tBarPrice
        ' 
        tBarPrice.Location = New Point(92, 268)
        tBarPrice.Name = "tBarPrice"
        tBarPrice.Size = New Size(147, 45)
        tBarPrice.TabIndex = 84
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Casual", "Running", "Basketball", "Skateboarding"})
        cmbCategory.Location = New Point(92, 321)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(147, 23)
        cmbCategory.TabIndex = 83
        ' 
        ' cmbSize
        ' 
        cmbSize.FormattingEnabled = True
        cmbSize.Items.AddRange(New Object() {"8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5"})
        cmbSize.Location = New Point(92, 155)
        cmbSize.Name = "cmbSize"
        cmbSize.Size = New Size(147, 23)
        cmbSize.TabIndex = 82
        ' 
        ' btnJBack
        ' 
        btnJBack.Location = New Point(240, 379)
        btnJBack.Name = "btnJBack"
        btnJBack.Size = New Size(75, 23)
        btnJBack.TabIndex = 81
        btnJBack.Text = "Back"
        btnJBack.UseVisualStyleBackColor = True
        ' 
        ' btnJSearch
        ' 
        btnJSearch.Location = New Point(146, 379)
        btnJSearch.Name = "btnJSearch"
        btnJSearch.Size = New Size(75, 23)
        btnJSearch.TabIndex = 80
        btnJSearch.Text = "Search"
        btnJSearch.UseVisualStyleBackColor = True
        ' 
        ' btnJClear
        ' 
        btnJClear.Location = New Point(52, 379)
        btnJClear.Name = "btnJClear"
        btnJClear.Size = New Size(75, 23)
        btnJClear.TabIndex = 79
        btnJClear.Text = "Clear"
        btnJClear.UseVisualStyleBackColor = True
        ' 
        ' dViewJordan
        ' 
        dViewJordan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dViewJordan.Location = New Point(337, 84)
        dViewJordan.Name = "dViewJordan"
        dViewJordan.RowTemplate.Height = 25
        dViewJordan.Size = New Size(442, 268)
        dViewJordan.TabIndex = 78
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(32, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 77
        Label8.Text = "Category:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(32, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 76
        Label7.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(32, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 75
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 74
        Label5.Text = "Size:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(32, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 73
        Label4.Text = "Model:"
        ' 
        ' txtJColor
        ' 
        txtJColor.Location = New Point(92, 209)
        txtJColor.Name = "txtJColor"
        txtJColor.Size = New Size(199, 23)
        txtJColor.TabIndex = 72
        ' 
        ' txtJModel
        ' 
        txtJModel.Location = New Point(92, 102)
        txtJModel.Name = "txtJModel"
        txtJModel.Size = New Size(199, 23)
        txtJModel.TabIndex = 71
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(337, 379)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(97, 23)
        btnAddToCart.TabIndex = 86
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' frmJordan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddToCart)
        Controls.Add(lblPrice)
        Controls.Add(tBarPrice)
        Controls.Add(cmbCategory)
        Controls.Add(cmbSize)
        Controls.Add(btnJBack)
        Controls.Add(btnJSearch)
        Controls.Add(btnJClear)
        Controls.Add(dViewJordan)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtJColor)
        Controls.Add(txtJModel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmJordan"
        Text = "frmJordan"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(dViewJordan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents tBarPrice As TrackBar
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents btnJBack As Button
    Friend WithEvents btnJSearch As Button
    Friend WithEvents btnJClear As Button
    Friend WithEvents dViewJordan As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJColor As TextBox
    Friend WithEvents txtJModel As TextBox
    Friend WithEvents btnAddToCart As Button
End Class
