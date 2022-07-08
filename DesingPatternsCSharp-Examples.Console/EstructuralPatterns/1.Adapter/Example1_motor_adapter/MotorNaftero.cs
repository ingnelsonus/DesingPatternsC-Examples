using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_motor_adapter
{
    internal class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor Naftero.....");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor Naftero.....");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("cargando combustible al motor Naftero.....");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor Naftero.....");
        }
    }
}
