/*
The State Pattern in C#

Type: Behavioral
Useful? 3/5 (Sometimes)
Good For: Allowing an object's behavior to change as its internal state does.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/state-pattern-in-csharp/
*/
namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Let's cook a steak!
            Steak account = new Steak("T-Bone");

            // Apply temperature changes
            account.AddTemp(120);
            account.AddTemp(15);
            account.AddTemp(15);
            account.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            account.RemoveTemp(15);
            account.AddTemp(20);
            account.AddTemp(20);
            account.AddTemp(20);

            Console.ReadKey();
        }
    }
}
