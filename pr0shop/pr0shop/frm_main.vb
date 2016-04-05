Public Class frm_main
    ' switche
    Dim Go As Boolean
    Dim LeftSet As Boolean
    Dim TopSet As Boolean
    ' maus position
    Dim HoldLeft As Integer
    Dim HoldTop As Integer
    ' offsets
    Dim OffLeft As Integer
    Dim OffTop As Integer
    ' form bewegen
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim bSettingsOpen As Boolean

    ' Hex codes für die farben
    Dim hexBackground As String = "#161618"
    Dim hexFont As String = "#ee4d2d"

    ' label config
    Public bLabelInit As Boolean = False
    Public lblLaenge(3) As Label

#Region "Functions"
    Function downElement()
        Go = True
        Return 1
    End Function

    Function upElement()
        Go = False
        LeftSet = False
        TopSet = False
        Return 1
    End Function

    Function moveElement(sender As Object)
        ' überprüfen ob eine maustaste gedrückt ist
        If Go = True Then
            ' mausposition setzen
            HoldLeft = (Control.MousePosition.X - Me.Left)
            HoldTop = (Control.MousePosition.Y - Me.Top)
            ' wo wurde die maus gedrückt?
            If TopSet = False Then
                OffTop = HoldTop - sender.Top
                TopSet = True
            End If
            If LeftSet = False Then
                OffLeft = HoldLeft - sender.Left
                LeftSet = True
            End If
            ' position neu setzen
            sender.Left = HoldLeft - OffLeft
            sender.Top = HoldTop - OffTop
        End If
        Return 1
    End Function
#End Region

    Private Sub frm_main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            'Cursor setzen
            'Me.Cursor = New Cursor(My.Resources.cursor.Handle)

            Me.BackColor = ColorTranslator.FromHtml(hexBackground)

            For i As Integer = 0 To 3
                lblLaenge(i) = New Label
                lbl_errorLabel.Text = "Lade Steuerelemente (" + i.ToString + "/4)"
                bLabelInit = True
            Next

            lbl_header.ForeColor = ColorTranslator.FromHtml(hexFont)
            lbl_body1.ForeColor = ColorTranslator.FromHtml(hexFont)
            lbl_brown.ForeColor = ColorTranslator.FromHtml(hexFont)
            cmd_settings.BackColor = ColorTranslator.FromHtml(hexBackground)
            cmd_settings.ForeColor = ColorTranslator.FromHtml(hexFont)
            cmd_quit.BackColor = ColorTranslator.FromHtml(hexBackground)
            cmd_quit.ForeColor = ColorTranslator.FromHtml(hexFont)
            cmd_minimize.BackColor = ColorTranslator.FromHtml(hexBackground)
            cmd_minimize.ForeColor = ColorTranslator.FromHtml(hexFont)
            lbl_brown.Text = "Brown's pr0shop >_ v" + Application.ProductVersion
        Catch ex As Exception
            MsgBox(ex.Message, , "Fehler")
        End Try
    End Sub

    Private Sub frm_main_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub frm_main_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub frm_main_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub cmd_quit_Click(sender As System.Object, e As System.EventArgs) Handles cmd_quit.Click
        End
    End Sub

    Private Sub cmd_settings_Click(sender As System.Object, e As System.EventArgs) Handles cmd_settings.Click
        bSettingsOpen = Not bSettingsOpen
        If bSettingsOpen Then
            frm_settings.Show()
            frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
            cmd_settings.ForeColor = Color.Green
        Else
            frm_settings.Hide()
            cmd_settings.ForeColor = ColorTranslator.FromHtml(hexFont)
        End If
    End Sub

    Private Sub frm_main_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub frm_main_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        frm_settings.Location = New Point(Me.Location.X + Me.Width + 5, Me.Location.Y)
    End Sub

    Private Sub lbl_body_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseDown
        downElement()
    End Sub

    Private Sub lbl_body_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseUp
        upElement()
    End Sub

    Private Sub lbl_body_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_body1.MouseMove
        moveElement(sender)
    End Sub

    Private Sub lbl_header_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_header.MouseDown
        downElement()
    End Sub

    Private Sub lbl_header_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_header.MouseUp
        upElement()
    End Sub

    Private Sub lbl_header_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lbl_header.MouseMove
        moveElement(sender)
    End Sub

    Private Sub cmd_quit_MouseEnter(sender As Object, e As System.EventArgs) Handles cmd_quit.MouseEnter
        cmd_quit.ForeColor = Color.Red
    End Sub

    Private Sub cmd_quit_MouseLeave(sender As Object, e As System.EventArgs) Handles cmd_quit.MouseLeave
        cmd_quit.ForeColor = ColorTranslator.FromHtml(hexFont)
    End Sub

    Private Sub cmd_minimize_Click(sender As System.Object, e As System.EventArgs) Handles cmd_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbl_brown_Click(sender As System.Object, e As System.EventArgs) Handles lbl_brown.Click
        Process.Start("http://pr0gramm.com/user/Brown")
    End Sub

    Private Sub tmr_settings_Tick(sender As System.Object, e As System.EventArgs) Handles tmr_settings.Tick
        If frm_settings.rb_colorOrange.Checked Then
            setColor("#ee4d2d")
            hexFont = "#ee4d2d"
            pb_angenehmesGruen.Visible = False
        End If
        If frm_settings.rb_colorGreen.Checked Then
            setColor("#1db992")
            hexFont = "#1db992"
            pb_angenehmesGruen.Visible = True
        End If
        If frm_settings.Visible Then
            cmd_settings.ForeColor = Color.Green
        Else
            cmd_settings.ForeColor = ColorTranslator.FromHtml(hexFont)
        End If
    End Sub

    Function setColor(color As String)
        lbl_header.ForeColor = ColorTranslator.FromHtml(color)
        lbl_body1.ForeColor = ColorTranslator.FromHtml(color)
        lbl_brown.ForeColor = ColorTranslator.FromHtml(color)
        cmd_settings.ForeColor = ColorTranslator.FromHtml(color)
        cmd_quit.ForeColor = ColorTranslator.FromHtml(color)
        cmd_minimize.ForeColor = ColorTranslator.FromHtml(color)
        Return 0
    End Function
End Class
