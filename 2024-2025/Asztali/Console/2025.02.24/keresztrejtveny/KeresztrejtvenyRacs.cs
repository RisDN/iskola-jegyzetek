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

        public Dictionary<int, int> Statisztika()
        {
            int kezdoszo = -1;
            Dictionary<int, int> talalatok = new Dictionary<int, int>();
            for (int sor = 0; sor < SorokDb; sor++)
            {

                for (int oszlop = 0; oszlop < OszlopokDb; oszlop++)
                {
                    char character = Racs[oszlop, sor];

                    if (character.Equals('#') && kezdoszo != -1)
                    {
                        int lepesek = oszlop - kezdoszo;

                        if (!talalatok.ContainsKey(lepesek))
                        {
                            talalatok.Add(lepesek, 0);
                        }

                        talalatok[lepesek]++;
                        kezdoszo = -1;
                        continue;
                    }
                    if (kezdoszo == -1 && !character.Equals('#'))
                    {
                        kezdoszo = oszlop;
                    }
                }
                if (kezdoszo != -1)
                {
                    int lepesek = OszlopokDb - kezdoszo;

                    if (!talalatok.ContainsKey(lepesek))
                    {
                        talalatok.Add(lepesek, 0);
                    }

                    talalatok[lepesek]++;
                }
                kezdoszo = -1;
            }

            return talalatok;
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
