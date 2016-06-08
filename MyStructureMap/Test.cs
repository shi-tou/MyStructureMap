using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructureMap
{
    public class Test : ITest
    {
        public string Print()
        {
            return "Hello,StructureMap!";
        }
    }
}
