using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            for (int sor = 0; sor < SorokDb; sor++)
            {

                for (int oszlop = 0; oszlop < OszlopokDb; oszlop++)
                {

                    int lementdarab = 0;
                    for (int sorlefele = sor; sorlefele < SorokDb; sorlefele++)
                    {
                        if (Racs[oszlop, sorlefele].Equals('#'))
                        {
                            break;
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

            for (int sor = 0; sor < SorokDb; sor++)
            {
                for (int oszlop = 0; oszlop < OszlopokDb; oszlop++)
                {
                    string character = "##";
                    if (Racs[oszlop, sor].Equals('-'))
                    {
                        character = "[]";
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
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!line.Equals(""))
                {
                    lines++;
                    Adatsorok.Add(line);
                }

            }
            reader.Close();
            int lineLength = Adatsorok[0].Length;

            OszlopokDb = lineLength;
            SorokDb = lines;

            Racs = new char[OszlopokDb, SorokDb];
            Sorszamok = new int[OszlopokDb, SorokDb];

            FeltoltRacs();
        }

        public void FeltoltRacs()
        {
            int sor = 0;
            foreach (string line in Adatsorok)
            {
                List<char> charlist = line.ToCharArray().ToList();

                int oszlop = 0;
                foreach (char character in charlist)
                {
                    Racs[oszlop, sor] = character;
                    oszlop++;
                }

                Console.Write("\n");
                sor++;
            }


        }

    }
}
