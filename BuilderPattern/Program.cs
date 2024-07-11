/*
The Builder Pattern in C#

Type: Creational
Useful?: 1/5 (Almost certainly not)
Good For: Creating objects which need several steps to happen in order, but the steps are different for different specific implementations.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/builder-pattern-in-csharp/
*/
using System.Reflection.Metadata;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Create shop with sandwich assembly line
            AssemblyLine shop = new AssemblyLine();

            // Construct and display sandwiches
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Wait for user
            Console.ReadKey();
        }

    }
}
