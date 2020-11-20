using OpenClosedPrinciple.OCPLibrary.Concrete;
using OpenClosedPrinciple.OCPLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary
{
    public class Accounts
    {
        public IEmployee CreateAccount(Person person)
        {
            IEmployee employee = new Employee
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.LastName.ToLower()}{person.FirstName.Substring(0, 2).ToLower()}@dormakaba.com"
            };

            employee.EmailAddress = new Regex("(.)\\1+").Replace(employee.EmailAddress, "$1");
            return employee;
        }

    }
}
