namespace DecoratorPattern
{
    /// <summary>
    /// The abstract Decorator class.  
    /// </summary>
    abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        public Decorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
