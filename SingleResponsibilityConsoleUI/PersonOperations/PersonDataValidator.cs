using SingleResponsibilityConsoleUI.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityConsoleUI.PersonOperations
{
    public class PersonDataValidator
    {
        public static bool Validate(Person person)
        {
            bool result = true;

            if(string.IsNullOrWhiteSpace(person.FirstName))
            {
                //Console.WriteLine("You didn't give us a valid first name!");
                StandardMessages.DisplayErrorMessage(nameof(person.FirstName));
                //*1*DisplayMessages.DisplayEndOfProgram();
                result = false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                //Console.WriteLine("You didn't give us a valid last name!");
                StandardMessages.DisplayErrorMessage(nameof(person.LastName));
                //*1*DisplayMessages.DisplayEndOfProgram();
                result = false;
            }
            return result;
        }
    }
}
