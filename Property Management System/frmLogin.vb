Imports MySql.Data.MySqlClient


Public Class frmLogin
    Dim IDchange As Boolean
    Dim PWchange As Boolean
    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const HT_CAPTION As Integer = &H2

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)

        Me.Capture = False
        Dim msg As Message =
            Message.Create(Me.Handle, WM_NCLBUTTONDOWN,
                    New IntPtr(HT_CAPTION), IntPtr.Zero)
        Me.DefWndProc(msg)

    End Sub


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()
        txtID.Text = "USERNAME"
        TxtPW.Text = "PASSWORD"
        txtID.ForeColor = Color.DimGray
        TxtPW.ForeColor = Color.DimGray
        IDchange = True
        PWchange = True
        ResumeLayout()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim result As DialogResult
        'main function
        If IDchange = False And PWchange = False Then
            'for comparing if log in username and password are match
            Try
                OpenCon()
                Using executelogin As New MySqlCommand("select count(*) from tbl_user
                where id='" & txtID.Text & "'AND password='" & TxtPW.Text & "'", Con)
                    Dim Count = Convert.ToInt32(executelogin.ExecuteScalar())

                    If Val(Count) > 0 Then
                        result = MessageBox.Show("Login successful!", "Success",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Invalid Username or Password",
                                        "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtID.Focus()
                        txtID.SelectAll()
                        Exit Sub
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error in retrieving username and password to database. " & ex.Message, "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try

            'put data to current user details public value holders
            If result = DialogResult.OK Then
                Me.Hide()

                Try
                    OpenCon()
                    Using GetUserDetails As New MySqlCommand("SELECT * FROM tbl_user WHERE id='" & txtID.Text & "'", Con)
                        Dim GUDReader As MySqlDataReader
                        GUDReader = GetUserDetails.ExecuteReader
                        If GUDReader.Read Then
                            currentUserId = GUDReader("id").ToString
                            currentUserName = GUDReader("name").ToString
                            currentUserPosition = GUDReader("position").ToString
                        End If
                        GUDReader.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error in retrieving user details. " & ex.Message, "Error!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try

                frmMain.Show()
            End If

        ElseIf IDchange = True And PWchange = False Then
            MsgBox("Invalid Username!")
            txtID.Focus()

        ElseIf IDchange = False And PWchange = True Then
            MsgBox("Invalid Password!")
            TxtPW.Focus()
            TxtPW.SelectAll()
        Else
            MsgBox("Invalid Username and Password!")
            txtID.Focus()
        End If

    End Sub

    'textbox username and password trick
    Private Sub txtID_GotFocus(sender As Object, e As EventArgs) Handles txtID.GotFocus
        If IDchange = True Then
            txtID.Text = ""
            IDchange = False
            txtID.ForeColor = Color.FromArgb(37, 58, 91)
        Else
            txtID.SelectAll()
        End If
    End Sub

    Private Sub txtID_LostFocus(sender As Object, e As EventArgs) Handles txtID.LostFocus
        If txtID.Text = "" Then
            IDchange = True
            txtID.Text = "USERNAME"
            txtID.ForeColor = Color.DimGray
        Else
            IDchange = False
        End If
    End Sub

    Private Sub TxtPW_GotFocus(sender As Object, e As EventArgs) Handles TxtPW.GotFocus
        If PWchange = True Then
            TxtPW.Text = ""
            PWchange = False
            TxtPW.PasswordChar = "●"
            TxtPW.ForeColor = Color.FromArgb(37, 58, 91)
        Else
            TxtPW.SelectAll()
        End If
    End Sub

    Private Sub TxtPW_LostFocus(sender As Object, e As EventArgs) Handles TxtPW.LostFocus
        If TxtPW.Text = "" Then
            PWchange = True
            TxtPW.Text = "PASSWORD"
            TxtPW.PasswordChar = ""
            TxtPW.ForeColor = Color.DimGray
        Else
            PWchange = False
        End If
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        End
        Me.Dispose()
    End Sub

    'Close button hover and click color change
    Private Sub BtnClose_MouseHover(sender As Object, e As EventArgs) Handles BtnClose.MouseHover
        BtnClose.BackColor = Color.FromArgb(216, 196, 182)
        BtnClose.ForeColor = Color.FromArgb(245, 239, 231)
    End Sub

    Private Sub BtnClose_MouseLeave(sender As Object, e As EventArgs) Handles BtnClose.MouseLeave
        BtnClose.BackColor = Color.FromArgb(37, 58, 91)
        BtnClose.ForeColor = Color.White
    End Sub


    'when press enter then call log in regardless where control you focus
    Private Sub btnLogIn_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub TxtPW_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPW.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogIn_Click(sender, e)
        End If
    End Sub

    Private Sub TxtPW_TextChanged(sender As Object, e As EventArgs) Handles TxtPW.TextChanged
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


End Class