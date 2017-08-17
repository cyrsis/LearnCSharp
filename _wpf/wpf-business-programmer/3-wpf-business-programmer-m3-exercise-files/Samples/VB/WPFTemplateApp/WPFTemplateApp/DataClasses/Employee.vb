Public Class Employee
  Inherits ObjectBase
#Region "Private Variables"
  Private _EmployeeNumber As Integer = 0
  Private _FirstName As String = String.Empty
  Private _LastName As String = String.Empty
  Private _SSN As String = String.Empty
#End Region

#Region "Public Properties"
  Public Property EmployeeNumber() As Integer
    Get
      Return _EmployeeNumber
    End Get
    Set(ByVal value As Integer)
      If _EmployeeNumber <> value Then
        _EmployeeNumber = value
        RaisePropertyChanged("EmployeeNumber")
      End If
    End Set
  End Property

  Public Property FirstName() As String
    Get
      Return _FirstName
    End Get
    Set(ByVal value As String)
      If _FirstName <> value Then
        _FirstName = value
        RaisePropertyChanged("FirstName")
      End If
    End Set
  End Property

  Public Property LastName() As String
    Get
      Return _LastName
    End Get
    Set(ByVal value As String)
      If _LastName <> value Then
        _LastName = value
        RaisePropertyChanged("LastName")
      End If
    End Set
  End Property

  Public Property SSN() As String
    Get
      Return _SSN
    End Get
    Set(ByVal value As String)
      If _SSN <> value Then
        _SSN = value
        RaisePropertyChanged("SSN")
      End If
    End Set
  End Property
#End Region
End Class