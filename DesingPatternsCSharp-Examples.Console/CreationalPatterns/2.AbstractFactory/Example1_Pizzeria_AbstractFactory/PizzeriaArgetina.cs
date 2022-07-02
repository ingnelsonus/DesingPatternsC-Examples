using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// ConcretFactory, en este caso representa la pizzeiaArgentina que se extiente del abstractFactory y tiene la responsabilidad
    /// de crear el ConcretProduct especificado en tiempo de ejecucion.
    /// </summary>
    internal class PizzeriaArgetina : PizzeriaAbstractFactory
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaCarne();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaCancha();            
        }
        
    }
}
