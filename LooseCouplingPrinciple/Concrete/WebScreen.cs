using LooseCouplingPrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCouplingPrinciple.Concrete
{
    public class WebScreen : IScreen
    {
        public void Draw()
        {
            Console.WriteLine("WebScreen Initialize has started");
        }

        public void Initialize()
        {
            Console.WriteLine("WebScreen Draw has started");
        }
    }
}
