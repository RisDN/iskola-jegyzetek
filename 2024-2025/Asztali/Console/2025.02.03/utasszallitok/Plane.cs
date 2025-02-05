using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utasszallitok
{
    internal class Plane
    {
        public static List<string> categories = new List<string>()
    {
        "Alacsony sebességű",
        "Szubszonikus",
        "Transzszonikus",
        "Szuperszonikus"
    };
        private static List<Plane> planes = new List<Plane>();

        public string type;
        public int year;
        public string passangers;
        public string staff;
        public int speed;
        public int weight;
        public double distance;

        public Plane(string type, int year, string passangers, string staff, int speed, int weight, double distance)
        {
            this.type = type;
            this.year = year;
            this.passangers = passangers;
            this.staff = staff;
            this.speed = speed;
            this.weight = weight;
            this.distance = distance;
            Console.WriteLine();
            planes.Add(this);
        }

        public int GetMaxPassangers()
        {
            string[] splitted = passangers.Split('-');
            if(splitted.Length == 1)
            {
                return int.Parse(splitted[0]);
            }

            return int.Parse(splitted[1]);
        }

        public int GetMaxStaff()
        {
            string[] splitted = staff.Split('-');
            if (splitted.Length == 1)
            {
                return int.Parse(splitted[0]);
            }

            return int.Parse(splitted[1]);
        }

        public string GetSpeedCategory()
        {
            if (speed < 500) return "Alacsony sebességű";
            else if (speed < 1000) return "Szubszonikus";
            else if (speed < 1200) return "Transzszonikus";
            else return "Szuperszonikus";
        }

        public static List<Plane> GetPlanes() { return new List<Plane>(planes);  }

    }
}
