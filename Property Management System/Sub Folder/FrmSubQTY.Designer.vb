<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSubQTY
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
        LblQTYTitle = New Label()
        Label1 = New Label()
        LblItemName = New Label()
        BtnConfirm = New FontAwesome.Sharp.IconButton()
        BtnSubtract = New Button()
        BtnAdd = New Button()
        BtnDelete = New FontAwesome.Sharp.IconButton()
        txtQTY = New TextBox()
        PanelTitlebar.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitlebar
        ' 
        PanelTitlebar.BackColor = Color.FromArgb(CByte(79), CByte(112), CByte(156))
        PanelTitlebar.BorderStyle = BorderStyle.FixedSingle
        PanelTitlebar.Controls.Add(LblQTYTitle)
        PanelTitlebar.Controls.Add(Label1)
        PanelTitlebar.Dock = DockStyle.Top
        PanelTitlebar.Location = New Point(0, 0)
        PanelTitlebar.Name = "PanelTitlebar"
        PanelTitlebar.Size = New Size(533, 25)
        PanelTitlebar.TabIndex = 1
        ' 
        ' LblQTYTitle
        ' 
        LblQTYTitle.AutoSize = True
        LblQTYTitle.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LblQTYTitle.ForeColor = SystemColors.ControlLightLight
        LblQTYTitle.Location = New Point(4, 2)
        LblQTYTitle.Name = "LblQTYTitle"
        LblQTYTitle.Size = New Size(174, 17)
        LblQTYTitle.TabIndex = 7
        LblQTYTitle.Text = "Add/Edit/Delete Order item"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(508, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 18)
        Label1.TabIndex = 6
        Label1.Text = "x"
        ' 
        ' LblItemName
        ' 
        LblItemName.BackColor = Color.White
        LblItemName.BorderStyle = BorderStyle.FixedSingle
        LblItemName.FlatStyle = FlatStyle.Flat
        LblItemName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblItemName.Location = New Point(125, 34)
        LblItemName.Name = "LblItemName"
        LblItemName.Size = New Size(256, 34)
        LblItemName.TabIndex = 0
        LblItemName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnConfirm
        ' 
        BtnConfirm.BackColor = Color.FromArgb(CByte(230), CByte(160), CByte(0))
        BtnConfirm.FlatStyle = FlatStyle.Flat
        BtnConfirm.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnConfirm.IconChar = FontAwesome.Sharp.IconChar.None
        BtnConfirm.IconColor = Color.Black
        BtnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnConfirm.Location = New Point(425, 32)
        BtnConfirm.Name = "BtnConfirm"
        BtnConfirm.Size = New Size(101, 37)
        BtnConfirm.TabIndex = 0
        BtnConfirm.Text = "CONFIRM"
        BtnConfirm.UseVisualStyleBackColor = False
        ' 
        ' BtnSubtract
        ' 
        BtnSubtract.BackColor = Color.White
        BtnSubtract.FlatAppearance.BorderSize = 0
        BtnSubtract.FlatStyle = FlatStyle.Flat
        BtnSubtract.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnSubtract.Location = New Point(4, 31)
        BtnSubtract.Name = "BtnSubtract"
        BtnSubtract.Size = New Size(33, 40)
        BtnSubtract.TabIndex = 3
        BtnSubtract.Text = "-"
        BtnSubtract.UseVisualStyleBackColor = False
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = Color.White
        BtnAdd.FlatAppearance.BorderSize = 0
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnAdd.Location = New Point(86, 31)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(33, 40)
        BtnAdd.TabIndex = 4
        BtnAdd.Text = "+"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnDelete
        ' 
        BtnDelete.BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        BtnDelete.FlatAppearance.BorderSize = 0
        BtnDelete.FlatStyle = FlatStyle.Flat
        BtnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        BtnDelete.IconColor = Color.Firebrick
        BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto
        BtnDelete.IconSize = 35
        BtnDelete.ImageAlign = ContentAlignment.TopCenter
        BtnDelete.Location = New Point(384, 30)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(35, 39)
        BtnDelete.TabIndex = 2
        BtnDelete.UseVisualStyleBackColor = False
        ' 
        ' txtQTY
        ' 
        txtQTY.BorderStyle = BorderStyle.FixedSingle
        txtQTY.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtQTY.Location = New Point(39, 31)
        txtQTY.MaxLength = 2
        txtQTY.Multiline = True
        txtQTY.Name = "txtQTY"
        txtQTY.Size = New Size(45, 40)
        txtQTY.TabIndex = 1
        txtQTY.Text = "0"
        txtQTY.TextAlign = HorizontalAlignment.Center
        ' 
        ' FrmSubQTY
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(216), CByte(196), CByte(182))
        ClientSize = New Size(533, 78)
        Controls.Add(txtQTY)
        Controls.Add(BtnDelete)
        Controls.Add(BtnAdd)
        Controls.Add(LblItemName)
        Controls.Add(BtnConfirm)
        Controls.Add(PanelTitlebar)
        Controls.Add(BtnSubtract)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Name = "FrmSubQTY"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ENTER ITEM QUANTITY"
        PanelTitlebar.ResumeLayout(False)
        PanelTitlebar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelTitlebar As Panel
    Friend WithEvents LblQTYTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblItemName As Label
    Friend WithEvents BtnConfirm As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents txtQTY As TextBox
End Class
