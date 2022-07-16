﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_OrdenCompra_Commad
{
    internal class EmpresaInvoker
    {
        private List<OrdenCommand> ordenes = new List<OrdenCommand>();

        public void TomarOrden(OrdenCommand cmd)
        {
            ordenes.Add(cmd);
        }

        public void ProcesarOrdenes()
        {
            foreach (var orden in ordenes)
                orden.Ejecutar();
            ordenes.Clear();
        }

    }
}
