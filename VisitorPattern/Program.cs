/*
The Facade Pattern in C#

Type: Behavioral
Useful? 1/5 (Rarely)
Good For: Operating on objects without changing their classes.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/visitor-pattern-in-csharp/
*/
namespace VisitorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Who are my employees?
            Employees e = new Employees();
            e.Attach(new LineCook());
            e.Attach(new HeadChef());
            e.Attach(new GeneralManager());

            // Employees are visited, giving them 10% raises 
            // and 3 extra paid time off days.
            e.Accept(new IncomeVisitor());
            e.Accept(new PaidTimeOffVisitor());

            Console.ReadKey();
        }
    }
}
