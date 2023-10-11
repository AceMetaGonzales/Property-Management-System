<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTransactGuest

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnBack = New FontAwesome.Sharp.IconButton()
        Timer1 = New Timer(components)
        LblCheckInTime = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        CbbDescription = New ComboBox()
        lblDuration = New Label()
        lblCheckOut = New Label()
        LblHAvailed = New Label()
        Label19 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        BtnCheckIn = New FontAwesome.Sharp.IconButton()
        PanelGuestDetails = New Panel()
        txtOtherDiscount = New TextBox()
        TxtPlateNo = New TextBox()
        TxtVtype = New TextBox()
        TxtContactNo = New TextBox()
        TxtName = New TextBox()
        TxtSeniorNo = New TextBox()
        CbbPromo = New ComboBox()
        CbbGuestCount = New ComboBox()
        CbbGType = New ComboBox()
        BtnClear = New Button()
        Label15 = New Label()
        Label10 = New Label()
        Promo = New Label()
        Label29 = New Label()
        Label17 = New Label()
        Label6 = New Label()
        Label11 = New Label()
        TxtAddress = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        PanelTransact = New Panel()
        DGTransact = New DataGridView()
        ItemNo = New DataGridViewTextBoxColumn()
        Particulars = New DataGridViewTextBoxColumn()
        Qty = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        Tcategory = New DataGridViewTextBoxColumn()
        Label36 = New Label()
        LblPartialTotal = New Label()
        Label34 = New Label()
        LblODPercentage = New Label()
        LblGTPercentage = New Label()
        LblPDPercentage = New Label()
        Label31 = New Label()
        LblOtherDiscount = New Label()
        LblGDiscount = New Label()
        LblPromoDiscount = New Label()
        LblAddOn = New Label()
        Label30 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        Panel3 = New Panel()
        LblGrandTotal = New Label()
        Label28 = New Label()
        LblEHamount = New Label()
        LblEGamount = New Label()
        LblDHamount = New Label()
        LblEHprice = New Label()
        LblEGprice = New Label()
        LblDHprice = New Label()
        LblEHqty = New Label()
        LblEGqty = New Label()
        LblDHqty = New Label()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        LblTransactionNo = New Label()
        Label1 = New Label()
        TxtComment = New TextBox()
        PanelMenu = New Panel()
        DgMenu = New DataGridView()
        Item_No = New DataGridViewTextBoxColumn()
        item_description = New DataGridViewTextBoxColumn()
        Item_Price = New DataGridViewTextBoxColumn()
        Item_Stocks = New DataGridViewTextBoxColumn()
        category = New DataGridViewTextBoxColumn()
        Label18 = New Label()
        Panel8 = New Panel()
        Label16 = New Label()
        CbBevItems = New CheckBox()
        CbFoods = New CheckBox()
        TxtSearchMenu = New TextBox()
        Label2 = New Label()
        TimerRemainingTime = New Timer(components)
        BtnCheckOut = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        LblCurrentRoom = New Label()
        Panel7 = New Panel()
        LblRTDes = New Label()
        LblRemainingTime = New Label()
        Panel6 = New Panel()
        Label14 = New Label()
        LblRoomStatus = New Label()
        BtnCancel = New Button()
        BtnTransfer = New Button()
        Panel4 = New Panel()
        Label35 = New Label()
        Panel1.SuspendLayout()
        PanelGuestDetails.SuspendLayout()
        PanelTransact.SuspendLayout()
        CType(DGTransact, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        PanelMenu.SuspendLayout()
        CType(DgMenu, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        BtnBack.FlatAppearance.BorderSize = 0
        BtnBack.FlatStyle = FlatStyle.Flat
        BtnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        BtnBack.IconColor = Color.Black
        BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnBack.IconSize = 20
        BtnBack.ImageAlign = ContentAlignment.MiddleLeft
        BtnBack.Location = New Point(-1, 2)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(28, 26)
        BtnBack.TabIndex = 0
        BtnBack.TextAlign = ContentAlignment.MiddleLeft
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' LblCheckInTime
        ' 
        LblCheckInTime.BackColor = Color.WhiteSmoke
        LblCheckInTime.BorderStyle = BorderStyle.FixedSingle
        LblCheckInTime.FlatStyle = FlatStyle.Flat
        LblCheckInTime.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblCheckInTime.Location = New Point(21, 27)
        LblCheckInTime.Name = "LblCheckInTime"
        LblCheckInTime.Size = New Size(170, 22)
        LblCheckInTime.TabIndex = 7
        LblCheckInTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(21, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 16)
        Label3.TabIndex = 6
        Label3.Text = "Check In:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CbbDescription)
        Panel1.Controls.Add(lblDuration)
        Panel1.Controls.Add(lblCheckOut)
        Panel1.Controls.Add(LblCheckInTime)
        Panel1.Controls.Add(LblHAvailed)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(12, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(779, 58)
        Panel1.TabIndex = 8
        ' 
        ' CbbDescription
        ' 
        CbbDescription.BackColor = Color.White
        CbbDescription.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CbbDescription.FormattingEnabled = True
        CbbDescription.Location = New Point(210, 26)
        CbbDescription.Name = "CbbDescription"
        CbbDescription.Size = New Size(170, 23)
        CbbDescription.TabIndex = 28
        ' 
        ' lblDuration
        ' 
        lblDuration.BackColor = Color.WhiteSmoke
        lblDuration.BorderStyle = BorderStyle.FixedSingle
        lblDuration.FlatStyle = FlatStyle.Flat
        lblDuration.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblDuration.Location = New Point(401, 27)
        lblDuration.Name = "lblDuration"
        lblDuration.Size = New Size(165, 22)
        lblDuration.TabIndex = 29
        lblDuration.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCheckOut
        ' 
        lblCheckOut.BackColor = Color.WhiteSmoke
        lblCheckOut.BorderStyle = BorderStyle.FixedSingle
        lblCheckOut.FlatStyle = FlatStyle.Flat
        lblCheckOut.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblCheckOut.Location = New Point(588, 27)
        lblCheckOut.Name = "lblCheckOut"
        lblCheckOut.Size = New Size(170, 22)
        lblCheckOut.TabIndex = 11
        lblCheckOut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblHAvailed
        ' 
        LblHAvailed.AutoSize = True
        LblHAvailed.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblHAvailed.Location = New Point(218, 11)
        LblHAvailed.Name = "LblHAvailed"
        LblHAvailed.Size = New Size(94, 16)
        LblHAvailed.TabIndex = 27
        LblHAvailed.Text = "Choose Hours"
        LblHAvailed.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Red
        Label19.Location = New Point(209, 10)
        Label19.Name = "Label19"
        Label19.Size = New Size(14, 18)
        Label19.TabIndex = 30
        Label19.Text = "*"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(589, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 16)
        Label5.TabIndex = 9
        Label5.Text = "Check Out:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(401, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 16)
        Label4.TabIndex = 8
        Label4.Text = "Duration:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' BtnCheckIn
        ' 
        BtnCheckIn.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnCheckIn.FlatAppearance.BorderColor = Color.White
        BtnCheckIn.FlatStyle = FlatStyle.Flat
        BtnCheckIn.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCheckIn.ForeColor = Color.Black
        BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.SignIn
        BtnCheckIn.IconColor = Color.Black
        BtnCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCheckIn.IconSize = 30
        BtnCheckIn.Location = New Point(797, 30)
        BtnCheckIn.Name = "BtnCheckIn"
        BtnCheckIn.Size = New Size(276, 58)
        BtnCheckIn.TabIndex = 0
        BtnCheckIn.Text = "CHECK-IN"
        BtnCheckIn.TextAlign = ContentAlignment.MiddleRight
        BtnCheckIn.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCheckIn.UseVisualStyleBackColor = False
        ' 
        ' PanelGuestDetails
        ' 
        PanelGuestDetails.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelGuestDetails.BorderStyle = BorderStyle.FixedSingle
        PanelGuestDetails.Controls.Add(txtOtherDiscount)
        PanelGuestDetails.Controls.Add(TxtPlateNo)
        PanelGuestDetails.Controls.Add(TxtVtype)
        PanelGuestDetails.Controls.Add(TxtContactNo)
        PanelGuestDetails.Controls.Add(TxtName)
        PanelGuestDetails.Controls.Add(TxtSeniorNo)
        PanelGuestDetails.Controls.Add(CbbPromo)
        PanelGuestDetails.Controls.Add(CbbGuestCount)
        PanelGuestDetails.Controls.Add(CbbGType)
        PanelGuestDetails.Controls.Add(BtnClear)
        PanelGuestDetails.Controls.Add(Label15)
        PanelGuestDetails.Controls.Add(Label10)
        PanelGuestDetails.Controls.Add(Promo)
        PanelGuestDetails.Controls.Add(Label29)
        PanelGuestDetails.Controls.Add(Label17)
        PanelGuestDetails.Controls.Add(Label6)
        PanelGuestDetails.Controls.Add(Label11)
        PanelGuestDetails.Controls.Add(TxtAddress)
        PanelGuestDetails.Controls.Add(Label13)
        PanelGuestDetails.Controls.Add(Label12)
        PanelGuestDetails.Controls.Add(Label9)
        PanelGuestDetails.Controls.Add(Label8)
        PanelGuestDetails.Controls.Add(Label7)
        PanelGuestDetails.Location = New Point(12, 95)
        PanelGuestDetails.Name = "PanelGuestDetails"
        PanelGuestDetails.Size = New Size(779, 170)
        PanelGuestDetails.TabIndex = 11
        ' 
        ' txtOtherDiscount
        ' 
        txtOtherDiscount.BorderStyle = BorderStyle.FixedSingle
        txtOtherDiscount.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtOtherDiscount.Location = New Point(407, 139)
        txtOtherDiscount.Multiline = True
        txtOtherDiscount.Name = "txtOtherDiscount"
        txtOtherDiscount.Size = New Size(159, 22)
        txtOtherDiscount.TabIndex = 58
        ' 
        ' TxtPlateNo
        ' 
        TxtPlateNo.BorderStyle = BorderStyle.FixedSingle
        TxtPlateNo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPlateNo.Location = New Point(600, 48)
        TxtPlateNo.Multiline = True
        TxtPlateNo.Name = "TxtPlateNo"
        TxtPlateNo.Size = New Size(159, 22)
        TxtPlateNo.TabIndex = 40
        ' 
        ' TxtVtype
        ' 
        TxtVtype.BorderStyle = BorderStyle.FixedSingle
        TxtVtype.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtVtype.Location = New Point(407, 48)
        TxtVtype.Multiline = True
        TxtVtype.Name = "TxtVtype"
        TxtVtype.Size = New Size(159, 22)
        TxtVtype.TabIndex = 39
        ' 
        ' TxtContactNo
        ' 
        TxtContactNo.BorderStyle = BorderStyle.FixedSingle
        TxtContactNo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContactNo.Location = New Point(214, 48)
        TxtContactNo.Multiline = True
        TxtContactNo.Name = "TxtContactNo"
        TxtContactNo.Size = New Size(159, 22)
        TxtContactNo.TabIndex = 38
        ' 
        ' TxtName
        ' 
        TxtName.BorderStyle = BorderStyle.FixedSingle
        TxtName.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(21, 48)
        TxtName.Multiline = True
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(159, 22)
        TxtName.TabIndex = 29
        ' 
        ' TxtSeniorNo
        ' 
        TxtSeniorNo.BorderStyle = BorderStyle.FixedSingle
        TxtSeniorNo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSeniorNo.Location = New Point(407, 94)
        TxtSeniorNo.Multiline = True
        TxtSeniorNo.Name = "TxtSeniorNo"
        TxtSeniorNo.Size = New Size(159, 21)
        TxtSeniorNo.TabIndex = 60
        ' 
        ' CbbPromo
        ' 
        CbbPromo.BackColor = Color.White
        CbbPromo.DropDownStyle = ComboBoxStyle.DropDownList
        CbbPromo.FlatStyle = FlatStyle.System
        CbbPromo.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CbbPromo.FormattingEnabled = True
        CbbPromo.Location = New Point(600, 93)
        CbbPromo.MaxDropDownItems = 5
        CbbPromo.Name = "CbbPromo"
        CbbPromo.Size = New Size(159, 23)
        CbbPromo.TabIndex = 51
        ' 
        ' CbbGuestCount
        ' 
        CbbGuestCount.BackColor = Color.White
        CbbGuestCount.DropDownStyle = ComboBoxStyle.DropDownList
        CbbGuestCount.FlatStyle = FlatStyle.System
        CbbGuestCount.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CbbGuestCount.FormattingEnabled = True
        CbbGuestCount.Location = New Point(214, 93)
        CbbGuestCount.MaxDropDownItems = 5
        CbbGuestCount.Name = "CbbGuestCount"
        CbbGuestCount.Size = New Size(159, 23)
        CbbGuestCount.TabIndex = 47
        ' 
        ' CbbGType
        ' 
        CbbGType.BackColor = Color.White
        CbbGType.DropDownStyle = ComboBoxStyle.DropDownList
        CbbGType.FlatStyle = FlatStyle.System
        CbbGType.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        CbbGType.FormattingEnabled = True
        CbbGType.Location = New Point(21, 93)
        CbbGType.MaxDropDownItems = 5
        CbbGType.Name = "CbbGType"
        CbbGType.Size = New Size(159, 23)
        CbbGType.TabIndex = 46
        ' 
        ' BtnClear
        ' 
        BtnClear.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnClear.FlatStyle = FlatStyle.Flat
        BtnClear.Font = New Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClear.ForeColor = Color.White
        BtnClear.Location = New Point(600, 124)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(159, 37)
        BtnClear.TabIndex = 53
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(405, 124)
        Label15.Name = "Label15"
        Label15.Size = New Size(109, 14)
        Label15.TabIndex = 61
        Label15.Text = "Other Discount(%):"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(403, 78)
        Label10.Name = "Label10"
        Label10.Size = New Size(62, 14)
        Label10.TabIndex = 59
        Label10.Text = "Senior ID.:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Promo
        ' 
        Promo.AutoSize = True
        Promo.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Promo.Location = New Point(597, 78)
        Promo.Name = "Promo"
        Promo.Size = New Size(76, 14)
        Promo.TabIndex = 54
        Promo.Text = "Promo Type:"
        Promo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label29.Location = New Point(270, 101)
        Label29.Name = "Label29"
        Label29.Size = New Size(0, 14)
        Label29.TabIndex = 52
        Label29.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(213, 78)
        Label17.Name = "Label17"
        Label17.Size = New Size(79, 14)
        Label17.TabIndex = 48
        Label17.Text = "Guest Count:"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(-1, -1)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 22)
        Label6.TabIndex = 45
        Label6.Text = "GUEST DETAILS"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(20, 78)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 14)
        Label11.TabIndex = 42
        Label11.Text = "Guest Type:"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtAddress
        ' 
        TxtAddress.BorderStyle = BorderStyle.FixedSingle
        TxtAddress.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(77, 124)
        TxtAddress.Multiline = True
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(296, 37)
        TxtAddress.TabIndex = 37
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(20, 123)
        Label13.Name = "Label13"
        Label13.Size = New Size(58, 14)
        Label13.TabIndex = 36
        Label13.Text = "Address:"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(406, 33)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 14)
        Label12.TabIndex = 35
        Label12.Text = "Vehicle Type:"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(597, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 14)
        Label9.TabIndex = 32
        Label9.Text = "Plate No.:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(211, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 14)
        Label8.TabIndex = 31
        Label8.Text = "Contact No.:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(19, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 14)
        Label7.TabIndex = 30
        Label7.Text = "Name:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelTransact
        ' 
        PanelTransact.AutoScroll = True
        PanelTransact.BackColor = Color.White
        PanelTransact.BorderStyle = BorderStyle.FixedSingle
        PanelTransact.Controls.Add(DGTransact)
        PanelTransact.Controls.Add(Label36)
        PanelTransact.Controls.Add(LblPartialTotal)
        PanelTransact.Controls.Add(Label34)
        PanelTransact.Controls.Add(LblODPercentage)
        PanelTransact.Controls.Add(LblGTPercentage)
        PanelTransact.Controls.Add(LblPDPercentage)
        PanelTransact.Controls.Add(Label31)
        PanelTransact.Controls.Add(LblOtherDiscount)
        PanelTransact.Controls.Add(LblGDiscount)
        PanelTransact.Controls.Add(LblPromoDiscount)
        PanelTransact.Controls.Add(LblAddOn)
        PanelTransact.Controls.Add(Label30)
        PanelTransact.Controls.Add(Label32)
        PanelTransact.Controls.Add(Label33)
        PanelTransact.Controls.Add(Panel3)
        PanelTransact.Controls.Add(LblEHamount)
        PanelTransact.Controls.Add(LblEGamount)
        PanelTransact.Controls.Add(LblDHamount)
        PanelTransact.Controls.Add(LblEHprice)
        PanelTransact.Controls.Add(LblEGprice)
        PanelTransact.Controls.Add(LblDHprice)
        PanelTransact.Controls.Add(LblEHqty)
        PanelTransact.Controls.Add(LblEGqty)
        PanelTransact.Controls.Add(LblDHqty)
        PanelTransact.Controls.Add(Label27)
        PanelTransact.Controls.Add(Label26)
        PanelTransact.Controls.Add(Label25)
        PanelTransact.Controls.Add(Label24)
        PanelTransact.Controls.Add(Label23)
        PanelTransact.Controls.Add(Label22)
        PanelTransact.Controls.Add(Label21)
        PanelTransact.Controls.Add(Label20)
        PanelTransact.Location = New Point(797, 121)
        PanelTransact.Name = "PanelTransact"
        PanelTransact.Size = New Size(276, 439)
        PanelTransact.TabIndex = 32
        ' 
        ' DGTransact
        ' 
        DGTransact.AllowUserToAddRows = False
        DGTransact.AllowUserToResizeColumns = False
        DGTransact.AllowUserToResizeRows = False
        DGTransact.BackgroundColor = Color.White
        DGTransact.CellBorderStyle = DataGridViewCellBorderStyle.None
        DGTransact.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DGTransact.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DGTransact.ColumnHeadersHeight = 30
        DGTransact.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGTransact.ColumnHeadersVisible = False
        DGTransact.Columns.AddRange(New DataGridViewColumn() {ItemNo, Particulars, Qty, Price, Amount, Tcategory})
        DGTransact.EditMode = DataGridViewEditMode.EditProgrammatically
        DGTransact.Location = New Point(4, 126)
        DGTransact.Name = "DGTransact"
        DGTransact.ReadOnly = True
        DGTransact.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DGTransact.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DGTransact.RowHeadersVisible = False
        DGTransact.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DGTransact.RowTemplate.Height = 25
        DGTransact.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGTransact.Size = New Size(266, 159)
        DGTransact.TabIndex = 0
        ' 
        ' ItemNo
        ' 
        ItemNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ItemNo.HeaderText = "Item No."
        ItemNo.Name = "ItemNo"
        ItemNo.ReadOnly = True
        ItemNo.Visible = False
        ItemNo.Width = 45
        ' 
        ' Particulars
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        Particulars.DefaultCellStyle = DataGridViewCellStyle2
        Particulars.FillWeight = 160.305313F
        Particulars.HeaderText = "Particulars"
        Particulars.Name = "Particulars"
        Particulars.ReadOnly = True
        Particulars.Width = 105
        ' 
        ' Qty
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        Qty.DefaultCellStyle = DataGridViewCellStyle3
        Qty.FillWeight = 47.61458F
        Qty.HeaderText = "Qty"
        Qty.Name = "Qty"
        Qty.ReadOnly = True
        Qty.Width = 31
        ' 
        ' Price
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        Price.DefaultCellStyle = DataGridViewCellStyle4
        Price.FillWeight = 81.21163F
        Price.HeaderText = "Price"
        Price.Name = "Price"
        Price.ReadOnly = True
        Price.Width = 53
        ' 
        ' Amount
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        Amount.DefaultCellStyle = DataGridViewCellStyle5
        Amount.FillWeight = 110.868416F
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        Amount.ReadOnly = True
        Amount.Width = 73
        ' 
        ' Tcategory
        ' 
        Tcategory.HeaderText = "Category"
        Tcategory.Name = "Tcategory"
        Tcategory.ReadOnly = True
        Tcategory.Visible = False
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label36.Location = New Point(3, 285)
        Label36.Name = "Label36"
        Label36.Size = New Size(268, 13)
        Label36.TabIndex = 63
        Label36.Text = "*Double click an item to edit/remove it to guest order(s)"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblPartialTotal
        ' 
        LblPartialTotal.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LblPartialTotal.Location = New Point(163, 304)
        LblPartialTotal.Name = "LblPartialTotal"
        LblPartialTotal.Size = New Size(97, 16)
        LblPartialTotal.TabIndex = 87
        LblPartialTotal.Text = "0.00"
        LblPartialTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label34.Location = New Point(8, 305)
        Label34.Name = "Label34"
        Label34.Size = New Size(92, 17)
        Label34.TabIndex = 86
        Label34.Text = "SUB TOTAL :"
        Label34.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblODPercentage
        ' 
        LblODPercentage.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblODPercentage.Location = New Point(144, 370)
        LblODPercentage.Name = "LblODPercentage"
        LblODPercentage.Size = New Size(50, 13)
        LblODPercentage.TabIndex = 85
        LblODPercentage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblGTPercentage
        ' 
        LblGTPercentage.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblGTPercentage.Location = New Point(144, 328)
        LblGTPercentage.Name = "LblGTPercentage"
        LblGTPercentage.Size = New Size(50, 15)
        LblGTPercentage.TabIndex = 84
        LblGTPercentage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblPDPercentage
        ' 
        LblPDPercentage.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblPDPercentage.Location = New Point(144, 349)
        LblPDPercentage.Name = "LblPDPercentage"
        LblPDPercentage.Size = New Size(50, 14)
        LblPDPercentage.TabIndex = 83
        LblPDPercentage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label31.Location = New Point(9, 82)
        Label31.Name = "Label31"
        Label31.Size = New Size(54, 14)
        Label31.TabIndex = 82
        Label31.Text = "Add-On :"
        Label31.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblOtherDiscount
        ' 
        LblOtherDiscount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblOtherDiscount.Location = New Point(212, 369)
        LblOtherDiscount.Name = "LblOtherDiscount"
        LblOtherDiscount.Size = New Size(50, 14)
        LblOtherDiscount.TabIndex = 81
        LblOtherDiscount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblGDiscount
        ' 
        LblGDiscount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblGDiscount.Location = New Point(212, 329)
        LblGDiscount.Name = "LblGDiscount"
        LblGDiscount.Size = New Size(50, 14)
        LblGDiscount.TabIndex = 80
        LblGDiscount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblPromoDiscount
        ' 
        LblPromoDiscount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblPromoDiscount.Location = New Point(212, 349)
        LblPromoDiscount.Name = "LblPromoDiscount"
        LblPromoDiscount.Size = New Size(50, 14)
        LblPromoDiscount.TabIndex = 79
        LblPromoDiscount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblAddOn
        ' 
        LblAddOn.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblAddOn.Location = New Point(142, 86)
        LblAddOn.Name = "LblAddOn"
        LblAddOn.Size = New Size(118, 11)
        LblAddOn.TabIndex = 78
        LblAddOn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label30.Location = New Point(9, 329)
        Label30.Name = "Label30"
        Label30.Size = New Size(126, 14)
        Label30.TabIndex = 77
        Label30.Text = "Guest Type Discount :"
        Label30.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label32.Location = New Point(9, 369)
        Label32.Name = "Label32"
        Label32.Size = New Size(95, 14)
        Label32.TabIndex = 76
        Label32.Text = "Other Discount :"
        Label32.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label33.Location = New Point(9, 349)
        Label33.Name = "Label33"
        Label33.Size = New Size(101, 14)
        Label33.TabIndex = 75
        Label33.Text = "Promo Discount :"
        Label33.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(LblGrandTotal)
        Panel3.Controls.Add(Label28)
        Panel3.Location = New Point(6, 391)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(262, 39)
        Panel3.TabIndex = 53
        ' 
        ' LblGrandTotal
        ' 
        LblGrandTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblGrandTotal.Location = New Point(130, 5)
        LblGrandTotal.Name = "LblGrandTotal"
        LblGrandTotal.Size = New Size(125, 27)
        LblGrandTotal.TabIndex = 73
        LblGrandTotal.Text = "0.00"
        LblGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label28
        ' 
        Label28.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label28.Location = New Point(3, 5)
        Label28.Name = "Label28"
        Label28.Size = New Size(152, 27)
        Label28.TabIndex = 74
        Label28.Text = "GRAND TOTAL :"
        Label28.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblEHamount
        ' 
        LblEHamount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEHamount.Location = New Point(215, 42)
        LblEHamount.Name = "LblEHamount"
        LblEHamount.Size = New Size(45, 14)
        LblEHamount.TabIndex = 72
        LblEHamount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblEGamount
        ' 
        LblEGamount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEGamount.Location = New Point(215, 62)
        LblEGamount.Name = "LblEGamount"
        LblEGamount.Size = New Size(45, 14)
        LblEGamount.TabIndex = 71
        LblEGamount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblDHamount
        ' 
        LblDHamount.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblDHamount.Location = New Point(215, 22)
        LblDHamount.Name = "LblDHamount"
        LblDHamount.Size = New Size(45, 14)
        LblDHamount.TabIndex = 70
        LblDHamount.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblEHprice
        ' 
        LblEHprice.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEHprice.Location = New Point(141, 41)
        LblEHprice.Name = "LblEHprice"
        LblEHprice.Size = New Size(53, 16)
        LblEHprice.TabIndex = 69
        LblEHprice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblEGprice
        ' 
        LblEGprice.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEGprice.Location = New Point(141, 61)
        LblEGprice.Name = "LblEGprice"
        LblEGprice.Size = New Size(53, 16)
        LblEGprice.TabIndex = 68
        LblEGprice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblDHprice
        ' 
        LblDHprice.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblDHprice.Location = New Point(141, 21)
        LblDHprice.Name = "LblDHprice"
        LblDHprice.Size = New Size(53, 16)
        LblDHprice.TabIndex = 67
        LblDHprice.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LblEHqty
        ' 
        LblEHqty.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEHqty.Location = New Point(116, 42)
        LblEHqty.Name = "LblEHqty"
        LblEHqty.Size = New Size(19, 14)
        LblEHqty.TabIndex = 66
        LblEHqty.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblEGqty
        ' 
        LblEGqty.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblEGqty.Location = New Point(116, 62)
        LblEGqty.Name = "LblEGqty"
        LblEGqty.Size = New Size(19, 14)
        LblEGqty.TabIndex = 65
        LblEGqty.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDHqty
        ' 
        LblDHqty.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblDHqty.Location = New Point(116, 22)
        LblDHqty.Name = "LblDHqty"
        LblDHqty.Size = New Size(19, 14)
        LblDHqty.TabIndex = 64
        LblDHqty.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label27.Location = New Point(86, 106)
        Label27.Name = "Label27"
        Label27.Size = New Size(102, 13)
        Label27.TabIndex = 63
        Label27.Text = "- GUEST ORDER(S) -"
        Label27.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label26.Location = New Point(9, 3)
        Label26.Name = "Label26"
        Label26.Size = New Size(66, 13)
        Label26.TabIndex = 62
        Label26.Text = "PARTICULAR"
        Label26.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label25.Location = New Point(215, 3)
        Label25.Name = "Label25"
        Label25.Size = New Size(53, 13)
        Label25.TabIndex = 61
        Label25.Text = "AMOUNT"
        Label25.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label24.Location = New Point(163, 3)
        Label24.Name = "Label24"
        Label24.Size = New Size(35, 13)
        Label24.TabIndex = 60
        Label24.Text = "PRICE"
        Label24.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label23.Location = New Point(113, 3)
        Label23.Name = "Label23"
        Label23.Size = New Size(27, 13)
        Label23.TabIndex = 59
        Label23.Text = "QTY"
        Label23.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(9, 42)
        Label22.Name = "Label22"
        Label22.Size = New Size(82, 14)
        Label22.TabIndex = 58
        Label22.Text = "Excess Hours"
        Label22.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(9, 62)
        Label21.Name = "Label21"
        Label21.Size = New Size(70, 14)
        Label21.TabIndex = 57
        Label21.Text = "Extra Guest"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(9, 22)
        Label20.Name = "Label20"
        Label20.Size = New Size(89, 14)
        Label20.TabIndex = 56
        Label20.Text = "Duration Hours"
        Label20.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblTransactionNo
        ' 
        LblTransactionNo.AutoSize = True
        LblTransactionNo.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblTransactionNo.ForeColor = Color.Black
        LblTransactionNo.Location = New Point(136, 5)
        LblTransactionNo.Name = "LblTransactionNo"
        LblTransactionNo.Size = New Size(14, 15)
        LblTransactionNo.TabIndex = 55
        LblTransactionNo.Text = "1"
        LblTransactionNo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(4, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 15)
        Label1.TabIndex = 54
        Label1.Text = "TRANSACTION NO."
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TxtComment
        ' 
        TxtComment.BorderStyle = BorderStyle.FixedSingle
        TxtComment.Font = New Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TxtComment.Location = New Point(797, 595)
        TxtComment.Multiline = True
        TxtComment.Name = "TxtComment"
        TxtComment.Size = New Size(276, 73)
        TxtComment.TabIndex = 51
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelMenu.BorderStyle = BorderStyle.FixedSingle
        PanelMenu.Controls.Add(DgMenu)
        PanelMenu.Controls.Add(Label18)
        PanelMenu.Controls.Add(Panel8)
        PanelMenu.Controls.Add(TxtSearchMenu)
        PanelMenu.Controls.Add(Label2)
        PanelMenu.Location = New Point(363, 273)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(428, 395)
        PanelMenu.TabIndex = 33
        ' 
        ' DgMenu
        ' 
        DgMenu.AllowUserToAddRows = False
        DgMenu.AllowUserToResizeColumns = False
        DgMenu.AllowUserToResizeRows = False
        DgMenu.BackgroundColor = Color.Black
        DgMenu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.Black
        DataGridViewCellStyle7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = Color.LimeGreen
        DataGridViewCellStyle7.SelectionBackColor = Color.Black
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        DgMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        DgMenu.ColumnHeadersHeight = 25
        DgMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgMenu.Columns.AddRange(New DataGridViewColumn() {Item_No, item_description, Item_Price, Item_Stocks, category})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.Black
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = Color.Lime
        DataGridViewCellStyle9.SelectionBackColor = Color.PaleGoldenrod
        DataGridViewCellStyle9.SelectionForeColor = Color.Navy
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DgMenu.DefaultCellStyle = DataGridViewCellStyle9
        DgMenu.EditMode = DataGridViewEditMode.EditProgrammatically
        DgMenu.Location = New Point(9, 60)
        DgMenu.Name = "DgMenu"
        DgMenu.ReadOnly = True
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.Black
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = Color.Lime
        DataGridViewCellStyle10.SelectionBackColor = Color.White
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        DgMenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        DgMenu.RowHeadersVisible = False
        DgMenu.RowTemplate.Height = 25
        DgMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgMenu.Size = New Size(407, 316)
        DgMenu.TabIndex = 47
        ' 
        ' Item_No
        ' 
        Item_No.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Item_No.HeaderText = "Item No."
        Item_No.Name = "Item_No"
        Item_No.ReadOnly = True
        Item_No.Resizable = DataGridViewTriState.True
        Item_No.Width = 89
        ' 
        ' item_description
        ' 
        item_description.FillWeight = 204.7619F
        item_description.HeaderText = "Description"
        item_description.Name = "item_description"
        item_description.ReadOnly = True
        item_description.Width = 215
        ' 
        ' Item_Price
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight
        Item_Price.DefaultCellStyle = DataGridViewCellStyle8
        Item_Price.FillWeight = 38.84012F
        Item_Price.HeaderText = "Price"
        Item_Price.Name = "Item_Price"
        Item_Price.ReadOnly = True
        Item_Price.Width = 41
        ' 
        ' Item_Stocks
        ' 
        Item_Stocks.FillWeight = 56.3979874F
        Item_Stocks.HeaderText = "Stocks"
        Item_Stocks.Name = "Item_Stocks"
        Item_Stocks.ReadOnly = True
        Item_Stocks.Width = 59
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
        Label18.Location = New Point(9, 375)
        Label18.Name = "Label18"
        Label18.Size = New Size(227, 13)
        Label18.TabIndex = 62
        Label18.Text = "*Double click an item to add it to guest order(s)"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(Label16)
        Panel8.Controls.Add(CbBevItems)
        Panel8.Controls.Add(CbFoods)
        Panel8.Location = New Point(224, 14)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(192, 40)
        Panel8.TabIndex = 54
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(-1, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(45, 14)
        Label16.TabIndex = 51
        Label16.Text = "FILTER:"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' CbBevItems
        ' 
        CbBevItems.AutoSize = True
        CbBevItems.Location = New Point(73, 16)
        CbBevItems.Name = "CbBevItems"
        CbBevItems.Size = New Size(113, 19)
        CbBevItems.TabIndex = 53
        CbBevItems.Text = "Bevereges/Items"
        CbBevItems.UseVisualStyleBackColor = True
        ' 
        ' CbFoods
        ' 
        CbFoods.AutoSize = True
        CbFoods.Location = New Point(3, 16)
        CbFoods.Name = "CbFoods"
        CbFoods.Size = New Size(58, 19)
        CbFoods.TabIndex = 52
        CbFoods.Text = "Foods"
        CbFoods.UseVisualStyleBackColor = True
        ' 
        ' TxtSearchMenu
        ' 
        TxtSearchMenu.BorderStyle = BorderStyle.FixedSingle
        TxtSearchMenu.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearchMenu.Location = New Point(10, 33)
        TxtSearchMenu.Name = "TxtSearchMenu"
        TxtSearchMenu.Size = New Size(163, 21)
        TxtSearchMenu.TabIndex = 51
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(-1, -1)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 22)
        Label2.TabIndex = 49
        Label2.Text = "MENU"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TimerRemainingTime
        ' 
        TimerRemainingTime.Interval = 1000
        ' 
        ' BtnCheckOut
        ' 
        BtnCheckOut.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnCheckOut.FlatAppearance.BorderColor = Color.White
        BtnCheckOut.FlatStyle = FlatStyle.Flat
        BtnCheckOut.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCheckOut.ForeColor = Color.Black
        BtnCheckOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket
        BtnCheckOut.IconColor = Color.Black
        BtnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCheckOut.IconSize = 30
        BtnCheckOut.Location = New Point(12, 613)
        BtnCheckOut.Name = "BtnCheckOut"
        BtnCheckOut.Size = New Size(339, 55)
        BtnCheckOut.TabIndex = 36
        BtnCheckOut.Text = "PROCESS CHECK-OUT"
        BtnCheckOut.TextAlign = ContentAlignment.MiddleRight
        BtnCheckOut.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCheckOut.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(LblCurrentRoom)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(12, 273)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(339, 263)
        Panel5.TabIndex = 37
        ' 
        ' LblCurrentRoom
        ' 
        LblCurrentRoom.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblCurrentRoom.Font = New Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point)
        LblCurrentRoom.ForeColor = Color.Black
        LblCurrentRoom.Location = New Point(12, 3)
        LblCurrentRoom.Name = "LblCurrentRoom"
        LblCurrentRoom.Size = New Size(313, 58)
        LblCurrentRoom.TabIndex = 40
        LblCurrentRoom.Text = "ROOM NO. 00"
        LblCurrentRoom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(LblRTDes)
        Panel7.Controls.Add(LblRemainingTime)
        Panel7.Location = New Point(12, 150)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(313, 103)
        Panel7.TabIndex = 37
        ' 
        ' LblRTDes
        ' 
        LblRTDes.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblRTDes.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        LblRTDes.Location = New Point(62, 57)
        LblRTDes.Name = "LblRTDes"
        LblRTDes.Size = New Size(190, 30)
        LblRTDes.TabIndex = 34
        LblRTDes.Text = "REMAINING TIME"
        LblRTDes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblRemainingTime
        ' 
        LblRemainingTime.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        LblRemainingTime.FlatStyle = FlatStyle.Flat
        LblRemainingTime.Font = New Font("OCR A Extended", 36F, FontStyle.Bold, GraphicsUnit.Point)
        LblRemainingTime.ForeColor = Color.Black
        LblRemainingTime.Location = New Point(20, 5)
        LblRemainingTime.Name = "LblRemainingTime"
        LblRemainingTime.Size = New Size(272, 58)
        LblRemainingTime.TabIndex = 35
        LblRemainingTime.Text = "00:00:00"
        LblRemainingTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Label14)
        Panel6.Controls.Add(LblRoomStatus)
        Panel6.Location = New Point(12, 68)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(313, 74)
        Panel6.TabIndex = 36
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        Label14.Location = New Point(92, 43)
        Label14.Name = "Label14"
        Label14.Size = New Size(119, 21)
        Label14.TabIndex = 38
        Label14.Text = "ROOM STATUS"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblRoomStatus
        ' 
        LblRoomStatus.Font = New Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblRoomStatus.ForeColor = Color.Black
        LblRoomStatus.Location = New Point(3, -2)
        LblRoomStatus.Name = "LblRoomStatus"
        LblRoomStatus.Size = New Size(305, 52)
        LblRoomStatus.TabIndex = 37
        LblRoomStatus.Text = "AVAILABLE"
        LblRoomStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnCancel.FlatAppearance.BorderColor = Color.White
        BtnCancel.FlatStyle = FlatStyle.Flat
        BtnCancel.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnCancel.ForeColor = Color.White
        BtnCancel.Location = New Point(12, 547)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(164, 55)
        BtnCancel.TabIndex = 38
        BtnCancel.Text = "Cancel Booking"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' BtnTransfer
        ' 
        BtnTransfer.BackColor = Color.FromArgb(CByte(44), CByte(69), CByte(110))
        BtnTransfer.FlatAppearance.BorderColor = Color.White
        BtnTransfer.FlatStyle = FlatStyle.Flat
        BtnTransfer.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnTransfer.ForeColor = Color.White
        BtnTransfer.Location = New Point(187, 547)
        BtnTransfer.Name = "BtnTransfer"
        BtnTransfer.Size = New Size(164, 55)
        BtnTransfer.TabIndex = 39
        BtnTransfer.Text = "Transfer Room"
        BtnTransfer.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(LblTransactionNo)
        Panel4.Location = New Point(797, 95)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(276, 27)
        Panel4.TabIndex = 52
        ' 
        ' Label35
        ' 
        Label35.AutoSize = True
        Label35.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label35.ForeColor = Color.Black
        Label35.Location = New Point(795, 575)
        Label35.Name = "Label35"
        Label35.Size = New Size(72, 16)
        Label35.TabIndex = 53
        Label35.Text = "Comment:"
        Label35.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FrmTransactGuest
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        ClientSize = New Size(1084, 680)
        Controls.Add(Label35)
        Controls.Add(Panel4)
        Controls.Add(BtnTransfer)
        Controls.Add(BtnCancel)
        Controls.Add(TxtComment)
        Controls.Add(Panel5)
        Controls.Add(BtnCheckOut)
        Controls.Add(BtnCheckIn)
        Controls.Add(PanelMenu)
        Controls.Add(PanelTransact)
        Controls.Add(PanelGuestDetails)
        Controls.Add(Panel1)
        Controls.Add(BtnBack)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmTransactGuest"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelGuestDetails.ResumeLayout(False)
        PanelGuestDetails.PerformLayout()
        PanelTransact.ResumeLayout(False)
        PanelTransact.PerformLayout()
        CType(DGTransact, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        CType(DgMenu, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnBack As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblCheckInTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents BtnCheckIn As FontAwesome.Sharp.IconButton
    Friend WithEvents CbbDescription As ComboBox
    Friend WithEvents LblHAvailed As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents PanelGuestDetails As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPlateNo As TextBox
    Friend WithEvents TxtVtype As TextBox
    Friend WithEvents TxtContactNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelTransact As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents CbbGType As ComboBox
    Friend WithEvents DgMenu As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents CbbGuestCount As ComboBox
    Friend WithEvents TimerRemainingTime As Timer
    Friend WithEvents BtnCheckOut As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblRemainingTime As Label
    Friend WithEvents LblRTDes As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents LblRoomStatus As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnTransfer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSearchMenu As TextBox
    Friend WithEvents CbBevItems As CheckBox
    Friend WithEvents CbFoods As CheckBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents LblCurrentRoom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblTransactionNo As Label
    Public WithEvents DGTransact As DataGridView
    Friend WithEvents TxtComment As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents LblDHqty As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents LblEHamount As Label
    Friend WithEvents LblEGamount As Label
    Friend WithEvents LblDHamount As Label
    Friend WithEvents LblEHprice As Label
    Friend WithEvents LblEGprice As Label
    Friend WithEvents LblDHprice As Label
    Friend WithEvents LblEHqty As Label
    Friend WithEvents LblEGqty As Label
    Friend WithEvents ItemNo As DataGridViewTextBoxColumn
    Friend WithEvents Particulars As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Tcategory As DataGridViewTextBoxColumn
    Friend WithEvents Label28 As Label
    Friend WithEvents LblGrandTotal As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents CbbPromo As ComboBox
    Friend WithEvents Promo As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents LblGDiscount As Label
    Friend WithEvents LblPromoDiscount As Label
    Friend WithEvents txtOtherDiscount As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents LblOtherDiscount As Label
    Friend WithEvents LblAddOn As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtSeniorNo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LblODPercentage As Label
    Friend WithEvents LblGTPercentage As Label
    Friend WithEvents LblPDPercentage As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents LblPartialTotal As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Item_No As DataGridViewTextBoxColumn
    Friend WithEvents item_description As DataGridViewTextBoxColumn
    Friend WithEvents Item_Price As DataGridViewTextBoxColumn
    Friend WithEvents Item_Stocks As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents Label35 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label36 As Label
End Class
