using Example2_Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Example2_Singleton
    {
        public void Run()
        {
            //Modul 1
            ConfigurationSingleton singletonA = ConfigurationSingleton.GetInstance();
            //Modul 2
            ConfigurationSingleton singletonB = ConfigurationSingleton.GetInstance();

            Console.WriteLine(singletonA);
            Console.WriteLine(singletonB);
            Console.WriteLine("Same reference ==> " + (singletonA == singletonB));

            singletonA.AppName = "Singleton Pattern";
            singletonB.AppVersion = "1.0x";

            Console.WriteLine("SingletonA ==> " + singletonA);
            Console.WriteLine("SingletonB ==> " + singletonB);

            singletonA = null;
            singletonB = null;

            singletonA = ConfigurationSingleton.GetInstance();
            Console.WriteLine("singletonA ==> " + singletonA);
        }
    }
}
