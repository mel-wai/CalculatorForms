Public Class Form1
    Dim n As Integer
    Dim S As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text)
        While S <= n
            Dim square As Integer = S * S
            S += 1
            ListBox1.Items.Add(square)
        End While
    End Sub
End Class
