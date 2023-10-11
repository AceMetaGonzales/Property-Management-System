Imports MySql.Data.MySqlClient

Public Class FrmSubQTY
    Inherits System.Windows.Forms.Form

    Private isDragging As Boolean = False
    Private mouseOffset As Point
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.ShowInTaskbar = False ' This line is important to hide it from the taskbar.

    End Sub

    ' Drag functions for paneltitlebar
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

    Private Sub FrmSubQTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuspendLayout()

        AssignValidation(Me.txtQTY, ValidationType.Only_Numbers)

        Me.TopLevel = True
        Me.BringToFront()
        LblItemName.Text = qty_particulars
        txtQTY.Text = qty_qty
        If qty_qty = 0 Then
            BtnDelete.Visible = False
            LblQTYTitle.Text = "Add item to order(s)"
        Else
            BtnDelete.Visible = True
            LblQTYTitle.Text = "Update/Delete item to order(s)"
        End If

        ResumeLayout()
    End Sub
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If formUsingQTY = "FrmTransactGuest" Then
            Dim a As Boolean 'for determining messagebox result

            'compare itemcode and transaction number for more accurate adding of orders
            Try
                OpenCon()
                Using CompareItemCode As New MySqlCommand("SELECT COUNT(*) FROM tbl_transaction_order
                WHERE transaction_no='" & qty_tnum & "'AND item_code='" & qty_ic & "'", Con)
                    Dim Count = Convert.ToInt32(CompareItemCode.ExecuteScalar())
                    If Val(Count) > 0 Then
                        a = False ' if false then just add amount and compute the total amount
                    Else
                        a = True ' if true then just add to order to transaction
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try

            If txtQTY.Text = 0 Then
                MessageBox.Show("No item(s) added!", "Value is 0", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Dispose()
            Else
                If a = True Then
                    Try
                        OpenCon()
                        Using FillTransact As New MySqlCommand("INSERT INTO tbl_transaction_order
                (transaction_no,item_code,particulars,qty,price,
                amount,category) VALUES (@tnum,@ic,@particulars,@qty,@price,@amount,@category)", Con)
                            FillTransact.Parameters.AddWithValue("@tnum", qty_tnum)
                            FillTransact.Parameters.AddWithValue("@ic", qty_ic)
                            FillTransact.Parameters.AddWithValue("@particulars", qty_particulars)
                            FillTransact.Parameters.AddWithValue("@qty", Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@price", qty_price)
                            FillTransact.Parameters.AddWithValue("@amount", qty_price * Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@category", qty_category)
                            FillTransact.ExecuteNonQuery()
                        End Using
                        Con.Close()
                        OpenChildForm(New FrmTransactGuest)
                        Me.Dispose()
                    Catch ex As Exception
                        MessageBox.Show("Food/Item failed to add. " & ex.Message, "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf a = False Then
                    Try
                        OpenCon()
                        Using FillTransact As New MySqlCommand("UPDATE tbl_transaction_order
                SET qty=@qty,price=@price, amount=@amount,category=@category
                WHERE transaction_no=@tnum AND item_code=@ic", Con)
                            FillTransact.Parameters.AddWithValue("@tnum", qty_tnum)
                            FillTransact.Parameters.AddWithValue("@ic", qty_ic)
                            FillTransact.Parameters.AddWithValue("@particulars", qty_particulars)
                            FillTransact.Parameters.AddWithValue("@qty", Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@price", qty_price)
                            FillTransact.Parameters.AddWithValue("@amount", qty_price * Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@category", qty_category)
                            FillTransact.ExecuteNonQuery()
                        End Using
                        Con.Close()
                        OpenChildForm(New FrmTransactGuest)
                        Me.Hide()
                    Catch ex As Exception
                        MessageBox.Show("Food/Item failed to update. " & ex.Message, "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
            FrmBlurEffect.Hide()

        ElseIf formUsingQTY = "FrmEmployeesCredit" Then

            Dim b As Boolean 'for determining messagebox result

            'compare itemcode and voucher number for more accurate adding of orders
            Try
                OpenCon()
                Using CompareItemCode As New MySqlCommand("SELECT COUNT(*) FROM tbl_billing_emp_order
                WHERE voucher_no='" & currentVoucherNo & "'AND item_code='" & qty_ic & "'", Con)
                    Dim Count = Convert.ToInt32(CompareItemCode.ExecuteScalar())
                    If Val(Count) > 0 Then
                        b = False ' if false then just add amount and compute the total amount
                    Else
                        b = True ' if true then just add to order to transaction
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Con.Close()
            End Try

            If txtQTY.Text = 0 Then
                MessageBox.Show("No item(s) added!", "Value is 0", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Dispose()
            Else
                If b = True Then
                    Try
                        OpenCon()
                        Using FillTransact As New MySqlCommand("INSERT INTO tbl_billing_emp_order
                        (voucher_no,item_code,particulars,qty,price,
                        amount,category) VALUES (@vnum,@ic,@particulars,@qty,@price,@amount,@category)", Con)
                            FillTransact.Parameters.AddWithValue("@vnum", currentVoucherNo)
                            FillTransact.Parameters.AddWithValue("@ic", qty_ic)
                            FillTransact.Parameters.AddWithValue("@particulars", qty_particulars)
                            FillTransact.Parameters.AddWithValue("@qty", Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@price", qty_price)
                            FillTransact.Parameters.AddWithValue("@amount", qty_price * Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@category", qty_category)
                            FillTransact.ExecuteNonQuery()
                        End Using
                        Con.Close()
                        OpenChildForm(New FrmEmpCredit)
                        Me.Dispose()
                    Catch ex As Exception
                        MessageBox.Show("Food/Item failed to add. " & ex.Message, "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                ElseIf b = False Then
                    Try
                        OpenCon()
                        Using FillTransact As New MySqlCommand("UPDATE tbl_billing_emp_order
                        SET qty=@qty,price=@price,amount=@amount,category=@category
                        WHERE voucher_no=@vnum AND item_code=@ic", Con)
                            FillTransact.Parameters.AddWithValue("@vnum", currentVoucherNo)
                            FillTransact.Parameters.AddWithValue("@ic", qty_ic)
                            FillTransact.Parameters.AddWithValue("@particulars", qty_particulars)
                            FillTransact.Parameters.AddWithValue("@qty", Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@price", qty_price)
                            FillTransact.Parameters.AddWithValue("@amount", qty_price * Val(txtQTY.Text))
                            FillTransact.Parameters.AddWithValue("@category", qty_category)
                            FillTransact.ExecuteNonQuery()
                        End Using
                        Con.Close()
                        OpenChildForm(New FrmEmpCredit)
                        Me.Hide()
                    Catch ex As Exception
                        MessageBox.Show("Food/Item failed to update. " & ex.Message, "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
            FrmBlurEffect.Hide()

        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        FrmBlurEffect.Hide()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If txtQTY.Text >= 100 Then
            Exit Sub
        Else
            txtQTY.Text += 1
        End If
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles BtnSubtract.Click

        If txtQTY.Text = 0 Then
            Exit Sub
        Else
            txtQTY.Text -= 1
        End If
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As EventArgs) Handles txtQTY.TextChanged
        If qty_qty > 0 Then
            BtnDelete.Enabled = True
        Else
            BtnDelete.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        Dim ItemName As String = qty_particulars
        Me.Hide()
        Dim result As DialogResult = MessageBox.Show($"Delete ""{ItemName}"" to order?", "DELETE FOOD/ITEM",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If formUsingQTY = "ThenFrmTransactGuest" Then
            If result = DialogResult.Yes Then
                Try
                    OpenCon()
                    Using deleteOrder As New MySqlCommand("DELETE FROM tbl_transaction_order
                WHERE transaction_no ='" & qty_tnum & "'
                And item_code ='" & qty_ic & "'", Con)
                        deleteOrder.ExecuteNonQuery()
                    End Using

                    Dim result2 As DialogResult = MessageBox.Show("Food/Item successfully deleted.", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result2 = DialogResult.OK Then
                        FrmBlurEffect.Dispose()
                        OpenChildForm(New FrmTransactGuest)
                    Else
                        FrmBlurEffect.Dispose()
                        OpenChildForm(New FrmTransactGuest)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try

            Else
                Me.Show()
                Exit Sub
            End If
        ElseIf formUsingQTY = "FrmEmployeesCredit" Then
            If result = DialogResult.Yes Then
                Try
                    OpenCon()
                    Using deleteOrder As New MySqlCommand("DELETE FROM tbl_billing_emp_order
                     WHERE voucher_no ='" & currentVoucherNo & "'
                     And item_code ='" & qty_ic & "'", Con)
                        deleteOrder.ExecuteNonQuery()
                    End Using

                    Dim result2 As DialogResult = MessageBox.Show("Food/Item successfully deleted.", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If result2 = DialogResult.OK Then
                        FrmBlurEffect.Dispose()
                        OpenChildForm(New FrmEmpCredit)
                    Else
                        FrmBlurEffect.Dispose()
                        OpenChildForm(New FrmEmpCredit)
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    Con.Close()
                End Try

            Else
                Me.Show()
                Exit Sub
            End If
        End If

    End Sub

    Private Sub txtQTY_GotFocus(sender As Object, e As EventArgs) Handles txtQTY.GotFocus
        txtQTY.SelectAll()
    End Sub

    Private Sub FrmSubQTY_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle the key down event here
        Select Case e.KeyCode
            Case Keys.Right Or Keys.Up
                BtnAdd.PerformClick()
            Case Keys.Left Or Keys.Down
                BtnSubtract.PerformClick()
            Case Keys.Delete
                BtnDelete.PerformClick()
            Case Keys.Enter
                BtnConfirm.PerformClick()
        End Select
    End Sub
End Class