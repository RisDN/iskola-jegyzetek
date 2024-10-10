using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyosos
{
    internal class Dog
    {
        public static List<Dog> dogs = new List<Dog>();

        public string Name { get; set; }
        public string Genre { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Dog(string line)
        {
            string[] parts = line.Split(';');
            Name = parts[0];
            Genre = parts[1];
            Sex = parts[2];
            Age = int.Parse(parts[3]);

            dogs.Add(this);
        }
    }
}
