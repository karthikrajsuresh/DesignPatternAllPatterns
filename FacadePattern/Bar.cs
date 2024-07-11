namespace FacadePattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
