using System.Windows;
using PDSA.MessageBroker;

namespace Windows8Shell
{
  public partial class App : Application
  {
    /// <summary>
    /// Get/Set the Global Message Broker
    /// </summary>
    public PDSAMessageBroker MessageBroker { get; set; }

    public App()
    {
      MessageBroker = new PDSAMessageBroker();
    }
  }
}
