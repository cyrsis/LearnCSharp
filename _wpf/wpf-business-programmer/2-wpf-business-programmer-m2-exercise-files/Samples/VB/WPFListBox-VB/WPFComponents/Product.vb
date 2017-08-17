Imports System.IO

Public Class Product
#Region "Private Variables"
  Private mProductId As Integer
  Private mProductName As String
  Private mPrice As Decimal
  Private mLogo As String
#End Region

#Region "Public Properties"
  Public Property ProductId() As Integer
    Get
      Return mProductId
    End Get
    Set(ByVal value As Integer)
      mProductId = value
    End Set
  End Property

  Public Property ProductName() As String
    Get
      Return mProductName
    End Get
    Set(ByVal value As String)
      mProductName = value
    End Set
  End Property

  Public Property Price() As Decimal
    Get
      Return mPrice
    End Get
    Set(ByVal value As Decimal)
      mPrice = value
    End Set
  End Property

  Public Property Logo() As String
    Get
      Return mLogo
    End Get
    Set(ByVal value As String)
      mLogo = value
    End Set
  End Property
#End Region

  Public Function GetProductCollection() As IEnumerable(Of Product)
    Dim ret As IEnumerable(Of Product) = Nothing
    Dim fileName As String

    fileName = WPFCommon.GetCurrentDirectory() & "\Xml\Product.xml"

    If File.Exists(fileName) Then
      ret = Product.GetProducts(fileName)
    End If

    Return ret
  End Function

  Public Shared Function GetProducts(ByVal fileName As String) As IEnumerable(Of Product)
    Dim elem As XElement = XElement.Load(fileName)

    Dim items = From prod In elem.Descendants("Product") _
        Select New Product() With { _
                    .ProductId = Convert.ToInt32(prod.Element("ProductId").Value), _
                    .ProductName = prod.Element("ProductName").Value, _
                    .Price = Convert.ToDecimal(prod.Element("Price").Value), _
                    .Logo = prod.Element("Logo").Value _
                  }

    Return items
  End Function
End Class