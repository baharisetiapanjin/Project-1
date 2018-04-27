Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, i, f, g, h, bobot, total As Single
        Dim grade As String
        a = txttugaskecil.Text
        b = txttugasbesar.Text
        c = txtuts.Text
        d = txtuas.Text
        i = txtbobotkecil.Text
        f = txtbobotbesar.Text
        g = txtbobotuts.Text
        h = txtbobotuas.Text

        bobot = i + f + g + h
        If bobot = 100 Then

            total = ((a * i) / 100) + ((b * f) / 100) + ((c * g) / 100) + ((d * h) / 100)
            txttotal.Text = total
            If total > 80 Then
                grade = "A"
            ElseIf total > 70 Then
                grade = "B"
            ElseIf total > 60 Then
                grade = "C"
            ElseIf total > 50 Then
                grade = "D"
            Else
                grade = "E"
            End If
            txtgrade.Text = grade
        Else
            MsgBox("Nilai Bobot Salah", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class