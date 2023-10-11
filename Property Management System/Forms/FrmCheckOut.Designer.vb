<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCheckOut
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnPrint = New FontAwesome.Sharp.IconButton()
        txtReceiptNo = New TextBox()
        Panel1 = New Panel()
        CBBHousekeeping = New ComboBox()
        Label5 = New Label()
        Label38 = New Label()
        CbbCheckby = New ComboBox()
        Label4 = New Label()
        Label37 = New Label()
        Label10 = New Label()
        LblCurrentUser = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TxtODeduction = New TextBox()
        LblTransactionNo = New Label()
        Panel2 = New Panel()
        Label36 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        LblGTotal = New Label()
        Label1 = New Label()
        CBBPMethod = New ComboBox()
        Label14 = New Label()
        BtnCancel = New FontAwesome.Sharp.IconButton()
        BtnPPreview = New FontAwesome.Sharp.IconButton()
        Label6 = New Label()
        PanelCash = New Panel()
        BtnClear = New Button()
        TxtCash = New TextBox()
        Label13 = New Label()
        Label29 = New Label()
        LblChange = New Label()
        Button1 = New Button()
        Label16 = New Label()
        Btn0 = New Button()
        Btn1 = New Button()
        Btn2 = New Button()
        Btn3 = New Button()
        Btn9 = New Button()
        Btn4 = New Button()
        Btn8 = New Button()
        Btn5 = New Button()
        Btn7 = New Button()
        Btn6 = New Button()
        PanelGcash = New Panel()
        Label35 = New Label()
        Label39 = New Label()
        TxtRefNo = New TextBox()
        PictureBox1 = New PictureBox()
        PanelTitlebar = New Panel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        PanelCash.SuspendLayout()
        PanelGcash.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitlebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnPrint.FlatStyle = FlatStyle.Popup
        BtnPrint.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        BtnPrint.IconColor = Color.Black
        BtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPrint.IconSize = 30
        BtnPrint.ImageAlign = ContentAlignment.MiddleLeft
        BtnPrint.Location = New Point(14, 530)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Padding = New Padding(35, 0, 0, 0)
        BtnPrint.Size = New Size(237, 49)
        BtnPrint.TabIndex = 7
        BtnPrint.Text = "   CONFIRM" & vbCrLf & "   CHECK-OUT"
        BtnPrint.TextAlign = ContentAlignment.MiddleLeft
        BtnPrint.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' txtReceiptNo
        ' 
        txtReceiptNo.BorderStyle = BorderStyle.FixedSingle
        txtReceiptNo.Font = New Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtReceiptNo.Location = New Point(8, 34)
        txtReceiptNo.Multiline = True
        txtReceiptNo.Name = "txtReceiptNo"
        txtReceiptNo.Size = New Size(226, 29)
        txtReceiptNo.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CBBHousekeeping)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label38)
        Panel1.Controls.Add(CbbCheckby)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label37)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(LblCurrentUser)
        Panel1.Location = New Point(8, 149)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(249, 197)
        Panel1.TabIndex = 40
        ' 
        ' CBBHousekeeping
        ' 
        CBBHousekeeping.BackColor = Color.White
        CBBHousekeeping.DropDownStyle = ComboBoxStyle.DropDownList
        CBBHousekeeping.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CBBHousekeeping.FormattingEnabled = True
        CBBHousekeeping.Location = New Point(7, 150)
        CBBHousekeeping.MaxDropDownItems = 5
        CBBHousekeeping.Name = "CBBHousekeeping"
        CBBHousekeeping.Size = New Size(228, 22)
        CBBHousekeeping.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(10, 133)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 14)
        Label5.TabIndex = 94
        Label5.Text = "Assigned for housekeeping :"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label38.ForeColor = Color.Red
        Label38.Location = New Point(3, 133)
        Label38.Name = "Label38"
        Label38.Size = New Size(11, 14)
        Label38.TabIndex = 98
        Label38.Text = "*"
        Label38.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CbbCheckby
        ' 
        CbbCheckby.BackColor = Color.White
        CbbCheckby.DropDownStyle = ComboBoxStyle.DropDownList
        CbbCheckby.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CbbCheckby.FormattingEnabled = True
        CbbCheckby.Location = New Point(7, 91)
        CbbCheckby.MaxDropDownItems = 5
        CbbCheckby.Name = "CbbCheckby"
        CbbCheckby.Size = New Size(228, 22)
        CbbCheckby.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(11, 74)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 14)
        Label4.TabIndex = 90
        Label4.Text = "Check by :"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label37.ForeColor = Color.Red
        Label37.Location = New Point(4, 74)
        Label37.Name = "Label37"
        Label37.Size = New Size(11, 14)
        Label37.TabIndex = 97
        Label37.Text = "*"
        Label37.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(7, 16)
        Label10.Name = "Label10"
        Label10.Size = New Size(76, 14)
        Label10.TabIndex = 95
        Label10.Text = "Transact by :"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblCurrentUser
        ' 
        LblCurrentUser.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        LblCurrentUser.FlatStyle = FlatStyle.Flat
        LblCurrentUser.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblCurrentUser.ForeColor = Color.Black
        LblCurrentUser.Location = New Point(7, 33)
        LblCurrentUser.Name = "LblCurrentUser"
        LblCurrentUser.Size = New Size(228, 22)
        LblCurrentUser.TabIndex = 3
        LblCurrentUser.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(7, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 14)
        Label3.TabIndex = 89
        Label3.Text = "Enter Other Deduction(₱):"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(13, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 16)
        Label2.TabIndex = 88
        Label2.Text = "Enter Invoice No.:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtODeduction
        ' 
        TxtODeduction.BorderStyle = BorderStyle.FixedSingle
        TxtODeduction.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TxtODeduction.Location = New Point(9, 26)
        TxtODeduction.Multiline = True
        TxtODeduction.Name = "TxtODeduction"
        TxtODeduction.Size = New Size(225, 22)
        TxtODeduction.TabIndex = 4
        ' 
        ' LblTransactionNo
        ' 
        LblTransactionNo.AutoSize = True
        LblTransactionNo.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblTransactionNo.ForeColor = Color.Black
        LblTransactionNo.Location = New Point(127, 33)
        LblTransactionNo.Name = "LblTransactionNo"
        LblTransactionNo.Size = New Size(17, 18)
        LblTransactionNo.TabIndex = 55
        LblTransactionNo.Text = "1"
        LblTransactionNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txtReceiptNo)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label36)
        Panel2.Location = New Point(8, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(249, 87)
        Panel2.TabIndex = 54
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label36.ForeColor = Color.Red
        Label36.Location = New Point(5, 12)
        Label36.Name = "Label36"
        Label36.Size = New Size(11, 14)
        Label36.TabIndex = 97
        Label36.Text = "*"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(TxtODeduction)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(8, 351)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(249, 58)
        Panel5.TabIndex = 55
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(LblGTotal)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(CBBPMethod)
        Panel4.Controls.Add(Label14)
        Panel4.Location = New Point(262, 56)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(249, 151)
        Panel4.TabIndex = 92
        ' 
        ' LblGTotal
        ' 
        LblGTotal.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        LblGTotal.FlatStyle = FlatStyle.Flat
        LblGTotal.Font = New Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblGTotal.ForeColor = Color.Black
        LblGTotal.Location = New Point(10, 39)
        LblGTotal.Name = "LblGTotal"
        LblGTotal.Size = New Size(228, 39)
        LblGTotal.TabIndex = 99
        LblGTotal.Text = "0.00"
        LblGTotal.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(10, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 18)
        Label1.TabIndex = 91
        Label1.Text = "GRAND TOTAL:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CBBPMethod
        ' 
        CBBPMethod.BackColor = Color.White
        CBBPMethod.DropDownStyle = ComboBoxStyle.DropDownList
        CBBPMethod.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        CBBPMethod.FormattingEnabled = True
        CBBPMethod.Location = New Point(10, 118)
        CBBPMethod.MaxDropDownItems = 5
        CBBPMethod.Name = "CBBPMethod"
        CBBPMethod.Size = New Size(224, 22)
        CBBPMethod.TabIndex = 3
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(10, 101)
        Label14.Name = "Label14"
        Label14.Size = New Size(90, 14)
        Label14.TabIndex = 90
        Label14.Text = "PAYMENT TYPE:"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnCancel.FlatAppearance.BorderColor = Color.Black
        BtnCancel.FlatStyle = FlatStyle.Popup
        BtnCancel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        BtnCancel.IconColor = Color.White
        BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCancel.IconSize = 30
        BtnCancel.ImageAlign = ContentAlignment.MiddleLeft
        BtnCancel.Location = New Point(14, 416)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Padding = New Padding(35, 0, 0, 0)
        BtnCancel.Size = New Size(237, 49)
        BtnCancel.TabIndex = 5
        BtnCancel.Text = "  CANCEL" & vbCrLf & "  CHECK-OUT"
        BtnCancel.TextAlign = ContentAlignment.MiddleLeft
        BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnPPreview
        ' 
        BtnPPreview.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnPPreview.FlatAppearance.BorderColor = Color.Black
        BtnPPreview.FlatStyle = FlatStyle.Popup
        BtnPPreview.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPPreview.ForeColor = Color.White
        BtnPPreview.IconChar = FontAwesome.Sharp.IconChar.Receipt
        BtnPPreview.IconColor = Color.White
        BtnPPreview.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPPreview.IconSize = 30
        BtnPPreview.ImageAlign = ContentAlignment.MiddleLeft
        BtnPPreview.Location = New Point(14, 473)
        BtnPPreview.Name = "BtnPPreview"
        BtnPPreview.Padding = New Padding(35, 0, 0, 0)
        BtnPPreview.Size = New Size(237, 49)
        BtnPPreview.TabIndex = 6
        BtnPPreview.Text = "   PRINT" & vbCrLf & "   PREVIEW"
        BtnPPreview.TextAlign = ContentAlignment.MiddleLeft
        BtnPPreview.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPPreview.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(14, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 16)
        Label6.TabIndex = 60
        Label6.Text = "TRANSACT NO.:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelCash
        ' 
        PanelCash.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        PanelCash.BorderStyle = BorderStyle.FixedSingle
        PanelCash.Controls.Add(BtnClear)
        PanelCash.Controls.Add(TxtCash)
        PanelCash.Controls.Add(Label13)
        PanelCash.Controls.Add(Label29)
        PanelCash.Controls.Add(LblChange)
        PanelCash.Controls.Add(Button1)
        PanelCash.Controls.Add(Label16)
        PanelCash.Controls.Add(Btn0)
        PanelCash.Controls.Add(Btn1)
        PanelCash.Controls.Add(Btn2)
        PanelCash.Controls.Add(Btn3)
        PanelCash.Controls.Add(Btn9)
        PanelCash.Controls.Add(Btn4)
        PanelCash.Controls.Add(Btn8)
        PanelCash.Controls.Add(Btn5)
        PanelCash.Controls.Add(Btn7)
        PanelCash.Controls.Add(Btn6)
        PanelCash.Location = New Point(263, 213)
        PanelCash.Name = "PanelCash"
        PanelCash.Size = New Size(248, 366)
        PanelCash.TabIndex = 109
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.Orange
        BtnClear.FlatAppearance.BorderColor = Color.Black
        BtnClear.FlatStyle = FlatStyle.Popup
        BtnClear.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.ForeColor = Color.White
        BtnClear.Location = New Point(152, 235)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(50, 50)
        BtnClear.TabIndex = 114
        BtnClear.Text = "C"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' TxtCash
        ' 
        TxtCash.BackColor = Color.White
        TxtCash.BorderStyle = BorderStyle.FixedSingle
        TxtCash.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        TxtCash.ForeColor = Color.Black
        TxtCash.Location = New Point(48, 26)
        TxtCash.Multiline = True
        TxtCash.Name = "TxtCash"
        TxtCash.Size = New Size(154, 44)
        TxtCash.TabIndex = 112
        TxtCash.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(54, 8)
        Label13.Name = "Label13"
        Label13.Size = New Size(85, 15)
        Label13.TabIndex = 96
        Label13.Text = "ENTER CASH :"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label29.ForeColor = Color.Red
        Label29.Location = New Point(47, 7)
        Label29.Name = "Label29"
        Label29.Size = New Size(11, 14)
        Label29.TabIndex = 113
        Label29.Text = "*"
        Label29.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblChange
        ' 
        LblChange.BackColor = Color.Black
        LblChange.BorderStyle = BorderStyle.FixedSingle
        LblChange.FlatStyle = FlatStyle.Flat
        LblChange.Font = New Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblChange.ForeColor = Color.LimeGreen
        LblChange.Location = New Point(48, 316)
        LblChange.Name = "LblChange"
        LblChange.Size = New Size(154, 44)
        LblChange.TabIndex = 109
        LblChange.Text = "0.00"
        LblChange.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(48, 235)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 50)
        Button1.TabIndex = 111
        Button1.Text = "."
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(47, 297)
        Label16.Name = "Label16"
        Label16.Size = New Size(60, 15)
        Label16.TabIndex = 110
        Label16.Text = "CHANGE :"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Btn0
        ' 
        Btn0.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn0.FlatAppearance.BorderColor = Color.Black
        Btn0.FlatStyle = FlatStyle.Popup
        Btn0.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn0.ForeColor = Color.White
        Btn0.Location = New Point(100, 235)
        Btn0.Name = "Btn0"
        Btn0.Size = New Size(50, 50)
        Btn0.TabIndex = 98
        Btn0.Text = "0"
        Btn0.UseVisualStyleBackColor = False
        ' 
        ' Btn1
        ' 
        Btn1.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn1.FlatAppearance.BorderColor = Color.Black
        Btn1.FlatStyle = FlatStyle.Popup
        Btn1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn1.ForeColor = Color.White
        Btn1.Location = New Point(48, 183)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(50, 50)
        Btn1.TabIndex = 99
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = False
        ' 
        ' Btn2
        ' 
        Btn2.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn2.FlatAppearance.BorderColor = Color.Black
        Btn2.FlatStyle = FlatStyle.Popup
        Btn2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn2.ForeColor = Color.White
        Btn2.Location = New Point(100, 183)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(50, 50)
        Btn2.TabIndex = 100
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = False
        ' 
        ' Btn3
        ' 
        Btn3.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn3.FlatAppearance.BorderColor = Color.Black
        Btn3.FlatStyle = FlatStyle.Popup
        Btn3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn3.ForeColor = Color.White
        Btn3.Location = New Point(152, 183)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(50, 50)
        Btn3.TabIndex = 101
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = False
        ' 
        ' Btn9
        ' 
        Btn9.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn9.FlatAppearance.BorderColor = Color.Black
        Btn9.FlatStyle = FlatStyle.Popup
        Btn9.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn9.ForeColor = Color.White
        Btn9.Location = New Point(152, 79)
        Btn9.Name = "Btn9"
        Btn9.Size = New Size(50, 50)
        Btn9.TabIndex = 107
        Btn9.Text = "9"
        Btn9.UseVisualStyleBackColor = False
        ' 
        ' Btn4
        ' 
        Btn4.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn4.FlatAppearance.BorderColor = Color.Black
        Btn4.FlatStyle = FlatStyle.Popup
        Btn4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn4.ForeColor = Color.White
        Btn4.Location = New Point(48, 131)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(50, 50)
        Btn4.TabIndex = 102
        Btn4.Text = "4"
        Btn4.UseVisualStyleBackColor = False
        ' 
        ' Btn8
        ' 
        Btn8.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn8.FlatAppearance.BorderColor = Color.Black
        Btn8.FlatStyle = FlatStyle.Popup
        Btn8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn8.ForeColor = Color.White
        Btn8.Location = New Point(100, 79)
        Btn8.Name = "Btn8"
        Btn8.Size = New Size(50, 50)
        Btn8.TabIndex = 106
        Btn8.Text = "8"
        Btn8.UseVisualStyleBackColor = False
        ' 
        ' Btn5
        ' 
        Btn5.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn5.FlatAppearance.BorderColor = Color.Black
        Btn5.FlatStyle = FlatStyle.Popup
        Btn5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn5.ForeColor = Color.White
        Btn5.Location = New Point(100, 131)
        Btn5.Name = "Btn5"
        Btn5.Size = New Size(50, 50)
        Btn5.TabIndex = 103
        Btn5.Text = "5"
        Btn5.UseVisualStyleBackColor = False
        ' 
        ' Btn7
        ' 
        Btn7.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn7.FlatAppearance.BorderColor = Color.Black
        Btn7.FlatStyle = FlatStyle.Popup
        Btn7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn7.ForeColor = Color.White
        Btn7.Location = New Point(48, 79)
        Btn7.Name = "Btn7"
        Btn7.Size = New Size(50, 50)
        Btn7.TabIndex = 105
        Btn7.Text = "7"
        Btn7.UseVisualStyleBackColor = False
        ' 
        ' Btn6
        ' 
        Btn6.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        Btn6.FlatAppearance.BorderColor = Color.Black
        Btn6.FlatStyle = FlatStyle.Popup
        Btn6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Btn6.ForeColor = Color.White
        Btn6.Location = New Point(152, 131)
        Btn6.Name = "Btn6"
        Btn6.Size = New Size(50, 50)
        Btn6.TabIndex = 104
        Btn6.Text = "6"
        Btn6.UseVisualStyleBackColor = False
        ' 
        ' PanelGcash
        ' 
        PanelGcash.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        PanelGcash.BorderStyle = BorderStyle.FixedSingle
        PanelGcash.Controls.Add(Label35)
        PanelGcash.Controls.Add(Label39)
        PanelGcash.Controls.Add(TxtRefNo)
        PanelGcash.Controls.Add(PictureBox1)
        PanelGcash.Location = New Point(262, 213)
        PanelGcash.Name = "PanelGcash"
        PanelGcash.Size = New Size(248, 366)
        PanelGcash.TabIndex = 111
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label35.Location = New Point(57, 215)
        Label35.Name = "Label35"
        Label35.Size = New Size(136, 15)
        Label35.TabIndex = 96
        Label35.Text = "ENTER REFERENCE NO."
        Label35.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label39.ForeColor = Color.Red
        Label39.Location = New Point(49, 214)
        Label39.Name = "Label39"
        Label39.Size = New Size(11, 14)
        Label39.TabIndex = 114
        Label39.Text = "*"
        Label39.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtRefNo
        ' 
        TxtRefNo.BorderStyle = BorderStyle.FixedSingle
        TxtRefNo.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtRefNo.Location = New Point(11, 239)
        TxtRefNo.Multiline = True
        TxtRefNo.Name = "TxtRefNo"
        TxtRefNo.Size = New Size(224, 23)
        TxtRefNo.TabIndex = 97
        TxtRefNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.GCASH_Logo
        PictureBox1.Location = New Point(40, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(167, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 99
        PictureBox1.TabStop = False
        ' 
        ' PanelTitlebar
        ' 
        PanelTitlebar.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        PanelTitlebar.BorderStyle = BorderStyle.FixedSingle
        PanelTitlebar.Controls.Add(Label7)
        PanelTitlebar.Controls.Add(Label8)
        PanelTitlebar.Dock = DockStyle.Top
        PanelTitlebar.Location = New Point(0, 0)
        PanelTitlebar.Name = "PanelTitlebar"
        PanelTitlebar.Size = New Size(518, 25)
        PanelTitlebar.TabIndex = 57
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(4, 2)
        Label7.Name = "Label7"
        Label7.Size = New Size(139, 17)
        Label7.TabIndex = 7
        Label7.Text = "PROCESS CHECK-OUT"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(494, 2)
        Label8.Name = "Label8"
        Label8.Size = New Size(17, 18)
        Label8.TabIndex = 6
        Label8.Text = "x"
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(136))
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(224, 419)
        Label9.Name = "Label9"
        Label9.Size = New Size(24, 17)
        Label9.TabIndex = 112
        Label9.Text = "F1"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(136))
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(224, 476)
        Label11.Name = "Label11"
        Label11.Size = New Size(24, 17)
        Label11.TabIndex = 113
        Label11.Text = "F2"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(25), CByte(29), CByte(136))
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(224, 534)
        Label12.Name = "Label12"
        Label12.Size = New Size(24, 17)
        Label12.TabIndex = 114
        Label12.Text = "F3"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FrmCheckOut
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        ClientSize = New Size(518, 587)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Panel2)
        Controls.Add(Label9)
        Controls.Add(Panel4)
        Controls.Add(BtnCancel)
        Controls.Add(PanelTitlebar)
        Controls.Add(BtnPPreview)
        Controls.Add(Label6)
        Controls.Add(PanelGcash)
        Controls.Add(LblTransactionNo)
        Controls.Add(PanelCash)
        Controls.Add(Panel1)
        Controls.Add(BtnPrint)
        Controls.Add(Panel5)
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Name = "FrmCheckOut"
        StartPosition = FormStartPosition.CenterScreen
        Text = "te"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        PanelCash.ResumeLayout(False)
        PanelCash.PerformLayout()
        PanelGcash.ResumeLayout(False)
        PanelGcash.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelTitlebar.ResumeLayout(False)
        PanelTitlebar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents txtReceiptNo As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtODeduction As TextBox
    Friend WithEvents LblTransactionNo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbbCheckby As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblCurrentUser As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPPreview As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CBBPMethod As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents PanelCash As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents LblChange As Label
    Friend WithEvents PanelGcash As Panel
    Friend WithEvents TxtRefNo As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtCash As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CBBHousekeeping As ComboBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents LblGTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
