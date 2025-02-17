using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakkfeladvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("7. feladat:");
            Console.Write("Kérem a tábla sorainak a számát: 5");
            Console.Write("Kérem a tábla oszlopainak számát: 6");
            Console.WriteLine("\n9. feladat");

            int sor = 5;
            int oszlop = 6;
            Riddle riddle = new Riddle(sor, oszlop);

            riddle.TablaKiir();
            riddle.MegoldasokKeresese(0);

            int[,] matrix = new int[10, 10];

            matrix[0, 0] = 12;

            int[][] d = new int[10][];
            d[0] = new int[10];
            d[0][9] = 12;

            Console.WriteLine("9. feladat:");

            Console.ReadKey();

        }
    }
}
