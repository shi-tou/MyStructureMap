using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;

namespace MyStructureMap
{
    public class BootStrapper
    {
        public static IContainer container;
        public static void ConfigureStructureMap()
        {
            container = new Container(c => { c.AddRegistry<StructureMapRegistry>(); });
        }

        public static T GetInstance<T>()
        {
            return container.GetInstance<T>();
        }
        public static T GetNamedInstance<T>(string serviceName)
        {
            return container.GetInstance<T>(serviceName);
        }
    }
    public class StructureMapRegistry : Registry
    {
        public StructureMapRegistry()
        {
            //For<ITest>().Use<Test>();当使用GetInstance<ITest>()时，这个会被最后一个覆盖

            For<ITest>().Singleton().Use<Test>().Named("Test");
            For<ITest>().Singleton().Use<FirstTest>().Named("FirstTest");
            For<ITest>().Singleton().Use<SecondTest>().Named("SecondTest");
        }
    }
}
