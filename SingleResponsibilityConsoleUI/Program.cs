using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.DisplayWelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool result = ValidateUserInput.Validate(user);
            if (!result)
            {
                StandardMessages.DisplayEndOfProgram();//*1*
                return;
            }

            string userName = CreateUserData.CreateUserName(user);
            Console.WriteLine("Your username is: " + userName);

            StandardMessages.DisplayEndOfProgram();
        }
    }
}
