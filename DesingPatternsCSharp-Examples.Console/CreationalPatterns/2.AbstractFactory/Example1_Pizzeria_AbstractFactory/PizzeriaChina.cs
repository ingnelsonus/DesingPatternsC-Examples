using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class PizzeriaChina : PizzeriaAbstractFactory
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaMurcielago();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaSushi();
        }
    }
}
