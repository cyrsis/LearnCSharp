Public Class Form2

    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.NorthwindDataSet.Products)
        'TODO: This line of code loads data into the 'NorthwindDataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.NorthwindDataSet.Categories)

    End Sub
End Class