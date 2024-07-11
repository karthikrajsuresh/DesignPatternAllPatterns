namespace BridgePattern
{
    /// <summary>
    /// Refined abstraction for a dairy-free order
    /// </summary>
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }
}

