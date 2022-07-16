using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_CostoBebida_Decorator;

namespace Decorator
{
    internal class Example1_CostoBebida
    {
        public void Run()
        {
            BebidaComponent cafe = new CafeSolo();
            cafe = new Leche(cafe);
            cafe = new Edulcorante(cafe);

            Console.WriteLine($"Producto: {cafe.Descripcion} tiene un costo de: ${cafe.Costo}");
            Console.ReadKey();



        }
    }
}
