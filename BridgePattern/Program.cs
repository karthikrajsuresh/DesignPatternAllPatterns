/*
The Bridge Pattern in C#

Type: Structural
Useful? 3/5 (Sometimes)
Good For: Allowing lots of variation between implementations of interfaces.
Example Code: https://github.com/exceptionnotfound/DesignPatterns/
Link: https://www.exceptionnotfound.net/bridge-pattern-in-csharp/
*/
namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            Console.ReadKey();
        }
    }
}
