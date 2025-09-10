
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KusinApp
{
    public class Recipe
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public List<string> Ingredients { get; set; }

        public Recipe(string name, string imagePath, List<string> ingredients)
        {
            Name = name;
            ImagePath = imagePath;
            Ingredients = ingredients;
        }
    }
}
