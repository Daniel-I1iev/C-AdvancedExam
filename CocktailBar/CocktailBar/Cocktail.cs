using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBar
{
    public class Cocktail
    {
       
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public double Volume { get; private set; }
        public List<string> Ingredients { get; private set; }

        
        public Cocktail(string name, decimal price, double volume, string ingredients)
        {
            Name = name;
            Price = price;
            Volume = volume;
            Ingredients = ingredients.Split(", ").ToList();
        }

       
        public override string ToString()
        {
            string ingredientsList = string.Join(", ", Ingredients);
            return $"{Name}, Price: {Price:F2} BGN, Volume: {Volume} ml\nIngredients: {ingredientsList}";
        }
    }
}
