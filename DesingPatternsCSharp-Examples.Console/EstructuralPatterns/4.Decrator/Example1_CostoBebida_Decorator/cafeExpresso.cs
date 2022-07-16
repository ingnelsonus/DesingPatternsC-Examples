using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_CostoBebida_Decorator
{
    internal class cafeExpresso : BebidaComponent
    {
        public override double Costo => 12;

        public override string Descripcion => "Café expresso";
    }
}
