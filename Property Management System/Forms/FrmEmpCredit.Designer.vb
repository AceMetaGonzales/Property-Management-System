<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpCredit
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label9 = New Label()
        BtnConfirm = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        RbName = New RadioButton()
        RbIDNo = New RadioButton()
        Label1 = New Label()
        TxtSearchEmp = New TextBox()
        Label7 = New Label()
        BtnPPreview = New FontAwesome.Sharp.IconButton()
        LblIDNo = New Label()
        Label10 = New Label()
        TxtComment = New TextBox()
        Label13 = New Label()
        LblDate = New Label()
        Label11 = New Label()
        LblPosition = New Label()
        LblContactNo = New Label()
        Label6 = New Label()
        Label3 = New Label()
        LblName = New Label()
        BtnCancel = New FontAwesome.Sharp.IconButton()
        BtnPrint = New FontAwesome.Sharp.IconButton()
        Label8 = New Label()
        LblVoucherNo = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Label28 = New Label()
        LblTotal = New Label()
        Label16 = New Label()
        Label4 = New Label()
        DgTransact = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        dg_qty = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DgMenu = New DataGridView()
        Item_No = New DataGridViewTextBoxColumn()
        item_description = New DataGridViewTextBoxColumn()
        Item_Price = New DataGridViewTextBoxColumn()
        Item_Stocks = New DataGridViewTextBoxColumn()
        category = New DataGridViewTextBoxColumn()
        Label18 = New Label()
        Panel8 = New Panel()
        CbBevItems = New CheckBox()
        CbFoods = New CheckBox()
        TxtSearchMenu = New TextBox()
        Label2 = New Label()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DgTransact, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgMenu, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(BtnConfirm)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(TxtSearchEmp)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(330, 144)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.FlatStyle = FlatStyle.Flat
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(-1, -1)
        Label9.Name = "Label9"
        Label9.Size = New Size(155, 23)
        Label9.TabIndex = 72
        Label9.Text = "Employee's Details"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnConfirm.FlatStyle = FlatStyle.Flat
        BtnConfirm.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check
        BtnConfirm.IconColor = Color.Black
        BtnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnConfirm.IconSize = 30
        BtnConfirm.Location = New Point(270, 99)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(41, 25)
        BtnConfirm.TabIndex = 1
        BtnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(RbName)
        Panel3.Controls.Add(RbIDNo)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(21, 65)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(243, 26)
        Panel3.TabIndex = 55
        ' 
        ' RbName
        ' 
        RbName.AutoSize = True
        RbName.FlatStyle = FlatStyle.Popup
        RbName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        RbName.Location = New Point(97, 2)
        RbName.Name = "RbName"
        RbName.Size = New Size(56, 19)
        RbName.TabIndex = 53
        RbName.TabStop = True
        RbName.Text = "Name"
        RbName.UseVisualStyleBackColor = True
        ' 
        ' RbIDNo
        ' 
        RbIDNo.AutoSize = True
        RbIDNo.FlatStyle = FlatStyle.Popup
        RbIDNo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        RbIDNo.Location = New Point(169, 2)
        RbIDNo.Name = "RbIDNo"
        RbIDNo.Size = New Size(59, 19)
        RbIDNo.TabIndex = 52
        RbIDNo.TabStop = True
        RbIDNo.Text = "ID No."
        RbIDNo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 16)
        Label1.TabIndex = 51
        Label1.Text = "Search by:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtSearchEmp
        ' 
        TxtSearchEmp.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtSearchEmp.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtSearchEmp.BackColor = Color.White
        TxtSearchEmp.BorderStyle = BorderStyle.FixedSingle
        TxtSearchEmp.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchEmp.Location = New Point(21, 99)
        TxtSearchEmp.Name = "TxtSearchEmp"
        TxtSearchEmp.Size = New Size(243, 25)
        TxtSearchEmp.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(18, 40)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 17)
        Label7.TabIndex = 40
        Label7.Text = "SEARCH EMPLOYEE"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnPPreview
        ' 
        BtnPPreview.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnPPreview.FlatAppearance.BorderColor = Color.White
        BtnPPreview.FlatStyle = FlatStyle.Flat
        BtnPPreview.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPPreview.ForeColor = Color.White
        BtnPPreview.IconChar = FontAwesome.Sharp.IconChar.Receipt
        BtnPPreview.IconColor = Color.White
        BtnPPreview.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPPreview.IconSize = 30
        BtnPPreview.ImageAlign = ContentAlignment.MiddleLeft
        BtnPPreview.Location = New Point(77, 564)
        BtnPPreview.Name = "BtnPPreview"
        BtnPPreview.Padding = New Padding(30, 0, 0, 0)
        BtnPPreview.Size = New Size(200, 49)
        BtnPPreview.TabIndex = 5
        BtnPPreview.Text = "   VOUCHER" & vbCrLf & "   PREVIEW"
        BtnPPreview.TextAlign = ContentAlignment.MiddleLeft
        BtnPPreview.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPPreview.UseVisualStyleBackColor = False
        ' 
        ' LblIDNo
        ' 
        LblIDNo.BackColor = Color.Gainsboro
        LblIDNo.BorderStyle = BorderStyle.FixedSingle
        LblIDNo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblIDNo.Location = New Point(96, 18)
        LblIDNo.Name = "LblIDNo"
        LblIDNo.Size = New Size(211, 21)
        LblIDNo.TabIndex = 71
        LblIDNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(38, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 16)
        Label10.TabIndex = 70
        Label10.Text = "ID No. :"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtComment
        ' 
        TxtComment.BackColor = Color.White
        TxtComment.BorderStyle = BorderStyle.FixedSingle
        TxtComment.Location = New Point(96, 263)
        TxtComment.Multiline = True
        TxtComment.Name = "TxtComment"
        TxtComment.Size = New Size(211, 56)
        TxtComment.TabIndex = 2
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(15, 224)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 16)
        Label13.TabIndex = 68
        Label13.Text = "Comment :"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblDate
        ' 
        LblDate.BackColor = Color.Gainsboro
        LblDate.BorderStyle = BorderStyle.FixedSingle
        LblDate.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblDate.Location = New Point(96, 214)
        LblDate.Name = "LblDate"
        LblDate.Size = New Size(211, 21)
        LblDate.TabIndex = 67
        LblDate.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(47, 184)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 16)
        Label11.TabIndex = 66
        Label11.Text = "Date :"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblPosition
        ' 
        LblPosition.BackColor = Color.Gainsboro
        LblPosition.BorderStyle = BorderStyle.FixedSingle
        LblPosition.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblPosition.Location = New Point(96, 165)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(211, 21)
        LblPosition.TabIndex = 65
        LblPosition.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblContactNo
        ' 
        LblContactNo.BackColor = Color.Gainsboro
        LblContactNo.BorderStyle = BorderStyle.FixedSingle
        LblContactNo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblContactNo.Location = New Point(96, 116)
        LblContactNo.Name = "LblContactNo"
        LblContactNo.Size = New Size(211, 21)
        LblContactNo.TabIndex = 64
        LblContactNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(3, 102)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 16)
        Label6.TabIndex = 63
        Label6.Text = "Contact No. :"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(25, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 16)
        Label3.TabIndex = 62
        Label3.Text = "Position :"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblName
        ' 
        LblName.BackColor = Color.Gainsboro
        LblName.BorderStyle = BorderStyle.FixedSingle
        LblName.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblName.Location = New Point(96, 67)
        LblName.Name = "LblName"
        LblName.Size = New Size(211, 21)
        LblName.TabIndex = 61
        LblName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnCancel.FlatAppearance.BorderColor = Color.White
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        BtnCancel.IconColor = Color.White
        BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCancel.IconSize = 30
        BtnCancel.ImageAlign = ContentAlignment.MiddleLeft
        BtnCancel.Location = New Point(77, 509)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Padding = New Padding(30, 0, 0, 0)
        BtnCancel.Size = New Size(200, 49)
        BtnCancel.TabIndex = 4
        BtnCancel.Text = "  CANCEL" & vbCrLf & "  CREDIT"
        BtnCancel.TextAlign = ContentAlignment.MiddleLeft
        BtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnPrint.FlatAppearance.BorderColor = Color.White
        BtnPrint.FlatStyle = FlatStyle.Flat
        BtnPrint.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        BtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        BtnPrint.IconColor = Color.Black
        BtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnPrint.IconSize = 30
        BtnPrint.ImageAlign = ContentAlignment.MiddleLeft
        BtnPrint.Location = New Point(77, 619)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Padding = New Padding(30, 0, 0, 0)
        BtnPrint.Size = New Size(200, 49)
        BtnPrint.TabIndex = 6
        BtnPrint.Text = "  CONFIRM" & vbCrLf & "  CREDIT"
        BtnPrint.TextAlign = ContentAlignment.MiddleLeft
        BtnPrint.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(39, 61)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 16)
        Label8.TabIndex = 41
        Label8.Text = "Name :"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblVoucherNo
        ' 
        LblVoucherNo.BackColor = Color.FromArgb(CByte(51), CByte(124), CByte(207))
        LblVoucherNo.BorderStyle = BorderStyle.FixedSingle
        LblVoucherNo.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblVoucherNo.ForeColor = Color.White
        LblVoucherNo.Location = New Point(368, 40)
        LblVoucherNo.Name = "LblVoucherNo"
        LblVoucherNo.Size = New Size(340, 30)
        LblVoucherNo.TabIndex = 43
        LblVoucherNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Label16)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(DgTransact)
        Panel2.Controls.Add(DgMenu)
        Panel2.Controls.Add(Label18)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(TxtSearchMenu)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(LblVoucherNo)
        Panel2.Location = New Point(348, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(724, 656)
        Panel2.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label28)
        Panel5.Controls.Add(LblTotal)
        Panel5.Location = New Point(368, 589)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(340, 39)
        Panel5.TabIndex = 72
        ' 
        ' Label28
        ' 
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.Location = New Point(3, 6)
        Label28.Name = "Label28"
        Label28.Size = New Size(201, 21)
        Label28.TabIndex = 74
        Label28.Text = "TOTAL CREDIT ORDER(S) :"
        ' 
        ' LblTotal
        ' 
        LblTotal.Font = New Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblTotal.Location = New Point(201, 5)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(134, 27)
        LblTotal.TabIndex = 73
        LblTotal.Text = "0.00"
        LblTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(164, 22)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 15)
        Label16.TabIndex = 51
        Label16.Text = "Filter By:"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(368, -1)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 23)
        Label4.TabIndex = 69
        Label4.Text = "ORDERS"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' DgTransact
        ' 
        DgTransact.AllowUserToAddRows = False
        DgTransact.AllowUserToResizeColumns = False
        DgTransact.AllowUserToResizeRows = False
        DgTransact.BackgroundColor = Color.Black
        DgTransact.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgTransact.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.LimeGreen
        DataGridViewCellStyle1.SelectionBackColor = Color.Black
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgTransact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgTransact.ColumnHeadersHeight = 25
        DgTransact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgTransact.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, dg_qty, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.Black
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = Color.Lime
        DataGridViewCellStyle6.SelectionBackColor = Color.PaleGoldenrod
        DataGridViewCellStyle6.SelectionForeColor = Color.Navy
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DgTransact.DefaultCellStyle = DataGridViewCellStyle6
        DgTransact.EditMode = DataGridViewEditMode.EditProgrammatically
        DgTransact.Location = New Point(368, 68)
        DgTransact.Name = "DgTransact"
        DgTransact.ReadOnly = True
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Black
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.Lime
        DataGridViewCellStyle7.SelectionBackColor = Color.White
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DgTransact.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DgTransact.RowHeadersVisible = False
        DgTransact.RowTemplate.Height = 25
        DgTransact.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgTransact.Size = New Size(340, 524)
        DgTransact.TabIndex = 68
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewTextBoxColumn1.HeaderText = "Item No."
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True
        DataGridViewTextBoxColumn1.Visible = False
        DataGridViewTextBoxColumn1.Width = 70
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.FillWeight = 204.7619F
        DataGridViewTextBoxColumn2.HeaderText = "Description"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 176
        ' 
        ' dg_qty
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        dg_qty.DefaultCellStyle = DataGridViewCellStyle3
        dg_qty.HeaderText = "Qty"
        dg_qty.Name = "dg_qty"
        dg_qty.ReadOnly = True
        dg_qty.Width = 50
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        DataGridViewTextBoxColumn3.FillWeight = 38.84012F
        DataGridViewTextBoxColumn3.HeaderText = "Price"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 55
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        DataGridViewTextBoxColumn4.FillWeight = 56.3979874F
        DataGridViewTextBoxColumn4.HeaderText = "Amount"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 55
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Category"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Visible = False
        ' 
        ' DgMenu
        ' 
        DgMenu.AllowUserToAddRows = False
        DgMenu.AllowUserToResizeColumns = False
        DgMenu.AllowUserToResizeRows = False
        DgMenu.BackgroundColor = Color.Black
        DgMenu.CellBorderStyle = DataGridViewCellBorderStyle.None
        DgMenu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.Black
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = Color.LimeGreen
        DataGridViewCellStyle8.SelectionBackColor = Color.Black
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        DgMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        DgMenu.ColumnHeadersHeight = 25
        DgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgMenu.Columns.AddRange(New DataGridViewColumn() {Item_No, item_description, Item_Price, Item_Stocks, category})
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.Black
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = Color.Lime
        DataGridViewCellStyle11.SelectionBackColor = Color.PaleGoldenrod
        DataGridViewCellStyle11.SelectionForeColor = Color.Navy
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DgMenu.DefaultCellStyle = DataGridViewCellStyle11
        DgMenu.EditMode = DataGridViewEditMode.EditProgrammatically
        DgMenu.Location = New Point(10, 68)
        DgMenu.Name = "DgMenu"
        DgMenu.ReadOnly = True
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.Black
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = Color.Lime
        DataGridViewCellStyle12.SelectionBackColor = Color.White
        DataGridViewCellStyle12.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DgMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DgMenu.RowHeadersVisible = False
        DgMenu.RowTemplate.Height = 25
        DgMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgMenu.Size = New Size(340, 560)
        DgMenu.TabIndex = 63
        ' 
        ' Item_No
        ' 
        Item_No.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Item_No.HeaderText = "Item No."
        Item_No.Name = "Item_No"
        Item_No.ReadOnly = True
        Item_No.Resizable = DataGridViewTriState.True
        Item_No.Width = 70
        ' 
        ' item_description
        ' 
        item_description.FillWeight = 204.7619F
        item_description.HeaderText = "Description"
        item_description.Name = "item_description"
        item_description.ReadOnly = True
        item_description.Width = 176
        ' 
        ' Item_Price
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleRight
        Item_Price.DefaultCellStyle = DataGridViewCellStyle9
        Item_Price.FillWeight = 38.84012F
        Item_Price.HeaderText = "Price"
        Item_Price.Name = "Item_Price"
        Item_Price.ReadOnly = True
        Item_Price.Width = 45
        ' 
        ' Item_Stocks
        ' 
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        Item_Stocks.DefaultCellStyle = DataGridViewCellStyle10
        Item_Stocks.FillWeight = 56.3979874F
        Item_Stocks.HeaderText = "Stocks"
        Item_Stocks.Name = "Item_Stocks"
        Item_Stocks.ReadOnly = True
        Item_Stocks.Width = 45
        ' 
        ' category
        ' 
        category.HeaderText = "Category"
        category.Name = "category"
        category.ReadOnly = True
        category.Visible = False
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label18.Location = New Point(10, 630)
        Label18.Name = "Label18"
        Label18.Size = New Size(199, 13)
        Label18.TabIndex = 67
        Label18.Text = "*Double click an item to add it to order(s)"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(CbBevItems)
        Panel8.Controls.Add(CbFoods)
        Panel8.Location = New Point(166, 40)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(184, 23)
        Panel8.TabIndex = 66
        ' 
        ' CbBevItems
        ' 
        CbBevItems.AutoSize = True
        CbBevItems.Location = New Point(66, 1)
        CbBevItems.Name = "CbBevItems"
        CbBevItems.Size = New Size(113, 19)
        CbBevItems.TabIndex = 53
        CbBevItems.Text = "Bevereges/Items"
        CbBevItems.UseVisualStyleBackColor = True
        ' 
        ' CbFoods
        ' 
        CbFoods.AutoSize = True
        CbFoods.Location = New Point(3, 1)
        CbFoods.Name = "CbFoods"
        CbFoods.Size = New Size(58, 19)
        CbFoods.TabIndex = 52
        CbFoods.Text = "Foods"
        CbFoods.UseVisualStyleBackColor = True
        ' 
        ' TxtSearchMenu
        ' 
        TxtSearchMenu.BackColor = Color.White
        TxtSearchMenu.BorderStyle = BorderStyle.FixedSingle
        TxtSearchMenu.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchMenu.Location = New Point(10, 42)
        TxtSearchMenu.Name = "TxtSearchMenu"
        TxtSearchMenu.Size = New Size(149, 21)
        TxtSearchMenu.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(-1, -1)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 23)
        Label2.TabIndex = 64
        Label2.Text = "Choose Food/Item"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(LblIDNo)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(LblName)
        Panel4.Controls.Add(TxtComment)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(LblDate)
        Panel4.Controls.Add(LblContactNo)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(LblPosition)
        Panel4.Location = New Point(12, 158)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(330, 343)
        Panel4.TabIndex = 70
        ' 
        ' FrmEmpCredit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        ClientSize = New Size(1084, 680)
        Controls.Add(Panel4)
        Controls.Add(BtnPPreview)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(BtnCancel)
        Controls.Add(BtnPrint)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmEmpCredit"
        Text = "FrmEmpCredit"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel5.ResumeLayout(False)
        CType(DgTransact, ComponentModel.ISupportInitialize).EndInit()
        CType(DgMenu, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSearchEmp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblVoucherNo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DgMenu As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents CbBevItems As CheckBox
    Friend WithEvents CbFoods As CheckBox
    Friend WithEvents TxtSearchMenu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgTransact As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents RbName As RadioButton
    Friend WithEvents RbIDNo As RadioButton
    Friend WithEvents BtnConfirm As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCancel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents LblName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblContactNo As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtComment As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblIDNo As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnPPreview As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Item_No As DataGridViewTextBoxColumn
    Friend WithEvents item_description As DataGridViewTextBoxColumn
    Friend WithEvents Item_Price As DataGridViewTextBoxColumn
    Friend WithEvents Item_Stocks As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dg_qty As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label28 As Label
End Class
