using DelegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleUI
{
    class Program
    {
        static ShoppingCart cart = new ShoppingCart();
        static void Main(string[] args)
        {
            PopulateCartWithSampleData();
            Console.WriteLine($"Total for the shopping cart is {cart.GetSumWithDiscount(TotalWithoutDiscount):C2}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the application!");
            Console.ReadLine();
        }
        private static void TotalWithoutDiscount(decimal baseTotal)
        {
            Console.WriteLine($"Total before discount is {baseTotal}");
        }

        private static void PopulateCartWithSampleData()
        {
            cart.Items.Add(new Product {ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new Product {ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new Product {ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new Product {ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
