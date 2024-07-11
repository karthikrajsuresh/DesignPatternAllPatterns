namespace FacadePattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the hot entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
