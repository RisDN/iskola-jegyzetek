using System;
using System.Collections.Generic;

namespace keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KeresztrejtvenyRacs rejtveny = new KeresztrejtvenyRacs("kr2.txt");

            Console.WriteLine("5. feladat: A keresztrejtvény mérete:");
            Console.WriteLine("\tSorok száma: " + rejtveny.SorokDb);
            Console.WriteLine("\tOszlopok száma: " + rejtveny.OszlopokDb);

            Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
            rejtveny.Show();

            Console.WriteLine($"7. feladat: A leghosszabb függ.: {rejtveny.LeghosszabbFuggolegesSzo()} karakter");

            Console.WriteLine("8. feladat: Vízszintes szavak statisztikája:");

            Dictionary<int, int> statisztika = rejtveny.Statisztika();

            for (int i = 2; i <= rejtveny.OszlopokDb; i++)
            {
                if (!statisztika.ContainsKey(i))
                {
                    continue;
                }

                Console.WriteLine($"\t{i} betűs: {statisztika[i]}");
            }

            Console.ReadKey();
        }
    }
}
