using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> cities = new MyList<string>();
            cities.Add("adana");
            cities.Add("edirne");
            cities.Add("ankara");
            Console.WriteLine("Number of items: " + cities.Count);

            foreach (var city in cities)
            {
                Console.WriteLine("City: " + city);
            }

            Console.ReadLine();
        }
    }
}
