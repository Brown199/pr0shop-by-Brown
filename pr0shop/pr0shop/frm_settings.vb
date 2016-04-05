Public Class frm_settings

#Region "Eigene Events"
    Public Event colorSelected(ByVal chosenColor As Color)

    'Events die vom textEditor durchgereicht werden
    Public Event fontPlus()
    Public Event fontMinus()
    Public Event contentChanged(ByVal heading As String, ByVal content As String)
#End Region

#Region "lokale Variablen"

    Private iMaximumImages As Integer = 2
    Private iImageCount As Integer = 1
    Private iPbZaehler As Integer = 0
    Private pPb(10) As PictureBox

    Private allowedChars As String = "0123456789" & vbBack

    'Dim hexFont As String = "#1db992"
    'Dim bAutosize As Boolean = False

    Public WithEvents frm_textEditor As New frm_textEditor()

#End Region

    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frm_textEditor.lbl_body1FontSize.Text = frm_main.lbl_body1.Font.Size

        'Me.Cursor = New Cursor(My.Resources.cursor.Handle)

        lbl_aktuellDisplay.Text = iPbZaehler
        lbl_version.Text = "v" + Application.ProductVersion

        For i As Integer = 0 To 10
            pPb(i) = New PictureBox
        Next
    End Sub

    Private Sub frm_settings_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragOver
        frm_main.cmd_settings.ForeColor = ColorTranslator.FromHtml("#ee4d2d")
    End Sub


    Private Sub Save(sender As Object, e As EventArgs) Handles cmd_screenshot.Click
        Try
            frm_main.cmd_quit.Hide()
            frm_main.cmd_settings.Hide()
            frm_main.cmd_minimize.Hide()
            Dim Steuerelement As Control
            ' ***** Welches Steuerelement, ggf anpassen (z.B. Button1) *****
            Steuerelement = frm_main                                  ' Me entspricht Form
            Dim Breite As Integer = Steuerelement.Width         ' Breite des Steuerelements
            Dim Hoehe As Integer = Steuerelement.Height         ' Höhe des Steuerelements
            Dim Schnappschuss As Bitmap = New Bitmap(Breite, Hoehe) ' Größe der Bitmap
            ' ***** Schnappschuß machen als Bipmap *****
            Steuerelement.DrawToBitmap(Schnappschuss, Rectangle.FromLTRB(0, 0, Breite, Hoehe))
            My.Computer.Clipboard.SetImage(Schnappschuss)       ' In die Zwischenablage
            ' ***** Falls in der Zwischenablage eine Bitmap vorliegt *****
            If System.Windows.Forms.Clipboard.GetDataObject() IsNot Nothing Then
                Dim Zwischenablage As IDataObject = System.Windows.Forms.Clipboard.GetDataObject()
                If Zwischenablage.GetDataPresent(System.Windows.Forms.DataFormats.Bitmap) Then
                    If sfd_main.ShowDialog(Me) = DialogResult.OK Then
                        Dim sSavePath As String = sfd_main.FileName
                        Dim Bitmuster As System.Drawing.Image = CType(Zwischenablage.GetData(DataFormats.Bitmap, True), Image)
                        Bitmuster.Save(sSavePath)
                        System.Diagnostics.Process.Start(sSavePath)
                    End If
                End If
            End If
            frm_main.cmd_quit.Show()
            frm_main.cmd_settings.Show()
            frm_main.cmd_minimize.Show()
        Catch ex As Exception
            MsgBox("Egal was Du getan hast: Es war falsch ¯\_(ツ)_/¯", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub


    Private Sub tmr_refresh_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_refresh.Tick
        lbl_aktuellDisplay.Text = iPbZaehler

        If IsNumeric(txt_windowScaleX.Text) And IsNumeric(txt_windowScaleY.Text) Then
            If txt_windowScaleX.Text <> "" And txt_windowScaleY.Text <> "" Then
                If txt_windowScaleX.Text >= 1 And txt_windowScaleY.Text >= 1 Then
                    frm_main.Size = New System.Drawing.Size(txt_windowScaleX.Text, txt_windowScaleY.Text)
                End If
            End If
        End If

        Try
            If cb_bilderAnzahl.Text <> "" Then
                If IsNumeric(txt_xSize.Text) And IsNumeric(txt_ySize.Text) And Not chkb_autoSize.Checked Then
                    pPb(cb_bilderAnzahl.Text - 1).Width = txt_xSize.Text
                    pPb(cb_bilderAnzahl.Text - 1).Height = txt_ySize.Text
                End If
                chkb_autoSize.Enabled = True
            Else
                chkb_autoSize.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Fehler: " + vbCrLf + ex.Message)
        End Try

        If chkb_autoSize.Checked And chkb_autoSize.Enabled Then
            pPb(cb_bilderAnzahl.Text - 1).SizeMode = PictureBoxSizeMode.AutoSize
        End If

        If Not chkb_autoSize.Checked And chkb_autoSize.Enabled Then
            pPb(cb_bilderAnzahl.Text - 1).SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If frm_main.bLabelInit = True Then  'Ich weiß, hätte auch in einer Schleife gehen können...
            frm_main.lblLaenge(1).Text = "1/4"
            frm_main.lblLaenge(1).Visible = True
            frm_main.lblLaenge(1).ForeColor = Color.White
            frm_main.lblLaenge(1).Top = frm_main.Size.Height / 4
            frm_main.lblLaenge(1).Left = frm_main.Size.Width - 30
            frm_main.Controls.Add(frm_main.lblLaenge(1))
            frm_main.lblLaenge(1).BringToFront()

            frm_main.lblLaenge(2).Text = "2/4"
            frm_main.lblLaenge(2).Visible = True
            frm_main.lblLaenge(2).ForeColor = Color.White
            frm_main.lblLaenge(2).Top = frm_main.Size.Height / 2
            frm_main.lblLaenge(2).Left = frm_main.Size.Width - 30
            frm_main.Controls.Add(frm_main.lblLaenge(2))
            frm_main.lblLaenge(2).BringToFront()

            frm_main.lblLaenge(3).Text = "3/4"
            frm_main.lblLaenge(3).Visible = True
            frm_main.lblLaenge(3).ForeColor = Color.White
            frm_main.lblLaenge(3).Top = (frm_main.Size.Height / 2) + (frm_main.Size.Height / 4)
            frm_main.lblLaenge(3).Left = frm_main.Size.Width - 30
            frm_main.Controls.Add(frm_main.lblLaenge(3))
            frm_main.lblLaenge(3).BringToFront()

            frm_main.lbl_errorLabel.Text = ""
        End If
    End Sub

    Private Sub cmd_reset_Click(sender As System.Object, e As System.EventArgs) Handles cmd_reset.Click
        txt_windowScaleX.Text = 1052
        txt_windowScaleY.Text = 600
        txt_xSize.Text = 300
        txt_ySize.Text = 300
    End Sub


    Private Sub addImage(sender As System.Object, e As System.EventArgs) Handles cmd_imagePlus.Click
        If iPbZaehler < 10 Then
            Dim nummer As Integer
            For nummer = iPbZaehler To iPbZaehler
                pPb(iPbZaehler).Image = (My.Resources.dickbutt1)
                pPb(iPbZaehler).Visible = True
                pPb(iPbZaehler).Top = 100
                pPb(iPbZaehler).Left = 100
                pPb(iPbZaehler).Width = 300
                pPb(iPbZaehler).Height = 300
                pPb(iPbZaehler).SizeMode = PictureBoxSizeMode.StretchImage

                AddHandler pPb(iPbZaehler).DoubleClick, AddressOf PictureBox_Handler_DoubleClick
                AddHandler pPb(iPbZaehler).MouseDown, AddressOf PictureBox_Handler_MouseDown
                AddHandler pPb(iPbZaehler).MouseUp, AddressOf PictureBox_Handler_MouseUp
                AddHandler pPb(iPbZaehler).MouseMove, AddressOf PictureBox_Handler_MouseMove
                AddHandler pPb(iPbZaehler).SizeChanged, AddressOf PictureBox_Handler_SizeChanged
                frm_main.Controls.Add(pPb(iPbZaehler))
                pPb(iPbZaehler).BringToFront()
            Next
            iPbZaehler += 1
            lbl_aktuellDisplay.Text = iPbZaehler
            cb_bilderAnzahl.Items.Add(nummer.ToString)
            pPb(iPbZaehler).BringToFront()
            frm_main.lbl_body1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub removeImage(sender As System.Object, e As System.EventArgs) Handles cmd_imageMinus.Click
        If iPbZaehler > 0 Then
            iPbZaehler -= 1
            lbl_aktuellDisplay.Text = iPbZaehler
            Dim nummer As Integer
            For nummer = iPbZaehler To iPbZaehler
                RemoveHandler pPb(iPbZaehler).DoubleClick, AddressOf PictureBox_Handler_DoubleClick
                RemoveHandler pPb(iPbZaehler).MouseDown, AddressOf PictureBox_Handler_MouseDown
                RemoveHandler pPb(iPbZaehler).MouseUp, AddressOf PictureBox_Handler_MouseUp
                RemoveHandler pPb(iPbZaehler).MouseMove, AddressOf PictureBox_Handler_MouseMove
                RemoveHandler pPb(iPbZaehler).SizeChanged, AddressOf PictureBox_Handler_SizeChanged
                frm_main.Controls.Remove(pPb(iPbZaehler))
            Next
            cb_bilderAnzahl.Items.Remove(nummer.ToString)
        End If
    End Sub


#Region "Eventhandler für die Pictureboxen"
    Private Sub PictureBox_Handler_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim pb As PictureBox
        pb = CType(sender, PictureBox)
        If pb.Size.Width > frm_main.Size.Width - 10 Or pb.Size.Height > frm_main.Size.Height - 10 Then
            pb.Size = New Size(300, 300)
            txt_xSize.Text = 300
            txt_ySize.Text = 300
            'MsgBox("Das Bild ist zu groß für das Fenster ¯\_(ツ)_/¯", MsgBoxStyle.Critical, "Fehler")
        End If
    End Sub

    Private Sub PictureBox_Handler_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim pb As PictureBox
            pb = CType(sender, PictureBox)
            frm_main.ofd_pbmain.Title = "Wähle ein Bild aus"
            If frm_main.ofd_pbmain.ShowDialog(Me) = DialogResult.OK Then
                Dim img As String = frm_main.ofd_pbmain.FileName
                pb.Image = System.Drawing.Bitmap.FromFile(img)
            End If
        Catch ex As Exception
            MsgBox("Egal was Du getan hast: Es war falsch ¯\_(ツ)_/¯", MsgBoxStyle.Critical, "Fehler")
        End Try
    End Sub

    Private Sub PictureBox_Handler_MouseDown(ByVal sender As Object, ByVal e As EventArgs)
        frm_main.downElement()
    End Sub

    Private Sub PictureBox_Handler_MouseUp(ByVal sender As Object, ByVal e As EventArgs)
        frm_main.upElement()
    End Sub

    Private Sub PictureBox_Handler_MouseMove(ByVal sender As Object, ByVal e As EventArgs)
        Dim pb As PictureBox
        pb = CType(sender, PictureBox)

        If pb.Left + pb.Size.Width >= frm_main.Size.Width Or pb.Top + pb.Size.Height >= frm_main.Size.Height Then
            'frm_main.lbl_errorLabel.Text = "[IMAGE OUT OF RANGE]"
            pb.Location = New Point((pb.Left) - 1, (pb.Top) - 1)
            frm_main.upElement()
        ElseIf pb.Left <= 0 Or pb.Top <= 0 Then
            pb.Location = New Point((pb.Left) + 1, (pb.Top) + 1)
            frm_main.upElement()
            'frm_main.lbl_errorLabel.Text = "[IMAGE OK]"
        End If

        frm_main.moveElement(sender)
        'If MouseButtons = Windows.Forms.MouseButtons.Left Then
        '    pb.Location = New Point(0, 0)
        'End If
    End Sub
#End Region

#Region "Funktionen für die Fenstergröße"
    Private Sub txt_windowScaleX_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_windowScaleX.KeyPress
        Dim tText As TextBox
        tText = CType(sender, TextBox)
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            'nicht valide Taste
            e.Handled = True
        End If
        If tText.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_windowScaleY_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_windowScaleY.KeyPress
        Dim tText As TextBox
        tText = CType(sender, TextBox)
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
        If tText.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Funktionen für die Bildgröße"
    Private Sub txt_xSize_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_xSize.KeyPress
        Dim tText As TextBox
        tText = CType(sender, TextBox)
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
        If tText.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_ySize_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ySize.KeyPress
        Dim tText As TextBox
        tText = CType(sender, TextBox)
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If
        If tText.Text.Length >= 11 Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub cmd_edit_Click(sender As System.Object, e As System.EventArgs) Handles cmd_edit.Click
        frm_textEditor.Show()
    End Sub

#Region "Farbwechsel"
    Private Sub rb_colorGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rb_colorGreen.CheckedChanged
        If rb_colorGreen.Checked Then
            RaiseEvent colorSelected(ColorTranslator.FromHtml("#1db992"))
        Else
            RaiseEvent colorSelected(ColorTranslator.FromHtml("#ee4d2d"))
        End If
    End Sub

#End Region

#Region "Events des Text-Editor"

    Private Sub contentChangedHandler(ByVal heading As String, ByVal content As String) Handles frm_textEditor.contentChanged
        RaiseEvent contentChanged(heading, content)
    End Sub
    Private Sub fontPlusHandler() Handles frm_textEditor.fontPlus
        RaiseEvent fontPlus()
    End Sub
    Private Sub fontMinusHandler() Handles frm_textEditor.fontMinus
        RaiseEvent fontMinus()
    End Sub

#End Region

End Class

