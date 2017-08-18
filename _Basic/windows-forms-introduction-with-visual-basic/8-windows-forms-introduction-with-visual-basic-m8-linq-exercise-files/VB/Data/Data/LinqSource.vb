Public Class LinqSource
    Implements ISource

    Public Function GetCategories() As Object Implements ISource.GetCategories
        Dim result As Object

        Using context As New NorthwindDataContext
            result = context.LinqCategories.ToList()
        End Using

        Return result
    End Function

    Public Function GetProducts(categoryId As Integer) As Object Implements ISource.GetProducts
        Dim result As Object

        Using context As New NorthwindDataContext
            Dim query = From p In context.LinqProducts
                        Where p.CategoryID = categoryId
                        Select p

            result = query.ToList()
        End Using

        Return result
    End Function

    Public Function AddProduct(product As Product) As Boolean Implements ISource.AddProduct
        Using context As New NorthwindDataContext
            Dim linqProduct As New LinqProduct()
            linqProduct.ProductName = product.ProductName
            linqProduct.SupplierID = 1
            linqProduct.CategoryID = product.CategoryId
            linqProduct.QuantityPerUnit = product.QuantityPerUnit
            linqProduct.UnitPrice = product.UnitPrice
            linqProduct.UnitsInStock = product.UnitsInStock
            linqProduct.UnitsOnOrder = product.UnitsOnOrder
            linqProduct.ReorderLevel = 0
            linqProduct.Discontinued = product.Discontinued

            context.LinqProducts.InsertOnSubmit(linqProduct)
            Save(context)
        End Using

        Return True
    End Function

    Public Function DeleteProduct(productId As Integer) As Boolean Implements ISource.DeleteProduct
        Using context As New NorthwindDataContext
            Dim query = From p In context.LinqProducts
                        Where p.ProductID = productId
                        Select p
            Dim linqProduct = query.Single()

            context.LinqProducts.DeleteOnSubmit(linqProduct)
            Save(context)
        End Using

        Return True
    End Function

    Public Sub Save() Implements ISource.Save
        Using context As New NorthwindDataContext
            Save(context)
        End Using
    End Sub

    Private Sub Save(context As NorthwindDataContext)
        Try
            context.SubmitChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        End Try
    End Sub
End Class

