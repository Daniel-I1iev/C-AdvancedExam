using System;
using System.Collections.Generic;
using System.Linq;

namespace CocktailBar
{
    public class Menu
    {
        
        public List<Cocktail> Cocktails { get; private set; }
        public int BarCapacity { get; private set; }

        
        public Menu(int barCapacity)
        {
            BarCapacity = barCapacity;
            Cocktails = new List<Cocktail>();
        }

        
        public void AddCocktail(Cocktail cocktail)
        {
           
            if (Cocktails.Any(c => c.Name == cocktail.Name))
            {
                return; 
            }

            
            if (Cocktails.Count < BarCapacity)
            {
                Cocktails.Add(cocktail);
            }
        }

        
        public bool RemoveCocktail(string name)
        {
            var cocktailToRemove = Cocktails.FirstOrDefault(c => c.Name == name);
            if (cocktailToRemove != null)
            {
                Cocktails.Remove(cocktailToRemove);
                return true;
            }
            return false;
        }

        
        public Cocktail GetMostDiverse()
        {
            return Cocktails.OrderByDescending(c => c.Ingredients.Count).FirstOrDefault();
        }

       
        public string Details(string cocktailName)
        {
            var cocktail = Cocktails.FirstOrDefault(c => c.Name == cocktailName);
            return cocktail != null ? cocktail.ToString() : string.Empty;
        }

       
        public string GetAll()
        {
            var cocktailNames = Cocktails
                .OrderBy(c => c.Name)
                .Select(c => c.Name)
                .ToList();

            return "All Cocktails:\n" + string.Join("\n", cocktailNames);
        }
    }
}
