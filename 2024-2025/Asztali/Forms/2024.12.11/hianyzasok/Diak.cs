using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hianyzasok
{
    internal class Diak
    {
        public static List<Diak> diakok = new List<Diak>();

        public string Nev { get; set; }
        public string Osztaly { get; set; }
        public int Hanyadika { get; set; }
        public int Igazolt { get; set; }
        public int NemIgazolt { get; set; }

        public Diak(string nev, string osztaly, int hanyadika, int igazolt, int nemIgazolt)
        {
            Nev = nev;
            Osztaly = osztaly;
            Hanyadika = hanyadika;
            Igazolt = igazolt;
            NemIgazolt = nemIgazolt;

            diakok.Add(this);
        }

        public int NapiHianyzasSzamolas()
        {
            return Igazolt + NemIgazolt;
        }


        public static void Load()
        {
            StreamReader sr = new StreamReader("szeptember.txt");
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                string[] sor = sr.ReadLine().Split(';');
                new Diak(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3]), int.Parse(sor[4]));
            }
            sr.Close();
        }

        public static void Save()
        {
            StreamWriter sw = new StreamWriter("szeptember.txt");
            sw.WriteLine("Név;Osztály;Hányadik;Igazolt;Nem igazolt");
            foreach (Diak d in diakok)
            {
                sw.WriteLine($"{d.Nev};{d.Osztaly};{d.Hanyadika};{d.Igazolt};{d.NemIgazolt}");
            }
            sw.Close();
        }

    }
}
