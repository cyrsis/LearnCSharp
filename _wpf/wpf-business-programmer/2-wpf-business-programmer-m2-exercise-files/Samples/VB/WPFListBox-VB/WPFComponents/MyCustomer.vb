Public Class MyCustomer
  Private mFirstName As String
  Private mLastName As String

  Public Property FirstName() As String
    Get
      Return (mFirstName)
    End Get
    Set(ByVal value As String)
      mFirstName = value
    End Set
  End Property

  Public Property LastName() As String
    Get
      Return (mLastName)
    End Get
    Set(ByVal value As String)
      mLastName = value
    End Set
  End Property

  Public ReadOnly Property FullName() As String
    Get
      Return (FirstName & " ") + LastName
    End Get
  End Property
End Class