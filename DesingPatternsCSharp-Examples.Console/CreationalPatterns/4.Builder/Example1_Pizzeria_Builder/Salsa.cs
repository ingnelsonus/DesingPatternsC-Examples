using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal abstract class Salsa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }
    }

    internal class Tomate:Salsa
    {
        public Tomate()
        {
            _descripcion = "Salsa de tomate clásica";
        }
    }

    internal class Oliva : Salsa
    {
        public Oliva()
        {
            _descripcion = "Salsa de tomate a la oliva";
        }
    }

    internal class light : Salsa
    {
        public light()
        {
            _descripcion = "Salsa sin condimentos ni sal";
        }
    }

}
