namespace BridgePattern
{
    /// <summary>
    /// Concrete implementor for an ordering system at a diner.
    /// </summary>
    public class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Diner.");
        }
    }
}

