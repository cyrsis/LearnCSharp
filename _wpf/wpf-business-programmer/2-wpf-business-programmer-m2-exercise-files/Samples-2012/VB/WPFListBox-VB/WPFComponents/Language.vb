Public Class Language
  Private mName As String

  Public Property Name() As String
    Get
      Return mName
    End Get
    Set(ByVal value As String)
      mName = value
    End Set
  End Property

  Public Function GetLanguages() As IEnumerable(Of Language)
    Dim xe As XElement = Nothing
    Dim items As IEnumerable(Of Language) = Nothing

    Try
      xe = XElement.Load(WPFCommon.GetCurrentDirectory() & "\Xml\Languages.xml")
    Catch
      ' Ignore exceptions
    End Try

    ' Always check for null because of design time problem
    If xe IsNot Nothing Then
      items = (From item In xe.Descendants("Language") _
         Select New Language())
    End If

    Return items
  End Function
End Class