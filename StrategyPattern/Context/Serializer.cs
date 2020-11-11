using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Context
{
    public class Serializer
    {
        private ISerializer _serializer;
        public Serializer(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public void Serialize(string str)
        {
            _serializer.Serialize(str);
        }

        public void Deserialize(string str)
        {
            _serializer.DeSerialize(str);
        }
    }
}
