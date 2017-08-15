using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overdraft_Account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The bank account.
        private OverdraftAccount MyAccount =
            new PremierAccount() { Balance = 100 };

        // Adjust the account's balance.
        private void adjustButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(amountTextBox.Text);
            MyAccount.Balance += amount;
            balanceLabel.Text = "Balance: " +
                MyAccount.Balance.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyAccount.Overdrawn += MyAccount_Overdrawn;
            MyAccount.OverdraftCovered += MyAccount_OverdraftCovered;
        }

        private void MyAccount_OverdraftCovered(object sender, OverdrawnEventArgs e)
        {
            MessageBox.Show("Overdraft Covered: " +
                e.Account.Balance.ToString("C"));
        }

        private void MyAccount_Overdrawn(object sender, OverdrawnEventArgs e)
        {
            MessageBox.Show("Overdrawn Balance: " +
                e.Account.Balance.ToString("C"));
        }
    }
}
