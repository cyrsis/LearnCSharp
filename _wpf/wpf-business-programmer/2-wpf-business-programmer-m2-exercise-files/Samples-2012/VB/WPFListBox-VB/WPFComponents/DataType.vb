Public Class DataType
  Private mName As String

  Public Property Name() As String
    Get
      Return (mName)
    End Get
    Set(ByVal value As String)
      mName = value
    End Set
  End Property

  Public Function GetDataTypes(ByVal languageName As String) As IEnumerable(Of DataType)
    Dim xe As XElement
    Dim items As IEnumerable(Of DataType) = Nothing

    If languageName = "C#" Then
      xe = XElement.Load(WPFCommon.GetCurrentDirectory() & "\Xml\DataTypesCS.xml")
    ElseIf languageName = "VB.NET" Then
      xe = XElement.Load(WPFCommon.GetCurrentDirectory() & "\Xml\DataTypesVB.xml")
    Else
      xe = Nothing
    End If

    ' Always check for null because of design time problem
    If xe IsNot Nothing Then
      items = (From item In xe.Descendants("DataType") _
           Select New DataType())
    End If

    Return (items)
  End Function
End Class