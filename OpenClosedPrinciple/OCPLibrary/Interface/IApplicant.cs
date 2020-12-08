using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary.Interface
{
    public interface IApplicant
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountGenerator { get; set; }
    }
}
