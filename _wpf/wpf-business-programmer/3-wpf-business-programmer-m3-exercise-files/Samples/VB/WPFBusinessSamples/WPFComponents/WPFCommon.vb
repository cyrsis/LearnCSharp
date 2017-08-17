Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Markup
Imports System.IO

Public Class WPFCommon
  Public Shared Sub LoadSamplesResource(ByVal frm As Window, ByVal fileName As String)
    Dim dic As ResourceDictionary = Nothing

    If File.Exists(fileName) Then
      Using fs As New FileStream(fileName, FileMode.Open)
        dic = DirectCast(XamlReader.Load(fs), ResourceDictionary)
        frm.Resources.MergedDictionaries.Add(dic)
      End Using
    Else
      Throw New ApplicationException("Can't open resource file: " & fileName & " in the method PDSASamples.LoadSamplesResource().")
    End If
  End Sub

  Public Shared Function GetCurrentDirectory() As String
    Dim path As String = Nothing

    path = AppDomain.CurrentDomain.BaseDirectory
    If path.IndexOf("\bin") > 0 Then
      path = path.Substring(0, path.LastIndexOf("\bin"))
    End If

    Return path
  End Function
End Class