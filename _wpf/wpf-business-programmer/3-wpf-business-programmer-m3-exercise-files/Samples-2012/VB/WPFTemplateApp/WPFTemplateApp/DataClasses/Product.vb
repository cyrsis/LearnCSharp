Public Class Product
  Inherits ObjectBase
#Region "Private Variables"
  Private _ProductId As Integer = 0
  Private _ProductName As String = String.Empty
  Private _Price As Decimal = 0
  Private _IsActive As Boolean = True
#End Region

#Region "Public Properties"
  Public Property ProductId() As Integer
    Get
      Return _ProductId
    End Get
    Set(ByVal value As Integer)
      If _ProductId <> value Then
        _ProductId = value
        RaisePropertyChanged("ProductId")
      End If
    End Set
  End Property

  Public Property ProductName() As String
    Get
      Return _ProductName
    End Get
    Set(ByVal value As String)
      If _ProductName <> value Then
        _ProductName = value
        RaisePropertyChanged("ProductName")
      End If
    End Set
  End Property

  Public Property Price() As Decimal
    Get
      Return _Price
    End Get
    Set(ByVal value As Decimal)
      If _Price <> value Then
        _Price = value
        RaisePropertyChanged("Price")
      End If
    End Set
  End Property

  Public Property IsActive() As Boolean
    Get
      Return _IsActive
    End Get
    Set(ByVal value As Boolean)
      If _IsActive <> value Then
        _IsActive = value
        RaisePropertyChanged("IsActive")
      End If
    End Set
  End Property
#End Region
End Class