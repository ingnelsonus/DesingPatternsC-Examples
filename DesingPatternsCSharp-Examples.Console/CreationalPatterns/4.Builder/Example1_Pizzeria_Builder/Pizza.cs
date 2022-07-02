using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Pizzeria_Builder
{
    internal class Pizza
    {
        Masa _masa;
        Salsa _salsa;
        Agegado _agregado;
        string _tipo;

        public override string ToString()
        {
            return $"{_tipo}, Masa: {_masa.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }

        public Pizza(Masa masa, Salsa salsa, Agegado agregado,string tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;   
            _tipo = tipo;
        }

    }
}
