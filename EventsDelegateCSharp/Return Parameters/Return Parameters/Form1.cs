using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Parameters
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

            // Note: To allow a second event handler that always
            // disallows overdraft if balance is below -$100,
            // change the default value of AllowOverdraft to true.
            // Then be sure to register the new event handler 
            // before you register the existing one so the new
            // one executes first.
        }

        private void MyAccount_Overdrawn(object sender, OverdrawnEventArgs e)
        {
            if (!e.AllowOverdraft)
            {
                e.AllowOverdraft =
                    (MessageBox.Show(
                        "New Balance: " + e.NewBalance.ToString("C")
                        + ". Allow change?", "Allow Change?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes);
            }
        }
    }
}
