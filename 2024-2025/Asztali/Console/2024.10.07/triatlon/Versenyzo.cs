using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triatlon
{


    internal class Versenyzo
    {
        public static List<Versenyzo> versenyzos = new List<Versenyzo>();

        public string Name { get; set; }
        public DateTime BornIn { get; set; }
        public int Label { get; set; }
        public char Sex { get; set; }
        public string Category { get; set; }
        public int Age => DateTime.Now.Year - BornIn.Year;

        public TimeSpan TotalTime => SwimTime + FirstDepo + BikeTime + SecondDepo + RunTime;
        public TimeSpan TotalDepoTime => FirstDepo + SecondDepo;

        public TimeSpan SwimTime { get; set; }
        public TimeSpan FirstDepo { get; set; }
        public TimeSpan BikeTime { get; set; }
        public TimeSpan SecondDepo { get; set; }
        public TimeSpan RunTime { get; set; }

        public Versenyzo(string name, string bornIn, int label, char sex, string category, string swimTime, string firstDepo, string bikeTime, string secondDepo, string runTime)
        {
            Name = name;
            BornIn = new DateTime(int.Parse(bornIn), 1, 1, 1, 1, 1);
            Label = label;
            Sex = sex;
            Category = category;
            SwimTime = TimeSpan.Parse(swimTime);
            FirstDepo = TimeSpan.Parse(firstDepo);
            BikeTime = TimeSpan.Parse(bikeTime);
            SecondDepo = TimeSpan.Parse(secondDepo);
            RunTime = TimeSpan.Parse(runTime);

            versenyzos.Add(this);
        }

        public override string ToString()
        {
            return $"{Name} ({BornIn.ToString("yyyy")}) Idő: {TotalTime} | Kat.:{Category} | Rajtsz.: {Label}";
        }
    }
}
