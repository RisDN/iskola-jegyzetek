using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_241202
{
    internal class Author
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set {
                if(value.Length < 3 || value.Length > 32)
                {
                    throw new Exception("A vezetéknévnek 3 és 32 karakter között kell lennie! Megadott: " + value + " (" + value.Length + ")");
                }
                firstName = value;
            } }
        public string LastName { get => lastName; set {
                if (value.Length < 3 || value.Length > 32)
                {
                    throw new Exception("A keresztnévnek 3 és 32 karakter között kell lennie! Megadott: " + value + " (" + value.Length + ")");
                }

                lastName = value;
            } }
        public Guid GUID { get; set; }

      
        public Author(string name)
        {
            string[] names = name.Split(' ');
            if (names.Length != 2)
            {
                throw new Exception("A névnek két részből kell állnia! Megadott:" + name);
            }
            FirstName = names[0];
            LastName = names[1];
            GUID = Guid.NewGuid();
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }


    }
}
