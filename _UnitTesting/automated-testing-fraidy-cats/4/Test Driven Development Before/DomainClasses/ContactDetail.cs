using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SalesModel.DomainClasses.Annotations;

namespace SalesModel.DomainClasses
{
  public class ContactDetail:StateInfo
  {
    private string _mobilePhone;
    private string _homePhone;
    private string _officePhone;
    private string _messenger;
    private string _skype;
    private string _linkedIn;
    private string _facebook;
    private string _twitterAlias;
    //private DateTime _modifiedDate;
    //private DateTime _twitterLastTweetDateRetrievedElsewhere;

    //public new DateTime ModifiedDate
    //{
    //  get {
    //    //return http://twitterAPI/MyLatestTweet.Date;
    //    return _twitterLastTweetDateRetrievedElsewhere;
    //  }
    //  set { _modifiedDate=value; }
    //}

    public int CustomerId { get; set; }
    public string MobilePhone
    {
      get { return _mobilePhone; }
      set
      {
        if (value == _mobilePhone) return;
        _mobilePhone = value;
        OnPropertyChanged();
      }
    }

    public string HomePhone
    {
      get { return _homePhone; }
      set
      {
        if (value == _homePhone) return;
        _homePhone = value;
        OnPropertyChanged();
      }
    }

    public string OfficePhone
    {
      get { return _officePhone; }
      set
      {
        if (value == _officePhone) return;
        _officePhone = value;
        OnPropertyChanged();
      }
    }

    public string TwitterAlias
    {
      get { return _twitterAlias; }
      set
      {
        if (value == _twitterAlias) return;
        _twitterAlias = value;
        OnPropertyChanged();
      }
    }

    public string Facebook
    {
      get { return _facebook; }
      set
      {
        if (value == _facebook) return;
        _facebook = value;
        OnPropertyChanged();
      }
    }

    public string LinkedIn
    {
      get { return _linkedIn; }
      set
      {
        if (value == _linkedIn) return;
        _linkedIn = value;
        OnPropertyChanged();
      }
    }

    public string Skype
    {
      get { return _skype; }
      set
      {
        if (value == _skype) return;
        _skype = value;
        OnPropertyChanged();
      }
    }

    public string Messenger
    {
      get { return _messenger; }
      set
      {
        if (value == _messenger) return;
        _messenger = value;
        OnPropertyChanged();
      }
    }
    public Customer Customer { get; set; }
  }
}