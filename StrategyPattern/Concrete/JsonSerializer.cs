using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class JsonSerializer : ISerializer
    {
        public void DeSerialize(string str)
        {
            Console.WriteLine("Json is serialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("Json is deserialized");
        }
    }
}
