using OpenClosedPrinciple.OCPLibrary;
using OpenClosedPrinciple.OCPLibrary.Helper;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = GeneratePeople.Generate();

            var employees = new List<Employee>();
            Accounts accountGenerator = new Accounts();

            foreach (var person in people)
            {
                employees.Add(accountGenerator.CreateAccount(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
