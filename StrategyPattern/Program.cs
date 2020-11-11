using StrategyPattern.Concrete;
using StrategyPattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer serializer = new Serializer(new XmlSerializer());
            serializer.Serialize("");
            serializer.Deserialize("");

            serializer = new Serializer(new JsonSerializer());
            serializer.Serialize("");
            serializer.Serialize("");

            Console.ReadLine();
        }
    }
}
