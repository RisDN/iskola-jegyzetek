using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barlangok
{
    internal class Cave
    {

        private static List<Cave> caves = new List<Cave>();

        public int ID { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public int Depth { get; set; }
        public string Location { get; set; }
        public string Protection { get; set; }  


        public Cave(int iD, string name, int length, int depth, string location, string protection)
        {
            ID = iD;
            Name = name;
            Length = length;
            Depth = depth;
            Location = location;
            Protection = protection;

            caves.Add(this);
        }

        public override string ToString()
        {
            return $"({ID}) {Name} {Length} hosszúságú, {Depth} mélységű, {Location}, {Protection}";
        }

        public static List<Cave> GetCaves()
        {
            return new List<Cave>(caves);
        }
    }
}
