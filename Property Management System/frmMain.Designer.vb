<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        PanelTitlebar = New Panel()
        Label1 = New Label()
        LblMinimize = New Label()
        PictureBox6 = New PictureBox()
        PanelSideMenu = New Panel()
        PanelSettingSubMenu = New Panel()
        BtnOther = New FontAwesome.Sharp.IconButton()
        BtnUsersMenu = New FontAwesome.Sharp.IconButton()
        BtnSetting = New FontAwesome.Sharp.IconButton()
        PanelReportsSubMenu = New Panel()
        BtnUserLog = New FontAwesome.Sharp.IconButton()
        BtnVoidLog = New FontAwesome.Sharp.IconButton()
        BtnHouseKeepingLog = New FontAwesome.Sharp.IconButton()
        BtnTransactionLog = New FontAwesome.Sharp.IconButton()
        Btn12Hours = New FontAwesome.Sharp.IconButton()
        BtnSubEmployees = New FontAwesome.Sharp.IconButton()
        BtnExpenses = New FontAwesome.Sharp.IconButton()
        BtnSales = New FontAwesome.Sharp.IconButton()
        BtnReports = New FontAwesome.Sharp.IconButton()
        PanelInventorySubMenu = New Panel()
        BtnMiscellaneous = New FontAwesome.Sharp.IconButton()
        BtnBeverages = New FontAwesome.Sharp.IconButton()
        BtnKitchen = New FontAwesome.Sharp.IconButton()
        BtnInventory = New FontAwesome.Sharp.IconButton()
        PanelBillingsSubMenu = New Panel()
        BtnVoid = New FontAwesome.Sharp.IconButton()
        BtnRates = New FontAwesome.Sharp.IconButton()
        BtnRefund = New FontAwesome.Sharp.IconButton()
        BtnCashOut = New FontAwesome.Sharp.IconButton()
        BtnEmployeesCredit = New FontAwesome.Sharp.IconButton()
        BtnBilling = New FontAwesome.Sharp.IconButton()
        BtnReservation = New FontAwesome.Sharp.IconButton()
        BtnRooms = New FontAwesome.Sharp.IconButton()
        BtnDashboard = New FontAwesome.Sharp.IconButton()
        PanelHeader = New Panel()
        LblClock = New Label()
        Panel3 = New Panel()
        BtnLogOut = New FontAwesome.Sharp.IconButton()
        BtnCashUp = New FontAwesome.Sharp.IconButton()
        LblMaintenance = New Label()
        LblReserve = New Label()
        LblOccupied = New Label()
        LblHousekeeping = New Label()
        LblAvailable = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        LblID = New Label()
        Label6 = New Label()
        PictureBox5 = New PictureBox()
        LblPosition = New Label()
        LblName = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PanelMain = New Panel()
        TmrClock = New Timer(components)
        PanelTitlebar.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        PanelSideMenu.SuspendLayout()
        PanelSettingSubMenu.SuspendLayout()
        PanelReportsSubMenu.SuspendLayout()
        PanelInventorySubMenu.SuspendLayout()
        PanelBillingsSubMenu.SuspendLayout()
        PanelHeader.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitlebar
        ' 
        PanelTitlebar.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelTitlebar.BorderStyle = BorderStyle.FixedSingle
        PanelTitlebar.Controls.Add(Label1)
        PanelTitlebar.Controls.Add(LblMinimize)
        PanelTitlebar.Controls.Add(PictureBox6)
        PanelTitlebar.Dock = DockStyle.Top
        PanelTitlebar.Location = New Point(0, 0)
        PanelTitlebar.Name = "PanelTitlebar"
        PanelTitlebar.Size = New Size(1330, 32)
        PanelTitlebar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        Label1.Location = New Point(1299, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 32)
        Label1.TabIndex = 6
        Label1.Text = "x"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMinimize
        ' 
        LblMinimize.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        LblMinimize.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        LblMinimize.Location = New Point(1269, 1)
        LblMinimize.Name = "LblMinimize"
        LblMinimize.Size = New Size(30, 30)
        LblMinimize.TabIndex = 8
        LblMinimize.Text = "_"
        LblMinimize.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.property_management_system_logo_long
        PictureBox6.Location = New Point(3, -6)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(296, 43)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' PanelSideMenu
        ' 
        PanelSideMenu.AutoScroll = True
        PanelSideMenu.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        PanelSideMenu.Controls.Add(PanelSettingSubMenu)
        PanelSideMenu.Controls.Add(BtnSetting)
        PanelSideMenu.Controls.Add(PanelReportsSubMenu)
        PanelSideMenu.Controls.Add(BtnReports)
        PanelSideMenu.Controls.Add(PanelInventorySubMenu)
        PanelSideMenu.Controls.Add(BtnInventory)
        PanelSideMenu.Controls.Add(PanelBillingsSubMenu)
        PanelSideMenu.Controls.Add(BtnBilling)
        PanelSideMenu.Controls.Add(BtnReservation)
        PanelSideMenu.Controls.Add(BtnRooms)
        PanelSideMenu.Controls.Add(BtnDashboard)
        PanelSideMenu.Controls.Add(PanelHeader)
        PanelSideMenu.Dock = DockStyle.Left
        PanelSideMenu.Location = New Point(0, 32)
        PanelSideMenu.Name = "PanelSideMenu"
        PanelSideMenu.Size = New Size(246, 828)
        PanelSideMenu.TabIndex = 1
        ' 
        ' PanelSettingSubMenu
        ' 
        PanelSettingSubMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelSettingSubMenu.Controls.Add(BtnOther)
        PanelSettingSubMenu.Controls.Add(BtnUsersMenu)
        PanelSettingSubMenu.Dock = DockStyle.Top
        PanelSettingSubMenu.Location = New Point(0, 1280)
        PanelSettingSubMenu.Name = "PanelSettingSubMenu"
        PanelSettingSubMenu.Size = New Size(229, 95)
        PanelSettingSubMenu.TabIndex = 23
        ' 
        ' BtnOther
        ' 
        BtnOther.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnOther.Dock = DockStyle.Top
        BtnOther.FlatAppearance.BorderSize = 0
        BtnOther.FlatStyle = FlatStyle.Flat
        BtnOther.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnOther.ForeColor = Color.Black
        BtnOther.IconChar = FontAwesome.Sharp.IconChar.Gears
        BtnOther.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnOther.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnOther.IconSize = 25
        BtnOther.ImageAlign = ContentAlignment.MiddleLeft
        BtnOther.Location = New Point(0, 43)
        BtnOther.Name = "BtnOther"
        BtnOther.Padding = New Padding(35, 0, 0, 0)
        BtnOther.Size = New Size(229, 43)
        BtnOther.TabIndex = 7
        BtnOther.Text = "OTHER"
        BtnOther.TextAlign = ContentAlignment.MiddleLeft
        BtnOther.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnOther.UseVisualStyleBackColor = False
        ' 
        ' BtnUsersMenu
        ' 
        BtnUsersMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnUsersMenu.Dock = DockStyle.Top
        BtnUsersMenu.FlatAppearance.BorderSize = 0
        BtnUsersMenu.FlatStyle = FlatStyle.Flat
        BtnUsersMenu.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUsersMenu.ForeColor = Color.Black
        BtnUsersMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup
        BtnUsersMenu.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnUsersMenu.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnUsersMenu.IconSize = 25
        BtnUsersMenu.ImageAlign = ContentAlignment.MiddleLeft
        BtnUsersMenu.Location = New Point(0, 0)
        BtnUsersMenu.Name = "BtnUsersMenu"
        BtnUsersMenu.Padding = New Padding(35, 0, 0, 0)
        BtnUsersMenu.Size = New Size(229, 43)
        BtnUsersMenu.TabIndex = 6
        BtnUsersMenu.Text = "USERS"
        BtnUsersMenu.TextAlign = ContentAlignment.MiddleLeft
        BtnUsersMenu.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnUsersMenu.UseVisualStyleBackColor = False
        ' 
        ' BtnSetting
        ' 
        BtnSetting.Dock = DockStyle.Top
        BtnSetting.FlatAppearance.BorderSize = 0
        BtnSetting.FlatStyle = FlatStyle.Flat
        BtnSetting.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSetting.ForeColor = Color.Black
        BtnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear
        BtnSetting.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnSetting.IconSize = 30
        BtnSetting.ImageAlign = ContentAlignment.MiddleLeft
        BtnSetting.Location = New Point(0, 1220)
        BtnSetting.Name = "BtnSetting"
        BtnSetting.Padding = New Padding(20, 0, 0, 0)
        BtnSetting.Size = New Size(229, 60)
        BtnSetting.TabIndex = 22
        BtnSetting.Text = "SETTINGS"
        BtnSetting.TextAlign = ContentAlignment.MiddleLeft
        BtnSetting.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSetting.UseVisualStyleBackColor = True
        ' 
        ' PanelReportsSubMenu
        ' 
        PanelReportsSubMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelReportsSubMenu.Controls.Add(BtnUserLog)
        PanelReportsSubMenu.Controls.Add(BtnVoidLog)
        PanelReportsSubMenu.Controls.Add(BtnHouseKeepingLog)
        PanelReportsSubMenu.Controls.Add(BtnTransactionLog)
        PanelReportsSubMenu.Controls.Add(Btn12Hours)
        PanelReportsSubMenu.Controls.Add(BtnSubEmployees)
        PanelReportsSubMenu.Controls.Add(BtnExpenses)
        PanelReportsSubMenu.Controls.Add(BtnSales)
        PanelReportsSubMenu.Dock = DockStyle.Top
        PanelReportsSubMenu.Location = New Point(0, 869)
        PanelReportsSubMenu.Name = "PanelReportsSubMenu"
        PanelReportsSubMenu.Size = New Size(229, 351)
        PanelReportsSubMenu.TabIndex = 21
        ' 
        ' BtnUserLog
        ' 
        BtnUserLog.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnUserLog.Dock = DockStyle.Top
        BtnUserLog.FlatAppearance.BorderSize = 0
        BtnUserLog.FlatStyle = FlatStyle.Flat
        BtnUserLog.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUserLog.ForeColor = Color.Black
        BtnUserLog.IconChar = FontAwesome.Sharp.IconChar.FileText
        BtnUserLog.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnUserLog.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnUserLog.IconSize = 25
        BtnUserLog.ImageAlign = ContentAlignment.MiddleLeft
        BtnUserLog.Location = New Point(0, 301)
        BtnUserLog.Name = "BtnUserLog"
        BtnUserLog.Padding = New Padding(35, 0, 0, 0)
        BtnUserLog.Size = New Size(229, 43)
        BtnUserLog.TabIndex = 20
        BtnUserLog.Text = "USER LOG"
        BtnUserLog.TextAlign = ContentAlignment.MiddleLeft
        BtnUserLog.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnUserLog.UseVisualStyleBackColor = False
        ' 
        ' BtnVoidLog
        ' 
        BtnVoidLog.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnVoidLog.Dock = DockStyle.Top
        BtnVoidLog.FlatAppearance.BorderSize = 0
        BtnVoidLog.FlatStyle = FlatStyle.Flat
        BtnVoidLog.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnVoidLog.ForeColor = Color.Black
        BtnVoidLog.IconChar = FontAwesome.Sharp.IconChar.FileText
        BtnVoidLog.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnVoidLog.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnVoidLog.IconSize = 25
        BtnVoidLog.ImageAlign = ContentAlignment.MiddleLeft
        BtnVoidLog.Location = New Point(0, 258)
        BtnVoidLog.Name = "BtnVoidLog"
        BtnVoidLog.Padding = New Padding(35, 0, 0, 0)
        BtnVoidLog.Size = New Size(229, 43)
        BtnVoidLog.TabIndex = 19
        BtnVoidLog.Text = "VOID LOG"
        BtnVoidLog.TextAlign = ContentAlignment.MiddleLeft
        BtnVoidLog.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnVoidLog.UseVisualStyleBackColor = False
        ' 
        ' BtnHouseKeepingLog
        ' 
        BtnHouseKeepingLog.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnHouseKeepingLog.Dock = DockStyle.Top
        BtnHouseKeepingLog.FlatAppearance.BorderSize = 0
        BtnHouseKeepingLog.FlatStyle = FlatStyle.Flat
        BtnHouseKeepingLog.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHouseKeepingLog.ForeColor = Color.Black
        BtnHouseKeepingLog.IconChar = FontAwesome.Sharp.IconChar.FileText
        BtnHouseKeepingLog.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnHouseKeepingLog.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnHouseKeepingLog.IconSize = 25
        BtnHouseKeepingLog.ImageAlign = ContentAlignment.MiddleLeft
        BtnHouseKeepingLog.Location = New Point(0, 215)
        BtnHouseKeepingLog.Name = "BtnHouseKeepingLog"
        BtnHouseKeepingLog.Padding = New Padding(35, 0, 0, 0)
        BtnHouseKeepingLog.Size = New Size(229, 43)
        BtnHouseKeepingLog.TabIndex = 18
        BtnHouseKeepingLog.Text = "HOUSEKEEPING LOG"
        BtnHouseKeepingLog.TextAlign = ContentAlignment.MiddleLeft
        BtnHouseKeepingLog.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnHouseKeepingLog.UseVisualStyleBackColor = False
        ' 
        ' BtnTransactionLog
        ' 
        BtnTransactionLog.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnTransactionLog.Dock = DockStyle.Top
        BtnTransactionLog.FlatAppearance.BorderSize = 0
        BtnTransactionLog.FlatStyle = FlatStyle.Flat
        BtnTransactionLog.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnTransactionLog.ForeColor = Color.Black
        BtnTransactionLog.IconChar = FontAwesome.Sharp.IconChar.FileText
        BtnTransactionLog.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnTransactionLog.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnTransactionLog.IconSize = 25
        BtnTransactionLog.ImageAlign = ContentAlignment.MiddleLeft
        BtnTransactionLog.Location = New Point(0, 172)
        BtnTransactionLog.Name = "BtnTransactionLog"
        BtnTransactionLog.Padding = New Padding(35, 0, 0, 0)
        BtnTransactionLog.Size = New Size(229, 43)
        BtnTransactionLog.TabIndex = 17
        BtnTransactionLog.Text = "TRANSACTION LOG"
        BtnTransactionLog.TextAlign = ContentAlignment.MiddleLeft
        BtnTransactionLog.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnTransactionLog.UseVisualStyleBackColor = False
        ' 
        ' Btn12Hours
        ' 
        Btn12Hours.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Btn12Hours.Dock = DockStyle.Top
        Btn12Hours.FlatAppearance.BorderSize = 0
        Btn12Hours.FlatStyle = FlatStyle.Flat
        Btn12Hours.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Btn12Hours.ForeColor = Color.Black
        Btn12Hours.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf
        Btn12Hours.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        Btn12Hours.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btn12Hours.IconSize = 25
        Btn12Hours.ImageAlign = ContentAlignment.MiddleLeft
        Btn12Hours.Location = New Point(0, 129)
        Btn12Hours.Name = "Btn12Hours"
        Btn12Hours.Padding = New Padding(35, 0, 0, 0)
        Btn12Hours.Size = New Size(229, 43)
        Btn12Hours.TabIndex = 11
        Btn12Hours.Text = "12 HOURS CUT-OFF REPORT"
        Btn12Hours.TextAlign = ContentAlignment.MiddleLeft
        Btn12Hours.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn12Hours.UseVisualStyleBackColor = False
        ' 
        ' BtnSubEmployees
        ' 
        BtnSubEmployees.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnSubEmployees.Dock = DockStyle.Top
        BtnSubEmployees.FlatAppearance.BorderSize = 0
        BtnSubEmployees.FlatStyle = FlatStyle.Flat
        BtnSubEmployees.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSubEmployees.ForeColor = Color.Black
        BtnSubEmployees.IconChar = FontAwesome.Sharp.IconChar.UsersLine
        BtnSubEmployees.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnSubEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnSubEmployees.IconSize = 25
        BtnSubEmployees.ImageAlign = ContentAlignment.MiddleLeft
        BtnSubEmployees.Location = New Point(0, 86)
        BtnSubEmployees.Name = "BtnSubEmployees"
        BtnSubEmployees.Padding = New Padding(35, 0, 0, 0)
        BtnSubEmployees.Size = New Size(229, 43)
        BtnSubEmployees.TabIndex = 8
        BtnSubEmployees.Text = "EMPLOYEER'S CREDIT"
        BtnSubEmployees.TextAlign = ContentAlignment.MiddleLeft
        BtnSubEmployees.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSubEmployees.UseVisualStyleBackColor = False
        ' 
        ' BtnExpenses
        ' 
        BtnExpenses.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnExpenses.Dock = DockStyle.Top
        BtnExpenses.FlatAppearance.BorderSize = 0
        BtnExpenses.FlatStyle = FlatStyle.Flat
        BtnExpenses.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnExpenses.ForeColor = Color.Black
        BtnExpenses.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer
        BtnExpenses.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnExpenses.IconSize = 25
        BtnExpenses.ImageAlign = ContentAlignment.MiddleLeft
        BtnExpenses.Location = New Point(0, 43)
        BtnExpenses.Name = "BtnExpenses"
        BtnExpenses.Padding = New Padding(35, 0, 0, 0)
        BtnExpenses.Size = New Size(229, 43)
        BtnExpenses.TabIndex = 7
        BtnExpenses.Text = "EXPENSES"
        BtnExpenses.TextAlign = ContentAlignment.MiddleLeft
        BtnExpenses.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnExpenses.UseVisualStyleBackColor = False
        ' 
        ' BtnSales
        ' 
        BtnSales.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnSales.Dock = DockStyle.Top
        BtnSales.FlatAppearance.BorderSize = 0
        BtnSales.FlatStyle = FlatStyle.Flat
        BtnSales.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSales.ForeColor = Color.Black
        BtnSales.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        BtnSales.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnSales.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnSales.IconSize = 25
        BtnSales.ImageAlign = ContentAlignment.MiddleLeft
        BtnSales.Location = New Point(0, 0)
        BtnSales.Name = "BtnSales"
        BtnSales.Padding = New Padding(35, 0, 0, 0)
        BtnSales.Size = New Size(229, 43)
        BtnSales.TabIndex = 6
        BtnSales.Text = "SALES"
        BtnSales.TextAlign = ContentAlignment.MiddleLeft
        BtnSales.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSales.UseVisualStyleBackColor = False
        ' 
        ' BtnReports
        ' 
        BtnReports.Dock = DockStyle.Top
        BtnReports.FlatAppearance.BorderSize = 0
        BtnReports.FlatStyle = FlatStyle.Flat
        BtnReports.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnReports.ForeColor = Color.Black
        BtnReports.IconChar = FontAwesome.Sharp.IconChar.FileText
        BtnReports.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnReports.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnReports.IconSize = 30
        BtnReports.ImageAlign = ContentAlignment.MiddleLeft
        BtnReports.Location = New Point(0, 809)
        BtnReports.Name = "BtnReports"
        BtnReports.Padding = New Padding(20, 0, 0, 0)
        BtnReports.Size = New Size(229, 60)
        BtnReports.TabIndex = 20
        BtnReports.Text = "REPORTS"
        BtnReports.TextAlign = ContentAlignment.MiddleLeft
        BtnReports.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnReports.UseVisualStyleBackColor = True
        ' 
        ' PanelInventorySubMenu
        ' 
        PanelInventorySubMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelInventorySubMenu.Controls.Add(BtnMiscellaneous)
        PanelInventorySubMenu.Controls.Add(BtnBeverages)
        PanelInventorySubMenu.Controls.Add(BtnKitchen)
        PanelInventorySubMenu.Dock = DockStyle.Top
        PanelInventorySubMenu.Location = New Point(0, 670)
        PanelInventorySubMenu.Name = "PanelInventorySubMenu"
        PanelInventorySubMenu.Size = New Size(229, 139)
        PanelInventorySubMenu.TabIndex = 19
        ' 
        ' BtnMiscellaneous
        ' 
        BtnMiscellaneous.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnMiscellaneous.Dock = DockStyle.Top
        BtnMiscellaneous.FlatAppearance.BorderSize = 0
        BtnMiscellaneous.FlatStyle = FlatStyle.Flat
        BtnMiscellaneous.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnMiscellaneous.ForeColor = Color.Black
        BtnMiscellaneous.IconChar = FontAwesome.Sharp.IconChar.Warehouse
        BtnMiscellaneous.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnMiscellaneous.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnMiscellaneous.IconSize = 25
        BtnMiscellaneous.ImageAlign = ContentAlignment.MiddleLeft
        BtnMiscellaneous.Location = New Point(0, 86)
        BtnMiscellaneous.Name = "BtnMiscellaneous"
        BtnMiscellaneous.Padding = New Padding(35, 0, 0, 0)
        BtnMiscellaneous.Size = New Size(229, 46)
        BtnMiscellaneous.TabIndex = 8
        BtnMiscellaneous.Text = "MISCELLANEOUS"
        BtnMiscellaneous.TextAlign = ContentAlignment.MiddleLeft
        BtnMiscellaneous.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnMiscellaneous.UseVisualStyleBackColor = False
        ' 
        ' BtnBeverages
        ' 
        BtnBeverages.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnBeverages.Dock = DockStyle.Top
        BtnBeverages.FlatAppearance.BorderSize = 0
        BtnBeverages.FlatStyle = FlatStyle.Flat
        BtnBeverages.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBeverages.ForeColor = Color.Black
        BtnBeverages.IconChar = FontAwesome.Sharp.IconChar.WineBottle
        BtnBeverages.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnBeverages.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnBeverages.IconSize = 25
        BtnBeverages.ImageAlign = ContentAlignment.MiddleLeft
        BtnBeverages.Location = New Point(0, 43)
        BtnBeverages.Name = "BtnBeverages"
        BtnBeverages.Padding = New Padding(35, 0, 0, 0)
        BtnBeverages.Size = New Size(229, 43)
        BtnBeverages.TabIndex = 7
        BtnBeverages.Text = "BEVERAGES AND ITEMS"
        BtnBeverages.TextAlign = ContentAlignment.MiddleLeft
        BtnBeverages.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnBeverages.UseVisualStyleBackColor = False
        ' 
        ' BtnKitchen
        ' 
        BtnKitchen.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnKitchen.Dock = DockStyle.Top
        BtnKitchen.FlatAppearance.BorderSize = 0
        BtnKitchen.FlatStyle = FlatStyle.Flat
        BtnKitchen.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnKitchen.ForeColor = Color.Black
        BtnKitchen.IconChar = FontAwesome.Sharp.IconChar.CubesStacked
        BtnKitchen.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnKitchen.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnKitchen.IconSize = 25
        BtnKitchen.ImageAlign = ContentAlignment.MiddleLeft
        BtnKitchen.Location = New Point(0, 0)
        BtnKitchen.Name = "BtnKitchen"
        BtnKitchen.Padding = New Padding(35, 0, 0, 0)
        BtnKitchen.Size = New Size(229, 43)
        BtnKitchen.TabIndex = 6
        BtnKitchen.Text = "KITCHEN"
        BtnKitchen.TextAlign = ContentAlignment.MiddleLeft
        BtnKitchen.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnKitchen.UseVisualStyleBackColor = False
        ' 
        ' BtnInventory
        ' 
        BtnInventory.Dock = DockStyle.Top
        BtnInventory.FlatAppearance.BorderSize = 0
        BtnInventory.FlatStyle = FlatStyle.Flat
        BtnInventory.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnInventory.ForeColor = Color.Black
        BtnInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt
        BtnInventory.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnInventory.IconSize = 30
        BtnInventory.ImageAlign = ContentAlignment.MiddleLeft
        BtnInventory.Location = New Point(0, 610)
        BtnInventory.Name = "BtnInventory"
        BtnInventory.Padding = New Padding(20, 0, 0, 0)
        BtnInventory.Size = New Size(229, 60)
        BtnInventory.TabIndex = 18
        BtnInventory.Text = "INVENTORY"
        BtnInventory.TextAlign = ContentAlignment.MiddleLeft
        BtnInventory.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnInventory.UseVisualStyleBackColor = True
        ' 
        ' PanelBillingsSubMenu
        ' 
        PanelBillingsSubMenu.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PanelBillingsSubMenu.Controls.Add(BtnVoid)
        PanelBillingsSubMenu.Controls.Add(BtnRates)
        PanelBillingsSubMenu.Controls.Add(BtnRefund)
        PanelBillingsSubMenu.Controls.Add(BtnCashOut)
        PanelBillingsSubMenu.Controls.Add(BtnEmployeesCredit)
        PanelBillingsSubMenu.Dock = DockStyle.Top
        PanelBillingsSubMenu.Location = New Point(0, 389)
        PanelBillingsSubMenu.Name = "PanelBillingsSubMenu"
        PanelBillingsSubMenu.Size = New Size(229, 221)
        PanelBillingsSubMenu.TabIndex = 17
        ' 
        ' BtnVoid
        ' 
        BtnVoid.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnVoid.Dock = DockStyle.Top
        BtnVoid.FlatAppearance.BorderSize = 0
        BtnVoid.FlatStyle = FlatStyle.Flat
        BtnVoid.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnVoid.ForeColor = Color.Black
        BtnVoid.IconChar = FontAwesome.Sharp.IconChar.Backspace
        BtnVoid.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnVoid.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnVoid.IconSize = 25
        BtnVoid.ImageAlign = ContentAlignment.MiddleLeft
        BtnVoid.Location = New Point(0, 172)
        BtnVoid.Name = "BtnVoid"
        BtnVoid.Padding = New Padding(35, 0, 0, 0)
        BtnVoid.Size = New Size(229, 43)
        BtnVoid.TabIndex = 10
        BtnVoid.Text = "VOID"
        BtnVoid.TextAlign = ContentAlignment.MiddleLeft
        BtnVoid.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnVoid.UseVisualStyleBackColor = False
        ' 
        ' BtnRates
        ' 
        BtnRates.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnRates.Dock = DockStyle.Top
        BtnRates.FlatAppearance.BorderSize = 0
        BtnRates.FlatStyle = FlatStyle.Flat
        BtnRates.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnRates.ForeColor = Color.Black
        BtnRates.IconChar = FontAwesome.Sharp.IconChar.Gears
        BtnRates.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnRates.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnRates.IconSize = 25
        BtnRates.ImageAlign = ContentAlignment.MiddleLeft
        BtnRates.Location = New Point(0, 129)
        BtnRates.Name = "BtnRates"
        BtnRates.Padding = New Padding(35, 0, 0, 0)
        BtnRates.Size = New Size(229, 43)
        BtnRates.TabIndex = 9
        BtnRates.Text = "RATES AND PRICING"
        BtnRates.TextAlign = ContentAlignment.MiddleLeft
        BtnRates.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnRates.UseVisualStyleBackColor = False
        ' 
        ' BtnRefund
        ' 
        BtnRefund.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnRefund.Dock = DockStyle.Top
        BtnRefund.FlatAppearance.BorderSize = 0
        BtnRefund.FlatStyle = FlatStyle.Flat
        BtnRefund.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnRefund.ForeColor = Color.Black
        BtnRefund.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd
        BtnRefund.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnRefund.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnRefund.IconSize = 25
        BtnRefund.ImageAlign = ContentAlignment.MiddleLeft
        BtnRefund.Location = New Point(0, 86)
        BtnRefund.Name = "BtnRefund"
        BtnRefund.Padding = New Padding(35, 0, 0, 0)
        BtnRefund.Size = New Size(229, 43)
        BtnRefund.TabIndex = 8
        BtnRefund.Text = "REFUND PROCESSING"
        BtnRefund.TextAlign = ContentAlignment.MiddleLeft
        BtnRefund.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnRefund.UseVisualStyleBackColor = False
        ' 
        ' BtnCashOut
        ' 
        BtnCashOut.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnCashOut.Dock = DockStyle.Top
        BtnCashOut.FlatAppearance.BorderSize = 0
        BtnCashOut.FlatStyle = FlatStyle.Flat
        BtnCashOut.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCashOut.ForeColor = Color.Black
        BtnCashOut.IconChar = FontAwesome.Sharp.IconChar.MoneyBills
        BtnCashOut.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnCashOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCashOut.IconSize = 25
        BtnCashOut.ImageAlign = ContentAlignment.MiddleLeft
        BtnCashOut.Location = New Point(0, 43)
        BtnCashOut.Name = "BtnCashOut"
        BtnCashOut.Padding = New Padding(35, 0, 0, 0)
        BtnCashOut.Size = New Size(229, 43)
        BtnCashOut.TabIndex = 7
        BtnCashOut.Text = "CASH-OUT"
        BtnCashOut.TextAlign = ContentAlignment.MiddleLeft
        BtnCashOut.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCashOut.UseVisualStyleBackColor = False
        ' 
        ' BtnEmployeesCredit
        ' 
        BtnEmployeesCredit.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnEmployeesCredit.Dock = DockStyle.Top
        BtnEmployeesCredit.FlatAppearance.BorderSize = 0
        BtnEmployeesCredit.FlatStyle = FlatStyle.Flat
        BtnEmployeesCredit.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEmployeesCredit.ForeColor = Color.Black
        BtnEmployeesCredit.IconChar = FontAwesome.Sharp.IconChar.UsersLine
        BtnEmployeesCredit.IconColor = Color.FromArgb(CByte(48), CByte(75), CByte(122))
        BtnEmployeesCredit.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnEmployeesCredit.IconSize = 25
        BtnEmployeesCredit.ImageAlign = ContentAlignment.MiddleLeft
        BtnEmployeesCredit.Location = New Point(0, 0)
        BtnEmployeesCredit.Name = "BtnEmployeesCredit"
        BtnEmployeesCredit.Padding = New Padding(35, 0, 0, 0)
        BtnEmployeesCredit.Size = New Size(229, 43)
        BtnEmployeesCredit.TabIndex = 6
        BtnEmployeesCredit.Text = "EMPLOYEE'S CREDIT"
        BtnEmployeesCredit.TextAlign = ContentAlignment.MiddleLeft
        BtnEmployeesCredit.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnEmployeesCredit.UseVisualStyleBackColor = False
        ' 
        ' BtnBilling
        ' 
        BtnBilling.Dock = DockStyle.Top
        BtnBilling.FlatAppearance.BorderSize = 0
        BtnBilling.FlatStyle = FlatStyle.Flat
        BtnBilling.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBilling.ForeColor = Color.Black
        BtnBilling.IconChar = FontAwesome.Sharp.IconChar.Receipt
        BtnBilling.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnBilling.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnBilling.IconSize = 30
        BtnBilling.ImageAlign = ContentAlignment.MiddleLeft
        BtnBilling.Location = New Point(0, 329)
        BtnBilling.Name = "BtnBilling"
        BtnBilling.Padding = New Padding(20, 0, 0, 0)
        BtnBilling.Size = New Size(229, 60)
        BtnBilling.TabIndex = 16
        BtnBilling.Text = "BILLINGS AND INVOICING"
        BtnBilling.TextAlign = ContentAlignment.MiddleLeft
        BtnBilling.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnBilling.UseVisualStyleBackColor = True
        ' 
        ' BtnReservation
        ' 
        BtnReservation.Dock = DockStyle.Top
        BtnReservation.FlatAppearance.BorderSize = 0
        BtnReservation.FlatStyle = FlatStyle.Flat
        BtnReservation.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnReservation.ForeColor = Color.Black
        BtnReservation.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck
        BtnReservation.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnReservation.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnReservation.IconSize = 30
        BtnReservation.ImageAlign = ContentAlignment.MiddleLeft
        BtnReservation.Location = New Point(0, 269)
        BtnReservation.Name = "BtnReservation"
        BtnReservation.Padding = New Padding(20, 0, 0, 0)
        BtnReservation.Size = New Size(229, 60)
        BtnReservation.TabIndex = 15
        BtnReservation.Text = "RESERVATION"
        BtnReservation.TextAlign = ContentAlignment.MiddleLeft
        BtnReservation.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnReservation.UseVisualStyleBackColor = True
        ' 
        ' BtnRooms
        ' 
        BtnRooms.Dock = DockStyle.Top
        BtnRooms.FlatAppearance.BorderSize = 0
        BtnRooms.FlatStyle = FlatStyle.Flat
        BtnRooms.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnRooms.ForeColor = Color.Black
        BtnRooms.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        BtnRooms.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnRooms.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnRooms.IconSize = 30
        BtnRooms.ImageAlign = ContentAlignment.MiddleLeft
        BtnRooms.Location = New Point(0, 209)
        BtnRooms.Name = "BtnRooms"
        BtnRooms.Padding = New Padding(20, 0, 0, 0)
        BtnRooms.Size = New Size(229, 60)
        BtnRooms.TabIndex = 14
        BtnRooms.Text = "ROOMS"
        BtnRooms.TextAlign = ContentAlignment.MiddleLeft
        BtnRooms.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnRooms.UseVisualStyleBackColor = True
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.Dock = DockStyle.Top
        BtnDashboard.FlatAppearance.BorderSize = 0
        BtnDashboard.FlatStyle = FlatStyle.Flat
        BtnDashboard.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDashboard.ForeColor = Color.Black
        BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartSimple
        BtnDashboard.IconColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnDashboard.IconSize = 30
        BtnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        BtnDashboard.Location = New Point(0, 149)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Padding = New Padding(20, 0, 0, 0)
        BtnDashboard.Size = New Size(229, 60)
        BtnDashboard.TabIndex = 13
        BtnDashboard.Text = "DASHBOARD"
        BtnDashboard.TextAlign = ContentAlignment.MiddleLeft
        BtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnDashboard.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        PanelHeader.Controls.Add(LblClock)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(229, 149)
        PanelHeader.TabIndex = 0
        ' 
        ' LblClock
        ' 
        LblClock.BorderStyle = BorderStyle.FixedSingle
        LblClock.Font = New Font("Arial Narrow", 30.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblClock.ForeColor = Color.FromArgb(CByte(37), CByte(58), CByte(91))
        LblClock.Location = New Point(4, 9)
        LblClock.Name = "LblClock"
        LblClock.Size = New Size(236, 123)
        LblClock.TabIndex = 0
        LblClock.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        Panel3.Controls.Add(BtnLogOut)
        Panel3.Controls.Add(BtnCashUp)
        Panel3.Controls.Add(LblMaintenance)
        Panel3.Controls.Add(LblReserve)
        Panel3.Controls.Add(LblOccupied)
        Panel3.Controls.Add(LblHousekeeping)
        Panel3.Controls.Add(LblAvailable)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(LblID)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(PictureBox5)
        Panel3.Controls.Add(LblPosition)
        Panel3.Controls.Add(LblName)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(246, 32)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1084, 148)
        Panel3.TabIndex = 2
        ' 
        ' BtnLogOut
        ' 
        BtnLogOut.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        BtnLogOut.FlatAppearance.BorderColor = Color.FromArgb(CByte(24), CByte(38), CByte(58))
        BtnLogOut.FlatAppearance.BorderSize = 2
        BtnLogOut.FlatStyle = FlatStyle.Flat
        BtnLogOut.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLogOut.ForeColor = Color.White
        BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        BtnLogOut.IconColor = Color.White
        BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnLogOut.IconSize = 25
        BtnLogOut.Location = New Point(926, 80)
        BtnLogOut.Name = "BtnLogOut"
        BtnLogOut.Size = New Size(133, 42)
        BtnLogOut.TabIndex = 26
        BtnLogOut.Text = "LOG-OUT"
        BtnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnLogOut.UseVisualStyleBackColor = False
        ' 
        ' BtnCashUp
        ' 
        BtnCashUp.BackColor = Color.FromArgb(CByte(255), CByte(196), CByte(54))
        BtnCashUp.FlatAppearance.BorderColor = Color.FromArgb(CByte(24), CByte(38), CByte(58))
        BtnCashUp.FlatAppearance.BorderSize = 2
        BtnCashUp.FlatStyle = FlatStyle.Flat
        BtnCashUp.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCashUp.ForeColor = Color.Black
        BtnCashUp.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave
        BtnCashUp.IconColor = Color.Black
        BtnCashUp.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnCashUp.IconSize = 25
        BtnCashUp.Location = New Point(926, 27)
        BtnCashUp.Name = "BtnCashUp"
        BtnCashUp.Size = New Size(133, 42)
        BtnCashUp.TabIndex = 25
        BtnCashUp.Text = "CASH UP"
        BtnCashUp.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnCashUp.UseVisualStyleBackColor = False
        ' 
        ' LblMaintenance
        ' 
        LblMaintenance.AutoSize = True
        LblMaintenance.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblMaintenance.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblMaintenance.Location = New Point(539, 110)
        LblMaintenance.Name = "LblMaintenance"
        LblMaintenance.Size = New Size(29, 17)
        LblMaintenance.TabIndex = 24
        LblMaintenance.Text = "100"
        ' 
        ' LblReserve
        ' 
        LblReserve.AutoSize = True
        LblReserve.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblReserve.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblReserve.Location = New Point(539, 93)
        LblReserve.Name = "LblReserve"
        LblReserve.Size = New Size(29, 17)
        LblReserve.TabIndex = 23
        LblReserve.Text = "100"
        ' 
        ' LblOccupied
        ' 
        LblOccupied.AutoSize = True
        LblOccupied.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblOccupied.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblOccupied.Location = New Point(539, 57)
        LblOccupied.Name = "LblOccupied"
        LblOccupied.Size = New Size(29, 17)
        LblOccupied.TabIndex = 21
        LblOccupied.Text = "100"
        ' 
        ' LblHousekeeping
        ' 
        LblHousekeeping.AutoSize = True
        LblHousekeeping.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblHousekeeping.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblHousekeeping.Location = New Point(539, 75)
        LblHousekeeping.Name = "LblHousekeeping"
        LblHousekeeping.Size = New Size(29, 17)
        LblHousekeeping.TabIndex = 22
        LblHousekeeping.Text = "100"
        ' 
        ' LblAvailable
        ' 
        LblAvailable.AutoSize = True
        LblAvailable.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblAvailable.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblAvailable.Location = New Point(539, 39)
        LblAvailable.Name = "LblAvailable"
        LblAvailable.Size = New Size(29, 17)
        LblAvailable.TabIndex = 20
        LblAvailable.Text = "100"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(375, 109)
        Label13.Name = "Label13"
        Label13.Size = New Size(125, 17)
        Label13.TabIndex = 19
        Label13.Text = "Under Maintenance:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(435, 93)
        Label12.Name = "Label12"
        Label12.Size = New Size(65, 17)
        Label12.TabIndex = 18
        Label12.Text = "Reserved:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(434, 58)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 17)
        Label11.TabIndex = 17
        Label11.Text = "Occupied:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(383, 75)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 17)
        Label9.TabIndex = 17
        Label9.Text = "For Housekeeping:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(437, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 17)
        Label10.TabIndex = 16
        Label10.Text = "Available:"
        ' 
        ' LblID
        ' 
        LblID.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblID.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LblID.Location = New Point(684, 44)
        LblID.Name = "LblID"
        LblID.Size = New Size(116, 17)
        LblID.TabIndex = 12
        LblID.Text = "1000001"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(635, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 7
        Label6.Text = "ID No.:"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        PictureBox5.Image = My.Resources.Resources.User_Pic
        PictureBox5.Location = New Point(810, 41)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(75, 87)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 14
        PictureBox5.TabStop = False
        ' 
        ' LblPosition
        ' 
        LblPosition.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblPosition.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LblPosition.Location = New Point(684, 98)
        LblPosition.Name = "LblPosition"
        LblPosition.Size = New Size(116, 27)
        LblPosition.TabIndex = 13
        LblPosition.Text = "Programmer"
        ' 
        ' LblName
        ' 
        LblName.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        LblName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LblName.Location = New Point(684, 70)
        LblName.Name = "LblName"
        LblName.Size = New Size(116, 26)
        LblName.TabIndex = 11
        LblName.Text = "Jeyson Gonzales"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(635, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 15)
        Label8.TabIndex = 9
        Label8.Text = "Position:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(635, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 8
        Label7.Text = "Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(642, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 17)
        Label5.TabIndex = 6
        Label5.Text = "User Information"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(373, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 17)
        Label4.TabIndex = 5
        Label4.Text = "Room Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(156), CByte(190), CByte(229))
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(21, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 17)
        Label3.TabIndex = 1
        Label3.Text = "Reservation Notification"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Room_Status_color_coded
        PictureBox4.Location = New Point(360, 10)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(252, 128)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 2
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Reservation_notif_copy
        PictureBox2.Location = New Point(11, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(334, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Room_status
        PictureBox3.Location = New Point(627, 10)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(271, 128)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 1
        PictureBox3.TabStop = False
        ' 
        ' PanelMain
        ' 
        PanelMain.AutoScroll = True
        PanelMain.BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        PanelMain.BorderStyle = BorderStyle.FixedSingle
        PanelMain.Dock = DockStyle.Fill
        PanelMain.Location = New Point(246, 180)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(1084, 680)
        PanelMain.TabIndex = 8
        ' 
        ' TmrClock
        ' 
        TmrClock.Interval = 1000
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1330, 860)
        Controls.Add(PanelMain)
        Controls.Add(Panel3)
        Controls.Add(PanelSideMenu)
        Controls.Add(PanelTitlebar)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(1330, 860)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotel 101 Property Management System"
        PanelTitlebar.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        PanelSideMenu.ResumeLayout(False)
        PanelSettingSubMenu.ResumeLayout(False)
        PanelReportsSubMenu.ResumeLayout(False)
        PanelInventorySubMenu.ResumeLayout(False)
        PanelBillingsSubMenu.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelSideMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblPosition As Label
    Friend WithEvents LblID As Label
    Friend WithEvents LblName As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnLogOut As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCashUp As FontAwesome.Sharp.IconButton
    Public WithEvents LblMaintenance As Label
    Public WithEvents LblReserve As Label
    Public WithEvents LblOccupied As Label
    Public WithEvents LblHousekeeping As Label
    Public WithEvents LblAvailable As Label
    Friend WithEvents LblMinimize As Label
    Friend WithEvents PanelSettingSubMenu As Panel
    Friend WithEvents BtnOther As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnUsersMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSetting As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelReportsSubMenu As Panel
    Friend WithEvents BtnUserLog As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnVoidLog As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnHouseKeepingLog As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnTransactionLog As FontAwesome.Sharp.IconButton
    Friend WithEvents Btn12Hours As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSubEmployees As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnExpenses As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnReports As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelInventorySubMenu As Panel
    Friend WithEvents BtnMiscellaneous As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBeverages As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnKitchen As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelBillingsSubMenu As Panel
    Friend WithEvents BtnVoid As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRates As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRefund As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCashOut As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnEmployeesCredit As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnBilling As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnReservation As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRooms As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDashboard As FontAwesome.Sharp.IconButton
    Public WithEvents PanelMain As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents LblClock As Label
    Friend WithEvents TmrClock As Timer
End Class
