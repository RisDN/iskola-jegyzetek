
using System.Globalization;

namespace NASAKeresek
{

    internal class Keres
    {
        private static List<Keres> keresek = new List<Keres>();

        public string Cim { get; set; }
        public DateTime Ido { get; set; }
        public string Kep { get; set; }
        public int Kod { get; set; }
        public int? Meret { get; set; }

        public bool Domain => !char.IsNumber(Cim[^1]);

        public Keres(string line)
        {
            string[] splitted = line.Split("*");
            Cim = splitted[0];

            Ido = DateTime.ParseExact(splitted[1], "dd/MMM/yyyy:HH:mm:ss", CultureInfo.InvariantCulture);
            Kep = splitted[2];

            string[] splitted2 = splitted[3].Split(" ");
            Kod = int.Parse(splitted2[0]);
            Meret = splitted2[1] == "-" ? null : int.Parse(splitted2[1]);

            keresek.Add(this);
        }

        public static List<Keres> GetKeresek()
        {
            return keresek;
        }
    }
}
