using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szeged
{
    internal class Megallo
    {
        public string Jaratszam;
        public string Vegallomasok;
        public string MegalloNeve;
        public string Tipus;
        public Megallo(string sor)
        {
            string[] splitted = sor.Split(';');
            Jaratszam = splitted[0];
            Vegallomasok = splitted[1];
            MegalloNeve = splitted[2];
            Tipus = splitted[3];

        }
    }
}
