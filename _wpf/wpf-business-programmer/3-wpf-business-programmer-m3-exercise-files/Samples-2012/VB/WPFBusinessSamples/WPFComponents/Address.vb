Imports System.Text

Public Class Address
  Public Property Street1 As String
  Public Property Street2 As String
  Public Property City As String
  Public Property State As String
  Public Property PostalCode As String

  Public Function GetAddress() As String
    Dim sb As New StringBuilder()

    sb.Append(Street1 & Environment.NewLine)
    sb.Append(Street2 & Environment.NewLine)
    sb.Append(City & ", " & State & "  " & PostalCode)

    Return sb.ToString()
  End Function

  Public Function CreateSample() As Address
    Dim addr As New Address()

    addr.Street1 = "17852 E. 17th Street"
    addr.Street2 = "Suite 205"
    addr.City = "Tustin"
    addr.State = "CA"
    addr.PostalCode = "92780"

    Return addr
  End Function
End Class