<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_settings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_settings))
        Me.txt_windowScaleY = New System.Windows.Forms.TextBox()
        Me.txt_windowScaleX = New System.Windows.Forms.TextBox()
        Me.txt_ySize = New System.Windows.Forms.TextBox()
        Me.txt_xSize = New System.Windows.Forms.TextBox()
        Me.lbl_windowScale = New System.Windows.Forms.Label()
        Me.lbl_pictureboxSize = New System.Windows.Forms.Label()
        Me.cmd_screenshot = New System.Windows.Forms.Button()
        Me.cmd_reset = New System.Windows.Forms.Button()
        Me.tmr_refresh = New System.Windows.Forms.Timer(Me.components)
        Me.tt_main = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.sfd_main = New System.Windows.Forms.SaveFileDialog()
        Me.gb_groessen = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkb_autoSize = New System.Windows.Forms.CheckBox()
        Me.cb_bilderAnzahl = New System.Windows.Forms.ComboBox()
        Me.cmd_imageMinus = New System.Windows.Forms.Button()
        Me.cmd_imagePlus = New System.Windows.Forms.Button()
        Me.lbl_imageCount = New System.Windows.Forms.Label()
        Me.lbl_aktuell = New System.Windows.Forms.Label()
        Me.lbl_aktuellDisplay = New System.Windows.Forms.Label()
        Me.cmd_edit = New System.Windows.Forms.Button()
        Me.rb_colorGreen = New System.Windows.Forms.RadioButton()
        Me.rb_colorOrange = New System.Windows.Forms.RadioButton()
        Me.gb_groessen.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_windowScaleY
        '
        Me.txt_windowScaleY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_windowScaleY.Location = New System.Drawing.Point(155, 14)
        Me.txt_windowScaleY.MaxLength = 4
        Me.txt_windowScaleY.Name = "txt_windowScaleY"
        Me.txt_windowScaleY.Size = New System.Drawing.Size(37, 20)
        Me.txt_windowScaleY.TabIndex = 2
        Me.txt_windowScaleY.Text = "600"
        '
        'txt_windowScaleX
        '
        Me.txt_windowScaleX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_windowScaleX.Location = New System.Drawing.Point(112, 14)
        Me.txt_windowScaleX.MaxLength = 4
        Me.txt_windowScaleX.Name = "txt_windowScaleX"
        Me.txt_windowScaleX.Size = New System.Drawing.Size(37, 20)
        Me.txt_windowScaleX.TabIndex = 1
        Me.txt_windowScaleX.Text = "1052"
        '
        'txt_ySize
        '
        Me.txt_ySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ySize.Location = New System.Drawing.Point(155, 40)
        Me.txt_ySize.MaxLength = 4
        Me.txt_ySize.Name = "txt_ySize"
        Me.txt_ySize.Size = New System.Drawing.Size(37, 20)
        Me.txt_ySize.TabIndex = 4
        Me.txt_ySize.Text = "300"
        '
        'txt_xSize
        '
        Me.txt_xSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_xSize.Location = New System.Drawing.Point(112, 40)
        Me.txt_xSize.MaxLength = 4
        Me.txt_xSize.Name = "txt_xSize"
        Me.txt_xSize.Size = New System.Drawing.Size(37, 20)
        Me.txt_xSize.TabIndex = 3
        Me.txt_xSize.Text = "300"
        '
        'lbl_windowScale
        '
        Me.lbl_windowScale.AutoSize = True
        Me.lbl_windowScale.Location = New System.Drawing.Point(6, 16)
        Me.lbl_windowScale.Name = "lbl_windowScale"
        Me.lbl_windowScale.Size = New System.Drawing.Size(100, 13)
        Me.lbl_windowScale.TabIndex = 23
        Me.lbl_windowScale.Text = "Fenstergröße (X|Y): "
        '
        'lbl_pictureboxSize
        '
        Me.lbl_pictureboxSize.AutoSize = True
        Me.lbl_pictureboxSize.Location = New System.Drawing.Point(6, 42)
        Me.lbl_pictureboxSize.Name = "lbl_pictureboxSize"
        Me.lbl_pictureboxSize.Size = New System.Drawing.Size(100, 13)
        Me.lbl_pictureboxSize.TabIndex = 24
        Me.lbl_pictureboxSize.Text = "Bildergröße    (X|Y): "
        '
        'cmd_screenshot
        '
        Me.cmd_screenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_screenshot.Location = New System.Drawing.Point(216, 101)
        Me.cmd_screenshot.Name = "cmd_screenshot"
        Me.cmd_screenshot.Size = New System.Drawing.Size(135, 23)
        Me.cmd_screenshot.TabIndex = 11
        Me.cmd_screenshot.Text = "Speichern"
        Me.cmd_screenshot.UseVisualStyleBackColor = True
        '
        'cmd_reset
        '
        Me.cmd_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_reset.Location = New System.Drawing.Point(9, 89)
        Me.cmd_reset.Name = "cmd_reset"
        Me.cmd_reset.Size = New System.Drawing.Size(183, 23)
        Me.cmd_reset.TabIndex = 7
        Me.cmd_reset.Text = "Zurücksetzen"
        Me.cmd_reset.UseVisualStyleBackColor = True
        '
        'tmr_refresh
        '
        Me.tmr_refresh.Enabled = True
        Me.tmr_refresh.Interval = 500
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(12, 135)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(42, 13)
        Me.lbl_version.TabIndex = 29
        Me.lbl_version.Text = "Version"
        Me.tt_main.SetToolTip(Me.lbl_version, "made by Brown")
        '
        'sfd_main
        '
        Me.sfd_main.Filter = "Bilddateien(*.JPG)|*.JPG;"
        Me.sfd_main.Title = "Speichern unter..."
        '
        'gb_groessen
        '
        Me.gb_groessen.Controls.Add(Me.Label1)
        Me.gb_groessen.Controls.Add(Me.chkb_autoSize)
        Me.gb_groessen.Controls.Add(Me.cb_bilderAnzahl)
        Me.gb_groessen.Controls.Add(Me.lbl_windowScale)
        Me.gb_groessen.Controls.Add(Me.txt_xSize)
        Me.gb_groessen.Controls.Add(Me.txt_ySize)
        Me.gb_groessen.Controls.Add(Me.cmd_reset)
        Me.gb_groessen.Controls.Add(Me.txt_windowScaleX)
        Me.gb_groessen.Controls.Add(Me.txt_windowScaleY)
        Me.gb_groessen.Controls.Add(Me.lbl_pictureboxSize)
        Me.gb_groessen.Location = New System.Drawing.Point(12, 12)
        Me.gb_groessen.Name = "gb_groessen"
        Me.gb_groessen.Size = New System.Drawing.Size(198, 120)
        Me.gb_groessen.TabIndex = 1
        Me.gb_groessen.TabStop = False
        Me.gb_groessen.Text = "Größen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Bild Nr.: "
        '
        'chkb_autoSize
        '
        Me.chkb_autoSize.AutoSize = True
        Me.chkb_autoSize.Location = New System.Drawing.Point(112, 67)
        Me.chkb_autoSize.Name = "chkb_autoSize"
        Me.chkb_autoSize.Size = New System.Drawing.Size(66, 17)
        Me.chkb_autoSize.TabIndex = 6
        Me.chkb_autoSize.Text = "Autosize"
        Me.chkb_autoSize.UseVisualStyleBackColor = True
        '
        'cb_bilderAnzahl
        '
        Me.cb_bilderAnzahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_bilderAnzahl.FormattingEnabled = True
        Me.cb_bilderAnzahl.Location = New System.Drawing.Point(59, 65)
        Me.cb_bilderAnzahl.Name = "cb_bilderAnzahl"
        Me.cb_bilderAnzahl.Size = New System.Drawing.Size(47, 21)
        Me.cb_bilderAnzahl.TabIndex = 5
        '
        'cmd_imageMinus
        '
        Me.cmd_imageMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_imageMinus.Location = New System.Drawing.Point(248, 28)
        Me.cmd_imageMinus.Name = "cmd_imageMinus"
        Me.cmd_imageMinus.Size = New System.Drawing.Size(26, 23)
        Me.cmd_imageMinus.TabIndex = 9
        Me.cmd_imageMinus.Text = "-"
        Me.cmd_imageMinus.UseVisualStyleBackColor = True
        '
        'cmd_imagePlus
        '
        Me.cmd_imagePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_imagePlus.Location = New System.Drawing.Point(216, 28)
        Me.cmd_imagePlus.Name = "cmd_imagePlus"
        Me.cmd_imagePlus.Size = New System.Drawing.Size(26, 23)
        Me.cmd_imagePlus.TabIndex = 8
        Me.cmd_imagePlus.Text = "+"
        Me.cmd_imagePlus.UseVisualStyleBackColor = True
        '
        'lbl_imageCount
        '
        Me.lbl_imageCount.AutoSize = True
        Me.lbl_imageCount.Location = New System.Drawing.Point(213, 12)
        Me.lbl_imageCount.Name = "lbl_imageCount"
        Me.lbl_imageCount.Size = New System.Drawing.Size(89, 13)
        Me.lbl_imageCount.TabIndex = 29
        Me.lbl_imageCount.Text = "Anzahl der Bilder:"
        '
        'lbl_aktuell
        '
        Me.lbl_aktuell.AutoSize = True
        Me.lbl_aktuell.Location = New System.Drawing.Point(216, 54)
        Me.lbl_aktuell.Name = "lbl_aktuell"
        Me.lbl_aktuell.Size = New System.Drawing.Size(45, 13)
        Me.lbl_aktuell.TabIndex = 32
        Me.lbl_aktuell.Text = "Aktuell: "
        '
        'lbl_aktuellDisplay
        '
        Me.lbl_aktuellDisplay.AutoSize = True
        Me.lbl_aktuellDisplay.Location = New System.Drawing.Point(267, 54)
        Me.lbl_aktuellDisplay.Name = "lbl_aktuellDisplay"
        Me.lbl_aktuellDisplay.Size = New System.Drawing.Size(35, 13)
        Me.lbl_aktuellDisplay.TabIndex = 33
        Me.lbl_aktuellDisplay.Text = "NULL"
        '
        'cmd_edit
        '
        Me.cmd_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_edit.Location = New System.Drawing.Point(216, 72)
        Me.cmd_edit.Name = "cmd_edit"
        Me.cmd_edit.Size = New System.Drawing.Size(135, 23)
        Me.cmd_edit.TabIndex = 10
        Me.cmd_edit.Text = "Texte bearbeiten"
        Me.cmd_edit.UseVisualStyleBackColor = True
        '
        'rb_colorGreen
        '
        Me.rb_colorGreen.AutoSize = True
        Me.rb_colorGreen.Location = New System.Drawing.Point(303, 133)
        Me.rb_colorGreen.Name = "rb_colorGreen"
        Me.rb_colorGreen.Size = New System.Drawing.Size(48, 17)
        Me.rb_colorGreen.TabIndex = 34
        Me.rb_colorGreen.Text = "Grün"
        Me.rb_colorGreen.UseVisualStyleBackColor = True
        '
        'rb_colorOrange
        '
        Me.rb_colorOrange.AutoSize = True
        Me.rb_colorOrange.Checked = True
        Me.rb_colorOrange.Location = New System.Drawing.Point(216, 133)
        Me.rb_colorOrange.Name = "rb_colorOrange"
        Me.rb_colorOrange.Size = New System.Drawing.Size(60, 17)
        Me.rb_colorOrange.TabIndex = 35
        Me.rb_colorOrange.TabStop = True
        Me.rb_colorOrange.Text = "Orange"
        Me.rb_colorOrange.UseVisualStyleBackColor = True
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 157)
        Me.Controls.Add(Me.rb_colorOrange)
        Me.Controls.Add(Me.rb_colorGreen)
        Me.Controls.Add(Me.cmd_edit)
        Me.Controls.Add(Me.lbl_aktuellDisplay)
        Me.Controls.Add(Me.lbl_aktuell)
        Me.Controls.Add(Me.lbl_imageCount)
        Me.Controls.Add(Me.cmd_imageMinus)
        Me.Controls.Add(Me.gb_groessen)
        Me.Controls.Add(Me.cmd_imagePlus)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.cmd_screenshot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_settings"
        Me.Text = "pr0shop - Einstellungen"
        Me.gb_groessen.ResumeLayout(False)
        Me.gb_groessen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_windowScaleY As System.Windows.Forms.TextBox
    Friend WithEvents txt_windowScaleX As System.Windows.Forms.TextBox
    Friend WithEvents txt_ySize As System.Windows.Forms.TextBox
    Friend WithEvents txt_xSize As System.Windows.Forms.TextBox
    Friend WithEvents lbl_windowScale As System.Windows.Forms.Label
    Friend WithEvents lbl_pictureboxSize As System.Windows.Forms.Label
    Friend WithEvents cmd_screenshot As System.Windows.Forms.Button
    Friend WithEvents cmd_reset As System.Windows.Forms.Button
    Friend WithEvents tmr_refresh As System.Windows.Forms.Timer
    Friend WithEvents tt_main As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents sfd_main As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gb_groessen As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_imageMinus As System.Windows.Forms.Button
    Friend WithEvents cmd_imagePlus As System.Windows.Forms.Button
    Friend WithEvents lbl_imageCount As System.Windows.Forms.Label
    Friend WithEvents lbl_aktuell As System.Windows.Forms.Label
    Friend WithEvents lbl_aktuellDisplay As System.Windows.Forms.Label
    Friend WithEvents cmd_edit As System.Windows.Forms.Button
    Friend WithEvents cb_bilderAnzahl As System.Windows.Forms.ComboBox
    Friend WithEvents chkb_autoSize As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rb_colorGreen As System.Windows.Forms.RadioButton
    Friend WithEvents rb_colorOrange As System.Windows.Forms.RadioButton
End Class
