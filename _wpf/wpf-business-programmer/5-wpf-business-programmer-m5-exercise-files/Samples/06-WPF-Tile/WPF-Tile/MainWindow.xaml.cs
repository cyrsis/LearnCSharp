using System.Windows;

using PDSA.WPF;

namespace WPF_Tile
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void tile_Click(object sender, PDSATileEventArgs e)
    {
      tbText.Text = e.Text;
      tbViewName.Text = e.ViewName;
      tbImageUri.Text = e.ImageUri;
      tbToolTip.Text = e.ToolTip;
    }
  }
}
