Imports System.Configuration

Public Class AppConfig
  Protected Shared Function GetConnectString(ByVal key As String) As String
    Return ConfigurationManager.ConnectionStrings(key).ConnectionString
  End Function

  Public Shared ReadOnly Property ConnectString() As String
    Get
      Return GetConnectString("WPFComponents.Properties.Settings.AdventureWorksLTConnectionString")
    End Get
  End Property
End Class