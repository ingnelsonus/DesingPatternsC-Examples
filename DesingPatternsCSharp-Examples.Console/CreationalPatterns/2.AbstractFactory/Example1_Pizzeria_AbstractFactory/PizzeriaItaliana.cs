using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// ConcretFactory, en este caso representa la pizzeiaItaliana que se extiente del abstractFactory y tiene la resinsabilida 
    /// de crear el ConcretProduct especificado en tiempo de ejecucion.
    /// </summary>
    internal class PizzeriaItaliana : PizzeriaAbstractFactory
    {
        public override Empanada CrearEmpanada()
        {
            return new EmpanadaCapresse();
        }

        public override Pizza CrearPizza()
        {            
            return new PizzaNapolitana();           
        }
       
    }
}
