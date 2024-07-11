/*
The Strategy Pattern in C#

Type: Behavioral
Useful? 4/5 (Very)
Good For: Encapsulating parts of an algorithm as objects and allowing them to be invoked independently.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://exceptionnotfound.net/strategy-pattern-in-csharp/
*/
namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CookingMethod cookMethod = new CookingMethod();

            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();
            cookMethod.SetFood(food);

            Console.WriteLine("What cooking strategy would you like to use (1-3)?");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (input)
            {
                case 1:
                    cookMethod.SetCookStrategy(new Grilling());
                    cookMethod.Cook();
                    break;

                case 2:
                    cookMethod.SetCookStrategy(new OvenBaking());
                    cookMethod.Cook();
                    break;

                case 3:
                    cookMethod.SetCookStrategy(new DeepFrying());
                    cookMethod.Cook();
                    break;

                default:
                    Console.WriteLine("Invalid Selection!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
