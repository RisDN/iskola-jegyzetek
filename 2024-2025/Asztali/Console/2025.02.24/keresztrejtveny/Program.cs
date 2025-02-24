using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keresztrejtveny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            KeresztrejtvenyRacs rejtveny =  new KeresztrejtvenyRacs("kr1.txt");

            Console.WriteLine("rejtveny 1: ");
            rejtveny.Show();


            KeresztrejtvenyRacs rejtveny2 = new KeresztrejtvenyRacs("kr2.txt");

            Console.WriteLine("\nrejtveny 2:");
            rejtveny2.Show();


            //Console.WriteLine("5. feladat: A keresztrejtvény mérete:");
            //Console.WriteLine("\tSorok száma: " + rejtveny.SorokDb);
            //Console.WriteLine("\tOszlopok száma: " + rejtveny.OszlopokDb);

            //Console.WriteLine("6. feladat: A beolvasott keresztrejtvény");
            //rejtveny.Show();

            //Console.WriteLine($"7. feladat: A leghosszabb függ.: {rejtveny.LeghosszabbFuggolegesSzo()} karakter");

            Console.ReadKey();
        }
    }
}
