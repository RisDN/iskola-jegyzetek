using System;
using System.Collections.Generic;

namespace homerseklet
{
    internal class Meres
    {
        public static List<Meres> meresek = new List<Meres>();

        public int Azonosito { get; set; }
        public string Varos { get; set; }
        public string Napszak { get; set; }
        public DateTime Datum { get; set; }
        public double Homerseklet { get; set; }
        public int Csapadek { get; set; }

        public Meres(int azonosito, string varos, string napszak, DateTime datum, double homerseklet, int csapadek)
        {
            Azonosito = azonosito;
            Varos = varos;
            Napszak = napszak;
            Datum = datum;
            Homerseklet = homerseklet;
            Csapadek = csapadek;

            meresek.Add(this);
        }

        public void Frissites(string varos, string napszak, DateTime datum, double homerseklet, int csapadek)
        {
            Varos = varos;
            Napszak = napszak;
            Datum = datum;
            Homerseklet = homerseklet;
            Csapadek = csapadek;

            string query = "UPDATE homerseklet " +
                $"SET varos = '{Varos}', " +
                $"napszak = '{Napszak}', " +
                $"datum = '{Datum.ToString("yyyy-MM-dd")}', " +
                $"ertek = '{Math.Round(Homerseklet, 2).ToString().Replace(',', '.')}', " +
                $"csapadek = '{Csapadek}' " +
                $"WHERE azon = {Azonosito}";

            Console.WriteLine(query);

            DatabaseConnection connection = new DatabaseConnection(query);
        }

        public static void Hozzadas(int azonosito, string varos, string napszak, DateTime datum, double homerseklet, int csapadek)
        {

            string query = "INSERT INTO homerseklet (azon, varos, napszak, datum, ertek, csapadek) VALUES (" +
                $"{azonosito}, " +
                $"'{varos}', " +
                $"'{napszak}', " +
                $"'{datum.ToString("yyyy-MM-dd")}', " +
                $"'{Math.Round(homerseklet, 2).ToString().Replace(',', '.')}', " +
                $"'{csapadek}')";

            Console.WriteLine(query);

            DatabaseConnection connection = new DatabaseConnection(query);

            new Meres(azonosito, varos, napszak, datum, homerseklet, csapadek);
        }

        public static bool LetezoAzonositoE(int azonosito)
        {
            return MeresByAzonosito(azonosito) != null;
        }

        public static Meres MeresByAzonosito(int azonosito)
        {
            foreach(Meres meres in meresek)
            {
                if(!meres.Azonosito.Equals(azonosito))
                {
                    continue;
                }

                return meres;
            }

            return null;
        }
    }
}
