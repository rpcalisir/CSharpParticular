using EventsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsUI
{
    public partial class Transactions : Form
    {
        private Customer _customer;
        public Transactions(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            lblCustomerName.Text = _customer.CustomerName;

            //The reason using checkingAccount object's event is that checkingAccount is the main object
            //that we work on.
            _customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            lblError.Text = $"You have an overdraft";
            lblError.Visible = true;
        }

        //private void CheckingAccount_OverdraftEvent(object sender, decimal e)
        //{
        //    lblError.Text = $"You have an overdraft";
        //    lblError.Visible = true;
        //}

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            //This way it is not connected to checking account
            //Account account = new Account();
            //account.MakePayment("Card Purchase", Amount.Value, _customer.SavingsAccount);

            _customer.CheckingAccount.MakePayment("Card Purchase", Amount.Value, _customer.SavingsAccount);
            Amount.Value = 0;
        }
    }
}
