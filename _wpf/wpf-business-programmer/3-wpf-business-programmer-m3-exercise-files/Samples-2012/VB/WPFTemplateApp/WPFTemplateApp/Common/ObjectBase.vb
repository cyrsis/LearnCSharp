Imports System.ComponentModel
Imports System.Windows

Public Class ObjectBase
  Inherits DependencyObject
  Implements INotifyPropertyChanged

#Region "INotifyPropertyChanged"
  Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

  Protected Sub RaisePropertyChanged(ByVal propertyName As String)
    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
  End Sub
#End Region
End Class
