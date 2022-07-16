using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_List_Interator
{
    internal class Item
    {
        public Item(string _nom)
        {
            Nombre = _nom;
        }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
