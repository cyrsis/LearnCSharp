Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Public Class LanguageDataType
  Private mName As String
  Private mLanguageDataTypes As ObservableCollection(Of DataType)

  Public Property Name() As String
    Get
      Return mName
    End Get
    Set(ByVal value As String)
      mName = value
    End Set
  End Property

  Public Property LanguageDataTypes() As ObservableCollection(Of DataType)
    Get
      Return mLanguageDataTypes
    End Get
    Set(ByVal value As ObservableCollection(Of DataType))
      mLanguageDataTypes = value
    End Set
  End Property

  Public Sub New()

  End Sub

  ' Constructor with Param Array
  Public Sub New(ByVal name As String, _
                 ByVal ParamArray dataType As DataType())
    Me.Name = name

    LanguageDataTypes = New ObservableCollection(Of DataType)()
    For Each dt As DataType In dataType
      LanguageDataTypes.Add(dt)
    Next
  End Sub

  Public Function CreateLanguageData() As ObservableCollection(Of LanguageDataType)
    Dim langDataType As New ObservableCollection(Of LanguageDataType)()

    langDataType.Add(New LanguageDataType("C#", New DataType(), New DataType(), New DataType(), New DataType()))

    langDataType.Add(New LanguageDataType("VB.NET", New DataType(), New DataType(), New DataType(), New DataType()))

    Return langDataType
  End Function
End Class