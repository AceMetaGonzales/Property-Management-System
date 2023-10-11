Imports MySql.Data.MySqlClient
Public Class FrmRooms
    Private Function FindButtonById(id As String) As Button
        'getting buttons indexes
        Dim buttonName As String = "BtnRoom" & id
        Return Controls.Find(buttonName, True).FirstOrDefault()
    End Function

    Private Sub LoadButtonColorsFromDatabase()
        Try
            OpenCon()
            Using RoomColorsStatus As New MySqlCommand("SELECT * FROM tbl_room_status", Con)
                Dim RColorReader As MySqlDataReader
                RColorReader = RoomColorsStatus.ExecuteReader()
                While RColorReader.Read()
                    Dim buttonId As String = RColorReader("room_id")
                    Dim isOccupied As Boolean = Convert.ToBoolean(RColorReader("occupied"))
                    Dim isAvailable As Boolean = Convert.ToBoolean(RColorReader("available"))
                    Dim isMaintenance As Boolean = Convert.ToBoolean(RColorReader("maintenance"))
                    Dim isHousekeeping As Boolean = Convert.ToBoolean(RColorReader("housekeeping"))
                    Dim isReserved As Boolean = Convert.ToBoolean(RColorReader("reserved"))
                    Dim isDeactivated As Boolean = Convert.ToBoolean(RColorReader("deactivated"))

                    Dim button As Button = FindButtonById(buttonId)
                    If button IsNot Nothing Then
                        If isOccupied Then
                            button.BackColor = RGBColors.colorOccupied
                            button.ForeColor = Color.Black
                        ElseIf isAvailable Then
                            button.BackColor = RGBColors.colorAvailable
                            button.ForeColor = Color.Black
                        ElseIf isMaintenance Then
                            button.BackColor = RGBColors.colorMaintenance
                            button.ForeColor = Color.Black
                        ElseIf isHousekeeping Then
                            button.BackColor = RGBColors.colorHousekeeping
                            button.ForeColor = Color.Black
                        ElseIf isReserved Then
                            button.BackColor = RGBColors.colorReserved
                            button.ForeColor = Color.Black
                        Else
                            button.BackColor = RGBColors.colorDefault ' Set a default color if needed
                            button.ForeColor = Color.Silver
                            button.FlatAppearance.BorderColor = Color.Black
                        End If
                    End If
                End While
                RColorReader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading button states: " & ex.Message)
        End Try
        Con.Close()
    End Sub
    Sub loadStatusform()
        ' Load the specific forms or dialogbox depend on room status
        'Try
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
                    Con.Close()
                    OpenChildForm(New FrmTransactGuest)
                ElseIf isAvailable Then
                    Con.Close()
                    OpenChildForm(New FrmTransactGuest)
                ElseIf isMaintenance Then
                    Exit Sub
                ElseIf isHousekeeping Then
                    Con.Close()
                    FrmBlurEffect.Show()
                    Using FormHousekeeping As New FrmSubHousekeeping()
                        FormHousekeeping.ShowDialog()
                    End Using
                ElseIf isReserved Then
                    Exit Sub
                ElseIf isDeactivated Then
                    Exit Sub
                End If
            End If
            RCSReader.Close()
        End Using
        ' Catch ex As Exception
        ' MessageBox.Show("Retrieving current room status error. " & ex.Message,
        '                     "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' Finally

        '  End Try
    End Sub
    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadButtonColorsFromDatabase()
    End Sub

    Private Sub BtnRoom1_Click(sender As Object, e As EventArgs) Handles BtnRoom1.Click
        CurrentRoomNumber = 1
        loadStatusform()
    End Sub
    Private Sub BtnRoom2_Click(sender As Object, e As EventArgs) Handles BtnRoom2.Click
        CurrentRoomNumber = 2
        loadStatusform()
    End Sub

    Private Sub BtnRoom3_Click(sender As Object, e As EventArgs) Handles BtnRoom3.Click
        CurrentRoomNumber = 3
        loadStatusform()
    End Sub

    Private Sub BtnRoom4_Click(sender As Object, e As EventArgs) Handles BtnRoom4.Click
        CurrentRoomNumber = 4
        loadStatusform()
    End Sub

    Private Sub BtnRoom5_Click(sender As Object, e As EventArgs) Handles BtnRoom5.Click
        CurrentRoomNumber = 5
        loadStatusform()
    End Sub

    Private Sub BtnRoom6_Click(sender As Object, e As EventArgs) Handles BtnRoom6.Click
        CurrentRoomNumber = 6
        loadStatusform()
    End Sub

    Private Sub BtnRoom7_Click(sender As Object, e As EventArgs) Handles BtnRoom7.Click
        CurrentRoomNumber = 7
        loadStatusform()
    End Sub

    Private Sub BtnRoom8_Click(sender As Object, e As EventArgs) Handles BtnRoom8.Click
        CurrentRoomNumber = 8
        loadStatusform()
    End Sub

    Private Sub BtnRoom9_Click(sender As Object, e As EventArgs) Handles BtnRoom9.Click
        CurrentRoomNumber = 9
        loadStatusform()
    End Sub
    Private Sub BtnRoom10_Click(sender As Object, e As EventArgs) Handles BtnRoom10.Click
        CurrentRoomNumber = 10
        loadStatusform()
    End Sub

    Private Sub BtnRoom11_Click(sender As Object, e As EventArgs) Handles BtnRoom11.Click
        CurrentRoomNumber = 11
        loadStatusform()
    End Sub

    Private Sub BtnRoom12_Click(sender As Object, e As EventArgs) Handles BtnRoom12.Click
        CurrentRoomNumber = 12
        loadStatusform()
    End Sub

    Private Sub BtnRoom13_Click(sender As Object, e As EventArgs) Handles BtnRoom13.Click
        CurrentRoomNumber = 13
        loadStatusform()
    End Sub

    Private Sub BtnRoom14_Click(sender As Object, e As EventArgs) Handles BtnRoom14.Click
        CurrentRoomNumber = 14
        loadStatusform()
    End Sub

    Private Sub BtnRoom15_Click(sender As Object, e As EventArgs) Handles BtnRoom15.Click
        CurrentRoomNumber = 15
        loadStatusform()
    End Sub

    Private Sub BtnRoom16_Click(sender As Object, e As EventArgs) Handles BtnRoom16.Click
        CurrentRoomNumber = 16
        loadStatusform()
    End Sub

    Private Sub BtnRoom17_Click(sender As Object, e As EventArgs) Handles BtnRoom17.Click
        CurrentRoomNumber = 17
        loadStatusform()
    End Sub

    Private Sub BtnRoom18_Click(sender As Object, e As EventArgs) Handles BtnRoom18.Click
        CurrentRoomNumber = 18
        loadStatusform()
    End Sub

    Private Sub BtnRoom19_Click(sender As Object, e As EventArgs) Handles BtnRoom19.Click
        CurrentRoomNumber = 19
        loadStatusform()
    End Sub

    Private Sub BtnRoom20_Click(sender As Object, e As EventArgs) Handles BtnRoom20.Click
        CurrentRoomNumber = 20
        loadStatusform()
    End Sub
End Class