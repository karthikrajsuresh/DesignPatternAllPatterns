/*
The Command Pattern in C#

Type: Behavioral
Useful? 4/5 (Very)
Good For: Encapsulating requests as objects so that they can be processed differently by different receivers.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/command-pattern-in-csharp/
*/
namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patron patron = new Patron();
            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Remove the french fries
            patron.SetCommand(3 /*Remove*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Now we want 4 hamburgers rather than 2
            patron.SetCommand(2 /*Edit*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            Console.ReadKey();
        }
    }
}
