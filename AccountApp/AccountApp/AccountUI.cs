using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountApp
{
    public partial class AccountUI : Form
    {
        private Account anAccount;
        private double amount;

        public AccountUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        { anAccount = new Account();
            anAccount.number = accountNumberTextBox.Text;
            anAccount.name = nameTextBox.Text;

            MessageBox.Show(@"Account has been created");

        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                amount = Convert.ToDouble(amounTextBox.Text);
                anAccount.Deposite(amount);
                MessageBox.Show(@"Ammonut has been deposited");
            }
            else
            {
                MessageBox.Show("Please create an account first");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {

                double amount = Convert.ToDouble(amounTextBox.Text);
                anAccount.Withdraw(amount);
                MessageBox.Show(@"Ammonut has been withdraw");
            }
            else
            {
                MessageBox.Show("please create an account first and deposite some money");
            }
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.GetReport());
        }
    }
}
