Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Oranges")
        ListBox1.Items.Add("Grapes")
        ListBox1.Items.Add("Bananas")
        ListBox1.Items.Add("Peaches")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ListBox1.Text
    End Sub
End Class
