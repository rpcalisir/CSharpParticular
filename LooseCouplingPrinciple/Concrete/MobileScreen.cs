using LooseCouplingPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingPrinciple.Concrete
{
    public class MobileScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("MobileScreen Initialize has started");
        }

        public void Initialize()
        {
            Console.WriteLine("MobileScreen Draw has started");
        }
    }
}
