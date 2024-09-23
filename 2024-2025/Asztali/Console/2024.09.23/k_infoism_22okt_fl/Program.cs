using k_infoism_22okt_fl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Program
{

     class Program
    {
        public static void Main(string[] args)
        {

            StreamReader reader = new StreamReader(@"bukkm2019.txt");

            bool isFirstLine = true;
            while (!reader.EndOfStream)
            {

                if (isFirstLine) {
                    isFirstLine = false;
                    reader.ReadLine();
                    continue;
                };

                string[] splittedLine = reader.ReadLine().Split(';');

                new Versenyzo(Rajtszam.GetRajtszam(splittedLine[0]), splittedLine[1] , splittedLine[2], splittedLine[3], DateTime.Parse(splittedLine[4]));
            }

            reader.Close();

            List<Versenyzo> versenyzos = Versenyzo.GetVersenyzok();

            // 4. feladat
            int all = 691;
            int notFinished = all - versenyzos.Count;
            double notFinishedPercent = (double)notFinished / all * 100;
            Console.WriteLine($"4. feladat: Versenytávot nem teljesítők: {notFinishedPercent}%");

            // 5. feladat
            int womanShortDistance = versenyzos.Count(k => k.rajtszam.Equals("Rövid") && k.isWoman);
            Console.WriteLine($"5. feladat: Női versenyzők száma rövid távú versenyen: {womanShortDistance} fő");

            // 6. feladat
            bool isMoreThanSixHours = versenyzos.Any(k => k.ido.Hour >= 6);
            string ismore = isMoreThanSixHours ? "Volt ilyen versenyző" : "Nem volt ilyen versenyző";   
            Console.WriteLine($"6. feladat: {ismore}");

            // 7 feladat.
            List<Versenyzo> rovidFerfi = versenyzos.Where(k => k.kategoria.Equals("ff") && k.rajtszam == "Rövid").ToList();
            Versenyzo winner = rovidFerfi.OrderBy(k => k.ido).First();
            Console.WriteLine("7. feladat: A felnőtt férfi (ff) kategória győztese rövid távon:");
            Console.WriteLine($"\tRajtszám: {winner.rajtszam}");
            Console.WriteLine($"\tNév: {winner.nev}");
            if(!winner.egyesulet.Equals(""))
            {
                Console.WriteLine($"\tEgyesület: {winner.egyesulet}");
            }
            Console.WriteLine($"\tIdő: {winner.ido.ToLongTimeString()}");

            // 8.feladat
            Console.WriteLine("8. feladat: Statisztika");
            var stat = versenyzos.GroupBy(k => k.kategoria).Select(k => new { kategoria = k.Key, count = k.Count() }).ToList();
            foreach (var item in stat)
            {
                Console.WriteLine($"\t{item.kategoria} - {item.count} fő");
            }


            Console.ReadKey();
        }   
    }

}