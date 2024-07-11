/*
The Singleton Pattern in C#

Type: Creational
Useful? 5/5 (Extremely)
Good For: Creating objects in a related family.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/factory-method-pattern-in-csharp/
*/

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sandwich> sandwiches = new List<Sandwich>();
            sandwiches.Add(new TurkeySandwich());
            sandwiches.Add(new Dagwood());

            foreach (var sandwich in sandwiches)
            {
                Console.WriteLine("\nSandwich: " + sandwich.GetType().Name + " ");
                foreach (var ingredient in sandwich.Ingredients)
                {
                    Console.WriteLine("Ingredient: " + ingredient.GetType().Name);
                    Console.WriteLine("\neat the sandwich " + sandwich.GetType().Name + " ");

                }
            }

            Console.ReadKey();

        }
    }
}
