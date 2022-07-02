using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// AbstractFactory, define el comportamiento por default de los ConcreteFactory
    /// </summary>
    internal abstract class PizzeriaAbstractFactory
    {
        public abstract Pizza CrearPizza();
        public abstract Empanada CrearEmpanada();
        
    }
}
