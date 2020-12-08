using OpenClosedPrinciple.OCPLibrary.Concrete;
using OpenClosedPrinciple.OCPLibrary.Interface;
using System.Collections.Generic;

namespace OpenClosedPrinciple.OCPLibrary.Helper
{
    public static class GeneratePeople
    {
        public static List<IApplicant> Generate()
        {
            List<IApplicant> people = new List<IApplicant>()
            {
                new Person{FirstName = "Recep", LastName = "Calisir"},
                new Person{FirstName = "Baris", LastName = "OZ"},
                new Person{FirstName = "Sven", LastName = "Muller"}
            };
            return people;
        }
    }
}
