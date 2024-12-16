namespace LemonadeStandApp.Interfaces
{
    public interface IFruitPressService
    {
        FruitPressResult Produce(IRecipe recipe,
                              ICollection<IFruit> fruits,
                              int moneyPaid,
                              int orderedGlassQuantity);
    }
}
