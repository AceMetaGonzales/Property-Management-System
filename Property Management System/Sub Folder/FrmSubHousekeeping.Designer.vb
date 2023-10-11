<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubHousekeeping
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        LblDes = New Label()
        LblStatus = New Label()
        BtnConfirm = New FontAwesome.Sharp.IconButton()
        PanelTitlebar = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        PanelTitlebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(BtnConfirm)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(342, 272)
        Panel1.TabIndex = 58
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(LblDes)
        Panel2.Controls.Add(LblStatus)
        Panel2.Location = New Point(9, 9)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(324, 200)
        Panel2.TabIndex = 85
        ' 
        ' LblDes
        ' 
        LblDes.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LblDes.Location = New Point(21, 51)
        LblDes.Name = "LblDes"
        LblDes.Size = New Size(279, 131)
        LblDes.TabIndex = 1
        LblDes.Text = "Current Room Status"
        LblDes.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblStatus
        ' 
        LblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblStatus.Location = New Point(66, 13)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(191, 25)
        LblStatus.TabIndex = 0
        LblStatus.Text = "Current Room Status"
        LblStatus.TextAlign = ContentAlignment.MiddleCenter
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
        BtnConfirm.ImageAlign = ContentAlignment.MiddleRight
        BtnConfirm.Location = New Point(9, 215)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(324, 50)
        BtnConfirm.TabIndex = 0
        BtnConfirm.Text = "CONFIRM"
        BtnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnConfirm.UseVisualStyleBackColor = False
        ' 
        ' PanelTitlebar
        ' 
        PanelTitlebar.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        PanelTitlebar.Controls.Add(Label2)
        PanelTitlebar.Controls.Add(Label1)
        PanelTitlebar.Dock = DockStyle.Top
        PanelTitlebar.Location = New Point(0, 0)
        PanelTitlebar.Name = "PanelTitlebar"
        PanelTitlebar.Size = New Size(342, 25)
        PanelTitlebar.TabIndex = 57
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(4, 2)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 17)
        Label2.TabIndex = 7
        Label2.Text = "Current room status"
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
        ' FrmSubHousekeeping
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(342, 297)
        Controls.Add(Panel1)
        Controls.Add(PanelTitlebar)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmSubHousekeeping"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmSubHousekeeping"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        PanelTitlebar.ResumeLayout(False)
        PanelTitlebar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblStatus As Label
    Friend WithEvents BtnConfirm As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblDes As Label
End Class
