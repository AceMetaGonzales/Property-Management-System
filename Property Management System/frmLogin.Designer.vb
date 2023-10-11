<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        txtID = New TextBox()
        PictureBox1 = New PictureBox()
        TxtPW = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        BtnClose = New Button()
        PictureBox2 = New PictureBox()
        PicboxLogo = New PictureBox()
        Panel1 = New Panel()
        btnLogIn = New FontAwesome.Sharp.IconButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicboxLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        txtID.BorderStyle = BorderStyle.None
        txtID.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtID.ForeColor = Color.FromArgb(CByte(33), CByte(53), CByte(85))
        txtID.Location = New Point(496, 203)
        txtID.Name = "txtID"
        txtID.Size = New Size(118, 18)
        txtID.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.username_password_center_box
        PictureBox1.Location = New Point(382, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(323, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' TxtPW
        ' 
        TxtPW.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        TxtPW.BorderStyle = BorderStyle.None
        TxtPW.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPW.ForeColor = Color.FromArgb(CByte(33), CByte(53), CByte(85))
        TxtPW.Location = New Point(496, 251)
        TxtPW.Name = "TxtPW"
        TxtPW.Size = New Size(118, 18)
        TxtPW.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label3.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(33), CByte(53), CByte(85))
        Label3.Location = New Point(496, 276)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 13)
        Label3.TabIndex = 3
        Label3.Text = "Forgot your password?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label4.Location = New Point(409, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(275, 48)
        Label4.TabIndex = 0
        Label4.Text = "USER LOGIN"
        ' 
        ' BtnClose
        ' 
        BtnClose.BackColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnClose.FlatAppearance.BorderSize = 0
        BtnClose.FlatAppearance.MouseDownBackColor = Color.Red
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClose.ForeColor = Color.White
        BtnClose.Location = New Point(742, 0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(28, 29)
        BtnClose.TabIndex = 13
        BtnClose.Text = "x"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.property_management_system_logo
        PictureBox2.Location = New Point(12, 276)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(286, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PicboxLogo
        ' 
        PicboxLogo.Image = My.Resources.Resources.logo
        PicboxLogo.Location = New Point(48, 88)
        PicboxLogo.Name = "PicboxLogo"
        PicboxLogo.Size = New Size(221, 181)
        PicboxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PicboxLogo.TabIndex = 15
        PicboxLogo.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel1.Controls.Add(PicboxLogo)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(315, 481)
        Panel1.TabIndex = 16
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(255), CByte(196), CByte(54))
        btnLogIn.FlatAppearance.BorderColor = Color.White
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogIn.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        btnLogIn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket
        btnLogIn.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        btnLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogIn.IconSize = 40
        btnLogIn.Location = New Point(395, 332)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(297, 45)
        btnLogIn.TabIndex = 0
        btnLogIn.Text = "LOGIN"
        btnLogIn.TextAlign = ContentAlignment.MiddleRight
        btnLogIn.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        ClientSize = New Size(770, 481)
        Controls.Add(btnLogIn)
        Controls.Add(Panel1)
        Controls.Add(BtnClose)
        Controls.Add(Label3)
        Controls.Add(TxtPW)
        Controls.Add(txtID)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PicboxLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtPW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicboxLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogIn As FontAwesome.Sharp.IconButton
End Class
