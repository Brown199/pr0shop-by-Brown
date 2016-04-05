Public Class frm_main

#Region "Lokale Variablen"
    ' switche
    Private go As Boolean
    Private leftSet As Boolean
    Private topSet As Boolean

    ' maus position
    Private holdLeft As Integer
    Private holdTop As Integer

    ' offsets
    Private offLeft As Integer
    Private offTop As Integer

    ' form bewegen
    Private drag As Boolean
    Private mouseX As Integer
    Private mouseY As Integer
    Private bSettingsOpen As Boolean

    ' Farben
    Private colorBg As Color = ColorTranslator.FromHtml("#161618")
    Private colorFont As Color = ColorTranslator.FromHtml("#ee4d2d")

    ' label config
    Public bLabelInit As Boolean = False
    Public lblLaenge(3) As Label

    Private WithEvents frm_settings As New frm_settings()
#End Region


    Private Sub frm_main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'Cursor setzen
            'Me.Cursor = New Cursor(My.Resources.cursor.Handle)

            Me.BackColor = colorBg

            For i As Integer = 0 To 3
                lblLaenge(i) = New Label
                lbl_errorLabel.Text = "Lade Steuerelemente (" + i.ToString + "/4)"
                bLabelInit = True
            Next

            lbl_header.ForeColor = colorFont
            lbl_body1.ForeColor = colorFont
            lbl_brown.ForeColor = colorFont
            cmd_settings.ForeColor = colorFont
            cmd_quit.ForeColor = colorFont
            cmd_minimize.ForeColor = colorFont

            cmd_settings.BackColor = colorBg
            cmd_quit.BackColor = colorBg
            cmd_minimize.BackColor = colorBg

            lbl_brown.Text = "Brown's pr0shop >_ v" + Application.ProductVersion

        Catch ex As Exception
            MsgBox(ex.Message, , "Fehler")
        End Try
    End Sub

#Region "Farbwechsel"

    Private Sub frm_settings_colorSelected(chosenColor As Color) Handles frm_settings.colorSelected
        setColor(chosenColor)
        colorFont = chosenColor

        If frm_settings.rb_colorOrange.Checked Then
            pb_angenehmesGruen.Visible = False
        Else
            pb_angenehmesGruen.Visible = True
        End If

        If frm_settings.Visible Then
            cmd_settings.ForeColor = Color.Green
        Else
            cmd_settings.ForeColor = chosenColor
        End If
    End Sub

    Function setColor(color As Color)
        lbl_header.ForeColor = color
        lbl_body1.ForeColor = color
        lbl_brown.ForeColor = color
        cmd_settings.ForeColor = color
        cmd_quit.ForeColor = color
        cmd_minimize.ForeColor = color
        Return 0
    End Function

#End Region

#Region "Events des Text-Editor"

    Private Sub contentChanged(ByVal heading As String, ByVal content As String) Handles frm_settings.contentChanged
        lbl_header.Text = heading
        lbl_body1.Text = content
    End Sub

    Private Sub fontPlus() Handles frm_settings.fontPlus
        lbl_body1.Font = New Font(lbl_body1.Font.FontFamily, lbl_body1.Font.Size + 1, lbl_body1.Font.Style)
        If lbl_body1.Font.Size > 1 Then
            lbl_body1.Font = New Font(lbl_body1.Font.FontFamily, lbl_body1.Font.Size + 1, lbl_body1.Font.Style)
            frm_settings.frm_textEditor.updateFontSize(lbl_body1.Font.Size)
        End If
    End Sub

    Private Sub fontMinus() Handles frm_settings.fontMinus
        If lbl_body1.Font.Size > 1 Then
            lbl_body1.Font = New Font(lbl_body1.Font.FontFamily, lbl_body1.Font.Size - 1, lbl_body1.Font.Style)
            frm_settings.frm_textEditor.updateFontSize(lbl_body1.Font.Size)
        End If
    End Sub

#End Region

#Region "Funktionen für Bewegung der Labels"
    Sub downElement()
        go = True
    End Sub

    Sub upElement()
        go = False
        leftSet = False
        topSet = False
    End Sub

    Sub moveElement(sender As Object)
        ' überprüfen ob eine maustaste gedrückt ist
        If go Then
            ' mausposition setzen
            holdLeft = (Control.MousePosition.X - Me.Left)
            holdTop = (Control.MousePosition.Y - Me.Top)

            ' wo wurde die maus gedrückt?
            If topSet = False Then
                offTop = holdTop - sender.Top
                topSet = True
            End If
            If leftSet = False Then
                offLeft = holdLeft - sender.Left
                leftSet = True
            End If

            ' position neu setzen
            sender.Left = holdLeft - offLeft
            sender.Top = holdTop - offTop
        End If
    End Sub
#End Region

#Region "Eventhandler für Mausaktionen des Forms"

    Private Sub frm_main_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frm_main_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub frm_main_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

#End Region

#Region "Eventhandler für Mausaktionen auf den Labels"
    Private Sub lbl_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseDown, lbl_header.MouseDown
        downElement()
    End Sub

    Private Sub lbl_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseUp, lbl_header.MouseUp
        upElement()
    End Sub

    Private Sub lbl_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseMove, lbl_header.MouseMove
        moveElement(sender)
    End Sub

#End Region

#Region "Eventhandler für Steuerung der Fenster"

    Private Sub cmd_quit_Click(sender As Object, e As EventArgs) Handles cmd_quit.Click
        Application.Exit()
    End Sub

    Private Sub cmd_quit_MouseEnter(sender As Object, e As System.EventArgs) Handles cmd_quit.MouseEnter
        cmd_quit.ForeColor = Color.Red
    End Sub

    Private Sub cmd_quit_MouseLeave(sender As Object, e As System.EventArgs) Handles cmd_quit.MouseLeave
        cmd_quit.ForeColor = colorFont
    End Sub

    Private Sub cmd_minimize_Click(sender As Object, e As EventArgs) Handles cmd_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub cmd_settings_Click(sender As Object, e As EventArgs) Handles cmd_settings.Click
        bSettingsOpen = Not bSettingsOpen

        If bSettingsOpen Then
            frm_settings.Show()
            frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
            cmd_settings.ForeColor = Color.Green
        Else
            frm_settings.Hide()
            cmd_settings.ForeColor = colorFont
        End If
    End Sub


    Private Sub frm_main_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub frm_main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

#End Region

    Private Sub lbl_brown_Click(sender As System.Object, e As System.EventArgs) Handles lbl_brown.Click
        Process.Start("http://pr0gramm.com/user/Brown")
    End Sub

End Class
