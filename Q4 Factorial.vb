Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim c As Integer
        Dim f As Long
        n = Val(TextBox1.Text)
        c = 1
        f = 1
        While c <= n
            f = f * c
            c = c + 1
        End While
        TextBox2.Text = f
    End Sub
End Class
