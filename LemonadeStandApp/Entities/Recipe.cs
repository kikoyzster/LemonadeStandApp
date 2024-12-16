using LemonadeStandApp.Interfaces;

namespace LemonadeStandApp
{
    public class Recipe : IRecipe
    {
        public string Name { get; set; }
        public Type AllowedFruit { get; set; }
        public decimal ConsumptionPerGlass { get; set; }
        public int PricePerGlass { get; set; }
    }
}
