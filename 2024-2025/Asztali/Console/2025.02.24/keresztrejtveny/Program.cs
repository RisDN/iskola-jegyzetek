using System;

namespace keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KeresztrejtvenyRacs rejtveny = new KeresztrejtvenyRacs("kr1.txt");

            Console.WriteLine("5. feladat: A keresztrejtvény mérete:");
            Console.WriteLine("\tSorok száma: " + rejtveny.SorokDb);
            Console.WriteLine("\tOszlopok száma: " + rejtveny.OszlopokDb);

            Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
            rejtveny.Show();

            Console.WriteLine($"7. feladat: A leghosszabb függ.: {rejtveny.LeghosszabbFuggolegesSzo()} karakter");

            Console.ReadKey();
        }
    }
}
