using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary
{
    public class Accounts
    {
        public Employee Create(Person person)
        {
            Employee employee = new Employee();
            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.LastName}{person.FirstName.Substring(0,2)}@dormakaba.com";

            return employee;
        }
    }
}
