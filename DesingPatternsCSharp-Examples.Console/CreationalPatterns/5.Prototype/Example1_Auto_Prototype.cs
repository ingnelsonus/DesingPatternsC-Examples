using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_Auto_protype;


namespace Prototype
{
    internal class Example1_Auto_Prototype
    {
        public void Run()
        {
            AutoPrototype prototipoFiat = new FiatPrototype();
            AutoPrototype prototipoDS = new DSPrototype();
            AutoPrototype prototipoAlfa = new AlfaRomeoPrototype();

            AutoPrototype fiatPalio = prototipoFiat.Clonar();
            fiatPalio.Modelo = "Palio Fire";
            fiatPalio.Color = "negro";
            Console.WriteLine(fiatPalio.VerAuto());

            AutoPrototype fiatUno = prototipoFiat.Clonar();
            fiatUno.Modelo = "Uno SRC";
            fiatUno.Color = "blanco";
            Console.WriteLine(fiatUno.VerAuto());

            AutoPrototype ds3 = prototipoDS.Clonar();
            ds3.Modelo = "3 Chic";
            ds3.Color = "blanco";
            Console.WriteLine(ds3.VerAuto());

            AutoPrototype ds4 = prototipoDS.Clonar();
            ds4.Modelo = "4 Sport";
            ds4.Color = "negro";
            Console.WriteLine(ds4.VerAuto());

            Console.ReadKey();

        }
    }
}
