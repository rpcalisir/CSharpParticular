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
    public class PersonAccount : IPersonAccount
    {
        /// <summary>
        /// Creates an email address from a person model
        /// </summary>
        /// <param name="person"></param>
        /// <returns>An employee model which contains FirstName, LastName, EmailAddress</returns>
        public Employee CreateAccount(IParticipent person)
        {
            Employee employee = new Employee();

            employee.FirstName = person.FirstName;
            employee.LastName = person.LastName;
            employee.EmailAddress = $"{person.LastName.ToLower()}{person.FirstName.Substring(0, 2).ToLower()}@gmail.com";

            return employee;
        }
    }
}
