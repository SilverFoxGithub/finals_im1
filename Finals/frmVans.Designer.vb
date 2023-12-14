<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVans
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmVans))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        lblPrice = New Label()
        tBarPrice = New TrackBar()
        cmbCategory = New ComboBox()
        cmbSize = New ComboBox()
        btnVBack = New Button()
        btnVSearch = New Button()
        btnVClear = New Button()
        dViewVans = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtVColor = New TextBox()
        txtVModel = New TextBox()
        btnAddToCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(dViewVans, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(146, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 45)
        Label1.TabIndex = 18
        Label1.Text = "Vans Sneakers"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(16, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(250, 273)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 70
        lblPrice.Text = "Price"
        ' 
        ' tBarPrice
        ' 
        tBarPrice.Location = New Point(89, 268)
        tBarPrice.Name = "tBarPrice"
        tBarPrice.Size = New Size(147, 45)
        tBarPrice.TabIndex = 69
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Casual", "Running", "Basketball", "Skateboarding"})
        cmbCategory.Location = New Point(89, 321)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(147, 23)
        cmbCategory.TabIndex = 68
        ' 
        ' cmbSize
        ' 
        cmbSize.FormattingEnabled = True
        cmbSize.Items.AddRange(New Object() {"8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5"})
        cmbSize.Location = New Point(89, 155)
        cmbSize.Name = "cmbSize"
        cmbSize.Size = New Size(147, 23)
        cmbSize.TabIndex = 67
        ' 
        ' btnVBack
        ' 
        btnVBack.Location = New Point(237, 379)
        btnVBack.Name = "btnVBack"
        btnVBack.Size = New Size(75, 23)
        btnVBack.TabIndex = 66
        btnVBack.Text = "Back"
        btnVBack.UseVisualStyleBackColor = True
        ' 
        ' btnVSearch
        ' 
        btnVSearch.Location = New Point(143, 379)
        btnVSearch.Name = "btnVSearch"
        btnVSearch.Size = New Size(75, 23)
        btnVSearch.TabIndex = 65
        btnVSearch.Text = "Search"
        btnVSearch.UseVisualStyleBackColor = True
        ' 
        ' btnVClear
        ' 
        btnVClear.Location = New Point(49, 379)
        btnVClear.Name = "btnVClear"
        btnVClear.Size = New Size(75, 23)
        btnVClear.TabIndex = 64
        btnVClear.Text = "Clear"
        btnVClear.UseVisualStyleBackColor = True
        ' 
        ' dViewVans
        ' 
        dViewVans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dViewVans.Location = New Point(334, 84)
        dViewVans.Name = "dViewVans"
        dViewVans.RowTemplate.Height = 25
        dViewVans.Size = New Size(442, 268)
        dViewVans.TabIndex = 63
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(29, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 62
        Label8.Text = "Category:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 61
        Label7.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(29, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 60
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 59
        Label5.Text = "Size:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 58
        Label4.Text = "Model:"
        ' 
        ' txtVColor
        ' 
        txtVColor.Location = New Point(89, 209)
        txtVColor.Name = "txtVColor"
        txtVColor.Size = New Size(199, 23)
        txtVColor.TabIndex = 57
        ' 
        ' txtVModel
        ' 
        txtVModel.Location = New Point(89, 102)
        txtVModel.Name = "txtVModel"
        txtVModel.Size = New Size(199, 23)
        txtVModel.TabIndex = 56
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(334, 379)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(97, 23)
        btnAddToCart.TabIndex = 71
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' frmVans
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddToCart)
        Controls.Add(lblPrice)
        Controls.Add(tBarPrice)
        Controls.Add(cmbCategory)
        Controls.Add(cmbSize)
        Controls.Add(btnVBack)
        Controls.Add(btnVSearch)
        Controls.Add(btnVClear)
        Controls.Add(dViewVans)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtVColor)
        Controls.Add(txtVModel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmVans"
        Text = "Vans"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(dViewVans, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents tBarPrice As TrackBar
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents btnVBack As Button
    Friend WithEvents btnVSearch As Button
    Friend WithEvents btnVClear As Button
    Friend WithEvents dViewVans As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVColor As TextBox
    Friend WithEvents txtVModel As TextBox
    Friend WithEvents btnAddToCart As Button
End Class
