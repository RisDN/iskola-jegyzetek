using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
