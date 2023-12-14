<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNike
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmNike))
        dViewNike = New DataGridView()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtNColor = New TextBox()
        txtNModel = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btnNBack = New Button()
        btnNSearch = New Button()
        btnNClear = New Button()
        cmbSize = New ComboBox()
        cmbCategory = New ComboBox()
        tBarPrice = New TrackBar()
        lblPrice = New Label()
        btnAddToCart = New Button()
        CType(dViewNike, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dViewNike
        ' 
        dViewNike.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dViewNike.Location = New Point(335, 91)
        dViewNike.Name = "dViewNike"
        dViewNike.RowTemplate.Height = 25
        dViewNike.Size = New Size(442, 268)
        dViewNike.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(30, 328)
        Label8.Name = "Label8"
        Label8.Size = New Size(58, 15)
        Label8.TabIndex = 32
        Label8.Text = "Category:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(30, 275)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 31
        Label7.Text = "Price:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(30, 219)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 30
        Label6.Text = "Color:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(30, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 15)
        Label5.TabIndex = 29
        Label5.Text = "Size:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 28
        Label4.Text = "Model:"
        ' 
        ' txtNColor
        ' 
        txtNColor.Location = New Point(90, 216)
        txtNColor.Name = "txtNColor"
        txtNColor.Size = New Size(199, 23)
        txtNColor.TabIndex = 23
        ' 
        ' txtNModel
        ' 
        txtNModel.Location = New Point(90, 109)
        txtNModel.Name = "txtNModel"
        txtNModel.Size = New Size(199, 23)
        txtNModel.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(144, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 45)
        Label1.TabIndex = 18
        Label1.Text = "Nike Sneakers"
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
        ' btnNBack
        ' 
        btnNBack.Location = New Point(238, 386)
        btnNBack.Name = "btnNBack"
        btnNBack.Size = New Size(75, 23)
        btnNBack.TabIndex = 36
        btnNBack.Text = "Back"
        btnNBack.UseVisualStyleBackColor = True
        ' 
        ' btnNSearch
        ' 
        btnNSearch.Location = New Point(144, 386)
        btnNSearch.Name = "btnNSearch"
        btnNSearch.Size = New Size(75, 23)
        btnNSearch.TabIndex = 35
        btnNSearch.Text = "Search"
        btnNSearch.UseVisualStyleBackColor = True
        ' 
        ' btnNClear
        ' 
        btnNClear.Location = New Point(50, 386)
        btnNClear.Name = "btnNClear"
        btnNClear.Size = New Size(75, 23)
        btnNClear.TabIndex = 34
        btnNClear.Text = "Clear"
        btnNClear.UseVisualStyleBackColor = True
        ' 
        ' cmbSize
        ' 
        cmbSize.FormattingEnabled = True
        cmbSize.Items.AddRange(New Object() {"8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5"})
        cmbSize.Location = New Point(90, 162)
        cmbSize.Name = "cmbSize"
        cmbSize.Size = New Size(147, 23)
        cmbSize.TabIndex = 37
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Casual", "Running", "Basketball", "Skateboarding"})
        cmbCategory.Location = New Point(90, 328)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(147, 23)
        cmbCategory.TabIndex = 38
        ' 
        ' tBarPrice
        ' 
        tBarPrice.Location = New Point(90, 275)
        tBarPrice.Name = "tBarPrice"
        tBarPrice.Size = New Size(147, 45)
        tBarPrice.TabIndex = 39
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(251, 280)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 40
        lblPrice.Text = "Price"
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.Location = New Point(335, 386)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(97, 23)
        btnAddToCart.TabIndex = 41
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = True
        ' 
        ' frmNike
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddToCart)
        Controls.Add(lblPrice)
        Controls.Add(tBarPrice)
        Controls.Add(cmbCategory)
        Controls.Add(cmbSize)
        Controls.Add(btnNBack)
        Controls.Add(btnNSearch)
        Controls.Add(btnNClear)
        Controls.Add(dViewNike)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtNColor)
        Controls.Add(txtNModel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "frmNike"
        Text = "frmNike"
        CType(dViewNike, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(tBarPrice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dViewNike As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNColor As TextBox
    Friend WithEvents txtNModel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNBack As Button
    Friend WithEvents btnNSearch As Button
    Friend WithEvents btnNClear As Button
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents tBarPrice As TrackBar
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnAddToCart As Button
End Class
