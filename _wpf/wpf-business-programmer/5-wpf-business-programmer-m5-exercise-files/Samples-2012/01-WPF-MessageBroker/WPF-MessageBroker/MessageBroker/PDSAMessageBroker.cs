
namespace PDSA.MessageBroker
{
  /// <summary>
  /// This class is responsible for receiving and sending messages to classes registered to receive those messages
  /// </summary>
  public class PDSAMessageBroker : IPDSAMessageBroker
  {
    #region SendMessage Method
    /// <summary>
    /// Call this method to send a message to any other objects that are asking to receive messages
    /// </summary>
    /// <param name="msg">A PDSAMessageBrokerMessage object that contains the message</param>
    public void SendMessage(PDSAMessageBrokerMessage msg)
    {
      PDSAMessageBrokerEventArgs args;

      args = new PDSAMessageBrokerEventArgs(msg.MessageName, msg);

      RaiseMessageReceived(args);
    }
    #endregion

    #region MessageReceived Event
    /// <summary>
    /// A Message Received Event
    /// </summary>
    public event MessageReceivedEventHandler MessageReceived;

    /// <summary>
    /// Raise the Message Received Event
    /// </summary>
    /// <param name="e">A PDSAMessageBrokerEventArgs object</param>
    protected void RaiseMessageReceived(PDSAMessageBrokerEventArgs e)
    {
      if (null != MessageReceived)
        MessageReceived(this, e);
    }
    #endregion
  }
}
