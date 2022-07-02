
using System;

namespace FactoryMethod
{
    /// <summary>
    /// Esta es la Interfaz o clase abstracta <IProduct> sobre la cual se basaran los <ConcretProducts>
    /// </summary>
    internal abstract class Pizza
    {
        protected string _descripcion;
        protected string _Origen;

        public void Render()
        {
            Console.WriteLine(string.Format("Pizza {0} hecha en {1}", _descripcion, _Origen));
        }

    }
}
