using OpenClosedPrinciple.OCPLibrary;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> applicants = new List<Person>()
            {
                new Person(){FirstName = "recep", LastName = "calisir"},
                new Person(){FirstName = "tim", LastName = "corey"}
            };

            Accounts accountProcessor = new Accounts();
            List<Employee> employees = new List<Employee>();

            foreach (var applicant in applicants)
            {
                employees.Add(accountProcessor.Create(applicant));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} : {employee.EmailAddress} ");
            }


            Console.ReadLine();
        }
    }
}
