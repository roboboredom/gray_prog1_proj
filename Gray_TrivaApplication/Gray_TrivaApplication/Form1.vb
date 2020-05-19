Public Class Form1
    Const q1 As String = "How many space shuttle missions were there?" 'QUESTIONS
    Const q2 As String = "How many days was the longest time spent by a human in space?"
    Const q3 As String = "What is the name of NASA's new Moon program?"

    Const q1a As String = "135" 'ANSWERS
    Const q2a As String = "438"
    Const q3a As String = "ARTEMIS"

    Const q1h As String = "What's 322 - 187?" 'HINTS
    Const q2h As String = "What's 480 - 42?"
    Const q3h As String = "It's also the name of a book by Andy Weir!"

    Dim cur_question As Integer
    Dim cur_hint As String
    Dim cur_answer As String

    Private Sub btn_newquestion_Click(sender As Object, e As EventArgs) Handles btn_newquestion.Click
        While 1 = 1 'GET RANDOM NEW QUESTION, PREVENT REPEATS!
            Randomize()
            Dim val As Integer = CInt(Int((3 * Rnd()) + 1))
            If val <> cur_question Then
                cur_question = val
                lbl_curquestion.Text = "#" + Conversion.Str(val)
                Select Case val
                    Case 1
                        pb_img.Image = My.Resources.shuttle
                        lbl_question.Text = q1
                        cur_answer = q1a
                        cur_hint = q1h
                    Case 2
                        pb_img.Image = My.Resources.mir
                        lbl_question.Text = q2
                        cur_answer = q2a
                        cur_hint = q2h
                    Case 3
                        pb_img.Image = My.Resources.artemis
                        lbl_question.Text = q3
                        cur_answer = q3a
                        cur_hint = q3h
                End Select
                Exit While
            End If
        End While
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        Dim answer As String = StrConv(tb_answer.Text, VbStrConv.Uppercase) 'CONVERNT ANS TO UPPERCASE
        If answer = cur_answer Then
            pb_img.Image = My.Resources.checkmark
        Else
            pb_img.Image = My.Resources.xmark
        End If
    End Sub

    Private Sub GetAHintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetAHintToolStripMenuItem.Click
        MessageBox.Show(cur_hint, "Hint for question #" + Conversion.Str(cur_question) + ":")
    End Sub
End Class
