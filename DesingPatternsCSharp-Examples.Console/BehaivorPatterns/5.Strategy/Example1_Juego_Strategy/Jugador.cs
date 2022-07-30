using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Juego_Strategy
{
    internal class Jugador
    {
        Arma _estrategia;

        public string Nombre { get; set; }

        public void CambiarEstrategia(Arma estrategia)
        {
            _estrategia = estrategia;
        }

        public string Disparar()
        {
            if (_estrategia == null) return "Arma no disponible";
            return _estrategia.Disparar();
        }

    }
}
