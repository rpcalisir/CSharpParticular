using OCPLibrary.Interface.Model;
using OCPLibrary.Model;
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
            List<IParticipent> people = new List<IParticipent>()
            {
                new Person{FirstName = "Jack", LastName = "Perge"},
                new Manager{FirstName = "William", LastName = "Sands"},
                new Executive{FirstName = "Tim", LastName = "Spanks"},
            };

            List<Employee> employees = new List<Employee>();
            //Accounts accountManager = new Accounts();

            foreach (var person in people)
            {
                //employees.Add(accountManager.CreateAccount(person));
                employees.Add(person.accountProcessor.CreateAccount(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}  IsManager: {employee.isManager} IsExecutive: {employee.isExecutive}");
            }

            Console.ReadLine();
        }
    }
}
