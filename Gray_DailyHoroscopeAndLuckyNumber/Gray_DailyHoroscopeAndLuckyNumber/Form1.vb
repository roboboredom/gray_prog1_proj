Public Class Form1

    Private Sub btn_luckynumber_Click(sender As Object, e As EventArgs) Handles btn_luckynumber.Click
        Randomize()
        Dim val As Integer = CInt(Int((100 * Rnd()) + 1))
        lbl_luckynumber.Text = val
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim zsign As String = cb_sign.Text
        Dim pred = New String() {"You will have a great day at work and home today!",
                                 "You will be eaten by a monster at work today!",
                                 "A meteor will land on your car today!",
                                 "You will be given a suprise quiz at school today!"}
        Dim pred_n As Integer = 0 'im so bored........
        Select Case zsign
            Case "Aries" 'RANDOM string, who cares
                pred_n = 0
            Case "Taurus"
                pred_n = 1
            Case "Gemini"
                pred_n = 2
            Case "Cancer"
                pred_n = 3
            Case "Leo"
                pred_n = 0
            Case "Virgo"
                pred_n = 1
            Case "Libra"
                pred_n = 2
            Case "Scorpio"
                pred_n = 3
            Case "Sagittarius"
                pred_n = 0
            Case "Capricorn"
                pred_n = 1
            Case "Aquarius"
                pred_n = 2
            Case "Pisces"
                pred_n = 3
        End Select
        lbl_horoscope.Text = pred(pred_n)
        Randomize()
        Dim val As Integer = CInt(Int((3 * Rnd()) + 1)) '1n4 chance of danger symbol, looks convincing enough -w-
        If val = 1 Then
            pb_img.Image = My.Resources.download
        Else
            pb_img.Image = My.Resources._1200px_Checkmark_green_svg
        End If
    End Sub

    Private Sub pb_img_Click(sender As Object, e As EventArgs) Handles pb_img.Click

    End Sub
End Class
