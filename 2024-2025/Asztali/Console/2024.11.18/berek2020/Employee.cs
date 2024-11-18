using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek2020
{
    internal class Employee
    {
        public static List<Employee> employees = new List<Employee>();

        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Position { get; set; }
        public string SinceYear { get; set; }
        public int Salary { get; set; }

        public Employee(string name, bool sex, string position, string sinceYear, int salary)
        {
            Name = name;
            Sex = sex;
            Position = position;
            SinceYear = sinceYear;
            Salary = salary;
            employees.Add(this);
        }

        public string SexToString()
        {
            return Sex ? "férfi" : "nő";
        }
    }
}
