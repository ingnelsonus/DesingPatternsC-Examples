using Example2_Palabra_Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Example2_Palabra
    {
        public void Run()
        {
            Palabra palabra = new Palabra("hola mundo.");

            foreach(var letra in palabra)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();

        }
    }
}
