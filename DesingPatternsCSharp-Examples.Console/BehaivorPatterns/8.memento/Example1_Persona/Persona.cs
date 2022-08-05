using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento.Example1_Persona
{
    public class Persona
    {

        public string Nombre { get; set; }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
        }

        public void RestoreMement(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Originator: Recuperando memento " + Nombre);
        }

    }
}
