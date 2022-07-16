using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Producto_Observer
{
    internal interface IObserverUsuario
    {
        void Actualizar(Producto p);
    }
}
