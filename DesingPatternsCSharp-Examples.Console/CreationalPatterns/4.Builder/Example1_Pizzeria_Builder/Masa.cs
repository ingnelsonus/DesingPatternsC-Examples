using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal abstract class Masa
    {
        protected string _descripcion;

        public string Descripcion { get { return _descripcion; } }

    }

    internal class AlMolde:Masa
    {
        public AlMolde()
        {
            _descripcion = "Masa al Molde";
        }
    }

    internal class AlaPiedra : Masa
    {
        public AlaPiedra()
        {
            _descripcion = "Masa Ala Piedra";
        }
    }

    internal class Integral : Masa
    {
        public Integral()
        {
            _descripcion = "Masa de harina integral";
        }
    }
}
