using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal class PizzaLightBuilder:PizzaBuilder
    {
        public PizzaLightBuilder()
        {
            _descripcion = "Pizza light";
        }

        public override Agegado BuildAgregado()
        {
            return new Berengenas();
        }

        public override Masa BuildMasa()
        {
            return new Integral();
        }

        public override Salsa BuildSalsa()
        {
            return new light();
        }
    }
}
