using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_FilesSystem_Comosite
{
    internal class Archivo:Componente
    {
        int _tamaño;

        public Archivo(string name,int tamaño):base(name)
        {
            _tamaño = tamaño;
        }

        public int Tamaño { get { return _tamaño; } }        

        public override void AgregarHijo(Componente c)
        {
           
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerTamaño
        {
            get
            {
                return _tamaño;
            }
        }
    }
}
