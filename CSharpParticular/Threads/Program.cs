using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            //Initialize thread names and add into thread array. This creates threads and adds into array.
            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(bankAccount.MockingWithdraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            //Execute threads with starting them one by one.
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive: {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine("Current priority: {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} ending", Thread.CurrentThread.Name);

            Console.ReadLine();
        }
    }
}
