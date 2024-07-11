using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }
}
