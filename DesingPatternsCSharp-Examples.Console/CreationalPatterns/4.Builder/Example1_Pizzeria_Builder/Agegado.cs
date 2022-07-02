using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal abstract class Agegado
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    internal class Oregano:Agegado
    {
        public Oregano()
        {
            _descripcion = "Oregano fresco";
        }
    }

    internal class Anchoas : Agegado
    {
        public Anchoas()
        {
            _descripcion = "Anchoas en aceite";
        }
    }

    internal class Berengenas : Agegado
    {
        public Berengenas()
        {
            _descripcion = "Berengenas sin calorias";
        }
    }
}
