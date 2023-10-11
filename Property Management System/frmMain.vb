Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Public Class frmMain

    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Private currentSubBtn As IconButton
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    'for adding new control
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)
        PanelSideMenu.Controls.Add(leftBorderBtn)
    End Sub

    'methods that highlights selected menu and sub menu
    Public Sub ActivateButton(SenderBtn As Object, CustomColor As Color)
        DisableButton()
        If SenderBtn IsNot Nothing Then
            'button
            currentBtn = CType(SenderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 58, 91)
            currentBtn.ForeColor = CustomColor
            currentBtn.IconColor = CustomColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            currentBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
            'left Border
            leftBorderBtn.BackColor = CustomColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub
    Public Sub ActivateSubButton(SenderSubBtn As Object)
        DisableSubButton()
        If SenderSubBtn IsNot Nothing Then
            'sub button
            currentSubBtn = CType(SenderSubBtn, IconButton)
            currentSubBtn.BackColor = Color.FromArgb(50, 83, 103)
            currentSubBtn.IconColor = Color.White
            currentSubBtn.ForeColor = Color.White
            currentSubBtn.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        End If
    End Sub
    'methods that back to original state the selected menu
    Public Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(245, 239, 231)
            currentBtn.ForeColor = Color.Black
            currentBtn.IconColor = Color.FromArgb(37, 58, 91)
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
            currentBtn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        End If
    End Sub
    Public Sub DisableSubButton()
        If currentSubBtn IsNot Nothing Then
            'sub button
            currentSubBtn.BackColor = Color.FromArgb(216, 196, 182)
            currentSubBtn.IconColor = Color.FromArgb(48, 75, 122)
            currentSubBtn.ForeColor = Color.Black
            currentSubBtn.Font = New Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        End If
    End Sub
    'methods that show form to the mainpanel of selected menu


    'for sub menu visibility
    Private Sub ShowSideMenu(ActiveSubMenu As String)
        If ActiveSubMenu = "billing" Then
            PanelBillingsSubMenu.Visible = True
            PanelInventorySubMenu.Visible = False
            PanelReportsSubMenu.Visible = False
            PanelSettingSubMenu.Visible = False
        ElseIf ActiveSubMenu = "inventory" Then
            PanelBillingsSubMenu.Visible = False
            PanelInventorySubMenu.Visible = True
            PanelReportsSubMenu.Visible = False
            PanelSettingSubMenu.Visible = False
        ElseIf ActiveSubMenu = "reports" Then
            PanelBillingsSubMenu.Visible = False
            PanelInventorySubMenu.Visible = False
            PanelReportsSubMenu.Visible = True
            PanelSettingSubMenu.Visible = False
        ElseIf ActiveSubMenu = "setting" Then
            PanelBillingsSubMenu.Visible = False
            PanelInventorySubMenu.Visible = False
            PanelReportsSubMenu.Visible = False
            PanelSettingSubMenu.Visible = True
        ElseIf ActiveSubMenu = "hide" Then
            PanelBillingsSubMenu.Visible = False
            PanelInventorySubMenu.Visible = False
            PanelReportsSubMenu.Visible = False
            PanelSettingSubMenu.Visible = False
        End If
    End Sub
    'close the application
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FrmBlurEffect.Show()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to quit the application?", "QUIT?",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Dispose()
            End
            FrmBlurEffect.Dispose()
        Else
            FrmBlurEffect.Dispose()
            Exit Sub
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()
        'hide submenu from load
        PanelBillingsSubMenu.Visible = False
        PanelInventorySubMenu.Visible = False
        PanelReportsSubMenu.Visible = False
        PanelSettingSubMenu.Visible = False

        TmrClock.Start() 'for Display Clock

        'display current user details
        LblID.Text = currentUserId
        LblName.Text = currentUserName
        LblPosition.Text = currentUserPosition

        'for mini dashboard of room status
        Try
            OpenCon()
            Using availablecount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE available = True", Con)
                Dim Count = Convert.ToInt32(availablecount.ExecuteScalar())
                LblAvailable.Text = Val(Count)
            End Using
            Using OccupiedCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE occupied = True", Con)
                Dim Count = Convert.ToInt32(OccupiedCount.ExecuteScalar())
                LblOccupied.Text = Val(Count)
            End Using
            Using HousekeepingCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE housekeeping = True", Con)
                Dim Count = Convert.ToInt32(HousekeepingCount.ExecuteScalar())
                LblHousekeeping.Text = Val(Count)
            End Using
            Using ReservedCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE reserved = True", Con)
                Dim Count = Convert.ToInt32(ReservedCount.ExecuteScalar())
                LblReserve.Text = Val(Count)
            End Using
            Using maintenanceCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE maintenance = True", Con)
                Dim Count = Convert.ToInt32(maintenanceCount.ExecuteScalar())
                LblMaintenance.Text = Val(Count)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on retrieving rooms current status. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'give value current voucher
        Try
            OpenCon()
            Using ShowCurrentVno As New MySqlCommand("SELECT * FROM tbl_billing_voucher
                    WHERE status=@status", Con)
                ShowCurrentVno.Parameters.AddWithValue("status", "current")
                reader = ShowCurrentVno.ExecuteReader
                If reader.Read Then
                    currentVoucherNo = reader("voucher_no").ToString
                Else
                    currentVoucherNo = ""
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on retrieving current voucher no. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try


        'give value firstexcess and secondexcess
        Try
            OpenCon()
            Using GetfirstExcess As New MySqlCommand("SELECT * FROM tbl_excess_setting
            WHERE excess_code='firstexcessminutes'", Con)
                Dim FEReader As MySqlDataReader
                FEReader = GetfirstExcess.ExecuteReader()
                If FEReader.Read Then
                    firstexcess = FEReader("min").ToString
                End If
                FEReader.Close()
            End Using
            Using GetSecondExcess As New MySqlCommand("SELECT * FROM tbl_excess_setting
            WHERE excess_code='secondexcessminutes'", Con)
                Dim GSReader As MySqlDataReader
                GSReader = GetSecondExcess.ExecuteReader()
                If GSReader.Read Then
                    secondexcess = GSReader("min").ToString
                End If
                GSReader.Close()
            End Using

            Using GetadditionalExcess As New MySqlCommand("SELECT * FROM tbl_excess_setting
            WHERE excess_code='additionalexcess'", Con)
                Dim GAReader As MySqlDataReader
                GAReader = GetadditionalExcess.ExecuteReader()
                If GAReader.Read Then
                    additionalExcess = GAReader("min").ToString
                End If
                GAReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on retrieving excess hours setting values. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'give vat sales percentage
        Try
            OpenCon()
            Using cmdVatPercentage As New MySqlCommand("SELECT vat_percentage
            FROM tbl_vat_setting WHERE id=1", Con)
                Dim VPReader As MySqlDataReader
                VPReader = cmdVatPercentage.ExecuteReader
                With VPReader
                    .Read()
                    vatPercentage = .Item("vat_percentage")
                    .Close()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on retrieving Vat percentage. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        If currentUserPosition = "ADMIN" Then
            BtnDashboard.PerformClick()
        Else
            BtnRooms.PerformClick()
        End If

        ResumeLayout()
    End Sub

    Private Sub BtnRooms_Click(sender As Object, e As EventArgs) Handles BtnRooms.Click
        OpenChildForm(New FrmRooms)
        ShowSideMenu("hide")
        ActivateButton(sender, RGBColors.Color2)
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        ShowSideMenu("hide")
        ActivateButton(sender, RGBColors.Color1)

    End Sub

    Private Sub BtnReservation_Click(sender As Object, e As EventArgs) Handles BtnReservation.Click
        ShowSideMenu("hide")
        ActivateButton(sender, RGBColors.Color3)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnBilling.Click
        ShowSideMenu("billing")
        ActivateButton(sender, RGBColors.Color4)
        BtnEmployeesCredit.PerformClick()
    End Sub

    Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
        ShowSideMenu("inventory")
        ActivateButton(sender, RGBColors.Color5)
    End Sub

    Private Sub BtnReports_Click(sender As Object, e As EventArgs) Handles BtnReports.Click
        ShowSideMenu("reports")
        ActivateButton(sender, RGBColors.Color6)
    End Sub

    Private Sub BtnSetting_Click(sender As Object, e As EventArgs) Handles BtnSetting.Click
        ShowSideMenu("setting")
        ActivateButton(sender, RGBColors.Color7)
    End Sub

    Private Sub BtnEmployeesCredit_Click(sender As Object, e As EventArgs) Handles BtnEmployeesCredit.Click
        OpenChildForm(New FrmEmpCredit)
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnCashOut_Click(sender As Object, e As EventArgs) Handles BtnCashOut.Click
        OpenChildForm(New FrmExpences)
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnRefund_Click(sender As Object, e As EventArgs) Handles BtnRefund.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnRates_Click(sender As Object, e As EventArgs) Handles BtnRates.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnKitchen_Click(sender As Object, e As EventArgs) Handles BtnKitchen.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnBeverages_Click(sender As Object, e As EventArgs) Handles BtnBeverages.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnMiscellaneous_Click(sender As Object, e As EventArgs) Handles BtnMiscellaneous.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnExpenses_Click(sender As Object, e As EventArgs) Handles BtnExpenses.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnSubEmployees_Click(sender As Object, e As EventArgs) Handles BtnSubEmployees.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub Btn12Hours_Click(sender As Object, e As EventArgs) Handles Btn12Hours.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnUsersMenu_Click(sender As Object, e As EventArgs) Handles BtnUsersMenu.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnOther_Click(sender As Object, e As EventArgs) Handles BtnOther.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnVoid_Click(sender As Object, e As EventArgs) Handles BtnVoid.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnTransactionLog_Click_1(sender As Object, e As EventArgs) Handles BtnTransactionLog.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnVoidLog_Click_1(sender As Object, e As EventArgs) Handles BtnVoidLog.Click
        ActivateSubButton(sender)
    End Sub

    Private Sub BtnUserLog_Click_1(sender As Object, e As EventArgs) Handles BtnUserLog.Click
        ActivateSubButton(sender)
    End Sub
    Private Sub BtnHouseKeepingLog_Click(sender As Object, e As EventArgs) Handles BtnHouseKeepingLog.Click
        ActivateSubButton(sender)
    End Sub
    Private Sub PanelTitlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitlebar.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isDragging = True
            mouseOffset = e.Location
        End If
    End Sub

    Private Sub PanelTitlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitlebar.MouseMove
        If isDragging Then
            Dim newLocation As Point = Me.Location + (e.Location - mouseOffset)
            Me.Location = newLocation
        End If
    End Sub

    Private Sub PanelTitlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTitlebar.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isDragging = False
        End If
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        FrmBlurEffect.TopMost = True
        FrmBlurEffect.Show()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Log-Out?", "CONFIRM LOG-OUT",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            frmLogin.Show()
            FrmBlurEffect.Dispose()
        Else
            FrmBlurEffect.Dispose()
            Exit Sub
        End If
    End Sub

    Private Sub LblMinimize_Click(sender As Object, e As EventArgs) Handles LblMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub TmrClock_Tick(sender As Object, e As EventArgs) Handles TmrClock.Tick
        LblClock.Text = TimeOfDay.ToString("hh:mm:ss tt").ToUpper

    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.BackColor = Color.Red
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = RGBColors.colorpanelDark
        Label1.ForeColor = Color.FromArgb(37, 58, 91)
    End Sub

    Private Sub LblMinimize_MouseHover(sender As Object, e As EventArgs) Handles LblMinimize.MouseHover
        LblMinimize.BackColor = RGBColors.colorpanelLight
    End Sub

    Private Sub LblMinimize_MouseLeave(sender As Object, e As EventArgs) Handles LblMinimize.MouseLeave
        LblMinimize.BackColor = RGBColors.colorpanelDark
    End Sub
End Class
