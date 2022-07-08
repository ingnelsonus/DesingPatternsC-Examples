using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_motor_adapter
{
    internal class MotorElectrico
    {
        bool _conectado;
        bool _activo;
        bool _movimiento;

        public void Conectar()
        {
            if(_conectado)
                Console.WriteLine("Imposible conectar un motor electrico ya conectado!");
            else
            {
                _conectado = true;
                Console.WriteLine("Motor electrico conectado!");
            }
        }

        public void Activar()
        {
            if (!_conectado)
                Console.WriteLine("Imposible activar un motor no conectado");
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado!");
            }
        }

        public void Mover()
        {
            if (_conectado && _activo)
            {
                _movimiento = true;
                Console.WriteLine("Moviendo vehiculo con motor electrico");
            }                
            else                            
                Console.WriteLine("El motor deberá estar conectado y activo");            
        }

        public void Parar()
        {
            if (_movimiento)
            {
                _movimiento = false;
                Console.WriteLine("Parando vehiculo con motor electrico");
            }
            else
                Console.WriteLine("Imposible parar un motor que no este en movimiento!");
        }

        public void Desconectar()
        {
            if (_conectado)
            {                
                Console.WriteLine("Motor desconectado");
            }
            else
                Console.WriteLine("Imposible desconectar un motor no conectado");
        }

        public void Desactivar()
        {
            if (_activo)
            {
                Console.WriteLine("Motor desactivado");
            }
            else
                Console.WriteLine("Imposible desconectar un motor no activad");
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo=false;
                Console.WriteLine("Motor cargando las baterias");
            }
            else
                Console.WriteLine("Imposible enchufar un motor activo!");
        }
    

    }
}
