using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Auto_protype
{
    internal class DSPrototype:AutoPrototype
    {
        public override AutoPrototype Clonar()
        {
            return (DSPrototype)this.MemberwiseClone();
        }

        public override string VerAuto()
        {
            return $"DS {_modelo}, Color: {_color}";
        }
    }
}
