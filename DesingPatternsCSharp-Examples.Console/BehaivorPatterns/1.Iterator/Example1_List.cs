using Example1_List_Interator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Example1_List
    {
        private Collection _collection = new ConcrecteCollection();
        private IteratorEjemplo _iterator;


        public Example1_List()
        {
            _iterator = _collection.CreateInterator();
        }

        public void Run()
        {

            //Agregamos item a la colleccion.
            _collection.Agregar(new Item("Item 1"));
            Listar();

        }

        private void Listar()
        {
            _iterator.First();
            Item i = _iterator.CurrentItem();
            while(!_iterator.IsDone())
            {
                _iterator.Siguiente();
                Console.WriteLine(i.ToString());
            }
        }

    }
}
