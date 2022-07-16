using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_CostoBebida_Decorator
{
    internal abstract class BebidaComponent
    {
        public abstract double Costo { get; }
        public abstract string Descripcion { get; }
    }
}
