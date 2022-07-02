using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// ConcretFactory, en este caso representa la pizzeiaItaliana que se extiente del abstractFactory y tiene la resinsabilida 
    /// de crear el ConcretProduct especificado en tiempo de ejecucion.
    /// </summary>
    internal class PizzeriaItaliana : PizzeriaFactory
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "cancha")
                return new PizzaCancha("Italia");
            else if (tipo == "napo")
                return new PizzaNapolitana("italia");
            else
                return null;
        }
    }
}
