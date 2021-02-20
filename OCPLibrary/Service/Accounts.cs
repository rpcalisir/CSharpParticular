using OCPLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Service
{
    public class Accounts
    {
        public Employee CreateAccount(Person person)
        {
            Employee employee = new Employee();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.LastName.ToLower()}{person.FirstName.Substring(0,2).ToLower()}@gmail.com";

            return employee;
        }
    }
}
