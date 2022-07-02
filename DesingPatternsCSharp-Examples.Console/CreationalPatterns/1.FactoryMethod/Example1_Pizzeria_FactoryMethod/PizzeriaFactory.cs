using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// AbstractFactory, define el comportamiento por default de los ConcreteFactory
    /// </summary>
    internal abstract class PizzeriaFactory
    {
        public abstract Pizza CrearPizza(string tipo);
        
    }
}
