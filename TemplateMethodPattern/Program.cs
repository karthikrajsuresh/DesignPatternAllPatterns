/*
The Template Method Pattern in C#

Type: Behavioral
Useful? 4/5 (Very, with some caveats)
Good For: Creating an outline of an algorithm but letting specific steps be implemented by other classes.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/template-method-pattern-in-csharp/
*/
namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            sourdough.Make();

            TwelveGrain twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            WholeWheat wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
