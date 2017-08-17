Public Enum UIStateMode
  Normal
  Edit
  Add
  Cancel
End Enum

Public Class ViewModelBase
  Inherits ObjectBase
#Region "Private Variables"
  Private _IsSaveEnabled As Boolean = False
  Private _IsCancelEnabled As Boolean = False
  Private _IsAddEnabled As Boolean = True
  Private _IsAddMode As Boolean = False
  Private _UIState As UIStateMode = UIStateMode.Normal
#End Region

#Region "Public Properties"
  Public Property IsSaveEnabled() As Boolean
    Get
      Return _IsSaveEnabled
    End Get
    Set(ByVal value As Boolean)
      If _IsSaveEnabled <> value Then
        _IsSaveEnabled = value
        RaisePropertyChanged("IsSaveEnabled")
      End If
    End Set
  End Property

  Public Property IsCancelEnabled() As Boolean
    Get
      Return _IsCancelEnabled
    End Get
    Set(ByVal value As Boolean)
      If _IsCancelEnabled <> value Then
        _IsCancelEnabled = value
        RaisePropertyChanged("IsCancelEnabled")
      End If
    End Set
  End Property

  Public Property IsAddEnabled() As Boolean
    Get
      Return _IsAddEnabled
    End Get
    Set(ByVal value As Boolean)
      If _IsAddEnabled <> value Then
        _IsAddEnabled = value
        RaisePropertyChanged("IsAddEnabled")
      End If
    End Set
  End Property

  Public Property IsAddMode() As Boolean
    Get
      Return _IsAddMode
    End Get
    Set(ByVal value As Boolean)
      If _IsAddMode <> value Then
        _IsAddMode = value
        RaisePropertyChanged("IsAddMode")
      End If
    End Set
  End Property

  Public Property UIState() As UIStateMode
    Get
      Return _UIState
    End Get
    Set(ByVal value As UIStateMode)
      If _UIState <> value Then
        _UIState = value
        SetViewStateMode()
        RaisePropertyChanged("UIState")
      End If
    End Set
  End Property
#End Region

#Region "SetViewStateMode Methods"
  Public Overridable Sub SetViewStateMode()
    SetViewStateMode(Me.UIState)
  End Sub

  Public Overridable Sub SetViewStateMode(ByVal mode As UIStateMode)
    UIState = mode
    Select Case mode
      Case UIStateMode.Normal
        IsAddMode = False
        IsCancelEnabled = False
        IsSaveEnabled = False
        IsAddEnabled = True
        Exit Select

      Case UIStateMode.Edit
        IsCancelEnabled = True
        IsSaveEnabled = True
        IsAddEnabled = False
        Exit Select

      Case UIStateMode.Add
        IsAddMode = True
        IsCancelEnabled = True
        IsSaveEnabled = True
        IsAddEnabled = False
        Exit Select

      Case UIStateMode.Cancel
        IsAddMode = False
        IsCancelEnabled = False
        IsSaveEnabled = False
        IsAddEnabled = True
        Exit Select
      Case Else

        Exit Select
    End Select
  End Sub
#End Region
End Class
