﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_TempleteMethod_Prestamo
{
    internal class Cliente
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
