Public Class Form1
    'https://www.youtube.com/watch?v=K46809Gw3Sc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Label2.Text = (TextBox1.Text)
    End Sub
End Class
