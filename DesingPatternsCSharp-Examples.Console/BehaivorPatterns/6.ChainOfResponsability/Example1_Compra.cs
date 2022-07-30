using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_Compra_ChainOfResponsability;

namespace ChainOfResponsability
{
    internal class Example1_Compra
    {
        public void Run()
        {
            var comprador = new Comprador();
            var gerente = new Gerente();
            var director = new Director();
            comprador.AgregarSiguiente(gerente);
            gerente.AgregarSiguiente(director);

            var c = new Compra();
            double importe = 1;
            while (importe != 0)
            {
                Console.WriteLine("Ingrese el importe de la compra (0 para terminar)");
                importe = double.Parse(Console.ReadLine());
                c.Importe = importe;
                comprador.procesar(c);
            }
        }
    }
}
