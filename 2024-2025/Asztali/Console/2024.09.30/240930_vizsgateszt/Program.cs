
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _240930_vizsgateszt
{
    internal class Program
    {

        private static Random rnd = new Random();

        public static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader(@"szakacskonyvCLI_adatok.csv");

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                new Recipe(line);
            }


            Console.WriteLine($"3. feladat: Az állományban {Recipe.Recipes.Count} recept szerepel.");

            int longRecipes = Recipe.Recipes.Count(x => x.IsShort);
            Console.WriteLine($"4. feladat: A receptek között {longRecipes} darab 65 percnél rövidebb elkészítési idejű recept van.");

           
            Console.WriteLine("5. feladat: Receptek száma étel fajtánként: ");

            Dictionary<string, int> typesCount = Recipe.Recipes.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());

            foreach (var type in typesCount)
            {
                Console.WriteLine($"\t{type.Key}: {type.Value} db");
            }

            List<Recipe> easyRecipes = Recipe.Recipes.Where(x => x.Difficulty == "könnyű").ToList();
            Recipe randomEasyRecipe = easyRecipes[rnd.Next(easyRecipes.Count)];


            Console.WriteLine($"6. feladat: Az egyik könnyen elkészíthető élel: {randomEasyRecipe.Name}");

            Console.ReadKey();
        }

    }
}
