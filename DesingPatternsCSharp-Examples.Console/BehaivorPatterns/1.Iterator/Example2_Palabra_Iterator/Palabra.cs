using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_Palabra_Iterator
{
    internal class Palabra:IEnumerable
    {
        string _palabra;

        public Palabra(string palabra)
        {
            _palabra = palabra;
        }

        public IEnumerator GetEnumerator()
        {
            return new PalabraIterator(_palabra);
        }

    }
}
