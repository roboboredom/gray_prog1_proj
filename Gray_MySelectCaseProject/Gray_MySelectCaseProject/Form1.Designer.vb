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
        Me.pb_city = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_city = New System.Windows.Forms.TextBox()
        Me.btn_sel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_city = New System.Windows.Forms.Label()
        CType(Me.pb_city, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_city
        '
        Me.pb_city.BackColor = System.Drawing.Color.Azure
        Me.pb_city.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_city.Location = New System.Drawing.Point(415, 12)
        Me.pb_city.Name = "pb_city"
        Me.pb_city.Size = New System.Drawing.Size(501, 348)
        Me.pb_city.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_city.TabIndex = 0
        Me.pb_city.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is your favorite city?"
        '
        'tb_city
        '
        Me.tb_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.tb_city.Location = New System.Drawing.Point(287, 6)
        Me.tb_city.Name = "tb_city"
        Me.tb_city.Size = New System.Drawing.Size(122, 27)
        Me.tb_city.TabIndex = 2
        Me.tb_city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_sel
        '
        Me.btn_sel.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_sel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_sel.Location = New System.Drawing.Point(16, 39)
        Me.btn_sel.Name = "btn_sel"
        Me.btn_sel.Size = New System.Drawing.Size(393, 47)
        Me.btn_sel.TabIndex = 3
        Me.btn_sel.Text = "I have entered my favorite city #."
        Me.btn_sel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 140)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "===========================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 1 for Charlotte, NC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 2 for Austin, TX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Typ" & _
    "e 3 for Bentonville, AR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 4 for New York City, NY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Type 5 for Washington, DC" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "===========================" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_city
        '
        Me.lbl_city.BackColor = System.Drawing.Color.Azure
        Me.lbl_city.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.Location = New System.Drawing.Point(12, 235)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(397, 125)
        Me.lbl_city.TabIndex = 5
        Me.lbl_city.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(928, 377)
        Me.Controls.Add(Me.lbl_city)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_sel)
        Me.Controls.Add(Me.tb_city)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_city)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "My Select Case Project"
        CType(Me.pb_city, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_city As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_city As System.Windows.Forms.TextBox
    Friend WithEvents btn_sel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label

End Class
