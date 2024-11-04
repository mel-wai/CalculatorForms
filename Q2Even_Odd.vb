Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Val(TextBox1.Text)
        For even As Integer = 2 To n Step 2
            ListBox1.Items.Add(even)
        Next
        For odd As Integer = 1 To n Step 2
            ListBox2.Items.Add(odd)
        Next
    End Sub
End Class
