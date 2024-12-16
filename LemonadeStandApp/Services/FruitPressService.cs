using LemonadeStandApp.Interfaces;
using System.Collections.Generic;

namespace LemonadeStandApp.Services

{
    public class FruitPressService : IFruitPressService
    {
        // Metod för att producera juice baserat på recept, tillgänglig frukt, betalt belopp och beställd mängd
        public FruitPressResult Produce(IRecipe recipe, ICollection<IFruit> fruits, int moneyPaid, int orderedGlassQuantity)
        {
            // Validera att beställd mängd är större än noll
            if (orderedGlassQuantity <= 0)
            {
                return new FruitPressResult
                {
                    IsSuccess = false,
                    Message = "Please order at least one glass."
                };
            }

            // Beräkna hur mycket frukt som krävs för den beställda mängden
            var requiredFruit = recipe.ConsumptionPerGlass * orderedGlassQuantity;
            var availableFruit = fruits.Count(f => f.Name == recipe.Name.Split(' ')[0]);

            if (availableFruit < requiredFruit)
            {
                var deficit = requiredFruit - availableFruit;
                return new FruitPressResult
                {
                    IsSuccess = false,
                    Message = $"Not enough fruit. You need {deficit} more units of {recipe.Name.Split(' ')[0]}."
                };
            }

            // Beräkna den totala kostnaden och kontrollera om det betalade beloppet är tillräckligt
            var totalCost = recipe.PricePerGlass * orderedGlassQuantity;
            if (moneyPaid < totalCost)
            {
                var deficit = totalCost - moneyPaid;
                return new FruitPressResult
                {
                    IsSuccess = false,
                    Message = $"Insufficient funds. You need {deficit} more currency units."
                };
            }

            // Om alla valideringar passerar, returnera ett framgångsresultat
            return new FruitPressResult
            {
                IsSuccess = true,
                Message = "Juice production successful!",
                RemainingFruit = availableFruit - requiredFruit,
                Change = moneyPaid - totalCost
            };
        }
    }

}
