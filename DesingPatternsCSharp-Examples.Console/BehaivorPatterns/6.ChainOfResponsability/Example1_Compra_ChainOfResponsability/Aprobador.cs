using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Compra_ChainOfResponsability
{
    internal abstract class Aprobador
    {
        protected Aprobador _siguiente;

        public void AgregarSiguiente(Aprobador aprobador)
        {
            _siguiente = aprobador;
        }

        public abstract void procesar(Compra c);

    }
}
