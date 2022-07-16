using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_List_Interator
{
    internal class ConcrecteCollection:Collection
    {
        private List<Item> _listItems = new List<Item>();
        private Item _item;
        private int _posicion;

        public override void Agregar(Item _item)
        {
            _listItems.Add(_item);
        }

        public override int Count()
        {
            return _listItems.Count;
        }

        public override IteratorEjemplo CreateInterator()
        {
            return new ConcreteIteratorEjemplo(this);
        }

        public override Item Index(int _index)
        {
            _item = _listItems[_index];
            _posicion = _index;
            return _item;
        }

        public override int Posicion()
        {
            return _posicion;
        }
    }
}
