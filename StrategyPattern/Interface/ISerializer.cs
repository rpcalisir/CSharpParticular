using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface
{
    public interface ISerializer
    {
        void Serialize(string str);
        void DeSerialize(string str);
    }
}
