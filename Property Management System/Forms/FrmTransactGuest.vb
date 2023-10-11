Imports System.Windows
Imports System.Windows.Controls
Imports MySql.Data.MySqlClient

Public Class FrmTransactGuest
    Inherits Form
    Dim txtSearchHighlights As Boolean
    Dim HoursDuration As Integer
    Dim THoursDuration As TimeSpan
    Dim THoursdurationInt As Integer
    Dim RemainingTime As TimeSpan
    Dim excesshour As Integer
    Dim strCheckOutTime As String
    Dim strCurrentTime As String
    Dim currentDateTime As DateTime
    Dim checkOutTime As DateTime
    Dim countDownWatch As Stopwatch
    Dim HourCode As String
    Dim PartialTotal As Double
    Dim TotalOrderAmount As Double
    Dim EGCount As Integer
    Dim CBBChangeIndexes As Boolean

    Dim currentRoomStatus As String

    Private overlayPanel As Panel ' Used for the transparent overlay


    Private Sub FrmTransactGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()

        AssignValidation(Me.txtOtherDiscount, ValidationType.Only_Numbers)
        'AssignValidation(Me.TxtCash, ValidationType.Only_Characters)
        ' AssignValidation(Me.TextBox3, ValidationType.No_Blank)
        ' AssignValidation(Me.TextBox4, ValidationType.Only_Email)

        CBBChangeIndexes = True

        'Fill Guest Type combo box
        Try
            OpenCon()
            Using FillGtype As New MySqlCommand("SELECT discount_code FROM tbl_discountsandpromo_setting
              WHERE ispromo=0", Con)
                Dim GtypeAdapter As New MySqlDataAdapter
                Dim GtypeTable As New DataTable
                GtypeAdapter.SelectCommand = FillGtype
                GtypeTable.Clear()
                GtypeAdapter.Fill(GtypeTable)
                For i = 0 To GtypeTable.Rows.Count - 1
                    CbbGType.Items.Add(GtypeTable.Rows(i).Item(0).ToString)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving guest type list error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'Fill Guest Type combo box
        Try
            OpenCon()
            Using FillPromo As New MySqlCommand("SELECT discount_code FROM tbl_discountsandpromo_setting
                WHERE ispromo=1", Con)
                Dim PromoAdapter As New MySqlDataAdapter
                Dim PromoTable As New DataTable
                PromoAdapter.SelectCommand = FillPromo
                PromoTable.Clear()
                PromoAdapter.Fill(PromoTable)
                CbbPromo.Items.Add("None")
                For i = 0 To PromoTable.Rows.Count - 1
                    CbbPromo.Items.Add(PromoTable.Rows(i).Item(0).ToString)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving promo list error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try


        'add item to cbbguest count
        For i As Integer = 2 To 10
            CbbGuestCount.Items.Add(i)
        Next



        TransactInitialized()
        FillMenuTable()

        'Fill -choose hours- combo box
        Try
            OpenCon()
            Using FillChooseHours As New MySqlCommand("SELECT hour_code FROM tbl_hours ORDER BY hour_code DESC", Con)
                adapter.SelectCommand = FillChooseHours
                table.Clear()
                adapter.Fill(table)
                For i = 0 To table.Rows.Count - 1
                    CbbDescription.Items.Add(table.Rows(i).Item(0).ToString)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving hours code list error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'for filling up current order of available status room
        Try
            OpenCon()
            Using FillOrders As New MySqlCommand("SELECT * FROM tbl_transaction_order WHERE
            transaction_no='" & LblTransactionNo.Text & "'", Con)
                reader = FillOrders.ExecuteReader
                While reader.Read
                    Dim itemNo As String = reader("item_code").ToString()
                    Dim particulars As String = reader("particulars").ToString()
                    Dim price As String = reader("price").ToString & ".00"
                    Dim qty As Integer = CInt(reader("qty"))
                    Dim category As String = reader("category").ToString()
                    Dim amount As String = reader("amount") & ".00"
                    DGTransact.Rows.Add(itemNo, particulars, qty, price, amount, category)
                End While
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Fill-up order table error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try




        grandTotal()

        'default controls status when form initialize
        CbFoods.Checked = CheckState.Checked
        CbBevItems.Checked = CheckState.Checked
        TxtSearchMenu.Text = "-Search order here-"
        DgMenu.ClearSelection()
        DGTransact.ClearSelection()

        ResumeLayout()

    End Sub
    Sub grandTotal()
        Dim Ordertotal As Double
        Dim gTotal As Double
        Dim TotalPercentage As Double
        For Each row As DataGridViewRow In DGTransact.Rows
            ' Check if the cell in the second column is not empty and is a valid numeric value
            If Not row.Cells(4).Value Is Nothing AndAlso IsNumeric(row.Cells(4).Value) Then
                ' Add the value in the second column to the total
                Ordertotal += row.Cells(4).Value
                TotalOrderAmount += row.Cells(4).Value
            End If
        Next
        Dim OrderTotalFormatted As String = Ordertotal.ToString("0.00")


        PartialTotal = Val(LblDHamount.Text) + Val(LblEHamount.Text) + Val(LblEGamount.Text) + Val(OrderTotalFormatted)

        Dim PartialFormated As String = PartialTotal.ToString("0.00")
        LblPartialTotal.Text = PartialFormated
        TotalPercentage = (Val(LblGTPercentage.Text.TrimEnd("%"c)) + Val(LblPDPercentage.Text.TrimEnd("%"c)) +
            Val(LblODPercentage.Text.TrimEnd("%"c))) / 100

        Dim TotalPercentageFormatted As String = TotalPercentage.ToString("0.00")
        gTotal = CDbl(PartialFormated) - (CDbl(TotalPercentageFormatted) * CDbl(PartialFormated))

        Dim gTotalformatted As String = gTotal.ToString("0.00")

        LblGrandTotal.Text = gTotalformatted
    End Sub
    Sub CountRoomStatus()
        Try
            OpenCon()
            Using availablecount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE available = True", Con)
                Dim Count = Convert.ToInt32(availablecount.ExecuteScalar())
                frmMain.LblAvailable.Text = Val(Count)
            End Using
            Using OccupiedCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE occupied = True", Con)
                Dim Count = Convert.ToInt32(OccupiedCount.ExecuteScalar())
                frmMain.LblOccupied.Text = Val(Count)
            End Using
            Using HousekeepingCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE housekeeping = True", Con)
                Dim Count = Convert.ToInt32(HousekeepingCount.ExecuteScalar())
                frmMain.LblHousekeeping.Text = Val(Count)
            End Using
            Using ReservedCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE reserved = True", Con)
                Dim Count = Convert.ToInt32(ReservedCount.ExecuteScalar())
                frmMain.LblReserve.Text = Val(Count)
            End Using
            Using maintenanceCount As New MySqlCommand("select count(*) from
                tbl_room_status WHERE maintenance = True", Con)
                Dim Count = Convert.ToInt32(maintenanceCount.ExecuteScalar())
                frmMain.LblMaintenance.Text = Val(Count)
            End Using
        Catch ex As Exception
            MessageBox.Show("Counting current rooms status error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub
    Sub DataModified()
        If LblRoomStatus.Text = "OCCUPIED" Or LblRoomStatus.Text = "RESERVED" Then
            BtnCheckIn.Text = "UPDATE"
            BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        End If
    End Sub
    Sub TransactInitialized()


        'display current room number
        Try
            OpenCon()
            Using RoomCurrentStatus As New MySqlCommand("SELECT * FROM tbl_room_status WHERE room_id = @roomid", Con)
                RoomCurrentStatus.Parameters.AddWithValue("roomid", CurrentRoomNumber)
                Dim RCSReader As MySqlDataReader
                RCSReader = RoomCurrentStatus.ExecuteReader
                If RCSReader.Read Then
                    Dim isOccupied As Boolean = Convert.ToBoolean(RCSReader("occupied"))
                    Dim isAvailable As Boolean = Convert.ToBoolean(RCSReader("available"))
                    Dim isMaintenance As Boolean = Convert.ToBoolean(RCSReader("maintenance"))
                    Dim isHousekeeping As Boolean = Convert.ToBoolean(RCSReader("housekeeping"))
                    Dim isReserved As Boolean = Convert.ToBoolean(RCSReader("reserved"))
                    Dim isDeactivated As Boolean = Convert.ToBoolean(RCSReader("deactivated"))
                    If isOccupied Then
                        LblRoomStatus.Text = "OCCUPIED"
                        currentRoomStatus = "OCCUPIED"
                    ElseIf isAvailable Then
                        LblRoomStatus.Text = "AVAILABLE"
                        currentRoomStatus = "AVAILABLE"
                    ElseIf isMaintenance Then
                        LblRoomStatus.Text = "MAINTENANCE"
                        currentRoomStatus = "MAINTENANCE"
                    ElseIf isHousekeeping Then
                        LblRoomStatus.Text = "HOUSEKEEPING"
                        currentRoomStatus = "HOUSEKEEPING"
                    ElseIf isReserved Then
                        LblRoomStatus.Text = "RESERVED"
                        currentRoomStatus = "RESERVED"
                    ElseIf isDeactivated Then
                        LblRoomStatus.Text = "DEACTIVATED"
                        currentRoomStatus = "DEACTIVATED"
                    End If
                End If
                RCSReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Showing current room error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'display data and manipulate controls depend on room status
        If LblRoomStatus.Text = "AVAILABLE" Then
            'display current room number
            If CurrentRoomNumber >= 0 And CurrentRoomNumber <= 9 Then
                LblCurrentRoom.Text = "ROOM NO. " & "0" & CurrentRoomNumber
            Else
                LblCurrentRoom.Text = "ROOM NO. " & CurrentRoomNumber
            End If

            'controls default properties if room is available
            LblCheckInTime.Text = DateTime.Now.ToString
            LblRemainingTime.Text = "00:00:00"
            CbFoods.CheckState = CheckState.Checked
            CbBevItems.Checked = CheckState.Checked
            Timer1.Start()
            DgMenu.ClearSelection()
            LblTransactionNo.Visible = False
            PanelMenu.Enabled = False
            PanelGuestDetails.Enabled = False

        ElseIf LblRoomStatus.Text = "OCCUPIED" Or LblRoomStatus.Text = "RESERVED" Then
            'display current room number
            If CurrentRoomNumber >= 0 And CurrentRoomNumber <= 9 Then
                LblCurrentRoom.Text = "ROOM NO. " & "0" & CurrentRoomNumber
            Else
                LblCurrentRoom.Text = "ROOM NO. " & CurrentRoomNumber
            End If


            'controls default properties if room is occupied or reserved
            LblTransactionNo.Visible = True
            PanelGuestDetails.Enabled = True
            PanelMenu.Enabled = True

            'retrieve room data if occupied
            CBBChangeIndexes = False

            Try
                OpenCon()
                Using CurrentStats As New MySqlCommand("SELECT * FROM tbl_room_status WHERE room_id=@croom", Con)
                    CurrentStats.Parameters.AddWithValue("@croom", CurrentRoomNumber)
                    Dim CSReader As MySqlDataReader = CurrentStats.ExecuteReader
                    If CSReader.Read() Then
                        LblTransactionNo.Text = CSReader("transaction_no").ToString()

                        'give value to current transaction value holder
                        currentTransactionNo = CSReader("transaction_no").ToString()
                        TxtName.Text = CSReader("guest_name").ToString()
                        TxtContactNo.Text = CSReader("contact_no").ToString()
                        TxtVtype.Text = CSReader("vehicle_type").ToString()
                        TxtPlateNo.Text = CSReader("plate_no").ToString()
                        CbbGType.Text = CSReader("guest_type").ToString()
                        LblGTPercentage.Text = CSReader("guest_disper").ToString & "%"
                        LblGDiscount.Text = Convert.ToDouble(CSReader("guest_disamount").ToString).ToString("0.00")
                        CbbGuestCount.Text = CSReader("guest_count").ToString()
                        EGCount = CSReader("guest_count") - 2
                        TxtSeniorNo.Text = CSReader("senior_id").ToString()
                        TxtAddress.Text = CSReader("address").ToString()
                        CbbDescription.Text = CSReader("hours_code").ToString()
                        LblCheckInTime.Text = CSReader("check_in_time").ToString()
                        lblDuration.Text = CSReader("duration_hours").ToString() & " HOURS"
                        THoursDuration = TimeSpan.FromHours(CSReader("duration_hours"))
                        THoursdurationInt = CSReader("duration_hours")
                        lblCheckOut.Text = CSReader("check_out_time").ToString()
                        TxtComment.Text = CSReader("comment").ToString()
                        LblAddOn.Text = CSReader("addon").ToString
                        CbbPromo.Text = CSReader("promo_type").ToString
                        LblPDPercentage.Text = CSReader("promo_percentage").ToString & "%"
                        LblPromoDiscount.Text = Convert.ToDouble(CSReader("promo_amount").ToString).ToString("0.00")
                        txtOtherDiscount.Text = CSReader("other_discountper").ToString
                        LblODPercentage.Text = CSReader("other_discountper").ToString & "%"
                        LblOtherDiscount.Text = Convert.ToDouble(CSReader("other_disamount").ToString).ToString("0.00")
                    End If
                    CSReader.Close()
                    CBBChangeIndexes = True
                End Using
            Catch ex As Exception
                MessageBox.Show("Retrieving current room data error. " & ex.Message, "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try

            'display duration hours and amount to transaction preview
            Try
                OpenCon()
                Using RatePrice As New MySqlCommand("SELECT * FROM tbl_hours
                WHERE hour_code='" & CbbDescription.Text & "'", Con)
                    Dim ratepriceReader As MySqlDataReader
                    ratepriceReader = RatePrice.ExecuteReader
                    If ratepriceReader.Read Then
                        LblDHqty.Text = ratepriceReader("duration").ToString
                        LblDHprice.Text = Convert.ToDouble(ratepriceReader("hour_rate").ToString).ToString("0.00")
                        LblDHamount.Text = Convert.ToDouble(ratepriceReader("hour_rate").ToString).ToString("0.00")
                        ratepriceReader.Close()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Rent price error. " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try

            'display EXTRA GUEST and amount to transaction preview
            Try
                OpenCon()
                Using RatePerExtraGuest2 As New MySqlCommand("SELECT * FROM tbl_rates
                WHERE rates_code='" & "extra_guest" & "'", Con)
                    Dim RPEGuestReader2 As MySqlDataReader
                    RPEGuestReader2 = RatePerExtraGuest2.ExecuteReader
                    If RPEGuestReader2.Read Then
                        LblEGqty.Text = EGCount
                        LblEGprice.Text = Convert.ToDouble(RPEGuestReader2("price").ToString).ToString("0.00")
                        Dim EGamount = Convert.ToDouble(EGCount * Val(LblEGprice.Text)).ToString("0.00")
                        LblEGamount.Text = EGamount
                    End If
                    RPEGuestReader2.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Con.Close()


            'for making the countdown timer
            strCheckOutTime = lblCheckOut.Text
            strCurrentTime = DateTime.Now
            checkOutTime = Convert.ToDateTime(strCheckOutTime)
            currentDateTime = Convert.ToDateTime(strCurrentTime)
            RemainingTime = checkOutTime - currentDateTime
            countDownWatch = Stopwatch.StartNew
            TimerRemainingTime.Start()

            'for getting excess hours PS: sakit sa bangs :D
            Dim timeRemaining = RemainingTime - countDownWatch.Elapsed

            If timeRemaining <= TimeSpan.FromMinutes(firstexcess) And timeRemaining > TimeSpan.FromMinutes(secondexcess) Then
                excesshour = 1
                LblEHqty.Text = excesshour
            ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess) And timeRemaining > TimeSpan.FromMinutes(secondexcess + additionalExcess) Then
                excesshour = 2
                LblEHqty.Text = excesshour
            ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess + additionalExcess) And timeRemaining > TimeSpan.FromMinutes(secondexcess * 2) Then
                excesshour = 3
                LblEHqty.Text = excesshour
            ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess * 2) And timeRemaining > TimeSpan.FromMinutes(secondexcess * 2 + additionalExcess) Then
                excesshour = 4
                LblEHqty.Text = excesshour
            ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess * 2 + additionalExcess) And timeRemaining > TimeSpan.FromMinutes((secondexcess * 2) + (additionalExcess * 2)) Then
                excesshour = 5
                LblEHqty.Text = excesshour
            ElseIf timeRemaining <= TimeSpan.FromMinutes((secondexcess * 2) + (additionalExcess * 2)) Then
                excesshour = 6
                LblEHqty.Text = excesshour
            End If

            'now compute excesshour and amount to display to transaction preview

            Try
                OpenCon()
                Using RatePerExcessHour As New MySqlCommand("SELECT * FROM tbl_rates
                WHERE rates_code='" & "excess_hour" & "'", Con)
                    Dim RPEHourReader As MySqlDataReader
                    RPEHourReader = RatePerExcessHour.ExecuteReader
                    If RPEHourReader.Read Then
                        If excesshour = 0 Then
                            LblEHqty.Text = 0
                            LblEHprice.Text = "0.00"
                            LblEHamount.Text = "0.00"
                        Else
                            Dim EHprice = Convert.ToDouble(RPEHourReader("price").ToString).ToString("0.00")
                            LblEHqty.Text = excesshour
                            LblEHprice.Text = EHprice
                            Dim EHamount = Convert.ToDouble(excesshour * EHprice).ToString("0.00")
                            LblEHamount.Text = EHamount
                        End If
                        RPEHourReader.Close()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Excess hour error. " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try


            ' controls default properties if room is loaded as occupied or reserved
            BtnCheckIn.Text = "EDIT"
            BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
            LblHAvailed.Text = "Hours Availed:"
            CbbDescription.Enabled = False
        End If

        If myDataTable Is Nothing Then
            Exit Sub
        Else
            myDataTable.Dispose() ' clear myDataTable value as DGTransact everyime form load
        End If

    End Sub
    Sub ShowDuration()
        Try
            OpenCon()
            Using DurationText As New MySqlCommand("SELECT * FROM tbl_hours WHERE hour_code = @hourcode", Con)
                DurationText.Parameters.AddWithValue("hourcode", CbbDescription.Text)
                reader = DurationText.ExecuteReader
                If reader.Read Then
                    HoursDuration = reader("duration")
                    THoursDuration = TimeSpan.FromHours(HoursDuration)
                    lblDuration.Text = reader("duration") & " HOURS"
                    LblAddOn.Text = reader("add_on")
                End If
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving duration of hours code error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try
    End Sub
    Sub UpdateStatus()
        'update value to tbl_room_status'
        Try
            OpenCon()
            Using CStatus As New MySqlCommand("UPDATE tbl_room_status SET guest_name=@gname,contact_no=@cno,
        vehicle_type=@vtype,plate_no=@pno,guest_type=@gtype,guest_disper=@gtdpercentage,guest_disamount=@gdamount,
        guest_count=@guestcount,senior_id=@sid,address=@add,hours_code=@hcode,addon=@addon,check_in_time=@checkin,
        duration_hours=@dhours,check_out_time=@checkout,promo_type=@ptype,promo_percentage=@ppercentage,
        promo_amount=@pAmount,other_discountper=@odpercentage,other_disamount=@odamount,
        comment=@c,occupied=@isoccupied,available=@isavailable,housekeeping=@isHousekeeping,reserved=@isReserved,
        maintenance=@isMaintenance,deactivated=@isDeactivated,transaction_no=@tno
        WHERE room_id=@roomid", Con)
                Dim isOccupied As Boolean = True
                Dim isAvailable As Boolean = False
                Dim isHousekeeping As Boolean = False
                Dim isReserved As Boolean = False
                Dim isMaintenance As Boolean = False
                Dim isDeactivated As Boolean = False
                CStatus.Parameters.AddWithValue("roomid", CurrentRoomNumber)
                If TxtName.Text = "" Then
                    CStatus.Parameters.AddWithValue("gname", "GUEST")
                Else
                    CStatus.Parameters.AddWithValue("gname", TxtName.Text)
                End If
                If TxtContactNo.Text = "" Then
                    CStatus.Parameters.AddWithValue("cno", "UNKNOWN")
                Else
                    CStatus.Parameters.AddWithValue("cno", TxtContactNo.Text)
                End If
                If TxtVtype.Text = "" Then
                    CStatus.Parameters.AddWithValue("vtype", "UNKNOWN")
                Else
                    CStatus.Parameters.AddWithValue("vtype", TxtVtype.Text)
                End If
                If TxtPlateNo.Text = "" Then
                    CStatus.Parameters.AddWithValue("pno", "UNKNOWN")
                Else
                    CStatus.Parameters.AddWithValue("pno", TxtPlateNo.Text)
                End If
                If CbbGType.Text = "" Then
                    CStatus.Parameters.AddWithValue("gtype", "REGULAR")
                    CStatus.Parameters.AddWithValue("gtdpercentage", Val(LblGTPercentage.Text.TrimEnd("%"c)))
                    CStatus.Parameters.AddWithValue("gdamount", Val(LblGDiscount.Text))
                Else
                    CStatus.Parameters.AddWithValue("gtype", CbbGType.Text)
                    CStatus.Parameters.AddWithValue("gtdpercentage", Val(LblGTPercentage.Text.TrimEnd("%"c)))
                    CStatus.Parameters.AddWithValue("gdamount", Val(LblGDiscount.Text))
                End If

                If CbbGuestCount.Text = "" Then
                    CStatus.Parameters.AddWithValue("guestcount", 2)
                Else
                    CStatus.Parameters.AddWithValue("guestcount", CbbGuestCount.Text)
                End If
                If TxtSeniorNo.Text = "" Then
                    CStatus.Parameters.AddWithValue("sid", "N/A")
                Else
                    CStatus.Parameters.AddWithValue("sid", TxtSeniorNo.Text)
                End If
                If TxtAddress.Text = "" Then
                    CStatus.Parameters.AddWithValue("add", "UNKNOWN")
                Else
                    CStatus.Parameters.AddWithValue("add", TxtAddress.Text)
                End If

                If CbbPromo.Text = "" Then
                    CStatus.Parameters.AddWithValue("ptype", "None")
                    CStatus.Parameters.AddWithValue("ppercentage", Val(LblPDPercentage.Text.TrimEnd("%"c)))
                    CStatus.Parameters.AddWithValue("pAmount", Val(LblPromoDiscount.Text))
                Else
                    CStatus.Parameters.AddWithValue("ptype", CbbPromo.Text)
                    CStatus.Parameters.AddWithValue("ppercentage", Val(LblPDPercentage.Text.TrimEnd("%"c)))
                    CStatus.Parameters.AddWithValue("pAmount", Val(LblPromoDiscount.Text))
                End If
                If txtOtherDiscount.Text = "" Then
                    CStatus.Parameters.AddWithValue("odpercentage", 0)
                    CStatus.Parameters.AddWithValue("odamount", 0.00)
                Else
                    CStatus.Parameters.AddWithValue("odpercentage", Val(LblODPercentage.Text.TrimEnd("%"c)))
                    CStatus.Parameters.AddWithValue("odamount", Val(LblOtherDiscount.Text))
                End If

                CStatus.Parameters.AddWithValue("addon", LblAddOn.Text)
                CStatus.Parameters.AddWithValue("hcode", CbbDescription.Text)
                CStatus.Parameters.AddWithValue("checkin", LblCheckInTime.Text)
                CStatus.Parameters.AddWithValue("dhours", lblDuration.Text)
                CStatus.Parameters.AddWithValue("checkout", lblCheckOut.Text)
                CStatus.Parameters.AddWithValue("c", TxtComment.Text)
                CStatus.Parameters.AddWithValue("isoccupied", isOccupied)
                CStatus.Parameters.AddWithValue("isavailable", isAvailable)
                CStatus.Parameters.AddWithValue("ishousekeeping", isHousekeeping)
                CStatus.Parameters.AddWithValue("isreserved", isReserved)
                CStatus.Parameters.AddWithValue("ismaintenance", isMaintenance)
                CStatus.Parameters.AddWithValue("isdeactivated", isDeactivated)
                CStatus.Parameters.AddWithValue("tno", LblTransactionNo.Text)

                FrmBlurEffect.TopMost = True
                FrmBlurEffect.Show()

                If CStatus.ExecuteNonQuery Then
                    If BtnCheckIn.Text = "CHECK-IN" Then
                        Dim result2 As DialogResult = MessageBox.Show("Guest check-in successfuly.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result2 = DialogResult.OK Then
                            FrmBlurEffect.Dispose()
                        Else
                            FrmBlurEffect.Dispose()
                        End If
                    ElseIf BtnCheckIn.Text = "UPDATE" Then
                        Dim result As DialogResult = MessageBox.Show("Guest information successfully modified.", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result = DialogResult.OK Then
                            FrmBlurEffect.Dispose()
                        Else
                            FrmBlurEffect.Dispose()
                        End If
                    End If
                Else
                    MessageBox.Show("Guest information failed to update!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Updating current room booking error. " & ex.Message,
                           "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmBlurEffect.Dispose()
        Finally
            Con.Close()
        End Try
    End Sub

    'Fill Menu table data from 2 tables on database with working filter and search function
    Sub FillMenuTable()

        If TxtSearchMenu.Text.Trim = "-Search order here-" Or TxtSearchMenu.Text = "" Then
            If CbFoods.CheckState = CheckState.Checked And CbBevItems.CheckState = CheckState.Checked Then
                Try
                    OpenCon()
                    Using GetFoodMenu1 As New MySqlCommand("Select * FROM tbl_menu UNION ALL Select * FROM
                tbl_beverages_and_items", Con)
                        reader = GetFoodMenu1.ExecuteReader
                        DgMenu.Rows.Clear()
                        While reader.Read
                            Dim itemNo As String = reader("item_code").ToString()
                            Dim description As String = reader("description").ToString()
                            Dim price As String = reader("price").ToString()
                            Dim stocks As String = reader("stocks").ToString()
                            Dim category As String = reader("category").ToString
                            DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                        End While
                        reader.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Filling menu error. " & ex.Message,
                           "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try
            ElseIf CbFoods.CheckState = CheckState.Checked And CbBevItems.CheckState = CheckState.Unchecked Then
                OpenCon()
                Using GetFoodMenu2 As New MySqlCommand("Select * FROM tbl_menu", Con)
                    reader = GetFoodMenu2.ExecuteReader
                    DgMenu.Rows.Clear()
                    While reader.Read
                        Dim itemNo As String = reader("item_code").ToString()
                        Dim description As String = reader("description").ToString()
                        Dim price As String = reader("price").ToString()
                        Dim stocks As String = reader("stocks").ToString()
                        Dim category As String = reader("category").ToString
                        DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                    End While
                    reader.Close()
                End Using
                Con.Close()
            ElseIf CbFoods.CheckState = CheckState.Unchecked And CbBevItems.CheckState = CheckState.Checked Then
                OpenCon()
                Using GetFoodMenu3 As New MySqlCommand("Select * FROM tbl_beverages_and_items", Con)
                    reader = GetFoodMenu3.ExecuteReader
                    DgMenu.Rows.Clear()
                    While reader.Read
                        Dim itemNo As String = reader("item_code").ToString()
                        Dim description As String = reader("description").ToString()
                        Dim price As String = reader("price").ToString()
                        Dim stocks As String = reader("stocks").ToString()
                        Dim category As String = reader("category").ToString
                        DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                    End While
                    reader.Close()
                End Using
                Con.Close()
            Else
                DgMenu.Rows.Clear()
            End If
            Exit Sub

        ElseIf TxtSearchMenu.Text = "" Then
            DgMenu.Rows.Clear()
        Else
            If CbFoods.CheckState = CheckState.Checked And CbBevItems.CheckState = CheckState.Checked Then
                OpenCon()
                Using GetFoodMenu4 As New MySqlCommand("Select * FROM tbl_menu
                WHERE item_code LIKE '" & TxtSearchMenu.Text & "%'" &
                "OR description LIKE '%" & TxtSearchMenu.Text & "%'
                UNION ALL Select * FROM tbl_beverages_and_items
                WHERE item_code LIKE '" & TxtSearchMenu.Text & "%'" &
                "OR description LIKE '%" & TxtSearchMenu.Text & "%'", Con)
                    DgMenu.Rows.Clear()
                    reader = GetFoodMenu4.ExecuteReader
                    While reader.Read
                        Dim itemNo As String = reader("item_code").ToString()
                        Dim description As String = reader("description").ToString()
                        Dim price As String = reader("price").ToString()
                        Dim stocks As String = reader("stocks").ToString()
                        Dim category As String = reader("category").ToString
                        DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                    End While
                    reader.Close()
                End Using
                Con.Close()
            ElseIf CbFoods.CheckState = CheckState.Checked And CbBevItems.CheckState = CheckState.Unchecked Then
                OpenCon()
                Using GetFoodMenu5 As New MySqlCommand("Select * FROM tbl_menu WHERE item_code
                LIKE '" & TxtSearchMenu.Text & "%'" &
                "OR description LIKE '%" & TxtSearchMenu.Text & "%'", Con)

                    DgMenu.Rows.Clear()
                    reader = GetFoodMenu5.ExecuteReader
                    While reader.Read
                        Dim itemNo As String = reader("item_code").ToString()
                        Dim description As String = reader("description").ToString()
                        Dim price As String = reader("price").ToString()
                        Dim stocks As String = reader("stocks").ToString()
                        Dim category As String = reader("category").ToString
                        DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                        reader.Close()
                    End While
                End Using
                Con.Close()
            ElseIf CbFoods.CheckState = CheckState.Unchecked And CbBevItems.CheckState = CheckState.Checked Then
                OpenCon()
                Using GetFoodMenu6 As New MySqlCommand("Select * FROM tbl_beverages_and_items
                WHERE item_code LIKE '" & TxtSearchMenu.Text & "%'" &
                "OR description LIKE '%" & TxtSearchMenu.Text & "%'", Con)

                    DgMenu.Rows.Clear()
                    reader = GetFoodMenu6.ExecuteReader
                    While reader.Read
                        Dim itemNo As String = reader("item_code").ToString()
                        Dim description As String = reader("description").ToString()
                        Dim price As String = reader("price").ToString()
                        Dim stocks As String = reader("stocks").ToString()
                        Dim category As String = reader("category").ToString
                        DgMenu.Rows.Add(itemNo, description, price, stocks, category)
                    End While
                    reader.Close()
                    Con.Close()
                End Using
                Con.Close()
            End If
        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        If BtnCheckIn.Text = "UPDATE" Then
            Dim result As DialogResult = MessageBox.Show("There are changes that you are not saving." & vbCrLf &
            "Are you sure you want to go back to the room menu?", "Leave Room?", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                OpenChildForm(New FrmRooms)
            Else
                BtnCheckIn.Focus()
            End If
        Else
            OpenChildForm(New FrmRooms)
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblCheckInTime.Text = DateTime.Now
    End Sub
    Private Sub CbDescription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbbDescription.SelectedIndexChanged
        DataModified()
        If LblRoomStatus.Text = "AVAILABLE" Then
            'retrieve duration of selected hourscode
            ShowDuration()
        ElseIf LblRoomStatus.Text = "OCCUPIED" Or LblRoomStatus.Text = "RESERVED" Then

            lblCheckOut.Text = Convert.ToDateTime(LblCheckInTime.Text).AddHours(HoursDuration)
            'for making the countdown timer
            strCheckOutTime = lblCheckOut.Text
            strCurrentTime = DateTime.Now
            checkOutTime = Convert.ToDateTime(strCheckOutTime)
            currentDateTime = Convert.ToDateTime(strCurrentTime)
            RemainingTime = checkOutTime - currentDateTime
            'RemainingTime = TimeSpan.FromSeconds(10) 'For testing countdown
            countDownWatch = Stopwatch.StartNew
            TimerRemainingTime.Start()
        End If
    End Sub


    Private Sub BtnCheckIn_Click(sender As Object, e As EventArgs) Handles BtnCheckIn.Click

        If BtnCheckIn.Text = "EDIT" Then
            CbbDescription.Enabled = Enabled
            BtnCheckIn.Text = "UPDATE"
            BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk
        ElseIf BtnCheckIn.Text = "CHECK-IN" Then
            If CbbDescription.Text = "" Then
                FrmBlurEffect.Show()
                FrmBlurEffect.TopMost = False

                Dim result As DialogResult = MessageBox.Show("Choose Hours first!", "Field Required!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If result = DialogResult.OK Then
                    FrmBlurEffect.Dispose()
                Else
                    FrmBlurEffect.Dispose()
                End If

                CbbDescription.Focus()
                Exit Sub
            Else
                'to get check-out value from check-in time and duration
                Timer1.Stop()
                lblCheckOut.Text = Convert.ToDateTime(LblCheckInTime.Text).AddHours(HoursDuration)

                'for making the countdown timer
                strCheckOutTime = lblCheckOut.Text
                strCurrentTime = DateTime.Now
                checkOutTime = Convert.ToDateTime(strCheckOutTime)
                currentDateTime = Convert.ToDateTime(strCurrentTime)
                RemainingTime = checkOutTime - currentDateTime
                'RemainingTime = TimeSpan.FromSeconds(10) 'For testing countdown
                countDownWatch = Stopwatch.StartNew
                TimerRemainingTime.Start()

                'generate transaction/add or update tbl_transaction_summary
                OpenCon()
                Using GenTransactionNo As New MySqlCommand("INSERT INTO tbl_transaction_summary (room_no,transaction_status)
                VALUES (@currentRoom,@ts)", Con)
                    GenTransactionNo.Parameters.AddWithValue("currentRoom", CurrentRoomNumber)
                    GenTransactionNo.Parameters.AddWithValue("ts", "current")
                    GenTransactionNo.ExecuteNonQuery()
                End Using
                Con.Close()

                'Display transaction number on LblTransactioNo
                OpenCon()
                Using ShowCurrentTNo As New MySqlCommand("SELECT * FROM tbl_transaction_summary
                    ORDER BY transaction_no desc", Con)
                    reader = ShowCurrentTNo.ExecuteReader
                    If reader.Read Then
                        Dim TnoValue As String = reader("transaction_no").ToString
                        LblTransactionNo.Text = TnoValue
                        reader.Close()
                    Else
                        MessageBox.Show("No data found!")
                    End If
                End Using
                Con.Close()

                'call needed funtions
                UpdateStatus()
                TransactInitialized()
                CountRoomStatus()

                'controls manipulation
                BtnCheckIn.Text = "EDIT"
                BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
                LblHAvailed.Text = "Hours Availed:"
                CbbDescription.Enabled = False
                grandTotal()

            End If
        ElseIf BtnCheckIn.Text = "UPDATE" Then
            TimerRemainingTime.Stop()
            ShowDuration()
            lblCheckOut.Text = Convert.ToDateTime(LblCheckInTime.Text).AddHours(HoursDuration)
            'for making the countdown timer
            strCheckOutTime = lblCheckOut.Text
            strCurrentTime = DateTime.Now
            checkOutTime = Convert.ToDateTime(strCheckOutTime)
            currentDateTime = Convert.ToDateTime(strCurrentTime)
            RemainingTime = checkOutTime - currentDateTime

            'RemainingTime = TimeSpan.FromSeconds(10) 'For testing countdown
            countDownWatch = Stopwatch.StartNew
            TimerRemainingTime.Start()

            'call needed funtions
            UpdateStatus()
            TransactInitialized()
            grandTotal()

            BtnCheckIn.Text = "EDIT"
            BtnCheckIn.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
            LblHAvailed.Text = "Hours Availed:"
            CbbDescription.Enabled = False
        End If


    End Sub

    Private Sub TimerRemainingTime_Tick(sender As Object, e As EventArgs) Handles TimerRemainingTime.Tick
        Dim timeRemaining = RemainingTime - countDownWatch.Elapsed
        '  Static alreadyIncremented0 As Boolean = False
        '  Static alreadyIncremented1 As Boolean = False
        '  Static alreadyIncremented2 As Boolean = False
        '  Static alreadyIncremented3 As Boolean = False
        '  Static alreadyIncremented4 As Boolean = False
        '  Static alreadyIncremented5 As Boolean = False
        '  Static alreadyIncremented6 As Boolean = False
        If timeRemaining < TimeSpan.Zero Then
            LblRTDes.Text = "EXCESS TIME"
            LblRemainingTime.ForeColor = Color.Maroon

        Else
            LblRTDes.Text = "REMAINING TIME"
            LblRemainingTime.ForeColor = Color.Black
        End If

        '   
        '   If timeRemaining <= TimeSpan.FromMinutes(firstexcess) AndAlso
        '       Not alreadyIncremented0 Then
        '       Me.Refresh()
        '       alreadyIncremented0 = True
        '   ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess) AndAlso
        '       Not alreadyIncremented1 Then
        '       Me.Refresh()
        '       alreadyIncremented1 = True
        '   ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess + additionalExcess) AndAlso
        '       Not alreadyIncremented2 Then
        '       Me.Refresh()
        '       alreadyIncremented2 = True
        '   ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess * 2) AndAlso
        '       Not alreadyIncremented3 Then
        '       Me.Refresh()
        '       alreadyIncremented3 = True
        '   ElseIf timeRemaining <= TimeSpan.FromMinutes(secondexcess * 2 + additionalExcess) AndAlso
        '       Not alreadyIncremented4 Then
        '       Me.Refresh()
        '       alreadyIncremented4 = True
        '   ElseIf timeRemaining <= TimeSpan.FromMinutes((secondexcess * 2) + (additionalExcess * 2)) AndAlso
        '       Not alreadyIncremented5 Then
        '       Me.Refresh()
        '       alreadyIncremented5 = True
        '   End If
        LblRemainingTime.Text = timeRemaining.ToString("hh\:mm\:ss")
    End Sub

    Private Sub TxtSearchMenu_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchMenu.TextChanged
        FillMenuTable()
    End Sub

    Private Sub CbFoods_CheckedChanged(sender As Object, e As EventArgs) Handles CbFoods.CheckedChanged
        FillMenuTable()
    End Sub

    Private Sub CbBevItems_CheckedChanged(sender As Object, e As EventArgs) Handles CbBevItems.CheckedChanged
        FillMenuTable()
    End Sub

    Private Sub TxtSearchMenu_GotFocus(sender As Object, e As EventArgs) Handles TxtSearchMenu.GotFocus
        'clear menu search if text is -Search order here-
        If TxtSearchMenu.Text = "-Search order here-" Then
            TxtSearchMenu.Text = ""
            txtSearchHighlights = True
        End If
    End Sub

    Private Sub TxtSearchMenu_LostFocus(sender As Object, e As EventArgs) Handles TxtSearchMenu.LostFocus
        'menu seach back to original state if you leave the txtbox blank
        If TxtSearchMenu.Text = "" Then
            TxtSearchMenu.Text = "-Search order here-"
        End If
        txtSearchHighlights = True
    End Sub

    Private Sub TxtSearchMenu_Click(sender As Object, e As EventArgs) Handles TxtSearchMenu.Click
        'highlights the existing txt of menu search when you click
        If TxtSearchMenu.Text <> "" And txtSearchHighlights = True Then
            TxtSearchMenu.SelectAll()
            txtSearchHighlights = False
        ElseIf TxtSearchMenu.Text <> "" And txtSearchHighlights = False Then
            Exit Sub
        End If
    End Sub
    Private Sub DgMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMenu.CellDoubleClick
        qty_tnum = LblTransactionNo.Text
        qty_ic = DgMenu.SelectedRows.Item(0).Cells(0).Value.ToString
        qty_particulars = DgMenu.SelectedRows.Item(0).Cells(1).Value.ToString
        qty_price = DgMenu.SelectedRows.Item(0).Cells(2).Value
        qty_category = DgMenu.SelectedRows.Item(0).Cells(4).Value.ToString

        ' Iterate through the DataGridView to find the matching item code in the first column (index 0)
        For Each row As DataGridViewRow In DGTransact.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = qty_ic Then
                ' Found a match, get the quantity from the second column (index 1)
                ' put the quantity to variable
                qty_qty = row.Cells(2).Value.ToString()
                ' Exit the loop
                Exit For
            End If
        Next
        FrmBlurEffect.Show()
        FrmBlurEffect.TopMost = False
        formUsingQTY = "FrmTransactGuest"
        Using formSubQTY As New FrmSubQTY()
            formSubQTY.ShowDialog()
        End Using

    End Sub

    Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
        FrmBlurEffect.Show()
        Using frmshow As New FrmSubTransfer
            frmshow.ShowDialog()
        End Using

    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        DataModified()
    End Sub

    Private Sub TxtContactNo_TextChanged(sender As Object, e As EventArgs) Handles TxtContactNo.TextChanged
        DataModified()
    End Sub

    Private Sub TxtVtype_TextChanged(sender As Object, e As EventArgs) Handles TxtVtype.TextChanged
        DataModified()
    End Sub

    Private Sub TxtPlateNo_TextChanged(sender As Object, e As EventArgs) Handles TxtPlateNo.TextChanged
        DataModified()
    End Sub

    Private Sub CbbGType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbbGType.SelectedIndexChanged
        DataModified()
        If CBBChangeIndexes = True Then
            If CbbGType.Text = "" Or CbbGType.Text = "REGULAR" Then
                LblGTPercentage.Text = "0%"
                LblGDiscount.Text = "0.00"
            Else
                OpenCon()
                Using GType As New MySqlCommand("SELECT * FROM tbl_discountsandpromo_setting
                WHERE discount_code=@dc", Con)
                    Dim Gtypereader As MySqlDataReader
                    GType.Parameters.AddWithValue("dc", CbbGType.Text)
                    Gtypereader = GType.ExecuteReader
                    While Gtypereader.Read
                        Dim GPercentage = Gtypereader("percentage").ToString
                        LblGTPercentage.Text = GPercentage & "%"
                        Dim DiscountAmount As Double = CDbl(GPercentage / 100) * PartialTotal
                        Dim DisAmtFormatted As String = DiscountAmount.ToString("0.00")
                        LblGDiscount.Text = DisAmtFormatted
                    End While
                    Gtypereader.Close()
                End Using
                Con.Close()
            End If
        End If
        grandTotal()
    End Sub

    Private Sub CbbGuestCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbbGuestCount.SelectedIndexChanged
        DataModified()
        If CBBChangeIndexes = True Then
            EGCount = Val(CbbGuestCount.Text) - 2
            If CbbGuestCount.Text = "" Or CbbGuestCount.Text = "2" Then
                'display computed rate per extra guest to transaction preview
                LblEGqty.Text = "0"
                LblEGprice.Text = "0.00"
                LblEGamount.Text = "0.00"
            Else
                Try
                    OpenCon()
                    Using RatePerExtraGuest As New MySqlCommand("SELECT * FROM tbl_rates
                   WHERE rates_code='" & "extra_guest" & "'", Con)
                        Dim RPEGuestReader As MySqlDataReader
                        RPEGuestReader = RatePerExtraGuest.ExecuteReader
                        If RPEGuestReader.Read Then
                            LblEGqty.Text = EGCount
                            LblEGprice.Text = Convert.ToDouble(RPEGuestReader("price").ToString).ToString("0.00")
                            Dim EGamount = Convert.ToDouble(EGCount * Val(LblEGprice.Text)).ToString("0.00")
                            LblEGamount.Text = EGamount
                        End If
                        RPEGuestReader.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Con.Close()
            End If
        End If
        grandTotal()
    End Sub


    Private Sub TxtAddress_TextChanged(sender As Object, e As EventArgs) Handles TxtAddress.TextChanged
        DataModified()
    End Sub
    Private Sub BtnCheckIn_TextChanged(sender As Object, e As EventArgs) Handles BtnCheckIn.TextChanged
        If BtnCheckIn.Text = "UPDATE" Then
            CbbDescription.Enabled = True
        ElseIf BtnCheckIn.Text = "EDIT" Then
            CbbDescription.Enabled = False
        Else
            CbbDescription.Enabled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        FrmBlurEffect.Show()

        If LblRoomStatus.Text = "AVAILABLE" Then

            Dim result As DialogResult = MessageBox.Show("There Is no current booking On this room To cancel.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand)

            If result = DialogResult.OK Then
                FrmBlurEffect.Dispose()
            Else
                FrmBlurEffect.Dispose()
            End If
        Else
            Dim result1 As DialogResult = MessageBox.Show("Are you sure you want To cancel this booking?" & vbCrLf &
                "This action will Not be undone.", "CANCEL BOOKING", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = DialogResult.Yes Then
                'for updating tbl roomstatus details for cancellation
                FrmBlurEffect.Dispose()
                Try
                    OpenCon()
                    Using DelStatus As New MySqlCommand("UPDATE tbl_room_status Set transaction_no=@tno, guest_name =@gname,
                contact_no =@cno, vehicle_type =@vtype, plate_no =@pno, guest_type =@gtype, guest_disper =@gDis,
                guest_disamount =@gDisamount, guest_count =@gcount, senior_id =@sid, address =@add, hours_code =@hcode, addon =@addon,
                check_in_time =@checkin, duration_hours =@dHours, check_out_time =@CheckOut, promo_type =@ptype,
                promo_percentage =@pper, promo_amount =@pamount, other_discountper =@odper, other_disamount =@odamount, comment =@c,
                occupied =@isoccupied, available =@isavailable, housekeeping =@isHousekeeping, reserved =@isReserved,
                maintenance =@isMaintenance, deactivated =@isDeactivated WHERE room_id=@roomid", Con)
                        Dim tno As String = ""
                        Dim gName As String = ""
                        Dim cno As String = ""
                        Dim vType As String = ""
                        Dim pNo As String = ""
                        Dim gType As String = ""
                        Dim gCount As String = ""
                        Dim sid As String = ""
                        Dim add As String = ""
                        Dim hcode As String = ""
                        Dim checkin As String = ""
                        Dim dhours As String = ""
                        Dim checkout As String = ""
                        Dim comment As String = ""
                        Dim isOccupied As Boolean = False
                        Dim isAvailable As Boolean = True
                        Dim isHousekeeping As Boolean = False
                        Dim isReserved As Boolean = False
                        Dim isMaintenance As Boolean = False
                        Dim isDeactivated As Boolean = False
                        DelStatus.Parameters.AddWithValue("roomid", CurrentRoomNumber)
                        DelStatus.Parameters.AddWithValue("tno", tno)
                        DelStatus.Parameters.AddWithValue("gname", gName)
                        DelStatus.Parameters.AddWithValue("cno", cno)
                        DelStatus.Parameters.AddWithValue("vtype", vType)
                        DelStatus.Parameters.AddWithValue("pno", pNo)
                        DelStatus.Parameters.AddWithValue("gtype", gType)
                        DelStatus.Parameters.AddWithValue("gcount", gCount)
                        DelStatus.Parameters.AddWithValue("sid", sid)
                        DelStatus.Parameters.AddWithValue("add", add)
                        DelStatus.Parameters.AddWithValue("hcode", hcode)
                        DelStatus.Parameters.AddWithValue("checkin", checkin)
                        DelStatus.Parameters.AddWithValue("dhours", dhours)
                        DelStatus.Parameters.AddWithValue("checkout", checkout)
                        DelStatus.Parameters.AddWithValue("c", comment)
                        DelStatus.Parameters.AddWithValue("gDis", 0)
                        DelStatus.Parameters.AddWithValue("gDisamount", 0)
                        DelStatus.Parameters.AddWithValue("addon", "")
                        DelStatus.Parameters.AddWithValue("ptype", "")
                        DelStatus.Parameters.AddWithValue("pper", 0)
                        DelStatus.Parameters.AddWithValue("pamount", 0)
                        DelStatus.Parameters.AddWithValue("odper", 0)
                        DelStatus.Parameters.AddWithValue("odamount", 0)
                        DelStatus.Parameters.AddWithValue("isoccupied", isOccupied)
                        DelStatus.Parameters.AddWithValue("isavailable", isAvailable)
                        DelStatus.Parameters.AddWithValue("ishousekeeping", isHousekeeping)
                        DelStatus.Parameters.AddWithValue("isreserved", isReserved)
                        DelStatus.Parameters.AddWithValue("ismaintenance", isMaintenance)
                        DelStatus.Parameters.AddWithValue("isdeactivated", isDeactivated)
                        If DelStatus.ExecuteNonQuery Then

                            MessageBox.Show("Guest booking successfully canceled.", "Canceled!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Con.Close()
                            CountRoomStatus()

                        Else
                            MessageBox.Show("Guest booking failed to update!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error on deleting current room status. " & ex.Message, "Error!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try

                'for updating tbl transaction details for cancellation
                Try
                    OpenCon()
                    Using CTransaction As New MySqlCommand("UPDATE tbl_transaction_summary SET receipt_no=@rno,
                        room_no=@roomno,guest_type=@gtype,guest_percentage=@gper,guest_discount=@gamount,
                        accomodation=@acco,check_in=@checkin,check_out=@checkout,hour_duration=@hduration,
                        room_rent_amount@=rramount, addon=@addon,excess_hour=@excesshour,excess_rateperhour=@erate,
                        excess_amount=@excessamount,promo_type=@promotype,promo_percentage=@ppercentage,
                        promo_discount_amount=@pdamount,other_discount_percentage=@odpercentage,
                        other_discount_amount=@odamount,guest_count=@gcount,extra_guest_qty=@egqty,
                        extra_guest_perheadrate=@egperhead,extra_guest_fee=@egfee,total_order=totalorder,
                        senior_id=@seniorid,other_deduction=@otherdeduction,vat_percentage=@vatper,vat_sales=@vatsales,
                        vat=@vat,partial_total=@ptotal,grand_total=@gtotal,transact_by=@transactby,checked_by=@checkedby,
                        housekeeping=@housekeeping,comment=@comment,transaction_status=@tstatus, date=@date
                        WHERE transaction_no=@tno", Con)
                        CTransaction.Parameters.AddWithValue("tno", LblTransactionNo.Text)
                        CTransaction.Parameters.AddWithValue("rno", "")
                        CTransaction.Parameters.AddWithValue("roomno", CurrentRoomNumber)
                        CTransaction.Parameters.AddWithValue("gtype", CbbGType.Text)
                        CTransaction.Parameters.AddWithValue("gper", LblGTPercentage.Text)
                        CTransaction.Parameters.AddWithValue("gamount", LblGDiscount.Text)
                        CTransaction.Parameters.AddWithValue("acco", "")
                        CTransaction.Parameters.AddWithValue("checkin", LblCheckInTime.Text)
                        CTransaction.Parameters.AddWithValue("checkout", lblCheckOut.Text)
                        CTransaction.Parameters.AddWithValue("hduration", THoursDuration)
                        CTransaction.Parameters.AddWithValue("rramount", LblDHamount.Text)
                        CTransaction.Parameters.AddWithValue("addon", LblAddOn.Text)
                        CTransaction.Parameters.AddWithValue("excesshour", LblEHqty.Text)
                        CTransaction.Parameters.AddWithValue("erate", LblEHprice.Text)
                        CTransaction.Parameters.AddWithValue("excessamount", CDbl(LblEHamount.Text))
                        CTransaction.Parameters.AddWithValue("promotype", CbbPromo.Text)
                        CTransaction.Parameters.AddWithValue("ppercentage", LblPDPercentage.Text.TrimEnd("%"c))
                        CTransaction.Parameters.AddWithValue("pdamount", CDbl(LblPromoDiscount.Text))
                        CTransaction.Parameters.AddWithValue("odpercentage", LblODPercentage.Text.TrimEnd("%"c))
                        CTransaction.Parameters.AddWithValue("odamount", CDbl(LblOtherDiscount.Text))
                        CTransaction.Parameters.AddWithValue("gcount", CbbGuestCount.Text)
                        CTransaction.Parameters.AddWithValue("egqty", Val(LblEGqty.Text))
                        CTransaction.Parameters.AddWithValue("egperhead", CDbl(LblEGprice.Text))
                        CTransaction.Parameters.AddWithValue("egfee", CDbl(LblEGamount.Text))
                        CTransaction.Parameters.AddWithValue("totalorder", TotalOrderAmount)
                        CTransaction.Parameters.AddWithValue("seniorid", TxtSeniorNo.Text)
                        CTransaction.Parameters.AddWithValue("otherdeduction", "")
                        CTransaction.Parameters.AddWithValue("vatper", vatPercentage)
                        CTransaction.Parameters.AddWithValue("vatsales", "")
                        CTransaction.Parameters.AddWithValue("vat", "")
                        CTransaction.Parameters.AddWithValue("ptotal", CDbl(LblPartialTotal.Text))
                        CTransaction.Parameters.AddWithValue("gtotal", CDbl(LblGrandTotal.Text))
                        CTransaction.Parameters.AddWithValue("transactby", currentUserName)
                        CTransaction.Parameters.AddWithValue("checkedby", "")
                        CTransaction.Parameters.AddWithValue("housekeeping", "")
                        CTransaction.Parameters.AddWithValue("comment", LblTransactionNo.Text)
                        CTransaction.Parameters.AddWithValue("tstatus", "CANCELED")
                        CTransaction.Parameters.AddWithValue("date", DateTime.Now.ToString)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Current transaction data update error. " & ex.Message, "Error!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try

                FrmBlurEffect.Hide()
                OpenChildForm(New FrmRooms)
            ElseIf result1 = DialogResult.No Then
                FrmBlurEffect.Hide()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub CbbGType_Click(sender As Object, e As EventArgs) Handles CbbGType.Click
        CbbGType.DroppedDown = True
    End Sub

    Private Sub DGTransact_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTransact.CellDoubleClick

        qty_tnum = LblTransactionNo.Text
        qty_ic = DGTransact.SelectedRows.Item(0).Cells(0).Value.ToString
        qty_particulars = DGTransact.SelectedRows.Item(0).Cells(1).Value.ToString
        qty_price = DGTransact.SelectedRows.Item(0).Cells(2).Value
        qty_category = DGTransact.SelectedRows.Item(0).Cells(4).Value.ToString

        ' Iterate through the DataGridView to find the matching item code in the first column (index 0)
        For Each row As DataGridViewRow In DGTransact.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = qty_ic Then
                ' Found a match, get the quantity from the second column (index 1)
                ' put the quantity to variable
                qty_qty = row.Cells(2).Value.ToString()
                ' Exit the loop
                Exit For
            End If
        Next

        FrmBlurEffect.Show()
        FrmBlurEffect.TopMost = False

        Using frmQTY As New FrmSubQTY
            frmQTY.ShowDialog()
        End Using
    End Sub


    Private Sub txtOtherDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtOtherDiscount.TextChanged
        DataModified()
        If txtOtherDiscount.Text = "" Or Val(txtOtherDiscount.Text) = 0 Then
            LblODPercentage.Text = "0%"
            LblOtherDiscount.Text = "0.00"
        Else
            LblODPercentage.Text = txtOtherDiscount.Text & "%"
            Dim DiscountAmount As Decimal = Val(txtOtherDiscount.Text / 100) * Val(LblPartialTotal.Text)
            Dim DiscountAmountFormatted As String = DiscountAmount.ToString("0.00")
            LblOtherDiscount.Text = DiscountAmountFormatted
        End If
        grandTotal()
    End Sub

    Private Sub CbbPromo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbbPromo.SelectedIndexChanged
        DataModified()
        If CBBChangeIndexes = True Then
            If CbbPromo.Text = "" Or CbbPromo.Text = "None" Then
                LblPDPercentage.Text = "0%"
                LblPromoDiscount.Text = "0.00"
            Else
                OpenCon()
                Using Gpromo As New MySqlCommand("SELECT * FROM tbl_discountsandpromo_setting
                    WHERE discount_code=@dc", Con)
                    Dim GpromoReader As MySqlDataReader
                    Gpromo.Parameters.AddWithValue("dc", CbbPromo.Text)
                    GpromoReader = Gpromo.ExecuteReader
                    If GpromoReader.Read Then
                        Dim GPercentage = GpromoReader("percentage").ToString
                        LblPDPercentage.Text = GPercentage & "%"
                        Dim DiscountAmount = Convert.ToDouble((GPercentage / 100) * PartialTotal).ToString("0.00")
                        LblPromoDiscount.Text = DiscountAmount
                    End If
                    GpromoReader.Close()
                End Using
                Con.Close()
            End If
        End If
        grandTotal()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtName.Text = ""
        TxtContactNo.Text = ""
        TxtVtype.Text = ""
        TxtPlateNo.Text = ""
        CbbGType.Text = ""
        CbbGuestCount.Text = ""
        TxtSeniorNo.Text = ""
        TxtAddress.Text = ""
        CbbPromo.Text = ""
        txtOtherDiscount.Text = ""
    End Sub


    Private Sub TxtSeniorNo_TextChanged(sender As Object, e As EventArgs) Handles TxtSeniorNo.TextChanged
        DataModified()
    End Sub

    Private Sub BtnCheckOut_Click(sender As Object, e As EventArgs) Handles BtnCheckOut.Click
        Dim VatPerDouble As Double = vatPercentage / 100
        currentTransactionNo = Val(LblTransactionNo.Text)
        If currentRoomStatus = "OCCUPIED" Or currentRoomStatus = "RESERVED" Then
            If BtnCheckIn.Text = "UPDATE" Then
                FrmBlurEffect.Show()
                Dim result As DialogResult = MessageBox.Show("There are changes that you are not saving." & vbCrLf &
                "Make sure all the data are right and correct then click the UPDATE button before proceeding to CHECK-OUT",
                                "Leave Room?", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                BtnCheckIn.Focus()
                If result = DialogResult.OK Then
                    FrmBlurEffect.Hide()
                Else
                    FrmBlurEffect.Hide()
                End If
            Else

                myDataTable = DataGridViewToDataTable(DGTransact) ' set myDatable as DGTransact datatable for check out

                ' update generated transaction at tbl_transact_summary for check out form
                Try
                    OpenCon()
                    Using CTransaction As New MySqlCommand("UPDATE tbl_transaction_summary SET receipt_no=@rno,
                        room_no=@roomno,guest_type=@gtype,guest_percentage=@gper,guest_discount=@gamount,
                        accomodation=@acco,check_in=@checkin,check_out=@checkout,hours_duration=@hduration,
                        room_rent_amount=@rramount, addon=@addon,excess_hours=@excesshour,excess_rateperhour=@erate,
                        excess_amount=@excessamount,promo_type=@promotype,promo_percentage=@ppercentage,
                        promo_discount_amount=@pdamount,other_discount_percentage=@odpercentage,
                        other_discount_amount=@odamount,guest_count=@gcount,extra_guest_qty=@egqty,
                        extra_guest_perheadrate=@egperhead,extra_guest_fee=@egfee,total_order=@totalorder,
                        senior_id=@seniorid,other_deduction=@otherdeduction,vat_percentage=@vatper,vat_sales=@vatsales,
                        vat=@vat,partial_total=@ptotal,grand_total=@gtotal,transact_by=@transactby,checked_by=@checkedby,
                        housekeeping=@housekeeping,comment=@comment,transaction_status=@tstatus,total_room_rent=@TRoomrent
                        WHERE transaction_no=@tno", Con)
                        CTransaction.Parameters.AddWithValue("tno", currentTransactionNo)
                        CTransaction.Parameters.AddWithValue("rno", "")
                        CTransaction.Parameters.AddWithValue("roomno", CurrentRoomNumber)
                        CTransaction.Parameters.AddWithValue("gtype", CbbGType.Text)
                        CTransaction.Parameters.AddWithValue("gper", Val(LblGTPercentage.Text))
                        CTransaction.Parameters.AddWithValue("gamount", CDbl(LblGDiscount.Text))
                        CTransaction.Parameters.AddWithValue("acco", "DRIVE-IN")
                        CTransaction.Parameters.AddWithValue("checkin", LblCheckInTime.Text)
                        CTransaction.Parameters.AddWithValue("checkout", lblCheckOut.Text)
                        CTransaction.Parameters.AddWithValue("hduration", THoursdurationInt)
                        CTransaction.Parameters.AddWithValue("rramount", LblDHamount.Text)
                        CTransaction.Parameters.AddWithValue("addon", LblAddOn.Text)
                        CTransaction.Parameters.AddWithValue("excesshour", LblEHqty.Text)
                        CTransaction.Parameters.AddWithValue("erate", LblEHprice.Text)
                        CTransaction.Parameters.AddWithValue("excessamount", CDbl(LblEHamount.Text))
                        CTransaction.Parameters.AddWithValue("promotype", CbbPromo.Text)
                        CTransaction.Parameters.AddWithValue("ppercentage", LblPDPercentage.Text.TrimEnd("%"c))
                        CTransaction.Parameters.AddWithValue("pdamount", CDbl(LblPromoDiscount.Text))
                        CTransaction.Parameters.AddWithValue("odpercentage", LblODPercentage.Text.TrimEnd("%"c))
                        CTransaction.Parameters.AddWithValue("odamount", CDbl(LblOtherDiscount.Text))
                        CTransaction.Parameters.AddWithValue("gcount", CbbGuestCount.Text)
                        CTransaction.Parameters.AddWithValue("egqty", Val(LblEGqty.Text))
                        CTransaction.Parameters.AddWithValue("egperhead", CDbl(LblEGprice.Text))
                        CTransaction.Parameters.AddWithValue("egfee", CDbl(LblEGamount.Text))
                        CTransaction.Parameters.AddWithValue("totalorder", TotalOrderAmount)
                        CTransaction.Parameters.AddWithValue("TRoomrent", CDbl(LblDHamount.Text) +
                                                             CDbl(LblEGamount.Text) + CDbl(LblEHamount.Text))
                        CTransaction.Parameters.AddWithValue("seniorid", TxtSeniorNo.Text)
                        CTransaction.Parameters.AddWithValue("otherdeduction", "")
                        CTransaction.Parameters.AddWithValue("vatper", vatPercentage)
                        CTransaction.Parameters.AddWithValue("vatsales", CDbl(LblGrandTotal.Text - (LblGrandTotal.Text * VatPerDouble)))
                        CTransaction.Parameters.AddWithValue("vat", CDbl(LblGrandTotal.Text) * VatPerDouble)
                        CTransaction.Parameters.AddWithValue("ptotal", CDbl(LblPartialTotal.Text))
                        CTransaction.Parameters.AddWithValue("gtotal", CDbl(LblGrandTotal.Text))
                        CTransaction.Parameters.AddWithValue("transactby", currentUserName)
                        CTransaction.Parameters.AddWithValue("checkedby", "")
                        CTransaction.Parameters.AddWithValue("housekeeping", "")
                        CTransaction.Parameters.AddWithValue("comment", LblTransactionNo.Text)
                        CTransaction.Parameters.AddWithValue("tstatus", "current")
                        If CTransaction.ExecuteNonQuery() Then
                            FrmBlurEffect.Show()
                            Using showCheckOut As New FrmCheckOut
                                FrmCheckOut.BringToFront()
                                showCheckOut.ShowDialog()
                            End Using

                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Current transaction data update error. " & ex.Message, "Error!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try
            End If
        ElseIf currentRoomStatus = "AVAILABLE" Then
            Dim result3 As DialogResult = MessageBox.Show("There are no current booking on this room.",
                                "Check-out error!", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            If result3 = DialogResult.OK Then
                FrmBlurEffect.Hide()
            Else
                FrmBlurEffect.Hide()
            End If
        End If

    End Sub

    Private Sub TxtComment_TextChanged(sender As Object, e As EventArgs) Handles TxtComment.TextChanged
        DataModified()
    End Sub
End Class