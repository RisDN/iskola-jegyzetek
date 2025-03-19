using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szeged
{
    internal class Program
    {
                
        static List<Megallo> megallok = new List<Megallo>();


        static void Main(string[] args) {

            StreamReader reader = new StreamReader(@"szegedCLI_adatok.csv");
            while(!reader.EndOfStream)
            {
                megallok.Add(new Megallo(reader.ReadLine()));
            }

            Console.WriteLine("3. feladat: Szegeden " + megallok.Count + " darab megálló található.");

            int trolik = megallok.FindAll(m => m.Tipus.Equals("troli")).Count();
            Console.WriteLine("4. feladat: Szegedi troli megállok száma: " + trolik);

            var jaratok = megallok.GroupBy(m => m.Jaratszam);

            foreach(var item in jaratok)
            {
                int megallok = GetMegallokSzama(item.Key);
                Console.WriteLine("Járatszám: " +  item.Key +  " megállók száma:" + megallok + " db");
            }

            Console.WriteLine("5. feladat: ");

        }

        private static int GetMegallokSzama(string jaratszam)
        {
            int jaratok = 0;
            foreach (Megallo m in megallok)
            {
                if(m.Jaratszam.Equals(jaratszam))
                {
                    jaratok++;
                }
            }

            return jaratok;
        }
    }
}
