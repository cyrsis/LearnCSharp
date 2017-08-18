Public Class DataForm
    Private _source As New ObjectSource()
    Private _categoriesBindingSource As New BindingSource()
    Private _productsBindingSource As New BindingSource()

    Private Sub DataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _categoriesBindingSource.DataSource = _source.GetCategories()

        CategoryToolStripComboBox.ComboBox.DisplayMember = "CategoryName"
        CategoryToolStripComboBox.ComboBox.ValueMember = "CategoryID"
        CategoryToolStripComboBox.ComboBox.DataSource = _categoriesBindingSource

        ProductsDataGridView.DataSource = _productsBindingSource
        ProductsListBox.DataSource = _productsBindingSource
        ProductsListBox.DisplayMember = "ProductName"

        NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName")
        QuantityTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit")
        PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice")
        StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock")
        OrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder")
        DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued")
    End Sub

    Private Sub CategoryToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryToolStripComboBox.SelectedIndexChanged
        Dim catId = CategoryToolStripComboBox.ComboBox.SelectedValue
        _productsBindingSource.DataSource = _source.GetProducts(catId)
    End Sub

    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        Dim category = CType(CategoryToolStripComboBox.SelectedItem, Category)
        Dim form As New AddProductForm(category)
        Dim result = form.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            ' _source.AddProduct(form.Product)
            _productsBindingSource.Add(form.Product)
        End If
    End Sub

    Private Sub DeleteToolStripButton_Click(sender As Object, e As EventArgs) Handles DeleteToolStripButton.Click
        Dim product = CType(ProductsListBox.SelectedItem, Product)
        ' _source.DeleteProduct(product)
        _productsBindingSource.Remove(product)
    End Sub

    Private Sub BackToolStripButton_Click(sender As Object, e As EventArgs) Handles BackToolStripButton.Click
        _productsBindingSource.MovePrevious()
    End Sub

    Private Sub ForwardToolStripButton_Click(sender As Object, e As EventArgs) Handles ForwardToolStripButton.Click
        _productsBindingSource.MoveNext()
    End Sub

End Class
