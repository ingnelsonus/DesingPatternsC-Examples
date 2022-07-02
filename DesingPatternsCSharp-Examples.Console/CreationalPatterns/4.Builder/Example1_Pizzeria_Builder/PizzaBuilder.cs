using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal abstract class PizzaBuilder
    {
        protected string _descripcion;
        public abstract Masa BuildMasa();
        public abstract Salsa BuildSalsa();
        public abstract Agegado BuildAgregado();

        public override string ToString()
        {
            return _descripcion;
        }

        public Pizza BuildPizza()
        {
            Masa masa = BuildMasa();
            Salsa salsa = BuildSalsa();
            Agegado agregado = BuildAgregado();

            return new Pizza(masa, salsa, agregado, _descripcion);
        }
    }
}
