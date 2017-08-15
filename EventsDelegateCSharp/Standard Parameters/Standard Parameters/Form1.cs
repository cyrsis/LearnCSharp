using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Standard_Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The bank account.
        private BankAccount MyAccount =
            new BankAccount() { Balance = 100 };

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
            MyAccount.Debited += MyAccount_Debited;
        }

        private void MyAccount_Debited(object sender, DebitedEventArgs e)
        {
            MessageBox.Show("Debited. New balance: " +
                e.Account.Balance.ToString("C"));
        }

        private void MyAccount_Overdrawn(object sender,
            OverdrawnEventArgs e)
        {
            //BankAccount account = sender as BankAccount;
            //MessageBox.Show("Balance: " +
            //    account.Balance.ToString("C"));

            MessageBox.Show("Balance: " +
                e.Account.Balance.ToString("C"));
        }
    }
}
