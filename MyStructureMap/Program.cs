using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            BootStrapper.ConfigureStructureMap();
            //var test = BootStrapper.GetInstance<ITest>();
            //Console.WriteLine(test.Print());

            var test = BootStrapper.GetNamedInstance<ITest>("Test");
            Console.WriteLine(test.Print());

            var firstTest = BootStrapper.GetNamedInstance<ITest>("FirstTest");
            Console.WriteLine(firstTest.Print());

            var secondTest = BootStrapper.GetNamedInstance<ITest>("SecondTest");
            Console.WriteLine(secondTest.Print());

            Console.Read();
        }
    }
}
