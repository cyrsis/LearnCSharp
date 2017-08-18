Public Class Product
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property CategoryId As Integer
    Public Property QuantityPerUnit As String
    Public Property UnitPrice As Decimal
    Public Property UnitsInStock As Integer
    Public Property UnitsOnOrder As Integer
    Public Property Discontinued As Boolean

    Public Sub New(id As Integer, name As String, categoryId As Integer, unitQuant As String, price As Decimal, inStock As Integer, onOrder As Integer, discontinued As Boolean)
        Me.ProductID = id
        Me.ProductName = name
        Me.CategoryId = categoryId
        Me.QuantityPerUnit = unitQuant
        Me.UnitPrice = price
        Me.UnitsInStock = inStock
        Me.UnitsOnOrder = onOrder
        Me.Discontinued = discontinued
    End Sub
End Class
