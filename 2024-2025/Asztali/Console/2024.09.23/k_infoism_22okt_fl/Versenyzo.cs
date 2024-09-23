using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_infoism_22okt_fl
{
    internal class Versenyzo
    {

        private static List<Versenyzo> versenyzok = new List<Versenyzo>();  

        public string rajtszam { get; set; }
        public string kategoria { get; set; }
        public string nev { get; set; }
        public string egyesulet { get; set; }
        public DateTime ido { get; set; }

        public bool isWoman { get; set; }


        public Versenyzo(string rajtszam, string kategoria, string nev, string egyesulet, DateTime ido)
        {
            this.rajtszam = rajtszam;
            this.kategoria = kategoria;
            this.nev = nev;
            this.egyesulet = egyesulet;
            this.ido = ido;
            this.isWoman = kategoria.Last() == 'n';
            versenyzok.Add(this);
        }


        public static List<Versenyzo> GetVersenyzok()
        {
            return versenyzok;
        }

    }
}
