using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class BankAccount
    {
        private Object acctLock;

        public double Balance { get; set; }

        public BankAccount(double balance)
        {
            acctLock = new Object();
            Balance = balance;
        }

        public double Withdraw(double amount)
        {
            if ((Balance-amount)<0)
            {
                Console.WriteLine($"Sorry!!  ${Balance} in account");
                return Balance;
            }
            lock(acctLock)
            {
                if (Balance >= amount)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account", amount, (Balance-amount));
                    Balance -= amount;
                }
                return Balance;
            }
        }

        public void MockingWithdraw()
        {
            Withdraw(1);
        }
    }
}
