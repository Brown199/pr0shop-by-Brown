Public Class frm_textEditor
    Public bAuf As Boolean

    Private Sub cmd_fontPlus_Click_1(sender As System.Object, e As System.EventArgs) Handles cmd_fontPlus.Click
        frm_main.lbl_body1.Font = New Font(frm_main.lbl_body1.Font.FontFamily, frm_main.lbl_body1.Font.Size + 1, frm_main.lbl_body1.Font.Style)
        If frm_main.lbl_body1.Font.Size > 1 Then
            frm_main.lbl_body1.Font = New Font(frm_main.lbl_body1.Font.FontFamily, frm_main.lbl_body1.Font.Size + 1, frm_main.lbl_body1.Font.Style)
            lbl_body1FontSize.Text = frm_main.lbl_body1.Font.Size
        End If
    End Sub

    Private Sub cmd_fontMinus_Click_1(sender As System.Object, e As System.EventArgs) Handles cmd_fontMinus.Click
        If frm_main.lbl_body1.Font.Size > 1 Then
            frm_main.lbl_body1.Font = New Font(frm_main.lbl_body1.Font.FontFamily, frm_main.lbl_body1.Font.Size - 1, frm_main.lbl_body1.Font.Style)
            lbl_body1FontSize.Text = frm_main.lbl_body1.Font.Size
        End If
    End Sub

    Private Sub frm_textEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_body1FontSize.Text = frm_main.lbl_body1.Font.Size
        txt_header.Text = frm_main.lbl_header.Text
        rtb_body.Text = frm_main.lbl_body1.Text
    End Sub

    Private Sub tmr_refreshText_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_refreshText.Tick
        frm_main.lbl_header.Text = txt_header.Text
        frm_main.lbl_body1.Text = rtb_body.Text
    End Sub
End Class