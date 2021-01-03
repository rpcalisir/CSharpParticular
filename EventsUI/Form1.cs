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

            customer.CheckingAccount.TransactionCompletedEvent += CheckingAccount_TransactionCompletedEvent;
            customer.SavingsAccount.TransactionCompletedEvent += SavingsAccount_TransactionCompletedEvent;

            customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
            lblError.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e.AmountNeeded)}";
            e.StopOverdraft = cbxStopOverdraft.Checked;
            if (cbxStopOverdraft.Checked)
            {
                MessageBox.Show("Overdraft is not allowed!");
            }
            lblError.Visible = true;
        }

        //private void CheckingAccount_OverdraftEvent(object sender, decimal e)
        //{
        //    lblError.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e)}";
        //    lblError.Visible = true;
        //}

        private void CheckingAccount_TransactionCompletedEvent(object sender, string e)
        {
            lstChecking.DataSource = null;
            lstChecking.DataSource = customer.CheckingAccount.Transactions;
            txtCheckingBalance.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void SavingsAccount_TransactionCompletedEvent(object sender, string e)
        {
            lstSaving.DataSource = null;
            lstSaving.DataSource = customer.SavingsAccount.Transactions;
            txtSavingBalance.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void btnRecordTransaction_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(customer);
            transactions.Show();
        }

        private void lblError_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
