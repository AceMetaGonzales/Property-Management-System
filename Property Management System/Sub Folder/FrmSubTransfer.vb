Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class FrmSubTransfer
    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.ShowInTaskbar = False ' This line is important to hide it from the taskbar.

    End Sub

    Dim roomDestination As String
    Dim inputChecked As String

    Private Sub FrmSubTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True

        'fill list of room available
        Try
            OpenCon()
            Using FillAvailableRoom As New MySqlCommand("SELECT room_id FROM tbl_room_status WHERE available=1", Con)
                Dim FARReader As MySqlDataReader
                FARReader = FillAvailableRoom.ExecuteReader
                ClbAvailableRoom.Items.Clear()
                While FARReader.Read
                    ClbAvailableRoom.Items.Add("ROOM " & FARReader.GetString(0))
                End While
                FARReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Filling available room error. " & ex.Message,
                            "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        ClbAvailableRoom.SelectionMode = SelectionMode.One
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        FrmBlurEffect.TopMost = False
        If ClbAvailableRoom.CheckedItems.Count = 1 And txtReason.Text <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to transfer Room No. " & CurrentRoomNumber &
                                                " booking to Room No. " & roomDestination & "?", "Confirm Transfer",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'Try
                OpenCon()
                Using cmdAvailableRoom As New MySqlCommand("SELECT * FROM tbl_room_status
                    WHERE room_id=@roomid", Con)
                    cmdAvailableRoom.Parameters.AddWithValue("roomid", CurrentRoomNumber)
                    Dim ARreader As MySqlDataReader
                    ARreader = cmdAvailableRoom.ExecuteReader
                    If ARreader.Read Then
                        'Retrieve data from current room
                        Dim Tno As String = ARreader("transaction_no").ToString
                        Dim Gname As String = ARreader("guest_name").ToString
                        Dim Cno As String = ARreader("contact_no").ToString
                        Dim Vtype As String = ARreader("vehicle_type").ToString
                        Dim Pno As String = ARreader("plate_no").ToString
                        Dim GType As String = ARreader("guest_type").ToString
                        Dim GPer As String = ARreader("guest_disper").ToString
                        Dim GDis As String = ARreader("guest_disamount").ToString
                        Dim GCount As String = ARreader("guest_count").ToString
                        Dim Sid As String = ARreader("senior_id").ToString
                        Dim Address As String = ARreader("address").ToString
                        Dim HCode As String = ARreader("hours_code").ToString
                        Dim Addon As String = ARreader("addon").ToString
                        Dim CIT As String = ARreader("check_in_time").ToString
                        Dim DHours As String = ARreader("duration_hours").ToString
                        Dim COT As String = ARreader("check_out_time").ToString
                        Dim PType As String = ARreader("promo_type").ToString
                        Dim PPer As String = ARreader("promo_percentage").ToString
                        Dim PAmount As String = ARreader("promo_amount").ToString
                        Dim ODPer As String = ARreader("other_discountper").ToString
                        Dim ODAmount As String = ARreader("other_disamount").ToString
                        Dim Comment As String = ARreader("comment").ToString
                        Dim isOccupied As Boolean = Convert.ToBoolean(ARreader("occupied"))
                        Dim isAvailable As Boolean = Convert.ToBoolean(ARreader("available"))
                        Dim isHousekeeping As Boolean = Convert.ToBoolean(ARreader("housekeeping"))
                        Dim isReserved As Boolean = Convert.ToBoolean(ARreader("reserved"))
                        Dim isMaintenance As Boolean = Convert.ToBoolean(ARreader("maintenance"))
                        Dim isDeactivated As Boolean = Convert.ToBoolean(ARreader("deactivated"))
                        ARreader.Close()

                        'update the destination row with retrieved data
                        Using cmdTransaferData As New MySqlCommand("UPDATE tbl_room_status SET transaction_no=@Tno,
                            guest_name=@gname,contact_no=@cno,vehicle_type=@vtype,plate_no=@pno,guest_type=@gtype,
                            guest_disper=@gper,guest_disamount=@gdis,guest_count=@gcount,senior_id=@sid,address=@address,
                            hours_code=@hcode,addon=@addon,check_in_time=@cit,duration_hours=@dhours,check_out_time=@cot,
                            promo_type=@ptype,promo_percentage=@pper,promo_amount=@pamount,other_discountper=@odper,
                            other_disamount=@odamount,comment=@comment,occupied=@isoccupied,available=@isavailable,
                            housekeeping=@ishousekeeping,reserved=@isreserved,maintenance=@ismaintenance,
                            deactivated=@isdeactivated WHERE room_id=@rselected", Con)
                            cmdTransaferData.Parameters.AddWithValue("rselected", roomDestination)
                            cmdTransaferData.Parameters.AddWithValue("tno", Tno)
                            cmdTransaferData.Parameters.AddWithValue("gname", Gname)
                            cmdTransaferData.Parameters.AddWithValue("cno", Cno)
                            cmdTransaferData.Parameters.AddWithValue("vtype", Vtype)
                            cmdTransaferData.Parameters.AddWithValue("pno", Pno)
                            cmdTransaferData.Parameters.AddWithValue("gtype", GType)
                            cmdTransaferData.Parameters.AddWithValue("gper", GPer)
                            cmdTransaferData.Parameters.AddWithValue("gdis", GDis)
                            cmdTransaferData.Parameters.AddWithValue("gcount", GCount)
                            cmdTransaferData.Parameters.AddWithValue("sid", Sid)
                            cmdTransaferData.Parameters.AddWithValue("address", Address)
                            cmdTransaferData.Parameters.AddWithValue("hcode", HCode)
                            cmdTransaferData.Parameters.AddWithValue("addon", Addon)
                            cmdTransaferData.Parameters.AddWithValue("cit", CIT)
                            cmdTransaferData.Parameters.AddWithValue("dhours", DHours)
                            cmdTransaferData.Parameters.AddWithValue("cot", COT)
                            cmdTransaferData.Parameters.AddWithValue("ptype", PType)
                            cmdTransaferData.Parameters.AddWithValue("pper", PPer)
                            cmdTransaferData.Parameters.AddWithValue("pamount", PAmount)
                            cmdTransaferData.Parameters.AddWithValue("odper", ODPer)
                            cmdTransaferData.Parameters.AddWithValue("odamount", ODAmount)
                            cmdTransaferData.Parameters.AddWithValue("comment", Comment)
                            cmdTransaferData.Parameters.AddWithValue("isoccupied", isOccupied)
                            cmdTransaferData.Parameters.AddWithValue("isavailable", isAvailable)
                            cmdTransaferData.Parameters.AddWithValue("ishousekeeping", isHousekeeping)
                            cmdTransaferData.Parameters.AddWithValue("isreserved", isReserved)
                            cmdTransaferData.Parameters.AddWithValue("ismaintenance", isMaintenance)
                            cmdTransaferData.Parameters.AddWithValue("isdeactivated", isDeactivated)
                            cmdTransaferData.ExecuteNonQuery()
                        End Using

                        'update the current room to available
                        Using cmdDeleteData As New MySqlCommand("UPDATE tbl_room_status SET transaction_no=@Tno,
                             guest_name=@gname,contact_no=@cno,vehicle_type=@vtype,plate_no=@pno,guest_type=@gtype,
                             guest_disper=@gper,guest_disamount=@gdis,guest_count=@gcount,senior_id=@sid,address=@address,
                             hours_code=@hcode,addon=@addon,check_in_time=@cit,duration_hours=@dhours,check_out_time=@cot,
                             promo_type=@ptype,promo_percentage=@pper,promo_amount=@pamount,other_discountper=@odper,
                             other_disamount=@odamount,comment=@comment,occupied=@isoccupied,available=@isavailable,
                             housekeeping=@ishousekeeping,reserved=@isreserved,maintenance=@ismaintenance,
                             deactivated=@isdeactivated WHERE room_id=@currentroom", Con)
                            cmdDeleteData.Parameters.AddWithValue("tno", "")
                            cmdDeleteData.Parameters.AddWithValue("gname", "")
                            cmdDeleteData.Parameters.AddWithValue("cno", "")
                            cmdDeleteData.Parameters.AddWithValue("vtype", "")
                            cmdDeleteData.Parameters.AddWithValue("pno", "")
                            cmdDeleteData.Parameters.AddWithValue("gtype", "")
                            cmdDeleteData.Parameters.AddWithValue("gper", 0)
                            cmdDeleteData.Parameters.AddWithValue("gdis", 0.00)
                            cmdDeleteData.Parameters.AddWithValue("gcount", 0)
                            cmdDeleteData.Parameters.AddWithValue("sid", "")
                            cmdDeleteData.Parameters.AddWithValue("address", "")
                            cmdDeleteData.Parameters.AddWithValue("hcode", "")
                            cmdDeleteData.Parameters.AddWithValue("addon", "")
                            cmdDeleteData.Parameters.AddWithValue("cit", "")
                            cmdDeleteData.Parameters.AddWithValue("dhours", 0)
                            cmdDeleteData.Parameters.AddWithValue("cot", "")
                            cmdDeleteData.Parameters.AddWithValue("ptype", "")
                            cmdDeleteData.Parameters.AddWithValue("pper", 0)
                            cmdDeleteData.Parameters.AddWithValue("pamount", 0.00)
                            cmdDeleteData.Parameters.AddWithValue("odper", 0)
                            cmdDeleteData.Parameters.AddWithValue("odamount", 0.00)
                            cmdDeleteData.Parameters.AddWithValue("comment", "")
                            cmdDeleteData.Parameters.AddWithValue("isoccupied", 0)
                            cmdDeleteData.Parameters.AddWithValue("isavailable", 1)
                            cmdDeleteData.Parameters.AddWithValue("ishousekeeping", 0)
                            cmdDeleteData.Parameters.AddWithValue("isreserved", 0)
                            cmdDeleteData.Parameters.AddWithValue("ismaintenance", 0)
                            cmdDeleteData.Parameters.AddWithValue("isdeactivated", 0)
                            cmdDeleteData.Parameters.AddWithValue("currentroom", CurrentRoomNumber)
                            cmdDeleteData.ExecuteNonQuery()
                        End Using

                    End If
                End Using
                Con.Close()
                ' Catch ex As Exception
                '     MessageBox.Show("Transferring room error. " & ex.Message, "Error!",
                '                 MessageBoxButtons.OK, MessageBoxIcon.Error)
                '     Exit Sub
                ' Finally
                '     Con.Close()
                ' End Try

                'add transaction to system log

                OpenCon()
                Using addToTransLog As New MySqlCommand("INSERT INTO tbl_log (logdetails,logtype,logreason,logtime,loguser,
                    logposition) VALUES (@ldetails,@ltype,@lreason,@ltime,@luser,@lposition)", Con)
                    addToTransLog.Parameters.AddWithValue("ldetails", currentUserName & " done a room transfer.")
                    addToTransLog.Parameters.AddWithValue("ltype", "Room Transfer")
                    addToTransLog.Parameters.AddWithValue("lreason", txtReason.Text)
                    addToTransLog.Parameters.AddWithValue("ltime", DateTime.Now.ToString)
                    addToTransLog.Parameters.AddWithValue("luser", currentUserName)
                    addToTransLog.Parameters.AddWithValue("lposition", currentUserPosition)
                    If addToTransLog.ExecuteNonQuery() Then
                        Con.Close()
                        Me.Dispose()
                        MessageBox.Show("Room No.: " & CurrentRoomNumber &
                                        " successfully transfered to Room No.: " & roomDestination,
                                        "Room Transfer Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        OpenChildForm(New FrmRooms)
                    Else
                        MessageBox.Show("Log not save!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
                FrmBlurEffect.Hide()
            ElseIf result = DialogResult.No Then
                Exit Sub
            End If
        ElseIf ClbAvailableRoom.CheckedItems.Count = 0 Or txtReason.Text = "" Then
            MessageBox.Show("Check if Reason to Transfer is filled-up and if you already choose a room to transfer.",
                            "No room to transfer", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    Private Sub ClbAvailableRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbAvailableRoom.SelectedIndexChanged
        Dim regex As New Regex("\d+")
        Dim match As Match


        'get the checked value
        If ClbAvailableRoom.CheckedItems.Count = 1 Then
            inputChecked = ClbAvailableRoom.CheckedItems(0).ToString

            'trim strign character of checked value
            match = regex.Match(inputChecked)
            If match.Success Then
                roomDestination = match.Value
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ClbAvailableRoom_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ClbAvailableRoom.ItemCheck
        'check only one in the check list box
        For i As Integer = 0 To ClbAvailableRoom.Items.Count - 1
            If i <> e.Index Then
                ClbAvailableRoom.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Dispose()
        FrmBlurEffect.Hide()
        frmMain.Enabled = True
    End Sub

    Private Sub PanelTitlebar_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitlebar.Paint

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
End Class