using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal class PizzaItalianaBuilder : PizzaBuilder
    {
        public PizzaItalianaBuilder()
        {
            _descripcion = "Pizza Italiana";
        }

        public override Agegado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Masa BuildMasa()
        {
            return new AlaPiedra();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }
    }
}
