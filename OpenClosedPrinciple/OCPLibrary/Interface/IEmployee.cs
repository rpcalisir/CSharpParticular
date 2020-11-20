using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary.Interface
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
    }
}
