
Public Class FrmBlurEffect
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.ShowInTaskbar = False ' This line is important to hide it from the taskbar.

    End Sub


    Private Sub FrmBlurEffect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.6
        Me.TopLevel = True
        Me.BringToFront()
        Me.Top = frmMain.Top
        Me.Left = frmMain.Left
    End Sub
End Class