using OCPLibrary.Interface.AccountProcessor;
using OCPLibrary.Interface.Model;
using OCPLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.AccountProcessor
{
    public class ExecutiveAccount : IPersonAccount
    {
        public Employee CreateAccount(IParticipent person)
        {
            Employee employee = new Employee();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.LastName.ToLower()}{person.FirstName.ToLower()}@executive.com";

            employee.isManager = true;
            employee.isExecutive = true;

            return employee;
        }
    }
}
