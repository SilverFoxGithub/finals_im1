<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Label2 = New Label()
        Label1 = New Label()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        txtConfirm = New TextBox()
        Label4 = New Label()
        txtPassword = New TextBox()
        btnRegister = New Button()
        PictureBox2 = New PictureBox()
        btnCancel = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(321, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 12
        Label2.Text = "E-mail:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(321, 180)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 11
        Label1.Text = "Username:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(321, 258)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(275, 23)
        txtEmail.TabIndex = 10
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(321, 198)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(275, 23)
        txtUsername.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(337, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(244, 115)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(321, 379)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 14
        Label3.Text = "Confirm Password:"
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(321, 397)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(275, 23)
        txtConfirm.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(321, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 16
        Label4.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(321, 326)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(275, 23)
        txtPassword.TabIndex = 15
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(374, 449)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(75, 23)
        btnRegister.TabIndex = 17
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(-1, -1)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(286, 499)
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(475, 449)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 23)
        btnCancel.TabIndex = 19
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 497)
        Controls.Add(btnCancel)
        Controls.Add(PictureBox2)
        Controls.Add(btnRegister)
        Controls.Add(Label4)
        Controls.Add(txtPassword)
        Controls.Add(Label3)
        Controls.Add(txtConfirm)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        Controls.Add(PictureBox1)
        Name = "frmRegister"
        Text = "Register"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCancel As Button
End Class
