Imports System.Data.SqlClient

Public Class DataSetSource
    Implements ISource

    Private _dataSet As DataSet
    Private _productsAdapater As SqlDataAdapter
    Private _nextId As Integer = Integer.MaxValue

    Public Sub New()
        _dataSet = New DataSet

        Dim cn As New SqlConnection(My.Settings.NorthwindConnection)
        Dim cda As New SqlDataAdapter("Select CategoryID, CategoryName From Categories", cn)
        cda.Fill(_dataSet, "Categories")

        _productsAdapater = New SqlDataAdapter("Select * From Products", cn)
        Dim builder As New SqlCommandBuilder(_productsAdapater)
        _productsAdapater.Fill(_dataSet, "Products")
    End Sub

    Public Function GetCategories() As Object Implements ISource.GetCategories
        Dim table = _dataSet.Tables("Categories")
        Return table
    End Function

    Public Function GetProducts(categoryId As Integer) As Object Implements ISource.GetProducts
        Dim table = _dataSet.Tables("Products")
        table.DefaultView.RowFilter = "CategoryID = " & categoryId
        Return table
    End Function

    Public Sub AddProduct(bindingSource As BindingSource, product As Product) Implements ISource.AddProduct
        Dim table = _dataSet.Tables("Products")
        _nextId -= 1

        Dim row = table.NewRow()
        row("ProductId") = _nextId
        row("ProductName") = product.ProductName
        row("SupplierID") = 1
        row("CategoryID") = product.CategoryId
        row("QuantityPerUnit") = product.QuantityPerUnit
        row("UnitPrice") = product.UnitPrice
        row("UnitsInStock") = product.UnitsInStock
        row("UnitsOnOrder") = product.UnitsOnOrder
        row("ReorderLevel") = 0
        row("Discontinued") = product.Discontinued

        table.Rows.Add(row)
    End Sub

    Public Sub DeleteProduct(bindingSource As BindingSource, productId As Integer) Implements ISource.DeleteProduct
        Dim table = _dataSet.Tables("Products")
        Dim query = From p In table.AsEnumerable()
                    Where p.RowState <> DataRowState.Deleted AndAlso p.Field(Of Integer)("ProductID") = productId
                    Select p
        Dim row = query.Single()

        row.Delete()
    End Sub

    Public Sub Save() Implements ISource.Save
        Dim cn As SqlConnection = Nothing

        Try
            cn = New SqlConnection(My.Settings.NorthwindConnection)
            cn.Open()
            _productsAdapater.Update(_dataSet, "Products")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw
        Finally
            If cn IsNot Nothing Then
                cn.Dispose()
            End If
        End Try
    End Sub
End Class



