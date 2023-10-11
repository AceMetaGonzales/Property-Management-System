<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubTransfer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelTitlebar = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        txtReason = New TextBox()
        BtnConfirm = New FontAwesome.Sharp.IconButton()
        Label3 = New Label()
        ClbAvailableRoom = New CheckedListBox()
        Label4 = New Label()
        Label19 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        PanelTitlebar.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitlebar
        ' 
        PanelTitlebar.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        PanelTitlebar.BorderStyle = BorderStyle.FixedSingle
        PanelTitlebar.Controls.Add(Label2)
        PanelTitlebar.Controls.Add(Label1)
        PanelTitlebar.Dock = DockStyle.Top
        PanelTitlebar.Location = New Point(0, 0)
        PanelTitlebar.Name = "PanelTitlebar"
        PanelTitlebar.Size = New Size(345, 25)
        PanelTitlebar.TabIndex = 99
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(4, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 17)
        Label2.TabIndex = 7
        Label2.Text = "Transfer Room"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(324, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 18)
        Label1.TabIndex = 6
        Label1.Text = "x"
        ' 
        ' txtReason
        ' 
        txtReason.BorderStyle = BorderStyle.FixedSingle
        txtReason.Location = New Point(12, 29)
        txtReason.Multiline = True
        txtReason.Name = "txtReason"
        txtReason.Size = New Size(174, 189)
        txtReason.TabIndex = 101
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnConfirm.FlatStyle = FlatStyle.Flat
        BtnConfirm.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnConfirm.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        BtnConfirm.IconColor = Color.Black
        BtnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnConfirm.IconSize = 30
        BtnConfirm.Location = New Point(12, 226)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(321, 37)
        BtnConfirm.TabIndex = 102
        BtnConfirm.Text = "CONFIRM"
        BtnConfirm.TextAlign = ContentAlignment.MiddleRight
        BtnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnConfirm.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(17, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 15)
        Label3.TabIndex = 103
        Label3.Text = "Reason for Transfer:"
        ' 
        ' ClbAvailableRoom
        ' 
        ClbAvailableRoom.BorderStyle = BorderStyle.FixedSingle
        ClbAvailableRoom.CheckOnClick = True
        ClbAvailableRoom.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ClbAvailableRoom.FormattingEnabled = True
        ClbAvailableRoom.Location = New Point(202, 29)
        ClbAvailableRoom.Name = "ClbAvailableRoom"
        ClbAvailableRoom.Size = New Size(131, 189)
        ClbAvailableRoom.TabIndex = 104
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(202, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 15)
        Label4.TabIndex = 105
        Label4.Text = "Choose Available Room:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.ForeColor = Color.Red
        Label19.Location = New Point(8, 8)
        Label19.Name = "Label19"
        Label19.Size = New Size(12, 16)
        Label19.TabIndex = 106
        Label19.Text = "*"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(192, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(12, 16)
        Label5.TabIndex = 107
        Label5.Text = "*"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtReason)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(BtnConfirm)
        Panel1.Controls.Add(Label19)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(ClbAvailableRoom)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(345, 276)
        Panel1.TabIndex = 108
        ' 
        ' FrmSubTransfer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(239), CByte(231))
        ClientSize = New Size(345, 301)
        Controls.Add(Panel1)
        Controls.Add(PanelTitlebar)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmSubTransfer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "                       "
        PanelTitlebar.ResumeLayout(False)
        PanelTitlebar.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents BtnConfirm As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ClbAvailableRoom As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
End Class
