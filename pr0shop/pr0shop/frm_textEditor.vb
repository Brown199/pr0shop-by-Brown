Public Class frm_textEditor

    Public Event fontPlus()
    Public Event fontMinus()
    Public Event contentChanged(ByVal heading As String, ByVal content As String)

    Private Sub frm_textEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_body1FontSize.Text = frm_main.lbl_body1.Font.Size
        txt_header.Text = frm_main.lbl_header.Text
        rtb_body.Text = frm_main.lbl_body1.Text
    End Sub

    Private Sub cmd_fontPlus_Click_1(sender As System.Object, e As System.EventArgs) Handles cmd_fontPlus.Click
        RaiseEvent fontPlus()
    End Sub
    Private Sub cmd_fontMinus_Click_1(sender As System.Object, e As System.EventArgs) Handles cmd_fontMinus.Click
        RaiseEvent fontMinus()
    End Sub
    Public Sub updateFontSize(fontSize As Single)
        lbl_body1FontSize.Text = fontSize
    End Sub

    Private Sub textHasChanged(sender As Object, e As EventArgs) Handles rtb_body.KeyPress, txt_header.KeyPress
        RaiseEvent contentChanged(txt_header.Text, rtb_body.Text)
    End Sub

End Class