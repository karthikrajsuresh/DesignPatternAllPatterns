namespace BuilderPattern
{
    class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }
    }
}
