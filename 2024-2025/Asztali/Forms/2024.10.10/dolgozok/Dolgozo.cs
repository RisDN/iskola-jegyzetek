using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozok
{
    internal class Dolgozo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Sex { get; set; }


        public Dolgozo(string line)
        {
            string[] parts = line.Split(';');
            Name = parts[0];
            Age = int.Parse(parts[1]);
            City = parts[2];
            Sex = parts[3];
        }

    }
}
