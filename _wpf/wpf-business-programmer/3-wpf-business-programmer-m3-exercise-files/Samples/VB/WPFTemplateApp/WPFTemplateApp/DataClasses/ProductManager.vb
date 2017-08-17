Imports System
Imports System.Collections.ObjectModel
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Xml.Linq

Public Class ProductManager
#Region "GetProducts Methods"
  Public Function GetProducts() As ObservableCollection(Of Product)
    Dim ret As ObservableCollection(Of Product)
    Dim fileName As String

    Try
      fileName = WPFCommon.GetCurrentDirectory() & "\Xml\Product.xml"

      If File.Exists(fileName) Then
        ret = GetProducts(fileName)
      Else
        ret = GetProductMocks()
      End If
    Catch ex As Exception
      Debug.WriteLine(ex.ToString())
      ' Still return some data
      ret = GetProductMocks()
    End Try

    Return ret
  End Function

  Protected Function GetProducts(ByVal fileName As String) As ObservableCollection(Of Product)
    Dim ret As ObservableCollection(Of Product)
    Dim elem As XElement = XElement.Load(fileName)

    Dim items = From prod In elem.Descendants("Product")
                Select New Product() With { _
     .ProductId = Convert.ToInt32(prod.Element("ProductId").Value), _
     .ProductName = prod.Element("ProductName").Value, _
     .Price = Convert.ToDecimal(prod.Element("Price").Value), _
     .IsActive = Convert.ToBoolean(prod.Element("IsActive").Value) _
    }

    ret = New ObservableCollection(Of Product)(items)

    Return ret
  End Function
#End Region

#Region "Insert Method"
  Public Function Insert(ByVal entity As Product) As Integer
    Dim ret As Integer = 0

    ' TODO: Insert Data Here

    Return ret
  End Function
#End Region

#Region "Update Method"
  Public Function Update(ByVal entity As Product) As Integer
    Dim ret As Integer = 0

    ' TODO: Update Data Here

    Return ret
  End Function
#End Region

#Region "Delete Method"
  Public Function Delete(ByVal entity As Product) As Integer
    Dim ret As Integer = 0

    ' TODO: Delete Data Here

    Return ret
  End Function
#End Region

#Region "Mock Data"
  Protected Overridable Function GetProductMocks() As ObservableCollection(Of Product)
    Dim entity As Product
    Dim ret As New ObservableCollection(Of Product)()

    entity = New Product()
    entity.ProductId = 1
    entity.ProductName = "(Mock) Product 1"
    entity.Price = 100
    entity.IsActive = True
    ret.Add(entity)

    entity = New Product()
    entity.ProductId = 2
    entity.ProductName = "(Mock) Product 2"
    entity.Price = 200
    entity.IsActive = True
    ret.Add(entity)

    entity = New Product()
    entity.ProductId = 3
    entity.ProductName = "(Mock) Product 3"
    entity.Price = 300
    entity.IsActive = False
    ret.Add(entity)

    Return ret
  End Function
#End Region
End Class