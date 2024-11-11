using System;

namespace halak
{
    internal class Fish
    {
        private int top;
        private int depth;
        private float weight;
        private bool weightIsSet = false;

        public float Weight { 
            get => weight;
            set {

                if(value > 40.0 || value < 0.5)
                {
                    throw new Exception($"A hal 'weight' ({value}) értékének 0.5 és 40.0 között kell lennie.");
                }

                if (weightIsSet && (value < weight * 0.9 || value > weight * 1.1))
                {
                    throw new Exception($"A hal 'weight' ({value}) értékének a korábbi érték 10%-a között kell lennie.");
                }
                weightIsSet = true;
                weight = value; 
            }
        }
        public bool Predator { get; }
        public int Top { 
            get => top;
            set
            {
                if (value > 400 || value < 0)
                {
                    throw new Exception($"A hal 'top' ({value}) értékének 0 és 400 között kell lennie.");
                }
                top = value;
            }
        }
        public int Depth { 
            get => depth;
            set
            {
                if (value > 400 || value < 10)
                {
                    throw new Exception($"A hal 'depth' ({value}) értékének 10 és 400 között kell lennie.");
                }

                depth = value;
            }
        }
        public string Species { get; set; }


        public override string ToString()
        {
            return $"{Species} ({(Predator ? "Húsevő" : "Növényevő")}) [{Top} - {Top+Depth} cm] {Weight} kg";
        }

        public Fish(float weight, bool predator, int top, int depth, string species)
        {
            Weight = weight;
            Predator = predator;
            Top = top;
            Depth = depth;
            Species = species ?? throw new ArgumentNullException(nameof(species));
        }
    }
}
