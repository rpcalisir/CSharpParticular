using LooseCouplingPrinciple.Concrete;
using System;

namespace LooseCouplingPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ScreenCreator screenCreator = new ScreenCreator(new MobileScreen());
            screenCreator.InitializeScreen();
            screenCreator.DrawScreen();

            Console.ReadLine();
        }
    }
}
