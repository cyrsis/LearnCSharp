using System.Windows;
using System.Windows.Controls;
using PDSA.MessageBroker;

namespace WPF_MessageBroker
{
  public partial class ucPage1 : UserControl
  {
    public ucPage1()
    {
      InitializeComponent();

      // Hook to the Global Message Broker
      (Application.Current as App).MessageBroker.
        MessageReceived += new MessageReceivedEventHandler(
          MessageBroker_MessageReceived);
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {      
      // Send Status Message
      (Application.Current as App).MessageBroker.
        SendMessage(new PDSAMessageBrokerMessage("StatusBar", "This is Page 1"));
    }

    void MessageBroker_MessageReceived(object sender, PDSAMessageBrokerEventArgs e)
    {
      // Look for messages intended for Page 1
      switch (e.MessageName)
      {
        case "ForPage1":
          MessageBox.Show(e.Message.MessageBody.ToString());
          break;
      }
    }

    private void btnRaiseEvent_Click(object sender, RoutedEventArgs e)
    {
      PDSAMessageBrokerMessage arg = new PDSAMessageBrokerMessage();

      arg.MessageName = "FromPage1";
      arg.MessageBody = "Hello From Page 1";

      // Send a message
      (Application.Current as App).MessageBroker.SendMessage(arg);
    }

    private void UserControl_Unloaded(object sender, RoutedEventArgs e)
    {
      (Application.Current as App).MessageBroker.MessageReceived -=
        MessageBroker_MessageReceived;
    }
  }
}
