Public Class Form2

    Private _context As New NorthwindDataContext()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryBindingSource.DataSource = _context.Categories
    End Sub

    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        _context.SubmitChanges()
    End Sub
End Class