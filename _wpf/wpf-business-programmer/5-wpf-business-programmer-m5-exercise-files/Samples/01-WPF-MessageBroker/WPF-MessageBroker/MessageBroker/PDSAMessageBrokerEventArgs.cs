using System;

namespace PDSA.MessageBroker
{
  /// <summary>
  /// Event args for passing data when raising event in PDSAMessageBroker
  /// </summary>
  public class PDSAMessageBrokerEventArgs : EventArgs
  {
    #region Constructors
    /// <summary>
    /// Constructor for PDSAMessageBrokerEventArgs class
    /// </summary>
    public PDSAMessageBrokerEventArgs()
    {
    }

    /// <summary>
    /// Constructor for PDSAMessageBrokerEventArgs class
    /// </summary>
    /// <param name="name">A Message Name</param>
    /// <param name="body">The Message Body</param>
    public PDSAMessageBrokerEventArgs(string name, PDSAMessageBrokerMessage body)
    {
      MessageName = name;
      Message = body;
    }
    #endregion

    #region Public Properties
    /// <summary>
    /// Get/Set a Unique Message Name
    /// </summary>
    public string MessageName { get; set; }
    /// <summary>
    /// Get/Set an instance of a PDSAMessageBrokerMessage object.
    /// </summary>
    public PDSAMessageBrokerMessage Message { get; set; }
    #endregion
  }
}
