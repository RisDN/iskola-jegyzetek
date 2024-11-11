
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace halak
{
    internal class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {

            List<Fish> list = new List<Fish>();
            List<string> species = new List<string>();

            species.Add("Busa");
            species.Add("Keszeg");
            species.Add("Ponty");

            for (int i = 0; i < 100; i++)
            {
               
                bool predator = rnd.Next(0, 100) < 90;
                float weight = (float) rnd.NextDouble() * 39.5f + 0.5f;
                int top = rnd.Next(0, 400);
                int depth = rnd.Next(10, 400);
                string speciesName = species[rnd.Next(0, species.Count)];   
                list.Add(new Fish(weight, predator, top, depth, speciesName));

            }

            int predatorCount = list.FindAll(k => k.Predator).Count;
            int nonPredatorCount = list.Count - predatorCount;
            int canSwimUnder110 = list.FindAll(k => k.Depth > 110).Count;

            Console.WriteLine($"Húsevő halak száma: {predatorCount}");
            Console.WriteLine($"Növényevő halak száma: {nonPredatorCount}");
            Console.WriteLine($"110 cm-nél mélyebben úszó halak száma: {canSwimUnder110}");

            for (int i = 0; i < 100; i++)
            {
                Fish fish1 = list[rnd.Next(0, list.Count)];
                Fish fish2 = list[rnd.Next(0, list.Count)];

                if(fish1 == fish2)
                {
                    continue;
                }

                if (fish1.Predator == fish2.Predator)
                {
                    continue;
                }

                if(!((fish1.Predator && !fish2.Predator) || (!fish1.Predator && fish2.Predator))) {
                    continue;
                }
                Fish preadtor = fish1.Predator ? fish1 : fish2;
                Fish nonPredator = fish1.Predator ? fish2 : fish1;

               
                if(nonPredator.Top >= preadtor.Top && nonPredator.Top <= preadtor.Top + preadtor.Depth)
                {
                    continue;
                }

                bool eat = rnd.Next(0, 100) < 30;

                if(eat)
                {
                    list.Remove(nonPredator);
                    //preadtor.Weight += 2;
                    Console.WriteLine(preadtor + " megette: " + nonPredator);
                }


            }



            Console.ReadKey();
        }
    }
}
