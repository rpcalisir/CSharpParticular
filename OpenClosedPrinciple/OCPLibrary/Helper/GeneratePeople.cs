using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary.Helper
{
    public static class GeneratePeople
    {
        public static List<Person> Generate()
        {
            List<Person> people = new List<Person>()
            {
                new Person{FirstName = "Recep", LastName = "Calisir"},
                new Person{FirstName = "Baris", LastName = "OZ"}
            };
            return people;
        }
    }
}
