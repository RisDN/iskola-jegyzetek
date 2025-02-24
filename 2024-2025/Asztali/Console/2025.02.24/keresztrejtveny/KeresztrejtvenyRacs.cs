using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {


        private List<string> Adatsorok = new List<string>();
        private char[,] Racs;
        private int[,] Sorszamok;

        public int OszlopokDb { get; set; }
        public int SorokDb { get; set; } 


        public KeresztrejtvenyRacs(string forras)
        {
            BeolvasAdatsorok(forras);
        }

        public int LeghosszabbFuggolegesSzo()
        {
            int max = -1;
            for(int oszlop = 0; oszlop < OszlopokDb -1; oszlop++) { 
  
                for(int sor = 0; sor < SorokDb -1; sor++)
                {
                    Console.WriteLine($"[{oszlop}:{sor}]"); // ezen a ponton menjünk el lefele ameddig az oszlop tart
                    int lementdarab = 0;
                    for(int x = oszlop; x < OszlopokDb -1; x++)
                    {
              
                        Console.WriteLine($"Lefelé: [{oszlop}:{x}]");
                        if (Racs[oszlop, x].Equals('#'))
                        {
                            Console.WriteLine("Lement " + lementdarab + "x alkalommal");
                            continue;
                        }
                        lementdarab++;

                        if (lementdarab > max)
                        {
                            max = lementdarab;
                        }

                    }
                }

            }

            return max;
        }

        public void Show()
        {
            for (int i = 0; i < OszlopokDb; i++)
            {
                for (int y = 0; y < SorokDb; y++)
                {
                    string character = "";

                    if (Racs[i, y].Equals('-')) {
                        character = "[]";
                    } else if (Racs[i, y].Equals('#'))
                    {
                        character = "##";
                    }

                    Console.Write(character);
                }
                Console.Write("\n");
            }
        }

        public void BeolvasAdatsorok(string forras)
        {

            StreamReader reader = new StreamReader(@forras);
            int lines = 0;
            while(!reader.EndOfStream)
            {
                lines++;
                Adatsorok.Add(reader.ReadLine());
            }
            int lineLength = Adatsorok[0].Length;

            OszlopokDb = lineLength;
            SorokDb = lines;

            Racs = new char[OszlopokDb, SorokDb];
            Sorszamok = new int[OszlopokDb, SorokDb];

            Console.WriteLine($"{OszlopokDb}x{SorokDb}");

            FeltoltRacs();
        }

        public void FeltoltRacs()
        {
            Console.WriteLine("oszlopok: " + OszlopokDb);
            Console.WriteLine("sorok: " + SorokDb);
            for(int i = 0; i < OszlopokDb; i++)
            {

                string line = Adatsorok[i];
                for (int y = 0; y < SorokDb; y++)
                {
  
                    char[] chars = line.ToCharArray();

                    foreach(char character in chars)
                    {
                        Racs[i, y] = character;
                    }

                }
            }

        }

    }
}
