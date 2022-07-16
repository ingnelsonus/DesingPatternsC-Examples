using Example1_OrdenCompra_Commad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace command
{
    internal class Example1_OrdenCompra
    {
        public void Run()
        {
            EmpresaInvoker empresa = new EmpresaInvoker();
            ProductoReceiver producto = new ProductoReceiver();
            producto.Cantidad = 100;
            AltaStockCommand ordenAlta = new AltaStockCommand(producto,10);
            empresa.TomarOrden(ordenAlta);
            BajaStockCommand ordenBaja= new BajaStockCommand(producto,50);
            empresa.TomarOrden(ordenBaja);
            empresa.ProcesarOrdenes();
            Console.WriteLine($"Total en stock {producto.Cantidad}.");
            Console.ReadKey();


        }
    }
}
