Public Class Form3

    Private _context As New NorthwindDataContext()

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CategoryBindingSource.DataSource = _context.Categories
    End Sub
End Class