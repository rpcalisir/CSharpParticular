using System;
using System.Collections.Generic;
using System.Text;

namespace DryLibrary
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeId(string firstName, string lastName)
        {
            return $@"{GetStartingName(firstName,4)}{GetStartingName(lastName, 4)}{DateTime.Now.Millisecond}";
        }

        private string GetStartingName(string name, int numberOfCharacters)
        {
            string output = name;

            if (output.Length>numberOfCharacters)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            return output;
        }
    }
}
