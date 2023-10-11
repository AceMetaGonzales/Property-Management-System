<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpences
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
        TxtPayee = New TextBox()
        Panel4 = New Panel()
        CBCategory = New ComboBox()
        Label3 = New Label()
        TxtContactNo = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TxtComment = New TextBox()
        Label13 = New Label()
        Label6 = New Label()
        LblDate = New Label()
        Label11 = New Label()
        BtnGVoucherNo = New FontAwesome.Sharp.IconButton()
        BtnPPreview = New FontAwesome.Sharp.IconButton()
        BtnCancel = New FontAwesome.Sharp.IconButton()
        BtnPrint = New FontAwesome.Sharp.IconButton()
        LblVoucherNo = New Label()
        PanelGVoucher = New Panel()
        Panel4.SuspendLayout()
        PanelGVoucher.SuspendLayout()
        SuspendLayout()
        ' 
        ' TxtPayee
        ' 
        TxtPayee.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtPayee.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtPayee.BackColor = Color.White
        TxtPayee.BorderStyle = BorderStyle.FixedSingle
        TxtPayee.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPayee.Location = New Point(154, 15)
        TxtPayee.Name = "TxtPayee"
        TxtPayee.Size = New Size(243, 26)
        TxtPayee.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(CBCategory)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(TxtContactNo)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(TextBox1)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(TxtPayee)
        Panel4.Controls.Add(TxtComment)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(LblDate)
        Panel4.Controls.Add(Label11)
        Panel4.Location = New Point(272, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(541, 505)
        Panel4.TabIndex = 71
        ' 
        ' CBCategory
        ' 
        CBCategory.DropDownStyle = ComboBoxStyle.DropDownList
        CBCategory.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CBCategory.FormattingEnabled = True
        CBCategory.Location = New Point(154, 242)
        CBCategory.Name = "CBCategory"
        CBCategory.Size = New Size(243, 26)
        CBCategory.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(60, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 16)
        Label3.TabIndex = 76
        Label3.Text = "Category :"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtContactNo
        ' 
        TxtContactNo.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtContactNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtContactNo.BackColor = Color.White
        TxtContactNo.BorderStyle = BorderStyle.FixedSingle
        TxtContactNo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContactNo.Location = New Point(154, 68)
        TxtContactNo.Name = "TxtContactNo"
        TxtContactNo.Size = New Size(243, 26)
        TxtContactNo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(46, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 16)
        Label2.TabIndex = 74
        Label2.Text = "Description :"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(154, 121)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(243, 94)
        TextBox1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(77, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 16)
        Label1.TabIndex = 72
        Label1.Text = "Payee :"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtComment
        ' 
        TxtComment.BackColor = Color.White
        TxtComment.BorderStyle = BorderStyle.FixedSingle
        TxtComment.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtComment.Location = New Point(154, 349)
        TxtComment.Multiline = True
        TxtComment.Name = "TxtComment"
        TxtComment.Size = New Size(243, 94)
        TxtComment.TabIndex = 6
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(56, 350)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 16)
        Label13.TabIndex = 68
        Label13.Text = "Comment :"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(44, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 16)
        Label6.TabIndex = 63
        Label6.Text = "Contact No. :"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblDate
        ' 
        LblDate.BackColor = Color.Gainsboro
        LblDate.BorderStyle = BorderStyle.FixedSingle
        LblDate.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblDate.Location = New Point(154, 295)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(243, 27)
        LblDate.TabIndex = 5
        LblDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(88, 301)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 16)
        Label11.TabIndex = 66
        Label11.Text = "Date :"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnGVoucherNo
        ' 
        BtnGVoucherNo.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnGVoucherNo.FlatAppearance.BorderColor = Color.Black
        BtnGVoucherNo.FlatStyle = FlatStyle.Flat
        BtnGVoucherNo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnGVoucherNo.ForeColor = Color.White
        BtnGVoucherNo.IconChar = FontAwesome.Sharp.IconChar.None
        BtnGVoucherNo.IconColor = Color.White
        BtnGVoucherNo.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnGVoucherNo.IconSize = 30
        BtnGVoucherNo.ImageAlign = ContentAlignment.MiddleLeft
        BtnGVoucherNo.Location = New Point(154, 289)
        BtnGVoucherNo.Name = "BtnGVoucherNo"
        BtnGVoucherNo.Size = New Size(243, 79)
        BtnGVoucherNo.TabIndex = 7
        BtnGVoucherNo.Text = "GENERATE VOUCHER NO."
        BtnGVoucherNo.UseVisualStyleBackColor = False
        ' 
        ' BtnPPreview
        ' 
        BtnPPreview.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnPPreview.FlatAppearance.BorderColor = Color.Black
        BtnPPreview.FlatStyle = FlatStyle.Flat
        BtnPPreview.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPPreview.ForeColor = Color.White
        BtnPPreview.IconChar = FontAwesome.Sharp.IconChar.Receipt
        BtnPPreview.IconColor = Color.White
        BtnPPreview.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPPreview.IconSize = 30
        BtnPPreview.ImageAlign = ContentAlignment.MiddleLeft
        BtnPPreview.Location = New Point(310, 554)
        BtnPPreview.Name = "BtnPPreview"
        BtnPPreview.Padding = New Padding(50, 0, 0, 0)
        BtnPPreview.Size = New Size(224, 49)
        BtnPPreview.TabIndex = 8
        BtnPPreview.Text = "   VOUCHER" & vbCrLf & "   PREVIEW"
        BtnPPreview.TextAlign = ContentAlignment.MiddleLeft
        BtnPPreview.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPPreview.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnCancel.FlatAppearance.BorderColor = Color.Black
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        BtnCancel.IconColor = Color.White
        BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCancel.IconSize = 30
        BtnCancel.ImageAlign = ContentAlignment.MiddleLeft
        BtnCancel.Location = New Point(551, 554)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Padding = New Padding(50, 0, 0, 0)
        BtnCancel.Size = New Size(224, 49)
        BtnCancel.TabIndex = 9
        BtnCancel.Text = "  CANCEL" & vbCrLf & "  CREDIT"
        BtnCancel.TextAlign = ContentAlignment.MiddleLeft
        BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnPrint.FlatAppearance.BorderColor = Color.Black
        BtnPrint.FlatStyle = FlatStyle.Flat
        BtnPrint.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        BtnPrint.IconColor = Color.Black
        BtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPrint.IconSize = 30
        BtnPrint.Location = New Point(310, 619)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Padding = New Padding(75, 0, 0, 0)
        BtnPrint.Size = New Size(465, 49)
        BtnPrint.TabIndex = 10
        BtnPrint.Text = "  CONFIRM CASH-OUT" & vbCrLf
        BtnPrint.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' LblVoucherNo
        ' 
        LblVoucherNo.BackColor = Color.FromArgb(CByte(51), CByte(124), CByte(207))
        LblVoucherNo.BorderStyle = BorderStyle.FixedSingle
        LblVoucherNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblVoucherNo.ForeColor = Color.White
        LblVoucherNo.Location = New Point(272, 9)
        LblVoucherNo.Name = "LblVoucherNo"
        LblVoucherNo.Size = New Size(541, 30)
        LblVoucherNo.TabIndex = 72
        LblVoucherNo.Text = "Voucher No. :"
        LblVoucherNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelGVoucher
        ' 
        PanelGVoucher.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelGVoucher.BorderStyle = BorderStyle.FixedSingle
        PanelGVoucher.Controls.Add(BtnGVoucherNo)
        PanelGVoucher.Location = New Point(272, 9)
        PanelGVoucher.Name = "PanelGVoucher"
        PanelGVoucher.Size = New Size(541, 659)
        PanelGVoucher.TabIndex = 73
        ' 
        ' FrmExpences
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 680)
        Controls.Add(PanelGVoucher)
        Controls.Add(BtnPPreview)
        Controls.Add(LblVoucherNo)
        Controls.Add(BtnCancel)
        Controls.Add(Panel4)
        Controls.Add(BtnPrint)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmExpences"
        Text = "FrmExpences"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        PanelGVoucher.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TxtPayee As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtComment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblVoucherNo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents BtnPPreview As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnGVoucherNo As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents CBCategory As ComboBox
    Friend WithEvents PanelGVoucher As Panel
End Class
