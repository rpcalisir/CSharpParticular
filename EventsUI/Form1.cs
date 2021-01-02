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
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
            WrapUpForm();
        }

        private void LoadSampleData()
        {
            customer.CustomerName = "Recep Calisir";
            customer.CheckingAccount = new Account();
            customer.SavingsAccount = new Account();


            customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
            customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);
        }

        private void WrapUpForm()
        {
            lblCustomer.Text = customer.CustomerName;
            txtCheckingBalance.Text = string.Format("{0:C2}",customer.CheckingAccount.Balance);
            txtSavingBalance.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
            lstChecking.DataSource = customer.CheckingAccount.Transactions;
            lstSaving.DataSource = customer.SavingsAccount.Transactions;

            customer.CheckingAccount.TransactionCompleteEvent += CheckingAccount_TransactionCompleteEvent;
            customer.SavingsAccount.TransactionCompleteEvent += SavingsAccount_TransactionCompleteEvent;
        }

        private void SavingsAccount_TransactionCompleteEvent(object sender, string e)
        {
            lstSaving.DataSource = null;
            lstSaving.DataSource = customer.SavingsAccount.Transactions;
            txtSavingBalance.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void CheckingAccount_TransactionCompleteEvent(object sender, string e)
        {
            lstChecking.DataSource = null;
            lstChecking.DataSource = customer.CheckingAccount.Transactions;
            txtCheckingBalance.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void btnRecordTransaction_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(customer);
            transactions.Show();
        }
    }
}
