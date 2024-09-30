using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240930_vizsgateszt
{
    internal class Recipe
    {

        public static List<Recipe> Recipes = new List<Recipe>();    

        public string Name { get; set; }
        public int TimeToMake { get; set; }
        public string Type { get; set; }
        public string Difficulty { get; set; } 
        public bool IsShort => TimeToMake <= 65;


        public Recipe(string line)
        {
            string[] splitted = line.Split(';');

            Name = splitted[0];
            TimeToMake = int.Parse(splitted[1]);
            Type = splitted[2];
            Difficulty = splitted[3];


            Recipes.Add(this); 
        }
    }
}
