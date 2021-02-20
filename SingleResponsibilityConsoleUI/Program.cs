using SingleResponsibilityConsoleUI.Account;
using SingleResponsibilityConsoleUI.Messages;
using SingleResponsibilityConsoleUI.PersonOperations;
using System;
using System.Collections.Generic;
using System.IO;
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

            bool result = PersonDataValidator.Validate(user);
            if (!result)
            {
                StandardMessages.DisplayEndOfProgram();//*1*
                return;
            }

            string userName = AccountGenerator.CreateUserName(user);
            Console.WriteLine("Your username is: " + userName);


            Console.WriteLine("Usernames generated from file:");

            //List<Person> people = File.ReadAllLines("People.csv")
            //                        .Skip(1)
            //                        .Select(line => FromCsv.ConvertFromCsv(line)) //Get each line as a Person model from csv file
            //                        .ToList();
            //var data = AccountGenerator.CreateUserNames(people);

            //foreach (var d in data)
            //{
            //    Console.WriteLine(d);
            //}

            var people = FromCsv.GetFromCsv(File.ReadAllText("People.csv"));
            var usernames = AccountGenerator.CreateUserNames(people.ToList());
            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }

            StandardMessages.DisplayEndOfProgram();
        }
    }
}
