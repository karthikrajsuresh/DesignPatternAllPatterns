using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        // Gets sandwich instance
        public Sandwich Sandwich
        {
            get { return sandwich; }
        }

        // Abstract build methods
        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}
