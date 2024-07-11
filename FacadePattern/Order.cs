namespace FacadePattern
{
    /// <summary>
    /// Orders placed by Patrons.
    /// </summary>
    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }
}
