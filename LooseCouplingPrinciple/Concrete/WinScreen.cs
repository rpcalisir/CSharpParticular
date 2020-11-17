using LooseCouplingPrinciple.Interface;
using System;

namespace LooseCouplingPrinciple.Concrete
{
    public class WinScreen : IScreen
    {
        public void Initialize()
        {
            Console.WriteLine("WinScreen Initialize has started");
        }
        public void Draw()
        {
            Console.WriteLine("WinScreen Draw has started");
        }
    }
}
