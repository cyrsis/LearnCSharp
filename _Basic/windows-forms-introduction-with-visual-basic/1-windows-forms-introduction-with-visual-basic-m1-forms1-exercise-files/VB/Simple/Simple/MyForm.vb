Imports System.Windows.Forms

Public Class MyForm
    Inherits Form

    Private MessageTextBox As TextBox
    Private MessageLabel As Label
    Private WithEvents ShowMessageButton As Button

    Public Sub New()
        Me.Text = "My Form"

        MessageTextBox = New TextBox()
        MessageTextBox.Left = 25
        MessageTextBox.Top = 25
        MessageTextBox.Width = 200
        Me.Controls.Add(MessageTextBox)

        ShowMessageButton = New Button()
        ShowMessageButton.Left = 25
        ShowMessageButton.Top = 75
        ShowMessageButton.Width = 200
        ShowMessageButton.Text = "Show Message"
        Me.Controls.Add(ShowMessageButton)

        MessageLabel = New Label()
        MessageLabel.Left = 25
        MessageLabel.Top = 125
        MessageLabel.Width = 200
        MessageLabel.Text = "[Label]"
        Me.Controls.Add(MessageLabel)
    End Sub

    Private Sub ClickHandler(sender As Object, e As EventArgs) Handles ShowMessageButton.Click
        MessageLabel.Text = MessageTextBox.Text
    End Sub
End Class

