using OCPLibrary.AccountProcessor;
using OCPLibrary.Interface.AccountProcessor;
using OCPLibrary.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPLibrary.Model
{
    public class Executive : IParticipent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IPersonAccount accountProcessor { get; set; } = new ExecutiveAccount();
    }
}
