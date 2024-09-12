using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k_infoism_22maj_fl_2022
{
    internal class Donto
    {

        private static List<Donto> dontok = new List<Donto>();

        public string roman { get; set; }
        public DateTime date { get; set; }
        public string winner { get; set; }
        public string points { get; set; }
        public string loser { get; set; }
        public string venue { get; set; }
        public string city { get; set; }
        public int spectators { get; set; }

        public Donto(string roman, DateTime date, string winner, string points, string loser, string venue, string city, int spectators)
        {
            this.roman = roman;
            this.date = date;
            this.winner = winner;
            this.points = points;
            this.loser = loser;
            this.venue = venue;
            this.city = city;
            this.spectators = spectators;

            dontok.Add(this);
        }

        public static List<Donto> GetDontos()
        {
            return dontok;
        }

        public int pointDifference()
        {
            return Math.Abs(int.Parse(points.Split("-")[0]) - int.Parse(points.Split("-")[1]));
        }

        public int winnersScore()
        {
            string[] splitted = points.Split("-");
            return int.Parse(splitted[0]);
        }

        public int losersScore()
        {
            string[] splitted = points.Split("-");
            return int.Parse(splitted[1]);
        }
    }
}
