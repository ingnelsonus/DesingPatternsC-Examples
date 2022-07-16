using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_List_Interator
{
    internal abstract class IteratorEjemplo
    {
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}
