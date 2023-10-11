Module Value_Holder
    'for current status
    Public CurrentRoomNumber As Integer
    '    Public CurrentTime As TimeOnly
    Public currentChildForm As Form
    Public currentUserName As String
    Public currentUserId As String
    Public currentUserPosition As String

    ' orders value holder
    Public qty_tnum As Integer 'current transaction no holder
    Public qty_ic As String
    Public qty_particulars As String
    Public qty_qty As Integer
    Public qty_price As Integer
    Public qty_amount As Integer
    Public qty_category As String

    'for frmtransact to frmcheckout orders transfer table
    Public myDataTable As DataTable

    ' to identify what form using FrmSubQTY
    Public formUsingQTY As String

    ' current voucher no
    Public currentVoucherNo As String

    'for check-out index, current transasction
    Public currentTransactionNo As Integer

    'for setting declaration of countdown timer/excess hour meter
    Public firstexcess As Integer
    Public secondexcess As Integer
    Public additionalExcess As Integer

    'for vat percentage and senior percentage
    Public vatPercentage As Integer
    Public seniorPercentage As Integer

    Public Sub OpenChildForm(childForm As Form)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        frmMain.PanelMain.Controls.Add(childForm)
        frmMain.PanelMain.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub


End Module
