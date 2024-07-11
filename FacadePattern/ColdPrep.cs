namespace FacadePattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the cold item
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
