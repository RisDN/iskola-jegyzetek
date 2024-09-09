namespace NASAKeresek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"NASAlog.txt");
            string line;
            while((line = reader.ReadLine()) != null) 
            {
                new Keres(line);
            }

            List<Keres> keresek = Keres.GetKeresek();
            
            Console.WriteLine("5. feladat: Kérések száma: " + keresek.Count);

            int? sizeSum = keresek.Sum(k => k.Meret);

            Console.WriteLine("6. feladat: Válaszok összes mérete: " + sizeSum.ToString() + " byte");

            int hasDomain = keresek.Count(k => k.Domain);
            Console.WriteLine($"7. feladat: domain-es kérések: {hasDomain / (float) keresek.Count * 100:0.00}%");

            var stats = keresek.GroupBy(k => k.Kod);
            Console.WriteLine("9. feladat: statisztika");
            foreach(var stat in stats)
            {
                Console.WriteLine($"\t{stat.Key}: {stat.Count()} db");
            }

        }
    }
}