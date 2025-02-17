using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barlangok
{
    internal class Program
    {
        static void Main(string[] args)
        {


            StreamReader streamReader = new StreamReader("barlangok.txt");
            bool isFirstLine = true;
            while (!streamReader.EndOfStream)
            {
                if(isFirstLine)
                {
                    streamReader.ReadLine();
                    isFirstLine = false;
                    continue;
                }
                string[] line = streamReader.ReadLine().Split(';');
                Cave cave = new Cave(int.Parse(line[0]), line[1], int.Parse(line[2]), int.Parse(line[3]), line[4], line[5]);
            }

            streamReader.Close();

            List<Cave> caves = Cave.GetCaves();

            Console.WriteLine("4. feladat: Barlangok száma: " + caves.Count);

            double avargeDepth = caves.FindAll(c => c.Location.Contains("Miskolc")).Average(c => c.Depth);
            Console.WriteLine("5. feladat: Az átlagos mélység: " + Math.Round(avargeDepth, 3) + " m");

            Console.Write("6. feladat: Kérem a védettségi szintet: ");
            string protectionLevel = Console.ReadLine();
            List<Cave> inProtectionLevel = caves.FindAll(c => c.Protection == protectionLevel);

            if(inProtectionLevel.Count == 0)
            {
                Console.WriteLine("\tNincs ilyen védettségi szinttel barlang az adatok között!");
            }
            else
            {
                Cave longest = inProtectionLevel.OrderByDescending(c => c.Length).First();
                Console.WriteLine($"\tAzon: {longest.ID}");
                Console.WriteLine($"\tNév: {longest.Name}");
                Console.WriteLine($"\tHossz: {longest.Length} m");
                Console.WriteLine($"\tMélység: {longest.Depth} m");
                Console.WriteLine($"\tTelepülés: {longest.Location}");
            }

            Console.WriteLine("7. feladat: Statisztika");
            var statistics = caves.GroupBy(c => c.Protection).Select(c => new { Protection = c.Key, Count = c.Count() }).OrderBy(c => c.Protection);
            foreach (var item in statistics)
            {
                Console.WriteLine($"\t{item.Protection} ---------> {item.Count} db");
            }
            
            Console.ReadKey();
        }
    }
}
