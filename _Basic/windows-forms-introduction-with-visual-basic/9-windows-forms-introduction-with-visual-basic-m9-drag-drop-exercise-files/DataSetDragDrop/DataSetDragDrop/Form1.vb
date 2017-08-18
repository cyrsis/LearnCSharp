Public Class Form1

    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)

    End Sub
End Class
