/*
The Memento Pattern in C#

Type: Behavioral
Useful? 2/5 (Rarely)
Good For: Restoring an object's state from a previous state by creating a memento of said previous state.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/memento-pattern-in-csharp/
*/
namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here's a new supplier for our restaurant
            FoodSupplier s = new FoodSupplier();
            s.Name = "Harold Karstark";
            s.Phone = "(482) 555-1172";

            // Let's store that entry in our database.
            SupplierMemory m = new SupplierMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Address = "548 S Main St. Nowhere, KS";

            // Crap, gotta undo that entry, I entered the wrong address
            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }
}
