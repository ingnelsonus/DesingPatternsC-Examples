using Example1_Persona;
using memento.Example1_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Example1
    {
        static CareTaker careTaker = new CareTaker();
        public void Run()
        {

            var p = new Persona();
            p.Nombre = "pepe";
            careTaker.Add(p.SaveToMemento());
            p.Nombre = "Pepe1";
            careTaker.Add(p.SaveToMemento());
            p.Nombre = "Pepe2";
            careTaker.Add(p.SaveToMemento());

            Memento m1 = careTaker.GetMemento(0);
            Console.WriteLine("Viviendo memento 1: " + m1.Estado);
            Console.WriteLine("Viviendo memento 2: " + careTaker.GetMemento(1).Estado);
            Console.WriteLine("Viviendo memento 3: " + careTaker.GetMemento(2).Estado);
            p.RestoreMement(m1);
            p.RestoreMement(careTaker.GetMemento(1));
            Console.ReadKey();
        }
    }
}
