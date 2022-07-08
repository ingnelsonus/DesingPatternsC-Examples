using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1_motor_adapter;

namespace Adapter
{
    internal class Example_Motor_Adapter
    {
        public void Run()
        {
            Motor motor = new MotorNaftero();
            motor.Arrancar();
            motor.Acelerar();
            motor.Detener();
            motor.CargarCombustible();

            motor = new MotorDiesel();
            motor.Arrancar();
            motor.Acelerar();
            motor.Detener();
            motor.CargarCombustible();

            motor = new MotorElectricoAdapter();
            motor.Arrancar();
            motor.Acelerar();
            motor.Detener();
            motor.CargarCombustible();
           
        }
    }
}
