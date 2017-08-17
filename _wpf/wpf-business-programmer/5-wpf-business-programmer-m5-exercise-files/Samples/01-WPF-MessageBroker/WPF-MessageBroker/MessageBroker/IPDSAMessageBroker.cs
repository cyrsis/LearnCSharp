
namespace PDSA.MessageBroker
{
  #region Delegate for MessageReceivedEventHandler
  /// <summary>
  /// The delegate declaration of the MessageReceived Event Handler
  /// </summary>
  /// <param name="sender">The object raising the event</param>
  /// <param name="e">A PDSAMessageBrokerEventArgs object that contains the message</param>
  public delegate void MessageReceivedEventHandler(object sender, PDSAMessageBrokerEventArgs e);
  #endregion

  /// <summary>
  /// Interface for the PDSAMessageBroker object
  /// </summary>
  public interface IPDSAMessageBroker
  {
    /// <summary>
    /// Call this method to send a message to any other objects that are asking to receive messages 
    /// </summary>
    /// <param name="msg">A PDSAMessageBrokerMessage object that contains the message</param>
    void SendMessage(PDSAMessageBrokerMessage msg);
    /// <summary>
    /// Event to raise when a message is received.
    /// </summary>
    event MessageReceivedEventHandler MessageReceived;
  }
}
