namespace BridgePattern
{
    /// <summary>
    /// Refined abstraction for a gluten free order
    /// </summary>
    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}

