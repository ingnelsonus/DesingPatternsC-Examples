using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Auto_protype
{
    internal class FiatPrototype : AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (FiatPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"Fiat {_modelo}, Color: {_color}";
        }
    }
}
