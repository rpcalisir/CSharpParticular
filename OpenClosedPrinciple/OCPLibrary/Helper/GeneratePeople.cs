using OpenClosedPrinciple.OCPLibrary.Concrete;
using OpenClosedPrinciple.OCPLibrary.Interface;
using System.Collections.Generic;

namespace OpenClosedPrinciple.OCPLibrary.Helper
{
    public static class GeneratePeople
    {
        public static List<IApplicant> GenerateMockedPeopleData()
        {
            List<IApplicant> people = new List<IApplicant>()
            {
                new Person{FirstName = "Recep", LastName = "Calisir"},
                new Person{FirstName = "Tim", LastName = "Corey"},
                new Person{FirstName = "Sue", LastName = "Storm"}
            };
            return people;
        }
    }
}
