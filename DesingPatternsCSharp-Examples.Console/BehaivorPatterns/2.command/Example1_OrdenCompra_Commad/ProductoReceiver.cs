using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_OrdenCompra_Commad
{
    internal class ProductoReceiver
    {
        public double Cantidad { get; set; }
        public string Nombre { get; set; }

        public void RestarStock(double cant)
        {
            Cantidad = cant;
            Console.WriteLine($"Quitando {cant} unidades");
        }

        public void SumarStock(double cant)
        {
            Cantidad = Cantidad + cant;
            Console.WriteLine($"Agregando {cant} unidades");
        }
    }
}
