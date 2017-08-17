using System.Windows;
using PDSA.MessageBroker;

namespace WPF_MessageBroker
{
  public partial class App : Application
  {
    public PDSAMessageBroker MessageBroker { get; set; }

    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      MessageBroker = new PDSAMessageBroker();
    }
  }
}
