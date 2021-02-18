

using OpenClosedPrinciple.OCPLibrary.Interface;

namespace OpenClosedPrinciple.OCPLibrary.Concrete
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
