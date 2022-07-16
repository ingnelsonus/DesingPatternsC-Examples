﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_CostoBebida_Decorator
{
    internal class CafeSolo : BebidaComponent
    {
        public override double Costo => 10;

        public override string Descripcion => "café solo";
    }
}
