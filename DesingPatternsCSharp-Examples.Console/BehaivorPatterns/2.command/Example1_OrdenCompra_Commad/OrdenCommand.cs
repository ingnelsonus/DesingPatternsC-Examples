﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_OrdenCompra_Commad
{
    internal abstract class OrdenCommand
    {
        public abstract void Ejecutar();
        protected ProductoReceiver _producto;
        protected double _cantidad;

        public OrdenCommand(ProductoReceiver producto,double cantidad)
        {
            _producto = producto;
            _cantidad = cantidad;
        }
    }
}
