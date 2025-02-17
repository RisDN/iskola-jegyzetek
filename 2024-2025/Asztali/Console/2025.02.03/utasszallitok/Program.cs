using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader(@"utasszallitok.txt");
            streamReader.ReadLine();

            while (!streamReader.EndOfStream) {
                string line = streamReader.ReadLine();
                string[] lines = line.Split(';');
                new Plane(lines[0], int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]), int.Parse(lines[5]), double.Parse(lines[6]));
            };
            streamReader.Close();

            Console.WriteLine("4. feladat: Adatsorok száma: " + Plane.GetPlanes().Count);
            int boeings = Plane.GetPlanes().FindAll(x => x.type.Contains("Boeing")).Count;
            Console.WriteLine("5. feladat: Boeing típúsok száma: " + boeings);

            Plane maxPassangers = Plane.GetPlanes().OrderByDescending(x => x.GetMaxPassangers()).FirstOrDefault();

            Console.WriteLine("6. feladat: A legtöbb utast szállító repülőgéptípús: ");
            Console.WriteLine($"\tTípús: {maxPassangers.type}");
            Console.WriteLine($"\tElső felszállás: {maxPassangers.year}");
            Console.WriteLine($"\tUtasok száma: {maxPassangers.passangers}");
            Console.WriteLine($"\tSzemélyzet: {maxPassangers.staff}");
            Console.WriteLine($"\tUtazósebesség: {maxPassangers.speed}");

            Dictionary<string, bool> categories = new Dictionary<string, bool>();

            foreach (string category in Plane.categories) {
                categories.Add(category, true);
            }

            foreach (Plane plane in Plane.GetPlanes())
            {
                foreach (string category in Plane.categories)
                {
                    if (plane.GetSpeedCategory().Equals(category))
                    {
                        categories[category] = false;
                    }
                }
            }

            string categoriesWithTrue = "";
            foreach (string category in categories.Keys) {
                if (categories.ContainsKey(category)) {
                    if (categories[category])
                    {
                        categoriesWithTrue += category + ",";
                    }
                };
            }

            Console.WriteLine("7. feladat: ");
            Console.WriteLine($"\t{categoriesWithTrue.Substring(0, categoriesWithTrue.Length - 1)}");


            StreamWriter streamWriter = new StreamWriter(@"utasszallitok_new.txt");
            streamWriter.WriteLine("típús;év;utas;személyzet;utazósebesség;felszállótömeg;fesztáv");

            foreach (Plane plane in Plane.GetPlanes())
            {

                streamWriter.WriteLine($"{plane.type};{plane.year};{plane.GetMaxPassangers()};{plane.GetMaxStaff()};{plane.weight / 1000};{plane.distance * 3.2808}");

            }
            streamWriter.Close();


            Console.ReadKey();
        }
    }
}
