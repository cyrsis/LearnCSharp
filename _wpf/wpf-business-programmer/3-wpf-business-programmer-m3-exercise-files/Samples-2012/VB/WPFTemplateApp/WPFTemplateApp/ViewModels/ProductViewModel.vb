Imports System.Collections.ObjectModel
Imports System.Windows

Public Class ProductViewModel
  Inherits ViewModelBase
#Region "Constructor"
  Public Sub New()
    ' Make sure GetProducts has great exception handling!
    DataCollection = _DataManager.GetProducts()
  End Sub
#End Region

#Region "Private Variables"
  Private _DataManager As New ProductManager()
#End Region

#Region "DataCollection Property"
  Public Property DataCollection() As ObservableCollection(Of Product)
    Get
      Return DirectCast(GetValue(DataCollectionProperty), ObservableCollection(Of Product))
    End Get
    Set(ByVal value As ObservableCollection(Of Product))
      SetValue(DataCollectionProperty, value)
    End Set
  End Property

  Public Shared ReadOnly DataCollectionProperty As DependencyProperty = DependencyProperty.Register("DataCollection", GetType(ObservableCollection(Of Product)), GetType(ProductViewModel), New UIPropertyMetadata(Nothing))
#End Region

#Region "DetailData Property"
  Public Property DetailData() As Product
    Get
      Return DirectCast(GetValue(DetailDataProperty), Product)
    End Get
    Set(ByVal value As Product)
      SetValue(DetailDataProperty, value)
    End Set
  End Property

  Public Shared ReadOnly DetailDataProperty As DependencyProperty = DependencyProperty.Register("DetailData", GetType(Product), GetType(ProductViewModel), New UIPropertyMetadata(Nothing))
#End Region

#Region "AddRecord Method"
  Public Sub AddRecord()
    SetViewStateMode(UIStateMode.Add)

    ' Create Empty Object for UI to Display
    DetailData = New Product()
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