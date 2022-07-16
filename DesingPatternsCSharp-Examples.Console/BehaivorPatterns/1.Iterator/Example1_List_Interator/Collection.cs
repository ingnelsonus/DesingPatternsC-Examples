using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_List_Interator
{
    internal abstract class Collection
    {
        public abstract IteratorEjemplo CreateInterator();
        public abstract void Agregar(Item _item);
        public abstract Item Index(int _index);
        public abstract int Count();
        public abstract int Posicion();

    }
}
