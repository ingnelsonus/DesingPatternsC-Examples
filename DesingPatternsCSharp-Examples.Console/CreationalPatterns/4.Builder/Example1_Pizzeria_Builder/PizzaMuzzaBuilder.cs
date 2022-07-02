using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal class PizzaMuzzaBuilder:PizzaBuilder
    {
        public PizzaMuzzaBuilder()
        {
            _descripcion = "pizza de Muzzarela";
        }

        public override Agegado BuildAgregado()
        {
            return new Oregano();
        }

        public override Masa BuildMasa()
        {
            return new AlMolde();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }
    }
}
