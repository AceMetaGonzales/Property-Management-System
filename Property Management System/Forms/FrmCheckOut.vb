Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FrmCheckOut
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.ShowInTaskbar = False ' This line is important to hide it from the taskbar.

    End Sub

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    'data value holders
    Dim receiptNo As String
    Dim roomNo As String
    Dim gType As String
    Dim gPer As Integer
    Dim gDis As Double
    Dim accomodation As String
    Dim CIT As String
    Dim COT As String
    Dim HDuration As Integer
    Dim RentAmount As Double
    Dim Addon As String
    Dim EHours As Integer
    Dim ERate As Double
    Dim EAmount As Double
    Dim PType As String
    Dim PPer As Integer
    Dim PAmount As Double
    Dim OPer As Integer
    Dim OAmount As Double
    Dim GCount As Integer
    Dim EGQTY As Integer
    Dim EGRate As Double
    Dim EGAmount As Double
    Dim TotalOrder As Double
    Dim TotalRoomRent As Double
    Dim SID As String
    Dim OtherDeduction As Double
    Dim vatPer As Double
    Dim vatSales As Double
    Dim vat As Double
    Dim PTotal As Double
    Dim GTotal As Double
    Dim GtotalStatic As Double
    Dim TBy As String
    Dim CBy As String
    Dim HBy As String
    Dim comment As String
    Dim TStatus As String
    Dim CashMoney As Double
    Dim changeMoney As Double
    Dim RefNo As String

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
    Sub finalizeTransaction()

        'for updating tbl transaction summary details for sales
        Try
            OpenCon()
            Using CTransaction As New MySqlCommand("UPDATE tbl_transaction_summary SET receipt_no=@rno,
                       other_deduction=@otherdeduction,vat_sales=@vatsales,
                        vat=@vat,grand_total=@gtotal,transact_by=@transactby,checked_by=@checkedby,
                        housekeeping=@housekeeping,comment=@comment,transaction_status=@tstatus,cash=@cash,
                        payment_method=@PMethod,reference_no=@Refno,date=@date
                        WHERE transaction_no=@tno", Con)
                CTransaction.Parameters.AddWithValue("tno", LblTransactionNo.Text)
                CTransaction.Parameters.AddWithValue("rno", txtReceiptNo.Text)

                If TxtODeduction.Text = "" Then
                    CTransaction.Parameters.AddWithValue("otherdeduction", 0)
                Else
                    CTransaction.Parameters.AddWithValue("otherdeduction", CDbl(TxtODeduction.Text))
                End If

                CTransaction.Parameters.AddWithValue("vatsales", vatSales)
                CTransaction.Parameters.AddWithValue("vat", vat)
                CTransaction.Parameters.AddWithValue("gtotal", GTotal)
                CTransaction.Parameters.AddWithValue("transactby", currentUserName)
                CTransaction.Parameters.AddWithValue("checkedby", CbbCheckby.Text)
                CTransaction.Parameters.AddWithValue("housekeeping", CBBHousekeeping.Text)
                CTransaction.Parameters.AddWithValue("comment", LblTransactionNo.Text)
                CTransaction.Parameters.AddWithValue("tstatus", "SALE")
                CTransaction.Parameters.AddWithValue("date", DateTime.Now.ToString)
                CTransaction.Parameters.AddWithValue("refno", TxtRefNo.Text)
                CTransaction.Parameters.AddWithValue("PMethod", CBBPMethod.Text)
                If TxtCash.Text = "" Then
                    CTransaction.Parameters.AddWithValue("cash", 0)
                Else
                    CTransaction.Parameters.AddWithValue("cash", CDbl(TxtCash.Text))
                End If

                CTransaction.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Current transaction data update error. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'for updating tbl roomstatus details for sales
        Try
            OpenCon()
            Using DelStatus As New MySqlCommand("UPDATE tbl_room_status Set transaction_no=@tno, guest_name=@gname,
                contact_no=@cno, vehicle_type=@vtype, plate_no=@pno, guest_type=@gtype, guest_disper=@gDis,
                guest_disamount =@gDisamount, guest_count=@gcount, senior_id=@sid, address=@add, hours_code=@hcode,
                addon=@addon,
                check_in_time=@checkin, duration_hours=@dHours, check_out_time=@CheckOut, promo_type=@ptype,
                promo_percentage=@pper, promo_amount=@pamount, other_discountper=@odper, other_disamount=@odamount,
                comment=@c,
                occupied =@isoccupied, available=@isavailable, housekeeping=@isHousekeeping, reserved=@isReserved,
                maintenance=@isMaintenance, deactivated=@isDeactivated,assigned_housekeep=@ahousekeep
                WHERE room_id=@roomid", Con)
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
                Dim isAvailable As Boolean = False
                Dim isHousekeeping As Boolean = True
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
                DelStatus.Parameters.AddWithValue("ahousekeep", CBBHousekeeping.Text)
                If DelStatus.ExecuteNonQuery Then
                    Con.Close()
                    CountRoomStatus()
                Else
                    MessageBox.Show("Check-out failed to process!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on deleting current room status. " & ex.Message, "Error!",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'ADDING TRANSACTION TO LOG
        Try
            OpenCon()
            Using addToTransLog As New MySqlCommand("INSERT INTO tbl_log (logdetails,logtype,logreason,logtime,loguser,
                    logposition) VALUES (@ldetails,@ltype,@lreason,@ltime,@luser,@lposition)", Con)
                addToTransLog.Parameters.AddWithValue("ldetails", currentUserName & " check-out Room " &
                                                      CurrentRoomNumber & "." & vbCrLf &
                                                      "Recorded as Sales with a total amount of " &
                                                      GTotal.ToString("0.00") &
                                                      ". Room status switching to housekeeping with assigned personel " &
                                                        CBBHousekeeping.Text & ".")
                addToTransLog.Parameters.AddWithValue("ltype", "SALES")
                addToTransLog.Parameters.AddWithValue("lreason", "CHECK-OUT")
                addToTransLog.Parameters.AddWithValue("ltime", DateTime.Now.ToString)
                If currentUserName = Nothing Then
                    addToTransLog.Parameters.AddWithValue("luser", "")
                Else
                    addToTransLog.Parameters.AddWithValue("luser", currentUserName.ToString)
                End If
                If currentUserPosition = Nothing Then
                    addToTransLog.Parameters.AddWithValue("lposition", "")
                Else
                    addToTransLog.Parameters.AddWithValue("lposition", currentUserPosition.ToString)
                End If

                If addToTransLog.ExecuteNonQuery() Then
                    Con.Close()
                    OpenChildForm(New FrmRooms)
                    Me.Hide()
                    Dim result As DialogResult = MessageBox.Show("Room No. " & CurrentRoomNumber &
                                " successfully Check-Out. Room status switching to housekeeping with assigned personel " &
                                CBBHousekeeping.Text & "." & vbCrLf & "Printing receipt.",
                                "Check-Out Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result = DialogResult.OK Then
                        FrmBlurEffect.Dispose()
                    Else
                        FrmBlurEffect.Dispose()
                    End If
                Else

                    Dim result2 As DialogResult = MessageBox.Show("Log not save!", "Error!",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If result2 = DialogResult.OK Then
                        FrmBlurEffect.Dispose()
                    Else
                        FrmBlurEffect.Dispose()
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on adding transaction to log. " & ex.Message, "Error!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)
            FrmBlurEffect.Dispose()
        Finally
            Con.Close()
        End Try
    End Sub
    Sub changelongpaper()
        Dim getDynamicHeight As Integer
        longpaper = 0

        If myDataTable.Rows.Count <= 0 Then
            longpaper = 790
        Else

            ''COMPUTE THE DYNAMIC RECEIPT HEIGHT DEPENDS ON ORDERS TABLE

            ' Assuming you have a DataGridView named dgvItems
            Dim categories As New List(Of String)()
            ' Iterate through the rows of the DataGridView
            For Each row1 As DataRow In myDataTable.Rows

                Dim category1 As String = row1(5).ToString() ' Use index 2 for the third column

                ' Check if the category is not already in the list before adding it
                If Not categories.Contains(category1) Then
                    categories.Add(category1)
                End If
            Next

            ' Convert the List(Of String) to a String array
            Dim categoriesToPrint() As String = categories.ToArray()

            For Each categoryToPrint As String In categoriesToPrint
                ' Print the category header
                Dim categoryHeader As String = categoryToPrint
                getDynamicHeight += 20
                For row As Integer = 0 To myDataTable.Rows.Count - 1
                    Dim category As String = myDataTable.Rows(row).Item(5).ToString() ' Assuming category is in column 5
                    If category = categoryToPrint Then
                        getDynamicHeight += 10
                    End If
                Next
                getDynamicHeight += 10
            Next
            getDynamicHeight += 10
        End If
        'add the dynamic height to original receipt height
        longpaper = getDynamicHeight + 790
    End Sub
    Private Sub BTPRINT_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If CBBPMethod.Text = "CASH" Then
            If txtReceiptNo.Text = "" Or CbbCheckby.Text = "" Or CBBHousekeeping.Text = "" Or TxtCash.Text = "" Then
                Me.Hide()
                MessageBox.Show("Required field(s) or Cash Amount not filled-up!", "Incomplete data!",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Show()
                Exit Sub
            Else
                CashMoney = CDbl(TxtCash.Text)
                changeMoney = CDbl(LblChange.Text)
            End If
        ElseIf CBBPMethod.Text = "GCASH" Then
            If txtReceiptNo.Text = "" Or CbbCheckby.Text = "" Or CBBHousekeeping.Text = "" Or TxtRefNo.Text = "" Then
                Me.Hide()
                MessageBox.Show("Required field(s) or Reference No. not filled-up!", "Incomplete data!",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Show()
                Exit Sub
            Else
                RefNo = TxtRefNo.Text
            End If
        End If


        PPD.Document = PD
            changelongpaper()
            PD.Print()  'Direct Print

    End Sub
    Private Sub BtnPPreview_Click(sender As Object, e As EventArgs) Handles BtnPPreview.Click
        If CBBPMethod.Text = "CASH" Then
            If txtReceiptNo.Text = "" Or CbbCheckby.Text = "" Or CBBHousekeeping.Text = "" Or TxtCash.Text = "" Then
                Me.Hide()
                MessageBox.Show("Required field(s) or Cash Amount not filled-up!", "Incomplete data!",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Show()
                Exit Sub
            Else
                CashMoney = CDbl(TxtCash.Text)
                changeMoney = CDbl(LblChange.Text)
            End If
        ElseIf CBBPMethod.Text = "GCASH" Then
            If txtReceiptNo.Text = "" Or CbbCheckby.Text = "" Or CBBHousekeeping.Text = "" Or TxtRefNo.Text = "" Then
                Me.Hide()
                Dim result2 As DialogResult = MessageBox.Show("Required field(s) or Reference No. not filled-up!", "Incomplete data!",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Me.Show()
                Exit Sub
            Else
                RefNo = TxtRefNo.Text
            End If
        End If
        PPD.Document = PD
        changelongpaper()
        PPD.StartPosition = FormStartPosition.CenterScreen
        PPD.ShowDialog()
        PPD.BringToFront()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 300, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper) ' dynamic size
        PD.DefaultPageSettings = pagesetup

        'adjust margins
        Dim customMargins As New Margins(0, 0, 0, 0) ' Left, right, top, and bottom margins in hundredths of an inch
        PD.DefaultPageSettings.Margins = customMargins

        If PD.PrintController.IsPreview = False Then
            Dim result As DialogResult = MessageBox.Show("Are you sure to check-out Room No. " &
                                                         CurrentRoomNumber & "?", "Check-out Confirmation",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                finalizeTransaction() ' confirm transaction and print receipt
            Else
                e.Cancel = True ' cancel printing
            End If
        End If
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        ' variables for receipt layout
        ' font styles
        Dim f6b As New Font("Calibri", 6, FontStyle.Bold)
        Dim F7 As New Font("Calibri", 7, FontStyle.Regular)
        Dim f8 As New Font("Calibri", 9, FontStyle.Regular)
        Dim f8bb As New Font("Calibri", 8, FontStyle.Bold)
        Dim f8B As New Font("Calibri", 9, FontStyle.Bold)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)
        Dim F16 As New Font("Calibri", 16, FontStyle.Bold)

        ' margins
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        'lining
        Dim line As String = "********************************************"

        ' RECEIPT CONTENT

        'range from top
        'logo
        ' Dim logoImage As Image = My.Resources.ResourceManager.GetObject("logo")
        ' e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - 150) / 2), 5, 150, 150)
        'e.Graphics.DrawImage(logoImage, 0, 250, 150, 50)
        'e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Width - logoImage.Width) / 2), CInt((e.PageBounds.Height - logoImage.Height) / 2), logoImage.Width, logoImage.Height)

        'Receipt Header
        e.Graphics.DrawString("HOTEL 101", F16, Brushes.Black, centermargin, 0, center)
        e.Graphics.DrawString("Brgy. Domoit, Lucena City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel 7123-123", f10, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("CHECK-OUT", f10b, Brushes.Black, centermargin, 90, center)
        e.Graphics.DrawString("ROOM INFORMATION", f8B, Brushes.Black, centermargin, 105, center)

        e.Graphics.DrawString("INVOICE NO. :", f8, Brushes.Black, leftmargin, 135)
        e.Graphics.DrawString(txtReceiptNo.Text, f8, Brushes.Black, rightmargin, 135, right)

        e.Graphics.DrawString("ROOM NO. :", f8, Brushes.Black, leftmargin, 150)
        e.Graphics.DrawString(CurrentRoomNumber, f8, Brushes.Black, rightmargin, 150, right)

        e.Graphics.DrawString("CHECK-IN :", f8, Brushes.Black, leftmargin, 165)
        e.Graphics.DrawString(CIT, f8, Brushes.Black, rightmargin, 165, right)

        e.Graphics.DrawString("CHECK-OUT :", f8, Brushes.Black, leftmargin, 180)
        e.Graphics.DrawString(COT, f8, Brushes.Black, rightmargin, 180, right)

        e.Graphics.DrawString("ACCOMODATION :", f8, Brushes.Black, leftmargin, 195)
        If Addon = "None" Then
            e.Graphics.DrawString(HDuration & " Hours", f8, Brushes.Black, rightmargin, 195, right)
        Else
            e.Graphics.DrawString(HDuration & " Hours " & Addon, f8, Brushes.Black, rightmargin, 195, right)
        End If

        e.Graphics.DrawString("ACCOMODATION FEE :", f8, Brushes.Black, leftmargin, 210)
        e.Graphics.DrawString(RentAmount.ToString("0.00"), f8, Brushes.Black, rightmargin, 210, right)

        e.Graphics.DrawString("CATEGORY :", f8, Brushes.Black, leftmargin, 225)
        e.Graphics.DrawString(accomodation, f8, Brushes.Black, rightmargin, 225, right)

        e.Graphics.DrawString("EXCESS HOUR :", f8, Brushes.Black, leftmargin, 240)
        e.Graphics.DrawString(EHours, f8, Brushes.Black, rightmargin, 240, right)

        e.Graphics.DrawString("EXCESS HOUR FEE :", f8, Brushes.Black, leftmargin, 255)
        e.Graphics.DrawString(EAmount.ToString("0.00"), f8, Brushes.Black, rightmargin, 255, right)

        e.Graphics.DrawString("PROMO TYPE :", f8, Brushes.Black, leftmargin, 270)
        e.Graphics.DrawString(PType, f8, Brushes.Black, rightmargin, 270, right)

        e.Graphics.DrawString("PROMO DISCOUNT :", f8, Brushes.Black, leftmargin, 285)
        e.Graphics.DrawString(PPer & "%", f8, Brushes.Black, 185, 285, right)
        e.Graphics.DrawString(PAmount.ToString("0.00"), f8, Brushes.Black, rightmargin, 285, right)

        e.Graphics.DrawString("EXTRA GUEST :", f8, Brushes.Black, leftmargin, 300)
        e.Graphics.DrawString(EGQTY, f8, Brushes.Black, rightmargin, 300, right)

        e.Graphics.DrawString("EXTRA GUEST FEE :", f8, Brushes.Black, leftmargin, 315)
        e.Graphics.DrawString(EGAmount.ToString("0.00"), f8, Brushes.Black, rightmargin, 315, right)

        e.Graphics.DrawString("TOTAL ROOM RENT :", f8B, Brushes.Black, leftmargin, 330)
        e.Graphics.DrawString(TotalRoomRent.ToString("0.00"), f8B, Brushes.Black, rightmargin, 330, right)


        Dim ordertotal As Double
        Dim heightOfOrder As Integer 'DGV Position

        If myDataTable.Rows.Count <= 0 Then
            heightOfOrder += 15
            e.Graphics.DrawString("NO ORDERS", f10b, Brushes.Black, centermargin, 355, center)
        Else
            e.Graphics.DrawString("ORDERS", f10b, Brushes.Black, centermargin, 355, center)
            e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 370, center) 'first LINE
            heightOfOrder += 10
            ' Assuming you have a DataGridView named dgvItems
            Dim categories As New List(Of String)()

            ' Iterate through the rows of the DataGridView
            For Each row1 As DataRow In myDataTable.Rows

                Dim category1 As String = row1(5).ToString() ' Use index 2 for the third column

                ' Check if the category is not already in the list before adding it
                If Not categories.Contains(category1) Then
                    categories.Add(category1)
                End If

            Next

            ' Convert the List(Of String) to a String array
            Dim categoriesToPrint() As String = categories.ToArray()

            For Each categoryToPrint As String In categoriesToPrint
                ' Print the category header
                Dim categoryHeader As String = categoryToPrint
                heightOfOrder += 15
                e.Graphics.DrawString(categoryHeader, f6b, Brushes.Black, centermargin, 355 + heightOfOrder, center)

                ' Print the detail header
                heightOfOrder += 10
                e.Graphics.DrawString("ITEM", f8, Brushes.Black, leftmargin, 355 + heightOfOrder)
                e.Graphics.DrawString("QTY", f8, Brushes.Black, 160, 355 + heightOfOrder, right)
                e.Graphics.DrawString("PRICE", f8, Brushes.Black, 195, 355 + heightOfOrder, right)
                e.Graphics.DrawString("AMOUNT", f8, Brushes.Black, rightmargin, 355 + heightOfOrder, right)

                For row As Integer = 0 To myDataTable.Rows.Count - 1
                    Dim category As String = myDataTable.Rows(row).Item(5).ToString() ' Assuming category is in column 5
                    If category = categoryToPrint Then
                        heightOfOrder += 10
                        e.Graphics.DrawString(myDataTable.Rows(row).Item(1).ToString, F7, Brushes.Black, leftmargin, 360 + heightOfOrder)
                        e.Graphics.DrawString(myDataTable.Rows(row).Item(2).ToString, F7, Brushes.Black, 160, 360 + heightOfOrder, right)
                        e.Graphics.DrawString(myDataTable.Rows(row).Item(3).ToString, F7, Brushes.Black, 195, 360 + heightOfOrder, right)
                        e.Graphics.DrawString(myDataTable.Rows(row).Item(4).ToString, F7, Brushes.Black, rightmargin, 360 + heightOfOrder, right)
                        ordertotal += myDataTable.Rows(row).Item(4)
                    End If
                Next

                ' Add the line separator after each category
                heightOfOrder += 10
                e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 360 + heightOfOrder, center)
            Next

            heightOfOrder += 15
            e.Graphics.DrawString("TOTAL ORDERED :", f8B, Brushes.Black, leftmargin, 355 + heightOfOrder)
            e.Graphics.DrawString(ordertotal.ToString("0.00"), f8B, Brushes.Black, rightmargin, 355 + heightOfOrder, right)
        End If

        Dim height2 As Integer
        height2 = 360 + heightOfOrder
        ' sumprice() 'call sub


        e.Graphics.DrawString("GUEST TYPE :", f8, Brushes.Black, leftmargin, 15 + height2)
        e.Graphics.DrawString(gType, f8, Brushes.Black, rightmargin, 15 + height2, right)

        e.Graphics.DrawString("DISCOUNT :", f8, Brushes.Black, leftmargin, 30 + height2)
        e.Graphics.DrawString(gPer & "%", f8, Brushes.Black, 185, 30 + height2, right)
        e.Graphics.DrawString(gDis.ToString("0.00"), f8, Brushes.Black, rightmargin, 30 + height2, right)

        e.Graphics.DrawString("SENIOR ID :", f8, Brushes.Black, leftmargin, 45 + height2)
        e.Graphics.DrawString(SID, f8, Brushes.Black, rightmargin, 45 + height2, right)

        e.Graphics.DrawString("SENIOR SIGNATURE :", f8, Brushes.Black, leftmargin, 60 + height2)
        e.Graphics.DrawString("____________________", f8, Brushes.Black, rightmargin, 60 + height2, right)

        e.Graphics.DrawString("OTHER DISCOUNT :", f8, Brushes.Black, leftmargin, 80 + height2)
        e.Graphics.DrawString(OPer & "%", f8, Brushes.Black, 185, 80 + height2, right)
        e.Graphics.DrawString(OAmount.ToString("0.00"), f8, Brushes.Black, rightmargin, 80 + height2, right)

        Dim ODeductComp As Double
        Dim vatComp As Double
        Dim vatSalesComp As Double
        Dim GtotalComp As Double

        If TxtODeduction.Text = "" Then
            ODeductComp = 0
            vatComp = vat
            vatSalesComp = vatSales
            GtotalComp = GtotalStatic
        Else
            ODeductComp = Val(TxtODeduction.Text)
            vatComp = GtotalStatic - ODeductComp * vatPer
            vatSalesComp = GtotalStatic - vatComp
            GtotalComp = GtotalStatic - ODeductComp
        End If


        e.Graphics.DrawString("OTHER DEDUCTION :", f8, Brushes.Black, leftmargin, 95 + height2)
        e.Graphics.DrawString(ODeductComp.ToString("0.00"), f8, Brushes.Black, rightmargin, 95 + height2, right)

        e.Graphics.DrawString("VAT SALES :", f8, Brushes.Black, leftmargin, 115 + height2)
        e.Graphics.DrawString(vatSalesComp.ToString("0.00"), f8, Brushes.Black, rightmargin, 115 + height2, right)

        e.Graphics.DrawString("VAT :", f8, Brushes.Black, leftmargin, 130 + height2)
        e.Graphics.DrawString(vatComp.ToString("0.00"), f8, Brushes.Black, rightmargin, 130 + height2, right)

        e.Graphics.DrawString("GRAND TOTAL :", f10b, Brushes.Black, leftmargin, 150 + height2)
        e.Graphics.DrawString(GtotalComp.ToString("0.00"), f10b, Brushes.Black, rightmargin, 150 + height2, right)

        If CBBPMethod.Text = "CASH" Then
            e.Graphics.DrawString("MODE OF PAYMENT :", f8, Brushes.Black, leftmargin, 170 + height2)
            e.Graphics.DrawString("CASH", f8, Brushes.Black, rightmargin, 170 + height2, right)

            e.Graphics.DrawString("CASH :", f8, Brushes.Black, leftmargin, 185 + height2)
            e.Graphics.DrawString(CashMoney.ToString("0.00"), f8, Brushes.Black, rightmargin, 185 + height2, right)

            e.Graphics.DrawString("CHANGE :", f8, Brushes.Black, leftmargin, 200 + height2)
            e.Graphics.DrawString(changeMoney.ToString("0.00"), f8, Brushes.Black, rightmargin, 200 + height2, right)
        ElseIf CBBPMethod.Text = "GCASH" Then
            e.Graphics.DrawString("MODE OF PAYMENT :", f8, Brushes.Black, leftmargin, 170 + height2)
            e.Graphics.DrawString("GCASH", f8, Brushes.Black, rightmargin, 170 + height2, right)

            e.Graphics.DrawString("REFERENCE NO :", f8, Brushes.Black, leftmargin, 185 + height2)
            e.Graphics.DrawString(TxtRefNo.Text, f8, Brushes.Black, rightmargin, 185 + height2, right)
        End If

        e.Graphics.DrawString("DATE/TIME :", f8, Brushes.Black, leftmargin, 230 + height2)
        e.Graphics.DrawString(DateTime.Now.ToString, f8, Brushes.Black, rightmargin, 230 + height2, right)

        e.Graphics.DrawString("TRANSACT BY :", f8, Brushes.Black, leftmargin, 245 + height2)
        e.Graphics.DrawString(currentUserName, f8, Brushes.Black, rightmargin, 245 + height2, right)

        e.Graphics.DrawString("CHECK BY :", f8, Brushes.Black, leftmargin, 260 + height2)
        e.Graphics.DrawString(CbbCheckby.Text, f8, Brushes.Black, rightmargin, 260 + height2, right)

        e.Graphics.DrawString("Thank You! Please come again!", f10, Brushes.Black, centermargin, 315 + height2, center)
        e.Graphics.DrawString("Please ask for official receipt", f10, Brushes.Black, centermargin, 330 + height2, center)


        'Barcode
        ' Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        ' Try
        '     Dim barcodeimage As Image
        '     barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, "DRW8555RE"))
        '     e.Graphics.DrawImage(barcodeimage, CInt((e.PageBounds.Width - 150) / 2), 35 + height2, 150, 35)
        ' Catch ex As Exception
        '     MsgBox(ex.Message)
        ' End Try
        ' e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 70 + height2, center)
        ' e.Graphics.DrawString("~ Nosware Store ~", f10, Brushes.Black, centermargin, 85 + height2, center)
    End Sub
    Sub LoadData()

        Me.TopMost = True
        AssignValidation(Me.TxtCash, ValidationType.Only_Numbers)
        AssignValidation(Me.TxtRefNo, ValidationType.Only_Numbers)
        AssignValidation(Me.TxtODeduction, ValidationType.Only_Numbers)
        AssignValidation(Me.txtReceiptNo, ValidationType.Only_Numbers)
        'AssignValidation(Me.TxtCash, ValidationType.Only_Characters)
        'AssignValidation(Me.TextBox3, ValidationType.No_Blank)
        'AssignValidation(Me.TextBox4, ValidationType.Only_Email)

        'controls default properties
        PanelGcash.Visible = False
        PanelCash.Visible = False


        CBBPMethod.Items.Add("CASH")
        CBBPMethod.Items.Add("GCASH")

        CBBPMethod.Text = "CASH"

        LblCurrentUser.Text = currentUserName


        'Fill Check by combo box
        Try
            OpenCon()
            Using cmdFillCheckby As New MySqlCommand("SELECT name FROM tbl_user", Con)
                Dim CheckbyAdapter As New MySqlDataAdapter
                Dim Checkbytable As New DataTable
                CheckbyAdapter.SelectCommand = cmdFillCheckby
                Checkbytable.Clear()
                CheckbyAdapter.Fill(Checkbytable)
                For i = 0 To Checkbytable.Rows.Count - 1
                    CbbCheckby.Items.Add(Checkbytable.Rows(i).Item(0).ToString)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving employee list for check by error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'Fill Check by combo box
        Try
            OpenCon()
            Using cmdFillHKeeping As New MySqlCommand("SELECT name FROM tbl_user", Con)
                Dim HKeepingAdapter As New MySqlDataAdapter
                Dim HKeepingtable As New DataTable
                HKeepingAdapter.SelectCommand = cmdFillHKeeping
                HKeepingtable.Clear()
                HKeepingAdapter.Fill(HKeepingtable)
                For i = 0 To HKeepingtable.Rows.Count - 1
                    CBBHousekeeping.Items.Add(HKeepingtable.Rows(i).Item(0).ToString)
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Retrieving employee list for housekeeping error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        'adding data to value holders
        Try
            OpenCon()
            Using cmdLoadTransaction As New MySqlCommand("SELECT * FROM tbl_transaction_summary WHERE
            transaction_no=@currenttno", Con)
                cmdLoadTransaction.Parameters.AddWithValue("currenttno", currentTransactionNo)
                Dim LTReader As MySqlDataReader = cmdLoadTransaction.ExecuteReader
                With LTReader
                    .Read()
                    receiptNo = .Item("receipt_no")
                    roomNo = .Item("room_no")
                    gType = .Item("guest_type")
                    gPer = .Item("guest_percentage")
                    gDis = .Item("guest_discount")
                    accomodation = .Item("accomodation")
                    CIT = .Item("check_in")
                    COT = .Item("check_out")
                    HDuration = .Item("hours_duration")
                    RentAmount = .Item("room_rent_amount")
                    Addon = .Item("addon")
                    EHours = .Item("excess_hours")
                    ERate = .Item("excess_rateperhour")
                    EAmount = .Item("excess_amount")
                    PType = .Item("promo_type")
                    PPer = .Item("promo_percentage")
                    PAmount = .Item("promo_discount_amount")
                    OPer = .Item("other_discount_percentage")
                    OAmount = .Item("other_discount_amount")
                    GCount = .Item("guest_count")
                    EGQTY = .Item("extra_guest_qty")
                    EGRate = .Item("extra_guest_perheadrate")
                    EGAmount = .Item("extra_guest_fee")
                    TotalOrder = .Item("total_order")
                    TotalRoomRent = .Item("total_room_rent")
                    SID = .Item("senior_id")
                    OtherDeduction = .Item("other_deduction")
                    vatPer = .Item("vat_percentage") / 100
                    vatSales = .Item("vat_sales")
                    vat = .Item("vat")
                    PTotal = .Item("partial_total")
                    GTotal = .Item("grand_total")
                    GtotalStatic = .Item("grand_total")
                    TBy = .Item("transact_by")
                    CBy = .Item("checked_by")
                    HBy = .Item("housekeeping")
                    comment = .Item("comment")
                    TStatus = .Item("transaction_status")
                    .Close()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on loading check-out summary. " & ex.Message, "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        LblTransactionNo.Text = currentTransactionNo
        LblCurrentUser.Text = currentUserName
        LblGTotal.Text = GTotal.ToString("0.00")
        Dim coll As Integer = FrmTransactGuest.DGTransact.RowCount
        Label16.Text = coll
    End Sub
    Private Sub FrmCheckOut_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SuspendLayout()
        LoadData()
        ResumeLayout()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Dispose()
        FrmBlurEffect.Dispose()
    End Sub

    Private Sub CBBPMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBPMethod.SelectedIndexChanged
        If CBBPMethod.Text = "CASH" Then
            PanelCash.Visible = True
            PanelGcash.Visible = False
            TxtCash.Focus()
            TxtRefNo.Text = ""
        ElseIf CBBPMethod.Text = "GCASH" Then
            PanelCash.Visible = False
            PanelGcash.Visible = True
            TxtRefNo.Focus()
            TxtCash.Text = ""
        End If
    End Sub

    Private Sub TxtCash_TextChanged(sender As Object, e As EventArgs) Handles TxtCash.TextChanged

        If TxtCash.Text = "" Then
            LblChange.Text = "0.00"
            Exit Sub
        Else
            Try
                Dim changeAmount As Double = CDbl(TxtCash.Text) - GTotal
                LblChange.Text = changeAmount.ToString("0.00")
                CashMoney = CDbl(TxtCash.Text)
                changeMoney = CDbl(LblChange.Text)
            Catch
            End Try
        End If

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtCash.Text = TxtCash.Text & 1
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtCash.Text = TxtCash.Text & 2
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtCash.Text = TxtCash.Text & 3
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtCash.Text = TxtCash.Text & 4
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtCash.Text = TxtCash.Text & 5
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtCash.Text = TxtCash.Text & 6
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtCash.Text = TxtCash.Text & 7
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtCash.Text = TxtCash.Text & 8
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtCash.Text = TxtCash.Text & 9
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TxtCash.Text = TxtCash.Text & 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtCash.Text = TxtCash.Text & "."
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtCash.Text = ""
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Dispose()
        FrmBlurEffect.Dispose()
    End Sub

    Private Sub FrmCheckOut_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle the key down event here
        Select Case e.KeyCode
            Case Keys.F1
                BtnCancel.PerformClick()
            Case Keys.F2
                BtnPPreview.PerformClick()
            Case Keys.F3
                BtnPrint.PerformClick()
        End Select
    End Sub
End Class