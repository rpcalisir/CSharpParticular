using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.OCPLibrary.Interface
{
    interface IManager : IEmployee
    {
        bool IsManager { get; set; }
    }
}
