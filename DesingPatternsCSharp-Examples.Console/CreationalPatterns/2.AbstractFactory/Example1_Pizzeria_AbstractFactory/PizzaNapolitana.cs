using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// ConcrectPruduct que herada de IProduct en este caso la clase abstracta Pizza, tambien puede ser una interfaz.
    /// </summary>
    internal class PizzaNapolitana:Pizza
    {
        public PizzaNapolitana()
        {
            _descripcion = "Pizza napolitana";            

        }
    }
}
