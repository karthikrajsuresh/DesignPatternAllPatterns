/*
The Proxy Pattern in C#

Type: Structural
Useful? 4/5 (Very)
Good For: Controlling access to a particular object, testing scenarios.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/proxy-pattern-in-csharp/
*/
namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewServerProxy proxy = new NewServerProxy();

            Console.WriteLine("What would you like to order? ");
            string order = Console.ReadLine();
            proxy.TakeOrder(order);
            Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
            Console.WriteLine("How would you like to pay?");
            string payment = Console.ReadLine();
            proxy.ProcessPayment(payment);

            Console.ReadKey();
        }
    }
}
