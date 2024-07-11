/*
The Adapter Pattern in C#

Type: Structural
Useful? 4/5 (Very)
Good For: Adapting two interfaces together when one or more of those interfaces cannot be refactored.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/adapter-pattern-in-csharp/
*/
namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Non-adapted
            Meat unknown = new Meat("Beef");
            unknown.LoadData();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef");
            beef.LoadData();

            MeatDetails turkey = new MeatDetails("Turkey");
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken");
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
