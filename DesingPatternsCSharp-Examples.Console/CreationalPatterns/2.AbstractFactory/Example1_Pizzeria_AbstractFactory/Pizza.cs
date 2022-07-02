
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Esta es la Interfaz o clase abstracta <IProduct> sobre la cual se basaran los <ConcretProducts>
    /// </summary>
    internal abstract class Pizza
    {
        protected string _descripcion;


        public object Descripcion 
        {
            get {
                return _descripcion;
                }            
        }

    }
}
