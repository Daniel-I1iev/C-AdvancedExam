namespace CocktailBar
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository (CocktailBar)
            Menu cocktailMenu = new Menu(5);

            // Initialize entities (Cocktails)
            Cocktail mojito = new Cocktail("Mojito", 8.50m, 200, "White Rum, Soda Water, Fresh Mint, Lime, Brown Sugar");
            Cocktail fakeMojito = new Cocktail("Mojito", 18.50m, 180, "Red Rum, Soda Water, Fresh Mint, Lime, Brown Sugar");
            Cocktail pinaColada = new Cocktail("Pina Colada", 7.00m, 150, "White Rum, Coconut Cream, Pineapple Juice");
            Cocktail sexOnTheBeach = new Cocktail("Sex On The Beach", 11.00m, 200, "Vodka, Peach Schnapps, Orange Juice, Cranberry Juice, Glase Cherry");
            Cocktail margarita = new Cocktail("Margarita", 10.50m, 150, "Tequila, Triple Sec, Lime Juice, Salt");
            Cocktail dryMartini = new Cocktail("Dry Martini", 7.50m, 120, "Gin, Vermouth");
            Cocktail longIsland = new Cocktail("Long Island", 13.00m, 300, "Vodka, Tequilla, White Rum, Cointreau, Gin, Lemon Juice, Cola");

            // Adding cocktails to the repository
            cocktailMenu.AddCocktail(mojito);
            cocktailMenu.AddCocktail(fakeMojito); // Should not be added due to duplicate name
            cocktailMenu.AddCocktail(pinaColada);
            cocktailMenu.AddCocktail(sexOnTheBeach);
            cocktailMenu.AddCocktail(margarita);
            cocktailMenu.AddCocktail(dryMartini); // Bar is now full

            // Trying to add cocktail beyond capacity
            cocktailMenu.AddCocktail(longIsland); // Should not be added

            // Removing cocktails from the repository
            Console.WriteLine(cocktailMenu.RemoveCocktail("Long Island")); // False
            Console.WriteLine(cocktailMenu.RemoveCocktail("Pina Colada")); // True

            // Adding cocktail after removal
            cocktailMenu.AddCocktail(longIsland);

            // Finding the cocktail with the greatest variety of ingredients
            Console.WriteLine(cocktailMenu.GetMostDiverse());

            // Getting cocktail details
            Console.WriteLine(cocktailMenu.Details("Mojito"));

            // Getting a list of all cocktails
            Console.WriteLine(cocktailMenu.GetAll());

        }
    }
}
