Public Class WPFCommon
  Public Shared Function GetCurrentDirectory() As String
    Dim path As String = Nothing

    path = AppDomain.CurrentDomain.BaseDirectory
    If path.IndexOf("\bin") > 0 Then
      path = path.Substring(0, path.LastIndexOf("\bin"))
    End If

    Return path
  End Function
End Class