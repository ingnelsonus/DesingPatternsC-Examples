using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// ConcretFactory, en este caso representa la pizzeiaArgentina que se extiente del abstractFactory y tiene la responsabilidad
    /// de crear el ConcretProduct especificado en tiempo de ejecucion.
    /// </summary>
    internal class PizzeriaArgetina : PizzeriaFactory
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "cancha")
                return new PizzaCancha("Argentina");
            else if (tipo == "napo")
                return new PizzaNapolitana("Argentina");
            else
                return null;
        }
    }
}
