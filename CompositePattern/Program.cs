﻿/*
The Composite Pattern in C#

Type: Structural
Useful? 4/5 (Very)
Good For: Treating different objects in a hierarchy as the same.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://exceptionnotfound.net/composite-pattern-in-csharp/
 */
namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();

            Console.ReadKey();
        }
    }
}
