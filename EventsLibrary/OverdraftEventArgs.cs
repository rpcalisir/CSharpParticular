using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibrary
{
    public class OverdraftEventArgs
    {
        public decimal AmountNeeded { get; private set; }
        public string ExtraInformation { get; private set; }
        public bool StopOverdraft { get; set; } = false;

        public OverdraftEventArgs(decimal amountNeeded, string extraInformation)
        {
            this.AmountNeeded = amountNeeded;
            this.ExtraInformation = extraInformation;
        }
    }
}
