Imports System.Collections.ObjectModel
Imports System.Windows

Public Class EmployeeViewModel
  Inherits ViewModelBase
#Region "Constructor"
  Public Sub New()
    ' Make sure GetEmployees has great exception handling!
    DataCollection = _DataManager.GetEmployees()
  End Sub
#End Region

#Region "Private Variables"
  Private _DataManager As New EmployeeManager()
#End Region

#Region "DataCollection Property"
  Public Property DataCollection() As ObservableCollection(Of Employee)
    Get
      Return DirectCast(GetValue(DataCollectionProperty), ObservableCollection(Of Employee))
    End Get
    Set(ByVal value As ObservableCollection(Of Employee))
      SetValue(DataCollectionProperty, value)
    End Set
  End Property

  Public Shared ReadOnly DataCollectionProperty As DependencyProperty = DependencyProperty.Register("DataCollection", GetType(ObservableCollection(Of Employee)), GetType(EmployeeViewModel), New UIPropertyMetadata(Nothing))
#End Region

#Region "DetailData Property"
  Public Property DetailData() As Employee
    Get
      Return DirectCast(GetValue(DetailDataProperty), Employee)
    End Get
    Set(ByVal value As Employee)
      SetValue(DetailDataProperty, value)
    End Set
  End Property

  Public Shared ReadOnly DetailDataProperty As DependencyProperty = DependencyProperty.Register("DetailData", GetType(Employee), GetType(EmployeeViewModel), New UIPropertyMetadata(Nothing))
#End Region

#Region "AddRecord Method"
  Public Sub AddRecord()
    SetViewStateMode(UIStateMode.Add)

    ' Create Empty Object for UI to Display
    DetailData = New Employee()
  End Sub
#End Region

#Region "CancelEdit Method"
  Public Sub CancelEdit()
    SetViewStateMode(UIStateMode.Cancel)

    ' TODO: Write Code to Undo Here
  End Sub
#End Region

#Region "SaveData Method"
  Public Sub SaveData()
    If IsAddMode Then
      _DataManager.Insert(DetailData)
      DataCollection.Add(DetailData)
      SetViewStateMode(UIStateMode.Normal)
    Else
      _DataManager.Update(DetailData)
      SetViewStateMode(UIStateMode.Normal)
    End If
  End Sub
#End Region

#Region "DeleteData Method"
  Public Sub DeleteData()
    _DataManager.Delete(DetailData)
    DataCollection.Remove(DetailData)
    SetViewStateMode(UIStateMode.Normal)
  End Sub
#End Region
End Class