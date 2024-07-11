using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Sandwich
    {
        private string _sandwichType;
        private Dictionary<string, string> _ingredients
            = new Dictionary<string, string>();

        // Constructor
        public Sandwich(string sandwichType)
        {
            this._sandwichType = sandwichType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _ingredients[key]; }
            set { _ingredients[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich: {0}", _sandwichType);
            Console.WriteLine(" Bread: {0}", _ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", _ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", _ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", _ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", _ingredients["condiments"]);
        }
    }
}
