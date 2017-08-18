using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple
{
    public class MyForm : Form
    {
        private TextBox MessageTextBox;
        private Button ShowMessageButton;
        private Label MessageLabel;

        public MyForm()
        {
            this.Text = "My Form";

            MessageTextBox = new TextBox();
            MessageTextBox.Left = 25;
            MessageTextBox.Top = 25;
            MessageTextBox.Width = 200;
            this.Controls.Add(MessageTextBox);

            ShowMessageButton = new Button();
            ShowMessageButton.Left = 25;
            ShowMessageButton.Top = 75;
            ShowMessageButton.Width = 200;
            ShowMessageButton.Text = "Show Message";
            this.Controls.Add(ShowMessageButton);
            ShowMessageButton.Click += ClickHandler;

            MessageLabel = new Label();
            MessageLabel.Left = 25;
            MessageLabel.Top = 125;
            MessageLabel.Width = 200;
            MessageLabel.Text = "[Label]";
            this.Controls.Add(MessageLabel);
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            MessageLabel.Text = MessageTextBox.Text;
        }
    }
}
