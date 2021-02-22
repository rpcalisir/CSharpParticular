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
    public class ManagerAccount : IPersonAccount
    {
        public Employee CreateAccount(IParticipent person)
        {
            Employee employee = new Employee();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.LastName.ToLower()}{person.FirstName.Substring(0, 2).ToLower()}@manager.com";

            employee.isManager = true;

            return employee;
        }
    }
}
