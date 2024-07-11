/*
The Flyweight Pattern in C#

Type: Structural
Useful? 1/5 (Nope)
Good For: Creating lots of instances of the same set of objects and thereby improving performance.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/flyweight-pattern-in-csharp/
*/
namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Q with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    }
}
