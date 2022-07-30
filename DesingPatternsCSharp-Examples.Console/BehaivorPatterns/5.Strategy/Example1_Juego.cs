using Example1_Juego_Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Example1_Juego
    {
        List<Arma> _estrategiasDisparo;
        Jugador _jugador;

        public void Run()
        {
            _estrategiasDisparo = new List<Arma>();
            _estrategiasDisparo.Add(new Pistola());
            _estrategiasDisparo.Add(new Bazooka());
            _estrategiasDisparo.Add(new Ak47());

            _jugador = new Jugador();
            _jugador.Nombre = "Nelson";


            //Asigmanos el arma.
            Arma arma= _estrategiasDisparo[1];
            _jugador.CambiarEstrategia(arma);

            Console.WriteLine(_jugador.Disparar());
        }

    }
}
