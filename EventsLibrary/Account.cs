using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibrary
{
    public class Account
    {
        public decimal Balance { get; private set; }
        private readonly List<string> _transactions = new List<string>();

        public event EventHandler<string> TransactionCompleteEvent;

        public IReadOnlyList<string> Transactions {
            get
            {
                return _transactions.AsReadOnly();
            }
        }

        public bool AddDeposit(string depositName, decimal amount)
        {
            _transactions.Add($"Deposited {string.Format("{0:C2}", amount)} for {depositName}");
            Balance += amount;
            TransactionCompleteEvent?.Invoke(this, depositName);
            return true;
        }

        public bool MakePayment(string paymentName, decimal amount, Account backupAccount = null)
        {
            if (Balance >= amount)
            {
                _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                Balance -= amount;
                TransactionCompleteEvent?.Invoke(this, paymentName);
                return true;
            }
            else
            {
                if (backupAccount != null)
                {
                    if ((backupAccount.Balance + Balance) >= amount)
                    {
                        decimal amountNeeded = amount - Balance;
                        //When backupAccount object's MakePayment method is called, it's Balance property is being
                        //processed as Balance, meaning it's Balance is becoming actual Balance
                        bool overdraftSucceeded = backupAccount.MakePayment("Overdraft Protection", amountNeeded);
                        if (!overdraftSucceeded)
                        {
                            return false;
                        }

                        AddDeposit("Overdraft Protection Deposit", amountNeeded);
                        _transactions.Add($"Withdrew {string.Format("{0:C2}", amount)} for {paymentName}");
                        Balance -= amount;
                        TransactionCompleteEvent?.Invoke(this, paymentName);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
