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
        Me.tb_w1g = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_w4g = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_w3g = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_w2g = New System.Windows.Forms.TextBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_numg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_letterg = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_w1g
        '
        Me.tb_w1g.Location = New System.Drawing.Point(116, 27)
        Me.tb_w1g.Name = "tb_w1g"
        Me.tb_w1g.Size = New System.Drawing.Size(83, 22)
        Me.tb_w1g.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Week 1 Grade:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_w4g)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_w3g)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tb_w2g)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_w1g)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter your grades (0-100):"
        '
        'tb_w4g
        '
        Me.tb_w4g.Location = New System.Drawing.Point(116, 129)
        Me.tb_w4g.Name = "tb_w4g"
        Me.tb_w4g.Size = New System.Drawing.Size(83, 22)
        Me.tb_w4g.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Week 4 Grade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Week 3 Grade:"
        '
        'tb_w3g
        '
        Me.tb_w3g.Location = New System.Drawing.Point(116, 94)
        Me.tb_w3g.Name = "tb_w3g"
        Me.tb_w3g.Size = New System.Drawing.Size(83, 22)
        Me.tb_w3g.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Week 2 Grade:"
        '
        'tb_w2g
        '
        Me.tb_w2g.Location = New System.Drawing.Point(116, 60)
        Me.tb_w2g.Name = "tb_w2g"
        Me.tb_w2g.Size = New System.Drawing.Size(83, 22)
        Me.tb_w2g.TabIndex = 2
        '
        'btn_calc
        '
        Me.btn_calc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_calc.Location = New System.Drawing.Point(12, 204)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(218, 42)
        Me.btn_calc.TabIndex = 3
        Me.btn_calc.Text = "Calculate Letter Grade"
        Me.btn_calc.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lbl_numg)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_letterg)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 131)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(6, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Number Average:"
        '
        'lbl_numg
        '
        Me.lbl_numg.AutoSize = True
        Me.lbl_numg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_numg.Location = New System.Drawing.Point(133, 63)
        Me.lbl_numg.Name = "lbl_numg"
        Me.lbl_numg.Size = New System.Drawing.Size(18, 19)
        Me.lbl_numg.TabIndex = 10
        Me.lbl_numg.Text = "?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Letter Grade:"
        '
        'lbl_letterg
        '
        Me.lbl_letterg.AutoSize = True
        Me.lbl_letterg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_letterg.Location = New System.Drawing.Point(107, 30)
        Me.lbl_letterg.Name = "lbl_letterg"
        Me.lbl_letterg.Size = New System.Drawing.Size(18, 19)
        Me.lbl_letterg.TabIndex = 8
        Me.lbl_letterg.Text = "?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 270)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Test Grade 2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tb_w1g As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_w2g As System.Windows.Forms.TextBox
    Friend WithEvents tb_w4g As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_w3g As System.Windows.Forms.TextBox
    Friend WithEvents btn_calc As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_numg As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_letterg As System.Windows.Forms.Label

End Class
