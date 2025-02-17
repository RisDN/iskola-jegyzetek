using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace course
{

    internal enum Subject
    {
        Hálózat = 0,
        Mobil = 1,
        Frontend = 2,
        Backend = 3
    }

    internal class Student
    {
        public string Name { get; set; }
        public char Sex { get; set; }
        public int Paid { get; set; }
        public List<int> Results { get; set; }


        public Student(string name, char sex, int paid, List<int> results)
        {
            Name = name;
            Sex = sex;
            Paid = paid;
            Results = results;
        }

        public double GetAvarageResult()
        {
            return Results.Average();
        }

        public string GetLastName()
        {
            return Name.Split(' ')[1];
        }

        public int GetSubjectResult(Subject subject)
        {
            return Results[(int)subject];
        }

        public int GetResultsCombined()
        {
            return Results.Sum();
        }

        public int GetWebResults()
        {
            return GetSubjectResult(Subject.Frontend) + GetSubjectResult(Subject.Backend);
        }

        public bool IsAllPaid()
        {
            return Paid >= 2600;       
        }

        public bool Has100Percent()
        {
            return Results.Contains(100);
        }

        public bool DidFailAnySubject()
        {
            return GetFailedSubjects().Count != 0;
        }

        public List<Subject> GetFailedSubjects()
        {
            List<Subject> failedSubjects = new List<Subject>();

            foreach(Subject subject in Enum.GetValues(typeof(Subject)))
            {
                if (GetSubjectResult(subject) < 51)
                {
                    failedSubjects.Add(subject);
                }
            }

            return failedSubjects;


        }

    }
}
