using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haziallatok
{
    internal class Pet
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age => DateTime.Now.Year - BirthDate.Year;
        public bool Sex { get; set; }

    }
}
