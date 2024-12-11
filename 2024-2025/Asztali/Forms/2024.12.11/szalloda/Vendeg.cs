using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szalloda
{
    internal class Vendeg
    {
        public static List<Vendeg> vendegek = new List<Vendeg>();

        public string Nev { get; set; }
        public int EjszakakSzama { get; set; }
        public int VendegekSzama { get; set; }
        public string EllatasTipusa { get; set; }

        public Vendeg(string nev, int ejszakakSzama, int vendegekSzama, string ellatasTipusa)
        {
            Nev = nev;
            EjszakakSzama = ejszakakSzama;
            VendegekSzama = vendegekSzama;
            EllatasTipusa = ellatasTipusa;

            vendegek.Add(this);
        }

        public int VendegEjszakakSzamitas()
        {
            return EjszakakSzama * VendegekSzama;
        }

        public static void Load()
        {
            StreamReader streamReader = new StreamReader("vendegek.txt");
            while (!streamReader.EndOfStream)
            {
                string[] sor = streamReader.ReadLine().Split(';');
                new Vendeg(sor[0], int.Parse(sor[1]), int.Parse(sor[2]), sor[3]);
            }
            streamReader.Close();
        }

        public static void Save()
        {
            StreamWriter streamWriter = new StreamWriter("vendegek.txt");
            foreach (Vendeg vendeg in vendegek)
            {
                streamWriter.WriteLine($"{vendeg.Nev};{vendeg.EjszakakSzama};{vendeg.VendegekSzama};{vendeg.EllatasTipusa}");
            }
            streamWriter.Close();
        }

    }
}
