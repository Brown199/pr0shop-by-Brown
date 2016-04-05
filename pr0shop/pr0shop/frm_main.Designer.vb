<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.lbl_body1 = New System.Windows.Forms.Label()
        Me.cmd_quit = New System.Windows.Forms.Button()
        Me.cmd_settings = New System.Windows.Forms.Button()
        Me.ofd_pbmain = New System.Windows.Forms.OpenFileDialog()
        Me.cmd_minimize = New System.Windows.Forms.Button()
        Me.lbl_brown = New System.Windows.Forms.Label()
        Me.pb_main = New System.Windows.Forms.PictureBox()
        Me.lbl_errorLabel = New System.Windows.Forms.Label()
        Me.tmr_settings = New System.Windows.Forms.Timer(Me.components)
        Me.pb_angenehmesGruen = New System.Windows.Forms.PictureBox()
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_angenehmesGruen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header.Location = New System.Drawing.Point(12, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(256, 37)
        Me.lbl_header.TabIndex = 8
        Me.lbl_header.Text = "Hallo pr0gramm,"
        '
        'lbl_body1
        '
        Me.lbl_body1.AutoSize = True
        Me.lbl_body1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_body1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_body1.Location = New System.Drawing.Point(15, 46)
        Me.lbl_body1.Name = "lbl_body1"
        Me.lbl_body1.Size = New System.Drawing.Size(830, 200)
        Me.lbl_body1.TabIndex = 12
        Me.lbl_body1.Text = resources.GetString("lbl_body1.Text")
        '
        'cmd_quit
        '
        Me.cmd_quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_quit.Location = New System.Drawing.Point(986, 12)
        Me.cmd_quit.Name = "cmd_quit"
        Me.cmd_quit.Size = New System.Drawing.Size(24, 23)
        Me.cmd_quit.TabIndex = 2
        Me.cmd_quit.Text = "X"
        Me.cmd_quit.UseVisualStyleBackColor = True
        '
        'cmd_settings
        '
        Me.cmd_settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_settings.Location = New System.Drawing.Point(896, 12)
        Me.cmd_settings.Name = "cmd_settings"
        Me.cmd_settings.Size = New System.Drawing.Size(84, 23)
        Me.cmd_settings.TabIndex = 1
        Me.cmd_settings.Text = "Einstellungen"
        Me.cmd_settings.UseVisualStyleBackColor = True
        '
        'ofd_pbmain
        '
        Me.ofd_pbmain.FileName = "Bild"
        Me.ofd_pbmain.Filter = "Bilddateien(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF"
        Me.ofd_pbmain.Tag = ""
        '
        'cmd_minimize
        '
        Me.cmd_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_minimize.Location = New System.Drawing.Point(1016, 12)
        Me.cmd_minimize.Name = "cmd_minimize"
        Me.cmd_minimize.Size = New System.Drawing.Size(24, 23)
        Me.cmd_minimize.TabIndex = 13
        Me.cmd_minimize.Text = "_"
        Me.cmd_minimize.UseVisualStyleBackColor = True
        '
        'lbl_brown
        '
        Me.lbl_brown.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_brown.AutoSize = True
        Me.lbl_brown.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_brown.Location = New System.Drawing.Point(926, 583)
        Me.lbl_brown.Name = "lbl_brown"
        Me.lbl_brown.Size = New System.Drawing.Size(94, 12)
        Me.lbl_brown.TabIndex = 14
        Me.lbl_brown.Text = "Brown's pr0shop >_ v"
        '
        'pb_main
        '
        Me.pb_main.BackColor = System.Drawing.Color.Transparent
        Me.pb_main.Image = Global.pr0shop.My.Resources.Resources.dickbutt1
        Me.pb_main.Location = New System.Drawing.Point(868, 41)
        Me.pb_main.Name = "pb_main"
        Me.pb_main.Size = New System.Drawing.Size(172, 199)
        Me.pb_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_main.TabIndex = 2
        Me.pb_main.TabStop = False
        Me.pb_main.Visible = False
        '
        'lbl_errorLabel
        '
        Me.lbl_errorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_errorLabel.AutoSize = True
        Me.lbl_errorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_errorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_errorLabel.Location = New System.Drawing.Point(12, 576)
        Me.lbl_errorLabel.Name = "lbl_errorLabel"
        Me.lbl_errorLabel.Size = New System.Drawing.Size(0, 15)
        Me.lbl_errorLabel.TabIndex = 16
        '
        'tmr_settings
        '
        Me.tmr_settings.Enabled = True
        Me.tmr_settings.Interval = 1000
        '
        'pb_angenehmesGruen
        '
        Me.pb_angenehmesGruen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_angenehmesGruen.BackColor = System.Drawing.Color.Transparent
        Me.pb_angenehmesGruen.Image = Global.pr0shop.My.Resources.Resources.grün
        Me.pb_angenehmesGruen.Location = New System.Drawing.Point(855, 499)
        Me.pb_angenehmesGruen.Name = "pb_angenehmesGruen"
        Me.pb_angenehmesGruen.Size = New System.Drawing.Size(165, 81)
        Me.pb_angenehmesGruen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_angenehmesGruen.TabIndex = 17
        Me.pb_angenehmesGruen.TabStop = False
        Me.pb_angenehmesGruen.Visible = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 600)
        Me.Controls.Add(Me.pb_angenehmesGruen)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.lbl_body1)
        Me.Controls.Add(Me.lbl_errorLabel)
        Me.Controls.Add(Me.cmd_minimize)
        Me.Controls.Add(Me.cmd_settings)
        Me.Controls.Add(Me.cmd_quit)
        Me.Controls.Add(Me.pb_main)
        Me.Controls.Add(Me.lbl_brown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pr0shop"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        CType(Me.pb_main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_angenehmesGruen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_header As System.Windows.Forms.Label
    Friend WithEvents lbl_body1 As System.Windows.Forms.Label
    Friend WithEvents cmd_quit As System.Windows.Forms.Button
    Friend WithEvents cmd_settings As System.Windows.Forms.Button
    Friend WithEvents ofd_pbmain As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmd_minimize As System.Windows.Forms.Button
    Friend WithEvents lbl_brown As System.Windows.Forms.Label
    Friend WithEvents pb_main As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_errorLabel As System.Windows.Forms.Label
    Private WithEvents tmr_settings As System.Windows.Forms.Timer
    Friend WithEvents pb_angenehmesGruen As System.Windows.Forms.PictureBox

End Class
