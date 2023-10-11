Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports Google.Protobuf.Reflection.FieldOptions.Types
Imports MySql.Data.MySqlClient

Public Class FrmEmpCredit
    Dim txtSearchHighlights As Boolean

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub SearchEmployee()
        Dim columnSearch As New AutoCompleteStringCollection
        If RbName.Checked = True And RbIDNo.Checked = False Then
            OpenCon()
            Using cmdSearchEmp As New MySqlCommand("SELECT id,name FROM tbl_user", Con)
                Dim SEAdapter As New MySqlDataAdapter(cmdSearchEmp)
                Dim SEDT As New DataSet
                SEDT.Clear()
                SEAdapter.Fill(SEDT)
                For i As Integer = 0 To SEDT.Tables(0).Rows.Count - 1
                    columnSearch.Add(SEDT.Tables(0).Rows(i)("name").ToString() & " | " & SEDT.Tables(0).Rows(i)("id").ToString())
                Next
            End Using
            Con.Close()
        ElseIf RbName.Checked = False And RbIDNo.Checked = True Then
            OpenCon()
            Using cmdSearchEmp As New MySqlCommand("SELECT id,name FROM tbl_user", Con)
                Dim SEAdapter As New MySqlDataAdapter(cmdSearchEmp)
                Dim SEDT As New DataSet
                SEDT.Clear()
                SEAdapter.Fill(SEDT)
                For i As Integer = 0 To SEDT.Tables(0).Rows.Count - 1
                    columnSearch.Add(SEDT.Tables(0).Rows(i)("id").ToString() & " | " & SEDT.Tables(0).Rows(i)("name").ToString())
                Next
            End Using
            Con.Close()
        End If
        TxtSearchEmp.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtSearchEmp.AutoCompleteCustomSource = columnSearch
        TxtSearchEmp.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub
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
                    End While
                    reader.Close()
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
                End Using
                Con.Close()
            End If
        End If
    End Sub
    Sub LoadFormData()

        ' load current billing transaction
        If currentVoucherNo = "" Then
            LblVoucherNo.Text = "Generated voucher no. will display here."
            Exit Sub
             BtnConfirm.Enabled = True
        Else
            ' Retrieve data of current employee credit process when not cancel or done
            Try
                OpenCon()
                Using cmd As New MySqlCommand("SELECT * FROM tbl_billing_voucher WHERE voucher_no=@vnum", Con)
                    cmd.Parameters.AddWithValue("vnum", currentVoucherNo)
                    Dim cmdreader As MySqlDataReader = cmd.ExecuteReader
                    With cmdreader
                        .Read()
                        LblVoucherNo.Text = "Voucher No.: " & currentVoucherNo
                        TxtSearchEmp.Text = .Item("searchedtext")
                        LblIDNo.Text = .Item("em_id")
                        LblName.Text = .Item("name_payee")
                        LblContactNo.Text = .Item("contact")
                        LblPosition.Text = .Item("em_position")
                        LblDate.Text = .Item("date_time")
                        TxtComment.Text = .Item("comment")
                        .Close()
                    End With
                End Using
            Catch ex As Exception
                MessageBox.Show("Error on retrieving employee's data. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                Con.Close()
            End Try

            Try
                OpenCon()
                Using cmd As New MySqlCommand("SELECT * FROM tbl_billing_emp_order WHERE voucher_no=@vnum", Con)
                    cmd.Parameters.AddWithValue("vnum", currentVoucherNo)
                    Dim cmdreader As MySqlDataReader = cmd.ExecuteReader
                    With cmdreader
                        While .Read
                            Dim itemNo As String = cmdreader("item_code").ToString()
                            Dim particulars As String = cmdreader("particulars").ToString()
                            Dim qty As String = cmdreader("qty")
                            Dim price As Double = cmdreader("price")
                            Dim amount As Double = cmdreader("amount")
                            Dim category As String = cmdreader("category").ToString
                            DgTransact.Rows.Add(itemNo, particulars, qty, price.ToString("0.00"),
                                                amount.ToString("0.00"), category)
                            Dim total As Double
                            total += amount
                            LblTotal.Text = total.ToString("0.00")
                        End While
                        .Close()
                    End With
                    cmdreader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error on retrieving current employee's order. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                Con.Close()
            End Try
            BtnConfirm.Enabled = False
        End If

        PPD.ClientSize = New Size(200, 300) ' DETERMINE SIZE OF PRINTPREVIEWDIALOG

        If myDataTable Is Nothing Then
            Exit Sub
        Else
            myDataTable.Dispose() ' clear myDataTable value as DGTransact everyTime form load
        End If

       
    End Sub
    Sub finalizeCredit()

        FrmBlurEffect.Show()
        ' Update tbl_billing_coucher
        OpenCon()
        Using cmdVoucher As New MySqlCommand("UPDATE tbl_billing_voucher SET comment=@comment, status=@status
        WHERE voucher_no=@vno", Con)
            cmdVoucher.Parameters.AddWithValue("comment", TxtComment.Text)
            cmdVoucher.Parameters.AddWithValue("status", "OUT")
            cmdVoucher.Parameters.AddWithValue("vno", currentVoucherNo)
            cmdVoucher.ExecuteNonQuery()
        End Using

        'ADDING TRANSACTION TO LOG
        Try
            OpenCon()
            Using addToTransLog As New MySqlCommand("INSERT INTO tbl_log (logdetails,logtype,logreason,logtime,loguser,
                    logposition) VALUES (@ldetails,@ltype,@lreason,@ltime,@luser,@lposition)", Con)
                addToTransLog.Parameters.AddWithValue("ldetails", currentUserName & " transact credit of employee " &
                                                        LblName.Text & ".")
                addToTransLog.Parameters.AddWithValue("ltype", "EMPLOYEES CREDIT")
                addToTransLog.Parameters.AddWithValue("lreason", "CREDIT")
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
                    OpenChildForm(New FrmEmpCredit)
                    Dim result As DialogResult = MessageBox.Show("Credit of " &
                                                                 LblName.Text & " successfully transact.",
                                                                 "Credit Success!",
                                                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        'add the dynamic height to original receipt height
        longpaper = getDynamicHeight + 260
    End Sub

    Private Sub FrmEmpCredit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SuspendLayout()

        ' some default properties upon form load
        CbFoods.CheckState = CheckState.Checked
        CbBevItems.CheckState = CheckState.Checked
        RbName.Checked = CheckState.Checked
        TxtSearchMenu.Text = "-Search order here-"

        LoadFormData()
        FillMenuTable()
        SearchEmployee()
        ResumeLayout()
    End Sub

    Private Sub TxtSearchMenu_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchMenu.TextChanged
        FillMenuTable()
    End Sub

    Private Sub RbName_Click(sender As Object, e As EventArgs) Handles RbName.Click
        SearchEmployee()
        TxtSearchEmp.Focus()
    End Sub

    Private Sub RbIDNo_Click(sender As Object, e As EventArgs) Handles RbIDNo.Click
        SearchEmployee()
        TxtSearchEmp.Focus()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        Dim inputString As String = TxtSearchEmp.Text
        Dim intValue As Integer
        Dim match As Match = Regex.Match(inputString, "\d+")
        If TxtSearchEmp.Text <> "" Then
            If match.Success Then
                If Integer.TryParse(match.Value, intValue) Then
                    Try
                        OpenCon()
                        Using cmdEmployeesData As New MySqlCommand("SELECT * FROM tbl_user WHERE id=@idno", Con)
                            cmdEmployeesData.Parameters.AddWithValue("idno", intValue)
                            Dim EDReader As MySqlDataReader = cmdEmployeesData.ExecuteReader
                            With EDReader
                                .Read()
                                LblIDNo.Text = .Item("id")
                                LblContactNo.Text = .Item("contact_no")
                                LblName.Text = .Item("name")
                                LblPosition.Text = .Item("position")
                                LblDate.Text = Date.Now.ToShortDateString
                                .Close()
                            End With
                        End Using
                    Catch ex As Exception
                        FrmBlurEffect.Show()
                        FrmBlurEffect.TopMost = False
                        MessageBox.Show("No data found!", "Mismatch search!", MessageBoxButtons.OK,
                         MessageBoxIcon.Error)
                        FrmBlurEffect.Dispose()
                        Exit Sub
                    Finally
                        Con.Close()
                    End Try
                End If
            End If

            'generate transaction/add or update tbl_transaction_summary
            Try
                OpenCon()
                Using GenTransactionNo As New MySqlCommand("INSERT INTO tbl_billing_voucher
        (voucher_type,em_id,name_payee,contact,em_position,date_time,description,status,category,searchedtext)
         VALUES (@vtype,@eid,@ename,@econ,@epos,@date1,@des,@status,@category,@stext)", Con)

                    GenTransactionNo.Parameters.AddWithValue("vtype", "ECREDIT")
                    GenTransactionNo.Parameters.AddWithValue("eid", LblIDNo.Text)
                    GenTransactionNo.Parameters.AddWithValue("ename", LblName.Text)
                    GenTransactionNo.Parameters.AddWithValue("econ", LblContactNo.Text)
                    GenTransactionNo.Parameters.AddWithValue("epos", LblPosition.Text)
                    GenTransactionNo.Parameters.AddWithValue("date1", LblDate.Text)
                    GenTransactionNo.Parameters.AddWithValue("des", "Employees Credit")
                    GenTransactionNo.Parameters.AddWithValue("status", "current")
                    GenTransactionNo.Parameters.AddWithValue("category", "Credit")
                    GenTransactionNo.Parameters.AddWithValue("stext", TxtSearchEmp.Text)
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
            BtnConfirm.Enabled = False
        ElseIf TxtSearchEmp.Text = "" Then
            FrmBlurEffect.Show()
            MessageBox.Show("Empty search!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            FrmBlurEffect.Dispose()
            BtnConfirm.Enabled = True
        End If

    End Sub

    Private Sub DgMenu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMenu.CellDoubleClick
        If LblIDNo.Text = "" Then
            FrmBlurEffect.Show()
            MessageBox.Show("Search employee first!", "Empty credentials", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            FrmBlurEffect.Dispose()
            Exit Sub
        Else
            qty_ic = DgMenu.SelectedRows.Item(0).Cells(0).Value.ToString
            qty_particulars = DgMenu.SelectedRows.Item(0).Cells(1).Value.ToString
            qty_price = DgMenu.SelectedRows.Item(0).Cells(2).Value
            qty_category = DgMenu.SelectedRows.Item(0).Cells(4).Value.ToString

            ' Iterate through the DataGridView to find the matching item code in the first column (index 0)
            For Each row As DataGridViewRow In DgTransact.Rows
                If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = qty_ic Then
                    ' Found a match, get the quantity from the second column (index 1)
                    ' put the quantity to variable
                    qty_qty = row.Cells(2).Value.ToString()
                    ' Exit the loop
                    Exit For
                End If
            Next
            FrmBlurEffect.Show()
            formUsingQTY = "FrmEmployeesCredit"
            Using formSubQTY As New FrmSubQTY()
                formSubQTY.ShowDialog()
            End Using
        End If


    End Sub

    Private Sub DgTransact_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgTransact.CellDoubleClick
        qty_ic = DgTransact.SelectedRows.Item(0).Cells(0).Value.ToString
        qty_particulars = DgTransact.SelectedRows.Item(0).Cells(1).Value.ToString
        qty_price = DgTransact.SelectedRows.Item(0).Cells(3).Value
        qty_category = DgTransact.SelectedRows.Item(0).Cells(5).Value.ToString

        ' Iterate through the DataGridView to find the matching item code in the first column (index 0)
        For Each row As DataGridViewRow In DgTransact.Rows
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
        formUsingQTY = "FrmEmployeesCredit"
        Using formSubQTY As New FrmSubQTY()
            formSubQTY.ShowDialog()
        End Using
    End Sub

    Private Sub CbFoods_CheckedChanged(sender As Object, e As EventArgs) Handles CbFoods.CheckedChanged
        FillMenuTable()
    End Sub

    Private Sub CbBevItems_CheckedChanged(sender As Object, e As EventArgs) Handles CbBevItems.CheckedChanged
        FillMenuTable()
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
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        FrmBlurEffect.Show()
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
                finalizeCredit() ' confirm transaction and print receipt
                FrmBlurEffect.Dispose()
            Else
                e.Cancel = True ' cancel printing
                FrmBlurEffect.Dispose()
            End If

        End If

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        ' variables for receipt layout
        ' font styles
        Dim f6b As New Font("Calibri", 6, FontStyle.Bold)
        Dim F7 As New Font("Calibri", 7, FontStyle.Regular)
        Dim f8 As New Font("Calibri", 9, FontStyle.Regular)
        Dim f8Reg As New Font("Calibri", 8, FontStyle.Regular)
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
        e.Graphics.DrawString("HOTEL 101", f14, Brushes.Black, centermargin, 0, center)
        e.Graphics.DrawString("CASH VOUCHER", f8B, Brushes.Black, centermargin, 20, center)
        e.Graphics.DrawString("LUCENA BRANCH", f8B, Brushes.Black, centermargin, 33, center)

        e.Graphics.DrawString("VOUCHER NO. " & currentVoucherNo, f10b, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("PAYEE :", f8, Brushes.Black, leftmargin, 75)
        e.Graphics.DrawString(LblName.Text, f8, Brushes.Black, rightmargin, 75, right)

        e.Graphics.DrawString("CONTACT NO. :", f8, Brushes.Black, leftmargin, 90)
        e.Graphics.DrawString(LblContactNo.Text, f8, Brushes.Black, rightmargin, 90, right)

        e.Graphics.DrawString("DATE :", f8, Brushes.Black, leftmargin, 105)
        e.Graphics.DrawString(LblDate.Text, f8, Brushes.Black, rightmargin, 105, right)

        e.Graphics.DrawString("CATEGORY :", f8, Brushes.Black, leftmargin, 120)
        e.Graphics.DrawString("EMPLOYEE'S CREDIT", f8, Brushes.Black, rightmargin, 120, right)

        Dim ordertotal As Double
        Dim heightOfOrder As Integer 'DGV Position

        e.Graphics.DrawString("PARTICULARS", f10b, Brushes.Black, centermargin, 140, center)
        e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 155, center) 'first LINE
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
            e.Graphics.DrawString(categoryHeader, f6b, Brushes.Black, centermargin, 140 + heightOfOrder, center)

            ' Print the detail header
            heightOfOrder += 10
            e.Graphics.DrawString("ITEM", f8, Brushes.Black, leftmargin, 140 + heightOfOrder)
            e.Graphics.DrawString("QTY", f8, Brushes.Black, 150, 140 + heightOfOrder, right)
            e.Graphics.DrawString("PRICE", f8, Brushes.Black, 195, 140 + heightOfOrder, right)
            e.Graphics.DrawString("AMOUNT", f8, Brushes.Black, rightmargin, 140 + heightOfOrder, right)

            For row As Integer = 0 To myDataTable.Rows.Count - 1
                Dim category As String = myDataTable.Rows(row).Item(5).ToString() ' Assuming category is in column 5
                If category = categoryToPrint Then
                    heightOfOrder += 10
                    e.Graphics.DrawString(myDataTable.Rows(row).Item(1).ToString, f8Reg, Brushes.Black, leftmargin, 145 + heightOfOrder)
                    e.Graphics.DrawString(myDataTable.Rows(row).Item(2).ToString, f8Reg, Brushes.Black, 150, 145 + heightOfOrder, right)
                    e.Graphics.DrawString(myDataTable.Rows(row).Item(3).ToString, f8Reg, Brushes.Black, 195, 145 + heightOfOrder, right)
                    e.Graphics.DrawString(myDataTable.Rows(row).Item(4).ToString, f8Reg, Brushes.Black, rightmargin, 145 + heightOfOrder, right)
                    ordertotal += myDataTable.Rows(row).Item(4)
                End If
            Next

            ' Add the line separator after each category
            heightOfOrder += 10
            e.Graphics.DrawString(line, f8, Brushes.Black, centermargin, 145 + heightOfOrder, center)
        Next

        heightOfOrder += 15
        e.Graphics.DrawString("TOTAL AMOUNT :", f8B, Brushes.Black, leftmargin, 140 + heightOfOrder)
        e.Graphics.DrawString(ordertotal.ToString("0.00"), f8B, Brushes.Black, rightmargin, 140 + heightOfOrder, right)

        Dim height2 As Integer
        height2 = 155 + heightOfOrder

        e.Graphics.DrawString("PREPARED BY:", f10, Brushes.Black, leftmargin, 25 + height2)
        e.Graphics.DrawString("RECEIVED BY:", f10, Brushes.Black, 135, 25 + height2)

        e.Graphics.DrawString("____________________", f8, Brushes.Black, 65, 40 + height2, center)
        e.Graphics.DrawString("__________________", f8, Brushes.Black, 193, 40 + height2, center)

        e.Graphics.DrawString("Jhon Lester Manalo", f8, Brushes.Black, 65, 55 + height2, center)
        e.Graphics.DrawString("PAYEE SIGNATURE", f8, Brushes.Black, 193, 55 + height2, center)

        e.Graphics.DrawString("'", F7, Brushes.Black, rightmargin, 70 + height2, right)

    End Sub

    Private Sub BtnPPreview_Click(sender As Object, e As EventArgs) Handles BtnPPreview.Click
        ' Add an event handler for the FormClosing event
        AddHandler PPD.FormClosing, AddressOf PPD_FormClosing

        If DgTransact.RowCount = 0 Then
            FrmBlurEffect.Show()
            MessageBox.Show("There is no order to credit. Order first to preview the voucher", "Order(s) Empty!",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand)
            FrmBlurEffect.Hide()
        Else
            FrmBlurEffect.Show()
            myDataTable = DataGridViewToDataTable(DgTransact)
            PPD.Document = PD
            changelongpaper()
            PPD.StartPosition = FormStartPosition.CenterScreen
            PPD.ShowDialog()
            PPD.BringToFront()
        End If

    End Sub

    Private Sub PPD_FormClosing(sender As Object, e As FormClosingEventArgs)
        ' Handle the PrintPreviewDialog close event here
        If e.CloseReason = CloseReason.UserClosing Then
            ' The user closed the PrintPreviewDialog
            FrmBlurEffect.Dispose()

        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel employee's credit processing?",
                                                     "Cancel credit transaction",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            OpenCon()
            ' Delete current credit orders
            Using deleteOrders As New MySqlCommand("DELETE FROM tbl_billing_emp_order
             WHERE voucher_no=@cvoucherno", Con)
                deleteOrders.Parameters.AddWithValue("cvoucherno", currentVoucherNo)
                deleteOrders.ExecuteNonQuery()
            End Using

            ' Delete current credit voucher
            Using deleteVoucher As New MySqlCommand("DELETE FROM tbl_billing_voucher
            WHERE voucher_no=@cvoucherno", Con)
                deleteVoucher.Parameters.AddWithValue("cvoucherno", currentVoucherNo)
                deleteVoucher.ExecuteNonQuery()
            End Using

            ' Decrement the AUTO_INCREMENT value by 1
            If currentVoucherNo IsNot "" Then
                Dim newAutoIncrementValue As Integer = CInt(currentVoucherNo)
                Dim decrementAutoIncrementQuery As String = $"ALTER TABLE tbl_billing_voucher AUTO_INCREMENT = {newAutoIncrementValue}"
                Using cmd2 As New MySqlCommand(decrementAutoIncrementQuery, Con)
                    cmd2.ExecuteNonQuery()
                End Using
            End If

            Con.Close()

            currentVoucherNo = ""

            OpenChildForm(New FrmEmpCredit)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        PPD.Document = PD
        myDataTable = DataGridViewToDataTable(DgTransact)
        changelongpaper()
        PD.Print()  'Direct Print
    End Sub
End Class
