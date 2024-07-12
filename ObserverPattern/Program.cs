/*
The Observer Pattern in C#

Type: Behavioral
Useful? 4/5 (Very)
Good For: Notifying observer objects that a particular subject's state changed.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/observer-pattern-in-csharp/
*/
namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create price watch for Carrots 
            // and attach restaurants that buy carrots from suppliers.
            Carrots carrots = new Carrots(0.82);
            carrots.Attach(new Restaurant("Mackay's", 0.77));
            carrots.Attach(new Restaurant("Johnny's Sports Bar", 0.74));
            carrots.Attach(new Restaurant("Salad Kingdom", 0.75));

            // Fluctuating carrot prices will notify subscribing restaurants.
            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadKey();
        }
    }
}
