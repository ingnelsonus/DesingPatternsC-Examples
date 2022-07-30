using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Compra_ChainOfResponsability
{
    internal class Director : Aprobador
    {
        public override void procesar(Compra c)
        {           
            Console.WriteLine($"Compra aprobada por el {this.GetType().Name}");         
        }
    }
}
