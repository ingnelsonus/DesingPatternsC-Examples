using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// ConcrectPruduct que herada de IProduct en este caso la clase abstracta Pizza, tambien puede ser una interfaz.
    /// </summary>
    internal class PizzaCancha:Pizza
    {
        public PizzaCancha(string origen)
        {
            _descripcion = "Pizza de cancha";
            _Origen = origen;
        }
    }
}
