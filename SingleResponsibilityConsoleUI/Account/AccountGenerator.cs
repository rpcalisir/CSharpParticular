using SingleResponsibilityConsoleUI.PersonOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityConsoleUI.Account
{
    public class AccountGenerator
    {
        public static string CreateUserName(Person person)
        {
            return $"{person.LastName}{person.FirstName.Substring(0,2)}";
        }
    }
}
