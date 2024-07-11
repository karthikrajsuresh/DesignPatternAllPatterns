using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
}
