using System.Windows;
using PDSA.MessageBroker;

namespace WPF_MessageBroker
{
  public class Page2ViewModel
  {
    #region Constructor
    public Page2ViewModel()
    {
    }
    #endregion

    #region Message Broker Property
    private PDSAMessageBroker _MessageBroker = null;

    /// <summary>
    /// Get/Set a Message Broker to use to send messages
    /// Set this property from the page that is hooked to this View Model
    /// </summary>
    public PDSAMessageBroker MessageBroker
    {
      get { return _MessageBroker; }
      set
      {
        _MessageBroker = value;
        if(_MessageBroker != null)
          _MessageBroker.MessageReceived += 
            new MessageReceivedEventHandler(_MessageBroker_MessageReceived);
      }
    }
    #endregion

    void _MessageBroker_MessageReceived(object sender, PDSAMessageBrokerEventArgs e)
    {
      MessageBox.Show("Page 2 View Model");
      switch (e.MessageName)
      {
        case "SomeMessage":
          // Do something here

          break;
      }
    }

    #region DoSomething Method
    public void DoSomething()
    {
      PDSAMessageBrokerMessage arg = new PDSAMessageBrokerMessage();

      // Write some code to do something...


      // Send a message back to the ucPage2 User Control
      arg.MessageName = "FromPage2ViewModel";
      arg.MessageBody = "I am a message from View Model for Page 2";

      // Check to make sure the MessageBroker object was set.
      if (_MessageBroker != null)
      {
        _MessageBroker.SendMessage(arg);
      }
    }
    #endregion

    #region "Dispose" Method
    /// <summary>
    /// This is not a 'true' .NET 'Dispose' since we did not implement the 
    /// IDisposable interface, but since Dispose is well known, this tells
    /// a programmer to call this method when they are done with this class
    /// </summary>
    public void Dispose()
    {
      if(_MessageBroker != null)
        _MessageBroker.MessageReceived -= _MessageBroker_MessageReceived;
    }
    #endregion
  }
}
