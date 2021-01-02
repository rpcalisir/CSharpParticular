using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event101
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            TestingEvents testing = new TestingEvents();

            while (!input.Equals('z'))
            {
                input = Console.ReadLine();
                testing.Update(input);
                Console.WriteLine(input);
            }

            Console.ReadLine();
        }
    }
}
