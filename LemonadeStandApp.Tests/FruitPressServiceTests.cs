using LemonadeStandApp.Interfaces;
using LemonadeStandApp.Services;
using System.Collections.Generic;
using Xunit;

namespace LemonadeStandApp.Tests
{
    public class FruitPressServiceTests
    {
        [Fact]
        public void Produce_ShouldReturnSuccess_WhenResourcesAreSufficient()
        {
            // Arrange: Skapa en instans av FruitPressService och definiera resurser
            var service = new FruitPressService();
            var recipe = new Recipe
            {
                Name = "Apple Juice",
                AllowedFruit = typeof(Fruit),
                ConsumptionPerGlass = 2.5m, // Frukt som behövs per glas
                PricePerGlass = 10       // Pris per glas
            };

            var fruits = new List<IFruit>
        {
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" }
        };

            int moneyPaid = 20;  // Betalat belopp
            int orderedGlassQuantity = 2;  // Antal beställda glas

            // Act: Kör metoden Produce med ovanstående parametrar
            var result = service.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert: Kontrollera att produktionen lyckas
            Assert.True(result.IsSuccess);             // Resultatet ska vara framgångsrikt
            Assert.Equal(1, result.RemainingFruit);    // Kontrollera återstående frukt
            Assert.Equal(0, result.Change);            // Kontrollera att inget växel behövs
        }

        [Fact]
        public void Produce_ShouldReturnFailure_WhenInsufficientFruits()
        {
            // Arrange: Skapa en instans av FruitPressService och definiera resurser
            var service = new FruitPressService();
            var recipe = new Recipe
            {
                Name = "Apple Juice",
                AllowedFruit = typeof(Fruit),
                ConsumptionPerGlass = 2.5m,  // Frukt som behövs per glas
                PricePerGlass = 10  // Pris per glas
            };

            var fruits = new List<IFruit>
        {
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" },
            new Fruit { Name = "Apple" }
        };

            int moneyPaid = 20;   // Betalat belopp
            int orderedGlassQuantity = 2;  // Antal beställda glas

            // Act: Kör metoden Produce med otillräckliga resurser
            var result = service.Produce(recipe, fruits, moneyPaid, orderedGlassQuantity);

            // Assert: Kontrollera att produktionen misslyckas
            Assert.False(result.IsSuccess);
            Assert.Equal("Not enough fruit to produce the required quantity.", result.Message);
        }
    }
}
