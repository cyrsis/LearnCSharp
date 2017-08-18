Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ListView1.Columns.Add("Name", 250)
            ListView1.Columns.Add("Date modified", 150)
            ListView1.Columns.Add("Size", 75, HorizontalAlignment.Right)
            ViewToolStripComboBox.SelectedIndex = 0

            Dim docs As New TreeNode("My Documents")
            docs.Tag = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            TreeView1.Nodes.Add(docs)

            GetFolders(docs)
            docs.Expand()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim dir As New DirectoryInfo(e.Node.Tag)

        ListView1.Items.Clear()
        SmallImageList.Images.RemoveByKey(".exe")
        LargeImageList.Images.RemoveByKey(".exe")
        For Each file In dir.GetFiles()
            Dim item As New ListViewItem(file.Name)
            Dim lastWrite = file.LastWriteTime
            item.SubItems.Add(lastWrite.ToShortDateString() & " " & lastWrite.ToShortTimeString())
            item.SubItems.Add(Math.Ceiling(file.Length / 1024) & " KB")

            If Not LargeImageList.Images.ContainsKey(file.Extension) Then
                Dim thisIcon = Icon.ExtractAssociatedIcon(file.FullName)
                SmallImageList.Images.Add(file.Extension, thisIcon)
                LargeImageList.Images.Add(file.Extension, thisIcon)
            End If

            item.ImageKey = file.Extension
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub ViewToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ViewToolStripComboBox.SelectedIndexChanged
        Select Case ViewToolStripComboBox.Text
            Case "Large Icons"
                ListView1.View = View.LargeIcon
            Case "Small Icons"
                ListView1.View = View.SmallIcon
            Case "Details"
                ListView1.View = View.Details
        End Select
    End Sub

    Private Sub GetFolders(node As TreeNode)
        Dim dir As New DirectoryInfo(node.Tag)

        Try
            For Each childDir In dir.GetDirectories
                If childDir.Attributes.HasFlag(FileAttributes.Hidden) Then
                    Continue For
                End If

                Dim childNode As New TreeNode(childDir.Name)
                childNode.Tag = childDir.FullName
                node.Nodes.Add(childNode)

                GetFolders(childNode)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
