<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_sign = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.lbl_horoscope = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_luckynumber = New System.Windows.Forms.Button()
        Me.lbl_luckynumber = New System.Windows.Forms.Label()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your zodiac sign:"
        '
        'cb_sign
        '
        Me.cb_sign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sign.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.cb_sign.FormattingEnabled = True
        Me.cb_sign.Items.AddRange(New Object() {"Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"})
        Me.cb_sign.Location = New System.Drawing.Point(257, 36)
        Me.cb_sign.Name = "cb_sign"
        Me.cb_sign.Size = New System.Drawing.Size(163, 28)
        Me.cb_sign.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.Bisque
        Me.btn_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_check.Location = New System.Drawing.Point(12, 74)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(230, 49)
        Me.btn_check.TabIndex = 3
        Me.btn_check.Text = "Check Horoscope"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'lbl_horoscope
        '
        Me.lbl_horoscope.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbl_horoscope.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_horoscope.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.lbl_horoscope.Location = New System.Drawing.Point(12, 136)
        Me.lbl_horoscope.Name = "lbl_horoscope"
        Me.lbl_horoscope.Size = New System.Drawing.Size(408, 116)
        Me.lbl_horoscope.TabIndex = 4
        Me.lbl_horoscope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 46)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Click here for your lucky number:"
        '
        'btn_luckynumber
        '
        Me.btn_luckynumber.BackColor = System.Drawing.Color.Thistle
        Me.btn_luckynumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_luckynumber.Location = New System.Drawing.Point(218, 276)
        Me.btn_luckynumber.Name = "btn_luckynumber"
        Me.btn_luckynumber.Size = New System.Drawing.Size(90, 46)
        Me.btn_luckynumber.TabIndex = 6
        Me.btn_luckynumber.Text = "[?]"
        Me.btn_luckynumber.UseVisualStyleBackColor = False
        '
        'lbl_luckynumber
        '
        Me.lbl_luckynumber.BackColor = System.Drawing.Color.LemonChiffon
        Me.lbl_luckynumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_luckynumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_luckynumber.Location = New System.Drawing.Point(314, 276)
        Me.lbl_luckynumber.Name = "lbl_luckynumber"
        Me.lbl_luckynumber.Size = New System.Drawing.Size(106, 46)
        Me.lbl_luckynumber.TabIndex = 7
        Me.lbl_luckynumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_img
        '
        Me.pb_img.BackColor = System.Drawing.Color.SlateBlue
        Me.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_img.Location = New System.Drawing.Point(443, 39)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(364, 283)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_img.TabIndex = 8
        Me.pb_img.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 351)
        Me.Controls.Add(Me.pb_img)
        Me.Controls.Add(Me.lbl_luckynumber)
        Me.Controls.Add(Me.btn_luckynumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_horoscope)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.cb_sign)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Daily Horoscope and Lucky Number"
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_sign As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents lbl_horoscope As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_luckynumber As System.Windows.Forms.Button
    Friend WithEvents lbl_luckynumber As System.Windows.Forms.Label
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox

End Class
