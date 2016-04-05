<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_textEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_textEditor))
        Me.gb_texte = New System.Windows.Forms.GroupBox()
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.txt_header = New System.Windows.Forms.TextBox()
        Me.lbl_body1FontSize = New System.Windows.Forms.Label()
        Me.rtb_body = New System.Windows.Forms.RichTextBox()
        Me.cmd_fontMinus = New System.Windows.Forms.Button()
        Me.lbl_body1 = New System.Windows.Forms.Label()
        Me.cmd_fontPlus = New System.Windows.Forms.Button()
        Me.tmr_refreshText = New System.Windows.Forms.Timer(Me.components)
        Me.gb_texte.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_texte
        '
        Me.gb_texte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_texte.Controls.Add(Me.lbl_header)
        Me.gb_texte.Controls.Add(Me.txt_header)
        Me.gb_texte.Controls.Add(Me.lbl_body1FontSize)
        Me.gb_texte.Controls.Add(Me.rtb_body)
        Me.gb_texte.Controls.Add(Me.cmd_fontMinus)
        Me.gb_texte.Controls.Add(Me.lbl_body1)
        Me.gb_texte.Controls.Add(Me.cmd_fontPlus)
        Me.gb_texte.Location = New System.Drawing.Point(12, 12)
        Me.gb_texte.Name = "gb_texte"
        Me.gb_texte.Size = New System.Drawing.Size(282, 331)
        Me.gb_texte.TabIndex = 31
        Me.gb_texte.TabStop = False
        Me.gb_texte.Text = "Texte"
        '
        'lbl_header
        '
        Me.lbl_header.AutoSize = True
        Me.lbl_header.Location = New System.Drawing.Point(6, 21)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(33, 13)
        Me.lbl_header.TabIndex = 0
        Me.lbl_header.Text = "Titel: "
        '
        'txt_header
        '
        Me.txt_header.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_header.Location = New System.Drawing.Point(45, 19)
        Me.txt_header.Name = "txt_header"
        Me.txt_header.Size = New System.Drawing.Size(231, 20)
        Me.txt_header.TabIndex = 1
        Me.txt_header.Text = "Hallo pr0gramm,"
        '
        'lbl_body1FontSize
        '
        Me.lbl_body1FontSize.AutoSize = True
        Me.lbl_body1FontSize.Location = New System.Drawing.Point(6, 91)
        Me.lbl_body1FontSize.Name = "lbl_body1FontSize"
        Me.lbl_body1FontSize.Size = New System.Drawing.Size(13, 13)
        Me.lbl_body1FontSize.TabIndex = 28
        Me.lbl_body1FontSize.Text = "0"
        '
        'rtb_body
        '
        Me.rtb_body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtb_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtb_body.Location = New System.Drawing.Point(77, 45)
        Me.rtb_body.Name = "rtb_body"
        Me.rtb_body.Size = New System.Drawing.Size(199, 280)
        Me.rtb_body.TabIndex = 2
        Me.rtb_body.Text = resources.GetString("rtb_body.Text")
        '
        'cmd_fontMinus
        '
        Me.cmd_fontMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_fontMinus.Location = New System.Drawing.Point(42, 65)
        Me.cmd_fontMinus.Name = "cmd_fontMinus"
        Me.cmd_fontMinus.Size = New System.Drawing.Size(26, 23)
        Me.cmd_fontMinus.TabIndex = 27
        Me.cmd_fontMinus.TabStop = False
        Me.cmd_fontMinus.Text = "-"
        Me.cmd_fontMinus.UseVisualStyleBackColor = True
        '
        'lbl_body1
        '
        Me.lbl_body1.AutoSize = True
        Me.lbl_body1.Location = New System.Drawing.Point(6, 45)
        Me.lbl_body1.Name = "lbl_body1"
        Me.lbl_body1.Size = New System.Drawing.Size(62, 13)
        Me.lbl_body1.TabIndex = 1
        Me.lbl_body1.Text = "Haupttext1:"
        '
        'cmd_fontPlus
        '
        Me.cmd_fontPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_fontPlus.Location = New System.Drawing.Point(9, 65)
        Me.cmd_fontPlus.Name = "cmd_fontPlus"
        Me.cmd_fontPlus.Size = New System.Drawing.Size(26, 23)
        Me.cmd_fontPlus.TabIndex = 26
        Me.cmd_fontPlus.TabStop = False
        Me.cmd_fontPlus.Text = "+"
        Me.cmd_fontPlus.UseVisualStyleBackColor = True
        '
        'tmr_refreshText
        '
        Me.tmr_refreshText.Enabled = True
        '
        'frm_textEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 354)
        Me.Controls.Add(Me.gb_texte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_textEditor"
        Me.Text = "pr0shop - Texteditor"
        Me.gb_texte.ResumeLayout(False)
        Me.gb_texte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_texte As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_header As System.Windows.Forms.Label
    Friend WithEvents txt_header As System.Windows.Forms.TextBox
    Friend WithEvents lbl_body1FontSize As System.Windows.Forms.Label
    Friend WithEvents rtb_body As System.Windows.Forms.RichTextBox
    Friend WithEvents cmd_fontMinus As System.Windows.Forms.Button
    Friend WithEvents lbl_body1 As System.Windows.Forms.Label
    Friend WithEvents cmd_fontPlus As System.Windows.Forms.Button
    Friend WithEvents tmr_refreshText As System.Windows.Forms.Timer
End Class
