
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace triatlon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader(@"../../src/forras.txt");

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] splitted = line.Split(';');
                new Versenyzo(splitted[0], splitted[1], int.Parse(splitted[2]), char.Parse(splitted[3]), splitted[4], splitted[5], splitted[6], splitted[7], splitted[8], splitted[9]);

            }

            streamReader.Close();

            
            Console.WriteLine($"Összesen {Versenyzo.versenyzos.Count} versenyző fejezte be a versenyt.\n");


            int elitJuniors = Versenyzo.versenyzos.FindAll(x => x.Category == "elit junior").Count;
            Console.WriteLine($"Versenyzők száma elit junior kategóriában: {elitJuniors}\n");

            List<Versenyzo> males = Versenyzo.versenyzos.FindAll(x => x.Sex == 'f');
            int summedMaleAge = males.Sum(x => x.Age);
            double avarageMaleAge = (double)summedMaleAge / males.Count;
            Console.WriteLine($"Férfi versenyzők átlagos életkora: {avarageMaleAge}\n");

            double runForHours = Versenyzo.versenyzos.Sum(x => x.RunTime.TotalHours);
            Console.WriteLine($"A versenyzők futással töltött összideje órában: {runForHours:0.00} \n");

            List<Versenyzo> category2024 = Versenyzo.versenyzos.FindAll(x => x.Category == "20-24");
            double summedSwimTimeHours = category2024.Sum(x => x.SwimTime.TotalHours);
            double avarageSwimTimeHours = summedSwimTimeHours / category2024.Count;

            double summedSwimTimeMinutes = category2024.Sum(x => x.SwimTime.TotalMinutes);
            double avarageSwimTimeMinutes = summedSwimTimeMinutes / category2024.Count;

            double summedSwimTimeSeconds = category2024.Sum(x => x.SwimTime.Seconds);
            double avarageSwimTimeSeconds = summedSwimTimeSeconds / category2024.Count;

            Console.WriteLine($"Átlagos úszási idő '20-24'-es kategóriában: {avarageSwimTimeHours:0.0} óra {avarageSwimTimeMinutes:0.0} perc {avarageSwimTimeSeconds:0.0} másodperc\n");

            List<Versenyzo> females = Versenyzo.versenyzos.FindAll(x => x.Sex == 'n');
            Versenyzo femaleWinner = females.OrderBy(x => x.TotalTime).First();

            Console.WriteLine($"Nöi győztes: {femaleWinner}\n");

            Console.WriteLine($"A versenyt {females.Count} nő és {males.Count} férfi fejezte be.\n");

            var categories = Versenyzo.versenyzos.Select(x => x.Category).Distinct();

            Console.WriteLine("Korkategóriánként az átlag depóban töltött idő: ");
            foreach (var category in categories)
            {
                List<Versenyzo> categoryVersenyzos = Versenyzo.versenyzos.FindAll(x => x.Category == category);
                double summedDepoTime = categoryVersenyzos.Sum(x => x.TotalDepoTime.TotalMinutes);
                double avarageDepoTime = summedDepoTime / categoryVersenyzos.Count;
                Console.WriteLine($"{category}\t{avarageDepoTime:0.00} perc");
            }


            Console.ReadKey();
        }
    }
}
