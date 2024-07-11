/*
The Prototype Pattern in C#

Type: Creational
Useful? 3/5 (Sometimes)
Good For: Creating lots of similar objects.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/prototype-pattern-in-csharp/
 */


using Prototype;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            // Initialize with default sandwiches
            sandwichMenu["BLT"]
                = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"]
                = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"]
                = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            // Deli manager adds custom sandwiches
            sandwichMenu["LoadedBLT"]
                = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
            sandwichMenu["ThreeMeatCombo"]
                = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
            sandwichMenu["Vegetarian"]
                = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            // Now we can clone these sandwiches
            Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2
                = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
            Sandwich sandwich3
                = sandwichMenu["Vegetarian"].Clone() as Sandwich;

            // Wait for user
            Console.ReadKey();
        }
    }
}
