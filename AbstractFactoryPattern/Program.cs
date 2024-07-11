/*
The Abstract Factory Pattern in C#

Type: Creational
Useful?: 5/5 (Extremely)
Good For: Creating objects in different related families without relying on concrete implementations.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/abstract-factory-pattern-in-csharp/
*/
namespace AbstractFactoryPattern
{
    class Program
    {
        /// <summary>
        /// The Abstract Factory pattern provides an interface for creating related families of objects
        /// without needing to specify the concrete implementations.  This pattern is critical for ideas
        /// like Dependency Injection.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");
            char input = Console.ReadKey().KeyChar;
            RecipeFactory factory;
            switch (input)
            {
                case 'A':
                    factory = new AdultCuisineFactory();
                    break;

                case 'C':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();

            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

            Console.ReadKey();
        }
    }
}
