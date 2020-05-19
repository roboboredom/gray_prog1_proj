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
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.btn_newquestion = New System.Windows.Forms.Button()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.tb_answer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GetAHintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_curquestion = New System.Windows.Forms.Label()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pb_img
        '
        Me.pb_img.BackColor = System.Drawing.Color.LightGray
        Me.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_img.Cursor = System.Windows.Forms.Cursors.Help
        Me.pb_img.Location = New System.Drawing.Point(374, 52)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(363, 302)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_img.TabIndex = 0
        Me.pb_img.TabStop = False
        '
        'lbl_question
        '
        Me.lbl_question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_question.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_question.Location = New System.Drawing.Point(12, 95)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(356, 75)
        Me.lbl_question.TabIndex = 1
        Me.lbl_question.Text = "QUESTION HERE"
        Me.lbl_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_newquestion
        '
        Me.btn_newquestion.BackColor = System.Drawing.Color.Orange
        Me.btn_newquestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_newquestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newquestion.Location = New System.Drawing.Point(12, 52)
        Me.btn_newquestion.Name = "btn_newquestion"
        Me.btn_newquestion.Size = New System.Drawing.Size(356, 40)
        Me.btn_newquestion.TabIndex = 2
        Me.btn_newquestion.Text = "Get Random Question"
        Me.btn_newquestion.UseVisualStyleBackColor = False
        '
        'btn_check
        '
        Me.btn_check.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_check.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_check.Location = New System.Drawing.Point(12, 282)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(356, 72)
        Me.btn_check.TabIndex = 3
        Me.btn_check.Text = "Check Answer!"
        Me.btn_check.UseVisualStyleBackColor = False
        '
        'tb_answer
        '
        Me.tb_answer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_answer.Location = New System.Drawing.Point(12, 201)
        Me.tb_answer.Name = "tb_answer"
        Me.tb_answer.Size = New System.Drawing.Size(356, 27)
        Me.tb_answer.TabIndex = 4
        Me.tb_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Type answer here:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetAHintToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GetAHintToolStripMenuItem
        '
        Me.GetAHintToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon
        Me.GetAHintToolStripMenuItem.Name = "GetAHintToolStripMenuItem"
        Me.GetAHintToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.GetAHintToolStripMenuItem.Text = "Get A Hint"
        '
        'lbl_curquestion
        '
        Me.lbl_curquestion.AutoSize = True
        Me.lbl_curquestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curquestion.Location = New System.Drawing.Point(12, 95)
        Me.lbl_curquestion.Name = "lbl_curquestion"
        Me.lbl_curquestion.Size = New System.Drawing.Size(26, 17)
        Me.lbl_curquestion.TabIndex = 7
        Me.lbl_curquestion.Text = "#0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 365)
        Me.Controls.Add(Me.lbl_curquestion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_answer)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.btn_newquestion)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.pb_img)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Trivia Application"
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_question As System.Windows.Forms.Label
    Friend WithEvents btn_newquestion As System.Windows.Forms.Button
    Friend WithEvents btn_check As System.Windows.Forms.Button
    Friend WithEvents tb_answer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GetAHintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_curquestion As System.Windows.Forms.Label

End Class
