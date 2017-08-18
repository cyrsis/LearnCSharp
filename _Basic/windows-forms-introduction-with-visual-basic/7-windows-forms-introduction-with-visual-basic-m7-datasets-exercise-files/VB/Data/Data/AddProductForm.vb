Public Class AddProductForm
    Private _category As Category

    Public Sub New(category As Category)
        InitializeComponent()

        _category = Category
        CategoryTextBox.Text = _category.CategoryName
    End Sub

    Public ReadOnly Property Product As Product
        Get
            Dim result As New Product(0, NameTextBox.Text, _category.CategoryID, QuantityTextBox.Text, PriceTextBox.Text, StockTextBox.Text, OrderTextBox.Text, DiscontinuedCheckBox.Checked)
            Return result
        End Get
    End Property
End Class