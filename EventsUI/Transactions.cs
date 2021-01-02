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
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            bool isPurchased = _customer.CheckingAccount.MakePayment("CreditCardPayment", Amount.Value, _customer.SavingsAccount);
            Amount.Value = 0;
        }

        private void Transactions_Load(object sender, EventArgs e)
        {

        }
    }
}
