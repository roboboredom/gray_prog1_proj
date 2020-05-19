Public Class Form1
    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        tb_w1g.BackColor = Color.White 'RESET ERROR COLOR
        tb_w2g.BackColor = Color.White
        tb_w3g.BackColor = Color.White
        tb_w4g.BackColor = Color.White

        Dim iter_check = New String() {tb_w1g.Text, tb_w2g.Text, tb_w3g.Text, tb_w4g.Text} 'iter thru vals & check if valid input
        Dim isvalid As Boolean = True
        For iter As Integer = 0 To 3
            If Not IsNumeric(iter_check(iter)) Then
                isvalid = False
                Exit For
            End If
        Next

        If isvalid Then
            Dim avg As Single = (tb_w1g.Text + tb_w2g.Text + tb_w3g.Text + tb_w4g.Text) / 4.0F 'get average grade
            Dim letter_avg As Char = ""
            Select Case avg = avg 'grading scale is prob. not accurate to NC standard! 
                Case avg >= 90.0F
                    letter_avg = "A"
                Case avg <= 89.0F
                    letter_avg = "B"
                Case avg <= 79.0F
                    letter_avg = "C"
                Case avg <= 69.0F
                    letter_avg = "D"
                Case avg <= 59.0F
                    letter_avg = "F"
            End Select
            lbl_letterg.Text = letter_avg 'display output
            lbl_numg.Text = avg 'UNUSED
        Else
            tb_w1g.BackColor = Color.LightSalmon 'ERROR: INVALID INPUT
            tb_w2g.BackColor = Color.LightSalmon
            tb_w3g.BackColor = Color.LightSalmon
            tb_w4g.BackColor = Color.LightSalmon
            btn_calc.Text = "Calculate [INVALID INPUT; 0-100 ONLY]"
        End If
    End Sub

End Class
