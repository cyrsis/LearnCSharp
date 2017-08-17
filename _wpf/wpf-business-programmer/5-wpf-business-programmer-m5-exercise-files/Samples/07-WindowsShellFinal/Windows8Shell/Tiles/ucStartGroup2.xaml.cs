using System.Windows;
using System.Windows.Controls;

using PDSA.MessageBroker;
using PDSA.WPF;

namespace Windows8Shell
{
  public partial class ucStartGroup2 : UserControl
  {
    public ucStartGroup2()
    {
      InitializeComponent();
    }

    private void Tile_Click(object sender, PDSATileEventArgs e)
    {      
      // Send a message to main page to load the View specified 
      // in the tile's ViewName property.
      (Application.Current as App).MessageBroker.SendMessage(
        new PDSAMessageBrokerMessage(e.ViewName, null));
    }
  }
}
