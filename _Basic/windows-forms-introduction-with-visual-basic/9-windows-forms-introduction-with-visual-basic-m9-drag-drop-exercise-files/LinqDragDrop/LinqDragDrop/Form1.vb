Public Class Form1

    Private _context As New NorthwindDataContext()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductBindingSource.DataSource = _context.Products
    End Sub

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        _context.SubmitChanges()
    End Sub
End Class
