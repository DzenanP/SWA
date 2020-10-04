using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1
{
    class StackElement<T>
    {
        public T ValueOfElements { get; set; }
        public StackElement<T> Next { get; set; }
    }
}
