using OCPLibrary.Model;
using OCPLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person{FirstName = "Jack", LastName = "Perge"},
                new Person{FirstName = "William", LastName = "Sands"},
                new Person{FirstName = "Tim", LastName = "Spanks"},
            };

            List<Employee> employees = new List<Employee>();
            Accounts accountManager = new Accounts();

            foreach (var person in people)
            {
                employees.Add(accountManager.CreateAccount(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
