# Lemonade Stand Application

## Overview

The Lemonade Stand application is a Blazor-based project that simulates a juice production system. The system manages recipes, fruit inventory, customer orders, and payments. It adheres to Clean Architecture principles, SOLID design patterns, and includes unit testing for robustness.

---

## Features

- **Recipe Management:** Define juice recipes with fruit consumption per glass and pricing.
- **Inventory Management:** Handle fruit inventory dynamically based on user input.
- **Order Processing:** Validate orders for sufficient fruits and funds, calculate remaining inventory and change.
- **Dynamic Feedback:** Inform users of issues like insufficient fruits or funds.
- **Responsive UI:** Designed with Blazor and Bootstrap for a modern, responsive interface.
- **Unit Testing:** Ensures the functionality of the application through automated tests.

---

## Technologies Used

- **Frontend Framework:** Blazor (.NET)
- **Styling:** Bootstrap CSS framework
- **Backend Logic:** C# with .NET framework
- **Unit Testing:** xUnit

---

## File Structure

```
LemonadeStandApp
├── Pages
│   └── Index.razor       // Main application page
├── Services
│   └── FruitPressService // Business logic for juice production
├── Shared
│   ├── Entities
│   │   ├── Fruit.cs      // Represents fruit
│   │   ├── Recipe.cs     // Represents juice recipe
│   │   └── FruitPressResult.cs // Represents the result of production
│   ├── Interfaces
│   │   ├── IFruit.cs     // Interface for fruit
│   │   ├── IRecipe.cs    // Interface for recipe
│   │   └── IFruitPressService.cs // Interface for service
├── Tests
│   └── FruitPressServiceTests.cs // Unit tests for the service
└── Program.cs             // Application entry point
```

---

## How to Run

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/your-repo/lemonade-stand.git
   ```

2. **Navigate to the Project Directory:**

   ```bash
   cd lemonade-stand
   ```

3. **Build the Project:**

   ```bash
   dotnet build
   ```

4. **Run the Application:**

   ```bash
   dotnet run
   ```

5. **Access the Application:** Open a browser and navigate to `http://localhost:5000`.

---

## Testing

- Run unit tests using xUnit:
  ```bash
  dotnet test
  ```

---

## Key Design Choices

1. **Clean Architecture:**

   - Separated business logic (`FruitPressService`) from UI and data layers for scalability and maintainability.

2. **SOLID Principles:**

   - Applied principles like Single Responsibility, Dependency Inversion, and Open/Closed.

3. **Dynamic Inventory:**

   - Users can input fruit inventory at runtime, ensuring flexibility.

4. **Feedback Mechanism:**

   - Users are informed dynamically about errors or success, enhancing user experience.

---

## Improvements and Future Enhancements

1. **Database Integration:**
   - Store recipes and inventory in a database for persistence.
2. **API Integration:**
   - Connect the app to an external API for real-time inventory updates.
3. **Advanced UI:**
   - Add animations and improved styling for a better user experience.
4. **Localization:**
   - Support multiple languages for a wider audience.

---

## License

This project is licensed under the MIT License. See the LICENSE file for more details.

