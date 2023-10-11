Imports MySql.Data.MySqlClient
Public Class FrmSubHousekeeping
    Dim curHousekeeping As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.ShowInTaskbar = False ' This line is important to hide it from the taskbar.

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

    Private Sub FrmSubHousekeeping_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
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
                    curHousekeeping = RCSReader("assigned_housekeep").ToString
                    If isOccupied Then
                        LblStatus.Text = "OCCUPIED"
                    ElseIf isAvailable Then
                        LblStatus.Text = "AVAILABLE"
                    ElseIf isMaintenance Then
                        LblStatus.Text = "MAINTENANCE"
                    ElseIf isHousekeeping Then
                        LblStatus.Text = "HOUSEKEEPING"
                        LblDes.Text = curHousekeeping & " currently assigned to clean this room." & vbCrLf &
                        "If cleaning was done, click CONFIRM to change room status to AVAILABLE."
                    ElseIf isReserved Then
                        LblStatus.Text = "RESERVED"
                    ElseIf isDeactivated Then
                        LblStatus.Text = "DEACTIVATED"
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
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Dispose()
        FrmBlurEffect.Dispose()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        OpenCon()
        Using CStatus As New MySqlCommand("UPDATE tbl_room_status SET occupied=@isoccupied,available=@isavailable,
        housekeeping=@isHousekeeping,reserved=@isReserved, maintenance=@isMaintenance,deactivated=@isDeactivated,assigned_housekeep=@ah
        WHERE room_id=@roomid", Con)
            Dim isOccupied As Boolean = False
            Dim isAvailable As Boolean = True
            Dim isHousekeeping As Boolean = False
            Dim isReserved As Boolean = False
            Dim isMaintenance As Boolean = False
            Dim isDeactivated As Boolean = False
            CStatus.Parameters.AddWithValue("roomid", CurrentRoomNumber)
            CStatus.Parameters.AddWithValue("isoccupied", isOccupied)
            CStatus.Parameters.AddWithValue("isavailable", isAvailable)
            CStatus.Parameters.AddWithValue("ishousekeeping", isHousekeeping)
            CStatus.Parameters.AddWithValue("isreserved", isReserved)
            CStatus.Parameters.AddWithValue("ismaintenance", isMaintenance)
            CStatus.Parameters.AddWithValue("isdeactivated", isDeactivated)
            CStatus.Parameters.AddWithValue("ah", "")
            CStatus.ExecuteNonQuery()
        End Using
        Con.Close()
        CountRoomStatus()
        Me.Hide()
        frmMain.BtnRooms.PerformClick()
        FrmBlurEffect.Dispose()
    End Sub


End Class