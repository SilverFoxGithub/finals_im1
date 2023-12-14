<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdidas
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAdidas))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        lblPrice = New Label()
        tBarPrice = New TrackBar()
        cmbCategory = New ComboBox()
        cmbSize = New ComboBox()
        btnABack = New Button()
        btnASearch = New Button()
        btnAClear = New Button()
        dViewAdidas = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtAColor = New TextBox()
        txtAModel = New TextBox()
        btnAddToCart = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(dViewAdidas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(142, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 45)
        Label1.TabIndex = 1
        Label1.Text = "Adidas Sneakers"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(248, 273)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 55
        lblPrice.Text = "Price"
        ' 
        ' tBarPrice
        ' 
        tBarPrice.Location = New Point(87, 268)
        tBarPrice.Name = "tBarPrice"
        tBarPrice.Size = New Size(147, 45)
        tBarPrice.TabIndex = 54
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Casual", "Running", "Basketball", "Skateboarding"})
        cmbCategory.Location = New Point(87, 321)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(147, 23)
        cmbCategory.TabIndex = 53
        ' 
        ' cmbSize
        ' 
        cmbSize.FormattingEnabled = True
        cmbSize.Items.AddRange(New Object() {"8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5"})
        cmbSize.Location = New Point(87, 155)
        cmbSize.Name = "cmbSize"
        cmbSize.Size = New Size(147, 23)
        cmbSize.TabIndex = 52
        ' 
        ' btnABack
        ' 
        btnABack.Location = New Point(235, 379)
        btnABack.Name = "btnABack"
        btnABack.Size = New Size(75, 23)
        btnABack.TabIndex = 51
        btnABack.Text = "Back"
        btnABack.UseVisualStyleBackColor = True
        ' 
        ' btnASearch
        ' 
        btnASearch.Location = New Point(141, 379)
        btnASearch.Name = "btnASearch"
        btnASearch.Size = New Size(75, 23)
        btnASearch.TabIndex = 50
        btnASearch.Text = "Search"
        btnASearch.UseVisualStyleBackColor = True
        ' 
        ' btnAClear
        ' 
        btnAClear.Location = New Point(47, 379)
        btnAClear.Name = "btnAClear"
        btnAClear.Size = New Size(75, 23)
        btnAClear.TabIndex = 49
        btnAClear.Text = "Clear"
        btnAClear.UseVisualStyleBackColor = True
        ' 
        ' dViewAdidas
        ' 
        dViewAdidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dViewAdidas.Location = New Point(332, 84)
        dViewAdidas.Name = "dViewAdidas"
        dViewAdidas.RowTemplate.Height = 25
        dViewAdidas.Size = New Size(442, 268)
        dViewAdidas.TabIndex = 48
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(27, 321)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 47
        Label8.Text = "Category:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 46
        Label7.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 45
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 44
        Label5.Text = "Size:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 43
        Label4.Text = "Model:"
        ' 
        ' txtAColor
        ' 
        txtAColor.Location = New Point(87, 209)
        txtAColor.Name = "txtAColor"
        txtAColor.Size = New Size(199, 23)
        txtAColor.TabIndex = 42
        ' 
        ' txtAModel
        ' 
        txtAModel.Location = New Point(87, 102)
        txtAModel.Name = "txtAModel"
        txtAModel.Size = New Size(199, 23)
        txtAModel.TabIndex = 41
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(332, 379)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(97, 23)
        btnAddToCart.TabIndex = 56
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' frmAdidas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 443)
        Controls.Add(btnAddToCart)
        Controls.Add(lblPrice)
        Controls.Add(tBarPrice)
        Controls.Add(cmbCategory)
        Controls.Add(cmbSize)
        Controls.Add(btnABack)
        Controls.Add(btnASearch)
        Controls.Add(btnAClear)
        Controls.Add(dViewAdidas)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtAColor)
        Controls.Add(txtAModel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmAdidas"
        Text = "frmAdidas"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(dViewAdidas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents tBarPrice As TrackBar
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents btnABack As Button
    Friend WithEvents btnASearch As Button
    Friend WithEvents btnAClear As Button
    Friend WithEvents dViewAdidas As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAColor As TextBox
    Friend WithEvents txtAModel As TextBox
    Friend WithEvents btnAddToCart As Button
End Class
