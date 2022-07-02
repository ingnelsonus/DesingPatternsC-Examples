using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_Employee_Builder
{
    internal interface IBuilder<T>
    {
        T Build();
    }
}
