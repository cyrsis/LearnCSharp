Public Class MyForm

    Private Sub ShowMessageButton_Click(sender As Object, e As EventArgs) Handles ShowMessageButton.Click
        MessageLabel.Text = MessageTextBox.Text
    End Sub
End Class
