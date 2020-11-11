using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class XmlSerializer : ISerializer
    {
        public void DeSerialize(string str)
        {
            Console.WriteLine("Xml is serialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("Xml is deserialized");
        }
    }
}
