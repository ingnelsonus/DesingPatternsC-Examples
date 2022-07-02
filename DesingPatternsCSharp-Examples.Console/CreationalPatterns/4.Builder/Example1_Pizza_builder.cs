using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_Pizzeria_Builder;

namespace Builder
{
    internal class Example1_Pizza_builder
    {
        public void Run()
        {
            List<PizzaBuilder> _lienas = new List<PizzaBuilder>();
            _lienas.Add(new PizzaItalianaBuilder());
            _lienas.Add(new PizzaLightBuilder());
            _lienas.Add(new PizzaMuzzaBuilder());


            //Tomamos a manera de ejemplo el primer elemento builder de la lista.
            PizzaBuilder builder = _lienas[2];
            Pizza pizza = builder.BuildPizza();

            Console.WriteLine(pizza.ToString());


        }
    }
}
