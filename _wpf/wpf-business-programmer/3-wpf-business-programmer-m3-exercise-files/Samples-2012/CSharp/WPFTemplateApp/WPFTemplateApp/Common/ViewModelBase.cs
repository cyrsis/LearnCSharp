namespace WPFTemplateApp
{
  public enum UIStateMode
  {
    Normal,
    Edit,
    Add,
    Cancel
  }

  public class ViewModelBase : ObjectBase
  {
    #region Private Variables
    private bool _IsSaveEnabled = false;
    private bool _IsCancelEnabled = false;
    private bool _IsAddEnabled = true;
    private bool _IsAddMode = false;
    private UIStateMode _UIState = UIStateMode.Normal;
    #endregion

    #region Public Properties
    public bool IsSaveEnabled
    {
      get { return _IsSaveEnabled; }
      set
      {
        if (_IsSaveEnabled != value)
        {
          _IsSaveEnabled = value;
          RaisePropertyChanged("IsSaveEnabled");
        }
      }
    }

    public bool IsCancelEnabled
    {
      get { return _IsCancelEnabled; }
      set
      {
        if (_IsCancelEnabled != value)
        {
          _IsCancelEnabled = value;
          RaisePropertyChanged("IsCancelEnabled");
        }
      }
    }

    public bool IsAddEnabled
    {
      get { return _IsAddEnabled; }
      set
      {
        if (_IsAddEnabled != value)
        {
          _IsAddEnabled = value;
          RaisePropertyChanged("IsAddEnabled");
        }
      }
    }

    public bool IsAddMode
    {
      get { return _IsAddMode; }
      set
      {
        if (_IsAddMode != value)
        {
          _IsAddMode = value;
          RaisePropertyChanged("IsAddMode");
        }
      }
    }
    
    public UIStateMode UIState
    {
      get { return _UIState; }
      set
      {
        if (_UIState != value)
        {
          _UIState = value;
          SetViewStateMode();
          RaisePropertyChanged("UIState");
        }
      }
    }
    #endregion

    #region SetViewStateMode Methods
    public virtual void SetViewStateMode()
    {
      SetViewStateMode(this.UIState);
    }

    public virtual void SetViewStateMode(UIStateMode mode)
    {
      UIState = mode;
      switch (mode)
      {
        case UIStateMode.Normal:
          IsAddMode = false;
          IsCancelEnabled = false;
          IsSaveEnabled = false;
          IsAddEnabled = true;
          break;

        case UIStateMode.Edit:
          IsCancelEnabled = true;
          IsSaveEnabled = true;
          IsAddEnabled = false;
          break;

        case UIStateMode.Add:
          IsAddMode = true;
          IsCancelEnabled = true;
          IsSaveEnabled = true;
          IsAddEnabled = false;
          break;

        case UIStateMode.Cancel:
          IsAddMode = false;
          IsCancelEnabled = false;
          IsSaveEnabled = false;
          IsAddEnabled = true;
          break;

        default:
          break;
      }
    }
    #endregion
  }
}
