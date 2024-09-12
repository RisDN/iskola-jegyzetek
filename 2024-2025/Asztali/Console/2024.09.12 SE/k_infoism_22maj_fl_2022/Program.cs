namespace k_infoism_22maj_fl_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            readData();


            List<Donto> list = new List<Donto>(Donto.GetDontos());
            Console.WriteLine("4. feladat: Döntők száma: " + list.Count);

            int allPointsDifference = list.Sum(x => x.pointDifference());
            double diff = (double) allPointsDifference / list.Count;
            Console.WriteLine($"5. feladat: Átlagos pontkülönbség: {diff:0.0}");


            Donto mostSpectators = list.OrderByDescending(x => x.spectators).First();
            Console.WriteLine("6. feladat: Legmagasabb nézőszám a döntők során:");
            RomaiSorszam romaiSorszam = new RomaiSorszam(mostSpectators.roman);
            Console.WriteLine($"\tSorszám (dátum): {romaiSorszam.ArabSsz} ({mostSpectators.date:yyyy.MM.dd})");
            Console.WriteLine($"\tGyőztes csapat: {mostSpectators.winner}, szerzett pontok: {mostSpectators.winnersScore()}");
            Console.WriteLine($"\tVesztes csapat: {mostSpectators.loser}, szerzett pontok: {mostSpectators.losersScore()}");
            Console.WriteLine($"\tHelyszín: {mostSpectators.venue}");
            Console.WriteLine($"\tVáros, állam: {mostSpectators.city}");
            Console.WriteLine($"\tNézőszám: {mostSpectators.spectators}");


            StreamWriter writer = new StreamWriter(@"SuperBowlNew.txt");
            writer.WriteLine("Ssz;Dátum;Győztes;Eredmény;Vesztes;Nézőszám");
            foreach(Donto donto in list)
            {
                writer.WriteLine($"{donto.roman};{donto.date:yyyy.MM.dd};{donto.winner};{donto.points};{donto.loser};{donto.spectators}");
            }
            writer.Close();
        }


        private static void readData()
        {
            StreamReader reader = new StreamReader(@"SuperBowl.txt");

            bool isFirstLine = true;
            while (!reader.EndOfStream)
            {
                if (isFirstLine)
                {
                    isFirstLine = false;
                    reader.ReadLine();
                    continue;
                }

                string line = reader.ReadLine();
                string[] splitted = line.Split(";");
                new Donto(splitted[0], DateTime.Parse(splitted[1]), splitted[2], splitted[3], splitted[4], splitted[5], splitted[6], int.Parse(splitted[7]));
            }
        }
    }






}
