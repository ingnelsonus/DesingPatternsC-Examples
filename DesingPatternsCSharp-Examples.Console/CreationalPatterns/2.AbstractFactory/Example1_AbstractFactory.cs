using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Example1_AbstractFactory
    {
        public void Run()
        {
            PizzeriaAbstractFactory fabrica = new PizzeriaArgetina();
            Pizza pizza = fabrica.CrearPizza();
            Empanada empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");

            //Aplicamos sustitucion de liskov
            fabrica = new PizzeriaItaliana();
            pizza = fabrica.CrearPizza();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");

            fabrica =new PizzeriaChina();
            pizza = fabrica.CrearPizza();
            empanada = fabrica.CrearEmpanada();
            Console.WriteLine($"Pizza: {pizza.Descripcion}, Empanada: {empanada.Descripcion}");


        }
    }
}
