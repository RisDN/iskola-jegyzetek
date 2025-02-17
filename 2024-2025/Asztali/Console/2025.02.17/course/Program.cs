using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            StreamReader reader = new StreamReader(@"course.txt");

            while(!reader.EndOfStream)
            {
                string[] splitted = reader.ReadLine().Split(';');

                List<int> results = new List<int>();

                results.Add(int.Parse(splitted[3]));
                results.Add(int.Parse(splitted[4]));
                results.Add(int.Parse(splitted[5]));
                results.Add(int.Parse(splitted[6]));

                students.Add(new Student(splitted[0], char.Parse(splitted[1]), int.Parse(splitted[2]), results));

            }

            reader.Close();

            Console.WriteLine($"1. feladat: {students.Count} db hallgató adatait tartalmazza a fájl.");

            double avarageBackendResult = students.Average(k => k.GetSubjectResult(Subject.Backend));

            Console.WriteLine($"2. feladat: {avarageBackendResult}% az átlag Backend fejlesztésből.");

            Student bestStudent = students.OrderByDescending(k => k.GetResultsCombined()).FirstOrDefault();

            Console.WriteLine($"3. feladat: Az osztályelső diák neve: {bestStudent.Name}");

            int maleCount = students.Count(k => k.Sex == 'm');
            double percent =  (maleCount / ((double)students.Count)) * 100;

            Console.WriteLine($"4. feladat: Férfiak aránya a képzésen: {maleCount}/{students.Count} ({percent}%)");

            List<Student> females = students.FindAll(k => k.Sex == 'f');

            Student bestFemaleWeb = females.OrderByDescending(k => k.GetWebResults()).FirstOrDefault();

            Console.WriteLine($"5. feladat: {bestFemaleWeb.Name} a legjobb a nők között webfejlesztésből.");

            List<Student> alreadyPaidAll = students.FindAll(k => k.IsAllPaid());

            Console.WriteLine("6. feladat: Ők már befizették a teljes tanfolyam díjat:");
            foreach (Student student in alreadyPaidAll)
            {
                Console.WriteLine($"\t- {student.Name}");
            }

            Console.Write("7. feladat: Kérem adja meg egy diák nevét: ");

            string input = Console.ReadLine();

            Student searchedStudent = students.Find(k => k.Name.ToLower() == input.ToLower());

            if(searchedStudent == null)
            {
                Console.WriteLine($"Nem található diák {input} névvel.");
            } else
            {
                Console.WriteLine($"Javító vizsgát kell {searchedStudent.Name}-nek/nak tennie a következő tantárgyakból:");
                foreach(Subject subject in searchedStudent.GetFailedSubjects())
                {
                    Console.WriteLine($"\t- {subject.ToString()}");
                }
            }

            int perfectStudents = students.Count(k => k.Has100Percent() && k.DidFailAnySubject());

            Console.WriteLine($"8.feladat: {perfectStudents} db diák van akik egy modulból 100%-ot teljesítettek, és egyik modulból sem kell javítóvizsgát tenniük:");

            Dictionary<Subject, int> fails = new Dictionary<Subject, int>();

            foreach (Subject subject in Enum.GetValues(typeof(Subject)))
            {
                foreach(Student student in students)
                {
                    if(student.GetFailedSubjects().Contains(subject))
                    {
                        if(fails.ContainsKey(subject))
                        {
                            fails[subject] = fails[subject] + 1;
                            continue;
                        }

                        fails.Add(subject, 1);

                    }
                }
            }

            Console.WriteLine("9. feladat: Modulonkénti javítóvizsgák száma:");

            foreach(var fail in fails)
            {
                Console.WriteLine($"\t- {fail.Key}: {fail.Value} db");
            }

            List<Student> orderedByLastName = students.OrderBy(k => k.GetLastName()).ToList();

            StreamWriter writer = new StreamWriter(@"output.txt");

            foreach(Student student in orderedByLastName)
            {
                writer.WriteLine($"{student.GetLastName()}: {student.GetAvarageResult()}%");
            }

            Console.WriteLine("10. feladat: A családnév alapján ABC sorrendbe rendezett diákok átlageredménye az output.txt fájlba lett írva.");
            writer.Close();
            Console.ReadKey();
        }
    }
}
