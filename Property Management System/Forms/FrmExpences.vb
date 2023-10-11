Imports MySql.Data.MySqlClient

Public Class FrmExpences
    Sub LoadForm()
        Me.BackColor = RGBColors.colorBGLight

        ' fill CBCategory
        CBCategory.Items.Add("Expences")
        CBCategory.Items.Add("Food/Item/Beverage")

        LblDate.Text = DateTime.Today

    End Sub
    Private Sub FrmExpences_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SuspendLayout()
        LoadForm()
        ResumeLayout()
    End Sub

    Private Sub BtnGVoucherNo_Click(sender As Object, e As EventArgs) Handles BtnGVoucherNo.Click
        Try
            OpenCon()
            Using GenTransactionNo As New MySqlCommand("INSERT INTO tbl_billing_voucher
        (voucher_type,status)
         VALUES (@vtype,@status)", Con)

                GenTransactionNo.Parameters.AddWithValue("vtype", "EXPENCES")
                GenTransactionNo.Parameters.AddWithValue("status", "current")
                GenTransactionNo.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error on adding new voucher. " & ex.Message, "Error!", MessageBoxButtons.OK,
                                                         MessageBoxIcon.Exclamation)
        Finally
            Con.Close()
        End Try

        'Display transaction number on LblTransactioNo
        OpenCon()
        Using ShowCurrentVno As New MySqlCommand("SELECT * FROM tbl_billing_voucher
                    ORDER BY voucher_no desc", Con)
            reader = ShowCurrentVno.ExecuteReader
            If reader.Read Then
                Dim VnoValue As String = reader("voucher_no").ToString
                LblVoucherNo.Text = "Voucher No. : " & VnoValue
                currentVoucherNo = VnoValue
            Else
                MessageBox.Show("No data found!")
            End If
            reader.Close()
        End Using
        Con.Close()
        PanelGVoucher.Hide()

    End Sub

    Private Sub BtnPPreview_Click(sender As Object, e As EventArgs) Handles BtnPPreview.Click
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
    End Sub
End Class