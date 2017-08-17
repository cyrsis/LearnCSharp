
namespace PDSA.Common
{
  public enum PDSAEditUIState
  {
    Normal,
    Edit,
    Exception,
    ValidationFailed
  }

  public class PDSAViewModelBase : PDSACommonBase
  {
    public PDSAViewModelBase()
    {
      SetUIState(PDSAEditUIState.Normal);
      TotalRecords = 0;
      SelectedIndex = 0;
      MessageToDisplay = string.Empty;
      LastExceptionMessage = string.Empty;
    }

    #region Private Variables
    private string _MessageToDisplay = string.Empty;
    private bool _IsMessageVisible = false;
    private bool _IsAddMode = false;
    private bool _IsListEnabled;
    private bool _ExceptionOccurred;
    private bool _ValidationFailed;
    private bool _IsAddEnabled;
    private bool _IsSaveEnabled;
    private bool _IsCancelEnabled;
    private bool _IsDetailAreaEnabled;
    private string _LastExceptionMessage;
    private string _ValidationRuleMessages;
    private int _SelectedIndex;
    private int _TotalRecords;
    #endregion

    #region Public Properties
    public string MessageToDisplay
    {
      get { return _MessageToDisplay; }
      set
      {
        _MessageToDisplay = value;
        RaisePropertyChanged("MessageToDisplay");
      }
    }

    public bool IsMessageVisible
    {
      get { return _IsMessageVisible; }
      set
      {
        _IsMessageVisible = value;
        RaisePropertyChanged("IsMessageVisible");
      }
    }

    public bool IsAddMode
    {
      get { return _IsAddMode; }
      set
      {
        _IsAddMode = value;
        RaisePropertyChanged("IsAddMode");
      }
    }

    public bool IsListEnabled
    {
      get { return _IsListEnabled; }
      set
      {
        _IsListEnabled = value;
        RaisePropertyChanged("IsListEnabled");
      }
    }

    public bool ExceptionOccurred
    {
      get { return _ExceptionOccurred; }
      set
      {
        _ExceptionOccurred = value;
        RaisePropertyChanged("ExceptionOccurred");
      }
    }

    public bool ValidationFailed
    {
      get { return _ValidationFailed; }
      set
      {
        _ValidationFailed = value;
        RaisePropertyChanged("ValidationFailed");
      }
    }

    public bool IsAddEnabled
    {
      get { return _IsAddEnabled; }
      set
      {
        _IsAddEnabled = value;
        RaisePropertyChanged("IsAddEnabled");
      }
    }

    public bool IsSaveEnabled
    {
      get { return _IsSaveEnabled; }
      set
      {
        _IsSaveEnabled = value;
        RaisePropertyChanged("IsSaveEnabled");
      }
    }

    public bool IsCancelEnabled
    {
      get { return _IsCancelEnabled; }
      set
      {
        _IsCancelEnabled = value;
        RaisePropertyChanged("IsCancelEnabled");
      }
    }

    public string LastExceptionMessage
    {
      get { return _LastExceptionMessage; }
      set
      {
        _LastExceptionMessage = value;
        RaisePropertyChanged("LastExceptionMessage");
      }
    }

    public string ValidationRuleMessages
    {
      get { return _ValidationRuleMessages; }
      set
      {
        _ValidationRuleMessages = value;
        RaisePropertyChanged("ValidationRuleMessages");
      }
    }

    public int TotalRecords
    {
      get { return _TotalRecords; }
      set
      {
        _TotalRecords = value;
        RaisePropertyChanged("TotalRecords");
      }
    }

    public bool IsDetailAreaEnabled
    {
      get { return _IsDetailAreaEnabled; }
      set
      {
        _IsDetailAreaEnabled = value;
        RaisePropertyChanged("IsDetailAreaEnabled");
      }
    }

    public int SelectedIndex
    {
      get { return _SelectedIndex; }
      set
      {
        _SelectedIndex = value;
        RaisePropertyChanged("SelectedIndex");
      }
    }
    #endregion

    public void SetUIState(PDSAEditUIState state)
    {
      switch (state)
      {
        case PDSAEditUIState.Normal:
          IsAddMode = false;
          IsListEnabled = true;
          ExceptionOccurred = false;
          ValidationFailed = false;
          IsDetailAreaEnabled = false;
          IsAddEnabled = true;
          IsSaveEnabled = false;
          IsCancelEnabled = false;

          break;

        case PDSAEditUIState.Edit:
          IsListEnabled = false;
          ExceptionOccurred = false;
          ValidationFailed = false;
          IsDetailAreaEnabled = true;
          IsAddEnabled = false;
          IsSaveEnabled = true;
          IsCancelEnabled = true;

          break;

        case PDSAEditUIState.Exception:
          IsListEnabled = false;
          ExceptionOccurred = true;
          ValidationFailed = false;
          IsDetailAreaEnabled = false;
          IsAddEnabled = false;
          IsSaveEnabled = false;
          IsCancelEnabled = false;

          break;

        case PDSAEditUIState.ValidationFailed:
          ValidationFailed = true;

          break;
      }
    }
  }
}
