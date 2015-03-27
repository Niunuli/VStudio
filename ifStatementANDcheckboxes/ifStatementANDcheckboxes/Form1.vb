Public Class Form1
    ' tutoriaali osoitteesta https://www.youtube.com/watch?v=wPtqEX6iQcQ
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.BackColor = Color.Red 'punainen loota jos checkattu
        Else
            Me.BackColor = Color.Blue 'sininen jos ei
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
    'jos checkbox2 checkattu, nappulaa painamalla avautuu lomake 2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
End Class
