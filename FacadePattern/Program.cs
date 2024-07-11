/*
The Facade Pattern in C#

Type: Structural
Useful? 5/5 (Extremely)
Good For: Hiding complexity which cannot be refactored away.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/facade-pattern-in-csharp/
*/
namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            Patron patron = new Patron(name);

            Console.WriteLine("Hello " + patron.Name
                              + ". What appetizer would you like? (1-15):");
            var appID = int.Parse(Console.ReadLine());

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeID = int.Parse(Console.ReadLine());

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkID = int.Parse(Console.ReadLine());

            Console.WriteLine("I'll get that order in right away.");

            //Here's what the Facade simplifies
            server.PlaceOrder(patron, appID, entreeID, drinkID);

            Console.ReadKey();
        }
    }
}
