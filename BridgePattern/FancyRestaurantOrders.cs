namespace BridgePattern
{
    /// <summary>
    /// Concrete implementor for an ordering system at a fancy restaurant.
    /// </summary>
    public class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Fancy Restaurant.");
        }
    }
}

