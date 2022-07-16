using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_List_Interator
{
    internal class ConcreteIteratorEjemplo:IteratorEjemplo
    {
        private Collection _aggregate;
        private Item _item;

        public ConcreteIteratorEjemplo(Collection agregado)
        {
            _aggregate = agregado;
        }

        public override Item CurrentItem()
        {
            return _item;
        }

        public override void First()
        {
            _item= _aggregate.Index(0);
        }

        public override bool IsDone()
        {
           if(_aggregate.Count() == _aggregate.Posicion() + 1)
                return true;
            else
                return false;
        }

        public override void Siguiente()
        {
            _item =_aggregate.Index(_aggregate.Posicion()+1);
        }
    }
}
