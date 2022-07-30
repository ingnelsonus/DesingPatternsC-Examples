using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Producto_Observer
{
    internal class Producto : ISujetoProducto
    {
        private List<IObserverUsuario> _usuarios;
        double _precio;


        public Producto(string nombre, double precio)
        {
            _usuarios = new List<IObserverUsuario>();
            Nombre = nombre;
            _precio = precio;
        }

        public string Nombre { get; set; }
        public double Precio { 
            get 
            { 
                return _precio;
            }
            set 
            { 
                _precio = value;
                this.Notificar();
            }
        }

        public override string ToString()
        {
            return $"{Nombre} (${_precio})";
        }

        public void Agregar(IObserverUsuario usuario)
        {
            if (!_usuarios.Contains(usuario))
                _usuarios.Add(usuario);
            else
                throw new Exception($"Ya existe una suscripcion para {usuario}");
        }

        public void Notificar()
        {
            //foreach (var usuario in _usuarios)
                //usuario.Actualizar();
        }

        public void Quitar(IObserverUsuario usuario)
        {
            if (_usuarios.Contains(usuario))
                _usuarios.Remove(usuario);
            else
                throw new Exception($"No existe una suscripcion para {usuario}");
        }
    }
}
