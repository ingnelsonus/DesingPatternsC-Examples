using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Compra_ChainOfResponsability
{
    internal class Gerente : Aprobador
    {
        public override void procesar(Compra c)
        {
            if (c.Importe <= 1000)
                Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");
            else
                _siguiente.procesar(c);
        }
    }
}
