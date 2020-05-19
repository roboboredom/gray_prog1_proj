Public Class Form1
    Dim tb_city_feedback = New String() {"Population: 872,498",
                                         "Population: 964,254",
                                         "Population: 51,111",
                                         "Population: 8.399 Million",
                                         "Population: 702,455"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_sel.Click
        Dim city As Integer = tb_city.Text 'WE ARE NOT GOING TO HANDLE INCORRECT INPUT AS IT TAKES TOO MUCH TIME
        Select Case city
            Case 1 'charlotte
                lbl_city.Text = tb_city_feedback(0) 'ARRAYS START AT 0, NOT 1
                pb_city.Image = My.Resources.charlotte
            Case 2 'austin
                lbl_city.Text = tb_city_feedback(1)
                pb_city.Image = My.Resources.austin
            Case 3 'bentonville
                lbl_city.Text = tb_city_feedback(2)
                pb_city.Image = My.Resources.bentonville
            Case 4 'new york
                lbl_city.Text = tb_city_feedback(3)
                pb_city.Image = My.Resources.nyc
            Case 5 'washington
                lbl_city.Text = tb_city_feedback(4)
                pb_city.Image = My.Resources.washington
        End Select
    End Sub
End Class
