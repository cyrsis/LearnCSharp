Public Class MainForm

    Private _counter As Integer = 0

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        Dim childForm As New ChildForm()
        childForm.MdiParent = Me
        _counter += 1
        childForm.Text = "New Document " & _counter
        childForm.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Rich text files|*.rtf"
        Dim result = dialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Dim childForm As New ChildForm
            childForm.DocumentTextBox.LoadFile(dialog.FileName)
            childForm.Text = dialog.FileName
            childForm.MdiParent = Me
            childForm.Show()
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Me.ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)

            Dim dialog As New SaveFileDialog()
            dialog.Filter = "Rich text files|*.rtf"
            dialog.AddExtension = True
            Dim result = dialog.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                childForm.DocumentTextBox.SaveFile(dialog.FileName)
                childForm.Text = dialog.FileName
            End If
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.Undo()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.Redo()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click, CutToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.Cut()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, CopyToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click, PasteToolStripButton.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.Paste()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        If Me.ActiveMdiChild IsNot Nothing Then
            Dim childForm = CType(Me.ActiveMdiChild, ChildForm)
            childForm.DocumentTextBox.SelectAll()
        End If
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticallyToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

End Class
