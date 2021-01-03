using System;
using System.Collections.Generic;

namespace EventsLibrary
{
    public class Account
    {
        private readonly List<string> _transactions = new List<string>();
        //the reason of private set is letting change on this property only inside of this class.
        public decimal Balance { get; private set; }

        public event EventHandler<string> TransactionCompletedEvent;
        //public event EventHandler<decimal> OverdraftEvent;
        public event EventHandler<OverdraftEventArgs> OverdraftEvent;

        public IReadOnlyList<string> Transactions 
        {
            get
            {
                return _transactions.AsReadOnly();
            }
        }
        /// <summary>
        /// Adds money into checking account
        /// </summary>
        /// <param name="depositName"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited {string.Format("{0:C2}",amount)} for {depositName}");
            Balance += amount;
            TransactionCompletedEvent?.Invoke(this, depositName);
            return true;
        }
        /// <summary>
        /// Substracts the specified amount from Checking Account.
        /// If balance is not enough in Checking Account, then it checks Saving Account.
        /// backupAccount = null specifies this argument is optional.
        /// </summary>
        /// <param name="paymentName"></param>
        /// <param name="amount"></param>
        /// <param name="backupAccount"></param>
        /// <returns></returns>
        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            //If Checking Account balance is enough to pay
            if (Balance>=amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}",amount)} for {paymentName}");
                Balance -= amount;
                TransactionCompletedEvent?.Invoke(this, paymentName);
                return true;
            }
            else//Look for saving account balance to transfer into checking account
            {
                if (backupAccount != null)
                {
                    if ((Balance + backupAccount.Balance) >= amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        OverdraftEventArgs args = new OverdraftEventArgs(amountNeeded, "Extra Info");
                        OverdraftEvent?.Invoke(this, args);

                        if (args.StopOverdraft)
                        {
                            return false;
                        }

                        //backupAccount object will run it's MakePayment method with it's own Balance property.
                        //This way it will make transaction up above in the first if
                        bool isTransferSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);

                        //This check is redundant, because if backupAccount.Balance is not enough, then it would
                        //not enter in this if in the first place.
                        if (!isTransferSucceeded)
                        {
                            return false;
                        }

                        //Adding balance into checking account from saving account after checking it is enough
                        //and making transaction from saving account with displayin it.
                        AddDeposit("Overdraft Protection", amountNeeded);
                        

                        //Finally making the payment
                        _transactions.Add($"Withdrew {string.Format("{0:C2}",amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionCompletedEvent?.Invoke(this, paymentName);
                        return true;
                    }
                    else//if total balance of saving and checking is not enough to pay
                    {
                        return false;
                    }
                }
                else//if there is no saving account
                {
                    return false;
                }
            }
        }
    }
}
