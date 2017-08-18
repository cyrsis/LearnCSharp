Public Class DocForm

    Private Shared _counter As Integer = 1

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        CreateForm()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Rich text files|*.rtf"
        Dim result = dialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Me.DocumentTextBox.LoadFile(dialog.FileName)
            Me.Text = dialog.FileName
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Rich text files|*.rtf"
        dialog.AddExtension = True
        Dim result = dialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Me.DocumentTextBox.SaveFile(dialog.FileName)
            Me.Text = dialog.FileName
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click, CutToolStripButton.Click
        DocumentTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, CopyToolStripButton.Click
        DocumentTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click, PasteToolStripButton.Click
        DocumentTextBox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        DocumentTextBox.SelectAll()
    End Sub

    Private Sub WindowToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.DropDownOpening
        Dim menuItem = WindowToolStripMenuItem
        If menuItem.DropDownItems.Count > 0 Then
            menuItem.DropDown.Dispose()
        End If

        menuItem.DropDown = New ToolStripDropDown()
        For Each openForm As Form In My.Application.OpenForms
            Dim childItem As New ToolStripMenuItem()
            childItem.Text = openForm.Text
            childItem.Tag = openForm
            menuItem.DropDownItems.Add(childItem)
            AddHandler childItem.Click, AddressOf WindowMenuItemClick
        Next
    End Sub

    Private Sub WindowMenuItemClick(sender As Object, e As EventArgs)
        Dim menuItem = CType(sender, ToolStripMenuItem)
        Dim form = CType(menuItem.Tag, Form)
        form.Activate()
    End Sub

    Public Shared Function CreateForm() As DocForm
        Dim form As New DocForm()
        _counter += 1
        form.Text = "New Document " & _counter
        My.Application.ApplicationContext.MainForm = form
        form.Show()

        Return form
    End Function

End Class
