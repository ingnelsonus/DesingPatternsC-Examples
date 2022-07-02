using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Example1_FactoryMethod
    {   
        public  void Run()
        {
            PizzeriaFactory pizzeriafactory;
            Pizza pizza;

            pizzeriafactory = new PizzeriaArgetina();
            pizza = pizzeriafactory.CrearPizza(pizzaType.napo.ToString());
            pizza.Render();
            pizza = pizzeriafactory.CrearPizza(pizzaType.cancha.ToString());
            pizza.Render();

            pizzeriafactory = new PizzeriaItaliana();
            pizza = pizzeriafactory.CrearPizza(pizzaType.napo.ToString());
            pizza.Render();
            pizza = pizzeriafactory.CrearPizza(pizzaType.cancha.ToString());
            pizza.Render();
        }
    }
}
