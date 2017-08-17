
namespace PDSA.MessageBroker
{
  /// <summary>
  /// This class is used to send a message to the PDSAMessageBroker instance
  /// You can inherit from this class and add additional properties so you can pass additional information with your messages
  /// </summary>
  public class PDSAMessageBrokerMessage
  {
    #region Constructors
    /// <summary>
    /// Constructor for PDSAMessageBrokerMessage class
    /// </summary>
    public PDSAMessageBrokerMessage()
    {
    }

    /// <summary>
    /// Constructor for PDSAMessageBrokerMessage class
    /// </summary>
    /// <param name="name">A Message Name</param>
    /// <param name="msg">The Message Body</param>
    public PDSAMessageBrokerMessage(string name, object msg)
    {
      MessageName = name;
      MessageBody = msg;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set a Unique Message Name
    /// </summary>
    public string MessageName { get; set; }
    /// <summary>
    /// Get/Set the Message Body
    /// </summary>
    public object MessageBody { get; set; }
    #endregion
  }
}
