using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityConsoleUI
{
    public class StandardMessages
    {
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void DisplayEndOfProgram()
        {
            Console.ReadLine();
        }
        
        public static void DisplayErrorMessage(string name)
        {
            Console.WriteLine($"You didn't give us a valid {name}!");
        }
    }
}
