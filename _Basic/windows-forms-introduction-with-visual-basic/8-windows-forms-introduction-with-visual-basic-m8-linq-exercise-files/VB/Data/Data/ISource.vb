Public Interface ISource
    Function GetCategories() As Object
    Function GetProducts(categoryId As Integer) As Object
    Function DeleteProduct(productId As Integer) As Boolean
    Function AddProduct(product As Product) As Boolean
    Sub Save()
End Interface
