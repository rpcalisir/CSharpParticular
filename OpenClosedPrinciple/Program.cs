using OpenClosedPrinciple.OCPLibrary;
using OpenClosedPrinciple.OCPLibrary.Concrete;
using OpenClosedPrinciple.OCPLibrary.Helper;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = GeneratePeople.GenerateMockedPeopleData();

            var employees = new List<Employee>();
            Accounts accountGenerator = new Accounts();

            foreach (var person in people)
            {
                employees.Add((Employee)accountGenerator.CreateAccount(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
