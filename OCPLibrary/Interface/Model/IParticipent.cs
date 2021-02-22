using OCPLibrary.Interface.AccountProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Interface.Model
{
    public interface IParticipent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IPersonAccount accountProcessor { get; set; }
    }
}
